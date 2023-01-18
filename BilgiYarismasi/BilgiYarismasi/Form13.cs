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
    public partial class Form13 : Form
    {
        SoundPlayer player = new SoundPlayer();
        public static int Puan;
        public Form13()
        {
            InitializeComponent();

        }

        private void Form13_Load(object sender, EventArgs e)
        {
            string dizin = Application.StartupPath + "\\bitis.wav";
            player.SoundLocation = dizin;
            player.Play();
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
            Form13 form13 = new Form13();
            form13.Close();
            Form21 form21 = new Form21();
            form21.Show();
            this.Hide();
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

