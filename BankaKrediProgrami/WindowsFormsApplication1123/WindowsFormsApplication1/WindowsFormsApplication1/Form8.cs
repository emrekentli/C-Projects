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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a,b;
            a= textBox2.Text;
            b= textBox3.Text;   
            if (Form7.kadi == a && Form7.sifre == b)
            {
                MessageBox.Show("Başarıyla giriş yaptınız.");
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }

            else if (Form7.kadi != a || Form7.sifre != b)
            {
                MessageBox.Show("Hatalı giriş yaptınız. Lütfen tekrar deneyiniz.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
