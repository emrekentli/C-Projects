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
    public partial class Form3 : Form
    {
        public static int sayac = 0;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
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
            if (sayac == 8)
            {
                button17.Visible = Enabled;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
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
            //
            if (lbl9.Text == "İsrail")
            {
                pb9.ImageLocation = ("Israel.png");
            }
            else if (lbl9.Text == "İsveç")
            {
                pb9.ImageLocation = ("Sweden.png");
            }
            else if (lbl9.Text == "Macaristan")
            {
                pb9.ImageLocation = ("Hungary.png");
            }
            else if (lbl9.Text == "Romanya")
            {
                pb9.ImageLocation = ("Romania.png");
            }
            else if (lbl9.Text == "Sırbistan")
            {
                pb9.ImageLocation = ("Serbia.png");
            }
            else if (lbl9.Text == "Brezilya")
            {
                pb9.ImageLocation = ("Brazil.png");
            }
            else if (lbl9.Text == "Estonya")
            {
                pb9.ImageLocation = ("Estonia.png");
            }
            else if (lbl9.Text == "Slovenya")
            {
                pb9.ImageLocation = ("Slovenia.png");
            }
            else if (lbl9.Text == "Norveç")
            {
                pb9.ImageLocation = ("Norway.png");
            }
            else if (lbl9.Text == "Azerbaycan")
            {
                pb9.ImageLocation = ("Azerbaijan.png");
            }
            else if (lbl9.Text == "Kazakistan")
            {
                pb9.ImageLocation = ("Kazakhstan.png");
            }
            else if (lbl9.Text == "Polonya")
            {
                pb9.ImageLocation = ("Poland.png");
            }
            else if (lbl9.Text == "Ukrayna")
            {
                pb9.ImageLocation = ("Ukraine.png");
            }
            else if (lbl9.Text == "Bosna Hersek")
            {
                pb9.ImageLocation = ("Bosnia-and-Herzegovina.png");
            }
            else if (lbl9.Text == "Danimarka")
            {
                pb9.ImageLocation = ("Denmark.png");
            }
            else if (lbl9.Text == "İzlanda")
            {
                pb9.ImageLocation = ("Ireland.png");
            }
            else if (lbl9.Text == "Fransa")
            {
                pb9.ImageLocation = ("France.png");
            }
            else if (lbl9.Text == "Çek Cumhuriyeti")
            {
                pb9.ImageLocation = ("Czech-Republic.png");
            }
            else if (lbl9.Text == "İsviçre")
            {
                pb9.ImageLocation = ("Switzerland.png");
            }
            else if (lbl9.Text == "İtalya")
            {
                pb9.ImageLocation = ("Italy.png");
            }
            else if (lbl9.Text == "Avusturya")
            {
                pb9.ImageLocation = ("Austria.png");
            }
            else if (lbl9.Text == "Slovakya")
            {
                pb9.ImageLocation = ("Slovakia.png");
            }
            else if (lbl9.Text == "Hırvatistan")
            {
                pb9.ImageLocation = ("Crotia.png");
            }
            else if (lbl9.Text == "İspanya")
            {
                pb9.ImageLocation = ("Spain.png");
            }
            else if (lbl9.Text == "Galler")
            {
                pb9.ImageLocation = ("Wales.png");
            }
            else if (lbl9.Text == "İngiltere")
            {
                pb9.ImageLocation = ("England.png");
            }
            else if (lbl9.Text == "Portekiz")
            {
                pb9.ImageLocation = ("Portugal.png");
            }
            else if (lbl9.Text == "Litvanya")
            {
                pb9.ImageLocation = ("Lithuania.png");
            }
            else if (lbl9.Text == "Hollanda")
            {
                pb9.ImageLocation = ("Holland.png");
            }
            else if (lbl9.Text == "Belçika")
            {
                pb9.ImageLocation = ("Belgium.png");
            }
            else if (lbl9.Text == "Almanya")
            {
                pb9.ImageLocation = ("Germany.png");
            }
            else if (lbl9.Text == "Türkiye")
            {
                pb9.ImageLocation = ("Turkey.png");
            }
            ////
            if (lbl10.Text == "İsrail")
            {
                pb10.ImageLocation = ("Israel.png");
            }
            else if (lbl10.Text == "İsveç")
            {
                pb10.ImageLocation = ("Sweden.png");
            }
            else if (lbl10.Text == "Macaristan")
            {
                pb10.ImageLocation = ("Hungary.png");
            }
            else if (lbl10.Text == "Romanya")
            {
                pb10.ImageLocation = ("Romania.png");
            }
            else if (lbl10.Text == "Sırbistan")
            {
                pb10.ImageLocation = ("Serbia.png");
            }
            else if (lbl10.Text == "Brezilya")
            {
                pb10.ImageLocation = ("Brazil.png");
            }
            else if (lbl10.Text == "Estonya")
            {
                pb10.ImageLocation = ("Estonia.png");
            }
            else if (lbl10.Text == "Slovenya")
            {
                pb10.ImageLocation = ("Slovenia.png");
            }
            else if (lbl10.Text == "Norveç")
            {
                pb10.ImageLocation = ("Norway.png");
            }
            else if (lbl10.Text == "Azerbaycan")
            {
                pb10.ImageLocation = ("Azerbaijan.png");
            }
            else if (lbl10.Text == "Kazakistan")
            {
                pb10.ImageLocation = ("Kazakhstan.png");
            }
            else if (lbl10.Text == "Polonya")
            {
                pb10.ImageLocation = ("Poland.png");
            }
            else if (lbl10.Text == "Ukrayna")
            {
                pb10.ImageLocation = ("Ukraine.png");
            }
            else if (lbl10.Text == "Bosna Hersek")
            {
                pb10.ImageLocation = ("Bosnia-and-Herzegovina.png");
            }
            else if (lbl10.Text == "Danimarka")
            {
                pb10.ImageLocation = ("Denmark.png");
            }
            else if (lbl10.Text == "İzlanda")
            {
                pb10.ImageLocation = ("Ireland.png");
            }
            else if (lbl10.Text == "Fransa")
            {
                pb10.ImageLocation = ("France.png");
            }
            else if (lbl10.Text == "Çek Cumhuriyeti")
            {
                pb10.ImageLocation = ("Czech-Republic.png");
            }
            else if (lbl10.Text == "İsviçre")
            {
                pb10.ImageLocation = ("Switzerland.png");
            }
            else if (lbl10.Text == "İtalya")
            {
                pb10.ImageLocation = ("Italy.png");
            }
            else if (lbl10.Text == "Avusturya")
            {
                pb10.ImageLocation = ("Austria.png");
            }
            else if (lbl10.Text == "Slovakya")
            {
                pb10.ImageLocation = ("Slovakia.png");
            }
            else if (lbl10.Text == "Hırvatistan")
            {
                pb10.ImageLocation = ("Crotia.png");
            }
            else if (lbl10.Text == "İspanya")
            {
                pb10.ImageLocation = ("Spain.png");
            }
            else if (lbl10.Text == "Galler")
            {
                pb10.ImageLocation = ("Wales.png");
            }
            else if (lbl10.Text == "İngiltere")
            {
                pb10.ImageLocation = ("England.png");
            }
            else if (lbl10.Text == "Portekiz")
            {
                pb10.ImageLocation = ("Portugal.png");
            }
            else if (lbl10.Text == "Litvanya")
            {
                pb10.ImageLocation = ("Lithuania.png");
            }
            else if (lbl10.Text == "Hollanda")
            {
                pb10.ImageLocation = ("Holland.png");
            }
            else if (lbl10.Text == "Belçika")
            {
                pb10.ImageLocation = ("Belgium.png");
            }
            else if (lbl10.Text == "Almanya")
            {
                pb10.ImageLocation = ("Germany.png");
            }
            else if (lbl10.Text == "Türkiye")
            {
                pb10.ImageLocation = ("Turkey.png");
            }
            ////////////
            if (lbl11.Text == "İsrail")
            {
                pb11.ImageLocation = ("Israel.png");
            }
            else if (lbl11.Text == "İsveç")
            {
                pb11.ImageLocation = ("Sweden.png");
            }
            else if (lbl11.Text == "Macaristan")
            {
                pb11.ImageLocation = ("Hungary.png");
            }
            else if (lbl11.Text == "Romanya")
            {
                pb11.ImageLocation = ("Romania.png");
            }
            else if (lbl11.Text == "Sırbistan")
            {
                pb11.ImageLocation = ("Serbia.png");
            }
            else if (lbl11.Text == "Brezilya")
            {
                pb11.ImageLocation = ("Brazil.png");
            }
            else if (lbl11.Text == "Estonya")
            {
                pb11.ImageLocation = ("Estonia.png");
            }
            else if (lbl11.Text == "Slovenya")
            {
                pb11.ImageLocation = ("Slovenia.png");
            }
            else if (lbl11.Text == "Norveç")
            {
                pb11.ImageLocation = ("Norway.png");
            }
            else if (lbl11.Text == "Azerbaycan")
            {
                pb11.ImageLocation = ("Azerbaijan.png");
            }
            else if (lbl11.Text == "Kazakistan")
            {
                pb11.ImageLocation = ("Kazakhstan.png");
            }
            else if (lbl11.Text == "Polonya")
            {
                pb11.ImageLocation = ("Poland.png");
            }
            else if (lbl11.Text == "Ukrayna")
            {
                pb11.ImageLocation = ("Ukraine.png");
            }
            else if (lbl11.Text == "Bosna Hersek")
            {
                pb11.ImageLocation = ("Bosnia-and-Herzegovina.png");
            }
            else if (lbl11.Text == "Danimarka")
            {
                pb11.ImageLocation = ("Denmark.png");
            }
            else if (lbl11.Text == "İzlanda")
            {
                pb11.ImageLocation = ("Ireland.png");
            }
            else if (lbl11.Text == "Fransa")
            {
                pb11.ImageLocation = ("France.png");
            }
            else if (lbl11.Text == "Çek Cumhuriyeti")
            {
                pb11.ImageLocation = ("Czech-Republic.png");
            }
            else if (lbl11.Text == "İsviçre")
            {
                pb11.ImageLocation = ("Switzerland.png");
            }
            else if (lbl11.Text == "İtalya")
            {
                pb11.ImageLocation = ("Italy.png");
            }
            else if (lbl11.Text == "Avusturya")
            {
                pb11.ImageLocation = ("Austria.png");
            }
            else if (lbl11.Text == "Slovakya")
            {
                pb11.ImageLocation = ("Slovakia.png");
            }
            else if (lbl11.Text == "Hırvatistan")
            {
                pb11.ImageLocation = ("Crotia.png");
            }
            else if (lbl11.Text == "İspanya")
            {
                pb11.ImageLocation = ("Spain.png");
            }
            else if (lbl11.Text == "Galler")
            {
                pb11.ImageLocation = ("Wales.png");
            }
            else if (lbl11.Text == "İngiltere")
            {
                pb11.ImageLocation = ("England.png");
            }
            else if (lbl11.Text == "Portekiz")
            {
                pb11.ImageLocation = ("Portugal.png");
            }
            else if (lbl11.Text == "Litvanya")
            {
                pb11.ImageLocation = ("Lithuania.png");
            }
            else if (lbl11.Text == "Hollanda")
            {
                pb11.ImageLocation = ("Holland.png");
            }
            else if (lbl11.Text == "Belçika")
            {
                pb11.ImageLocation = ("Belgium.png");
            }
            else if (lbl11.Text == "Almanya")
            {
                pb11.ImageLocation = ("Germany.png");
            }
            else if (lbl11.Text == "Türkiye")
            {
                pb11.ImageLocation = ("Turkey.png");
            }
            //////////
            if (lbl12.Text == "İsrail")
            {
                pb12.ImageLocation = ("Israel.png");
            }
            else if (lbl12.Text == "İsveç")
            {
                pb12.ImageLocation = ("Sweden.png");
            }
            else if (lbl12.Text == "Macaristan")
            {
                pb12.ImageLocation = ("Hungary.png");
            }
            else if (lbl12.Text == "Romanya")
            {
                pb12.ImageLocation = ("Romania.png");
            }
            else if (lbl12.Text == "Sırbistan")
            {
                pb12.ImageLocation = ("Serbia.png");
            }
            else if (lbl12.Text == "Brezilya")
            {
                pb12.ImageLocation = ("Brazil.png");
            }
            else if (lbl12.Text == "Estonya")
            {
                pb12.ImageLocation = ("Estonia.png");
            }
            else if (lbl12.Text == "Slovenya")
            {
                pb12.ImageLocation = ("Slovenia.png");
            }
            else if (lbl12.Text == "Norveç")
            {
                pb12.ImageLocation = ("Norway.png");
            }
            else if (lbl12.Text == "Azerbaycan")
            {
                pb12.ImageLocation = ("Azerbaijan.png");
            }
            else if (lbl12.Text == "Kazakistan")
            {
                pb12.ImageLocation = ("Kazakhstan.png");
            }
            else if (lbl12.Text == "Polonya")
            {
                pb12.ImageLocation = ("Poland.png");
            }
            else if (lbl12.Text == "Ukrayna")
            {
                pb12.ImageLocation = ("Ukraine.png");
            }
            else if (lbl12.Text == "Bosna Hersek")
            {
                pb12.ImageLocation = ("Bosnia-and-Herzegovina.png");
            }
            else if (lbl12.Text == "Danimarka")
            {
                pb12.ImageLocation = ("Denmark.png");
            }
            else if (lbl12.Text == "İzlanda")
            {
                pb12.ImageLocation = ("Ireland.png");
            }
            else if (lbl12.Text == "Fransa")
            {
                pb12.ImageLocation = ("France.png");
            }
            else if (lbl12.Text == "Çek Cumhuriyeti")
            {
                pb12.ImageLocation = ("Czech-Republic.png");
            }
            else if (lbl12.Text == "İsviçre")
            {
                pb12.ImageLocation = ("Switzerland.png");
            }
            else if (lbl12.Text == "İtalya")
            {
                pb12.ImageLocation = ("Italy.png");
            }
            else if (lbl12.Text == "Avusturya")
            {
                pb12.ImageLocation = ("Austria.png");
            }
            else if (lbl12.Text == "Slovakya")
            {
                pb12.ImageLocation = ("Slovakia.png");
            }
            else if (lbl12.Text == "Hırvatistan")
            {
                pb12.ImageLocation = ("Crotia.png");
            }
            else if (lbl12.Text == "İspanya")
            {
                pb12.ImageLocation = ("Spain.png");
            }
            else if (lbl12.Text == "Galler")
            {
                pb12.ImageLocation = ("Wales.png");
            }
            else if (lbl12.Text == "İngiltere")
            {
                pb12.ImageLocation = ("England.png");
            }
            else if (lbl12.Text == "Portekiz")
            {
                pb12.ImageLocation = ("Portugal.png");
            }
            else if (lbl12.Text == "Litvanya")
            {
                pb12.ImageLocation = ("Lithuania.png");
            }
            else if (lbl12.Text == "Hollanda")
            {
                pb12.ImageLocation = ("Holland.png");
            }
            else if (lbl12.Text == "Belçika")
            {
                pb12.ImageLocation = ("Belgium.png");
            }
            else if (lbl12.Text == "Almanya")
            {
                pb12.ImageLocation = ("Germany.png");
            }
            else if (lbl12.Text == "Türkiye")
            {
                pb12.ImageLocation = ("Turkey.png");
            }
            /////////////////////
            if (lbl13.Text == "İsrail")
            {
                pb13.ImageLocation = ("Israel.png");
            }
            else if (lbl13.Text == "İsveç")
            {
                pb13.ImageLocation = ("Sweden.png");
            }
            else if (lbl13.Text == "Macaristan")
            {
                pb13.ImageLocation = ("Hungary.png");
            }
            else if (lbl13.Text == "Romanya")
            {
                pb13.ImageLocation = ("Romania.png");
            }
            else if (lbl13.Text == "Sırbistan")
            {
                pb13.ImageLocation = ("Serbia.png");
            }
            else if (lbl13.Text == "Brezilya")
            {
                pb13.ImageLocation = ("Brazil.png");
            }
            else if (lbl13.Text == "Estonya")
            {
                pb13.ImageLocation = ("Estonia.png");
            }
            else if (lbl13.Text == "Slovenya")
            {
                pb13.ImageLocation = ("Slovenia.png");
            }
            else if (lbl13.Text == "Norveç")
            {
                pb13.ImageLocation = ("Norway.png");
            }
            else if (lbl13.Text == "Azerbaycan")
            {
                pb13.ImageLocation = ("Azerbaijan.png");
            }
            else if (lbl13.Text == "Kazakistan")
            {
                pb13.ImageLocation = ("Kazakhstan.png");
            }
            else if (lbl13.Text == "Polonya")
            {
                pb13.ImageLocation = ("Poland.png");
            }
            else if (lbl13.Text == "Ukrayna")
            {
                pb13.ImageLocation = ("Ukraine.png");
            }
            else if (lbl13.Text == "Bosna Hersek")
            {
                pb13.ImageLocation = ("Bosnia-and-Herzegovina.png");
            }
            else if (lbl13.Text == "Danimarka")
            {
                pb13.ImageLocation = ("Denmark.png");
            }
            else if (lbl13.Text == "İzlanda")
            {
                pb13.ImageLocation = ("Ireland.png");
            }
            else if (lbl13.Text == "Fransa")
            {
                pb13.ImageLocation = ("France.png");
            }
            else if (lbl13.Text == "Çek Cumhuriyeti")
            {
                pb13.ImageLocation = ("Czech-Republic.png");
            }
            else if (lbl13.Text == "İsviçre")
            {
                pb13.ImageLocation = ("Switzerland.png");
            }
            else if (lbl13.Text == "İtalya")
            {
                pb13.ImageLocation = ("Italy.png");
            }
            else if (lbl13.Text == "Avusturya")
            {
                pb13.ImageLocation = ("Austria.png");
            }
            else if (lbl13.Text == "Slovakya")
            {
                pb13.ImageLocation = ("Slovakia.png");
            }
            else if (lbl13.Text == "Hırvatistan")
            {
                pb13.ImageLocation = ("Crotia.png");
            }
            else if (lbl13.Text == "İspanya")
            {
                pb13.ImageLocation = ("Spain.png");
            }
            else if (lbl13.Text == "Galler")
            {
                pb13.ImageLocation = ("Wales.png");
            }
            else if (lbl13.Text == "İngiltere")
            {
                pb13.ImageLocation = ("England.png");
            }
            else if (lbl13.Text == "Portekiz")
            {
                pb13.ImageLocation = ("Portugal.png");
            }
            else if (lbl13.Text == "Litvanya")
            {
                pb13.ImageLocation = ("Lithuania.png");
            }
            else if (lbl13.Text == "Hollanda")
            {
                pb13.ImageLocation = ("Holland.png");
            }
            else if (lbl13.Text == "Belçika")
            {
                pb13.ImageLocation = ("Belgium.png");
            }
            else if (lbl13.Text == "Almanya")
            {
                pb13.ImageLocation = ("Germany.png");
            }
            else if (lbl13.Text == "Türkiye")
            {
                pb13.ImageLocation = ("Turkey.png");
            }
            ////////////////
            if (lbl14.Text == "İsrail")
            {
                pb14.ImageLocation = ("Israel.png");
            }
            else if (lbl14.Text == "İsveç")
            {
                pb14.ImageLocation = ("Sweden.png");
            }
            else if (lbl14.Text == "Macaristan")
            {
                pb14.ImageLocation = ("Hungary.png");
            }
            else if (lbl14.Text == "Romanya")
            {
                pb14.ImageLocation = ("Romania.png");
            }
            else if (lbl14.Text == "Sırbistan")
            {
                pb14.ImageLocation = ("Serbia.png");
            }
            else if (lbl14.Text == "Brezilya")
            {
                pb14.ImageLocation = ("Brazil.png");
            }
            else if (lbl14.Text == "Estonya")
            {
                pb14.ImageLocation = ("Estonia.png");
            }
            else if (lbl14.Text == "Slovenya")
            {
                pb14.ImageLocation = ("Slovenia.png");
            }
            else if (lbl14.Text == "Norveç")
            {
                pb14.ImageLocation = ("Norway.png");
            }
            else if (lbl14.Text == "Azerbaycan")
            {
                pb14.ImageLocation = ("Azerbaijan.png");
            }
            else if (lbl14.Text == "Kazakistan")
            {
                pb14.ImageLocation = ("Kazakhstan.png");
            }
            else if (lbl14.Text == "Polonya")
            {
                pb14.ImageLocation = ("Poland.png");
            }
            else if (lbl14.Text == "Ukrayna")
            {
                pb14.ImageLocation = ("Ukraine.png");
            }
            else if (lbl14.Text == "Bosna Hersek")
            {
                pb14.ImageLocation = ("Bosnia-and-Herzegovina.png");
            }
            else if (lbl14.Text == "Danimarka")
            {
                pb14.ImageLocation = ("Denmark.png");
            }
            else if (lbl14.Text == "İzlanda")
            {
                pb14.ImageLocation = ("Ireland.png");
            }
            else if (lbl14.Text == "Fransa")
            {
                pb14.ImageLocation = ("France.png");
            }
            else if (lbl14.Text == "Çek Cumhuriyeti")
            {
                pb14.ImageLocation = ("Czech-Republic.png");
            }
            else if (lbl14.Text == "İsviçre")
            {
                pb14.ImageLocation = ("Switzerland.png");
            }
            else if (lbl14.Text == "İtalya")
            {
                pb14.ImageLocation = ("Italy.png");
            }
            else if (lbl14.Text == "Avusturya")
            {
                pb14.ImageLocation = ("Austria.png");
            }
            else if (lbl14.Text == "Slovakya")
            {
                pb14.ImageLocation = ("Slovakia.png");
            }
            else if (lbl14.Text == "Hırvatistan")
            {
                pb14.ImageLocation = ("Crotia.png");
            }
            else if (lbl14.Text == "İspanya")
            {
                pb14.ImageLocation = ("Spain.png");
            }
            else if (lbl14.Text == "Galler")
            {
                pb14.ImageLocation = ("Wales.png");
            }
            else if (lbl14.Text == "İngiltere")
            {
                pb14.ImageLocation = ("England.png");
            }
            else if (lbl14.Text == "Portekiz")
            {
                pb14.ImageLocation = ("Portugal.png");
            }
            else if (lbl14.Text == "Litvanya")
            {
                pb14.ImageLocation = ("Lithuania.png");
            }
            else if (lbl14.Text == "Hollanda")
            {
                pb14.ImageLocation = ("Holland.png");
            }
            else if (lbl14.Text == "Belçika")
            {
                pb14.ImageLocation = ("Belgium.png");
            }
            else if (lbl14.Text == "Almanya")
            {
                pb14.ImageLocation = ("Germany.png");
            }
            else if (lbl14.Text == "Türkiye")
            {
                pb14.ImageLocation = ("Turkey.png");
            }
            /////////////
            if (lbl15.Text == "İsrail")
            {
                pb15.ImageLocation = ("Israel.png");
            }
            else if (lbl15.Text == "İsveç")
            {
                pb15.ImageLocation = ("Sweden.png");
            }
            else if (lbl15.Text == "Macaristan")
            {
                pb15.ImageLocation = ("Hungary.png");
            }
            else if (lbl15.Text == "Romanya")
            {
                pb15.ImageLocation = ("Romania.png");
            }
            else if (lbl15.Text == "Sırbistan")
            {
                pb15.ImageLocation = ("Serbia.png");
            }
            else if (lbl15.Text == "Brezilya")
            {
                pb15.ImageLocation = ("Brazil.png");
            }
            else if (lbl15.Text == "Estonya")
            {
                pb15.ImageLocation = ("Estonia.png");
            }
            else if (lbl15.Text == "Slovenya")
            {
                pb15.ImageLocation = ("Slovenia.png");
            }
            else if (lbl15.Text == "Norveç")
            {
                pb15.ImageLocation = ("Norway.png");
            }
            else if (lbl15.Text == "Azerbaycan")
            {
                pb15.ImageLocation = ("Azerbaijan.png");
            }
            else if (lbl15.Text == "Kazakistan")
            {
                pb15.ImageLocation = ("Kazakhstan.png");
            }
            else if (lbl15.Text == "Polonya")
            {
                pb15.ImageLocation = ("Poland.png");
            }
            else if (lbl15.Text == "Ukrayna")
            {
                pb15.ImageLocation = ("Ukraine.png");
            }
            else if (lbl15.Text == "Bosna Hersek")
            {
                pb15.ImageLocation = ("Bosnia-and-Herzegovina.png");
            }
            else if (lbl15.Text == "Danimarka")
            {
                pb15.ImageLocation = ("Denmark.png");
            }
            else if (lbl15.Text == "İzlanda")
            {
                pb15.ImageLocation = ("Ireland.png");
            }
            else if (lbl15.Text == "Fransa")
            {
                pb15.ImageLocation = ("France.png");
            }
            else if (lbl15.Text == "Çek Cumhuriyeti")
            {
                pb15.ImageLocation = ("Czech-Republic.png");
            }
            else if (lbl15.Text == "İsviçre")
            {
                pb15.ImageLocation = ("Switzerland.png");
            }
            else if (lbl15.Text == "İtalya")
            {
                pb15.ImageLocation = ("Italy.png");
            }
            else if (lbl15.Text == "Avusturya")
            {
                pb15.ImageLocation = ("Austria.png");
            }
            else if (lbl15.Text == "Slovakya")
            {
                pb15.ImageLocation = ("Slovakia.png");
            }
            else if (lbl15.Text == "Hırvatistan")
            {
                pb15.ImageLocation = ("Crotia.png");
            }
            else if (lbl15.Text == "İspanya")
            {
                pb15.ImageLocation = ("Spain.png");
            }
            else if (lbl15.Text == "Galler")
            {
                pb15.ImageLocation = ("Wales.png");
            }
            else if (lbl15.Text == "İngiltere")
            {
                pb15.ImageLocation = ("England.png");
            }
            else if (lbl15.Text == "Portekiz")
            {
                pb15.ImageLocation = ("Portugal.png");
            }
            else if (lbl15.Text == "Litvanya")
            {
                pb15.ImageLocation = ("Lithuania.png");
            }
            else if (lbl15.Text == "Hollanda")
            {
                pb15.ImageLocation = ("Holland.png");
            }
            else if (lbl15.Text == "Belçika")
            {
                pb15.ImageLocation = ("Belgium.png");
            }
            else if (lbl15.Text == "Almanya")
            {
                pb15.ImageLocation = ("Germany.png");
            }
            else if (lbl15.Text == "Türkiye")
            {
                pb15.ImageLocation = ("Turkey.png");
            }
            ////
            if (lbl16.Text == "İsrail")
            {
                pb16.ImageLocation = ("Israel.png");
            }
            else if (lbl16.Text == "İsveç")
            {
                pb16.ImageLocation = ("Sweden.png");
            }
            else if (lbl16.Text == "Macaristan")
            {
                pb16.ImageLocation = ("Hungary.png");
            }
            else if (lbl16.Text == "Romanya")
            {
                pb16.ImageLocation = ("Romania.png");
            }
            else if (lbl16.Text == "Sırbistan")
            {
                pb16.ImageLocation = ("Serbia.png");
            }
            else if (lbl16.Text == "Brezilya")
            {
                pb16.ImageLocation = ("Brazil.png");
            }
            else if (lbl16.Text == "Estonya")
            {
                pb16.ImageLocation = ("Estonia.png");
            }
            else if (lbl16.Text == "Slovenya")
            {
                pb16.ImageLocation = ("Slovenia.png");
            }
            else if (lbl16.Text == "Norveç")
            {
                pb16.ImageLocation = ("Norway.png");
            }
            else if (lbl16.Text == "Azerbaycan")
            {
                pb16.ImageLocation = ("Azerbaijan.png");
            }
            else if (lbl16.Text == "Kazakistan")
            {
                pb16.ImageLocation = ("Kazakhstan.png");
            }
            else if (lbl16.Text == "Polonya")
            {
                pb16.ImageLocation = ("Poland.png");
            }
            else if (lbl16.Text == "Ukrayna")
            {
                pb16.ImageLocation = ("Ukraine.png");
            }
            else if (lbl16.Text == "Bosna Hersek")
            {
                pb16.ImageLocation = ("Bosnia-and-Herzegovina.png");
            }
            else if (lbl16.Text == "Danimarka")
            {
                pb16.ImageLocation = ("Denmark.png");
            }
            else if (lbl16.Text == "İzlanda")
            {
                pb16.ImageLocation = ("Ireland.png");
            }
            else if (lbl16.Text == "Fransa")
            {
                pb16.ImageLocation = ("France.png");
            }
            else if (lbl16.Text == "Çek Cumhuriyeti")
            {
                pb16.ImageLocation = ("Czech-Republic.png");
            }
            else if (lbl16.Text == "İsviçre")
            {
                pb16.ImageLocation = ("Switzerland.png");
            }
            else if (lbl16.Text == "İtalya")
            {
                pb16.ImageLocation = ("Italy.png");
            }
            else if (lbl16.Text == "Avusturya")
            {
                pb16.ImageLocation = ("Austria.png");
            }
            else if (lbl16.Text == "Slovakya")
            {
                pb16.ImageLocation = ("Slovakia.png");
            }
            else if (lbl16.Text == "Hırvatistan")
            {
                pb16.ImageLocation = ("Crotia.png");
            }
            else if (lbl16.Text == "İspanya")
            {
                pb16.ImageLocation = ("Spain.png");
            }
            else if (lbl16.Text == "Galler")
            {
                pb16.ImageLocation = ("Wales.png");
            }
            else if (lbl16.Text == "İngiltere")
            {
                pb16.ImageLocation = ("England.png");
            }
            else if (lbl16.Text == "Portekiz")
            {
                pb16.ImageLocation = ("Portugal.png");
            }
            else if (lbl16.Text == "Litvanya")
            {
                pb16.ImageLocation = ("Lithuania.png");
            }
            else if (lbl16.Text == "Hollanda")
            {
                pb16.ImageLocation = ("Holland.png");
            }
            else if (lbl16.Text == "Belçika")
            {
                pb16.ImageLocation = ("Belgium.png");
            }
            else if (lbl16.Text == "Almanya")
            {
                pb16.ImageLocation = ("Germany.png");
            }
            else if (lbl16.Text == "Türkiye")
            {
                pb16.ImageLocation = ("Turkey.png");
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
            if (sayac == 8)
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
            if (sayac == 8)
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
                button5.Enabled = true;
            }
            else if (b > a)
            {
                label4.Text = lbl8.Text + " Kazandı!";
                listBox1.Items.Add(lbl8.Text);
                button5.Enabled = true;
            }
            else if (txt7.Text == txt8.Text)
            {
                button4.Text = "Tekrar Oyna";
                button4.Enabled = true;
                sayac--;
            }
            if (sayac == 8)
            {
                button17.Visible = Enabled;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sayac++;
            button5.Enabled = false;
            Random number = new Random();
            txt9.Text = number.Next(0, 5).ToString();

            txt10.Text = number.Next(0, 5).ToString();


            int a, b;

            a = Convert.ToInt32(txt9.Text);
            b = Convert.ToInt32(txt10.Text);
            if (a > b)
            {
                label5.Text = lbl9.Text + " Kazandı!";
                listBox1.Items.Add(lbl9.Text);
                button6.Enabled = true;
            }
            else if (b > a)
            {
                label5.Text = lbl10.Text + " Kazandı!";
                listBox1.Items.Add(lbl10.Text);
                button6.Enabled = true;
            }
            else if (txt10.Text == txt9.Text)
            {
                button5.Text = "Tekrar Oyna";
                button5.Enabled = true;
                sayac--;
            }
            if (sayac == 8)
            {
                button17.Visible = Enabled;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sayac++;
            button6.Enabled = false;
            Random number = new Random();
            txt11.Text = number.Next(0, 5).ToString();

            txt12.Text = number.Next(0, 5).ToString();


            int a, b;

            a = Convert.ToInt32(txt11.Text);
            b = Convert.ToInt32(txt12.Text);
            if (a > b)
            {
                label6.Text = lbl11.Text + " Kazandı!";
                listBox1.Items.Add(lbl11.Text);
                button7.Enabled = true;
            }
            else if (b > a)
            {
                label6.Text = lbl12.Text + " Kazandı!";
                listBox1.Items.Add(lbl12.Text);
                button7.Enabled = true;
            }
            else if (txt11.Text == txt12.Text)
            {
                button6.Text = "Tekrar Oyna";
                button6.Enabled = true;
                sayac--;
            }
            if (sayac == 8)
            {
                button17.Visible = Enabled;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            sayac++;
            button7.Enabled = false;
            Random number = new Random();
            txt13.Text = number.Next(0, 5).ToString();

            txt14.Text = number.Next(0, 5).ToString();


            int a, b;

            a = Convert.ToInt32(txt13.Text);
            b = Convert.ToInt32(txt14.Text);
            if (a > b)
            {
                label7.Text = lbl13.Text + " Kazandı!";
                listBox1.Items.Add(lbl13.Text);
                button8.Enabled = true;
            }
            else if (b > a)
            {
                label7.Text = lbl14.Text + " Kazandı!";
                listBox1.Items.Add(lbl14.Text);
                button8.Enabled = true;
            }
            else if (txt13.Text == txt14.Text)
            {
                button7.Text = "Tekrar Oyna";
                button7.Enabled = true;
                sayac--;
            }
            if (sayac == 8)
            {
                button17.Visible = Enabled;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            sayac++;
            button8.Enabled = false;
            Random number = new Random();
            txt15.Text = number.Next(0, 5).ToString();

            txt16.Text = number.Next(0, 5).ToString();


            int a, b;

            a = Convert.ToInt32(txt15.Text);
            b = Convert.ToInt32(txt16.Text);
            if (a > b)
            {
                label8.Text = lbl15.Text + " Kazandı!";
                listBox1.Items.Add(lbl15.Text);
            }
            else if (b > a)
            {
                label8.Text = lbl16.Text + " Kazandı!";
                listBox1.Items.Add(lbl16.Text);

            }
            else if (txt15.Text == txt16.Text)
            {
                button8.Text = "Tekrar Oyna";
                button8.Enabled = true;
                sayac--;
            }
            if (sayac == 8)
            {
                button17.Visible = Enabled;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            Form3 form3 = new Form3();
            form4.lbl1.Text = listBox1.Items[0].ToString();
            form4.lbl2.Text = listBox1.Items[1].ToString();
            form4.lbl3.Text = listBox1.Items[2].ToString();
            form4.lbl4.Text = listBox1.Items[3].ToString();
            form4.lbl5.Text = listBox1.Items[4].ToString();
            form4.lbl6.Text = listBox1.Items[5].ToString();
            form4.lbl7.Text = listBox1.Items[6].ToString();
            form4.lbl8.Text = listBox1.Items[7].ToString();

            form4.Show();
            this.Close();
        }
    }
}
