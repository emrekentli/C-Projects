using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OtoparkProje
{
    public partial class Yönetici_Menüsü : Form
    {
        public Yönetici_Menüsü()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Araç_Ekle ekle = new Araç_Ekle();
            ekle.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Araç_Çıkışı araccikis = new Araç_Çıkışı();
            araccikis.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Araç_Konumu konum = new Araç_Konumu();
            konum.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Geçmiş_İşlemler gecmis = new Geçmiş_İşlemler();
            gecmis.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Kullanıcı_Girişi giris = new Kullanıcı_Girişi();
            giris.Show();
            this.Hide();
        }
    }
}
