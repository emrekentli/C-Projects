using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form5 formkapa = new Form5();
            formkapa.Close();
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || comboBox2.Text == "" || textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Lütfen Boş Yer Bırakmayınız!");

                Form5 formkapa = new Form5();
                formkapa.Close();
                Form5 form = new Form5();
                form.Show();
                this.Hide();
            }


            else if (comboBox1.Text != "" || comboBox2.Text != "" || textBox1.Text != "" || textBox2.Text != "" || textBox3.Text != "" || textBox4.Text != "")
            {
                MessageBox.Show("Siparişiniz Verilmiştir. Afiyet Olsun.");
                this.Close();
            }

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
        
    }
}
