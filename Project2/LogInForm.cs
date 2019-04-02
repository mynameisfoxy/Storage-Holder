using System;
using SQLite;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace StorageHolder
{
    public partial class LogInForm : Form
    {
        static string RoamingPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Project2";
        static string DataBasePath = RoamingPath + "\\MyData.db";
        public LogInForm()
        {
            InitializeComponent();
            //=========================================================
            if (!Directory.Exists(RoamingPath))
            {
                Directory.CreateDirectory(RoamingPath);
            }
            SQLiteConnection db = new SQLiteConnection(DataBasePath);
            db.CreateTable<UserClass>();
            db.CreateTable<StorageClass>();
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
            SQLiteConnection db = new SQLiteConnection(DataBasePath);
            List<UserClass> DataUserImport = new List<UserClass>();
            List<StorageClass> DataStorageImport = new List<StorageClass>();
            DataUserImport = db.Query<UserClass>("SELECT * FROM UserTable WHERE ColumnUsername='" + HashFunc.GetHash(LoginField.Text) + "'");
            DataStorageImport = db.Query<StorageClass>("SELECT * FROM StorageKeys WHERE UserId='" + DataUserImport[0].Id + "'");
            if (DataUserImport.Count>0)
            {
                if (DataUserImport[0].PassWord != HashFunc.GetHash(PasswordField.Text))
                {
                    MessageBox.Show("Пароль инкоррект!");
                }
                else
                {
                    AddStorageForm frm = new AddStorageForm(DataStorageImport[0].DropBox, DataStorageImport[0].Google, DataUserImport[0].Id);
                    frm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show(LoginField.Text + " не найден!");
            }
        }
    }
}
