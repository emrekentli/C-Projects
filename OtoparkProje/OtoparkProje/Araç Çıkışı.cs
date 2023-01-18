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
    public partial class Araç_Çıkışı : Form
    {
       
        public Araç_Çıkışı()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Veritabanı.accdb");

        private void Araç_Çıkışı_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand kom = new OleDbCommand("Select * From MüsteriBilgileri where Konum=0",baglanti);
            OleDbDataReader okuyucu = kom.ExecuteReader();
            while (okuyucu.Read())
            {
                comboBox1.Items.Add(okuyucu["Plaka"].ToString());
            }
            baglanti.Close();
            }

        DateTime tarih;
        string Park = "";
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand kom2 = new OleDbCommand("Select * From MüsteriBilgileri where Konum=0 and Plaka LIKE'" + comboBox1.Text + "'", baglanti);
            OleDbDataReader okuyucu2 = kom2.ExecuteReader();
            while (okuyucu2.Read())
            {
                lblmarka.Text = okuyucu2["Marka"].ToString();
                lblmodel.Text = okuyucu2["Model"].ToString();
                lbladı.Text = okuyucu2["Adı"].ToString();
                lblsoyadı.Text = okuyucu2["Soyadı"].ToString();
                tarih = Convert.ToDateTime(okuyucu2["GirisSaati"].ToString());
                Park = okuyucu2["Sifre"].ToString();
            }
            baglanti.Close();
            System.TimeSpan zaman;
            DateTime son = DateTime.Now;
            zaman = son.Subtract(tarih);
            double saat = Convert.ToDouble(zaman.TotalHours);
            double para = 2 * double.Parse(saat.ToString("0.##"));
            lblücret.Text=(para).ToString() + " TL";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
            baglanti.Open();
            OleDbCommand kom4 = new OleDbCommand("update Park set Konum=0 where Park='" + Park + "'", baglanti);
            kom4.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Open();
            OleDbCommand kom5 = new OleDbCommand("update MüsteriBilgileri set Konum=1 where Plaka='" + comboBox1.Text + "'",baglanti);
            kom5.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Open();
            OleDbCommand kom6 = new OleDbCommand("update GecmisBilgiler set CikisSaati='" + DateTime.Now + "', Fiyat='" + lblücret.Text + "' where Plaka='" + comboBox1.Text + "'",baglanti);
            kom6.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Çıkışınız Yapıldı.");
            Park = "";
            lbladı.Text = "";
            lblmarka.Text = "";
            lblmodel.Text = "";
            lblsoyadı.Text = "";
            lblücret.Text = "";
            comboBox1.Text = "";
            comboBox1.Items.Clear();
            Araç_Çıkışı_Load(sender, e);


            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
