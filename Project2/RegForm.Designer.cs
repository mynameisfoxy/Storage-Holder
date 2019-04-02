namespace StorageHolder
{
    partial class RegForm
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
            this.ExitButton = new System.Windows.Forms.Button();
            this.RegButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LoginField = new System.Windows.Forms.TextBox();
            this.PasswordField = new System.Windows.Forms.TextBox();
            this.PasswordCheckField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(14, 90);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(156, 23);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "Отмена";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.CloseClick);
            // 
            // RegButton
            // 
            this.RegButton.Enabled = false;
            this.RegButton.Location = new System.Drawing.Point(176, 90);
            this.RegButton.Name = "RegButton";
            this.RegButton.Size = new System.Drawing.Size(156, 23);
            this.RegButton.TabIndex = 1;
            this.RegButton.Text = "Зарегистрировать";
            this.RegButton.UseVisualStyleBackColor = true;
            this.RegButton.Click += new System.EventHandler(this.Registry);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Повторить пароль";
            // 
            // LoginField
            // 
            this.LoginField.Location = new System.Drawing.Point(129, 12);
            this.LoginField.Name = "LoginField";
            this.LoginField.Size = new System.Drawing.Size(203, 20);
            this.LoginField.TabIndex = 5;
            this.LoginField.TextChanged += new System.EventHandler(this.CheckFields);
            // 
            // PasswordField
            // 
            this.PasswordField.Location = new System.Drawing.Point(129, 38);
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.PasswordChar = '*';
            this.PasswordField.Size = new System.Drawing.Size(203, 20);
            this.PasswordField.TabIndex = 6;
            this.PasswordField.TextChanged += new System.EventHandler(this.CheckFields);
            // 
            // PasswordCheckField
            // 
            this.PasswordCheckField.Location = new System.Drawing.Point(129, 64);
            this.PasswordCheckField.Name = "PasswordCheckField";
            this.PasswordCheckField.PasswordChar = '*';
            this.PasswordCheckField.Size = new System.Drawing.Size(203, 20);
            this.PasswordCheckField.TabIndex = 7;
            this.PasswordCheckField.TextChanged += new System.EventHandler(this.CheckFields);
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 123);
            this.Controls.Add(this.PasswordCheckField);
            this.Controls.Add(this.PasswordField);
            this.Controls.Add(this.LoginField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RegButton);
            this.Controls.Add(this.ExitButton);
            this.MaximizeBox = false;
            this.Name = "RegForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button RegButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LoginField;
        private System.Windows.Forms.TextBox PasswordField;
        private System.Windows.Forms.TextBox PasswordCheckField;
    }
}