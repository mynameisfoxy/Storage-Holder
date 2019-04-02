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
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Dropbox");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("GoogleDrive");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkDirectioryForm));
            this.listView1 = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DownloadFileContext = new System.Windows.Forms.ToolStripMenuItem();
            this.DownloadFileAsContext = new System.Windows.Forms.ToolStripMenuItem();
            this.fillerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.TreeImageList = new System.Windows.Forms.ImageList(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.BreadCrumbsPanel = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1.SuspendLayout();
            this.BreadCrumbsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.BackColor = System.Drawing.SystemColors.Window;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(166, 66);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(442, 397);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.StateImageList = this.imageList1;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DownloadFileContext,
            this.DownloadFileAsContext,
            this.fillerToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(150, 70);
            // 
            // DownloadFileContext
            // 
            this.DownloadFileContext.Name = "DownloadFileContext";
            this.DownloadFileContext.Size = new System.Drawing.Size(149, 22);
            this.DownloadFileContext.Text = "Загрузить";
            this.DownloadFileContext.Click += new System.EventHandler(this.DownloadItem_Click);
            // 
            // DownloadFileAsContext
            // 
            this.DownloadFileAsContext.Name = "DownloadFileAsContext";
            this.DownloadFileAsContext.Size = new System.Drawing.Size(149, 22);
            this.DownloadFileAsContext.Text = "Загрузить как";
            this.DownloadFileAsContext.Click += new System.EventHandler(this.DownloadItemAs_Click);
            // 
            // fillerToolStripMenuItem
            // 
            this.fillerToolStripMenuItem.Name = "fillerToolStripMenuItem";
            this.fillerToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.fillerToolStripMenuItem.Text = "Filler";
            this.fillerToolStripMenuItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "/";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(100, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "↑";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(274, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Лист";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(193, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Детали";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // treeView1
            // 
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.TreeImageList;
            this.treeView1.Location = new System.Drawing.Point(12, 66);
            this.treeView1.Name = "treeView1";
            treeNode3.ImageIndex = 0;
            treeNode3.Name = "DropboxNode";
            treeNode3.Text = "Dropbox";
            treeNode4.ImageIndex = 1;
            treeNode4.Name = "GoogleNode";
            treeNode4.Text = "GoogleDrive";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4});
            this.treeView1.SelectedImageIndex = 2;
            this.treeView1.Size = new System.Drawing.Size(148, 397);
            this.treeView1.StateImageList = this.imageList1;
            this.treeView1.TabIndex = 5;
            // 
            // TreeImageList
            // 
            this.TreeImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("TreeImageList.ImageStream")));
            this.TreeImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.TreeImageList.Images.SetKeyName(0, "twitter-card-glyph_m1@2x.png");
            this.TreeImageList.Images.SetKeyName(1, "1200px-Googledrive_logo.svg.png");
            this.TreeImageList.Images.SetKeyName(2, "w256h2561339870311Folder256.png");
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(365, 12);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(243, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // BreadCrumbsPanel
            // 
            this.BreadCrumbsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BreadCrumbsPanel.AutoSize = false;
            this.BreadCrumbsPanel.CanOverflow = false;
            this.BreadCrumbsPanel.Dock = System.Windows.Forms.DockStyle.None;
            this.BreadCrumbsPanel.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.BreadCrumbsPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.BreadCrumbsPanel.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.BreadCrumbsPanel.Location = new System.Drawing.Point(12, 38);
            this.BreadCrumbsPanel.Name = "BreadCrumbsPanel";
            this.BreadCrumbsPanel.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.BreadCrumbsPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BreadCrumbsPanel.Size = new System.Drawing.Size(596, 25);
            this.BreadCrumbsPanel.Stretch = true;
            this.BreadCrumbsPanel.TabIndex = 7;
            this.BreadCrumbsPanel.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 19);
            this.toolStripButton1.Text = "/";
            // 
            // WorkDirectioryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 475);
            this.Controls.Add(this.BreadCrumbsPanel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Name = "WorkDirectioryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorkDirectioryForm";
            this.contextMenuStrip1.ResumeLayout(false);
            this.BreadCrumbsPanel.ResumeLayout(false);
            this.BreadCrumbsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem DownloadFileContext;
        private System.Windows.Forms.ToolStripMenuItem DownloadFileAsContext;
        private System.Windows.Forms.ToolStripMenuItem fillerToolStripMenuItem;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ImageList TreeImageList;
        private System.Windows.Forms.ToolStrip BreadCrumbsPanel;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}