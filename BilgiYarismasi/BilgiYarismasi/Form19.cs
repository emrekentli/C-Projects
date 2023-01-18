using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BilgiYarismasi
{
    public partial class Form19 : Form
    {
        public static int Puan;
        public Form19()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form19 form19 = new Form19();
            form19.Close();
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

      
/*
        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                Convert.ToInt32(label3.Text);
                Puan = Convert.ToInt32(label3.Text);
                Puan += 0;
                label3.Text = Puan.ToString();
                label3.Text = Puan.ToString();
                Form19 form19 = new Form19();
                form19.Close();
                Form20 form20 = new Form20();
                form20.Show();
                this.Hide();
                form20.label3.Text = label3.Text;

            }
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                Convert.ToInt32(label3.Text);
                Puan = Convert.ToInt32(label3.Text);
                Puan += 0;
                label3.Text = Puan.ToString();
                label3.Text = Puan.ToString();
                Form19 form19 = new Form19();
                form19.Close();
                Form20 form20 = new Form20();
                form20.Show();
                this.Hide();
                form20.label3.Text = label3.Text;
            }
        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                Convert.ToInt32(label3.Text);
                Puan = Convert.ToInt32(label3.Text);
                Puan += 0;
                label3.Text = Puan.ToString();
                label3.Text = Puan.ToString();
                Form19 form19 = new Form19();
                form19.Close();
                Form20 form20 = new Form20();
                form20.Show();
                this.Hide();
                form20.label3.Text = label3.Text;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                Convert.ToInt32(label3.Text);
                Puan = Convert.ToInt32(label3.Text);
                Puan += 5;
                label3.Text = Puan.ToString();
                label3.Text = Puan.ToString();
                Form19 form19 = new Form19();
                form19.Close();
                Form20 form20 = new Form20();
                form20.Show();
                this.Hide();
                form20.label3.Text = label3.Text;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }*/
    }
}







