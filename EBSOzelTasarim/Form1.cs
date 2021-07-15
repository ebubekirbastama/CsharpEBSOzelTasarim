using System;
using System.Drawing;
using System.Windows.Forms;

namespace EBSOzelTasarim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //www.ebubekirbastama.com
        //iletişim:05554128854
        //twitter:@ebubekirstt

        bool formTasiniyor = false;
        Point baslangicNoktasi = new Point(0, 0);
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            formTasiniyor = true;
            baslangicNoktasi = new Point(e.X, e.Y);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            formTasiniyor = false;
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (formTasiniyor)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.baslangicNoktasi.X, p.Y - this.baslangicNoktasi.Y);
            }
        }

    }
}
