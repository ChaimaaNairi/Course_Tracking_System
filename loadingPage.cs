﻿using System;
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
    public partial class loadingPage : Form
    {
        public loadingPage()
        {
            InitializeComponent();
        }

        private void loadingPage_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width +=3/2;

            if(panel2.Width > 599)
            {
                timer1.Stop();
                MainPage mainPage = new MainPage();
                mainPage.Show();
                this.Hide();
            }
        }
    }
}