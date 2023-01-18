using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace BilgiYarismasi
{
    public partial class Form21 : Form
    {
        
        SoundPlayer player = new SoundPlayer();
        public Form21()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            player.Stop();
            Form21 form21 = new Form21();
            form21.Close();
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form21 form21 = new Form21();
            form21.Close();
            Form19 form19 = new Form19();
            form19.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form21_Load(object sender, EventArgs e)
        {
            
            string dizin = Application.StartupPath + "\\kim.wav";
            player.SoundLocation = dizin;
            player.Play();

        }

        private void x(object sender, FormClosingEventArgs e)
        {
            DialogResult x = MessageBox.Show("Programdan Çıkmak İstediğinizden Emin Misiniz?", "Çıkış Mesajı!", MessageBoxButtons.YesNo);
            if (x == DialogResult.Yes)
            {
                //Evet tıklandığında Yapılacak İşlemler
                Environment.Exit(0); // Evet tıklandığında uygulama kapanacak

            }
            else if (x == DialogResult.No)
            {
                // Hayır tıklandığında yapılacak işlemler
                e.Cancel = true; // Hayır tıklandığında iptal edilecek
            }
        }
    }
}
