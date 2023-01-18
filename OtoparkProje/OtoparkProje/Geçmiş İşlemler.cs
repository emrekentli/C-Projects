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
    public partial class Geçmiş_İşlemler : Form
    {
        public Geçmiş_İşlemler()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Veritabanı.accdb");
        DataTable tablo = new DataTable();
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Geçmiş_İşlemler_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            tablo.Clear();
            OleDbDataAdapter adtr = new OleDbDataAdapter("Select * From GecmisBilgiler",baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            tablo.Clear();
            OleDbDataAdapter dtr = new OleDbDataAdapter("Select * From GecmisBilgiler where Plaka='"+textBox1.Text+"'",baglanti);
            dtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

       
    }
}
