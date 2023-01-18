﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
namespace BilgiYarismasi
{
    public partial class Form3 : Form
    {
        public static int joker1;
        public static int joker2;
        public static int joker3;
        SoundPlayer player = new SoundPlayer();
        public static int Puan = 1000;
        Int32 zaman = 30;
        public Form3()
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
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton4.Enabled = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Enabled = false;
            radioButton3.Enabled = false;
            radioButton2.Enabled = false;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
              
                Form3 form3 = new Form3();
                form3.Close();
                Form13 form13 = new Form13();
                form13.Show();
                this.Hide();
                form13.label3.Text = Puan.ToString() + " TL";
                
            }
            else if (radioButton2.Checked == true)
            {

                Form3 form3 = new Form3();
                form3.Close();
                Form13 form13 = new Form13();
                form13.Show();
                this.Hide();
                form13.label3.Text = Puan.ToString() + " TL";
            }

            else if (radioButton3.Checked == true)
            {

                Form3 form3 = new Form3();
                form3.Close();
                Form13 form13 = new Form13();
                form13.Show();
                this.Hide();
                form13.label3.Text = Puan.ToString() + " TL";
            }
            else if (radioButton4.Checked == true)
            {
               
                Form3 form3 = new Form3();
                form3.Close();
                Form4 form4 = new Form4();
                form4.Show();
                this.Hide();

            }
            timer1.Enabled = false;
        }

     

        private void button1_Click_2(object sender, EventArgs e)
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

        private void Form3_Load(object sender, EventArgs e)
        {
            label3.Text = Form2.joker1.ToString();
            label4.Text = Form2.joker2.ToString();
            label5.Text = Form2.joker3.ToString();
            joker1 = Convert.ToInt32(label3.Text);
            joker2 = Convert.ToInt32(label4.Text);
            joker3 = Convert.ToInt32(label5.Text);
            string dizin = Application.StartupPath + "\\dogrucevap.wav";
            player.SoundLocation = dizin;
            player.Play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            Form3 form3 = new Form3();
            form3.Close();
            Form13 form13 = new Form13();
            form13.Show();
            form13.label3.Text = Puan.ToString() + " TL";
            this.Hide();

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {

            radioButton1.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;
        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {

            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton4.Enabled = false;
        }

        private void radioButton4_CheckedChanged_1(object sender, EventArgs e)
        {

            radioButton1.Enabled = false;
            radioButton3.Enabled = false;
            radioButton2.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            zaman--;
            label2.Text = "SÜRE : " + zaman.ToString();
            if (zaman == 0)
            {
                timer1.Enabled = false;
                MessageBox.Show("Süreniz DOLDU!");
                Form3 form3 = new Form3();
                form3.Close();
                Form13 form13 = new Form13();
                form13.Show();
                this.Hide();
                form13.label3.Text = Puan.ToString() + " TL";

            }

        }

        private void x(object sender, FormClosingEventArgs e)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (joker1 == 1)
            {
                joker1--;
                Form4 form4 = new Form4();
                form4.label3.Text = joker1.ToString();
                pictureBox1.Visible = false;
                radioButton3.Visible = false;
                radioButton1.Visible = false;
            }
            else
            {
                MessageBox.Show("Bu jokeri daha önce kullandınız.");
            }
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (joker2 == 1)
            {
                joker2--;
                Form4 form4 = new Form4();
                form4.label4.Text = joker2.ToString();
                pictureBox5.Visible = true;
                pictureBox3.Visible = false;
            }
            else
            {
                MessageBox.Show("Bu jokeri daha önce kullandınız.");
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (joker3 == 1)
            {
                joker3--;
                pictureBox4.Visible = false;
                MessageBox.Show("Aradığınız kişi cevabın Kamikaze olduğunu düşünüyor");
                Form4 form4 = new Form4();
                form4.label5.Text = joker3.ToString();
            }
            else
            {
                MessageBox.Show("Bu jokeri daha önce kullandınız.");
            }
           }


    }
}
