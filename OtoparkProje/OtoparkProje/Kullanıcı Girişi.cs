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
    public partial class Kullanıcı_Girişi : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Veritabanı.accdb");
        public Kullanıcı_Girişi()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (txtad.Text=="" || txtsifre.Text=="")
            {
                MessageBox.Show("Boş Alan Geçmeyiniz");
            }
            else
            {

                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Select * From Müsteri where MüsteriAdi ='" + txtad.Text.ToString() + "'", baglanti);
                OleDbDataReader okuyucu = komut.ExecuteReader();
                if (okuyucu.Read() == true)
                {
                    if (txtad.Text.ToString() == okuyucu["MüsteriAdi"].ToString() && txtsifre.Text.ToString() == okuyucu["Sifre"].ToString())
                    {
                        Yönetici_Menüsü menü = new Yönetici_Menüsü();
                        menü.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı veya şifre yanlıştır. Lütfen kontrol ediniz");  
                        txtad.Clear();
                        txtsifre.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlıştır. Lütfen kontrol ediniz");
                    txtad.Clear();
                    txtsifre.Clear();
                }
                baglanti.Close();
            }
        }

        private void Kullanıcı_Girişi_Load(object sender, EventArgs e)
        {

        }

       
    }
}
