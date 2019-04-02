using Dropbox.Api;
using StorageHolder.Files;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dropbox;
using Dropbox.Api.Files;
using Dropbox.Api.Stone;
using Syroot.Windows.IO;

namespace StorageHolder
{
    public partial class WorkDirectioryForm : Form
    {
        List<AbstractFile> FilesAndFolders = new List<AbstractFile>();
        List<string> BreadCrumbs = new List<string>();
        string CurrentPath = null;
        //string CurrentFile = null;
        string DownloadPath = new KnownFolder(KnownFolderType.Downloads).Path;
        public WorkDirectioryForm()
        {
            InitializeComponent();
            //====================================
            BreadCrumbs.Add("/");
            listView1.SmallImageList = imageList1;
            imageList1.Images.Add(Properties.Resources.file);
            imageList1.Images.Add(Properties.Resources.folder);
            imageList1.Images.Add(Properties.Resources.text);
            imageList1.Images.Add(Properties.Resources.music);
            imageList1.Images.Add(Properties.Resources.document);
            imageList1.Images.Add(Properties.Resources.pdf);
            imageList1.Images.Add(Properties.Resources.image);
            imageList1.Images.Add(Properties.Resources.URL);
            imageList1.Images.Add(Properties.Resources.archive);
            string[] files = Directory.GetFiles(Directory.GetCurrentDirectory());
            //foreach (string file in files)
            //{
            //    ListViewItem lvi = new ListViewItem();
            //    // установка названия файла
            //    lvi.Text = file.Remove(0, file.LastIndexOf('\\') + 1);
            //    lvi.ImageIndex = 0; // установка картинки для файла
            //    // добавляем элемент в ListView
            //    listView1.Items.Add(lvi);
            //}
            button1_Click(this, new EventArgs());
        }

        async Task ListRootFolder(DropboxClient dbx)
        {
            var list = await dbx.Files.ListFolderAsync(string.Empty);
            // show folders then files
            foreach (var item in list.Entries.Where(i => i.IsFolder))
            {
                ListViewItem lvi = new ListViewItem();
                //Console.WriteLine("D  {0}/", item.Name);
                // установка названия файла
                lvi.Text = item.Name;
                lvi.ImageIndex = 0;
                listView1.Items.Add(lvi);
            }

            foreach (var item in list.Entries.Where(i => i.IsFile))
            {
                ListViewItem lvi = new ListViewItem();

                //try
                //{
                //    IDownloadResponse<FileMetadata> AsyncThumb = await dbx.Files.GetThumbnailAsync(item.PathLower, ThumbnailFormat.Jpeg.Instance, ThumbnailSize.W32h32.Instance);

                //    //Metadata meta = await dbx.Files.GetMetadataAsync(item.PathLower);
                //    //meta.ParentSharedFolderId;
                //    //MessageBox.Show("111");
                //    Image img = Image.FromStream(await AsyncThumb.GetContentAsStreamAsync());
                //    imageList1.Images.Add(img);
                //    //using (FileStream VarFileStream = File.Create(item.Name))
                //    //{
                //    //    Stream ThumbStream = await AsyncThumb.GetContentAsStreamAsync();
                //    //    ThumbStream.CopyTo(VarFileStream);
                //    //}
                //}
                //catch (ApiException<ThumbnailError>)
                //{
                    
                //}
                // установка названия файла
                lvi.Text = item.Name;
                lvi.ImageIndex = imageList1.Images.Count-1;
                listView1.Items.Add(lvi);
            }
        }

        void GenerateBreadCrumbs(string path)
        {
            BreadCrumbs.Clear();
            BreadCrumbs.Add("/");
            BreadCrumbsPanel.Items.Clear();
            BreadCrumbsPanel.Items.Add("/");
            BreadCrumbsPanel.Items[0].Click += button1_Click;
            if (path != null)
            {
                string[] outerstring = path.Split('/');
                
                string teststring = "";
                for (int i = 1; i < outerstring.Length; i++)
                {
                    teststring += "/"+outerstring[i];
                    BreadCrumbs.Add(teststring);
                    BreadCrumbsPanel.Items.Add(outerstring[i]);
                    BreadCrumbsPanel.Items[i].Click += async (object sender, EventArgs e) => {
                        ToolStripItem BreadClicked = sender as ToolStripItem;
                        CurrentPath = BreadCrumbs[BreadCrumbsPanel.Items.IndexOf(BreadClicked)];
                        await ChainToShow(BreadCrumbs[BreadCrumbsPanel.Items.IndexOf(BreadClicked)]);
                    };
                }
            }
        }
        
        async Task ChainToShow(string path)
        {
            using (DropboxClient dbx = new DropboxClient("JPL_TOTIRMAAAAAAAAAAHFc9X2uPZtbmp3mIc62wzPEjCco1lj_XmpJHgu8hzawO"))
            {
                button1.Enabled = false;
                progressBar1.Value = 30;
                //await ListRootFolder(dbx);
                FilesAndFolders = await GetList(path, dbx);
                progressBar1.Value = 50;
                DisplayContent(FilesAndFolders);
                SetIcons(FilesAndFolders);
                button1.Enabled = true;
                button1.Text = "/";
                GenerateBreadCrumbs(path);
                progressBar1.Value = 70;
                if (String.IsNullOrEmpty(CurrentPath))
                {
                    button2.Enabled = false;
                }
                else
                {
                    button2.Enabled = true;
                }
                progressBar1.Value = 100;
                await Task.Run( async () => { await Task.Delay(1000); });
                progressBar1.Value = 0;
            }
        }
        
