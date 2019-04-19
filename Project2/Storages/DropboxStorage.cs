using Dropbox.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Dropbox.Api.Files;
using Syroot.Windows.IO;
using Dropbox.Api.Stone;
using StorageHolder.Misc;
using Dropbox.Api.Sharing;

namespace StorageHolder
{
    interface IStorage
    {
        Task<List<AbstractFile>> GetList(string path);
        Task<List<AbstractFile>> GetMetadata(List<AbstractFile> List);
        Task<string> GetSharedLink(string path);
        Task Rename(string path, AbstractFile file);
        Task ShowMetadata(string path);
        Task InitializeDownload(Form OwnerForm, string path, List<AbstractFile> DownloadList);
        Task InitializeUpload(Form OwnerForm, List<AbstractFile> UploadList, string path);
        Task InitializeDelete(Form OwnerForm, List<AbstractFile> DeleteList);
        Task CreateFolder(string NewFolder);

    }

    class DropboxStorage : IStorage
    {
        DropboxClient client;

        public DropboxStorage(string ClientToken)
        {
            DropboxClient dbx = new DropboxClient(ClientToken);
            client = dbx;
        }

        public async Task Rename(string path, AbstractFile file)
        {
            using (NewFolderForm CrtFldrFrm = new NewFolderForm())
            {
                if (file.GetType() == "File")
                {
                    ConcreteFile CurrentFile = (ConcreteFile)file;
                    CrtFldrFrm.SetItemName(CurrentFile.FileName);
                    CrtFldrFrm.ShowDialog();
                    if (CrtFldrFrm.DialogResult == DialogResult.OK)
                    {
                        await client.Files.MoveAsync(new RelocationArg(CurrentFile.FilePath, path + "/" + CrtFldrFrm.FolderName));
                    }
                }
                if (file.GetType() == "Folder")
                {
                    ConcreteFolder CurrentFile = (ConcreteFolder)file;
                    CrtFldrFrm.SetItemName(CurrentFile.FolderName);
                    CrtFldrFrm.ShowDialog();
                    if (CrtFldrFrm.DialogResult == DialogResult.OK)
                    {
                        await client.Files.MoveAsync(new RelocationArg(CurrentFile.FolderPath, path + "/" + CrtFldrFrm.FolderName));
                    }
                }
            }
        }

        public async Task CreateFolder(string NewFolder)
        {
            using (NewFolderForm CrtFldrFrm = new NewFolderForm())
            {
                CrtFldrFrm.ShowDialog();
                if (CrtFldrFrm.DialogResult == DialogResult.OK)
                {
                    await client.Files.CreateFolderAsync(new CreateFolderArg(NewFolder + "/" + CrtFldrFrm.FolderName, true));
                }
            }
        }

        public async Task<string> GetSharedLink(string path)
        {
            string Result = string.Empty;
            await client.Sharing.RevokeSharedLinkAsync(path);
            IDownloadResponse<SharedLinkMetadata> sharing = await client.Sharing.GetSharedLinkFileAsync(path);
            MessageBox.Show(sharing.ToString());

            return Result;
        }

        public async Task InitializeDelete(Form OwnerForm, List<AbstractFile> DeleteList)
        {
            int count = DeleteList.Count, enumerator = 0;
            CopyProgress window = new CopyProgress("0", count.ToString());
            window.Owner = OwnerForm;
            window.Show();
            foreach (AbstractFile file in DeleteList)
            {
                if (file.GetType() == "File")
                {
                    ConcreteFile FileToDelete = (ConcreteFile)file;
                    await client.Files.DeleteAsync(new DeleteArg(FileToDelete.FilePath));
                    enumerator++;
                    window.RefreshData(enumerator, count);
                }
                if (file.GetType() == "Folder")
                {
                    ConcreteFolder FolderToDelete = (ConcreteFolder)file;
                    await client.Files.DeleteAsync(new DeleteArg(FolderToDelete.FolderPath));
                    enumerator++;
                    window.RefreshData(enumerator, count);
                }
            }
        }

        public async Task InitializeUpload (Form OwnerForm, List<AbstractFile> UploadList, string path)
        {
            int count = UploadList.Count, enumerator = 0;
            CopyProgress window = new CopyProgress("0", count.ToString());
            window.Owner = OwnerForm;
            window.Show();
            foreach (ConcreteFile file in UploadList)
            {
                using (FileStream stream = new FileStream(file.FilePath, FileMode.Open))
                {
                    MessageBox.Show(stream.Name);
                    await client.Files.UploadAsync(path + "/" + file.FileName, WriteMode.Overwrite.Instance, body: stream);

                    enumerator++;
                    window.RefreshData(enumerator, count);
                }
            }
        }

