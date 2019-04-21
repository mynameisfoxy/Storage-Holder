using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syroot.Windows.IO;
using System.Drawing;
using Etier.IconHelper;

namespace StorageHolder
{
    //public static class Extensions
    //{
    //    public static string PathCombine(this string[] paths)
    //    {
    //        string result = string.Empty;
    //        foreach (string path in paths)
    //            result = Path.Combine(result, path);
    //        return result;
    //    }
    //}

    public partial class WorkDirectioryForm : Form
    {
        List<AbstractFile> FilesAndFolders = new List<AbstractFile>();
        List<AbstractFile> DownloadList = new List<AbstractFile>();
        List<AbstractFile> DeleteList = new List<AbstractFile>();
        List<AbstractFile> UploadList = new List<AbstractFile>();
        List<string> BreadCrumbs = new List<string>();
        string CurrentPath = null;
        string FileSystemPath = @"D:\Downloads\";
        string DownloadPath = new KnownFolder(KnownFolderType.Downloads).Path;
        IStorage DropboxClient;
        Lists ActiveList = Lists.Storage;
        Point moveStart;

        public WorkDirectioryForm()
        {
            InitializeComponent();
            //InitializeIcons();
            SettingsPage.Parent = this;
            StorageFolderPage.Parent = this;
            UpButton.Parent = StorageFolderPage;
            StorageFilesList.Parent = StorageFolderPage;
            BreadCrumbsPanel.Parent = StorageFolderPage;
            
            StorageFolderPage.BringToFront();
            //====================================
            BreadCrumbs.Add("/");

            string[] files = Directory.GetFiles(Directory.GetCurrentDirectory());

            DropboxClient = new DropboxStorage("JPL_TOTIRMAAAAAAAAAAHFc9X2uPZtbmp3mIc62wzPEjCco1lj_XmpJHgu8hzawO");
            RightComboBox.SelectedIndex = 0;

            GoToRoot(this, new EventArgs());

        }

        void InitializeIcons()
        {
            imageList1.Images.Add(Properties.Resources.icons8_file_24);
            imageList1.Images.Add(Properties.Resources.icons8_folder_24);
            imageList1.Images.Add(Properties.Resources.icons8_document_24);
            imageList1.Images.Add(Properties.Resources.icons8_musical_notes_24);
            imageList1.Images.Add(Properties.Resources.icons8_document_24);
            imageList1.Images.Add(Properties.Resources.icons8_pdf_24);
            imageList1.Images.Add(Properties.Resources.icons8_image_file_24);
            imageList1.Images.Add(Properties.Resources.icons8_bookmark_24);
            imageList1.Images.Add(Properties.Resources.icons8_filing_cabinet_24);
        }

        void GenerateBreadCrumbs(string path)
        {
            BreadCrumbs.Clear();
            BreadCrumbs.Add("/");
            BreadCrumbsPanel.Items.Clear();
            BreadCrumbsPanel.Items.Add("/");
            BreadCrumbsPanel.Items[0].Click += GoToRoot;
            if (path != null)
            {
                string[] SplittedParhString = path.Split('/');
                
                string BreadPathString = "";
                for (int i = 1; i < SplittedParhString.Length; i++)
                {
                    BreadPathString += "/"+ SplittedParhString[i];
                    BreadCrumbs.Add(BreadPathString);
                    BreadCrumbsPanel.Items.Add(SplittedParhString[i]);
                    BreadCrumbsPanel.Items[i].Click += async (object sender, EventArgs e) => {
                        ToolStripItem BreadClicked = sender as ToolStripItem;
                        CurrentPath = BreadCrumbs[BreadCrumbsPanel.Items.IndexOf(BreadClicked)];
                        await ChainToShow(BreadCrumbs[BreadCrumbsPanel.Items.IndexOf(BreadClicked)]);
                    };
                }
            }
        }

