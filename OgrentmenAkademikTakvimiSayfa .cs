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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label47_Click(object sender, EventArgs e)
        {

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
    }
}
