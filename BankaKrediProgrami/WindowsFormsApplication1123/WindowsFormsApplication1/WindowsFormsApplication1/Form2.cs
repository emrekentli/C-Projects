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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            button4.Text = "Araç Kredisi";
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.Text = "";
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.Text = "Konut Kredisi";
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Text = "";
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            button2.Text = "İhtiyaç Kredisi";
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.Text = "";
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            button3.Text = "İşyeri Kredisi";
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.Text = "";
        }
    }
}