        List<AbstractFile> GetFileSystemList(string FsPath)
        {
            List<AbstractFile> FilesList = new List<AbstractFile>();
            //FileSystemFilesAndFolders.Clear();
            string[] files = Directory.GetFiles(FsPath);
            string[] directory = Directory.GetDirectories(FsPath);
            int index = 0;
            if (!String.IsNullOrEmpty(FsPath) && FsPath.Length > 3)
            {
                FilesList.Add(new ConcreteFolder());
                ConcreteFolder UpFolder = (ConcreteFolder)FilesList[0];
                UpFolder.FolderName = "..";
                UpFolder.FolderPath = FsPath.Remove(FsPath.LastIndexOf(@"\"), FsPath.Length - FsPath.LastIndexOf(@"\"));
                FilesList[0] = UpFolder;
                index = 1;
            }
            foreach (string obj in directory)
            {
                if (Directory.Exists(obj))
                {
                    FilesList.Add(new ConcreteFolder());
                    ConcreteFolder fld = (ConcreteFolder)FilesList[index];
                    fld.FolderName = obj.Remove(0, obj.LastIndexOf('\\') + 1);
                    fld.FolderPath = Path.GetFullPath(obj);
                    FilesList[index] = fld;
                    index++;
                }
            }
            foreach (string obj in files)
            {
                if (File.Exists(obj))
                {
                    FilesList.Add(new ConcreteFile());
                    ConcreteFile fle = (ConcreteFile)FilesList[index];
                    fle.FileName = Path.GetFileName(obj);
                    fle.FilePath = Path.GetFullPath(obj);
                    fle.FileSize = new FileInfo(obj).Length / 1024;
                    fle.Type = FileTypes.File;
                    FilesList[index] = fle;
                    index++;
                }
            }
            index = 0;
            return FilesList;
        }
        
        async Task ChainToShow(string path) //переписать бы это дерьмо по-человечески
        {
            InfoContext.Visible = false;
            DeleteContext.Visible = false;
            DeleteButton.Enabled = false;
            RenameContext.Visible = false;
            GetSharedLinkClipboardContext.Visible = false;
            //==============================
            progressBar1.Value = 30;
            FilesAndFolders = await DropboxClient.GetList(path);
            progressBar1.Value = 50;
            DisplayContent(FilesAndFolders, StorageFilesList);
            SetIcons(FilesAndFolders, StorageFilesList);
            DisplayCounters(FilesAndFolders, StorageListCount);
            GenerateBreadCrumbs(path);
            progressBar1.Value = 70;
            if (String.IsNullOrEmpty(CurrentPath))
            {
                UpButton.Enabled = false;
            }
            else
            {
                UpButton.Enabled = true;
            }
            progressBar1.Value = 100;
            await Task.Run(async () => { await Task.Delay(1000); });
            progressBar1.Value = 0;
            
            //FilesAndFolders = await DropboxClient.GetMetadata(FilesAndFolders);
            //DisplayContent(FilesAndFolders, StorageFilesList);
            //SetIcons(FilesAndFolders, StorageFilesList);
        }

        void DisplayCounters(List<AbstractFile> list, Label label)
        {
            int files = 0, folders = 0;
            foreach (AbstractFile folder in list.Where(i => i.GetType() == "Folder"))
            {
                folders++;
            }
            foreach (AbstractFile file in list.Where(i => i.GetType() == "File"))
            {
                files++;
            }
            if (!String.IsNullOrEmpty(CurrentPath) && CurrentPath != "/")
            {
                folders--;
            }
            label.Text = files.ToString() + " files, and " + folders.ToString() + " folders";
        }

        void DisplayContent(List<AbstractFile> list, ListView FileList)
        {
            FileList.Clear();
            FileList.Columns.Add("Name");
            FileList.Columns[0].Width = 300;
            FileList.Columns.Add("Size");
            foreach (var item in list.Where(i => i.GetType() == "Folder"))
            {
                ListViewItem lvi = new ListViewItem();
                ConcreteFolder fle = (ConcreteFolder)item;
                lvi.Text = fle.FolderName;
                FileList.Items.Add(lvi);
            }
            foreach (var item in list.Where(i => i.GetType() == "File"))
            {
                ListViewItem lvi = new ListViewItem();
                ConcreteFile fle = (ConcreteFile)item;
                lvi.Text = fle.FileName;
                lvi.SubItems.Add(fle.FileSize.ToString() + " Kb");
                FileList.Items.Add(lvi);
            }
        }

        void SetIcons(List<AbstractFile> list, ListView FileList)
        {
            imageList1.Images.Clear();
            imageList1.Images.Add(Etier.IconHelper.IconReader.GetFolderIcon(IconReader.IconSize.Small,IconReader.FolderType.Closed));
            foreach (var item in list.Where(i => i.GetType() == "Folder"))
            {
                ConcreteFolder fle = (ConcreteFolder)item;
                FileList.Items[list.IndexOf(item)].ImageIndex = imageList1.Images.Count-1;
            }
            imageList1.Images.Add(Etier.IconHelper.IconReader.GetFolderIcon(IconReader.IconSize.Small, IconReader.FolderType.Open));
            if (FileList.Items[0].Name == "..")
            {
                FileList.Items[0].ImageIndex = 1;
            }
            foreach (var item in list.Where(i => i.GetType() == "File"))
            {
                ConcreteFile file = (ConcreteFile)item;
                imageList1.Images.Add(Etier.IconHelper.IconReader.GetFileIcon(Path.GetExtension(file.FilePath), 
                    IconReader.IconSize.Large, false));
                FileList.Items[list.IndexOf(item)].ImageIndex = imageList1.Images.Count - 1;
            }
        }

        private async void GoToRoot(object sender, EventArgs e)
        {
            CurrentPath = null;
            await ChainToShow(null);
        }

        async private void UpButtonClick(object sender, EventArgs e)
        {
            CurrentPath = CurrentPath.Remove(CurrentPath.LastIndexOf("/"), CurrentPath.Length - CurrentPath.LastIndexOf("/"));
            await ChainToShow(CurrentPath);
        }

        private async void StorageFileList_DoubleClick(object sender, EventArgs e)
        {
            if (StorageFilesList.SelectedIndices.Count > 0)
            {
                if (FilesAndFolders[StorageFilesList.SelectedIndices[0]].GetType() == "Folder")
                {
                    ConcreteFolder concfldr = (ConcreteFolder)FilesAndFolders[StorageFilesList.SelectedIndices[0]];
                    CurrentPath = concfldr.FolderPath;
                    await ChainToShow(CurrentPath);
                }
            }
        }

        async void DownloadItem_Click(object sender, EventArgs e)
        {
            if (StorageFilesList.SelectedIndices.Count > 0)
            {
                DownloadList.Clear();
                foreach (int index in StorageFilesList.SelectedIndices)
                {
                    if (FilesAndFolders[index].GetType() == "File")
                    {
                        DownloadList.Add(FilesAndFolders[index]);
                    }
                }
                await DropboxClient.InitializeDownload(this,DownloadPath, DownloadList);
            }
        }

        async private void DownloadItemAs_Click(object sender, EventArgs e)
        {
            if (StorageFilesList.SelectedIndices.Count > 0)
            {
                DownloadList.Clear();
                foreach (int index in StorageFilesList.SelectedIndices)
                {
                    if (FilesAndFolders[index].GetType() == "File")
                    {
                        DownloadList.Add(FilesAndFolders[index]);
                    }
                }
                if (StorageFilesList.SelectedIndices.Count < 2)
                {
                    SaveFileDialog SaveFile = new SaveFileDialog();
                    ConcreteFile FileInTheListToDownload = (ConcreteFile)FilesAndFolders[StorageFilesList.SelectedIndices[0]];
                    SaveFile.FileName = FileInTheListToDownload.FileName;
                    DialogResult res = SaveFile.ShowDialog();
                    if (res == DialogResult.OK)
                    {
                        await DropboxClient.InitializeDownload(this, SaveFile.FileName, DownloadList);
                    }
                }
                else
                {
                    FolderBrowserDialog SaveFileFolder = new FolderBrowserDialog();
                    ConcreteFile FileInTheListToDownload = (ConcreteFile)FilesAndFolders[StorageFilesList.SelectedIndices[0]];
                    DialogResult res = SaveFileFolder.ShowDialog();
                    if (res == DialogResult.OK)
                    {
                        await DropboxClient.InitializeDownload(this, SaveFileFolder.SelectedPath, DownloadList);
                    }
                }
            }
        }

        private void StorageFileList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StorageFilesList.SelectedIndices.Count > 0)
            {
                if (StorageFilesList.SelectedIndices.Count < 2)
                {
                    InfoContext.Visible = true;
                    RenameContext.Visible = true;
                    GetSharedLinkClipboardContext.Visible = true;
                }
                else
                {
                    InfoContext.Visible = false;
                    RenameContext.Visible = false;
                    GetSharedLinkClipboardContext.Visible = false;
                }

                if (FilesAndFolders[StorageFilesList.SelectedIndices[0]].GetType() == "File")
                {
                    DownloadFileContext.Visible = true;
                    DownloadFileAsContext.Visible = true;
                    DeleteContext.Visible = true;
                    DeleteButton.Enabled = true;
                }
                else
                {
                    DownloadFileContext.Visible = false;
                    DownloadFileAsContext.Visible = false;
                    DeleteContext.Visible = true;
                    DeleteButton.Enabled = true;
                }
            }
            else
            {
                DownloadFileContext.Visible = false;
                DownloadFileAsContext.Visible = false;
                DeleteContext.Visible = false;
                DeleteButton.Enabled = false;
                InfoContext.Visible = false;
                RenameContext.Visible = false;
                GetSharedLinkClipboardContext.Visible = false;
            }
        }

