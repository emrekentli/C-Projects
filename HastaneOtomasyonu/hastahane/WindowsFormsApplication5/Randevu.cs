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
    public partial class Randevu : Form
    {
        string tcNo = "";
        string Parola = "";
        Form1 frm1 = new Form1();

        public Randevu(string tc, string parola)
        {
            InitializeComponent();
            tcNo = tc;
            Parola = parola;
        }
        public OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db.accdb");
        public OleDbCommand komut = new OleDbCommand();
        public OleDbDataAdapter adtr = new OleDbDataAdapter();
        public DataSet ds = new DataSet();
        public OleDbDataReader dr;
        public OleDbDataReader drx;
        string klinikid = "";
        DateTime datee = DateTime.Now;

        void klinileriGoster()
        {
            baglanti.Open();
           
                cmBoxKlinik.Items.Clear();
                OleDbCommand cmd = new OleDbCommand("Select * From Klinik", baglanti);
                cmd.ExecuteNonQuery();
                OleDbDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    cmBoxKlinik.Items.Add(rd["KlinikAdi"].ToString());
                }
            
         
            baglanti.Close();
        }

        void doktorlariGoster()
        {
            baglanti.Open();

            OleDbCommand cmd = new OleDbCommand("Select * From Doktorlar where Klinikid=@id", baglanti);
            cmd.Parameters.AddWithValue("@id", klinikid);

            cmd.ExecuteNonQuery();
            OleDbDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                cmBoxDoktor.Items.Add(rd["DoktorAdiSoyadi"].ToString());
            }


            baglanti.Close();
        }

        void uyeBilgileriniGoster()
        {
            baglanti.Open();
            OleDbCommand cmd = new OleDbCommand("Select * From Uyeler where TC='" + tcNo + "' ", baglanti);
            cmd.ExecuteNonQuery();
            OleDbDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                lblTC.Text = rd["TC"].ToString();
                lblAdSoyad.Text = rd["Adı"].ToString() + " " + rd["Soyadı"].ToString();
                lblDogumYeriTarihi.Text = rd["DogumYeri"].ToString() + " / " + rd["DogumTarihi"].ToString();
                lblCinsiyet.Text = rd["Cinsiyeti"].ToString();
                lblTel.Text = rd["CepTel"].ToString();

            }
            baglanti.Close();
        }
        void KlinikidsiniBul()
        {
            baglanti.Open();
            OleDbCommand cmd = new OleDbCommand("Select * From Klinik where KlinikAdi='" + cmBoxKlinik.Text + "'", baglanti);
            cmd.ExecuteNonQuery();
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                klinikid = dr["Klinikid"].ToString();
            }
            baglanti.Close();
            doktorlariGoster();

        }



        private void Randevu_Load(object sender, EventArgs e)
        {
            uyeBilgileriniGoster();
            klinileriGoster();
           
        }
       

        private void cmBoxKlinik_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmBoxDoktor.Select();
            cmBoxDoktor.Items.Clear();
            cmBoxDoktor.Text = "";

            cmBoxRandevTarihi.Items.Clear();
            cmBoxRandevTarihi.Text = "";
            KlinikidsiniBul();
            cmBoxKlinik.Enabled = false;
            cmBoxDoktor.Enabled = true;


        }

        private void cmBoxDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmBoxRandevTarihi.Select();
            cmBoxRandevTarihi.Items.Clear();
            cmBoxRandevTarihi.Text = "";
            
            tarihDuzenleme();

            cmBoxDoktor.Enabled = false;
            cmBoxRandevTarihi.Enabled = true;


        }
        void tarihDuzenleme()
        {
            int i = 0;
            while (cmBoxRandevTarihi.Items.Count != 5)
            {
                if (datee.AddDays(i).DayOfWeek.ToString() != "Saturday" && datee.AddDays(i).DayOfWeek.ToString() != "Sunday")
                {
                    cmBoxRandevTarihi.Items.Add(datee.AddDays(i).ToShortDateString());
                }
                i++;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label8.Left > -340)
            {
                label8.Left -= 10;
            }
            else
            {
                label8.Left = 958;
            }
        }
        int renkA = 0;
        int renkB = 0;
        int renkC = 0;
        bool duzmu = true;
        private void timer2_Tick(object sender, EventArgs e)
        {

            lblHastaneAdi.ForeColor = Color.FromArgb(renkA, renkB, renkC);

            if (duzmu)
            {
                if (renkA < 255)
                {
                    renkA++;
                }
                else if (renkB < 255)
                {
                    renkB++;
                }
                else if (renkC < 255)
                {
                    renkC++;
                }
                else
                {
                    duzmu = false;
                }
            }
            else
            {
                if (renkA > 0)
                {
                    renkA--;
                }
                else if (renkB > 0)
                {
                    renkB--;
                }
                else if (renkC > 0)
                {
                    renkC--;
                }
                else
                {
                    duzmu = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {   
           
        }
       

        private void cmBoxRandevTarihi_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            panel1.Visible = true;
            cmBoxRandevTarihi.Enabled = false;
            baglanti.Open();
            OleDbCommand komut1 = new OleDbCommand("Select * From Randevular where Saat='" + label31.Text + "' and Tarih='" + cmBoxRandevTarihi.Text + "' and KlinikAdi='" + cmBoxKlinik.Text + "'", baglanti);
            komut1.Connection = baglanti;
            dr = komut1.ExecuteReader();

            if (dr.Read())
            {
                label31.BackColor = Color.Red;
                label31.Enabled = false;
            }
            else 
            {
                label31.BackColor = Color.Green;
                label31.Enabled = true;
            }
            baglanti.Close();
            ////////////////////////

            baglanti.Open();
            OleDbCommand komut2 = new OleDbCommand("Select * From Randevular where Saat='" + label11.Text + "' and Tarih='" + cmBoxRandevTarihi.Text + "' and KlinikAdi='" + cmBoxKlinik.Text + "'", baglanti);
            komut2.Connection = baglanti;
            dr = komut2.ExecuteReader();

            if (dr.Read())
            {
                label11.BackColor = Color.Red;
                label11.Enabled = false;
            }
            else
            {
                label11.BackColor = Color.Green;
                label11.Enabled = true;
            }
            baglanti.Close();
            //////////////////
            baglanti.Open();
            OleDbCommand komut3 = new OleDbCommand("Select * From Randevular where Saat='" + label9.Text + "' and Tarih='" + cmBoxRandevTarihi.Text + "' and KlinikAdi='" + cmBoxKlinik.Text + "'", baglanti);
            komut3.Connection = baglanti;
            dr = komut3.ExecuteReader();

            if (dr.Read())
            {
                label9.BackColor = Color.Red;
                label9.Enabled = false;
            }
            else
            {
                label9.BackColor = Color.Green;
                label9.Enabled = true;
            }
            baglanti.Close();
            
            /////////////
            baglanti.Open();
            OleDbCommand komut4 = new OleDbCommand("Select * From Randevular where Saat='" + label10.Text + "' and Tarih='" + cmBoxRandevTarihi.Text + "' and KlinikAdi='" + cmBoxKlinik.Text + "'", baglanti);
            komut4.Connection = baglanti;
            dr = komut4.ExecuteReader();

            if (dr.Read())
            {
                label10.BackColor = Color.Red;
                label10.Enabled = false;
            }
            else
            {
                label10.BackColor = Color.Green;
                label10.Enabled = true;
            }
            baglanti.Close();
            ///////////
            baglanti.Open();
            OleDbCommand komut5 = new OleDbCommand("Select * From Randevular where Saat='" + label30.Text + "' and Tarih='" + cmBoxRandevTarihi.Text + "' and KlinikAdi='" + cmBoxKlinik.Text + "'", baglanti);
            komut5.Connection = baglanti;
            dr = komut5.ExecuteReader();

            if (dr.Read())
            {
                label30.BackColor = Color.Red;
                label30.Enabled = false;
            }
            else
            {
                label30.BackColor = Color.Green;
                label30.Enabled = true;
            }
            baglanti.Close();
            ////////////
            baglanti.Open();
            OleDbCommand komut6 = new OleDbCommand("Select * From Randevular where Saat='" + label12.Text + "' and Tarih='" + cmBoxRandevTarihi.Text + "' and KlinikAdi='" + cmBoxKlinik.Text + "'", baglanti);
            komut6.Connection = baglanti;
            dr = komut6.ExecuteReader();

            if (dr.Read())
            {
                label12.BackColor = Color.Red;
                label12.Enabled = false;
            }
            else
            {
                label12.BackColor = Color.Green;
                label12.Enabled = true;
            }
            baglanti.Close();
            ///////////
            baglanti.Open();
            OleDbCommand komut7 = new OleDbCommand("Select * From Randevular where Saat='" + label13.Text + "' and Tarih='" + cmBoxRandevTarihi.Text + "' and KlinikAdi='" + cmBoxKlinik.Text + "'", baglanti);
            komut7.Connection = baglanti;
            dr = komut7.ExecuteReader();

            if (dr.Read())
            {
                label13.BackColor = Color.Red;
                label13.Enabled = false;
            }
            else
            {
                label13.BackColor = Color.Green;
                label13.Enabled = true;
            }
            baglanti.Close();
            /////////////
            baglanti.Open();
            OleDbCommand komut8 = new OleDbCommand("Select * From Randevular where Saat='" + label14.Text + "' and Tarih='" + cmBoxRandevTarihi.Text + "' and KlinikAdi='" + cmBoxKlinik.Text + "'", baglanti);
            komut8.Connection = baglanti;
            dr = komut8.ExecuteReader();

            if (dr.Read())
            {
                label14.BackColor = Color.Red;
                label14.Enabled = false;
            }
            else
            {
                label14.BackColor = Color.Green;
                label14.Enabled = true;
            }
            baglanti.Close();
            /////////////
            baglanti.Open();
            OleDbCommand komut9 = new OleDbCommand("Select * From Randevular where Saat='" + label15.Text + "' and Tarih='" + cmBoxRandevTarihi.Text + "' and KlinikAdi='" + cmBoxKlinik.Text + "'", baglanti);
            komut9.Connection = baglanti;
            dr = komut9.ExecuteReader();

            if (dr.Read())
            {
                label15.BackColor = Color.Red;
                label15.Enabled = false;
            }
            else
            {
                label15.BackColor = Color.Green;
                label15.Enabled = true;
            }

            baglanti.Close();
            /////////////
            baglanti.Open();
            OleDbCommand komut10 = new OleDbCommand("Select * From Randevular where Saat='" + label16.Text + "' and Tarih='" + cmBoxRandevTarihi.Text + "' and KlinikAdi='" + cmBoxKlinik.Text + "'", baglanti);
            komut10.Connection = baglanti;
            dr = komut10.ExecuteReader();

            if (dr.Read())
            {
                label16.BackColor = Color.Red;
                label16.Enabled = false;
            }
            else
            {
                label16.BackColor = Color.Green;
                label16.Enabled = true;
            }
            baglanti.Close();
            /////////////
            baglanti.Open();
            OleDbCommand komut11 = new OleDbCommand("Select * From Randevular where Saat='" + label17.Text + "' and Tarih='" + cmBoxRandevTarihi.Text + "' and KlinikAdi='" + cmBoxKlinik.Text + "'", baglanti);
            komut11.Connection = baglanti;
            dr = komut11.ExecuteReader();

            if (dr.Read())
            {
                label17.BackColor = Color.Red;
                label17.Enabled = false;
            }
            else
            {
                label17.BackColor = Color.Green;
                label17.Enabled = true;
            }
            baglanti.Close();
            /////////////
            baglanti.Open();
            OleDbCommand komut12 = new OleDbCommand("Select * From Randevular where Saat='" + label18.Text + "' and Tarih='" + cmBoxRandevTarihi.Text + "' and KlinikAdi='" + cmBoxKlinik.Text + "'", baglanti);
            komut12.Connection = baglanti;
            dr = komut12.ExecuteReader();

            if (dr.Read())
            {
                label18.BackColor = Color.Red;
                label18.Enabled = false;
            }
            else
            {
                label18.BackColor = Color.Green;
                label18.Enabled = true;
            }
            baglanti.Close();
            /////////////
            baglanti.Open();
            OleDbCommand komut13 = new OleDbCommand("Select * From Randevular where Saat='" + label19.Text + "' and Tarih='" + cmBoxRandevTarihi.Text + "' and KlinikAdi='" + cmBoxKlinik.Text + "'", baglanti);
            komut13.Connection = baglanti;
            dr = komut13.ExecuteReader();

            if (dr.Read())
            {
                label19.BackColor = Color.Red;
                label19.Enabled = false;
            }
            else
            {
                label19.BackColor = Color.Green;
                label19.Enabled = true;
            }
            baglanti.Close();
            /////////////
            baglanti.Open();
            OleDbCommand komut14 = new OleDbCommand("Select * From Randevular where Saat='" + label20.Text + "' and Tarih='" + cmBoxRandevTarihi.Text + "' and KlinikAdi='" + cmBoxKlinik.Text + "'", baglanti);
            komut14.Connection = baglanti;
            dr = komut14.ExecuteReader();

            if (dr.Read())
            {
                label20.BackColor = Color.Red;
                label20.Enabled = false;
            }
            else
            {
                label20.BackColor = Color.Green;
                label20.Enabled = true;
            }
            baglanti.Close();
            /////////////
            baglanti.Open();
            OleDbCommand komut15 = new OleDbCommand("Select * From Randevular where Saat='" + label21.Text + "' and Tarih='" + cmBoxRandevTarihi.Text + "' and KlinikAdi='" + cmBoxKlinik.Text + "'", baglanti);
            komut15.Connection = baglanti;
            dr = komut15.ExecuteReader();

            if (dr.Read())
            {
                label21.BackColor = Color.Red;
                label21.Enabled = false;
            }
            else
            {
                label21.BackColor = Color.Green;
                label21.Enabled = true;
            }
            baglanti.Close();
            /////////////
            baglanti.Open();
            OleDbCommand komut16 = new OleDbCommand("Select * From Randevular where Saat='" + label22.Text + "' and Tarih='" + cmBoxRandevTarihi.Text + "' and KlinikAdi='" + cmBoxKlinik.Text + "'", baglanti);
            komut16.Connection = baglanti;
            dr = komut16.ExecuteReader();

            if (dr.Read())
            {
                label22.BackColor = Color.Red;
                label22.Enabled = false;
            }
            else
            {
                label22.BackColor = Color.Green;
                label22.Enabled = true;
            }
            baglanti.Close();
            /////////////
            baglanti.Open();
            OleDbCommand komut17 = new OleDbCommand("Select * From Randevular where Saat='" + label23.Text + "' and Tarih='" + "' and Tarih='" + cmBoxRandevTarihi.Text + "' and KlinikAdi='" + cmBoxKlinik.Text + "'", baglanti);
            komut17.Connection = baglanti;
            dr = komut17.ExecuteReader();

            if (dr.Read())
            {
                label23.BackColor = Color.Red;
                label23.Enabled = false;
            }
            else
            {
                label23.BackColor = Color.Green;
                label23.Enabled = true;
            }
            baglanti.Close();
            /////////////
            baglanti.Open();
            OleDbCommand komut18 = new OleDbCommand("Select * From Randevular where Saat='" + label24.Text + "' and Tarih='" + "' and Tarih='" + cmBoxRandevTarihi.Text + "' and KlinikAdi='" + cmBoxKlinik.Text + "'", baglanti);
            komut18.Connection = baglanti;
            dr = komut18.ExecuteReader();

            if (dr.Read())
            {
                label24.BackColor = Color.Red;
                label24.Enabled = false;
            }
            else
            {
                label24.BackColor = Color.Green;
                label24.Enabled = true;
            }
            baglanti.Close();
            /////////////
            baglanti.Open();
            OleDbCommand komut19 = new OleDbCommand("Select * From Randevular where Saat='" + label25.Text + "' and Tarih='" + cmBoxRandevTarihi.Text + "' and KlinikAdi='" + cmBoxKlinik.Text + "'", baglanti);
            komut19.Connection = baglanti;
            dr = komut19.ExecuteReader();

            if (dr.Read())
            {
                label25.BackColor = Color.Red;
                label25.Enabled = false;
            }
            else
            {
                label25.BackColor = Color.Green;
                label25.Enabled = true;
            }
            baglanti.Close();
            /////////////
            baglanti.Open();
            OleDbCommand komut20 = new OleDbCommand("Select * From Randevular where Saat='" + label26.Text + "' and Tarih='" + cmBoxRandevTarihi.Text + "' and KlinikAdi='" + cmBoxKlinik.Text + "'", baglanti);
            komut20.Connection = baglanti;
            dr = komut20.ExecuteReader();

            if (dr.Read())
            {
                label26.BackColor = Color.Red;
                label26.Enabled = false;
            }
            else
            {
                label26.BackColor = Color.Green;
                label26.Enabled = true;
            }
            baglanti.Close();
        }

        
        private void label31_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select * From Randevular where Tc='" + lblTC.Text + "' and Tarih='" + cmBoxRandevTarihi.Text + "'", baglanti);
            komut.Connection = baglanti;
            dr = komut.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("Aynı Güne iki tane randevu alamazsınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }

            else 
            {
            komut = new OleDbCommand("insert into Randevular (TC,KlinikAdi,DoktorAdi,Tarih,Saat) values ('" + lblTC.Text + "','" + cmBoxKlinik.Text + "','" + cmBoxDoktor.Text + "','" + cmBoxRandevTarihi.Text + "','" + label31.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            MessageBox.Show("Randevu İşleminiz Başarıyla Gerçekleşmiştir");
            baglanti.Close();

            cmBoxKlinik.Select();
            klinileriGoster();
            panel1.Visible = false;
            cmBoxDoktor.Text = "";
            cmBoxRandevTarihi.Text = "";
            }

            baglanti.Close();
           

            
        }

        private void era(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2  form = new Form2();
            form.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select * From Randevular where Tc='" + lblTC.Text + "' and Tarih='" + cmBoxRandevTarihi.Text + "'", baglanti);
            komut.Connection = baglanti;
            dr = komut.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("Aynı Güne iki tane randevu alamazsınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {
                komut = new OleDbCommand("insert into Randevular (TC,KlinikAdi,DoktorAdi,Tarih,Saat) values ('" + lblTC.Text + "','" + cmBoxKlinik.Text + "','" + cmBoxDoktor.Text + "','" + cmBoxRandevTarihi.Text + "','" + label11.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("Randevu İşleminiz Başarıyla Gerçekleşmiştir");
                baglanti.Close();

                cmBoxKlinik.Select();
                klinileriGoster();
                panel1.Visible = false;
                cmBoxDoktor.Text = "";
                cmBoxRandevTarihi.Text = "";
            }

            baglanti.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select * From Randevular where Tc='" + lblTC.Text + "' and Tarih='" + cmBoxRandevTarihi.Text + "'", baglanti);
            komut.Connection = baglanti;
            dr = komut.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("Aynı Güne iki tane randevu alamazsınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {
                komut = new OleDbCommand("insert into Randevular (TC,KlinikAdi,DoktorAdi,Tarih,Saat) values ('" + lblTC.Text + "','" + cmBoxKlinik.Text + "','" + cmBoxDoktor.Text + "','" + cmBoxRandevTarihi.Text + "','" + label9.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("Randevu İşleminiz Başarıyla Gerçekleşmiştir");
                baglanti.Close();

                cmBoxKlinik.Select();
                klinileriGoster();
                panel1.Visible = false;
                cmBoxDoktor.Text = "";
                cmBoxRandevTarihi.Text = "";

            }

            baglanti.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select * From Randevular where Tc='" + lblTC.Text + "' and Tarih='" + cmBoxRandevTarihi.Text + "'", baglanti);
            komut.Connection = baglanti;
            dr = komut.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("Aynı Güne iki tane randevu alamazsınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {
                komut = new OleDbCommand("insert into Randevular (TC,KlinikAdi,DoktorAdi,Tarih,Saat) values ('" + lblTC.Text + "','" + cmBoxKlinik.Text + "','" + cmBoxDoktor.Text + "','" + cmBoxRandevTarihi.Text + "','" + label10.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("Randevu İşleminiz Başarıyla Gerçekleşmiştir");
                baglanti.Close();

                cmBoxKlinik.Select();
                klinileriGoster();
                panel1.Visible = false;
                cmBoxDoktor.Text = "";
                cmBoxRandevTarihi.Text = "";

            }

            baglanti.Close();
        }

        private void label30_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select * From Randevular where Tc='" + lblTC.Text + "' and Tarih='" + cmBoxRandevTarihi.Text + "'", baglanti);
            komut.Connection = baglanti;
            dr = komut.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("Aynı Güne iki tane randevu alamazsınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {
                komut = new OleDbCommand("insert into Randevular (TC,KlinikAdi,DoktorAdi,Tarih,Saat) values ('" + lblTC.Text + "','" + cmBoxKlinik.Text + "','" + cmBoxDoktor.Text + "','" + cmBoxRandevTarihi.Text + "','" + label30.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("Randevu İşleminiz Başarıyla Gerçekleşmiştir");
                baglanti.Close();

                cmBoxKlinik.Select();
                klinileriGoster();
                panel1.Visible = false;
                cmBoxDoktor.Text = "";
                cmBoxRandevTarihi.Text = "";
            }

            baglanti.Close();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select * From Randevular where Tc='" + lblTC.Text + "' and Tarih='" + cmBoxRandevTarihi.Text + "'", baglanti);
            komut.Connection = baglanti;
            dr = komut.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("Aynı Güne iki tane randevu alamazsınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {
                komut = new OleDbCommand("insert into Randevular (TC,KlinikAdi,DoktorAdi,Tarih,Saat) values ('" + lblTC.Text + "','" + cmBoxKlinik.Text + "','" + cmBoxDoktor.Text + "','" + cmBoxRandevTarihi.Text + "','" + label12.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("Randevu İşleminiz Başarıyla Gerçekleşmiştir");
                baglanti.Close();

                cmBoxKlinik.Select();
                klinileriGoster();
                panel1.Visible = false;
                cmBoxDoktor.Text = "";
                cmBoxRandevTarihi.Text = "";
            }

            baglanti.Close();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select * From Randevular where Tc='" + lblTC.Text + "' and Tarih='" + cmBoxRandevTarihi.Text + "'", baglanti);
            komut.Connection = baglanti;
            dr = komut.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("Aynı Güne iki tane randevu alamazsınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {
                komut = new OleDbCommand("insert into Randevular (TC,KlinikAdi,DoktorAdi,Tarih,Saat) values ('" + lblTC.Text + "','" + cmBoxKlinik.Text + "','" + cmBoxDoktor.Text + "','" + cmBoxRandevTarihi.Text + "','" + label13.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("Randevu İşleminiz Başarıyla Gerçekleşmiştir");
                baglanti.Close();

                cmBoxKlinik.Select();
                klinileriGoster();
                panel1.Visible = false;
                cmBoxDoktor.Text = "";
                cmBoxRandevTarihi.Text = "";
            }

            baglanti.Close();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select * From Randevular where Tc='" + lblTC.Text + "' and Tarih='" + cmBoxRandevTarihi.Text + "'", baglanti);
            komut.Connection = baglanti;
            dr = komut.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("Aynı Güne iki tane randevu alamazsınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {
                komut = new OleDbCommand("insert into Randevular (TC,KlinikAdi,DoktorAdi,Tarih,Saat) values ('" + lblTC.Text + "','" + cmBoxKlinik.Text + "','" + cmBoxDoktor.Text + "','" + cmBoxRandevTarihi.Text + "','" + label14.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("Randevu İşleminiz Başarıyla Gerçekleşmiştir");
                baglanti.Close();

                cmBoxKlinik.Select();
                klinileriGoster();
                panel1.Visible = false;
                cmBoxDoktor.Text = "";
                cmBoxRandevTarihi.Text = "";
            }

            baglanti.Close();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select * From Randevular where Tc='" + lblTC.Text + "' and Tarih='" + cmBoxRandevTarihi.Text + "'", baglanti);
            komut.Connection = baglanti;
            dr = komut.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("Aynı Güne iki tane randevu alamazsınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {
                komut = new OleDbCommand("insert into Randevular (TC,KlinikAdi,DoktorAdi,Tarih,Saat) values ('" + lblTC.Text + "','" + cmBoxKlinik.Text + "','" + cmBoxDoktor.Text + "','" + cmBoxRandevTarihi.Text + "','" + label15.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("Randevu İşleminiz Başarıyla Gerçekleşmiştir");
                baglanti.Close();

                cmBoxKlinik.Select();
                klinileriGoster();
                panel1.Visible = false;
                cmBoxDoktor.Text = "";
                cmBoxRandevTarihi.Text = "";
            }

            baglanti.Close();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select * From Randevular where Tc='" + lblTC.Text + "' and Tarih='" + cmBoxRandevTarihi.Text + "'", baglanti);
            komut.Connection = baglanti;
            dr = komut.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("Aynı Güne iki tane randevu alamazsınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {
                komut = new OleDbCommand("insert into Randevular (TC,KlinikAdi,DoktorAdi,Tarih,Saat) values ('" + lblTC.Text + "','" + cmBoxKlinik.Text + "','" + cmBoxDoktor.Text + "','" + cmBoxRandevTarihi.Text + "','" + label16.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("Randevu İşleminiz Başarıyla Gerçekleşmiştir");
                baglanti.Close();

                cmBoxKlinik.Select();
                klinileriGoster();
                panel1.Visible = false;
                cmBoxDoktor.Text = "";
                cmBoxRandevTarihi.Text = "";
            }

            baglanti.Close();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select * From Randevular where Tc='" + lblTC.Text + "' and Tarih='" + cmBoxRandevTarihi.Text + "'", baglanti);
            komut.Connection = baglanti;
            dr = komut.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("Aynı Güne iki tane randevu alamazsınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {
                komut = new OleDbCommand("insert into Randevular (TC,KlinikAdi,DoktorAdi,Tarih,Saat) values ('" + lblTC.Text + "','" + cmBoxKlinik.Text + "','" + cmBoxDoktor.Text + "','" + cmBoxRandevTarihi.Text + "','" + label17.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("Randevu İşleminiz Başarıyla Gerçekleşmiştir");
                baglanti.Close();

                cmBoxKlinik.Select();
                klinileriGoster();
                panel1.Visible = false;
                cmBoxDoktor.Text = "";
                cmBoxRandevTarihi.Text = "";
            }

            baglanti.Close();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select * From Randevular where Tc='" + lblTC.Text + "' and Tarih='" + cmBoxRandevTarihi.Text + "'", baglanti);
            komut.Connection = baglanti;
            dr = komut.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("Aynı Güne iki tane randevu alamazsınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {
                komut = new OleDbCommand("insert into Randevular (TC,KlinikAdi,DoktorAdi,Tarih,Saat) values ('" + lblTC.Text + "','" + cmBoxKlinik.Text + "','" + cmBoxDoktor.Text + "','" + cmBoxRandevTarihi.Text + "','" + label18.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("Randevu İşleminiz Başarıyla Gerçekleşmiştir");
                baglanti.Close();

                cmBoxKlinik.Select();
                klinileriGoster();
                panel1.Visible = false;
                cmBoxDoktor.Text = "";
                cmBoxRandevTarihi.Text = "";
            }

            baglanti.Close();
        }

        private void label19_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select * From Randevular where Tc='" + lblTC.Text + "' and Tarih='" + cmBoxRandevTarihi.Text + "'", baglanti);
            komut.Connection = baglanti;
            dr = komut.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("Aynı Güne iki tane randevu alamazsınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {
                komut = new OleDbCommand("insert into Randevular (TC,KlinikAdi,DoktorAdi,Tarih,Saat) values ('" + lblTC.Text + "','" + cmBoxKlinik.Text + "','" + cmBoxDoktor.Text + "','" + cmBoxRandevTarihi.Text + "','" + label19.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("Randevu İşleminiz Başarıyla Gerçekleşmiştir");
                baglanti.Close();

                cmBoxKlinik.Select();
                klinileriGoster();
                panel1.Visible = false;
                cmBoxDoktor.Text = "";
                cmBoxRandevTarihi.Text = "";
            }

            baglanti.Close();
        }

        private void label20_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select * From Randevular where Tc='" + lblTC.Text + "' and Tarih='" + cmBoxRandevTarihi.Text + "'", baglanti);
            komut.Connection = baglanti;
            dr = komut.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("Aynı Güne iki tane randevu alamazsınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {
                komut = new OleDbCommand("insert into Randevular (TC,KlinikAdi,DoktorAdi,Tarih,Saat) values ('" + lblTC.Text + "','" + cmBoxKlinik.Text + "','" + cmBoxDoktor.Text + "','" + cmBoxRandevTarihi.Text + "','" + label20.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("Randevu İşleminiz Başarıyla Gerçekleşmiştir");
                baglanti.Close();

                cmBoxKlinik.Select();
                klinileriGoster();
                panel1.Visible = false;
                cmBoxDoktor.Text = "";
                cmBoxRandevTarihi.Text = "";
            }

            baglanti.Close();
        }

        private void label21_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select * From Randevular where Tc='" + lblTC.Text + "' and Tarih='" + cmBoxRandevTarihi.Text + "'", baglanti);
            komut.Connection = baglanti;
            dr = komut.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("Aynı Güne iki tane randevu alamazsınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {
                komut = new OleDbCommand("insert into Randevular (TC,KlinikAdi,DoktorAdi,Tarih,Saat) values ('" + lblTC.Text + "','" + cmBoxKlinik.Text + "','" + cmBoxDoktor.Text + "','" + cmBoxRandevTarihi.Text + "','" + label21.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("Randevu İşleminiz Başarıyla Gerçekleşmiştir");
                baglanti.Close();

                cmBoxKlinik.Select();
                klinileriGoster();
                panel1.Visible = false;
                cmBoxDoktor.Text = "";
                cmBoxRandevTarihi.Text = "";
            }

            baglanti.Close();
        }

        private void label22_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select * From Randevular where Tc='" + lblTC.Text + "' and Tarih='" + cmBoxRandevTarihi.Text + "'", baglanti);
            komut.Connection = baglanti;
            dr = komut.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("Aynı Güne iki tane randevu alamazsınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {
                komut = new OleDbCommand("insert into Randevular (TC,KlinikAdi,DoktorAdi,Tarih,Saat) values ('" + lblTC.Text + "','" + cmBoxKlinik.Text + "','" + cmBoxDoktor.Text + "','" + cmBoxRandevTarihi.Text + "','" + label22.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("Randevu İşleminiz Başarıyla Gerçekleşmiştir");
                baglanti.Close();

                cmBoxKlinik.Select();
                klinileriGoster();
                panel1.Visible = false;
                cmBoxDoktor.Text = "";
                cmBoxRandevTarihi.Text = "";
            }

            baglanti.Close();
        }

        private void label23_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select * From Randevular where Tc='" + lblTC.Text + "' and Tarih='" + cmBoxRandevTarihi.Text + "'", baglanti);
            komut.Connection = baglanti;
            dr = komut.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("Aynı Güne iki tane randevu alamazsınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {
                komut = new OleDbCommand("insert into Randevular (TC,KlinikAdi,DoktorAdi,Tarih,Saat) values ('" + lblTC.Text + "','" + cmBoxKlinik.Text + "','" + cmBoxDoktor.Text + "','" + cmBoxRandevTarihi.Text + "','" + label23.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("Randevu İşleminiz Başarıyla Gerçekleşmiştir");
                baglanti.Close();

                cmBoxKlinik.Select();
                klinileriGoster();
                panel1.Visible = false;
                cmBoxDoktor.Text = "";
                cmBoxRandevTarihi.Text = "";
            }

            baglanti.Close();
        }

        private void label24_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select * From Randevular where Tc='" + lblTC.Text + "' and Tarih='" + cmBoxRandevTarihi.Text + "'", baglanti);
            komut.Connection = baglanti;
            dr = komut.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("Aynı Güne iki tane randevu alamazsınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {
                komut = new OleDbCommand("insert into Randevular (TC,KlinikAdi,DoktorAdi,Tarih,Saat) values ('" + lblTC.Text + "','" + cmBoxKlinik.Text + "','" + cmBoxDoktor.Text + "','" + cmBoxRandevTarihi.Text + "','" + label24.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("Randevu İşleminiz Başarıyla Gerçekleşmiştir");
                baglanti.Close();

                cmBoxKlinik.Select();
                klinileriGoster();
                panel1.Visible = false;
                cmBoxDoktor.Text = "";
                cmBoxRandevTarihi.Text = "";
            }

            baglanti.Close();
        }

        private void label25_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select * From Randevular where Tc='" + lblTC.Text + "' and Tarih='" + cmBoxRandevTarihi.Text + "'", baglanti);
            komut.Connection = baglanti;
            dr = komut.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("Aynı Güne iki tane randevu alamazsınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {
                komut = new OleDbCommand("insert into Randevular (TC,KlinikAdi,DoktorAdi,Tarih,Saat) values ('" + lblTC.Text + "','" + cmBoxKlinik.Text + "','" + cmBoxDoktor.Text + "','" + cmBoxRandevTarihi.Text + "','" + label25.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("Randevu İşleminiz Başarıyla Gerçekleşmiştir");
                baglanti.Close();

                cmBoxKlinik.Select();
                klinileriGoster();
                panel1.Visible = false;
                cmBoxDoktor.Text = "";
                cmBoxRandevTarihi.Text = "";
            }

            baglanti.Close();
        }

        private void label26_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select * From Randevular where Tc='" + lblTC.Text + "' and Tarih='" + cmBoxRandevTarihi.Text + "'", baglanti);
            komut.Connection = baglanti;
            dr = komut.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("Aynı Güne iki tane randevu alamazsınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {
                komut = new OleDbCommand("insert into Randevular (TC,KlinikAdi,DoktorAdi,Tarih,Saat) values ('" + lblTC.Text + "','" + cmBoxKlinik.Text + "','" + cmBoxDoktor.Text + "','" + cmBoxRandevTarihi.Text + "','" + label26.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("Randevu İşleminiz Başarıyla Gerçekleşmiştir");
                baglanti.Close();

                cmBoxKlinik.Select();
                klinileriGoster();
                panel1.Visible = false;
                cmBoxDoktor.Text = "";
                cmBoxRandevTarihi.Text = "";
            }

            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmBoxKlinik.Enabled = true;
            cmBoxKlinik.Text = "";
            cmBoxRandevTarihi.Text = "";
            cmBoxDoktor.Enabled = false;
            cmBoxDoktor.Text = "";
            cmBoxKlinik.Text = "";
            cmBoxRandevTarihi.Text = "";
            panel1.Visible = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

       
    }
}
