using Dropbox.Api;
using System.Diagnostics;
using System.Windows.Forms;

namespace StorageHolder
{
    public partial class CodeConfirmForm : Form
    {
        public string CodeConfirm
        {
            get { return Code.Text; }
        }

        public CodeConfirmForm()
        {
            InitializeComponent();
        }

        private void RetryButton_Click(object sender, System.EventArgs e)
        {
            Process.Start(DropboxOAuth2Helper.GetAuthorizeUri("jj2eyo41xn837y7", false).ToString()); //вызов страницы для подтверждения доступа и получения кода
        }

        private void CnclBtn_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void ConfirmButton_Click(object sender, System.EventArgs e)
        {
            this.Hide();
        }
    }
}
