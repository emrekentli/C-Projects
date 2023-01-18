using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string ad, soyad, tc, yas;

       public OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Veritabanı41.accdb");
       public OleDbCommand komut = new OleDbCommand();
       public OleDbDataAdapter dtr = new OleDbDataAdapter();
       public DataSet dt = new DataSet();
         
        private void button1_Click(object sender, EventArgs e)
        {
        
            tc = textBox1.Text;
            ad= textBox2.Text;
            soyad = textBox3.Text;
            yas = textBox4.Text;
            if (textBox2.Text == "" && textBox3.Text == "" && textBox1.Text == "")
            {
                MessageBox.Show ("Boş Geçilemez");
            }
            else if (textBox1.Text =="0")
            {
                MessageBox.Show("T.C.  0 İle Başlayamaz");
            }


            komut.Connection = baglanti;
            komut.CommandText = "Insert into Tablo1(TC,Ad,Soyad,Bolum,Adres)Values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "','" + textBox4.Text + "')";
            baglanti.Open();
            komut.ExecuteNonQuery();
            komut.Dispose();
            baglanti.Close();
            MessageBox.Show("Başarılı Giriş");
            dt.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            MessageBox.Show ("İşleminiz Tamamlandı");
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "Delete from Tablo1 where Ad='" + textBox5.Text + "'";
            komut.ExecuteNonQuery();
            komut.Dispose();
            baglanti.Close();
        }

        void listele()
        {

            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("Select * from Tablo1", baglanti);
            adtr.Fill(dt, "Tablo1");
            dataGridView1.DataSource = dt.Tables["Tablo1"];
            adtr.Dispose();
            baglanti.Close();



        }



        private void button4_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
