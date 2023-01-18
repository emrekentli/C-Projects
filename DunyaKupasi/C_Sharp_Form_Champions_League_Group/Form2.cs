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
    public partial class Form2 : Form
    {
        Form3 form3 = new Form3();

        public static int  sayac=0;
        public Form2()
        {
            InitializeComponent();
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
                button9.Enabled = true;
            }
            else if (b > a)
            {
                label8.Text = lbl16.Text + " Kazandı!";
                listBox1.Items.Add(lbl16.Text);
                button9.Enabled = true;

            }
            else if (txt15.Text == txt16.Text)
            {
                button8.Text = "Tekrar Oyna";
                button8.Enabled = true;
                sayac--;
            }
            if (sayac == 16)
            {
                button17.Visible = Enabled;
            }
        }

        private void button7_Click(object sender, EventArgs e)
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

            }
            else if (b > a)
            {
                label5.Text = lbl10.Text + " Kazandı!";

            }
            else if (txt9.Text == txt10.Text)
            {
                button5.Text = "Tekrar Oyna";
                button5.Enabled = true;
                sayac--;
            }
            if (sayac == 16)
            {
                button17.Visible = Enabled;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
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
            /////
            if (lbl17.Text == "İsrail")
            {
                pb17.ImageLocation = ("Israel.png");
            }
            else if (lbl17.Text == "İsveç")
            {
                pb17.ImageLocation = ("Sweden.png");
            }
            else if (lbl17.Text == "Macaristan")
            {
                pb17.ImageLocation = ("Hungary.png");
            }
            else if (lbl17.Text == "Romanya")
            {
                pb17.ImageLocation = ("Romania.png");
            }
            else if (lbl17.Text == "Sırbistan")
            {
                pb17.ImageLocation = ("Serbia.png");
            }
            else if (lbl17.Text == "Brezilya")
            {
                pb17.ImageLocation = ("Brazil.png");
            }
            else if (lbl17.Text == "Estonya")
            {
                pb17.ImageLocation = ("Estonia.png");
            }
            else if (lbl17.Text == "Slovenya")
            {
                pb17.ImageLocation = ("Slovenia.png");
            }
            else if (lbl17.Text == "Norveç")
            {
                pb17.ImageLocation = ("Norway.png");
            }
            else if (lbl17.Text == "Azerbaycan")
            {
                pb17.ImageLocation = ("Azerbaijan.png");
            }
            else if (lbl17.Text == "Kazakistan")
            {
                pb17.ImageLocation = ("Kazakhstan.png");
            }
            else if (lbl17.Text == "Polonya")
            {
                pb17.ImageLocation = ("Poland.png");
            }
            else if (lbl17.Text == "Ukrayna")
            {
                pb17.ImageLocation = ("Ukraine.png");
            }
            else if (lbl17.Text == "Bosna Hersek")
            {
                pb17.ImageLocation = ("Bosnia-and-Herzegovina.png");
            }
            else if (lbl17.Text == "Danimarka")
            {
                pb17.ImageLocation = ("Denmark.png");
            }
            else if (lbl17.Text == "İzlanda")
            {
                pb17.ImageLocation = ("Ireland.png");
            }
            else if (lbl17.Text == "Fransa")
            {
                pb17.ImageLocation = ("France.png");
            }
            else if (lbl17.Text == "Çek Cumhuriyeti")
            {
                pb17.ImageLocation = ("Czech-Republic.png");
            }
            else if (lbl17.Text == "İsviçre")
            {
                pb17.ImageLocation = ("Switzerland.png");
            }
            else if (lbl17.Text == "İtalya")
            {
                pb17.ImageLocation = ("Italy.png");
            }
            else if (lbl17.Text == "Avusturya")
            {
                pb17.ImageLocation = ("Austria.png");
            }
            else if (lbl17.Text == "Slovakya")
            {
                pb17.ImageLocation = ("Slovakia.png");
            }
            else if (lbl17.Text == "Hırvatistan")
            {
                pb17.ImageLocation = ("Crotia.png");
            }
            else if (lbl17.Text == "İspanya")
            {
                pb17.ImageLocation = ("Spain.png");
            }
            else if (lbl17.Text == "Galler")
            {
                pb17.ImageLocation = ("Wales.png");
            }
            else if (lbl17.Text == "İngiltere")
            {
                pb17.ImageLocation = ("England.png");
            }
            else if (lbl17.Text == "Portekiz")
            {
                pb17.ImageLocation = ("Portugal.png");
            }
            else if (lbl17.Text == "Litvanya")
            {
                pb17.ImageLocation = ("Lithuania.png");
            }
            else if (lbl17.Text == "Hollanda")
            {
                pb17.ImageLocation = ("Holland.png");
            }
            else if (lbl17.Text == "Belçika")
            {
                pb17.ImageLocation = ("Belgium.png");
            }
            else if (lbl17.Text == "Almanya")
            {
                pb17.ImageLocation = ("Germany.png");
            }
            else if (lbl17.Text == "Türkiye")
            {
                pb17.ImageLocation = ("Turkey.png");
            }
            //
            if (lbl18.Text == "İsrail")
            {
                pb18.ImageLocation = ("Israel.png");
            }
            else if (lbl18.Text == "İsveç")
            {
                pb18.ImageLocation = ("Sweden.png");
            }
            else if (lbl18.Text == "Macaristan")
            {
                pb18.ImageLocation = ("Hungary.png");
            }
            else if (lbl18.Text == "Romanya")
            {
                pb18.ImageLocation = ("Romania.png");
            }
            else if (lbl18.Text == "Sırbistan")
            {
                pb18.ImageLocation = ("Serbia.png");
            }
            else if (lbl18.Text == "Brezilya")
            {
                pb18.ImageLocation = ("Brazil.png");
            }
            else if (lbl18.Text == "Estonya")
            {
                pb18.ImageLocation = ("Estonia.png");
            }
            else if (lbl18.Text == "Slovenya")
            {
                pb18.ImageLocation = ("Slovenia.png");
            }
            else if (lbl18.Text == "Norveç")
            {
                pb18.ImageLocation = ("Norway.png");
            }
            else if (lbl18.Text == "Azerbaycan")
            {
                pb18.ImageLocation = ("Azerbaijan.png");
            }
            else if (lbl18.Text == "Kazakistan")
            {
                pb18.ImageLocation = ("Kazakhstan.png");
            }
            else if (lbl18.Text == "Polonya")
            {
                pb18.ImageLocation = ("Poland.png");
            }
            else if (lbl18.Text == "Ukrayna")
            {
                pb18.ImageLocation = ("Ukraine.png");
            }
            else if (lbl18.Text == "Bosna Hersek")
            {
                pb18.ImageLocation = ("Bosnia-and-Herzegovina.png");
            }
            else if (lbl18.Text == "Danimarka")
            {
                pb18.ImageLocation = ("Denmark.png");
            }
            else if (lbl18.Text == "İzlanda")
            {
                pb18.ImageLocation = ("Ireland.png");
            }
            else if (lbl18.Text == "Fransa")
            {
                pb18.ImageLocation = ("France.png");
            }
            else if (lbl18.Text == "Çek Cumhuriyeti")
            {
                pb18.ImageLocation = ("Czech-Republic.png");
            }
            else if (lbl18.Text == "İsviçre")
            {
                pb18.ImageLocation = ("Switzerland.png");
            }
            else if (lbl18.Text == "İtalya")
            {
                pb18.ImageLocation = ("Italy.png");
            }
            else if (lbl18.Text == "Avusturya")
            {
                pb18.ImageLocation = ("Austria.png");
            }
            else if (lbl18.Text == "Slovakya")
            {
                pb18.ImageLocation = ("Slovakia.png");
            }
            else if (lbl18.Text == "Hırvatistan")
            {
                pb18.ImageLocation = ("Crotia.png");
            }
            else if (lbl18.Text == "İspanya")
            {
                pb18.ImageLocation = ("Spain.png");
            }
            else if (lbl18.Text == "Galler")
            {
                pb18.ImageLocation = ("Wales.png");
            }
            else if (lbl18.Text == "İngiltere")
            {
                pb18.ImageLocation = ("England.png");
            }
            else if (lbl18.Text == "Portekiz")
            {
                pb18.ImageLocation = ("Portugal.png");
            }
            else if (lbl18.Text == "Litvanya")
            {
                pb18.ImageLocation = ("Lithuania.png");
            }
            else if (lbl18.Text == "Hollanda")
            {
                pb18.ImageLocation = ("Holland.png");
            }
            else if (lbl18.Text == "Belçika")
            {
                pb18.ImageLocation = ("Belgium.png");
            }
            else if (lbl18.Text == "Almanya")
            {
                pb18.ImageLocation = ("Germany.png");
            }
            else if (lbl18.Text == "Türkiye")
            {
                pb18.ImageLocation = ("Turkey.png");
            }
            /////////
            if (lbl19.Text == "İsrail")
            {
                pb19.ImageLocation = ("Israel.png");
            }
            else if (lbl19.Text == "İsveç")
            {
                pb19.ImageLocation = ("Sweden.png");
            }
            else if (lbl19.Text == "Macaristan")
            {
                pb19.ImageLocation = ("Hungary.png");
            }
            else if (lbl19.Text == "Romanya")
            {
                pb19.ImageLocation = ("Romania.png");
            }
            else if (lbl19.Text == "Sırbistan")
            {
                pb19.ImageLocation = ("Serbia.png");
            }
            else if (lbl19.Text == "Brezilya")
            {
                pb19.ImageLocation = ("Brazil.png");
            }
            else if (lbl19.Text == "Estonya")
            {
                pb19.ImageLocation = ("Estonia.png");
            }
            else if (lbl19.Text == "Slovenya")
            {
                pb19.ImageLocation = ("Slovenia.png");
            }
            else if (lbl19.Text == "Norveç")
            {
                pb19.ImageLocation = ("Norway.png");
            }
            else if (lbl19.Text == "Azerbaycan")
            {
                pb19.ImageLocation = ("Azerbaijan.png");
            }
            else if (lbl19.Text == "Kazakistan")
            {
                pb19.ImageLocation = ("Kazakhstan.png");
            }
            else if (lbl19.Text == "Polonya")
            {
                pb19.ImageLocation = ("Poland.png");
            }
            else if (lbl19.Text == "Ukrayna")
            {
                pb19.ImageLocation = ("Ukraine.png");
            }
            else if (lbl19.Text == "Bosna Hersek")
            {
                pb19.ImageLocation = ("Bosnia-and-Herzegovina.png");
            }
            else if (lbl19.Text == "Danimarka")
            {
                pb19.ImageLocation = ("Denmark.png");
            }
            else if (lbl19.Text == "İzlanda")
            {
                pb19.ImageLocation = ("Ireland.png");
            }
            else if (lbl19.Text == "Fransa")
            {
                pb19.ImageLocation = ("France.png");
            }
            else if (lbl19.Text == "Çek Cumhuriyeti")
            {
                pb19.ImageLocation = ("Czech-Republic.png");
            }
            else if (lbl19.Text == "İsviçre")
            {
                pb19.ImageLocation = ("Switzerland.png");
            }
            else if (lbl19.Text == "İtalya")
            {
                pb19.ImageLocation = ("Italy.png");
            }
            else if (lbl19.Text == "Avusturya")
            {
                pb19.ImageLocation = ("Austria.png");
            }
            else if (lbl19.Text == "Slovakya")
            {
                pb19.ImageLocation = ("Slovakia.png");
            }
            else if (lbl19.Text == "Hırvatistan")
            {
                pb19.ImageLocation = ("Crotia.png");
            }
            else if (lbl19.Text == "İspanya")
            {
                pb19.ImageLocation = ("Spain.png");
            }
            else if (lbl19.Text == "Galler")
            {
                pb19.ImageLocation = ("Wales.png");
            }
            else if (lbl19.Text == "İngiltere")
            {
                pb19.ImageLocation = ("England.png");
            }
            else if (lbl19.Text == "Portekiz")
            {
                pb19.ImageLocation = ("Portugal.png");
            }
            else if (lbl19.Text == "Litvanya")
            {
                pb19.ImageLocation = ("Lithuania.png");
            }
            else if (lbl19.Text == "Hollanda")
            {
                pb19.ImageLocation = ("Holland.png");
            }
            else if (lbl19.Text == "Belçika")
            {
                pb19.ImageLocation = ("Belgium.png");
            }
            else if (lbl19.Text == "Almanya")
            {
                pb19.ImageLocation = ("Germany.png");
            }
            else if (lbl19.Text == "Türkiye")
            {
                pb19.ImageLocation = ("Turkey.png");
            }
            /////////
            if (lbl20.Text == "İsrail")
            {
                pb20.ImageLocation = ("Israel.png");
            }
            else if (lbl20.Text == "İsveç")
            {
                pb20.ImageLocation = ("Sweden.png");
            }
            else if (lbl20.Text == "Macaristan")
            {
                pb20.ImageLocation = ("Hungary.png");
            }
            else if (lbl20.Text == "Romanya")
            {
                pb20.ImageLocation = ("Romania.png");
            }
            else if (lbl20.Text == "Sırbistan")
            {
                pb20.ImageLocation = ("Serbia.png");
            }
            else if (lbl20.Text == "Brezilya")
            {
                pb20.ImageLocation = ("Brazil.png");
            }
            else if (lbl20.Text == "Estonya")
            {
                pb20.ImageLocation = ("Estonia.png");
            }
            else if (lbl20.Text == "Slovenya")
            {
                pb20.ImageLocation = ("Slovenia.png");
            }
            else if (lbl20.Text == "Norveç")
            {
                pb20.ImageLocation = ("Norway.png");
            }
            else if (lbl20.Text == "Azerbaycan")
            {
                pb20.ImageLocation = ("Azerbaijan.png");
            }
            else if (lbl20.Text == "Kazakistan")
            {
                pb20.ImageLocation = ("Kazakhstan.png");
            }
            else if (lbl20.Text == "Polonya")
            {
                pb20.ImageLocation = ("Poland.png");
            }
            else if (lbl20.Text == "Ukrayna")
            {
                pb20.ImageLocation = ("Ukraine.png");
            }
            else if (lbl20.Text == "Bosna Hersek")
            {
                pb20.ImageLocation = ("Bosnia-and-Herzegovina.png");
            }
            else if (lbl20.Text == "Danimarka")
            {
                pb20.ImageLocation = ("Denmark.png");
            }
            else if (lbl20.Text == "İzlanda")
            {
                pb20.ImageLocation = ("Ireland.png");
            }
            else if (lbl20.Text == "Fransa")
            {
                pb20.ImageLocation = ("France.png");
            }
            else if (lbl20.Text == "Çek Cumhuriyeti")
            {
                pb20.ImageLocation = ("Czech-Republic.png");
            }
            else if (lbl20.Text == "İsviçre")
            {
                pb20.ImageLocation = ("Switzerland.png");
            }
            else if (lbl20.Text == "İtalya")
            {
                pb20.ImageLocation = ("Italy.png");
            }
            else if (lbl20.Text == "Avusturya")
            {
                pb20.ImageLocation = ("Austria.png");
            }
            else if (lbl20.Text == "Slovakya")
            {
                pb20.ImageLocation = ("Slovakia.png");
            }
            else if (lbl20.Text == "Hırvatistan")
            {
                pb20.ImageLocation = ("Crotia.png");
            }
            else if (lbl20.Text == "İspanya")
            {
                pb20.ImageLocation = ("Spain.png");
            }
            else if (lbl20.Text == "Galler")
            {
                pb20.ImageLocation = ("Wales.png");
            }
            else if (lbl20.Text == "İngiltere")
            {
                pb20.ImageLocation = ("England.png");
            }
            else if (lbl20.Text == "Portekiz")
            {
                pb20.ImageLocation = ("Portugal.png");
            }
            else if (lbl20.Text == "Litvanya")
            {
                pb20.ImageLocation = ("Lithuania.png");
            }
            else if (lbl20.Text == "Hollanda")
            {
                pb20.ImageLocation = ("Holland.png");
            }
            else if (lbl20.Text == "Belçika")
            {
                pb20.ImageLocation = ("Belgium.png");
            }
            else if (lbl20.Text == "Almanya")
            {
                pb20.ImageLocation = ("Germany.png");
            }
            else if (lbl20.Text == "Türkiye")
            {
                pb20.ImageLocation = ("Turkey.png");
            }
            if (lbl21.Text == "İsrail")
            {
                pb21.ImageLocation = ("Israel.png");
            }
            else if (lbl21.Text == "İsveç")
            {
                pb21.ImageLocation = ("Sweden.png");
            }
            else if (lbl21.Text == "Macaristan")
            {
                pb21.ImageLocation = ("Hungary.png");
            }
            else if (lbl21.Text == "Romanya")
            {
                pb21.ImageLocation = ("Romania.png");
            }
            else if (lbl21.Text == "Sırbistan")
            {
                pb21.ImageLocation = ("Serbia.png");
            }
            else if (lbl21.Text == "Brezilya")
            {
                pb21.ImageLocation = ("Brazil.png");
            }
            else if (lbl21.Text == "Estonya")
            {
                pb21.ImageLocation = ("Estonia.png");
            }
            else if (lbl21.Text == "Slovenya")
            {
                pb21.ImageLocation = ("Slovenia.png");
            }
            else if (lbl21.Text == "Norveç")
            {
                pb21.ImageLocation = ("Norway.png");
            }
            else if (lbl21.Text == "Azerbaycan")
            {
                pb21.ImageLocation = ("Azerbaijan.png");
            }
            else if (lbl21.Text == "Kazakistan")
            {
                pb21.ImageLocation = ("Kazakhstan.png");
            }
            else if (lbl21.Text == "Polonya")
            {
                pb21.ImageLocation = ("Poland.png");
            }
            else if (lbl21.Text == "Ukrayna")
            {
                pb21.ImageLocation = ("Ukraine.png");
            }
            else if (lbl21.Text == "Bosna Hersek")
            {
                pb21.ImageLocation = ("Bosnia-and-Herzegovina.png");
            }
            else if (lbl21.Text == "Danimarka")
            {
                pb21.ImageLocation = ("Denmark.png");
            }
            else if (lbl21.Text == "İzlanda")
            {
                pb21.ImageLocation = ("Ireland.png");
            }
            else if (lbl21.Text == "Fransa")
            {
                pb21.ImageLocation = ("France.png");
            }
            else if (lbl21.Text == "Çek Cumhuriyeti")
            {
                pb21.ImageLocation = ("Czech-Republic.png");
            }
            else if (lbl21.Text == "İsviçre")
            {
                pb21.ImageLocation = ("Switzerland.png");
            }
            else if (lbl21.Text == "İtalya")
            {
                pb21.ImageLocation = ("Italy.png");
            }
            else if (lbl21.Text == "Avusturya")
            {
                pb21.ImageLocation = ("Austria.png");
            }
            else if (lbl21.Text == "Slovakya")
            {
                pb21.ImageLocation = ("Slovakia.png");
            }
            else if (lbl21.Text == "Hırvatistan")
            {
                pb21.ImageLocation = ("Crotia.png");
            }
            else if (lbl21.Text == "İspanya")
            {
                pb21.ImageLocation = ("Spain.png");
            }
            else if (lbl21.Text == "Galler")
            {
                pb21.ImageLocation = ("Wales.png");
            }
            else if (lbl21.Text == "İngiltere")
            {
                pb21.ImageLocation = ("England.png");
            }
            else if (lbl21.Text == "Portekiz")
            {
                pb21.ImageLocation = ("Portugal.png");
            }
            else if (lbl21.Text == "Litvanya")
            {
                pb21.ImageLocation = ("Lithuania.png");
            }
            else if (lbl21.Text == "Hollanda")
            {
                pb21.ImageLocation = ("Holland.png");
            }
            else if (lbl21.Text == "Belçika")
            {
                pb21.ImageLocation = ("Belgium.png");
            }
            else if (lbl21.Text == "Almanya")
            {
                pb21.ImageLocation = ("Germany.png");
            }
            else if (lbl21.Text == "Türkiye")
            {
                pb21.ImageLocation = ("Turkey.png");
            }
            ////////
            if (lbl22.Text == "İsrail")
            {
                pb22.ImageLocation = ("Israel.png");
            }
            else if (lbl22.Text == "İsveç")
            {
                pb22.ImageLocation = ("Sweden.png");
            }
            else if (lbl22.Text == "Macaristan")
            {
                pb22.ImageLocation = ("Hungary.png");
            }
            else if (lbl22.Text == "Romanya")
            {
                pb22.ImageLocation = ("Romania.png");
            }
            else if (lbl22.Text == "Sırbistan")
            {
                pb22.ImageLocation = ("Serbia.png");
            }
            else if (lbl22.Text == "Brezilya")
            {
                pb22.ImageLocation = ("Brazil.png");
            }
            else if (lbl22.Text == "Estonya")
            {
                pb22.ImageLocation = ("Estonia.png");
            }
            else if (lbl22.Text == "Slovenya")
            {
                pb22.ImageLocation = ("Slovenia.png");
            }
            else if (lbl22.Text == "Norveç")
            {
                pb22.ImageLocation = ("Norway.png");
            }
            else if (lbl22.Text == "Azerbaycan")
            {
                pb22.ImageLocation = ("Azerbaijan.png");
            }
            else if (lbl22.Text == "Kazakistan")
            {
                pb22.ImageLocation = ("Kazakhstan.png");
            }
            else if (lbl22.Text == "Polonya")
            {
                pb22.ImageLocation = ("Poland.png");
            }
            else if (lbl22.Text == "Ukrayna")
            {
                pb22.ImageLocation = ("Ukraine.png");
            }
            else if (lbl22.Text == "Bosna Hersek")
            {
                pb22.ImageLocation = ("Bosnia-and-Herzegovina.png");
            }
            else if (lbl22.Text == "Danimarka")
            {
                pb22.ImageLocation = ("Denmark.png");
            }
            else if (lbl22.Text == "İzlanda")
            {
                pb22.ImageLocation = ("Ireland.png");
            }
            else if (lbl22.Text == "Fransa")
            {
                pb22.ImageLocation = ("France.png");
            }
            else if (lbl22.Text == "Çek Cumhuriyeti")
            {
                pb22.ImageLocation = ("Czech-Republic.png");
            }
            else if (lbl22.Text == "İsviçre")
            {
                pb22.ImageLocation = ("Switzerland.png");
            }
            else if (lbl22.Text == "İtalya")
            {
                pb22.ImageLocation = ("Italy.png");
            }
            else if (lbl22.Text == "Avusturya")
            {
                pb22.ImageLocation = ("Austria.png");
            }
            else if (lbl22.Text == "Slovakya")
            {
                pb22.ImageLocation = ("Slovakia.png");
            }
            else if (lbl22.Text == "Hırvatistan")
            {
                pb22.ImageLocation = ("Crotia.png");
            }
            else if (lbl22.Text == "İspanya")
            {
                pb22.ImageLocation = ("Spain.png");
            }
            else if (lbl22.Text == "Galler")
            {
                pb22.ImageLocation = ("Wales.png");
            }
            else if (lbl22.Text == "İngiltere")
            {
                pb22.ImageLocation = ("England.png");
            }
            else if (lbl22.Text == "Portekiz")
            {
                pb22.ImageLocation = ("Portugal.png");
            }
            else if (lbl22.Text == "Litvanya")
            {
                pb22.ImageLocation = ("Lithuania.png");
            }
            else if (lbl22.Text == "Hollanda")
            {
                pb22.ImageLocation = ("Holland.png");
            }
            else if (lbl22.Text == "Belçika")
            {
                pb22.ImageLocation = ("Belgium.png");
            }
            else if (lbl22.Text == "Almanya")
            {
                pb22.ImageLocation = ("Germany.png");
            }
            else if (lbl22.Text == "Türkiye")
            {
                pb22.ImageLocation = ("Turkey.png");
            }
            /////////
             if (lbl23.Text == "İsrail")
            {
                pb23.ImageLocation = ("Israel.png");
            }
            else if (lbl23.Text == "İsveç")
            {
                pb23.ImageLocation = ("Sweden.png");
            }
            else if (lbl23.Text == "Macaristan")
            {
                pb23.ImageLocation = ("Hungary.png");
            }
            else if (lbl23.Text == "Romanya")
            {
                pb23.ImageLocation = ("Romania.png");
            }
            else if (lbl23.Text == "Sırbistan")
            {
                pb23.ImageLocation = ("Serbia.png");
            }
            else if (lbl23.Text == "Brezilya")
            {
                pb23.ImageLocation = ("Brazil.png");
            }
            else if (lbl23.Text == "Estonya")
            {
                pb23.ImageLocation = ("Estonia.png");
            }
            else if (lbl23.Text == "Slovenya")
            {
                pb23.ImageLocation = ("Slovenia.png");
            }
            else if (lbl23.Text == "Norveç")
            {
                pb23.ImageLocation = ("Norway.png");
            }
            else if (lbl23.Text == "Azerbaycan")
            {
                pb23.ImageLocation = ("Azerbaijan.png");
            }
            else if (lbl23.Text == "Kazakistan")
            {
                pb23.ImageLocation = ("Kazakhstan.png");
            }
            else if (lbl23.Text == "Polonya")
            {
                pb23.ImageLocation = ("Poland.png");
            }
            else if (lbl23.Text == "Ukrayna")
            {
                pb23.ImageLocation = ("Ukraine.png");
            }
            else if (lbl23.Text == "Bosna Hersek")
            {
                pb23.ImageLocation = ("Bosnia-and-Herzegovina.png");
            }
            else if (lbl23.Text == "Danimarka")
            {
                pb23.ImageLocation = ("Denmark.png");
            }
            else if (lbl23.Text == "İzlanda")
            {
                pb23.ImageLocation = ("Ireland.png");
            }
            else if (lbl23.Text == "Fransa")
            {
                pb23.ImageLocation = ("France.png");
            }
            else if (lbl23.Text == "Çek Cumhuriyeti")
            {
                pb23.ImageLocation = ("Czech-Republic.png");
            }
            else if (lbl23.Text == "İsviçre")
            {
                pb23.ImageLocation = ("Switzerland.png");
            }
            else if (lbl23.Text == "İtalya")
            {
                pb23.ImageLocation = ("Italy.png");
            }
            else if (lbl23.Text == "Avusturya")
            {
                pb23.ImageLocation = ("Austria.png");
            }
            else if (lbl23.Text == "Slovakya")
            {
                pb23.ImageLocation = ("Slovakia.png");
            }
            else if (lbl23.Text == "Hırvatistan")
            {
                pb23.ImageLocation = ("Crotia.png");
            }
            else if (lbl23.Text == "İspanya")
            {
                pb23.ImageLocation = ("Spain.png");
            }
            else if (lbl23.Text == "Galler")
            {
                pb23.ImageLocation = ("Wales.png");
            }
            else if (lbl23.Text == "İngiltere")
            {
                pb23.ImageLocation = ("England.png");
            }
            else if (lbl23.Text == "Portekiz")
            {
                pb23.ImageLocation = ("Portugal.png");
            }
            else if (lbl23.Text == "Litvanya")
            {
                pb23.ImageLocation = ("Lithuania.png");
            }
            else if (lbl23.Text == "Hollanda")
            {
                pb23.ImageLocation = ("Holland.png");
            }
            else if (lbl23.Text == "Belçika")
            {
                pb23.ImageLocation = ("Belgium.png");
            }
            else if (lbl23.Text == "Almanya")
            {
                pb23.ImageLocation = ("Germany.png");
            }
            else if (lbl23.Text == "Türkiye")
            {
                pb23.ImageLocation = ("Turkey.png");
            }
            ////////
             if (lbl24.Text == "İsrail")
             {
                 pb24.ImageLocation = ("Israel.png");
             }
             else if (lbl24.Text == "İsveç")
             {
                 pb24.ImageLocation = ("Sweden.png");
             }
             else if (lbl24.Text == "Macaristan")
             {
                 pb24.ImageLocation = ("Hungary.png");
             }
             else if (lbl24.Text == "Romanya")
             {
                 pb24.ImageLocation = ("Romania.png");
             }
             else if (lbl24.Text == "Sırbistan")
             {
                 pb24.ImageLocation = ("Serbia.png");
             }
             else if (lbl24.Text == "Brezilya")
             {
                 pb24.ImageLocation = ("Brazil.png");
             }
             else if (lbl24.Text == "Estonya")
             {
                 pb24.ImageLocation = ("Estonia.png");
             }
             else if (lbl24.Text == "Slovenya")
             {
                 pb24.ImageLocation = ("Slovenia.png");
             }
             else if (lbl24.Text == "Norveç")
             {
                 pb24.ImageLocation = ("Norway.png");
             }
             else if (lbl24.Text == "Azerbaycan")
             {
                 pb24.ImageLocation = ("Azerbaijan.png");
             }
             else if (lbl24.Text == "Kazakistan")
             {
                 pb24.ImageLocation = ("Kazakhstan.png");
             }
             else if (lbl24.Text == "Polonya")
             {
                 pb24.ImageLocation = ("Poland.png");
             }
             else if (lbl24.Text == "Ukrayna")
             {
                 pb24.ImageLocation = ("Ukraine.png");
             }
             else if (lbl24.Text == "Bosna Hersek")
             {
                 pb24.ImageLocation = ("Bosnia-and-Herzegovina.png");
             }
             else if (lbl24.Text == "Danimarka")
             {
                 pb24.ImageLocation = ("Denmark.png");
             }
             else if (lbl24.Text == "İzlanda")
             {
                 pb24.ImageLocation = ("Ireland.png");
             }
             else if (lbl24.Text == "Fransa")
             {
                 pb24.ImageLocation = ("France.png");
             }
             else if (lbl24.Text == "Çek Cumhuriyeti")
             {
                 pb24.ImageLocation = ("Czech-Republic.png");
             }
             else if (lbl24.Text == "İsviçre")
             {
                 pb24.ImageLocation = ("Switzerland.png");
             }
             else if (lbl24.Text == "İtalya")
             {
                 pb24.ImageLocation = ("Italy.png");
             }
             else if (lbl24.Text == "Avusturya")
             {
                 pb24.ImageLocation = ("Austria.png");
             }
             else if (lbl24.Text == "Slovakya")
             {
                 pb24.ImageLocation = ("Slovakia.png");
             }
             else if (lbl24.Text == "Hırvatistan")
             {
                 pb24.ImageLocation = ("Crotia.png");
             }
             else if (lbl24.Text == "İspanya")
             {
                 pb24.ImageLocation = ("Spain.png");
             }
             else if (lbl24.Text == "Galler")
             {
                 pb24.ImageLocation = ("Wales.png");
             }
             else if (lbl24.Text == "İngiltere")
             {
                 pb24.ImageLocation = ("England.png");
             }
             else if (lbl24.Text == "Portekiz")
             {
                 pb24.ImageLocation = ("Portugal.png");
             }
             else if (lbl24.Text == "Litvanya")
             {
                 pb24.ImageLocation = ("Lithuania.png");
             }
             else if (lbl24.Text == "Hollanda")
             {
                 pb24.ImageLocation = ("Holland.png");
             }
             else if (lbl24.Text == "Belçika")
             {
                 pb24.ImageLocation = ("Belgium.png");
             }
             else if (lbl24.Text == "Almanya")
             {
                 pb24.ImageLocation = ("Germany.png");
             }
             else if (lbl24.Text == "Türkiye")
             {
                 pb24.ImageLocation = ("Turkey.png");
             }
            /////
             if (lbl25.Text == "İsrail")
             {
                 pb25.ImageLocation = ("Israel.png");
             }
             else if (lbl25.Text == "İsveç")
             {
                 pb25.ImageLocation = ("Sweden.png");
             }
             else if (lbl25.Text == "Macaristan")
             {
                 pb25.ImageLocation = ("Hungary.png");
             }
             else if (lbl25.Text == "Romanya")
             {
                 pb25.ImageLocation = ("Romania.png");
             }
             else if (lbl25.Text == "Sırbistan")
             {
                 pb25.ImageLocation = ("Serbia.png");
             }
             else if (lbl25.Text == "Brezilya")
             {
                 pb25.ImageLocation = ("Brazil.png");
             }
             else if (lbl25.Text == "Estonya")
             {
                 pb25.ImageLocation = ("Estonia.png");
             }
             else if (lbl25.Text == "Slovenya")
             {
                 pb25.ImageLocation = ("Slovenia.png");
             }
             else if (lbl25.Text == "Norveç")
             {
                 pb25.ImageLocation = ("Norway.png");
             }
             else if (lbl25.Text == "Azerbaycan")
             {
                 pb25.ImageLocation = ("Azerbaijan.png");
             }
             else if (lbl25.Text == "Kazakistan")
             {
                 pb25.ImageLocation = ("Kazakhstan.png");
             }
             else if (lbl25.Text == "Polonya")
             {
                 pb25.ImageLocation = ("Poland.png");
             }
             else if (lbl25.Text == "Ukrayna")
             {
                 pb25.ImageLocation = ("Ukraine.png");
             }
             else if (lbl25.Text == "Bosna Hersek")
             {
                 pb25.ImageLocation = ("Bosnia-and-Herzegovina.png");
             }
             else if (lbl25.Text == "Danimarka")
             {
                 pb25.ImageLocation = ("Denmark.png");
             }
             else if (lbl25.Text == "İzlanda")
             {
                 pb25.ImageLocation = ("Ireland.png");
             }
             else if (lbl25.Text == "Fransa")
             {
                 pb25.ImageLocation = ("France.png");
             }
             else if (lbl25.Text == "Çek Cumhuriyeti")
             {
                 pb25.ImageLocation = ("Czech-Republic.png");
             }
             else if (lbl25.Text == "İsviçre")
             {
                 pb25.ImageLocation = ("Switzerland.png");
             }
             else if (lbl25.Text == "İtalya")
             {
                 pb25.ImageLocation = ("Italy.png");
             }
             else if (lbl25.Text == "Avusturya")
             {
                 pb25.ImageLocation = ("Austria.png");
             }
             else if (lbl25.Text == "Slovakya")
             {
                 pb25.ImageLocation = ("Slovakia.png");
             }
             else if (lbl25.Text == "Hırvatistan")
             {
                 pb25.ImageLocation = ("Crotia.png");
             }
             else if (lbl25.Text == "İspanya")
             {
                 pb25.ImageLocation = ("Spain.png");
             }
             else if (lbl25.Text == "Galler")
             {
                 pb25.ImageLocation = ("Wales.png");
             }
             else if (lbl25.Text == "İngiltere")
             {
                 pb25.ImageLocation = ("England.png");
             }
             else if (lbl25.Text == "Portekiz")
             {
                 pb25.ImageLocation = ("Portugal.png");
             }
             else if (lbl25.Text == "Litvanya")
             {
                 pb25.ImageLocation = ("Lithuania.png");
             }
             else if (lbl25.Text == "Hollanda")
             {
                 pb25.ImageLocation = ("Holland.png");
             }
             else if (lbl25.Text == "Belçika")
             {
                 pb25.ImageLocation = ("Belgium.png");
             }
             else if (lbl25.Text == "Almanya")
             {
                 pb25.ImageLocation = ("Germany.png");
             }
             else if (lbl25.Text == "Türkiye")
             {
                 pb25.ImageLocation = ("Turkey.png");
             }
            //
             if (lbl26.Text == "İsrail")
             {
                 pb26.ImageLocation = ("Israel.png");
             }
             else if (lbl26.Text == "İsveç")
             {
                 pb26.ImageLocation = ("Sweden.png");
             }
             else if (lbl26.Text == "Macaristan")
             {
                 pb26.ImageLocation = ("Hungary.png");
             }
             else if (lbl26.Text == "Romanya")
             {
                 pb26.ImageLocation = ("Romania.png");
             }
             else if (lbl26.Text == "Sırbistan")
             {
                 pb26.ImageLocation = ("Serbia.png");
             }
             else if (lbl26.Text == "Brezilya")
             {
                 pb26.ImageLocation = ("Brazil.png");
             }
             else if (lbl26.Text == "Estonya")
             {
                 pb26.ImageLocation = ("Estonia.png");
             }
             else if (lbl26.Text == "Slovenya")
             {
                 pb26.ImageLocation = ("Slovenia.png");
             }
             else if (lbl26.Text == "Norveç")
             {
                 pb26.ImageLocation = ("Norway.png");
             }
             else if (lbl26.Text == "Azerbaycan")
             {
                 pb26.ImageLocation = ("Azerbaijan.png");
             }
             else if (lbl26.Text == "Kazakistan")
             {
                 pb26.ImageLocation = ("Kazakhstan.png");
             }
             else if (lbl26.Text == "Polonya")
             {
                 pb26.ImageLocation = ("Poland.png");
             }
             else if (lbl26.Text == "Ukrayna")
             {
                 pb26.ImageLocation = ("Ukraine.png");
             }
             else if (lbl26.Text == "Bosna Hersek")
             {
                 pb26.ImageLocation = ("Bosnia-and-Herzegovina.png");
             }
             else if (lbl26.Text == "Danimarka")
             {
                 pb26.ImageLocation = ("Denmark.png");
             }
             else if (lbl26.Text == "İzlanda")
             {
                 pb26.ImageLocation = ("Ireland.png");
             }
             else if (lbl26.Text == "Fransa")
             {
                 pb26.ImageLocation = ("France.png");
             }
             else if (lbl26.Text == "Çek Cumhuriyeti")
             {
                 pb26.ImageLocation = ("Czech-Republic.png");
             }
             else if (lbl26.Text == "İsviçre")
             {
                 pb26.ImageLocation = ("Switzerland.png");
             }
             else if (lbl26.Text == "İtalya")
             {
                 pb26.ImageLocation = ("Italy.png");
             }
             else if (lbl26.Text == "Avusturya")
             {
                 pb26.ImageLocation = ("Austria.png");
             }
             else if (lbl26.Text == "Slovakya")
             {
                 pb26.ImageLocation = ("Slovakia.png");
             }
             else if (lbl26.Text == "Hırvatistan")
             {
                 pb26.ImageLocation = ("Crotia.png");
             }
             else if (lbl26.Text == "İspanya")
             {
                 pb26.ImageLocation = ("Spain.png");
             }
             else if (lbl26.Text == "Galler")
             {
                 pb26.ImageLocation = ("Wales.png");
             }
             else if (lbl26.Text == "İngiltere")
             {
                 pb26.ImageLocation = ("England.png");
             }
             else if (lbl26.Text == "Portekiz")
             {
                 pb26.ImageLocation = ("Portugal.png");
             }
             else if (lbl26.Text == "Litvanya")
             {
                 pb26.ImageLocation = ("Lithuania.png");
             }
             else if (lbl26.Text == "Hollanda")
             {
                 pb26.ImageLocation = ("Holland.png");
             }
             else if (lbl26.Text == "Belçika")
             {
                 pb26.ImageLocation = ("Belgium.png");
             }
             else if (lbl26.Text == "Almanya")
             {
                 pb26.ImageLocation = ("Germany.png");
             }
             else if (lbl26.Text == "Türkiye")
             {
                 pb26.ImageLocation = ("Turkey.png");
             }
            /////
             if (lbl27.Text == "İsrail")
             {
                 pb27.ImageLocation = ("Israel.png");
             }
             else if (lbl27.Text == "İsveç")
             {
                 pb27.ImageLocation = ("Sweden.png");
             }
             else if (lbl27.Text == "Macaristan")
             {
                 pb27.ImageLocation = ("Hungary.png");
             }
             else if (lbl27.Text == "Romanya")
             {
                 pb27.ImageLocation = ("Romania.png");
             }
             else if (lbl27.Text == "Sırbistan")
             {
                 pb27.ImageLocation = ("Serbia.png");
             }
             else if (lbl27.Text == "Brezilya")
             {
                 pb27.ImageLocation = ("Brazil.png");
             }
             else if (lbl27.Text == "Estonya")
             {
                 pb27.ImageLocation = ("Estonia.png");
             }
             else if (lbl27.Text == "Slovenya")
             {
                 pb27.ImageLocation = ("Slovenia.png");
             }
             else if (lbl27.Text == "Norveç")
             {
                 pb27.ImageLocation = ("Norway.png");
             }
             else if (lbl27.Text == "Azerbaycan")
             {
                 pb27.ImageLocation = ("Azerbaijan.png");
             }
             else if (lbl27.Text == "Kazakistan")
             {
                 pb27.ImageLocation = ("Kazakhstan.png");
             }
             else if (lbl27.Text == "Polonya")
             {
                 pb27.ImageLocation = ("Poland.png");
             }
             else if (lbl27.Text == "Ukrayna")
             {
                 pb27.ImageLocation = ("Ukraine.png");
             }
             else if (lbl27.Text == "Bosna Hersek")
             {
                 pb27.ImageLocation = ("Bosnia-and-Herzegovina.png");
             }
             else if (lbl27.Text == "Danimarka")
             {
                 pb27.ImageLocation = ("Denmark.png");
             }
             else if (lbl27.Text == "İzlanda")
             {
                 pb27.ImageLocation = ("Ireland.png");
             }
             else if (lbl27.Text == "Fransa")
             {
                 pb27.ImageLocation = ("France.png");
             }
             else if (lbl27.Text == "Çek Cumhuriyeti")
             {
                 pb27.ImageLocation = ("Czech-Republic.png");
             }
             else if (lbl27.Text == "İsviçre")
             {
                 pb27.ImageLocation = ("Switzerland.png");
             }
             else if (lbl27.Text == "İtalya")
             {
                 pb27.ImageLocation = ("Italy.png");
             }
             else if (lbl27.Text == "Avusturya")
             {
                 pb27.ImageLocation = ("Austria.png");
             }
             else if (lbl27.Text == "Slovakya")
             {
                 pb27.ImageLocation = ("Slovakia.png");
             }
             else if (lbl27.Text == "Hırvatistan")
             {
                 pb27.ImageLocation = ("Crotia.png");
             }
             else if (lbl27.Text == "İspanya")
             {
                 pb27.ImageLocation = ("Spain.png");
             }
             else if (lbl27.Text == "Galler")
             {
                 pb27.ImageLocation = ("Wales.png");
             }
             else if (lbl27.Text == "İngiltere")
             {
                 pb27.ImageLocation = ("England.png");
             }
             else if (lbl27.Text == "Portekiz")
             {
                 pb27.ImageLocation = ("Portugal.png");
             }
             else if (lbl27.Text == "Litvanya")
             {
                 pb27.ImageLocation = ("Lithuania.png");
             }
             else if (lbl27.Text == "Hollanda")
             {
                 pb27.ImageLocation = ("Holland.png");
             }
             else if (lbl27.Text == "Belçika")
             {
                 pb27.ImageLocation = ("Belgium.png");
             }
             else if (lbl27.Text == "Almanya")
             {
                 pb27.ImageLocation = ("Germany.png");
             }
             else if (lbl27.Text == "Türkiye")
             {
                 pb27.ImageLocation = ("Turkey.png");
             }
            /////////
             if (lbl28.Text == "İsrail")
             {
                 pb28.ImageLocation = ("Israel.png");
             }
             else if (lbl28.Text == "İsveç")
             {
                 pb28.ImageLocation = ("Sweden.png");
             }
             else if (lbl28.Text == "Macaristan")
             {
                 pb28.ImageLocation = ("Hungary.png");
             }
             else if (lbl28.Text == "Romanya")
             {
                 pb28.ImageLocation = ("Romania.png");
             }
             else if (lbl28.Text == "Sırbistan")
             {
                 pb28.ImageLocation = ("Serbia.png");
             }
             else if (lbl28.Text == "Brezilya")
             {
                 pb28.ImageLocation = ("Brazil.png");
             }
             else if (lbl28.Text == "Estonya")
             {
                 pb28.ImageLocation = ("Estonia.png");
             }
             else if (lbl28.Text == "Slovenya")
             {
                 pb28.ImageLocation = ("Slovenia.png");
             }
             else if (lbl28.Text == "Norveç")
             {
                 pb28.ImageLocation = ("Norway.png");
             }
             else if (lbl28.Text == "Azerbaycan")
             {
                 pb28.ImageLocation = ("Azerbaijan.png");
             }
             else if (lbl28.Text == "Kazakistan")
             {
                 pb28.ImageLocation = ("Kazakhstan.png");
             }
             else if (lbl28.Text == "Polonya")
             {
                 pb28.ImageLocation = ("Poland.png");
             }
             else if (lbl28.Text == "Ukrayna")
             {
                 pb28.ImageLocation = ("Ukraine.png");
             }
             else if (lbl28.Text == "Bosna Hersek")
             {
                 pb28.ImageLocation = ("Bosnia-and-Herzegovina.png");
             }
             else if (lbl28.Text == "Danimarka")
             {
                 pb28.ImageLocation = ("Denmark.png");
             }
             else if (lbl28.Text == "İzlanda")
             {
                 pb28.ImageLocation = ("Ireland.png");
             }
             else if (lbl28.Text == "Fransa")
             {
                 pb28.ImageLocation = ("France.png");
             }
             else if (lbl28.Text == "Çek Cumhuriyeti")
             {
                 pb28.ImageLocation = ("Czech-Republic.png");
             }
             else if (lbl28.Text == "İsviçre")
             {
                 pb28.ImageLocation = ("Switzerland.png");
             }
             else if (lbl28.Text == "İtalya")
             {
                 pb28.ImageLocation = ("Italy.png");
             }
             else if (lbl28.Text == "Avusturya")
             {
                 pb28.ImageLocation = ("Austria.png");
             }
             else if (lbl28.Text == "Slovakya")
             {
                 pb28.ImageLocation = ("Slovakia.png");
             }
             else if (lbl28.Text == "Hırvatistan")
             {
                 pb28.ImageLocation = ("Crotia.png");
             }
             else if (lbl28.Text == "İspanya")
             {
                 pb28.ImageLocation = ("Spain.png");
             }
             else if (lbl28.Text == "Galler")
             {
                 pb28.ImageLocation = ("Wales.png");
             }
             else if (lbl28.Text == "İngiltere")
             {
                 pb28.ImageLocation = ("England.png");
             }
             else if (lbl28.Text == "Portekiz")
             {
                 pb28.ImageLocation = ("Portugal.png");
             }
             else if (lbl28.Text == "Litvanya")
             {
                 pb28.ImageLocation = ("Lithuania.png");
             }
             else if (lbl28.Text == "Hollanda")
             {
                 pb28.ImageLocation = ("Holland.png");
             }
             else if (lbl28.Text == "Belçika")
             {
                 pb28.ImageLocation = ("Belgium.png");
             }
             else if (lbl28.Text == "Almanya")
             {
                 pb28.ImageLocation = ("Germany.png");
             }
             else if (lbl28.Text == "Türkiye")
             {
                 pb28.ImageLocation = ("Turkey.png");
             }
            //////////
             if (lbl29.Text == "İsrail")
             {
                 pb29.ImageLocation = ("Israel.png");
             }
             else if (lbl29.Text == "İsveç")
             {
                 pb29.ImageLocation = ("Sweden.png");
             }
             else if (lbl29.Text == "Macaristan")
             {
                 pb29.ImageLocation = ("Hungary.png");
             }
             else if (lbl29.Text == "Romanya")
             {
                 pb29.ImageLocation = ("Romania.png");
             }
             else if (lbl29.Text == "Sırbistan")
             {
                 pb29.ImageLocation = ("Serbia.png");
             }
             else if (lbl29.Text == "Brezilya")
             {
                 pb29.ImageLocation = ("Brazil.png");
             }
             else if (lbl29.Text == "Estonya")
             {
                 pb29.ImageLocation = ("Estonia.png");
             }
             else if (lbl29.Text == "Slovenya")
             {
                 pb29.ImageLocation = ("Slovenia.png");
             }
             else if (lbl29.Text == "Norveç")
             {
                 pb29.ImageLocation = ("Norway.png");
             }
             else if (lbl29.Text == "Azerbaycan")
             {
                 pb29.ImageLocation = ("Azerbaijan.png");
             }
             else if (lbl29.Text == "Kazakistan")
             {
                 pb29.ImageLocation = ("Kazakhstan.png");
             }
             else if (lbl29.Text == "Polonya")
             {
                 pb29.ImageLocation = ("Poland.png");
             }
             else if (lbl29.Text == "Ukrayna")
             {
                 pb29.ImageLocation = ("Ukraine.png");
             }
             else if (lbl29.Text == "Bosna Hersek")
             {
                 pb29.ImageLocation = ("Bosnia-and-Herzegovina.png");
             }
             else if (lbl29.Text == "Danimarka")
             {
                 pb29.ImageLocation = ("Denmark.png");
             }
             else if (lbl29.Text == "İzlanda")
             {
                 pb29.ImageLocation = ("Ireland.png");
             }
             else if (lbl29.Text == "Fransa")
             {
                 pb29.ImageLocation = ("France.png");
             }
             else if (lbl29.Text == "Çek Cumhuriyeti")
             {
                 pb29.ImageLocation = ("Czech-Republic.png");
             }
             else if (lbl29.Text == "İsviçre")
             {
                 pb29.ImageLocation = ("Switzerland.png");
             }
             else if (lbl29.Text == "İtalya")
             {
                 pb29.ImageLocation = ("Italy.png");
             }
             else if (lbl29.Text == "Avusturya")
             {
                 pb29.ImageLocation = ("Austria.png");
             }
             else if (lbl29.Text == "Slovakya")
             {
                 pb29.ImageLocation = ("Slovakia.png");
             }
             else if (lbl29.Text == "Hırvatistan")
             {
                 pb29.ImageLocation = ("Crotia.png");
             }
             else if (lbl29.Text == "İspanya")
             {
                 pb29.ImageLocation = ("Spain.png");
             }
             else if (lbl29.Text == "Galler")
             {
                 pb29.ImageLocation = ("Wales.png");
             }
             else if (lbl29.Text == "İngiltere")
             {
                 pb29.ImageLocation = ("England.png");
             }
             else if (lbl29.Text == "Portekiz")
             {
                 pb29.ImageLocation = ("Portugal.png");
             }
             else if (lbl29.Text == "Litvanya")
             {
                 pb29.ImageLocation = ("Lithuania.png");
             }
             else if (lbl29.Text == "Hollanda")
             {
                 pb29.ImageLocation = ("Holland.png");
             }
             else if (lbl29.Text == "Belçika")
             {
                 pb29.ImageLocation = ("Belgium.png");
             }
             else if (lbl29.Text == "Almanya")
             {
                 pb29.ImageLocation = ("Germany.png");
             }
             else if (lbl29.Text == "Türkiye")
             {
                 pb29.ImageLocation = ("Turkey.png");
             }
            ////
             if (lbl30.Text == "İsrail")
             {
                 pb30.ImageLocation = ("Israel.png");
             }
             else if (lbl30.Text == "İsveç")
             {
                 pb30.ImageLocation = ("Sweden.png");
             }
             else if (lbl30.Text == "Macaristan")
             {
                 pb30.ImageLocation = ("Hungary.png");
             }
             else if (lbl30.Text == "Romanya")
             {
                 pb30.ImageLocation = ("Romania.png");
             }
             else if (lbl30.Text == "Sırbistan")
             {
                 pb30.ImageLocation = ("Serbia.png");
             }
             else if (lbl30.Text == "Brezilya")
             {
                 pb30.ImageLocation = ("Brazil.png");
             }
             else if (lbl30.Text == "Estonya")
             {
                 pb30.ImageLocation = ("Estonia.png");
             }
             else if (lbl30.Text == "Slovenya")
             {
                 pb30.ImageLocation = ("Slovenia.png");
             }
             else if (lbl30.Text == "Norveç")
             {
                 pb30.ImageLocation = ("Norway.png");
             }
             else if (lbl30.Text == "Azerbaycan")
             {
                 pb30.ImageLocation = ("Azerbaijan.png");
             }
             else if (lbl30.Text == "Kazakistan")
             {
                 pb30.ImageLocation = ("Kazakhstan.png");
             }
             else if (lbl30.Text == "Polonya")
             {
                 pb30.ImageLocation = ("Poland.png");
             }
             else if (lbl30.Text == "Ukrayna")
             {
                 pb30.ImageLocation = ("Ukraine.png");
             }
             else if (lbl30.Text == "Bosna Hersek")
             {
                 pb30.ImageLocation = ("Bosnia-and-Herzegovina.png");
             }
             else if (lbl30.Text == "Danimarka")
             {
                 pb30.ImageLocation = ("Denmark.png");
             }
             else if (lbl30.Text == "İzlanda")
             {
                 pb30.ImageLocation = ("Ireland.png");
             }
             else if (lbl30.Text == "Fransa")
             {
                 pb30.ImageLocation = ("France.png");
             }
             else if (lbl30.Text == "Çek Cumhuriyeti")
             {
                 pb30.ImageLocation = ("Czech-Republic.png");
             }
             else if (lbl30.Text == "İsviçre")
             {
                 pb30.ImageLocation = ("Switzerland.png");
             }
             else if (lbl30.Text == "İtalya")
             {
                 pb30.ImageLocation = ("Italy.png");
             }
             else if (lbl30.Text == "Avusturya")
             {
                 pb30.ImageLocation = ("Austria.png");
             }
             else if (lbl30.Text == "Slovakya")
             {
                 pb30.ImageLocation = ("Slovakia.png");
             }
             else if (lbl30.Text == "Hırvatistan")
             {
                 pb30.ImageLocation = ("Crotia.png");
             }
             else if (lbl30.Text == "İspanya")
             {
                 pb30.ImageLocation = ("Spain.png");
             }
             else if (lbl30.Text == "Galler")
             {
                 pb30.ImageLocation = ("Wales.png");
             }
             else if (lbl30.Text == "İngiltere")
             {
                 pb30.ImageLocation = ("England.png");
             }
             else if (lbl30.Text == "Portekiz")
             {
                 pb30.ImageLocation = ("Portugal.png");
             }
             else if (lbl30.Text == "Litvanya")
             {
                 pb30.ImageLocation = ("Lithuania.png");
             }
             else if (lbl30.Text == "Hollanda")
             {
                 pb30.ImageLocation = ("Holland.png");
             }
             else if (lbl30.Text == "Belçika")
             {
                 pb30.ImageLocation = ("Belgium.png");
             }
             else if (lbl30.Text == "Almanya")
             {
                 pb30.ImageLocation = ("Germany.png");
             }
             else if (lbl30.Text == "Türkiye")
             {
                 pb30.ImageLocation = ("Turkey.png");
             }
            /////
             if (lbl31.Text == "İsrail")
             {
                 pb31.ImageLocation = ("Israel.png");
             }
             else if (lbl31.Text == "İsveç")
             {
                 pb31.ImageLocation = ("Sweden.png");
             }
             else if (lbl31.Text == "Macaristan")
             {
                 pb31.ImageLocation = ("Hungary.png");
             }
             else if (lbl31.Text == "Romanya")
             {
                 pb31.ImageLocation = ("Romania.png");
             }
             else if (lbl31.Text == "Sırbistan")
             {
                 pb31.ImageLocation = ("Serbia.png");
             }
             else if (lbl31.Text == "Brezilya")
             {
                 pb31.ImageLocation = ("Brazil.png");
             }
             else if (lbl31.Text == "Estonya")
             {
                 pb31.ImageLocation = ("Estonia.png");
             }
             else if (lbl31.Text == "Slovenya")
             {
                 pb31.ImageLocation = ("Slovenia.png");
             }
             else if (lbl31.Text == "Norveç")
             {
                 pb31.ImageLocation = ("Norway.png");
             }
             else if (lbl31.Text == "Azerbaycan")
             {
                 pb31.ImageLocation = ("Azerbaijan.png");
             }
             else if (lbl31.Text == "Kazakistan")
             {
                 pb31.ImageLocation = ("Kazakhstan.png");
             }
             else if (lbl31.Text == "Polonya")
             {
                 pb31.ImageLocation = ("Poland.png");
             }
             else if (lbl31.Text == "Ukrayna")
             {
                 pb31.ImageLocation = ("Ukraine.png");
             }
             else if (lbl31.Text == "Bosna Hersek")
             {
                 pb31.ImageLocation = ("Bosnia-and-Herzegovina.png");
             }
             else if (lbl31.Text == "Danimarka")
             {
                 pb31.ImageLocation = ("Denmark.png");
             }
             else if (lbl31.Text == "İzlanda")
             {
                 pb31.ImageLocation = ("Ireland.png");
             }
             else if (lbl31.Text == "Fransa")
             {
                 pb31.ImageLocation = ("France.png");
             }
             else if (lbl31.Text == "Çek Cumhuriyeti")
             {
                 pb31.ImageLocation = ("Czech-Republic.png");
             }
             else if (lbl31.Text == "İsviçre")
             {
                 pb31.ImageLocation = ("Switzerland.png");
             }
             else if (lbl31.Text == "İtalya")
             {
                 pb31.ImageLocation = ("Italy.png");
             }
             else if (lbl31.Text == "Avusturya")
             {
                 pb31.ImageLocation = ("Austria.png");
             }
             else if (lbl31.Text == "Slovakya")
             {
                 pb31.ImageLocation = ("Slovakia.png");
             }
             else if (lbl31.Text == "Hırvatistan")
             {
                 pb31.ImageLocation = ("Crotia.png");
             }
             else if (lbl31.Text == "İspanya")
             {
                 pb31.ImageLocation = ("Spain.png");
             }
             else if (lbl31.Text == "Galler")
             {
                 pb31.ImageLocation = ("Wales.png");
             }
             else if (lbl31.Text == "İngiltere")
             {
                 pb31.ImageLocation = ("England.png");
             }
             else if (lbl31.Text == "Portekiz")
             {
                 pb31.ImageLocation = ("Portugal.png");
             }
             else if (lbl31.Text == "Litvanya")
             {
                 pb31.ImageLocation = ("Lithuania.png");
             }
             else if (lbl31.Text == "Hollanda")
             {
                 pb31.ImageLocation = ("Holland.png");
             }
             else if (lbl31.Text == "Belçika")
             {
                 pb31.ImageLocation = ("Belgium.png");
             }
             else if (lbl31.Text == "Almanya")
             {
                 pb31.ImageLocation = ("Germany.png");
             }
             else if (lbl31.Text == "Türkiye")
             {
                 pb31.ImageLocation = ("Turkey.png");
             }
            ////////
             if (lbl32.Text == "İsrail")
             {
                 pb32.ImageLocation = ("Israel.png");
             }
             else if (lbl32.Text == "İsveç")
             {
                 pb32.ImageLocation = ("Sweden.png");
             }
             else if (lbl32.Text == "Macaristan")
             {
                 pb32.ImageLocation = ("Hungary.png");
             }
             else if (lbl32.Text == "Romanya")
             {
                 pb32.ImageLocation = ("Romania.png");
             }
             else if (lbl32.Text == "Sırbistan")
             {
                 pb32.ImageLocation = ("Serbia.png");
             }
             else if (lbl32.Text == "Brezilya")
             {
                 pb32.ImageLocation = ("Brazil.png");
             }
             else if (lbl32.Text == "Estonya")
             {
                 pb32.ImageLocation = ("Estonia.png");
             }
             else if (lbl32.Text == "Slovenya")
             {
                 pb32.ImageLocation = ("Slovenia.png");
             }
             else if (lbl32.Text == "Norveç")
             {
                 pb32.ImageLocation = ("Norway.png");
             }
             else if (lbl32.Text == "Azerbaycan")
             {
                 pb32.ImageLocation = ("Azerbaijan.png");
             }
             else if (lbl32.Text == "Kazakistan")
             {
                 pb32.ImageLocation = ("Kazakhstan.png");
             }
             else if (lbl32.Text == "Polonya")
             {
                 pb32.ImageLocation = ("Poland.png");
             }
             else if (lbl32.Text == "Ukrayna")
             {
                 pb32.ImageLocation = ("Ukraine.png");
             }
             else if (lbl32.Text == "Bosna Hersek")
             {
                 pb32.ImageLocation = ("Bosnia-and-Herzegovina.png");
             }
             else if (lbl32.Text == "Danimarka")
             {
                 pb32.ImageLocation = ("Denmark.png");
             }
             else if (lbl32.Text == "İzlanda")
             {
                 pb32.ImageLocation = ("Ireland.png");
             }
             else if (lbl32.Text == "Fransa")
             {
                 pb32.ImageLocation = ("France.png");
             }
             else if (lbl32.Text == "Çek Cumhuriyeti")
             {
                 pb32.ImageLocation = ("Czech-Republic.png");
             }
             else if (lbl32.Text == "İsviçre")
             {
                 pb32.ImageLocation = ("Switzerland.png");
             }
             else if (lbl32.Text == "İtalya")
             {
                 pb32.ImageLocation = ("Italy.png");
             }
             else if (lbl32.Text == "Avusturya")
             {
                 pb32.ImageLocation = ("Austria.png");
             }
             else if (lbl32.Text == "Slovakya")
             {
                 pb32.ImageLocation = ("Slovakia.png");
             }
             else if (lbl32.Text == "Hırvatistan")
             {
                 pb32.ImageLocation = ("Crotia.png");
             }
             else if (lbl32.Text == "İspanya")
             {
                 pb32.ImageLocation = ("Spain.png");
             }
             else if (lbl32.Text == "Galler")
             {
                 pb32.ImageLocation = ("Wales.png");
             }
             else if (lbl32.Text == "İngiltere")
             {
                 pb32.ImageLocation = ("England.png");
             }
             else if (lbl32.Text == "Portekiz")
             {
                 pb32.ImageLocation = ("Portugal.png");
             }
             else if (lbl32.Text == "Litvanya")
             {
                 pb32.ImageLocation = ("Lithuania.png");
             }
             else if (lbl32.Text == "Hollanda")
             {
                 pb32.ImageLocation = ("Holland.png");
             }
             else if (lbl32.Text == "Belçika")
             {
                 pb32.ImageLocation = ("Belgium.png");
             }
             else if (lbl32.Text == "Almanya")
             {
                 pb32.ImageLocation = ("Germany.png");
             }
             else if (lbl32.Text == "Türkiye")
             {
                 pb32.ImageLocation = ("Turkey.png");
             }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
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
                if (sayac==16)
                {
                    button17.Visible = Enabled;
                }
          
           
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            Form2 form2 = new Form2();
            form3.lbl1.Text = listBox1.Items[0].ToString();
            form3.lbl2.Text = listBox1.Items[1].ToString();
            form3.lbl3.Text = listBox1.Items[2].ToString();
            form3.lbl4.Text = listBox1.Items[3].ToString();
            form3.lbl5.Text = listBox1.Items[4].ToString();
            form3.lbl6.Text = listBox1.Items[5].ToString();
            form3.lbl7.Text = listBox1.Items[6].ToString();
            form3.lbl8.Text = listBox1.Items[7].ToString();
            form3.lbl9.Text = listBox1.Items[8].ToString();
            form3.lbl10.Text = listBox1.Items[9].ToString();
            form3.lbl11.Text = listBox1.Items[10].ToString();
            form3.lbl12.Text = listBox1.Items[11].ToString();
            form3.lbl13.Text = listBox1.Items[12].ToString();
            form3.lbl14.Text = listBox1.Items[13].ToString();
            form3.lbl15.Text = listBox1.Items[14].ToString();
            form3.lbl16.Text = listBox1.Items[15].ToString();
            
            
            form3.Show();
            this.Close();
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
            if (sayac == 16)
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
            if (sayac == 16)
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
            if (sayac == 16)
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
            if (sayac == 16)
            {
                button17.Visible = Enabled;
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
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
            if (sayac == 16)
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
            if (sayac == 16)
            {
                button17.Visible = Enabled;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            sayac++;
            button9.Enabled = false;
            Random number = new Random();
            txt17.Text = number.Next(0, 5).ToString();

            txt18.Text = number.Next(0, 5).ToString();


            int a, b;

            a = Convert.ToInt32(txt17.Text);
            b = Convert.ToInt32(txt18.Text);
            if (a > b)
            {
                label9.Text = lbl17.Text + " Kazandı!";
                listBox1.Items.Add(lbl17.Text);
                button10.Enabled = true;
            }
            else if (b > a)
            {
                label9.Text = lbl18.Text + " Kazandı!";
                listBox1.Items.Add(lbl18.Text);
                button10.Enabled = true;
            }
            else if (txt17.Text == txt18.Text)
            {
                button9.Text = "Tekrar Oyna";
                button9.Enabled = true;
                sayac--;
            }
            if (sayac == 16)
            {
                button17.Visible = Enabled;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            sayac++;
            button10.Enabled = false;
            Random number = new Random();
            txt19.Text = number.Next(0, 5).ToString();

            txt20.Text = number.Next(0, 5).ToString();


            int a, b;

            a = Convert.ToInt32(txt19.Text);
            b = Convert.ToInt32(txt20.Text);
            if (a > b)
            {
                label10.Text = lbl19.Text + " Kazandı!";
                listBox1.Items.Add(lbl19.Text);
                button11.Enabled = true;
            }
            else if (b > a)
            {
                label10.Text = lbl20.Text + " Kazandı!";
                listBox1.Items.Add(lbl20.Text); 
                button11.Enabled = true;
            }
            else if (txt19.Text == txt20.Text)
            {
                button10.Text = "Tekrar Oyna";
                button10.Enabled = true;
                sayac--;
            }
            if (sayac == 16)
            {
                button17.Visible = Enabled;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            sayac++;
            button11.Enabled = false;
            Random number = new Random();
            txt21.Text = number.Next(0, 5).ToString();

            txt22.Text = number.Next(0, 5).ToString();


            int a, b;

            a = Convert.ToInt32(txt21.Text);
            b = Convert.ToInt32(txt22.Text);
            if (a > b)
            {
                label11.Text = lbl21.Text + " Kazandı!";
                listBox1.Items.Add(lbl21.Text);
                button12.Enabled = true;
            }
            else if (b > a)
            {
                label11.Text = lbl22.Text + " Kazandı!";
                listBox1.Items.Add(lbl22.Text);
                button12.Enabled = true;
            }
            else if (txt21.Text == txt22.Text)
            {
                button11.Text = "Tekrar Oyna";
                button11.Enabled = true;
                sayac--;
            }
            if (sayac == 16)
            {
                button17.Visible = Enabled;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            sayac++;
            button12.Enabled = false;
            Random number = new Random();
            txt23.Text = number.Next(0, 5).ToString();

            txt24.Text = number.Next(0, 5).ToString();


            int a, b;

            a = Convert.ToInt32(txt23.Text);
            b = Convert.ToInt32(txt24.Text);
            if (a > b)
            {
                label12.Text = lbl23.Text + " Kazandı!";
                listBox1.Items.Add(lbl23.Text);
                button13.Enabled = true;
            }
            else if (b > a)
            {
                label12.Text = lbl24.Text + " Kazandı!";
                listBox1.Items.Add(lbl24.Text);
                button13.Enabled = true;
            }
            else if (txt23.Text == txt24.Text)
            {
                button12.Text = "Tekrar Oyna";
                button12.Enabled = true;
                sayac--;
            }
            if (sayac == 16)
            {
                button17.Visible = Enabled;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            sayac++;
            button13.Enabled = false;
            Random number = new Random();
            txt25.Text = number.Next(0, 5).ToString();

            txt26.Text = number.Next(0, 5).ToString();


            int a, b;

            a = Convert.ToInt32(txt25.Text);
            b = Convert.ToInt32(txt26.Text);
            if (a > b)
            {
                label13.Text = lbl25.Text + " Kazandı!";
                listBox1.Items.Add(lbl25.Text);
                button14.Enabled = true;
            }
            else if (b > a)
            {
                label13.Text = lbl26.Text + " Kazandı!";
                listBox1.Items.Add(lbl26.Text);
                button14.Enabled = true;
            }
            else if (txt25.Text == txt26.Text)
            {
                button13.Text = "Tekrar Oyna";
                button13.Enabled = true;
                sayac--;
            }
            if (sayac == 16)
            {
                button17.Visible = Enabled;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            sayac++;
            button14.Enabled = false;
            Random number = new Random();
            txt27.Text = number.Next(0, 5).ToString();

            txt28.Text = number.Next(0, 5).ToString();


            int a, b;

            a = Convert.ToInt32(txt27.Text);
            b = Convert.ToInt32(txt28.Text);
            if (a > b)
            {
                label14.Text = lbl27.Text + " Kazandı!";
                listBox1.Items.Add(lbl27.Text);
                button15.Enabled = true;
            }
            else if (b > a)
            {
                label14.Text = lbl28.Text + " Kazandı!";
                listBox1.Items.Add(lbl28.Text);
                button15.Enabled = true;
            }
            else if (txt27.Text == txt28.Text)
            {
                button14.Text = "Tekrar Oyna";
                button14.Enabled = true;
                sayac--;
            }
            if (sayac == 16)
            {
                button17.Visible = Enabled;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            sayac++;
            button15.Enabled = false;
            Random number = new Random();
            txt29.Text = number.Next(0, 5).ToString();

            txt30.Text = number.Next(0, 5).ToString();


            int a, b;

            a = Convert.ToInt32(txt29.Text);
            b = Convert.ToInt32(txt30.Text);
            if (a > b)
            {
                label15.Text = lbl29.Text + " Kazandı!";
                listBox1.Items.Add(lbl29.Text);
                button16.Enabled = true;
            }
            else if (b > a)
            {
                label15.Text = lbl30.Text + " Kazandı!";
                listBox1.Items.Add(lbl30.Text);
                button16.Enabled = true;
            }
            else if (txt29.Text == txt30.Text)
            {
                button15.Text = "Tekrar Oyna";
                button15.Enabled = true;
                sayac--;
            }
            if (sayac == 16)
            {
                button17.Visible = Enabled;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            sayac++;
            button16.Enabled = false;
            Random number = new Random();
            txt31.Text = number.Next(0, 5).ToString();

            txt32.Text = number.Next(0, 5).ToString();


            int a, b;

            a = Convert.ToInt32(txt31.Text);
            b = Convert.ToInt32(txt32.Text);
            if (a > b)
            {
                label16.Text = lbl31.Text + " Kazandı!";
                listBox1.Items.Add(lbl31.Text);
            }
            else if (b > a)
            {
                label16.Text = lbl32.Text + " Kazandı!";
                listBox1.Items.Add(lbl32.Text);
            }
            else if (txt31.Text == txt32.Text)
            {
                button16.Text = "Tekrar Oyna";
                button16.Enabled = true;
                sayac--;
            }
            if (sayac == 16)
            {
                button17.Visible = Enabled;
            }
        }

      
    

      
    }
}
