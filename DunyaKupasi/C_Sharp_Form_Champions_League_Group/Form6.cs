using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C_Sharp_Form_Champions_League_Group
{
    public partial class Form6 : Form
    {
        public static int sayac = 0;
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            sayac++;
            button1.Enabled = false;
            Random number = new Random();
            txt1.Text = number.Next(0, 5).ToString();

            txt2.Text = number.Next(0, 5).ToString();


            int a, b;

            a = Convert.ToInt32(txt1.Text);
            b = Convert.ToInt32(txt2.Text);
            if (a > b)
            {

                Form7 form7 = new Form7();
                form7.Show();
                form7.label2.Text = lbl1.Text;
                

            }
            else if (b > a)
            {

                Form7 form7 = new Form7();
                form7.Show();

                form7.label2.Text = lbl2.Text;

            }
            else if (txt1.Text == txt2.Text)
            {
                button1.Text = "Tekrar Oyna";
                button1.Enabled = true;
                sayac--;
            }
            
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            if (lbl1.Text == "İsrail")
            {
                pb1.ImageLocation = ("Israel.png");
            }
            else if (lbl1.Text == "İsveç")
            {
                pb1.ImageLocation = ("Sweden.png");
            }
            else if (lbl1.Text == "Macaristan")
            {
                pb1.ImageLocation = ("Hungary.png");
            }
            else if (lbl1.Text == "Romanya")
            {
                pb1.ImageLocation = ("Romania.png");
            }
            else if (lbl1.Text == "Sırbistan")
            {
                pb1.ImageLocation = ("Serbia.png");
            }
            else if (lbl1.Text == "Brezilya")
            {
                pb1.ImageLocation = ("Brazil.png");
            }
            else if (lbl1.Text == "Estonya")
            {
                pb1.ImageLocation = ("Estonia.png");
            }
            else if (lbl1.Text == "Slovenya")
            {
                pb1.ImageLocation = ("Slovenia.png");
            }
            else if (lbl1.Text == "Norveç")
            {
                pb1.ImageLocation = ("Norway.png");
            }
            else if (lbl1.Text == "Azerbaycan")
            {
                pb1.ImageLocation = ("Azerbaijan.png");
            }
            else if (lbl1.Text == "Kazakistan")
            {
                pb1.ImageLocation = ("Kazakhstan.png");
            }
            else if (lbl1.Text == "Polonya")
            {
                pb1.ImageLocation = ("Poland.png");
            }
            else if (lbl1.Text == "Ukrayna")
            {
                pb1.ImageLocation = ("Ukraine.png");
            }
            else if (lbl1.Text == "Bosna Hersek")
            {
                pb1.ImageLocation = ("Bosnia-and-Herzegovina.png");
            }
            else if (lbl1.Text == "Danimarka")
            {
                pb1.ImageLocation = ("Denmark.png");
            }
            else if (lbl1.Text == "İzlanda")
            {
                pb1.ImageLocation = ("Ireland.png");
            }
            else if (lbl1.Text == "Fransa")
            {
                pb1.ImageLocation = ("France.png");
            }
            else if (lbl1.Text == "Çek Cumhuriyeti")
            {
                pb1.ImageLocation = ("Czech-Republic.png");
            }
            else if (lbl1.Text == "İsviçre")
            {
                pb1.ImageLocation = ("Switzerland.png");
            }
            else if (lbl1.Text == "İtalya")
            {
                pb1.ImageLocation = ("Italy.png");
            }
            else if (lbl1.Text == "Avusturya")
            {
                pb1.ImageLocation = ("Austria.png");
            }
            else if (lbl1.Text == "Slovakya")
            {
                pb1.ImageLocation = ("Slovakia.png");
            }
            else if (lbl1.Text == "Hırvatistan")
            {
                pb1.ImageLocation = ("Crotia.png");
            }
            else if (lbl1.Text == "İspanya")
            {
                pb1.ImageLocation = ("Spain.png");
            }
            else if (lbl1.Text == "Galler")
            {
                pb1.ImageLocation = ("Wales.png");
            }
            else if (lbl1.Text == "İngiltere")
            {
                pb1.ImageLocation = ("England.png");
            }
            else if (lbl1.Text == "Portekiz")
            {
                pb1.ImageLocation = ("Portugal.png");
            }
            else if (lbl1.Text == "Litvanya")
            {
                pb1.ImageLocation = ("Lithuania.png");
            }
            else if (lbl1.Text == "Hollanda")
            {
                pb1.ImageLocation = ("Holland.png");
            }
            else if (lbl1.Text == "Belçika")
            {
                pb1.ImageLocation = ("Belgium.png");
            }
            else if (lbl1.Text == "Almanya")
            {
                pb1.ImageLocation = ("Germany.png");
            }
            else if (lbl1.Text == "Türkiye")
            {
                pb1.ImageLocation = ("Turkey.png");
            }
            /////
            if (lbl2.Text == "İsrail")
            {
                pb2.ImageLocation = ("Israel.png");
            }
            else if (lbl2.Text == "İsveç")
            {
                pb2.ImageLocation = ("Sweden.png");
            }
            else if (lbl2.Text == "Macaristan")
            {
                pb2.ImageLocation = ("Hungary.png");
            }
            else if (lbl2.Text == "Romanya")
            {
                pb2.ImageLocation = ("Romania.png");
            }
            else if (lbl2.Text == "Sırbistan")
            {
                pb2.ImageLocation = ("Serbia.png");
            }
            else if (lbl2.Text == "Brezilya")
            {
                pb2.ImageLocation = ("Brazil.png");
            }
            else if (lbl2.Text == "Estonya")
            {
                pb2.ImageLocation = ("Estonia.png");
            }
            else if (lbl2.Text == "Slovenya")
            {
                pb2.ImageLocation = ("Slovenia.png");
            }
            else if (lbl2.Text == "Norveç")
            {
                pb2.ImageLocation = ("Norway.png");
            }
            else if (lbl2.Text == "Azerbaycan")
            {
                pb2.ImageLocation = ("Azerbaijan.png");
            }
            else if (lbl2.Text == "Kazakistan")
            {
                pb2.ImageLocation = ("Kazakhstan.png");
            }
            else if (lbl2.Text == "Polonya")
            {
                pb2.ImageLocation = ("Poland.png");
            }
            else if (lbl2.Text == "Ukrayna")
            {
                pb2.ImageLocation = ("Ukraine.png");
            }
            else if (lbl2.Text == "Bosna Hersek")
            {
                pb2.ImageLocation = ("Bosnia-and-Herzegovina.png");
            }
            else if (lbl2.Text == "Danimarka")
            {
                pb2.ImageLocation = ("Denmark.png");
            }
            else if (lbl2.Text == "İzlanda")
            {
                pb2.ImageLocation = ("Ireland.png");
            }
            else if (lbl2.Text == "Fransa")
            {
                pb2.ImageLocation = ("France.png");
            }
            else if (lbl2.Text == "Çek Cumhuriyeti")
            {
                pb2.ImageLocation = ("Czech-Republic.png");
            }
            else if (lbl2.Text == "İsviçre")
            {
                pb2.ImageLocation = ("Switzerland.png");
            }
            else if (lbl2.Text == "İtalya")
            {
                pb2.ImageLocation = ("Italy.png");
            }
            else if (lbl2.Text == "Avusturya")
            {
                pb2.ImageLocation = ("Austria.png");
            }
            else if (lbl2.Text == "Slovakya")
            {
                pb2.ImageLocation = ("Slovakia.png");
            }
            else if (lbl2.Text == "Hırvatistan")
            {
                pb2.ImageLocation = ("Crotia.png");
            }
            else if (lbl2.Text == "İspanya")
            {
                pb2.ImageLocation = ("Spain.png");
            }
            else if (lbl2.Text == "Galler")
            {
                pb2.ImageLocation = ("Wales.png");
            }
            else if (lbl2.Text == "İngiltere")
            {
                pb2.ImageLocation = ("England.png");
            }
            else if (lbl2.Text == "Portekiz")
            {
                pb2.ImageLocation = ("Portugal.png");
            }
            else if (lbl2.Text == "Litvanya")
            {
                pb2.ImageLocation = ("Lithuania.png");
            }
            else if (lbl2.Text == "Hollanda")
            {
                pb2.ImageLocation = ("Holland.png");
            }
            else if (lbl2.Text == "Belçika")
            {
                pb2.ImageLocation = ("Belgium.png");
            }
            else if (lbl2.Text == "Almanya")
            {
                pb2.ImageLocation = ("Germany.png");
            }
            else if (lbl2.Text == "Türkiye")
            {
                pb2.ImageLocation = ("Turkey.png");
            }
           
        }

        private void button17_Click(object sender, EventArgs e)
        {

        }
    }
}
