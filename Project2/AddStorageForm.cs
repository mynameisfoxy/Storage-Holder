using System.Windows.Forms;
using System.Threading.Tasks;
using Dropbox.Api;
using System;
using System.Diagnostics;
using SQLite;
using System.Collections.Generic;

namespace StorageHolder
{
    public partial class AddStorageForm : Form
    {
        static string RoamingPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Project2";
        static string DataBasePath = RoamingPath + "\\MyData.db";
        string DropboxCode;
        string GoogleCode;
        int UserId;
        bool IsDropboxEnable = false;
        bool IsGoogleEnable = false;

        public AddStorageForm(string DropboxCodeIn, string GoogleCodeIn, int UserIdIn)
        {
            DropboxCode = DropboxCodeIn;
            GoogleCode = GoogleCodeIn;
            UserId = UserIdIn;

            if (!String.IsNullOrEmpty(DropboxCode))
            {
                IsDropboxEnable = true;
            }

            if (!String.IsNullOrEmpty(GoogleCode))
            {
                IsGoogleEnable = true;
            }

            InitializeComponent();
            StorageList_SelectedIndexChanged(this, new EventArgs());
        }

        async private void NextBtn_Click(object sender, EventArgs e)
        {
            if (StorageList.SelectedIndices.Count > 0)
            {
                if (StorageList.SelectedIndices[0].Equals(0))
                {
                    if (!IsDropboxEnable)
                    {
                        Process.Start(DropboxOAuth2Helper.GetAuthorizeUri("jj2eyo41xn837y7", false).ToString()); //вызов страницы для подтверждения доступа и получения кода
                        CodeConfirmForm LetMeConfirm = new CodeConfirmForm();
                        LetMeConfirm.ShowDialog();
                        OAuth2Response resp = await DropboxOAuth2Helper.ProcessCodeFlowAsync(LetMeConfirm.CodeConfirm, "jj2eyo41xn837y7", "ldfel2pg0e7yery", null, null);
                        DropboxCode = resp.AccessToken;
                        LetMeConfirm.Close();
                        SQLiteConnection db = new SQLiteConnection(DataBasePath);
                        List<StorageClass> DataStorageImport = new List<StorageClass>();
                        DataStorageImport = db.Query<StorageClass>("SELECT * FROM StorageKeys WHERE UserId='" + UserId + "'");
                        if (DataStorageImport.Count > 0)
                        {
                            DataStorageImport = db.Query<StorageClass>("UPDATE StorageKeys SET DropboxKey='" + DropboxCode + "'" + "WHERE UserId='" + UserId + "'");
                        }
                        else
                        {
                            StorageClass RegUserInfo = new StorageClass()
                            {
                                Id = UserId,
                                DropBox = DropboxCode
                            };
                            db.Insert(RegUserInfo);
                        }
                        IsDropboxEnable = true;
                    }
                    //using (DropboxClient dbx = new DropboxClient(DropboxCode))
                    //{
                    //    var full = await dbx.Users.GetCurrentAccountAsync();
                    //    MessageBox.Show("Username: " + full.Name.DisplayName + "\n E-mail: " + full.Email);
                    //}
                    WorkDirectioryForm WorkDirectory = new WorkDirectioryForm();
                    WorkDirectory.Show();
                    this.Hide();
                }
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StorageList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StorageList.SelectedIndices.Count > 0)
            {
                if (StorageList.SelectedIndices[0].Equals(0) && IsDropboxEnable ||
                StorageList.SelectedIndices[0].Equals(1) && IsGoogleEnable)
                {
                    NextBtn.Text = "Далее";
                }
                else
                {
                    NextBtn.Text = "Авторизация";
                }
            }
        }
    }
}
