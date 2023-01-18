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
    public partial class Form3 : Form
    {
        string tcNo = "";
        public Form3(string tc)
        {
            InitializeComponent();
            tcNo = tc;

        }
        public OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db.accdb");
        public OleDbCommand komut = new OleDbCommand();
        public OleDbDataAdapter adtr = new OleDbDataAdapter();
        public DataSet ds = new DataSet();
        public OleDbDataReader dr;

        private void Form3_Load(object sender, EventArgs e)
        {
            listviewGuncelle();
          
        }
        void listviewGuncelle()
        {
            listView1.Items.Clear();
            try
            {
                baglanti.Open();
                OleDbCommand cmd = new OleDbCommand("select * from Randevular where TC='" + tcNo + "' order by Randevuid desc ", baglanti);
                cmd.ExecuteNonQuery();
                OleDbDataReader rd = cmd.ExecuteReader();
                int no = 0;
                while (rd.Read())
                {
                    no++;
                    listView1.Items.Add(no.ToString());
                    listView1.Items[no - 1].SubItems.Add(rd["KlinikAdi"].ToString());
                    listView1.Items[no - 1].SubItems.Add(rd["DoktorAdi"].ToString());
                    listView1.Items[no - 1].SubItems.Add(rd["Tarih"].ToString());
                    listView1.Items[no - 1].SubItems.Add(rd["Saat"].ToString());
                    listView1.Items[no - 1].SubItems.Add(rd["Randevuid"].ToString());
                }
               baglanti.Close();
                
            }
            catch (Exception hata)//www.gorselprogramlama.com
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] idler = new string[listView1.CheckedItems.Count];

            for (int i = 0; i < listView1.CheckedItems.Count; i++)
            {
                idler[i] = listView1.CheckedItems[i].Text;
                try
                {
                    baglanti.Open();
                    OleDbCommand cmd = new OleDbCommand("Delete * From Randevular where Randevuid=@id", baglanti);
                    cmd.Parameters.AddWithValue("@id", listView1.CheckedItems[i].SubItems[5].Text);
                    cmd.ExecuteNonQuery();
                    baglanti.Close();

                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.Message);
                }

            }
            listviewGuncelle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
