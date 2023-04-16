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
    public partial class OgretmenSayfa : Form
    {
        public OgretmenSayfa()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            OgrentmenAkademikTakvimiSayfa x = new OgrentmenAkademikTakvimiSayfa();
            x.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AnaSayfa x= new AnaSayfa();
            x.Show();
            this.Hide();
        }
    }
}
