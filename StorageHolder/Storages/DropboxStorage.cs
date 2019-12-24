using Dropbox.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Dropbox.Api.Files;
using Dropbox.Api.Stone;
using StorageHolder.Misc;
using Dropbox.Api.Sharing;
using StorageHolder.Files;

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
        FileCreator Creator = new FileCreator();

        public DropboxStorage(string ClientToken)
        {
            DropboxClient dbx = new DropboxClient(ClientToken);
            client = dbx;
        }

        public async Task Rename(string path, AbstractFile file)
        {
            using (NewFolderForm CrtFldrFrm = new NewFolderForm())
            {
                if (file.Type() == FileDir.File)
                {
                    ConcreteFile CurrentFile = (ConcreteFile)file;
                    CrtFldrFrm.SetItemName(CurrentFile.FileName);
                    CrtFldrFrm.ShowDialog();

                    if (CrtFldrFrm.DialogResult == DialogResult.OK)
                    {
                        await client.Files.MoveAsync(new RelocationArg(CurrentFile.FilePath, path + "/" + CrtFldrFrm.FolderName));
                    }
                }
                if (file.Type() == FileDir.Folder)
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
            try
            {
                SharedLinkMetadata sharedMeta = await client.Sharing.CreateSharedLinkWithSettingsAsync(path);
                Result = sharedMeta.Url;
            }
            catch (ApiException<Dropbox.Api.Sharing.CreateSharedLinkWithSettingsError>)
            {
                ListSharedLinksResult sharedList = await client.Sharing.ListSharedLinksAsync(path: path);
                IList<SharedLinkMetadata> asdasd = sharedList.Links;
                Result = asdasd[asdasd.Count - 1].Url;
            }
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
                if (file.Type() == FileDir.File)
                {
                    ConcreteFile FileToDelete = (ConcreteFile)file;
                    await client.Files.DeleteAsync(new DeleteArg(FileToDelete.FilePath));
                    enumerator++;
                    window.RefreshData(enumerator, count);
                }

                if (file.Type() == FileDir.Folder)
                {
                    ConcreteFolder FolderToDelete = (ConcreteFolder)file;
                    await client.Files.DeleteAsync(new DeleteArg(FolderToDelete.FolderPath));
                    enumerator++;
                    window.RefreshData(enumerator, count);
                }
            }
            window.Close();
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
                    await client.Files.UploadAsync(path + "/" + file.FileName, WriteMode.Overwrite.Instance, body: stream);

                    enumerator++;
                    window.RefreshData(enumerator, count);
                }
            }
            window.Close();
        }

        public async Task<List<AbstractFile>> GetMetadata(List<AbstractFile> List)
        {
            List<AbstractFile> Result = List;
            /*"Оператор foreach используется для итерации коллекции с целью получения необходимой информации, 
             * однако его не следует использовать для добавления или удаления элементов исходной коллекции
             * во избежание непредвиденных побочных эффектов. 
             * Если нужно добавить или удалить элементы исходной коллекции, следует использовать цикл for."*/
            for (int i = 0; i < Result.Count; i++)
            {
                if (Result[i].Type() == FileDir.File)
                {
                    ConcreteFile file = (ConcreteFile)Result[i];
                    Metadata meta = await client.Files.GetMetadataAsync(file.FilePath);
                    file.FileSize = meta.AsFile.Size;
                    file.DateFileClientModified = meta.AsFile.ClientModified;
                    file.DateFileServerModified = meta.AsFile.ServerModified;
                    Result[i] = file;
                }
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
            }

            List<AbstractFile> FilesList = new List<AbstractFile>();
            ListFolderResult list = await client.Files.ListFolderAsync(path);
            int index = 0;

            if (!String.IsNullOrEmpty(path) && path != "/")
            {
                FilesList.Add(Creator.GetNew(FileDir.Folder));
                ConcreteFolder UpFolder = (ConcreteFolder)FilesList[0];
                UpFolder.FolderName = "..";
                UpFolder.FolderPath = path.Remove(path.LastIndexOf(@"/"), path.Length - path.LastIndexOf(@"/"));
                FilesList[0] = UpFolder;
                index = 1;
            }

            foreach (var item in list.Entries.Where(i => i.IsFolder))
            {
                FilesList.Add(Creator.GetNew(FileDir.Folder));
                ConcreteFolder fle = (ConcreteFolder)FilesList[index];
                fle.FolderName = item.Name;
                fle.FolderPath = item.PathLower;
                FilesList[index] = fle;
                index++;
            }

            foreach (var item in list.Entries.Where(i => i.IsFile))
            {
                FilesList.Add(Creator.GetNew(FileDir.File));
                ConcreteFile fle = (ConcreteFile)FilesList[index];
                fle.FileName = item.Name;
                fle.FilePath = item.PathLower;
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
                /*if (DownloadList.Count < 2)
                {
                    ResultPath = path;
                }
                else
                {
                    ResultPath = path + @"\" + file.FileName;
                }*/

                ResultPath = (DownloadList.Count < 2) ? path : path + @"\" + file.FileName;

                using (FileStream fstream = new FileStream(ResultPath, FileMode.CreateNew))
                {
                    IDownloadResponse<FileMetadata> GetFile = await client.Files.DownloadAsync(file.FilePath);
                    byte[] FileAsBytes = await GetFile.GetContentAsByteArrayAsync();
                    await fstream.WriteAsync(FileAsBytes, 0, FileAsBytes.Length);
                    enumerator++;
                    window.RefreshData(enumerator, count);
                }
            }
        }
    }
}
