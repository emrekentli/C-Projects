﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        double hesap1 = 0.89;
        double hesap2 = 1.05;
        double sonuc;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt1.Enabled = false;
            txt2.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt2.Enabled = false;
            txt3.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = true;

            int a, b,c;
            a = Convert.ToInt32(txt1.Text);
            b = Convert.ToInt32(txt2.Text);

            if (b<a/4)
            {
                MessageBox.Show("Peşinat Az!");
                label7.Text = "";
                txt1.Enabled = true;
                txt2.Enabled = false;
                txt3.Enabled = false;
                button5.Enabled = false;
                txt1.Clear();
                txt2.Clear();
                txt3.Clear();
                button2.Enabled = false;
                button3.Enabled = false;
                button1.Enabled = true;
                label4.Text = "";
                label5.Text = "";
                label6.Text = "";
            }
            if (b>a)
            {
                MessageBox.Show("Peşinat Konut fiyatından fazla olamaz!");
                label7.Text = "";
                txt1.Enabled = true;
                txt2.Enabled = false;
                txt3.Enabled = false;
                button5.Enabled = false;
                txt1.Clear();
                txt2.Clear();
                txt3.Clear();
                label4.Text = "";
                button2.Enabled = false;
                button3.Enabled = false;
                button1.Enabled = true;
                label5.Text = "";
                label6.Text = "";
            }

            c = a - b;
            txt3.Text = c.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label7.Text = "";
            txt1.Enabled = true;
            txt2.Enabled = false;
            txt3.Enabled = false;
            button5.Enabled = false;
            txt1.Clear();
            txt2.Clear();
            txt3.Clear();
            button2.Enabled = false;
            button3.Enabled = false;
            button1.Enabled = true;
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
           double a = Convert.ToInt32(txt3.Text);
           double b = Convert.ToInt32(comboBox1.Text);
            
            if (b<61)
            {
                double sonucc;
                
                double taksit;
                double er = b;
                sonuc = a * hesap1;
                sonucc = a + sonuc;
                taksit = sonucc / er;
                label4.Text = taksit.ToString() + " TL";
                label5.Text = sonucc.ToString() + " TL";
                label6.Text = "0.89";
                label7.Text = sonuc + " TL";

               
            }
            else if (b>60)
            {
                double sonucc;
                double taksit;
                double er = b;
                
                sonuc = a * hesap2;
                sonucc = a + sonuc;
                taksit = sonucc / er;
                label4.Text = taksit.ToString() + " TL" ;
                label5.Text =sonucc.ToString() + " TL";
                label6.Text = "1.05";
                label7.Text = sonuc + " TL";
            }

            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txt3.Enabled = false;
            button3.Enabled = false;
           
            comboBox1.Enabled = true;
        }

        private void cmb1(object sender, EventArgs e)
        {
            button5.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
