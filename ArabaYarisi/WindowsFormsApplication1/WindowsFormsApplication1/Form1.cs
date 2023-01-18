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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int saniye = 0;
        Random r = new Random();
        private void button1_Click(object sender, EventArgs e)
        {

            button1.Enabled = false;
            timer1.Start();
            timer2.Start();
            timer3.Start();
            timer5.Start();
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button3.Enabled = false; ;
            button4.Enabled = false;
            button5.Enabled = false; ;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;

            timer1.Stop();
            timer5.Stop();
            timer2.Stop();
            timer3.Stop();
            Araba1.Location = new Point(28, 81);
            Araba2.Location = new Point(28, 241);
            Araba3.Location = new Point(28, 379);
            label3.Visible = false;
            label4.Visible = false;
            lblyorumsatiri.Text = "";
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Araba1.Left = Araba1.Left + 100;
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            button3.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Araba2.Left = Araba2.Left + 100;
            button6.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            button6.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Enabled = false;

            Araba3.Left = Araba3.Left + 100;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button8.Enabled = false;
            timer3.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Araba1.Left = Araba1.Left + r.Next(6, 10); 
            if (Araba1.Left > Araba2.Left + 1 && Araba1.Left > Araba3.Left + 1)
            {
                lblyorumsatiri.Text = "Ferrari yarışı önde götürüyor...";
            }
            else if (Araba2.Left > Araba1.Left + 2 && Araba2.Left > Araba3.Left + 2)
            {
                lblyorumsatiri.Text = "Toyota atak yaptı...";

            }

            else if (Araba3.Left > Araba1.Left + 2 && Araba3.Left > Araba2.Left + 2)
            {
                lblyorumsatiri.Text = "Mitsubishi hızla yarışı önde götürüyor....";
            }

            if (Araba1.Width + Araba1.Left > lblfinish.Left)
            {
                timer1.Stop();
                lblyorumsatiri.Text = "..::Ferrari yarışı kazandı::..";
            }
            else if (Araba2.Width + Araba2.Left > lblfinish.Left)
            {
                timer1.Stop();
                lblyorumsatiri.Text = "..::Toyota yarışı kazandı::..";
            }
            else if (Araba3.Width + Araba3.Left > lblfinish.Left)
            {
                timer1.Stop();
                lblyorumsatiri.Text = "..::Mitsubishi yarışı kazandı::..";
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Araba2.Left = Araba2.Left + r.Next(6,10);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            Araba3.Left = Araba3.Left + r.Next(6, 10);
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (Araba1.Width+Araba1.Left>lblfinish.Left)
            {
               
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                timer5.Stop();

                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                label3.Visible = true;
                label4.Visible = true;
                lblyorumsatiri.Visible = true;

                lblyorumsatiri.Text = ("Ferrari Yarışmayı " + saniye + " sn. ile Kazandı!");



            }

           else if (Araba2.Width+Araba2.Left>lblfinish.Left)
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                timer5.Stop();
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                label3.Visible = true;
                label4.Visible = true;
               lblyorumsatiri.Visible = true;

               lblyorumsatiri.Text = ("Toyota Yarışmayı " + saniye + " sn. ile Kazandı!");

            }

              else if (Araba3.Width+Araba3.Left>lblfinish.Left)
    {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                timer5.Stop();
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                label3.Visible = true;
                label4.Visible = true;
                lblyorumsatiri.Visible = true;

                lblyorumsatiri.Text = ("Mitsubishi Yarışmayı " + saniye + " sn. ile Kazandı!");

            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            saniye++;
            label2.Text = saniye.ToString();
        }
    }
}
