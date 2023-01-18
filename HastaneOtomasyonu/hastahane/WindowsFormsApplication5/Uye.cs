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
    public partial class Uye : Form
    {
        public Uye()
        {
            InitializeComponent();
        }

        public OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db.accdb");
       public OleDbCommand komut = new OleDbCommand();
       public OleDbDataAdapter adtr = new OleDbDataAdapter();
       public DataSet ds = new DataSet();
       public OleDbDataReader dr;

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText = "Select * from Uyeler where TC='" + maskedtxtTC.Text + "'";
            dr = komut.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("Girdiğiniz TC Kimlik Kullanılmaktadır. Lütfen Kontrol Ediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                baglanti.Close();
            }

            else if (maskedtxtTC.Text.Length < 11 || maskedtxtCepTel.Text.Length < 10 || txtEposta.Text != txtEpostaTekrar.Text || txtParola.Text != txtParolaTekrar.Text)
            {
                MessageBox.Show("Hata Bulundu, lütfen Düzeltiniz.");
                baglanti.Close();
            }
            else if (maskedtxtTC.Text.StartsWith("0"))
            {
                MessageBox.Show("TC Kimlik 0 ile başlayamaz!");
                baglanti.Close();
            }
            else if (txtAd.Text == "" || txtAnneAdı.Text == "" || txtBabaAdı.Text == "" || txtDogumYeri.Text == "" || txtEposta.Text == "" || txtEpostaTekrar.Text == "" || txtParola.Text == "" || txtParolaTekrar.Text == "" || txtSoyad.Text == "" || maskedtxtCepTel.Text == "" || maskedtxtDogumTarihi.Text == "" || maskedtxtTC.Text == "")
            {
                MessageBox.Show("Boş yer bırakmayınız.");
                baglanti.Close();
            }


            else
            {
                baglanti.Close();

                string cinsiyet = "Seçilmedi";
                if (radioButton1.Checked == true)
                    cinsiyet = "Bay";
                if (radioButton2.Checked == true)
                    cinsiyet = "Bayan";
                if (radioButton3.Checked == true)
                    cinsiyet = "Seçilmedi";
                komut.Connection = baglanti;
                komut.CommandText = "Insert into Uyeler(TC,Adı,Soyadı,DogumYeri,DogumTarihi,BabaAdı,AnneAdı,CepTel,Eposta,Parola,Cinsiyeti) Values('" + maskedtxtTC.Text + "','" + txtAd.Text + "','" + txtSoyad.Text + "','" + txtDogumYeri.Text + "','" + maskedtxtDogumTarihi.Text + "','" + txtBabaAdı.Text + "','" + txtAnneAdı.Text + "','" + maskedtxtCepTel.Text + "','" + txtEposta.Text + "','" + txtParola.Text + "','" + cinsiyet + "')";


                baglanti.Open();
                komut.ExecuteNonQuery();//sql cümleciğinin işlenmesini sağlar.
                komut.Dispose();//kullan at.yani komutu birkez kullandıktan sonra hafızadan sil
                baglanti.Close();
                MessageBox.Show("Bravo! , kayıt başarı ile gerçekleşti.");
                ds.Clear();
                this.Hide();
            }

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAd.Text = "";
            txtAnneAdı.Text = "";
            txtBabaAdı.Text = "";
            txtDogumYeri.Text = "";
            txtEposta.Text = "";
            txtEpostaTekrar.Text = "";
            txtParola.Text = "";
            txtParolaTekrar.Text = "";
            txtSoyad.Text = "";
            maskedtxtCepTel.Text = "";
            maskedtxtDogumTarihi.Text = "";
            maskedtxtTC.Text = "";
        }

        

        private void a(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        
    }
}
