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
    public partial class CopyProgress : Form
    {
        Point moveStart;

        public CopyProgress()
        {
            InitializeComponent();
        }
        public CopyProgress(string data1, string data2)
        {
            InitializeComponent();
            label1.Text = "Загружено " + data1 + " из " + data2 + " файлов.";
            progressBar1.Maximum = int.Parse(data2);
            if (int.Parse(data2) > 1)
            {
                progressBar1.Style = ProgressBarStyle.Blocks;
            } else
            {
                progressBar1.Style = ProgressBarStyle.Marquee;
            }
        }
        public void RefreshData(int progres, int outOf)
        {
            progressBar1.Value = progres;
            label1.Text = "Загружено " + progres.ToString() + " из " + outOf.ToString() + " файлов.";
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
