namespace StorageHolder
{
    partial class WorkDirectioryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.StorageFilesList = new System.Windows.Forms.ListView();
            this.SelectedFilesContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RefreshContext = new System.Windows.Forms.ToolStripMenuItem();
            this.DownloadFileContext = new System.Windows.Forms.ToolStripMenuItem();
            this.DownloadFileAsContext = new System.Windows.Forms.ToolStripMenuItem();
            this.DownloadZipContext = new System.Windows.Forms.ToolStripMenuItem();
            this.GetSharedLinkClipboardContext = new System.Windows.Forms.ToolStripMenuItem();
            this.RenameContext = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteContext = new System.Windows.Forms.ToolStripMenuItem();
            this.NewFolderContext = new System.Windows.Forms.ToolStripMenuItem();
            this.InfoContext = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.TreeImageList = new System.Windows.Forms.ImageList(this.components);
            this.BreadCrumbsPanel = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.StorageListCount = new System.Windows.Forms.Label();
            this.RightComboBox = new System.Windows.Forms.ComboBox();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.UserLabel = new System.Windows.Forms.Label();
            this.DownloadButton = new System.Windows.Forms.Button();
            this.AppName = new System.Windows.Forms.Label();
            this.StoragePageButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SettingsPage = new System.Windows.Forms.Panel();
            this.StorageFolderPage = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.NewFolderButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpButton = new System.Windows.Forms.Button();
            this.lollipopFlatButton1 = new LollipopFlatButton();
            this.lollipopToggle1 = new LollipopToggle();
            this.lollipopFolderInPut1 = new LollipopFolderInPut();
            this.lollipopButton1 = new LollipopButton();
            this.lollipopLabel1 = new LollipopLabel();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.StoragesPanel = new System.Windows.Forms.Panel();
            this.StoragePanelCapture = new System.Windows.Forms.Panel();
            this.StorageCaptureLabel = new System.Windows.Forms.Label();
            this.TreePanel = new System.Windows.Forms.Panel();
            this.TreePanelCapture = new System.Windows.Forms.Panel();
            this.TreeViewLabel = new System.Windows.Forms.Label();
            this.StorageTreeView = new System.Windows.Forms.TreeView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.lollipopButton2 = new LollipopButton();
            this.PasswordLabel = new LollipopLabel();
            this.LoginLabel = new LollipopLabel();
            this.PasswordField = new LollipopTextBox();
            this.LoginField = new LollipopTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lollipopFlatButton2 = new LollipopFlatButton();
            this.SelectedFilesContextMenu.SuspendLayout();
            this.BreadCrumbsPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.SettingsPage.SuspendLayout();
            this.StorageFolderPage.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            this.StoragesPanel.SuspendLayout();
            this.StoragePanelCapture.SuspendLayout();
            this.TreePanel.SuspendLayout();
            this.TreePanelCapture.SuspendLayout();
            this.LoginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // StorageFilesList
            // 
            this.StorageFilesList.AllowDrop = true;
            this.StorageFilesList.BackColor = System.Drawing.SystemColors.Window;
            this.StorageFilesList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StorageFilesList.ContextMenuStrip = this.SelectedFilesContextMenu;
            this.StorageFilesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StorageFilesList.ForeColor = System.Drawing.SystemColors.WindowText;
            this.StorageFilesList.FullRowSelect = true;
            this.StorageFilesList.GridLines = true;
            this.StorageFilesList.HideSelection = false;
            this.StorageFilesList.LabelWrap = false;
            this.StorageFilesList.LargeImageList = this.imageList1;
            this.StorageFilesList.Location = new System.Drawing.Point(0, 39);
            this.StorageFilesList.Name = "StorageFilesList";
            this.StorageFilesList.Size = new System.Drawing.Size(844, 653);
            this.StorageFilesList.SmallImageList = this.imageList1;
            this.StorageFilesList.TabIndex = 0;
            this.StorageFilesList.UseCompatibleStateImageBehavior = false;
            this.StorageFilesList.View = System.Windows.Forms.View.Details;
            this.StorageFilesList.SelectedIndexChanged += new System.EventHandler(this.StorageFileList_SelectedIndexChanged);
            this.StorageFilesList.DragDrop += new System.Windows.Forms.DragEventHandler(this.StorageFilesList_DragDrop);
            this.StorageFilesList.DragEnter += new System.Windows.Forms.DragEventHandler(this.StorageFilesList_DragEnter);
            this.StorageFilesList.DoubleClick += new System.EventHandler(this.StorageFileList_DoubleClick);
            // 
            // SelectedFilesContextMenu
            // 
            this.SelectedFilesContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RefreshContext,
            this.DownloadFileContext,
            this.DownloadFileAsContext,
            this.DownloadZipContext,
            this.GetSharedLinkClipboardContext,
            this.RenameContext,
            this.DeleteContext,
            this.NewFolderContext,
            this.InfoContext});
            this.SelectedFilesContextMenu.Name = "contextMenuStrip1";
            this.SelectedFilesContextMenu.Size = new System.Drawing.Size(189, 202);
            // 
            // RefreshContext
            // 
            this.RefreshContext.Image = global::StorageHolder.Properties.Resources.icons8_restart_24;
            this.RefreshContext.Name = "RefreshContext";
            this.RefreshContext.Size = new System.Drawing.Size(188, 22);
            this.RefreshContext.Text = "Refresh";
            this.RefreshContext.Click += new System.EventHandler(this.RefreshClick);
            // 
            // DownloadFileContext
            // 
            this.DownloadFileContext.Image = global::StorageHolder.Properties.Resources.icons8_download_from_the_cloud_24;
            this.DownloadFileContext.Name = "DownloadFileContext";
            this.DownloadFileContext.Size = new System.Drawing.Size(188, 22);
            this.DownloadFileContext.Text = "Download";
            this.DownloadFileContext.Visible = false;
            this.DownloadFileContext.Click += new System.EventHandler(this.DownloadItem_Click);
            // 
            // DownloadFileAsContext
            // 
            this.DownloadFileAsContext.Image = global::StorageHolder.Properties.Resources.icons8_download_from_the_cloud_24;
            this.DownloadFileAsContext.Name = "DownloadFileAsContext";
            this.DownloadFileAsContext.Size = new System.Drawing.Size(188, 22);
            this.DownloadFileAsContext.Text = "Download as...";
            this.DownloadFileAsContext.Visible = false;
            this.DownloadFileAsContext.Click += new System.EventHandler(this.DownloadItemAs_Click);
            // 
            // DownloadZipContext
            // 
            this.DownloadZipContext.Image = global::StorageHolder.Properties.Resources.icons8_filing_cabinet_24;
            this.DownloadZipContext.Name = "DownloadZipContext";
            this.DownloadZipContext.Size = new System.Drawing.Size(188, 22);
            this.DownloadZipContext.Text = "Download folder (zip)";
            this.DownloadZipContext.Visible = false;
            // 
            // GetSharedLinkClipboardContext
            // 
            this.GetSharedLinkClipboardContext.Image = global::StorageHolder.Properties.Resources.icons8_copy_24;
            this.GetSharedLinkClipboardContext.Name = "GetSharedLinkClipboardContext";
            this.GetSharedLinkClipboardContext.Size = new System.Drawing.Size(188, 22);
            this.GetSharedLinkClipboardContext.Text = "Copy link";
            this.GetSharedLinkClipboardContext.Click += new System.EventHandler(this.GetSharedLinkClipboardContext_Click);
            // 
            // RenameContext
            // 
            this.RenameContext.Image = global::StorageHolder.Properties.Resources.icons8_rename_24;
            this.RenameContext.Name = "RenameContext";
            this.RenameContext.Size = new System.Drawing.Size(188, 22);
            this.RenameContext.Text = "Rename";
            this.RenameContext.Visible = false;
            this.RenameContext.Click += new System.EventHandler(this.RenameContext_Click);
            // 
            // DeleteContext
            // 
            this.DeleteContext.Image = global::StorageHolder.Properties.Resources.icons8_trash_24;
            this.DeleteContext.Name = "DeleteContext";
            this.DeleteContext.Size = new System.Drawing.Size(188, 22);
            this.DeleteContext.Text = "Delete";
            this.DeleteContext.Visible = false;
            this.DeleteContext.Click += new System.EventHandler(this.DeleteClicked);
            // 
            // NewFolderContext
            // 
            this.NewFolderContext.Image = global::StorageHolder.Properties.Resources.icons8_documents_folder_24;
            this.NewFolderContext.Name = "NewFolderContext";
            this.NewFolderContext.Size = new System.Drawing.Size(188, 22);
            this.NewFolderContext.Text = "New folder";
            this.NewFolderContext.Click += new System.EventHandler(this.NewFolderClick);
            // 
            // InfoContext
            // 
            this.InfoContext.Image = global::StorageHolder.Properties.Resources.icons8_info_24;
            this.InfoContext.Name = "InfoContext";
            this.InfoContext.Size = new System.Drawing.Size(188, 22);
            this.InfoContext.Text = "Info";
            this.InfoContext.Visible = false;
            this.InfoContext.Click += new System.EventHandler(this.InfoContext_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // TreeImageList
            // 
            this.TreeImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.TreeImageList.ImageSize = new System.Drawing.Size(16, 16);
            this.TreeImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // BreadCrumbsPanel
            // 
            this.BreadCrumbsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BreadCrumbsPanel.AutoSize = false;
            this.BreadCrumbsPanel.BackColor = System.Drawing.Color.Transparent;
            this.BreadCrumbsPanel.CanOverflow = false;
            this.BreadCrumbsPanel.Dock = System.Windows.Forms.DockStyle.None;
            this.BreadCrumbsPanel.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.BreadCrumbsPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.BreadCrumbsPanel.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.BreadCrumbsPanel.Location = new System.Drawing.Point(151, 0);
            this.BreadCrumbsPanel.Name = "BreadCrumbsPanel";
            this.BreadCrumbsPanel.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.BreadCrumbsPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BreadCrumbsPanel.Size = new System.Drawing.Size(693, 36);
            this.BreadCrumbsPanel.Stretch = true;
            this.BreadCrumbsPanel.TabIndex = 7;
            this.BreadCrumbsPanel.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 33);
            this.toolStripButton1.Text = "/";
            // 
            // StorageListCount
            // 
            this.StorageListCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StorageListCount.AutoSize = true;
            this.StorageListCount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StorageListCount.Location = new System.Drawing.Point(3, 695);
            this.StorageListCount.Name = "StorageListCount";
            this.StorageListCount.Size = new System.Drawing.Size(103, 13);
            this.StorageListCount.TabIndex = 6;
            this.StorageListCount.Text = "                                ";
            // 
            // RightComboBox
            // 
            this.RightComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RightComboBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.RightComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RightComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RightComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RightComboBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RightComboBox.FormattingEnabled = true;
            this.RightComboBox.Items.AddRange(new object[] {
            "Dropbox",
            "Google Drive"});
            this.RightComboBox.Location = new System.Drawing.Point(703, 2);
            this.RightComboBox.Name = "RightComboBox";
            this.RightComboBox.Size = new System.Drawing.Size(167, 24);
            this.RightComboBox.TabIndex = 1;
            this.RightComboBox.TabStop = false;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TopPanel.Controls.Add(this.LogOutButton);
            this.TopPanel.Controls.Add(this.UserLabel);
            this.TopPanel.Controls.Add(this.DownloadButton);
            this.TopPanel.Controls.Add(this.AppName);
            this.TopPanel.Controls.Add(this.StoragePageButton);
            this.TopPanel.Controls.Add(this.RightComboBox);
            this.TopPanel.Controls.Add(this.SettingsButton);
            this.TopPanel.Controls.Add(this.ExitButton);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1021, 29);
            this.TopPanel.TabIndex = 8;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            // 
            // LogOutButton
            // 
            this.LogOutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LogOutButton.BackColor = System.Drawing.Color.MintCream;
            this.LogOutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogOutButton.FlatAppearance.BorderSize = 0;
            this.LogOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOutButton.Image = global::StorageHolder.Properties.Resources.icons8_log_in_24;
            this.LogOutButton.Location = new System.Drawing.Point(664, 0);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(33, 29);
            this.LogOutButton.TabIndex = 102;
            this.LogOutButton.TabStop = false;
            this.toolTip1.SetToolTip(this.LogOutButton, "Log Out");
            this.LogOutButton.UseVisualStyleBackColor = false;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // UserLabel
            // 
            this.UserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserLabel.Image = global::StorageHolder.Properties.Resources.icons8_user_24;
            this.UserLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UserLabel.Location = new System.Drawing.Point(529, 0);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(129, 29);
            this.UserLabel.TabIndex = 101;
            this.UserLabel.Text = "User Name";
            this.UserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DownloadButton
            // 
            this.DownloadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DownloadButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DownloadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DownloadButton.FlatAppearance.BorderSize = 0;
            this.DownloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DownloadButton.Image = global::StorageHolder.Properties.Resources.icons8_download_from_the_cloud_24;
            this.DownloadButton.Location = new System.Drawing.Point(876, 0);
            this.DownloadButton.Name = "DownloadButton";
            this.DownloadButton.Size = new System.Drawing.Size(33, 29);
            this.DownloadButton.TabIndex = 100;
            this.DownloadButton.TabStop = false;
            this.toolTip1.SetToolTip(this.DownloadButton, "Storage FileSystem");
            this.DownloadButton.UseVisualStyleBackColor = false;
            // 
            // AppName
            // 
            this.AppName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AppName.AutoSize = true;
            this.AppName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AppName.Location = new System.Drawing.Point(12, 6);
            this.AppName.Name = "AppName";
            this.AppName.Size = new System.Drawing.Size(114, 16);
            this.AppName.TabIndex = 12;
            this.AppName.Text = "Storage Holder";
            // 
            // StoragePageButton
            // 
            this.StoragePageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StoragePageButton.BackColor = System.Drawing.SystemColors.Window;
            this.StoragePageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StoragePageButton.FlatAppearance.BorderSize = 0;
            this.StoragePageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StoragePageButton.Image = global::StorageHolder.Properties.Resources.icons8_shared_folder_24;
            this.StoragePageButton.Location = new System.Drawing.Point(909, 0);
            this.StoragePageButton.Name = "StoragePageButton";
            this.StoragePageButton.Size = new System.Drawing.Size(33, 29);
            this.StoragePageButton.TabIndex = 11;
            this.StoragePageButton.TabStop = false;
            this.toolTip1.SetToolTip(this.StoragePageButton, "Storage FileSystem");
            this.StoragePageButton.UseVisualStyleBackColor = false;
            this.StoragePageButton.Click += new System.EventHandler(this.StoragePageButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingsButton.BackColor = System.Drawing.SystemColors.Menu;
            this.SettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingsButton.FlatAppearance.BorderSize = 0;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Image = global::StorageHolder.Properties.Resources.icons8_settings_24;
            this.SettingsButton.Location = new System.Drawing.Point(942, 0);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(33, 29);
            this.SettingsButton.TabIndex = 10;
            this.SettingsButton.TabStop = false;
            this.toolTip1.SetToolTip(this.SettingsButton, "Settings");
            this.SettingsButton.UseVisualStyleBackColor = false;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.BackColor = System.Drawing.Color.Red;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Image = global::StorageHolder.Properties.Resources.icons8_shutdown_24;
            this.ExitButton.Location = new System.Drawing.Point(975, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(46, 29);
            this.ExitButton.TabIndex = 9;
            this.ExitButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.ExitButton, "Exit");
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SettingsPage
            // 
            this.SettingsPage.BackColor = System.Drawing.SystemColors.Menu;
            this.SettingsPage.Controls.Add(this.StorageFolderPage);
            this.SettingsPage.Controls.Add(this.lollipopFlatButton1);
            this.SettingsPage.Controls.Add(this.lollipopToggle1);
            this.SettingsPage.Controls.Add(this.lollipopFolderInPut1);
            this.SettingsPage.Controls.Add(this.lollipopButton1);
            this.SettingsPage.Controls.Add(this.lollipopLabel1);
            this.SettingsPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsPage.Location = new System.Drawing.Point(0, 0);
            this.SettingsPage.Name = "SettingsPage";
            this.SettingsPage.Size = new System.Drawing.Size(844, 712);
            this.SettingsPage.TabIndex = 99;
            // 
            // StorageFolderPage
            // 
            this.StorageFolderPage.Controls.Add(this.progressBar1);
            this.StorageFolderPage.Controls.Add(this.NewFolderButton);
            this.StorageFolderPage.Controls.Add(this.RefreshButton);
            this.StorageFolderPage.Controls.Add(this.DeleteButton);
            this.StorageFolderPage.Controls.Add(this.BreadCrumbsPanel);
            this.StorageFolderPage.Controls.Add(this.StorageFilesList);
            this.StorageFolderPage.Controls.Add(this.UpButton);
            this.StorageFolderPage.Controls.Add(this.StorageListCount);
            this.StorageFolderPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StorageFolderPage.Location = new System.Drawing.Point(0, 0);
            this.StorageFolderPage.Name = "StorageFolderPage";
            this.StorageFolderPage.Size = new System.Drawing.Size(844, 712);
            this.StorageFolderPage.TabIndex = 10;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(0, 35);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(844, 4);
            this.progressBar1.TabIndex = 13;
            // 
            // NewFolderButton
            // 
            this.NewFolderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewFolderButton.FlatAppearance.BorderSize = 0;
            this.NewFolderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewFolderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewFolderButton.Image = global::StorageHolder.Properties.Resources.icons8_documents_folder_24;
            this.NewFolderButton.Location = new System.Drawing.Point(110, 0);
            this.NewFolderButton.Name = "NewFolderButton";
            this.NewFolderButton.Size = new System.Drawing.Size(38, 35);
            this.NewFolderButton.TabIndex = 11;
            this.toolTip1.SetToolTip(this.NewFolderButton, "New Folder");
            this.NewFolderButton.UseVisualStyleBackColor = true;
            this.NewFolderButton.Click += new System.EventHandler(this.NewFolderClick);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RefreshButton.FlatAppearance.BorderSize = 0;
            this.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RefreshButton.Image = global::StorageHolder.Properties.Resources.icons8_restart_24;
            this.RefreshButton.Location = new System.Drawing.Point(71, 0);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(38, 35);
            this.RefreshButton.TabIndex = 10;
            this.toolTip1.SetToolTip(this.RefreshButton, "Refresh");
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshClick);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteButton.Image = global::StorageHolder.Properties.Resources.icons8_trash_24;
            this.DeleteButton.Location = new System.Drawing.Point(35, 0);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(38, 35);
            this.DeleteButton.TabIndex = 9;
            this.toolTip1.SetToolTip(this.DeleteButton, "Delete");
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteClicked);
            // 
            // UpButton
            // 
            this.UpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpButton.Enabled = false;
            this.UpButton.FlatAppearance.BorderSize = 0;
            this.UpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpButton.Image = global::StorageHolder.Properties.Resources.icons8_arrow_up_24;
            this.UpButton.Location = new System.Drawing.Point(0, 0);
            this.UpButton.Name = "UpButton";
            this.UpButton.Size = new System.Drawing.Size(38, 35);
            this.UpButton.TabIndex = 8;
            this.toolTip1.SetToolTip(this.UpButton, "Up");
            this.UpButton.UseVisualStyleBackColor = true;
            this.UpButton.Click += new System.EventHandler(this.UpButtonClick);
            // 
            // lollipopFlatButton1
            // 
            this.lollipopFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.lollipopFlatButton1.FontColor = "#508ef5";
            this.lollipopFlatButton1.Location = new System.Drawing.Point(164, 308);
            this.lollipopFlatButton1.Name = "lollipopFlatButton1";
            this.lollipopFlatButton1.Size = new System.Drawing.Size(102, 29);
            this.lollipopFlatButton1.TabIndex = 12;
            this.lollipopFlatButton1.Text = "lollipopFlatButton1";
            // 
            // lollipopToggle1
            // 
            this.lollipopToggle1.AutoSize = true;
            this.lollipopToggle1.EllipseBorderColor = "#3b73d1";
            this.lollipopToggle1.EllipseColor = "#508ef5";
            this.lollipopToggle1.Location = new System.Drawing.Point(279, 242);
            this.lollipopToggle1.Name = "lollipopToggle1";
            this.lollipopToggle1.Size = new System.Drawing.Size(47, 19);
            this.lollipopToggle1.TabIndex = 15;
            this.lollipopToggle1.Text = "lollipopToggle1";
            this.lollipopToggle1.UseVisualStyleBackColor = true;
            // 
            // lollipopFolderInPut1
            // 
            this.lollipopFolderInPut1.FocusedColor = "#508ef5";
            this.lollipopFolderInPut1.FontColor = "#999999";
            this.lollipopFolderInPut1.IsEnabled = true;
            this.lollipopFolderInPut1.Location = new System.Drawing.Point(175, 61);
            this.lollipopFolderInPut1.MaxLength = 32767;
            this.lollipopFolderInPut1.Name = "lollipopFolderInPut1";
            this.lollipopFolderInPut1.ReadOnly = false;
            this.lollipopFolderInPut1.Size = new System.Drawing.Size(300, 24);
            this.lollipopFolderInPut1.TabIndex = 13;
            this.lollipopFolderInPut1.Text = "lollipopFolderInPut1";
            this.lollipopFolderInPut1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.lollipopFolderInPut1.UseSystemPasswordChar = false;
            // 
            // lollipopButton1
            // 
            this.lollipopButton1.BackColor = System.Drawing.Color.Transparent;
            this.lollipopButton1.BGColor = "#508ef5";
            this.lollipopButton1.FontColor = "#ffffff";
            this.lollipopButton1.Location = new System.Drawing.Point(487, 61);
            this.lollipopButton1.Name = "lollipopButton1";
            this.lollipopButton1.Size = new System.Drawing.Size(102, 24);
            this.lollipopButton1.TabIndex = 11;
            this.lollipopButton1.Text = "lollipopButton1";
            // 
            // lollipopLabel1
            // 
            this.lollipopLabel1.AutoSize = true;
            this.lollipopLabel1.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel1.Font = new System.Drawing.Font("Roboto Medium", 10F);
            this.lollipopLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel1.Location = new System.Drawing.Point(6, 63);
            this.lollipopLabel1.Name = "lollipopLabel1";
            this.lollipopLabel1.Size = new System.Drawing.Size(163, 19);
            this.lollipopLabel1.TabIndex = 14;
            this.lollipopLabel1.Text = "Default download folder:";
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.LeftPanel.Controls.Add(this.StoragesPanel);
            this.LeftPanel.Controls.Add(this.TreePanel);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 29);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(177, 712);
            this.LeftPanel.TabIndex = 9;
            // 
            // StoragesPanel
            // 
            this.StoragesPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.StoragesPanel.Controls.Add(this.StoragePanelCapture);
            this.StoragesPanel.Location = new System.Drawing.Point(0, 0);
            this.StoragesPanel.Name = "StoragesPanel";
            this.StoragesPanel.Size = new System.Drawing.Size(177, 29);
            this.StoragesPanel.TabIndex = 1;
            // 
            // StoragePanelCapture
            // 
            this.StoragePanelCapture.BackColor = System.Drawing.SystemColors.GrayText;
            this.StoragePanelCapture.Controls.Add(this.StorageCaptureLabel);
            this.StoragePanelCapture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StoragePanelCapture.Dock = System.Windows.Forms.DockStyle.Top;
            this.StoragePanelCapture.Location = new System.Drawing.Point(0, 0);
            this.StoragePanelCapture.Name = "StoragePanelCapture";
            this.StoragePanelCapture.Size = new System.Drawing.Size(177, 30);
            this.StoragePanelCapture.TabIndex = 0;
            // 
            // StorageCaptureLabel
            // 
            this.StorageCaptureLabel.AutoSize = true;
            this.StorageCaptureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StorageCaptureLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.StorageCaptureLabel.Location = new System.Drawing.Point(4, 5);
            this.StorageCaptureLabel.Name = "StorageCaptureLabel";
            this.StorageCaptureLabel.Size = new System.Drawing.Size(82, 20);
            this.StorageCaptureLabel.TabIndex = 0;
            this.StorageCaptureLabel.Text = "Storages";
            // 
            // TreePanel
            // 
            this.TreePanel.Controls.Add(this.TreePanelCapture);
            this.TreePanel.Controls.Add(this.StorageTreeView);
            this.TreePanel.Location = new System.Drawing.Point(0, 35);
            this.TreePanel.Name = "TreePanel";
            this.TreePanel.Size = new System.Drawing.Size(177, 677);
            this.TreePanel.TabIndex = 0;
            // 
            // TreePanelCapture
            // 
            this.TreePanelCapture.BackColor = System.Drawing.SystemColors.GrayText;
            this.TreePanelCapture.Controls.Add(this.TreeViewLabel);
            this.TreePanelCapture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TreePanelCapture.Dock = System.Windows.Forms.DockStyle.Top;
            this.TreePanelCapture.Location = new System.Drawing.Point(0, 0);
            this.TreePanelCapture.Name = "TreePanelCapture";
            this.TreePanelCapture.Size = new System.Drawing.Size(177, 30);
            this.TreePanelCapture.TabIndex = 1;
            this.toolTip1.SetToolTip(this.TreePanelCapture, "Show File System as tree");
            // 
            // TreeViewLabel
            // 
            this.TreeViewLabel.AutoSize = true;
            this.TreeViewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TreeViewLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.TreeViewLabel.Location = new System.Drawing.Point(3, 5);
            this.TreeViewLabel.Name = "TreeViewLabel";
            this.TreeViewLabel.Size = new System.Drawing.Size(83, 20);
            this.TreeViewLabel.TabIndex = 0;
            this.TreeViewLabel.Text = "TreeView";
            // 
            // StorageTreeView
            // 
            this.StorageTreeView.BackColor = System.Drawing.SystemColors.ControlDark;
            this.StorageTreeView.Location = new System.Drawing.Point(0, 28);
            this.StorageTreeView.Name = "StorageTreeView";
            this.StorageTreeView.Size = new System.Drawing.Size(177, 649);
            this.StorageTreeView.TabIndex = 0;
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.SystemColors.Window;
            this.LoginPanel.Controls.Add(this.SettingsPage);
            this.LoginPanel.Controls.Add(this.lollipopButton2);
            this.LoginPanel.Controls.Add(this.PasswordLabel);
            this.LoginPanel.Controls.Add(this.LoginLabel);
            this.LoginPanel.Controls.Add(this.PasswordField);
            this.LoginPanel.Controls.Add(this.LoginField);
            this.LoginPanel.Controls.Add(this.label1);
            this.LoginPanel.Controls.Add(this.lollipopFlatButton2);
            this.LoginPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginPanel.Location = new System.Drawing.Point(177, 29);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(844, 712);
            this.LoginPanel.TabIndex = 100;
            // 
            // lollipopButton2
            // 
            this.lollipopButton2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lollipopButton2.BackColor = System.Drawing.Color.Transparent;
            this.lollipopButton2.BGColor = "#508ef5";
            this.lollipopButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lollipopButton2.FontColor = "#ffffff";
            this.lollipopButton2.Location = new System.Drawing.Point(334, 385);
            this.lollipopButton2.Name = "lollipopButton2";
            this.lollipopButton2.Size = new System.Drawing.Size(143, 41);
            this.lollipopButton2.TabIndex = 5;
            this.lollipopButton2.Text = "Log In";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.PasswordLabel.Font = new System.Drawing.Font("Roboto Medium", 10F);
            this.PasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.PasswordLabel.Location = new System.Drawing.Point(173, 333);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(71, 19);
            this.PasswordLabel.TabIndex = 4;
            this.PasswordLabel.Text = "Password";
            // 
            // LoginLabel
            // 
            this.LoginLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.BackColor = System.Drawing.Color.Transparent;
            this.LoginLabel.Font = new System.Drawing.Font("Roboto Medium", 10F);
            this.LoginLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.LoginLabel.Location = new System.Drawing.Point(173, 284);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(45, 19);
            this.LoginLabel.TabIndex = 3;
            this.LoginLabel.Text = "Login";
            // 
            // PasswordField
            // 
            this.PasswordField.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PasswordField.FocusedColor = "#508ef5";
            this.PasswordField.FontColor = "#999999";
            this.PasswordField.IsEnabled = true;
            this.PasswordField.Location = new System.Drawing.Point(177, 355);
            this.PasswordField.MaxLength = 32767;
            this.PasswordField.Multiline = false;
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.ReadOnly = false;
            this.PasswordField.Size = new System.Drawing.Size(300, 24);
            this.PasswordField.TabIndex = 2;
            this.PasswordField.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.PasswordField.UseSystemPasswordChar = true;
            // 
            // LoginField
            // 
            this.LoginField.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LoginField.BackColor = System.Drawing.SystemColors.Window;
            this.LoginField.FocusedColor = "#508ef5";
            this.LoginField.FontColor = "#999999";
            this.LoginField.IsEnabled = true;
            this.LoginField.Location = new System.Drawing.Point(177, 306);
            this.LoginField.MaxLength = 32767;
            this.LoginField.Multiline = false;
            this.LoginField.Name = "LoginField";
            this.LoginField.ReadOnly = false;
            this.LoginField.Size = new System.Drawing.Size(300, 24);
            this.LoginField.TabIndex = 1;
            this.LoginField.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.LoginField.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(183, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Storage Holder";
            // 
            // lollipopFlatButton2
            // 
            this.lollipopFlatButton2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lollipopFlatButton2.BackColor = System.Drawing.Color.Transparent;
            this.lollipopFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lollipopFlatButton2.FontColor = "#508ef5";
            this.lollipopFlatButton2.Location = new System.Drawing.Point(177, 385);
            this.lollipopFlatButton2.Name = "lollipopFlatButton2";
            this.lollipopFlatButton2.Size = new System.Drawing.Size(143, 41);
            this.lollipopFlatButton2.TabIndex = 6;
            this.lollipopFlatButton2.Text = "Registration";
            // 
            // WorkDirectioryForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1021, 741);
            this.Controls.Add(this.LoginPanel);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WorkDirectioryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Storage File Manager";
            this.SelectedFilesContextMenu.ResumeLayout(false);
            this.BreadCrumbsPanel.ResumeLayout(false);
            this.BreadCrumbsPanel.PerformLayout();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.SettingsPage.ResumeLayout(false);
            this.SettingsPage.PerformLayout();
            this.StorageFolderPage.ResumeLayout(false);
            this.StorageFolderPage.PerformLayout();
            this.LeftPanel.ResumeLayout(false);
            this.StoragesPanel.ResumeLayout(false);
            this.StoragePanelCapture.ResumeLayout(false);
            this.StoragePanelCapture.PerformLayout();
            this.TreePanel.ResumeLayout(false);
            this.TreePanelCapture.ResumeLayout(false);
            this.TreePanelCapture.PerformLayout();
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView StorageFilesList;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip SelectedFilesContextMenu;
        private System.Windows.Forms.ToolStripMenuItem DownloadFileContext;
        private System.Windows.Forms.ToolStripMenuItem DownloadFileAsContext;
        private System.Windows.Forms.ToolStripMenuItem RefreshContext;
        private System.Windows.Forms.ImageList TreeImageList;
        private System.Windows.Forms.ToolStrip BreadCrumbsPanel;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ComboBox RightComboBox;
        private System.Windows.Forms.Label StorageListCount;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Button StoragePageButton;
        private System.Windows.Forms.Panel StorageFolderPage;
        private System.Windows.Forms.Panel SettingsPage;
        private System.Windows.Forms.Label AppName;
        private System.Windows.Forms.Panel TreePanel;
        private System.Windows.Forms.Panel TreePanelCapture;
        private System.Windows.Forms.Label TreeViewLabel;
        private System.Windows.Forms.TreeView StorageTreeView;
        private System.Windows.Forms.Button UpButton;
        private System.Windows.Forms.Panel StoragesPanel;
        private System.Windows.Forms.Panel StoragePanelCapture;
        private System.Windows.Forms.Label StorageCaptureLabel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button DownloadButton;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button NewFolderButton;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.ToolStripMenuItem DeleteContext;
        private System.Windows.Forms.ToolStripMenuItem NewFolderContext;
        private System.Windows.Forms.ToolStripMenuItem InfoContext;
        private System.Windows.Forms.ToolStripMenuItem DownloadZipContext;
        private System.Windows.Forms.ToolStripMenuItem GetSharedLinkClipboardContext;
        private System.Windows.Forms.ToolStripMenuItem RenameContext;
        private LollipopFlatButton lollipopFlatButton1;
        private LollipopToggle lollipopToggle1;
        private LollipopFolderInPut lollipopFolderInPut1;
        private LollipopButton lollipopButton1;
        private LollipopLabel lollipopLabel1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel LoginPanel;
        private LollipopButton lollipopButton2;
        private LollipopLabel PasswordLabel;
        private LollipopLabel LoginLabel;
        private LollipopTextBox PasswordField;
        private LollipopTextBox LoginField;
        private System.Windows.Forms.Label label1;
        private LollipopFlatButton lollipopFlatButton2;
    }
}