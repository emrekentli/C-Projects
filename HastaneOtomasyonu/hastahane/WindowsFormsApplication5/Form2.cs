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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db.accdb");
       public OleDbCommand komut = new OleDbCommand();
        OleDbDataAdapter adtr = new OleDbDataAdapter();
        DataSet dt = new DataSet();
        bool giris_Yapildimi = false;


        private void btnYeniUye_Click(object sender, EventArgs e)
        {
            Uye uye = new Uye();

            uye.ShowDialog();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            Uye_Girisi();
        }



        void Uye_Girisi()
        {
                baglanti.Open();
                OleDbCommand cmd1 = new OleDbCommand("Select * From Uyeler where TC='" + maskedtxtTC.Text + "' and Parola='" + txtParola.Text + "'", baglanti);
                cmd1.ExecuteNonQuery();
                OleDbDataReader rd1 = cmd1.ExecuteReader();

                while (rd1.Read())
                {
                        Randevu rara = new Randevu(maskedtxtTC.Text, txtParola.Text);
                        rara.Show();
                        this.Hide();
                        giris_Yapildimi = true;
                  
                }
               baglanti.Close();

                if (giris_Yapildimi == false)
                {
                    MessageBox.Show("Hatalı Kullanıcı Adı/Parola");
                }
            }

        private void btnParolamiUnuttum_Click(object sender, EventArgs e)
        {
            Sifremiunuttum sifremi = new Sifremiunuttum();
            sifremi.Show();
            this.Hide();

        }
    }
}