        async Task<List<AbstractFile>> GetList(string path, DropboxClient client)
        {
            if (String.IsNullOrEmpty(path))
            {
                path = string.Empty;
                //path = "/Изображения";
            }
            List<AbstractFile> FilesList = new List<AbstractFile>();
            ListFolderResult list = await client.Files.ListFolderAsync(path);
            int index = 0;
            foreach (var item in list.Entries.Where(i => i.IsFolder))
            {
                FilesList.Add(new CreateConcreteFolder().Create());
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
                FilesList.Add(new CreateConcreteFile().Create());
                ConcreteFile fle = (ConcreteFile)FilesList[index];
                //Metadata meta = await client.Files.GetMetadataAsync(item.PathLower);
                fle.FileName = item.Name;
                fle.FilePath = item.PathLower;
                fle.Type = FileTypes.File;
                //fle.Id = meta.AsFile.Id;
                FilesList[index] = fle;
                index++;
            }
            index = 0;
            return FilesList;
        }

        void DisplayContent(List<AbstractFile> list)
        {
            listView1.Clear();
            foreach (var item in list.Where(i => i.GetType() == "Folder"))
            {
                ListViewItem lvi = new ListViewItem();
                ConcreteFolder fle = (ConcreteFolder)item;
                lvi.Text = fle.FolderName;
                //lvi.ImageIndex = 1;
                listView1.Items.Add(lvi);
            }
            foreach (var item in list.Where(i => i.GetType() == "File"))
            {
                ListViewItem lvi = new ListViewItem();
                ConcreteFile fle = (ConcreteFile)item;
                lvi.Text = fle.FileName;
                //lvi.ImageIndex = 0;
                listView1.Items.Add(lvi);
            }
        }

        void SetIcons(List<AbstractFile> list)
        {
            foreach (var item in list.Where(i => i.GetType() == "Folder"))
            {
                int index = 0;
                //MessageBox.Show("hello world");
                ConcreteFolder fle = (ConcreteFolder)item;
                listView1.Items[list.IndexOf(item)].ImageIndex = fle.Icon;
                
                index++;
            }
            foreach (var item in list.Where(i => i.GetType() == "File"))
            {
                int index = 0;
                ConcreteFile fle = (ConcreteFile)item;
                switch (Path.GetExtension(fle.FilePath))
                {
                    case ".url":
                        listView1.Items[list.IndexOf(item)].ImageIndex = (int)FileTypes.URL;
                        break;
                    case ".pdf":
                        listView1.Items[list.IndexOf(item)].ImageIndex = (int)FileTypes.PDF;
                        break;
                    case ".jpg":
                        listView1.Items[list.IndexOf(item)].ImageIndex = (int)FileTypes.Image;
                        break;
                    case ".zip":
                        listView1.Items[list.IndexOf(item)].ImageIndex = (int)FileTypes.Archive;
                        break;
                    default:
                        listView1.Items[list.IndexOf(item)].ImageIndex = (int)FileTypes.File;
                        break;
                }
                index++;
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            CurrentPath = null;
            await ChainToShow(null);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.View = View.List;
        }

        async private void button2_Click(object sender, EventArgs e)
        {
            CurrentPath = CurrentPath.Remove(CurrentPath.LastIndexOf("/"), CurrentPath.Length - CurrentPath.LastIndexOf("/"));
            await ChainToShow(CurrentPath);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listView1.View = View.Tile;
        }

        private async void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                if (FilesAndFolders[listView1.SelectedIndices[0]].GetType() == "Folder")
                {
                    ConcreteFolder concfldr = (ConcreteFolder)FilesAndFolders[listView1.SelectedIndices[0]];
                    CurrentPath = concfldr.FolderPath;
                    await ChainToShow(CurrentPath);
                }
            }
        }

        async private void DownloadItem_Click(object sender, EventArgs e)
        {
            if (FilesAndFolders[listView1.SelectedIndices[0]].GetType() == "File")
            {
                ConcreteFile concfle = (ConcreteFile)FilesAndFolders[listView1.SelectedIndices[0]];
                await InitializeDownload(concfle.FilePath + "/" + concfle.FileName);
            }
        }

        async private void DownloadItemAs_Click(object sender, EventArgs e)
        {
            
            if (FilesAndFolders[listView1.SelectedIndices[0]].GetType() == "File")
            {
                SaveFileDialog SaveFile = new SaveFileDialog();
                ConcreteFile FileInTheListToDownload = (ConcreteFile)FilesAndFolders[listView1.SelectedIndices[0]];
                SaveFile.FileName = FileInTheListToDownload.FileName;
                DialogResult res = SaveFile.ShowDialog();
                if (res == DialogResult.OK)
                {
                    await InitializeDownload(SaveFile.FileName);
                }
            }
        }

        async Task InitializeDownload(string Current)
        {
            ConcreteFile concfle = (ConcreteFile)FilesAndFolders[listView1.SelectedIndices[0]];
            
            using (DropboxClient dbx = new DropboxClient("JPL_TOTIRMAAAAAAAAAAHFc9X2uPZtbmp3mIc62wzPEjCco1lj_XmpJHgu8hzawO"))
            {
                using (FileStream fstream = new FileStream(Current, FileMode.CreateNew))
                {
                    IDownloadResponse<FileMetadata> GetFile = await dbx.Files.DownloadAsync(concfle.FilePath);
                    byte[] FileAsBytes = await GetFile.GetContentAsByteArrayAsync();
                    await fstream.WriteAsync(FileAsBytes, 0, FileAsBytes.Length);
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                if (FilesAndFolders[listView1.SelectedIndices[0]].GetType() == "File")
                {
                    DownloadFileContext.Visible = true;
                    DownloadFileAsContext.Visible = true;
                }
                else
                {
                    DownloadFileContext.Visible = false;
                    DownloadFileAsContext.Visible = false;
                }
            }
        }
    }
}
