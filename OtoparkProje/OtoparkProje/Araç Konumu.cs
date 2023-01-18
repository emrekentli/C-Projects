using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace OtoparkProje
{

    public partial class Araç_Konumu : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Veritabanı.accdb");
        public Araç_Konumu()
        {
            InitializeComponent();
        }

        private void Araç_Konumu_Load(object sender, EventArgs e)
        {
           
            baglanti.Open();
            OleDbCommand kom = new OleDbCommand("Select * From Park,MüsteriBilgileri where Park.Park=MüsteriBilgileri.Sifre and MüsteriBilgileri.Konum=0",baglanti);
            OleDbDataReader okuyucu = kom.ExecuteReader();
            while (okuyucu.Read())
            {
                if (okuyucu["Sifre"].ToString()=="P1")
                {
                    pictureBox1.ImageLocation = "Dolu.png";
                    label2.Text = okuyucu["Plaka"].ToString();
                    label2.BackColor = Color.Red;
                    label1.BackColor = Color.Red;
                    
                }
                if (okuyucu["Sifre"].ToString() == "P2")
                {
                    pictureBox2.ImageLocation = "Dolu.png";
                    label3.Text = okuyucu["Plaka"].ToString();
                    label3.BackColor = Color.Red;
                    label4.BackColor = Color.Red;
                }
                if (okuyucu["Sifre"].ToString() == "P3")
                {
                    pictureBox3.ImageLocation = "Dolu.png";
                    label5.Text = okuyucu["Plaka"].ToString();
                    label5.BackColor = Color.Red;
                    label6.BackColor = Color.Red;
                }
                if (okuyucu["Sifre"].ToString() == "P4")
                {
                    pictureBox4.ImageLocation = "Dolu.png";
                    label7.Text = okuyucu["Plaka"].ToString();
                    label7.BackColor = Color.Red;
                    label8.BackColor = Color.Red;
                }
                if (okuyucu["Sifre"].ToString() == "P5")
                {
                    pictureBox5.ImageLocation = "Dolu.png";
                    label9.Text = okuyucu["Plaka"].ToString();
                    label9.BackColor = Color.Red;
                    label10.BackColor = Color.Red;
                }
                if (okuyucu["Sifre"].ToString() == "P6")
                {
                    pictureBox10.ImageLocation = "Dolu.png";
                    label19.Text = okuyucu["Plaka"].ToString();
                    label19.BackColor = Color.Red;
                    label20.BackColor = Color.Red;
                }
                if (okuyucu["Sifre"].ToString() == "P7")
                {
                    pictureBox9.ImageLocation = "Dolu.png";
                    label17.Text = okuyucu["Plaka"].ToString();
                    label17.BackColor = Color.Red;
                    label18.BackColor = Color.Red;
                }
                if (okuyucu["Sifre"].ToString() == "P8")
                {
                    pictureBox8.ImageLocation = "Dolu.png";
                    label15.Text = okuyucu["Plaka"].ToString();
                    label15.BackColor = Color.Red;
                    label16.BackColor = Color.Red;
                }
                if (okuyucu["Sifre"].ToString() == "P9")
                {
                    pictureBox7.ImageLocation = "Dolu.png";
                    label13.Text = okuyucu["Plaka"].ToString();
                    label13.BackColor = Color.Red;
                    label14.BackColor = Color.Red;
                }
                if (okuyucu["Sifre"].ToString() == "P10")
                {
                    pictureBox6.ImageLocation = "Dolu.png";
                    label11.Text = okuyucu["Plaka"].ToString();
                    label11.BackColor = Color.Red;
                    label12.BackColor = Color.Red;
                }
                
            }
            baglanti.Close();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }
    }
}
