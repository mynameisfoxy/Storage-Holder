namespace StorageHolder
{
    partial class LogInForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoginField = new System.Windows.Forms.TextBox();
            this.PasswordField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LogInButton = new System.Windows.Forms.Button();
            this.Registry = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginField
            // 
            this.LoginField.Location = new System.Drawing.Point(123, 12);
            this.LoginField.Name = "LoginField";
            this.LoginField.Size = new System.Drawing.Size(214, 20);
            this.LoginField.TabIndex = 0;
            this.LoginField.TextChanged += new System.EventHandler(this.CheckFields);
            // 
            // PasswordField
            // 
            this.PasswordField.Location = new System.Drawing.Point(123, 38);
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.PasswordChar = '*';
            this.PasswordField.Size = new System.Drawing.Size(214, 20);
            this.PasswordField.TabIndex = 1;
            this.PasswordField.TextChanged += new System.EventHandler(this.CheckFields);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Имя пользователя";
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
            // LogInButton
            // 
            this.LogInButton.Enabled = false;
            this.LogInButton.Location = new System.Drawing.Point(179, 64);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(158, 23);
            this.LogInButton.TabIndex = 4;
            this.LogInButton.Text = "Войти";
            this.LogInButton.UseVisualStyleBackColor = true;
            this.LogInButton.Click += new System.EventHandler(this.LogInButtonClicked);
            // 
            // Registry
            // 
            this.Registry.Location = new System.Drawing.Point(15, 64);
            this.Registry.Name = "Registry";
            this.Registry.Size = new System.Drawing.Size(158, 23);
            this.Registry.TabIndex = 5;
            this.Registry.Text = "Регистрация";
            this.Registry.UseVisualStyleBackColor = true;
            this.Registry.Click += new System.EventHandler(this.RegButtonClicked);
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 97);
            this.Controls.Add(this.Registry);
            this.Controls.Add(this.LogInButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordField);
            this.Controls.Add(this.LoginField);
            this.MaximizeBox = false;
            this.Name = "LogInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginField;
        private System.Windows.Forms.TextBox PasswordField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LogInButton;
        private System.Windows.Forms.Button Registry;
    }
}

