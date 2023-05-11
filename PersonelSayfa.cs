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
    public partial class PersonelSayfa : Form
    {
        public PersonelSayfa()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            PersonelÖğretmenListesiSayfa c = new PersonelÖğretmenListesiSayfa();
            c.Show();
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
            PersonelOgrenciListesi personelOgrenciListesi = new PersonelOgrenciListesi();
            personelOgrenciListesi.Show();
                this.Hide();
        }

        private void label33_Click(object sender, EventArgs e)
        {
            PersonelOgrenciListesi personelOgrenciListesi = new PersonelOgrenciListesi();
            personelOgrenciListesi.Show();
            this.Hide();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            PersonelÖğretmenListesiSayfa c = new PersonelÖğretmenListesiSayfa();
            c.Show();
            this.Hide();
        }

        private void label34_Click(object sender, EventArgs e)
        {
            PersonelÖğretmenListesiSayfa c = new PersonelÖğretmenListesiSayfa();
            c.Show();
            this.Hide();
        }

        private void label33_MouseEnter(object sender, EventArgs e)
        {
            label7.ForeColor = Color.Red;
        }

        private void label33_MouseLeave(object sender, EventArgs e)
        {
            label7.ForeColor = Color.Black;
        }

        private void label34_MouseEnter(object sender, EventArgs e)
        {
            label7.ForeColor = Color.Red;
        }

        private void label34_MouseLeave(object sender, EventArgs e)
        {
            label7.ForeColor = Color.Black;
        }
    }
}
