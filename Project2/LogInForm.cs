using System;
using SQLite;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using StorageHolder.Authentication;

namespace StorageHolder
{
    public partial class LogInForm : Form
    {
        static string RoamingPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Project2";
        static string DataBasePath = RoamingPath + "\\MyData.db";
        Auth AuthApi = Auth.GetInstance();

        public LogInForm()
        {
            InitializeComponent();
        }

        private void CheckFields(object sender, EventArgs e)
        {
            if (LoginField.Text.Length >= 4 && PasswordField.Text.Length >= 6)
            {
                LogInButton.Enabled = true;
            }
            else
            {
                LogInButton.Enabled = false;
            }
        }

        private void RegButtonClicked(object sender, EventArgs e)
        {
            RegForm reg = new RegForm();
            reg.ShowDialog();
        }

        private void LogInButtonClicked(object sender, EventArgs e)
        {
            AuthApi.LogIn(LoginField.Text, PasswordField.Text);
        }
    }
}
