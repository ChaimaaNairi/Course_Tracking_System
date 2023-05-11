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
    public partial class OgrentmenAkademikTakvimiSayfa : Form
    {
        public OgrentmenAkademikTakvimiSayfa()
        {
            InitializeComponent();
        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void label47_Click(object sender, EventArgs e)
        {
            OgretmenSayfa x = new OgretmenSayfa();
            x.Show();
            this.Hide();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            OgretmenSayfa x = new OgretmenSayfa();
            x.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AnaSayfa x = new AnaSayfa();
            x.Show();
            this.Hide();
        }

        private void label33_Click(object sender, EventArgs e)
        {
            OgretmenDersler ogretmenDersler = new OgretmenDersler();
            ogretmenDersler.Show();
            this.Hide();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            OgretmenDersler x = new OgretmenDersler();
            x.Show();
            this.Hide();
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            OgrenciSayfa ogrenciSayfa = new OgrenciSayfa();
            ogrenciSayfa.Show();
            this.Hide();
        }
    }
}