        async private void CopyButton_Click(object sender, EventArgs e)
        {
            if (ActiveList == Lists.Storage)
            {
                if (StorageFilesList.SelectedIndices.Count > 0)
                {
                    DownloadList.Clear();
                    foreach (int index in StorageFilesList.SelectedIndices)
                    {
                        if (FilesAndFolders[index].GetType() == "File")
                        {
                            DownloadList.Add(FilesAndFolders[index]);
                        }
                    }
                    await DropboxClient.InitializeDownload(this, FileSystemPath, DownloadList);
                }
            }
        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                moveStart = new Point(e.X, e.Y);
            }
        }

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) != 0)
            {
                // получаем новую точку положения формы
                Point deltaPos = new Point(e.X - moveStart.X, e.Y - moveStart.Y);
                // устанавливаем положение формы
                this.Location = new Point(this.Location.X + deltaPos.X,
                  this.Location.Y + deltaPos.Y);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            LeftPanel.Visible = false;
            SettingsPage.BringToFront();
        }

        private void StorageFilesList_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private async void StorageFilesList_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            UploadList.Clear();

            foreach (string file in files)
            {
                ConcreteFile concfile = new ConcreteFile
                {
                    FilePath = Path.GetFullPath(file),
                    FileName = Path.GetFileName(file)
                };
                UploadList.Add(concfile);
            }
            await DropboxClient.InitializeUpload(this, UploadList, CurrentPath);
            await ChainToShow(CurrentPath);
        }

        private async void DeleteClicked(object sender, EventArgs e)
        {
            string countFiles;
            int count = 0;
            if (DeleteList.Count > 1)
            {
                countFiles = " items";
            }
            else
            {
                countFiles = " item";
            }
            if (StorageFilesList.SelectedIndices.Count > 0)
            {
                DeleteList.Clear();
                foreach (int index in StorageFilesList.SelectedIndices)
                {
                    DeleteList.Add(FilesAndFolders[index]);
                }
                count = DeleteList.Count;
                if (MessageBox.Show("Delete " + count + countFiles + "?", "Delete confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    await DropboxClient.InitializeDelete(this, DeleteList);
                    await ChainToShow(CurrentPath);
                }
            }
        }

        private async void RefreshClick(object sender, EventArgs e)
        {
            await ChainToShow(CurrentPath);
        }

        private async void NewFolderClick(object sender, EventArgs e)
        {
            await DropboxClient.CreateFolder(CurrentPath);
            await ChainToShow(CurrentPath);
        }

        private void InfoContext_Click(object sender, EventArgs e)
        {
            if (StorageFilesList.SelectedIndices.Count > 0 && StorageFilesList.SelectedIndices.Count < 2)
            {
                if (FilesAndFolders[StorageFilesList.SelectedIndices[0]].GetType() == "File")
                {
                    ConcreteFile file = (ConcreteFile)FilesAndFolders[StorageFilesList.SelectedIndices[0]];
                    DropboxClient.ShowMetadata(file.FilePath);
                }
                if (FilesAndFolders[StorageFilesList.SelectedIndices[0]].GetType() == "Folder")
                {
                    ConcreteFolder folder = (ConcreteFolder)FilesAndFolders[StorageFilesList.SelectedIndices[0]];
                    DropboxClient.ShowMetadata(folder.FolderPath);
                }
            }
        }

        private async void GetSharedLinkClipboardContext_Click(object sender, EventArgs e)
        {
            if (StorageFilesList.SelectedIndices.Count > 0 && StorageFilesList.SelectedIndices.Count < 2)
            {
                if (FilesAndFolders[StorageFilesList.SelectedIndices[0]].GetType() == "File")
                {
                    ConcreteFile file = (ConcreteFile)FilesAndFolders[StorageFilesList.SelectedIndices[0]];
                    string str = await DropboxClient.GetSharedLink(file.FilePath);
                }
            }
        }

        private void StoragePageButton_Click(object sender, EventArgs e)
        {
            LeftPanel.Visible = true;
            StorageFolderPage.BringToFront();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            LeftPanel.Visible = false;
            LoginPanel.BringToFront();
        }

        private async void RenameContext_Click(object sender, EventArgs e)
        {
            if (StorageFilesList.SelectedIndices.Count > 0 && StorageFilesList.SelectedIndices.Count < 2)
            {
                if (FilesAndFolders[StorageFilesList.SelectedIndices[0]].GetType() == "File")
                {
                    ConcreteFile file = (ConcreteFile)FilesAndFolders[StorageFilesList.SelectedIndices[0]];
                    await DropboxClient.Rename(CurrentPath, file);
                }
                if (FilesAndFolders[StorageFilesList.SelectedIndices[0]].GetType() == "Folder")
                {
                    ConcreteFolder folder = (ConcreteFolder)FilesAndFolders[StorageFilesList.SelectedIndices[0]];
                    await DropboxClient.Rename(CurrentPath, folder);
                }
                await ChainToShow(CurrentPath);
            }
        }
    }
}
