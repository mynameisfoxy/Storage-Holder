namespace StorageHolder
{
    partial class CodeConfirmForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.Code = new System.Windows.Forms.TextBox();
            this.RetryButton = new System.Windows.Forms.Button();
            this.CnclBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите код подтверждения";
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(224, 42);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(107, 23);
            this.ConfirmButton.TabIndex = 1;
            this.ConfirmButton.Text = "Подтвердить";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // Code
            // 
            this.Code.Location = new System.Drawing.Point(170, 12);
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(161, 20);
            this.Code.TabIndex = 2;
            // 
            // RetryButton
            // 
            this.RetryButton.Location = new System.Drawing.Point(119, 42);
            this.RetryButton.Name = "RetryButton";
            this.RetryButton.Size = new System.Drawing.Size(99, 23);
            this.RetryButton.TabIndex = 3;
            this.RetryButton.Text = "Повторить";
            this.RetryButton.UseVisualStyleBackColor = true;
            this.RetryButton.Click += new System.EventHandler(this.RetryButton_Click);
            // 
            // CnclBtn
            // 
            this.CnclBtn.Location = new System.Drawing.Point(12, 42);
            this.CnclBtn.Name = "CnclBtn";
            this.CnclBtn.Size = new System.Drawing.Size(101, 23);
            this.CnclBtn.TabIndex = 4;
            this.CnclBtn.Text = "Отмена";
            this.CnclBtn.UseVisualStyleBackColor = true;
            this.CnclBtn.Click += new System.EventHandler(this.CnclBtn_Click);
            // 
            // CodeConfirmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 77);
            this.Controls.Add(this.CnclBtn);
            this.Controls.Add(this.RetryButton);
            this.Controls.Add(this.Code);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CodeConfirmForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Введите код подтверждения";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.TextBox Code;
        private System.Windows.Forms.Button RetryButton;
        private System.Windows.Forms.Button CnclBtn;
    }
}