        public async Task<List<AbstractFile>> GetMetadata(List<AbstractFile> List)
        {
            List<AbstractFile> Result = List;
            foreach (ConcreteFile item in Result.Where(i => i.GetType() == "File"))
            {
                //Result.Add(new ConcreteFile());
                ConcreteFile file = (ConcreteFile)item;
                Metadata meta = await client.Files.GetMetadataAsync(file.FilePath);
                file.FileSize = meta.AsFile.Size;
                file.DateFileClientModified = meta.AsFile.ClientModified;
                file.DateFileServerModified = meta.AsFile.ServerModified;
                Result[Result.IndexOf(item)] = file;
            }
            return Result;
        }

        public async Task ShowMetadata(string path)
        {
            Metadata meta = await client.Files.GetMetadataAsync(path);
            
            string FileName = meta.Name;
            string FilePath = meta.PathLower;
            if (meta.IsFile)
            {
                string ID = meta.AsFile.Id;
                float FileSize = meta.AsFile.Size;
                DateTime ServerModified = meta.AsFile.ServerModified;
                DateTime ClientModified = meta.AsFile.ClientModified;
                ItemInfoForm info = new ItemInfoForm(ID,FileName,FilePath, FileSize,ServerModified,ClientModified);
                info.ShowDialog();
            }
            if (meta.IsFolder)
            {
                string ID = meta.AsFolder.Id;
                ItemInfoForm info = new ItemInfoForm(ID, FileName, FilePath);
                info.ShowDialog();
            }
        }

        public async Task<List<AbstractFile>> GetList(string path)
        {
            if (String.IsNullOrEmpty(path))
            {
                path = string.Empty;
                //path = "/Изображения";
            }
            List<AbstractFile> FilesList = new List<AbstractFile>();
            ListFolderResult list = await client.Files.ListFolderAsync(path);
            int index = 0;
            if (!String.IsNullOrEmpty(path) && path != "/")
            {
                FilesList.Add(new ConcreteFolder());
                ConcreteFolder UpFolder = (ConcreteFolder)FilesList[0];
                UpFolder.FolderName = "..";
                UpFolder.FolderPath = path.Remove(path.LastIndexOf(@"/"), path.Length - path.LastIndexOf(@"/"));
                FilesList[0] = UpFolder;
                index = 1;
            }
            foreach (var item in list.Entries.Where(i => i.IsFolder))
            {
                FilesList.Add(new ConcreteFolder());
                ConcreteFolder fle = (ConcreteFolder)FilesList[index];
                //Metadata meta = await client.Files.GetMetadataAsync(item.PathLower);
                fle.FolderName = item.Name;
                fle.FolderPath = item.PathLower;
                //fle.Id = item.AsFolder.Id;
                FilesList[index] = fle;
                index++;
            }
            foreach (var item in list.Entries.Where(i => i.IsFile))
            {
                FilesList.Add(new ConcreteFile());
                ConcreteFile fle = (ConcreteFile)FilesList[index];
                //Metadata meta = await client.Files.GetMetadataAsync(item.PathLower);
                fle.FileName = item.Name;
                fle.FilePath = item.PathLower;
                fle.Type = FileTypes.File;
                //fle.Id = meta.AsFile.Id;
                //fle.FileSize = meta.AsFile.Size;
                //fle.DateFileClientModified = meta.AsFile.ClientModified;
                //fle.DateFileServerModified = meta.AsFile.ServerModified;
                FilesList[index] = fle;
                index++;
            }
            index = 0;
            return FilesList;
        }

        public async Task InitializeDownload(Form OwnerForm, string path, List<AbstractFile> DownloadList)
        {
            int count = DownloadList.Count, enumerator = 0;
            CopyProgress window = new CopyProgress("0", count.ToString());
            window.Owner = OwnerForm;
            window.Show();
            string ResultPath = String.Empty;
            
            foreach (ConcreteFile file in DownloadList)
            {
                if (DownloadList.Count < 2)
                {
                    ResultPath = path;
                }
                else
                {
                    ResultPath = path + @"\" + file.FileName;
                }
                using (FileStream fstream = new FileStream(ResultPath, FileMode.CreateNew))
                {
                    IDownloadResponse<FileMetadata> GetFile = await client.Files.DownloadAsync(file.FilePath);
                    byte[] FileAsBytes = await GetFile.GetContentAsByteArrayAsync();
                    await fstream.WriteAsync(FileAsBytes, 0, FileAsBytes.Length);
                    enumerator++;
                    window.RefreshData(enumerator, count);
                }   
            }
            //if (window.DialogResult == DialogResult.OK)
            //{
            //    window.Close();
            //}
            //MessageBox.Show("В директорию " + path + " загружено " + DownloadList.Count.ToString() + " файлов!");
        }
    }
}
