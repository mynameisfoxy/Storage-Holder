namespace StorageHolder.Misc
{
    partial class ItemInfoForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Cls = new System.Windows.Forms.Button();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.FileName = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.Path = new System.Windows.Forms.Label();
            this.PathLabel = new System.Windows.Forms.Label();
            this.Sz = new System.Windows.Forms.Label();
            this.SzLabel = new System.Windows.Forms.Label();
            this.ServerModified = new System.Windows.Forms.Label();
            this.ServerModifiedLabel = new System.Windows.Forms.Label();
            this.ClientModified = new System.Windows.Forms.Label();
            this.ClientModofiedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 26);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // Cls
            // 
            this.Cls.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cls.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Cls.FlatAppearance.BorderSize = 0;
            this.Cls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cls.Image = global::StorageHolder.Properties.Resources.icons8_checkmark_24;
            this.Cls.Location = new System.Drawing.Point(111, 175);
            this.Cls.Name = "Cls";
            this.Cls.Size = new System.Drawing.Size(75, 23);
            this.Cls.TabIndex = 1;
            this.Cls.UseVisualStyleBackColor = true;
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.Location = new System.Drawing.Point(12, 67);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(55, 13);
            this.FileNameLabel.TabIndex = 2;
            this.FileNameLabel.Text = "File name:";
            // 
            // FileName
            // 
            this.FileName.AutoSize = true;
            this.FileName.Location = new System.Drawing.Point(73, 67);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(49, 13);
            this.FileName.TabIndex = 3;
            this.FileName.Text = "              ";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(12, 45);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(21, 13);
            this.IDLabel.TabIndex = 4;
            this.IDLabel.Text = "ID:";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(39, 45);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(49, 13);
            this.ID.TabIndex = 5;
            this.ID.Text = "              ";
            // 
            // Path
            // 
            this.Path.AutoSize = true;
            this.Path.Location = new System.Drawing.Point(50, 88);
            this.Path.Name = "Path";
            this.Path.Size = new System.Drawing.Size(49, 13);
            this.Path.TabIndex = 7;
            this.Path.Text = "              ";
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.Location = new System.Drawing.Point(12, 88);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(32, 13);
            this.PathLabel.TabIndex = 6;
            this.PathLabel.Text = "Path:";
            // 
            // Sz
            // 
            this.Sz.AutoSize = true;
            this.Sz.Location = new System.Drawing.Point(48, 110);
            this.Sz.Name = "Sz";
            this.Sz.Size = new System.Drawing.Size(49, 13);
            this.Sz.TabIndex = 9;
            this.Sz.Text = "              ";
            // 
            // SzLabel
            // 
            this.SzLabel.AutoSize = true;
            this.SzLabel.Location = new System.Drawing.Point(12, 110);
            this.SzLabel.Name = "SzLabel";
            this.SzLabel.Size = new System.Drawing.Size(30, 13);
            this.SzLabel.TabIndex = 8;
            this.SzLabel.Text = "Size:";
            // 
            // ServerModified
            // 
            this.ServerModified.AutoSize = true;
            this.ServerModified.Location = new System.Drawing.Point(99, 132);
            this.ServerModified.Name = "ServerModified";
            this.ServerModified.Size = new System.Drawing.Size(49, 13);
            this.ServerModified.TabIndex = 11;
            this.ServerModified.Text = "              ";
            // 
            // ServerModifiedLabel
            // 
            this.ServerModifiedLabel.AutoSize = true;
            this.ServerModifiedLabel.Location = new System.Drawing.Point(12, 132);
            this.ServerModifiedLabel.Name = "ServerModifiedLabel";
            this.ServerModifiedLabel.Size = new System.Drawing.Size(83, 13);
            this.ServerModifiedLabel.TabIndex = 10;
            this.ServerModifiedLabel.Text = "Server modified:";
            // 
            // ClientModified
            // 
            this.ClientModified.AutoSize = true;
            this.ClientModified.Location = new System.Drawing.Point(99, 154);
            this.ClientModified.Name = "ClientModified";
            this.ClientModified.Size = new System.Drawing.Size(49, 13);
            this.ClientModified.TabIndex = 13;
            this.ClientModified.Text = "              ";
            // 
            // ClientModofiedLabel
            // 
            this.ClientModofiedLabel.AutoSize = true;
            this.ClientModofiedLabel.Location = new System.Drawing.Point(12, 154);
            this.ClientModofiedLabel.Name = "ClientModofiedLabel";
            this.ClientModofiedLabel.Size = new System.Drawing.Size(78, 13);
            this.ClientModofiedLabel.TabIndex = 12;
            this.ClientModofiedLabel.Text = "Client modified:";
            // 
            // ItemInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 210);
            this.Controls.Add(this.ClientModified);
            this.Controls.Add(this.ClientModofiedLabel);
            this.Controls.Add(this.ServerModified);
            this.Controls.Add(this.ServerModifiedLabel);
            this.Controls.Add(this.Sz);
            this.Controls.Add(this.SzLabel);
            this.Controls.Add(this.Path);
            this.Controls.Add(this.PathLabel);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.FileNameLabel);
            this.Controls.Add(this.Cls);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ItemInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItemInfoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Cls;
        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.Label FileName;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label Path;
        private System.Windows.Forms.Label PathLabel;
        private System.Windows.Forms.Label Sz;
        private System.Windows.Forms.Label SzLabel;
        private System.Windows.Forms.Label ServerModified;
        private System.Windows.Forms.Label ServerModifiedLabel;
        private System.Windows.Forms.Label ClientModified;
        private System.Windows.Forms.Label ClientModofiedLabel;
    }
}