using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form4 : Form
    {
        double hesap1 = 0.35;
        
        double sonuc;
        public Form4()
        {
            InitializeComponent();
        }
        private void button5_Click_1(object sender, EventArgs e)
        {
            double a = Convert.ToInt32(txt3.Text);
            double b = Convert.ToInt32(comboBox1.Text);

            if (b < 49)
            {
                double sonucc;
                double taksit;
                double er = b;
                sonuc = a * hesap1;
                sonucc = a + sonuc;
                taksit = sonucc / er;
                label2.Text = taksit.ToString() + " TL";
                label5.Text = sonucc.ToString() + " TL";
                label6.Text = "0,35";
                label7.Text = sonuc + " TL";


            }
           
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txt3.Text) > 50000)
            {
                MessageBox.Show("Alabileceğiniz Maksimum miktar 50000 TL'dir.");

            }
            else
            {


                button3.Enabled = false;
                comboBox1.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            label7.Text = "";
            button3.Enabled = true;
            txt3.Enabled =true;
            button5.Enabled = false;
            label2.Text = "";
            txt3.Clear();
           
            button3.Enabled = true;
            
            label5.Text = "";
            label6.Text = "";
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
      
    }
}
