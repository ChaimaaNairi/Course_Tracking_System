using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders_takip_sistemi
{
    public partial class OgrenciDersProgramiSayfa : Form
    {
        public OgrenciDersProgramiSayfa()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Click(object sender, EventArgs e)
        {
            OgrenciSayfa x = new OgrenciSayfa();
            x.Show();
            this.Hide();
        }

        private void label47_Click(object sender, EventArgs e)
        {
            OgrenciSayfa x = new OgrenciSayfa();
            x.Show();
            this.Hide();
        }

        private void label33_Click(object sender, EventArgs e)
        {
            OgrenciSayfa x = new OgrenciSayfa();
            x.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa();
            anaSayfa.Show();
            this.Hide();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            ogrenciDersler ogrenciDersler = new ogrenciDersler();
            ogrenciDersler.Show();
            this.Hide();
        }
    }
}
