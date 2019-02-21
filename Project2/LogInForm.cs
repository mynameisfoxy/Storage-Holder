using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    public partial class LogInForm : Form
    {
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

        }
    }
}
