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
    public partial class Form7 : Form
    {
        public static string kadi;
        public static string isim;
        public static string sifre;
        public static string sql;
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            if (textBox1.Text=="" || textBox2.Text=="" || textBox3.Text=="" || comboBox1.Text == "")
            {
                MessageBox.Show("Lütfen boş bırakılan alanları eksiksiz doldurunuz.");

            }
            else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && comboBox1.Text!="")
            {
                isim = textBox1.Text;
                kadi = textBox2.Text;
                sifre = textBox3.Text;
                sql = comboBox1.Text;
                MessageBox.Show("Kayıt işlemi tamamlandı.");
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
                form1.button1.Enabled = false;
                
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Today.AddYears(-20);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = false;
            button2.Enabled = false;
            comboBox1.Enabled = true;
            DateTime dogumgunu = new DateTime();
            dogumgunu = dateTimePicker1.Value;
            int dogumyili = dateTimePicker1.Value.Year;
            int buyil = DateTime.Today.Year;
            int yas = 0;
            yas = buyil - dogumyili;


            if (yas < 20)
            {
                MessageBox.Show("Bankamız yaşınızdan dolayı kredi verememektedir.\n İyi Günler Dileriz.");
                Application.Exit();
            }
            else
            {

                button1.Enabled = true;
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
            }
        }
    }
}
