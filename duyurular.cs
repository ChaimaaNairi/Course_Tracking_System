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
    public partial class duyurular : Form
    {
        public duyurular()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            etkinlikler c = new etkinlikler();
            c.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            AnaSayfa v = new AnaSayfa();
            v.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Giris s = new Giris();
            s.Show();
            this.Hide();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kayit kayit = new Kayit();
            kayit.Show();
            this.Hide();
        }
    }
}
