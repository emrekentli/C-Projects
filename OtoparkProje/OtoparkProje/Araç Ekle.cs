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
    public partial class Araç_Ekle : Form
    {
         OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Veritabanı.accdb");
        public Araç_Ekle()
        {
            InitializeComponent();
        }
       

       
        private void Araç_Ekle_Load(object sender, EventArgs e)
        {

            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select * from Park where Konum like (0)", baglanti);
            OleDbDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                cbxno.Items.Add(okuyucu["Park"].ToString());
            }
            baglanti.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string tarih = DateTime.Now.ToShortDateString();
            baglanti.Open();
            OleDbCommand komut2 = new OleDbCommand("insert into MüsteriBilgileri (Sifre,Marka,Model,Plaka,Adı,Soyadı,Konum,GirisSaati) Values ('" + cbxno.Text + "','" + txtmarka.Text + "','" + txtmodel.Text + "','" + txtplaka.Text + "','" + txtad.Text + "','" + txtsoyad.Text + "','0','" + tarih.ToString() + "')", baglanti);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Open();
            OleDbCommand komut3 = new OleDbCommand("update Park set Konum='1' where Park like'" + cbxno.Text + "'", baglanti);
            komut3.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Open();
            OleDbCommand komut4 = new OleDbCommand("insert into GecmisBilgiler (Plaka,Ad,Soyad,Marka,Model,Sifre,GirisSaati) Values ('" + txtplaka.Text + "','" + txtad.Text + "','" + txtsoyad.Text + "','" + txtmarka.Text + "','" + txtmodel.Text + "','" + cbxno.Text + "','" + tarih.ToString() + "')", baglanti);
            komut4.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt tamamlanmıştır.", "Başarıyla tamamlandı");
            cbxno.Items.Clear();
            cbxno.Text = "";
            txtad.Text = "";
            txtsoyad.Text = "";
            txtplaka.Text = "";
            txtmarka.Text = "";
            txtmodel.Text = "";
            Araç_Ekle_Load(sender, e);
           
  
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        }
    }

