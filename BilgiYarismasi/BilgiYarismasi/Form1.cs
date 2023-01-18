using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.IO;


namespace BilgiYarismasi
{
    public partial class Form1 : Form
    {
        public static int joker1 = 1;
        public static int joker2 = 1;
        public static int joker3 = 1;
        SoundPlayer player = new SoundPlayer();
        public static int zaman = 30;
        public static int Puan = 0;
        public Form1()
        {
            InitializeComponent();
        }



        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            radioButton2.Enabled = false;
            radioButton1.Enabled = false;
            radioButton4.Enabled = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            radioButton1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                Puan += 500;
                Form1 form1 = new Form1();
                form1.Close();
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
                Form13 form13 = new Form13();
                form13.label3.Text = Puan.ToString() + " TL";
                timer1.Enabled = false;
            }
            else if (radioButton2.Checked == true)
            {

                Form1 form1 = new Form1();
                form1.Close();
                Form13 form13 = new Form13();
                form13.Show();
                this.Hide();
                form13.label3.Text = Puan.ToString() + " TL";
            }

            else if (radioButton3.Checked == true)
            {
                Form1 form1 = new Form1();
                form1.Close();
                Form13 form13 = new Form13();
                form13.Show();
                this.Hide();
                form13.label3.Text = Puan.ToString() + " TL";
            }
            else if (radioButton4.Checked == true)
            {
                
                Form1 form1 = new Form1();
                form1.Close();
                Form13 form13 = new Form13();
                form13.Show();
                this.Hide();
                form13.label3.Text = Puan.ToString() + " TL";
            }
            timer1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            //////////////
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;
            radioButton4.Enabled = true;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1x_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = joker1.ToString();
            label4.Text = joker2.ToString();
            label5.Text = joker3.ToString();
            timer1.Enabled = true;
            string dizin = Application.StartupPath + "\\sorugiris.wav";
            player.SoundLocation = dizin;
            player.Play();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            zaman--;
            label2.Text = "SÜRE : " + zaman.ToString();
            if (zaman==0)
            {
                timer1.Enabled = false;
                MessageBox.Show("Süreniz DOLDU!");
                Form1 form1 = new Form1();
                form1.Close();
                Form13 form13 = new Form13();
                form13.Show();
                this.Hide();
                form13.label3.Text = Puan.ToString() + " TL";
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult x = MessageBox.Show("Programdan Çıkmak İstediğinizden Emin Misiniz?", "Çıkış Mesajı!", MessageBoxButtons.YesNo);
            if (x == DialogResult.Yes)
            {
                //Evet tıklandığında Yapılacak İşlemler
                Environment.Exit(0); // Evet tıklandığında uygulama kapanacak

            }
            else if (x == DialogResult.No)
            {
                // Hayır tıklandığında yapılacak işlemler
                e.Cancel = true; // Hayır tıklandığında iptal edilecek
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            joker1--;
            Form2 form2 = new Form2();
            form2.label3.Text = joker1.ToString();
            label3.Text = joker1.ToString();
            pictureBox1.Visible = false;
            radioButton3.Visible = false;
            radioButton2.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
            joker2--;
            Form2 form2 = new Form2();
            form2.label4.Text = joker2.ToString();
            pictureBox5.Visible = true;
            pictureBox3.Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            joker3--;
            Form2 form2 = new Form2();
            form2.label5.Text = joker3.ToString();
            pictureBox4.Visible = false;
            MessageBox.Show("Aradığınız kişi cevabın 1299 olduğunu düşünüyor");
        }

        

       
    }
}
