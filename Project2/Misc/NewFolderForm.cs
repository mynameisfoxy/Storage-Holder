using System;
using System.Drawing;
using System.Windows.Forms;

namespace StorageHolder.Misc
{
    public partial class NewFolderForm : Form
    {
        public string FolderName { get; protected set; }
        Point moveStart;

        public NewFolderForm()
        {
            InitializeComponent();
        }

        public void SetItemName (string Name)
        {
            FolderName = Name;
            FolderNameBox.Text = FolderName;
            FolderNameBox.Select(0, FolderNameBox.Text.LastIndexOf('.'));
        }

        private void OkButtonClick(object sender, EventArgs e)
        {
            FolderName = FolderNameBox.Text;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                moveStart = new Point(e.X, e.Y);
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) != 0)
            {
                // получаем новую точку положения формы
                Point deltaPos = new Point(e.X - moveStart.X, e.Y - moveStart.Y);
                // устанавливаем положение формы
                this.Location = new Point(this.Location.X + deltaPos.X,
                  this.Location.Y + deltaPos.Y);
            }
        }

        private void FolderNameBox_TextChanged(object sender, EventArgs e)
        {
            if (FolderNameBox.Text.Length < 1)
            {
                OkButton.Enabled = false;
            }
            else
            {
                OkButton.Enabled = true;
            }
        }
    }
}
