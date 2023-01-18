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
    public partial class Form4 : Form
    {
        public static int sayac = 0;
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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
                label1.Text = lbl1.Text + " Kazandı!";
                listBox1.Items.Add(lbl1.Text);
                button2.Enabled = true;

            }
            else if (b > a)
            {

                label1.Text = lbl2.Text + " Kazandı!";
                listBox1.Items.Add(lbl2.Text);
                button2.Enabled = true;

            }
            else if (txt1.Text == txt2.Text)
            {
                button1.Text = "Tekrar Oyna";
                button1.Enabled = true;
                sayac--;
            }
            if (sayac == 4)
            {
                button17.Visible = Enabled;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sayac++;
            button2.Enabled = false;
            Random number = new Random();
            txt3.Text = number.Next(0, 5).ToString();

            txt4.Text = number.Next(0, 5).ToString();


            int a, b;

            a = Convert.ToInt32(txt3.Text);
            b = Convert.ToInt32(txt4.Text);
            if (a > b)
            {
                label2.Text = lbl3.Text + " Kazandı!";
                listBox1.Items.Add(lbl3.Text);
                button3.Enabled = true;
            }
            else if (b > a)
            {
                label2.Text = lbl4.Text + " Kazandı!";
                listBox1.Items.Add(lbl4.Text);
                button3.Enabled = true;
            }
            else if (txt3.Text == txt4.Text)
            {
                button2.Text = "Tekrar Oyna";
                button2.Enabled = true;
                sayac--;
            }
            if (sayac == 4)
            {
                button17.Visible = Enabled;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sayac++;
            button3.Enabled = false;
            Random number = new Random();
            txt5.Text = number.Next(0, 5).ToString();

            txt6.Text = number.Next(0, 5).ToString();


            int a, b;

            a = Convert.ToInt32(txt5.Text);
            b = Convert.ToInt32(txt6.Text);
            if (a > b)
            {
                label3.Text = lbl5.Text + " Kazandı!";
                listBox1.Items.Add(lbl5.Text);
                button4.Enabled = true;
            }
            else if (b > a)
            {
                label3.Text = lbl6.Text + " Kazandı!";
                listBox1.Items.Add(lbl6.Text);
                button4.Enabled = true;
            }
            else if (txt5.Text == txt6.Text)
            {
                button3.Text = "Tekrar Oyna";
                button3.Enabled = true;
                sayac--;
            }
            if (sayac == 4)
            {
                button17.Visible = Enabled;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sayac++;
            button4.Enabled = false;
            Random number = new Random();
            txt7.Text = number.Next(0, 5).ToString();

            txt8.Text = number.Next(0, 5).ToString();


            int a, b;

            a = Convert.ToInt32(txt7.Text);
            b = Convert.ToInt32(txt8.Text);
            if (a > b)
            {
                label4.Text = lbl7.Text + " Kazandı!";
                listBox1.Items.Add(lbl7.Text);
                
            }
            else if (b > a)
            {
                label4.Text = lbl8.Text + " Kazandı!";
                listBox1.Items.Add(lbl8.Text);
              
            }
            else if (txt7.Text == txt8.Text)
            {
                button4.Text = "Tekrar Oyna";
                button4.Enabled = true;
                sayac--;
            }
            if (sayac == 4)
            {
                button17.Visible = Enabled;
            }
        }

        private void Form4_Load(object sender, EventArgs e)
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
            /////////////
            if (lbl3.Text == "İsrail")
            {
                pb3.ImageLocation = ("Israel.png");
            }
            else if (lbl3.Text == "İsveç")
            {
                pb3.ImageLocation = ("Sweden.png");
            }
            else if (lbl3.Text == "Macaristan")
            {
                pb3.ImageLocation = ("Hungary.png");
            }
            else if (lbl3.Text == "Romanya")
            {
                pb3.ImageLocation = ("Romania.png");
            }
            else if (lbl3.Text == "Sırbistan")
            {
                pb3.ImageLocation = ("Serbia.png");
            }
            else if (lbl3.Text == "Brezilya")
            {
                pb3.ImageLocation = ("Brazil.png");
            }
            else if (lbl3.Text == "Estonya")
            {
                pb3.ImageLocation = ("Estonia.png");
            }
            else if (lbl3.Text == "Slovenya")
            {
                pb3.ImageLocation = ("Slovenia.png");
            }
            else if (lbl3.Text == "Norveç")
            {
                pb3.ImageLocation = ("Norway.png");
            }
            else if (lbl3.Text == "Azerbaycan")
            {
                pb3.ImageLocation = ("Azerbaijan.png");
            }
            else if (lbl3.Text == "Kazakistan")
            {
                pb3.ImageLocation = ("Kazakhstan.png");
            }
            else if (lbl3.Text == "Polonya")
            {
                pb3.ImageLocation = ("Poland.png");
            }
            else if (lbl3.Text == "Ukrayna")
            {
                pb3.ImageLocation = ("Ukraine.png");
            }
            else if (lbl3.Text == "Bosna Hersek")
            {
                pb3.ImageLocation = ("Bosnia-and-Herzegovina.png");
            }
            else if (lbl3.Text == "Danimarka")
            {
                pb3.ImageLocation = ("Denmark.png");
            }
            else if (lbl3.Text == "İzlanda")
            {
                pb3.ImageLocation = ("Ireland.png");
            }
            else if (lbl3.Text == "Fransa")
            {
                pb3.ImageLocation = ("France.png");
            }
            else if (lbl3.Text == "Çek Cumhuriyeti")
            {
                pb3.ImageLocation = ("Czech-Republic.png");
            }
            else if (lbl3.Text == "İsviçre")
            {
                pb3.ImageLocation = ("Switzerland.png");
            }
            else if (lbl3.Text == "İtalya")
            {
                pb3.ImageLocation = ("Italy.png");
            }
            else if (lbl3.Text == "Avusturya")
            {
                pb3.ImageLocation = ("Austria.png");
            }
            else if (lbl3.Text == "Slovakya")
            {
                pb3.ImageLocation = ("Slovakia.png");
            }
            else if (lbl3.Text == "Hırvatistan")
            {
                pb3.ImageLocation = ("Crotia.png");
            }
            else if (lbl3.Text == "İspanya")
            {
                pb3.ImageLocation = ("Spain.png");
            }
            else if (lbl3.Text == "Galler")
            {
                pb3.ImageLocation = ("Wales.png");
            }
            else if (lbl3.Text == "İngiltere")
            {
                pb3.ImageLocation = ("England.png");
            }
            else if (lbl3.Text == "Portekiz")
            {
                pb3.ImageLocation = ("Portugal.png");
            }
            else if (lbl3.Text == "Litvanya")
            {
                pb3.ImageLocation = ("Lithuania.png");
            }
            else if (lbl3.Text == "Hollanda")
            {
                pb3.ImageLocation = ("Holland.png");
            }
            else if (lbl3.Text == "Belçika")
            {
                pb3.ImageLocation = ("Belgium.png");
            }
            else if (lbl3.Text == "Almanya")
            {
                pb3.ImageLocation = ("Germany.png");
            }
            else if (lbl3.Text == "Türkiye")
            {
                pb3.ImageLocation = ("Turkey.png");
            }
            /////////////
            if (lbl4.Text == "İsrail")
            {
                pb4.ImageLocation = ("Israel.png");
            }
            else if (lbl4.Text == "İsveç")
            {
                pb4.ImageLocation = ("Sweden.png");
            }
            else if (lbl4.Text == "Macaristan")
            {
                pb4.ImageLocation = ("Hungary.png");
            }
            else if (lbl4.Text == "Romanya")
            {
                pb4.ImageLocation = ("Romania.png");
            }
            else if (lbl4.Text == "Sırbistan")
            {
                pb4.ImageLocation = ("Serbia.png");
            }
            else if (lbl4.Text == "Brezilya")
            {
                pb4.ImageLocation = ("Brazil.png");
            }
            else if (lbl4.Text == "Estonya")
            {
                pb4.ImageLocation = ("Estonia.png");
            }
            else if (lbl4.Text == "Slovenya")
            {
                pb4.ImageLocation = ("Slovenia.png");
            }
            else if (lbl4.Text == "Norveç")
            {
                pb4.ImageLocation = ("Norway.png");
            }
            else if (lbl4.Text == "Azerbaycan")
            {
                pb4.ImageLocation = ("Azerbaijan.png");
            }
            else if (lbl4.Text == "Kazakistan")
            {
                pb4.ImageLocation = ("Kazakhstan.png");
            }
            else if (lbl4.Text == "Polonya")
            {
                pb4.ImageLocation = ("Poland.png");
            }
            else if (lbl4.Text == "Ukrayna")
            {
                pb4.ImageLocation = ("Ukraine.png");
            }
            else if (lbl4.Text == "Bosna Hersek")
            {
                pb4.ImageLocation = ("Bosnia-and-Herzegovina.png");
            }
            else if (lbl4.Text == "Danimarka")
            {
                pb4.ImageLocation = ("Denmark.png");
            }
            else if (lbl4.Text == "İzlanda")
            {
                pb4.ImageLocation = ("Ireland.png");
            }
            else if (lbl4.Text == "Fransa")
            {
                pb4.ImageLocation = ("France.png");
            }
            else if (lbl4.Text == "Çek Cumhuriyeti")
            {
                pb4.ImageLocation = ("Czech-Republic.png");
            }
            else if (lbl4.Text == "İsviçre")
            {
                pb4.ImageLocation = ("Switzerland.png");
            }
            else if (lbl4.Text == "İtalya")
            {
                pb4.ImageLocation = ("Italy.png");
            }
            else if (lbl4.Text == "Avusturya")
            {
                pb4.ImageLocation = ("Austria.png");
            }
            else if (lbl4.Text == "Slovakya")
            {
                pb4.ImageLocation = ("Slovakia.png");
            }
            else if (lbl4.Text == "Hırvatistan")
            {
                pb4.ImageLocation = ("Crotia.png");
            }
            else if (lbl4.Text == "İspanya")
            {
                pb4.ImageLocation = ("Spain.png");
            }
            else if (lbl4.Text == "Galler")
            {
                pb4.ImageLocation = ("Wales.png");
            }
            else if (lbl4.Text == "İngiltere")
            {
                pb4.ImageLocation = ("England.png");
            }
            else if (lbl4.Text == "Portekiz")
            {
                pb4.ImageLocation = ("Portugal.png");
            }
            else if (lbl4.Text == "Litvanya")
            {
                pb4.ImageLocation = ("Lithuania.png");
            }
            else if (lbl4.Text == "Hollanda")
            {
                pb4.ImageLocation = ("Holland.png");
            }
            else if (lbl4.Text == "Belçika")
            {
                pb4.ImageLocation = ("Belgium.png");
            }
            else if (lbl4.Text == "Almanya")
            {
                pb4.ImageLocation = ("Germany.png");
            }
            else if (lbl4.Text == "Türkiye")
            {
                pb4.ImageLocation = ("Turkey.png");
            }
            ////
            if (lbl5.Text == "İsrail")
            {
                pb5.ImageLocation = ("Israel.png");
            }
            else if (lbl5.Text == "İsveç")
            {
                pb5.ImageLocation = ("Sweden.png");
            }
            else if (lbl5.Text == "Macaristan")
            {
                pb5.ImageLocation = ("Hungary.png");
            }
            else if (lbl5.Text == "Romanya")
            {
                pb5.ImageLocation = ("Romania.png");
            }
            else if (lbl5.Text == "Sırbistan")
            {
                pb5.ImageLocation = ("Serbia.png");
            }
            else if (lbl5.Text == "Brezilya")
            {
                pb5.ImageLocation = ("Brazil.png");
            }
            else if (lbl5.Text == "Estonya")
            {
                pb5.ImageLocation = ("Estonia.png");
            }
            else if (lbl5.Text == "Slovenya")
            {
                pb5.ImageLocation = ("Slovenia.png");
            }
            else if (lbl5.Text == "Norveç")
            {
                pb5.ImageLocation = ("Norway.png");
            }
            else if (lbl5.Text == "Azerbaycan")
            {
                pb5.ImageLocation = ("Azerbaijan.png");
            }
            else if (lbl5.Text == "Kazakistan")
            {
                pb5.ImageLocation = ("Kazakhstan.png");
            }
            else if (lbl5.Text == "Polonya")
            {
                pb5.ImageLocation = ("Poland.png");
            }
            else if (lbl5.Text == "Ukrayna")
            {
                pb5.ImageLocation = ("Ukraine.png");
            }
            else if (lbl5.Text == "Bosna Hersek")
            {
                pb5.ImageLocation = ("Bosnia-and-Herzegovina.png");
            }
            else if (lbl5.Text == "Danimarka")
            {
                pb5.ImageLocation = ("Denmark.png");
            }
            else if (lbl5.Text == "İzlanda")
            {
                pb5.ImageLocation = ("Ireland.png");
            }
            else if (lbl5.Text == "Fransa")
            {
                pb5.ImageLocation = ("France.png");
            }
            else if (lbl5.Text == "Çek Cumhuriyeti")
            {
                pb5.ImageLocation = ("Czech-Republic.png");
            }
            else if (lbl5.Text == "İsviçre")
            {
                pb5.ImageLocation = ("Switzerland.png");
            }
            else if (lbl5.Text == "İtalya")
            {
                pb5.ImageLocation = ("Italy.png");
            }
            else if (lbl5.Text == "Avusturya")
            {
                pb5.ImageLocation = ("Austria.png");
            }
            else if (lbl5.Text == "Slovakya")
            {
                pb5.ImageLocation = ("Slovakia.png");
            }
            else if (lbl5.Text == "Hırvatistan")
            {
                pb5.ImageLocation = ("Crotia.png");
            }
            else if (lbl5.Text == "İspanya")
            {
                pb5.ImageLocation = ("Spain.png");
            }
            else if (lbl5.Text == "Galler")
            {
                pb5.ImageLocation = ("Wales.png");
            }
            else if (lbl5.Text == "İngiltere")
            {
                pb5.ImageLocation = ("England.png");
            }
            else if (lbl5.Text == "Portekiz")
            {
                pb5.ImageLocation = ("Portugal.png");
            }
            else if (lbl5.Text == "Litvanya")
            {
                pb5.ImageLocation = ("Lithuania.png");
            }
            else if (lbl5.Text == "Hollanda")
            {
                pb5.ImageLocation = ("Holland.png");
            }
            else if (lbl5.Text == "Belçika")
            {
                pb5.ImageLocation = ("Belgium.png");
            }
            else if (lbl5.Text == "Almanya")
            {
                pb5.ImageLocation = ("Germany.png");
            }
            else if (lbl5.Text == "Türkiye")
            {
                pb5.ImageLocation = ("Turkey.png");
            }
            //////
            if (lbl6.Text == "İsrail")
            {
                pb6.ImageLocation = ("Israel.png");
            }
            else if (lbl6.Text == "İsveç")
            {
                pb6.ImageLocation = ("Sweden.png");
            }
            else if (lbl6.Text == "Macaristan")
            {
                pb6.ImageLocation = ("Hungary.png");
            }
            else if (lbl6.Text == "Romanya")
            {
                pb6.ImageLocation = ("Romania.png");
            }
            else if (lbl6.Text == "Sırbistan")
            {
                pb6.ImageLocation = ("Serbia.png");
            }
            else if (lbl6.Text == "Brezilya")
            {
                pb6.ImageLocation = ("Brazil.png");
            }
            else if (lbl6.Text == "Estonya")
            {
                pb6.ImageLocation = ("Estonia.png");
            }
            else if (lbl6.Text == "Slovenya")
            {
                pb6.ImageLocation = ("Slovenia.png");
            }
            else if (lbl6.Text == "Norveç")
            {
                pb6.ImageLocation = ("Norway.png");
            }
            else if (lbl6.Text == "Azerbaycan")
            {
                pb6.ImageLocation = ("Azerbaijan.png");
            }
            else if (lbl6.Text == "Kazakistan")
            {
                pb6.ImageLocation = ("Kazakhstan.png");
            }
            else if (lbl6.Text == "Polonya")
            {
                pb6.ImageLocation = ("Poland.png");
            }
            else if (lbl6.Text == "Ukrayna")
            {
                pb6.ImageLocation = ("Ukraine.png");
            }
            else if (lbl6.Text == "Bosna Hersek")
            {
                pb6.ImageLocation = ("Bosnia-and-Herzegovina.png");
            }
            else if (lbl6.Text == "Danimarka")
            {
                pb6.ImageLocation = ("Denmark.png");
            }
            else if (lbl6.Text == "İzlanda")
            {
                pb6.ImageLocation = ("Ireland.png");
            }
            else if (lbl6.Text == "Fransa")
            {
                pb6.ImageLocation = ("France.png");
            }
            else if (lbl6.Text == "Çek Cumhuriyeti")
            {
                pb6.ImageLocation = ("Czech-Republic.png");
            }
            else if (lbl6.Text == "İsviçre")
            {
                pb6.ImageLocation = ("Switzerland.png");
            }
            else if (lbl6.Text == "İtalya")
            {
                pb6.ImageLocation = ("Italy.png");
            }
            else if (lbl6.Text == "Avusturya")
            {
                pb6.ImageLocation = ("Austria.png");
            }
            else if (lbl6.Text == "Slovakya")
            {
                pb6.ImageLocation = ("Slovakia.png");
            }
            else if (lbl6.Text == "Hırvatistan")
            {
                pb6.ImageLocation = ("Crotia.png");
            }
            else if (lbl6.Text == "İspanya")
            {
                pb6.ImageLocation = ("Spain.png");
            }
            else if (lbl6.Text == "Galler")
            {
                pb6.ImageLocation = ("Wales.png");
            }
            else if (lbl6.Text == "İngiltere")
            {
                pb6.ImageLocation = ("England.png");
            }
            else if (lbl6.Text == "Portekiz")
            {
                pb6.ImageLocation = ("Portugal.png");
            }
            else if (lbl6.Text == "Litvanya")
            {
                pb6.ImageLocation = ("Lithuania.png");
            }
            else if (lbl6.Text == "Hollanda")
            {
                pb6.ImageLocation = ("Holland.png");
            }
            else if (lbl6.Text == "Belçika")
            {
                pb6.ImageLocation = ("Belgium.png");
            }
            else if (lbl6.Text == "Almanya")
            {
                pb6.ImageLocation = ("Germany.png");
            }
            else if (lbl6.Text == "Türkiye")
            {
                pb6.ImageLocation = ("Turkey.png");
            }
            //
            if (lbl7.Text == "İsrail")
            {
                pb7.ImageLocation = ("Israel.png");
            }
            else if (lbl7.Text == "İsveç")
            {
                pb7.ImageLocation = ("Sweden.png");
            }
            else if (lbl7.Text == "Macaristan")
            {
                pb7.ImageLocation = ("Hungary.png");
            }
            else if (lbl7.Text == "Romanya")
            {
                pb7.ImageLocation = ("Romania.png");
            }
            else if (lbl7.Text == "Sırbistan")
            {
                pb7.ImageLocation = ("Serbia.png");
            }
            else if (lbl7.Text == "Brezilya")
            {
                pb7.ImageLocation = ("Brazil.png");
            }
            else if (lbl7.Text == "Estonya")
            {
                pb7.ImageLocation = ("Estonia.png");
            }
            else if (lbl7.Text == "Slovenya")
            {
                pb7.ImageLocation = ("Slovenia.png");
            }
            else if (lbl7.Text == "Norveç")
            {
                pb7.ImageLocation = ("Norway.png");
            }
            else if (lbl7.Text == "Azerbaycan")
            {
                pb7.ImageLocation = ("Azerbaijan.png");
            }
            else if (lbl7.Text == "Kazakistan")
            {
                pb7.ImageLocation = ("Kazakhstan.png");
            }
            else if (lbl7.Text == "Polonya")
            {
                pb7.ImageLocation = ("Poland.png");
            }
            else if (lbl7.Text == "Ukrayna")
            {
                pb7.ImageLocation = ("Ukraine.png");
            }
            else if (lbl7.Text == "Bosna Hersek")
            {
                pb7.ImageLocation = ("Bosnia-and-Herzegovina.png");
            }
            else if (lbl7.Text == "Danimarka")
            {
                pb7.ImageLocation = ("Denmark.png");
            }
            else if (lbl7.Text == "İzlanda")
            {
                pb7.ImageLocation = ("Ireland.png");
            }
            else if (lbl7.Text == "Fransa")
            {
                pb7.ImageLocation = ("France.png");
            }
            else if (lbl7.Text == "Çek Cumhuriyeti")
            {
                pb7.ImageLocation = ("Czech-Republic.png");
            }
            else if (lbl7.Text == "İsviçre")
            {
                pb7.ImageLocation = ("Switzerland.png");
            }
            else if (lbl7.Text == "İtalya")
            {
                pb7.ImageLocation = ("Italy.png");
            }
            else if (lbl7.Text == "Avusturya")
            {
                pb7.ImageLocation = ("Austria.png");
            }
            else if (lbl7.Text == "Slovakya")
            {
                pb7.ImageLocation = ("Slovakia.png");
            }
            else if (lbl7.Text == "Hırvatistan")
            {
                pb7.ImageLocation = ("Crotia.png");
            }
            else if (lbl7.Text == "İspanya")
            {
                pb7.ImageLocation = ("Spain.png");
            }
            else if (lbl7.Text == "Galler")
            {
                pb7.ImageLocation = ("Wales.png");
            }
            else if (lbl7.Text == "İngiltere")
            {
                pb7.ImageLocation = ("England.png");
            }
            else if (lbl7.Text == "Portekiz")
            {
                pb7.ImageLocation = ("Portugal.png");
            }
            else if (lbl7.Text == "Litvanya")
            {
                pb7.ImageLocation = ("Lithuania.png");
            }
            else if (lbl7.Text == "Hollanda")
            {
                pb7.ImageLocation = ("Holland.png");
            }
            else if (lbl7.Text == "Belçika")
            {
                pb7.ImageLocation = ("Belgium.png");
            }
            else if (lbl7.Text == "Almanya")
            {
                pb7.ImageLocation = ("Germany.png");
            }
            else if (lbl7.Text == "Türkiye")
            {
                pb7.ImageLocation = ("Turkey.png");
            }
            /////
            if (lbl8.Text == "İsrail")
            {
                pb8.ImageLocation = ("Israel.png");
            }
            else if (lbl8.Text == "İsveç")
            {
                pb8.ImageLocation = ("Sweden.png");
            }
            else if (lbl8.Text == "Macaristan")
            {
                pb8.ImageLocation = ("Hungary.png");
            }
            else if (lbl8.Text == "Romanya")
            {
                pb8.ImageLocation = ("Romania.png");
            }
            else if (lbl8.Text == "Sırbistan")
            {
                pb8.ImageLocation = ("Serbia.png");
            }
            else if (lbl8.Text == "Brezilya")
            {
                pb8.ImageLocation = ("Brazil.png");
            }
            else if (lbl8.Text == "Estonya")
            {
                pb8.ImageLocation = ("Estonia.png");
            }
            else if (lbl8.Text == "Slovenya")
            {
                pb8.ImageLocation = ("Slovenia.png");
            }
            else if (lbl8.Text == "Norveç")
            {
                pb8.ImageLocation = ("Norway.png");
            }
            else if (lbl8.Text == "Azerbaycan")
            {
                pb8.ImageLocation = ("Azerbaijan.png");
            }
            else if (lbl8.Text == "Kazakistan")
            {
                pb8.ImageLocation = ("Kazakhstan.png");
            }
            else if (lbl8.Text == "Polonya")
            {
                pb8.ImageLocation = ("Poland.png");
            }
            else if (lbl8.Text == "Ukrayna")
            {
                pb8.ImageLocation = ("Ukraine.png");
            }
            else if (lbl8.Text == "Bosna Hersek")
            {
                pb8.ImageLocation = ("Bosnia-and-Herzegovina.png");
            }
            else if (lbl8.Text == "Danimarka")
            {
                pb8.ImageLocation = ("Denmark.png");
            }
            else if (lbl8.Text == "İzlanda")
            {
                pb8.ImageLocation = ("Ireland.png");
            }
            else if (lbl8.Text == "Fransa")
            {
                pb8.ImageLocation = ("France.png");
            }
            else if (lbl8.Text == "Çek Cumhuriyeti")
            {
                pb8.ImageLocation = ("Czech-Republic.png");
            }
            else if (lbl8.Text == "İsviçre")
            {
                pb8.ImageLocation = ("Switzerland.png");
            }
            else if (lbl8.Text == "İtalya")
            {
                pb8.ImageLocation = ("Italy.png");
            }
            else if (lbl8.Text == "Avusturya")
            {
                pb8.ImageLocation = ("Austria.png");
            }
            else if (lbl8.Text == "Slovakya")
            {
                pb8.ImageLocation = ("Slovakia.png");
            }
            else if (lbl8.Text == "Hırvatistan")
            {
                pb8.ImageLocation = ("Crotia.png");
            }
            else if (lbl8.Text == "İspanya")
            {
                pb8.ImageLocation = ("Spain.png");
            }
            else if (lbl8.Text == "Galler")
            {
                pb8.ImageLocation = ("Wales.png");
            }
            else if (lbl8.Text == "İngiltere")
            {
                pb8.ImageLocation = ("England.png");
            }
            else if (lbl8.Text == "Portekiz")
            {
                pb8.ImageLocation = ("Portugal.png");
            }
            else if (lbl8.Text == "Litvanya")
            {
                pb8.ImageLocation = ("Lithuania.png");
            }
            else if (lbl8.Text == "Hollanda")
            {
                pb8.ImageLocation = ("Holland.png");
            }
            else if (lbl8.Text == "Belçika")
            {
                pb8.ImageLocation = ("Belgium.png");
            }
            else if (lbl8.Text == "Almanya")
            {
                pb8.ImageLocation = ("Germany.png");
            }
            else if (lbl8.Text == "Türkiye")
            {
                pb8.ImageLocation = ("Turkey.png");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            Form4 form4 = new Form4();
            form5.lbl1.Text = listBox1.Items[0].ToString();
            form5.lbl2.Text = listBox1.Items[1].ToString();
            form5.lbl3.Text = listBox1.Items[2].ToString();
            form5.lbl4.Text = listBox1.Items[3].ToString();
            form5.Show();
            this.Close();
        }
    }
}
