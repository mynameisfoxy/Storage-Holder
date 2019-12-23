using System;
using SQLite;
using System.Windows.Forms;
using System.IO;

namespace StorageHolder
{
    public partial class RegForm : Form
    {
        static string RoamingPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Project2";
        static string DataBasePath = RoamingPath + "\\MyData.db";
        public RegForm()
        {
            InitializeComponent();
            
        }
        private void CheckFields(object sender, EventArgs e)
        {
            if (LoginField.Text.Length >= 4 && PasswordField.Text.Length >= 6 && PasswordCheckField.Text.Length >= 6 &&
                PasswordField.Text==PasswordCheckField.Text)
            {
                RegButton.Enabled = true;
            }
            else
            {
                RegButton.Enabled = false;
            }
        }
        private void Registry (object sender, EventArgs e)
        {
            SQLiteConnection db = new SQLiteConnection(DataBasePath);

            UserClass RegUserInfo = new UserClass()
            {
                UserName = HashFunc.GetHash(LoginField.Text),
                PassWord = HashFunc.GetHash(PasswordField.Text)
            };

            db.Insert(RegUserInfo);

            StorageClass RegStorageInfo = new StorageClass()
            {
                DropBox = null,
                Google = null,
                Id = RegUserInfo.Id,
            };

            db.Insert(RegStorageInfo);

            if (MessageBox.Show("Пользователь " + LoginField.Text + " успешно зарегистрирован!", "Внимание!", 
                MessageBoxButtons.OK) == DialogResult.OK)
            {
                this.Close();
            }
        }
        private void CloseClick (object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
