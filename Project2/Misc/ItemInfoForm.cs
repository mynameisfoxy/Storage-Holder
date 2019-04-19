using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorageHolder.Misc
{
    public partial class ItemInfoForm : Form
    {
        Point moveStart;

        public ItemInfoForm()
        {
            InitializeComponent();
        }

        public ItemInfoForm(string _ID, string _FileName, string _Path, float _Size, DateTime _ServerModified, DateTime _ClientModified)
        {
            InitializeComponent();
            ID.Text = _ID;
            FileName.Text = _FileName;
            Path.Text = _Path;
            Size.Text = _Size.ToString() + " bytes"; //fix size output
            ServerModified.Text = _ServerModified.ToString();
            ClientModified.Text = _ClientModified.ToString();
        }

        public ItemInfoForm(string _ID, string _FileName, string _Path)
        {
            InitializeComponent();
            ID.Text = _ID;
            FileName.Text = _FileName;
            Path.Text = _Path;
            Size.Visible = false;
            ServerModifiedLabel.Visible = false;
            ServerModified.Visible = false;
            ClientModified.Visible = false;
            ClientModofiedLabel.Visible = false;
            SizeLabel.Visible = false;
            Size.Visible = false;
            this.Height = 137;
            Close.Location = new Point(103,106);
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
    }
}
