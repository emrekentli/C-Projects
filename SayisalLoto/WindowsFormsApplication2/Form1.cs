using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {

        Int32 nmb1, nmb2, nmb3, nmb4, nmb5, nmb6, puan=0;
        public Form1()
        {
            InitializeComponent();
        }
      
        private void label8_Click(object sender, EventArgs e)
        {

        }

 

        private void generatebutton_Click(object sender, EventArgs e)
        {
        

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("Hatali Giriş!");
                generatebutton.Enabled = false;
                check.Visible = false;
            }


            int A1 = Convert.ToInt32(textBox1.Text);
            int A2 = Convert.ToInt32(textBox2.Text);
            int A3 = Convert.ToInt32(textBox3.Text);
            int A4 = Convert.ToInt32(textBox4.Text);
            int A5 = Convert.ToInt32(textBox5.Text);
            int A6 = Convert.ToInt32(textBox6.Text);

        

            textBox1.Enabled = false;
            generatebutton.Enabled = false;
           
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;

           
               

            if (textBox1.Text == textBox2.Text ||  textBox1.Text == textBox3.Text || textBox1.Text == textBox4.Text || textBox1.Text == textBox5.Text || textBox1.Text == textBox6.Text || A1 < 1 || A1 > 49)
            {
               
                label1.Visible = false;
               
                loto1.Visible = false;
                loto2.Visible = false;
                loto3.Visible = false;
                loto4.Visible = false;
                loto5.Visible = false;
                loto6.Visible = false;
                listBox1.Visible = false;
                MessageBox.Show("Hatali Giriş!");
                generatebutton.Enabled = false;
                check.Visible = false;

            }

            else
                if (textBox2.Text == textBox1.Text || textBox2.Text == textBox3.Text || textBox2.Text == textBox4.Text || textBox2.Text == textBox5.Text || textBox2.Text == textBox6.Text || A2 < 1 || A2 > 49)
            {
               
                label1.Visible = false;
               
                loto1.Visible = false;
                loto2.Visible = false;
                loto3.Visible = false;
                loto4.Visible = false;
                loto5.Visible = false;
                loto6.Visible = false;
                listBox1.Visible = false;
                MessageBox.Show("Hatali Giriş!");
                generatebutton.Enabled = false;
                check.Visible = false;
            }

                else if (textBox3.Text == textBox1.Text || textBox3.Text == textBox2.Text || textBox3.Text == textBox4.Text || textBox3.Text == textBox5.Text || textBox3.Text == textBox6.Text || A3 < 1 || A3 > 49)
            {
                
                label1.Visible = false;
                
                loto1.Visible = false;
                loto2.Visible = false;
                loto3.Visible = false;
                loto4.Visible = false;
                loto5.Visible = false;
                loto6.Visible = false;
                listBox1.Visible = false;
                check.Visible = false;
                MessageBox.Show("Hatali Giriş!");
                generatebutton.Enabled = false;

            }

                else if (textBox4.Text == textBox1.Text || textBox4.Text == textBox2.Text || textBox4.Text == textBox3.Text || textBox4.Text == textBox5.Text || textBox4.Text == textBox6.Text || A4 < 1 || A4 > 49)
            {
                
                label1.Visible = false;
               
                loto1.Visible = false;
                loto2.Visible = false;
                loto3.Visible = false;
                loto4.Visible = false;
                loto5.Visible = false;
                loto6.Visible = false;
                listBox1.Visible = false;
                MessageBox.Show("Hatali Giriş!");
                generatebutton.Enabled = false;
                check.Visible = false;

            }

                else if (textBox5.Text == textBox1.Text || textBox5.Text == textBox2.Text || textBox5.Text == textBox3.Text || textBox5.Text == textBox4.Text || textBox5.Text == textBox6.Text || A5 < 1 || A5 > 49)
            {
               
                label1.Visible = false;
               
                loto1.Visible = false;
                loto2.Visible = false;
                loto3.Visible = false;
                loto4.Visible = false;
                loto5.Visible = false;
                loto6.Visible = false;
                listBox1.Visible = false;
                MessageBox.Show("Hatali Giriş!");
                generatebutton.Enabled = false;
                check.Visible = false;

            }

                else if (textBox6.Text == textBox1.Text || textBox6.Text == textBox2.Text || textBox6.Text == textBox3.Text || textBox6.Text == textBox4.Text || textBox6.Text == textBox5.Text || A6 < 1 || A6> 49)
            {
                
                label1.Visible = false;
              
                loto1.Visible = false;
                loto2.Visible = false;
                loto3.Visible = false;
                loto4.Visible = false;
                loto5.Visible = false;
                loto6.Visible = false;
                listBox1.Visible = false;
                    MessageBox.Show("Hatali Giriş!");
                generatebutton.Enabled = false;
                check.Visible = false;


            }

            Random rastgele = new Random();
            nmb1 = rastgele.Next(1, 50);
            loto1.Text = nmb1.ToString();

            nmb2 = rastgele.Next(1, 50);
            loto2.Text = nmb2.ToString();

            nmb3 = rastgele.Next(1, 50);
            loto3.Text = nmb3.ToString();

            nmb4 = rastgele.Next(1, 50);
            loto4.Text = nmb4.ToString();

            nmb5 = rastgele.Next(1, 50);
            loto5.Text = nmb5.ToString();

            nmb6 = rastgele.Next(1, 50);
            loto6.Text = nmb6.ToString();

            if (nmb1 == nmb2 || nmb1 == nmb3 || nmb1 == nmb4 || nmb1 == nmb5 || nmb1 == nmb6)
            {
                nmb1 = rastgele.Next(1, 50);
                loto1.Text = nmb1.ToString();
            }

            if (nmb2 == nmb1 || nmb2 == nmb3 || nmb2 == nmb4 || nmb2 == nmb5 || nmb2 == nmb6)
            {
                nmb2 = rastgele.Next(1, 50);
                loto2.Text = nmb2.ToString();
            }


            if (nmb3 == nmb1 || nmb3 == nmb2 || nmb3 == nmb4 || nmb3 == nmb5 || nmb3 == nmb6)
            {
                nmb3 = rastgele.Next(1, 50);
                loto3.Text = nmb3.ToString();
            }


            if (nmb4 == nmb1 || nmb4 == nmb2 || nmb4 == nmb3 || nmb4 == nmb5 || nmb4 == nmb6)
            {
                nmb4 = rastgele.Next(1, 50);
                loto4.Text = nmb4.ToString();
            }


            if (nmb5 == nmb1 || nmb5 == nmb2 || nmb5 == nmb3 || nmb5 == nmb4 || nmb5 == nmb6)
            {
                nmb5 = rastgele.Next(1, 50);
                loto5.Text = nmb5.ToString();
            }


            if (nmb6 == nmb1 || nmb6 == nmb2 || nmb6 == nmb3 || nmb6 == nmb4 || nmb6 == nmb5)
            {
                nmb6 = rastgele.Next(1, 50);
                loto6.Text = nmb6.ToString();
            }

 
            /////////

            if (textBox1.Text == loto1.Text || textBox1.Text == loto2.Text || textBox1.Text == loto3.Text || textBox1.Text == loto4.Text || textBox1.Text == loto5.Text || textBox1.Text == loto6.Text)
            {
                listBox1.Items.Add(textBox1.Text);
                puan = puan + 1;
            }
            if (textBox2.Text == loto1.Text || textBox2.Text == loto2.Text || textBox2.Text == loto3.Text || textBox2.Text == loto4.Text || textBox2.Text == loto5.Text || textBox2.Text == loto6.Text)
            {
                listBox1.Items.Add(textBox2.Text);
                puan = puan + 1;
            }
            if (textBox3.Text == loto1.Text || textBox3.Text == loto2.Text || textBox3.Text == loto3.Text || textBox3.Text == loto4.Text || textBox3.Text == loto5.Text || textBox3.Text == loto6.Text)
            {
                listBox1.Items.Add(textBox3.Text);
                puan = puan + 1;
            }
            if (textBox4.Text == loto1.Text || textBox4.Text == loto2.Text || textBox4.Text == loto3.Text || textBox4.Text == loto4.Text || textBox4.Text == loto5.Text || textBox4.Text == loto6.Text)
            {
                listBox1.Items.Add(textBox4.Text);
                puan = puan + 1;
            }

            if (textBox5.Text == loto1.Text || textBox5.Text == loto2.Text || textBox5.Text == loto3.Text || textBox5.Text == loto4.Text || textBox5.Text == loto5.Text || textBox5.Text == loto6.Text)
            {
                listBox1.Items.Add(textBox5.Text);
                puan = puan + 1;
            }
            if (textBox6.Text == loto1.Text || textBox6.Text == loto2.Text || textBox6.Text == loto3.Text || textBox6.Text == loto4.Text || textBox6.Text == loto5.Text || textBox6.Text == loto6.Text)
            {
                listBox1.Items.Add(textBox6.Text);
                puan = puan + 1;
            }
            
            ///////
            if (puan == 0 )
            {
                label1.Text = "Üzgünüm. Hiçbir Sayıyı Bilemedin.";

            }
            else if (puan == 1)
            {
                label1.Text = "Tebrikler! 1 Sayı Tutturdunuz. \nBizden 100 TL Kazandınız. ";

            }

            else if (puan == 2)
            {
                label1.Text = "Tebrikler! 2 Sayı Tutturdunuz. \n Bizden 300 TL Kazandınız. ";

            }
            else if (puan == 3)
            {
                label1.Text = "Tebrikler! 3 Sayı Tutturdunuz. \n Bizden 1.000 TL Kazandınız. ";

            }

            else if (puan == 4)
            {
                label1.Text = "Tebrikler! 4 Sayı Tutturdunuz. \n Bizden 5.000 TL Kazandınız. ";

            }

            else if (puan == 5)
            {
                label1.Text = "Tebrikler! 5 Sayı Tutturdunuz. \n Bizden 10.000 TL Kazandınız. ";

            }

            else if (puan == 6)
            {
                label1.Text = "Tebrikler! 6 Sayı Tutturdunuz. \n Bizden 1.000.000 TL Kazandınız. ";

            }

            if (puan == 1 || puan == 2 || puan == 3 || puan == 4 || puan == 5 || puan == 6)
            {
                check.Visible = true;

            }

          
            }

        private void button1_Click(object sender, EventArgs e)
        {
            puan = 0;
            check.Visible = false;
            generatebutton.Enabled = true;
            textBox1.Enabled = true;
             textBox2.Enabled = true;
             textBox3.Enabled = true;
             textBox4.Enabled = true;
             textBox5.Enabled = true;
             textBox6.Enabled = true;
             loto1.Visible = true;
             loto2.Visible = true;
             loto3.Visible = true;
             loto4.Visible = true;
             loto5.Visible = true;
             loto6.Visible = true;
             label1.Visible = true;
             listBox1.Items.Clear();
             listBox1.Visible = true;
            
             label1.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            loto1.Text = "X";
            loto2.Text = "X";
            loto3.Text = "X";
            loto4.Text = "X";
            loto5.Text = "X";
            loto6.Text = "X";
            
        }

    

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loto3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

     e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
             e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            MessageBox.Show("Çek Kodunuz : " + CreateActivationCode());
        }

        public static string CreateActivationCode()

{

   string Code = Guid.NewGuid().ToString();

   return Code;

}

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      

       
    }
}
