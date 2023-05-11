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
    public partial class PersonelOgrenciListesi : Form
    {
        public PersonelOgrenciListesi()
        {
            InitializeComponent();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            PersonelSayfa personelSayfa = new PersonelSayfa();
            personelSayfa.Show();
            this.Hide();
        }

        private void label47_Click(object sender, EventArgs e)
        {
            PersonelSayfa personelSayfa = new PersonelSayfa();
            personelSayfa.Show();
            this.Hide();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            PersonelÖğretmenListesiSayfa x = new PersonelÖğretmenListesiSayfa();
            x.Show();
            this.Hide();
        }

        private void label34_Click(object sender, EventArgs e)
        {
            PersonelÖğretmenListesiSayfa x = new PersonelÖğretmenListesiSayfa();
            x.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa();
            anaSayfa.Show();
            this.Hide();
        }
    }
}
