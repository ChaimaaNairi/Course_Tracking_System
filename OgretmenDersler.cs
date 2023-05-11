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
    public partial class OgretmenDersler : Form
    {
        public OgretmenDersler()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OgretmenSayfa v = new OgretmenSayfa();
            v.Show();
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
