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
    public partial class Form5 : Form
    {
        public static int sayac = 0;
        public Form5()
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

            }
            else if (b > a)
            {

                label1.Text = lbl2.Text + " Kazandı!";
                listBox1.Items.Add(lbl2.Text);

            }
            else if (txt1.Text == txt2.Text)
            {
                button1.Text = "Tekrar Oyna";
                button1.Enabled = true;
                sayac--;
            }
            if (sayac == 2)
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
            }
            else if (b > a)
            {
                label2.Text = lbl4.Text + " Kazandı!";
                listBox1.Items.Add(lbl4.Text);
            }
            else if (txt3.Text == txt4.Text)
            {
                button2.Text = "Tekrar Oyna";
                button2.Enabled = true;
                sayac--;
            }
            if (sayac == 2)
            {
                button17.Visible = Enabled;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            Form5 form5= new Form5();
            form6.lbl1.Text = listBox1.Items[0].ToString();
            form6.lbl2.Text = listBox1.Items[1].ToString();
           
            form6.Show();
            this.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
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
        }
    }
}
