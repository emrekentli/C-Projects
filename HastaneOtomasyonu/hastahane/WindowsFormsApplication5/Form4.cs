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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        Form2 f2 = new Form2();
        public OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db.accdb");
        public OleDbCommand komut = new OleDbCommand();
        OleDbDataAdapter adtr = new OleDbDataAdapter();
        DataSet ds = new DataSet();

        private void Form4_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut.Connection = baglanti;
            OleDbCommand cmd = new OleDbCommand("Delete * From Randevular where Randevuid=@id", baglanti);
            komut.ExecuteNonQuery();
            komut.Dispose();
            baglanti.Close();
            ds.Clear();
        }
        void listele()
        {
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("Select * From Randevular where TC='" + f2.maskedtxtTC + "'", baglanti);
            adtr.Fill(ds, "Randevular");
            dataGridView1.DataSource = ds.Tables["Randevular"];
            adtr.Dispose();
            baglanti.Close();
        }
    }
}
