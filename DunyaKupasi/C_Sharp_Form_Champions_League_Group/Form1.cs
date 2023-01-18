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
    public partial class Form1 : Form
    {
        List<Takim> takimlar;
        Form2 form2 = new Form2();
        List<ListBox> torbalar = new List<ListBox>();
        List<ListBox> gruplar = new List<ListBox>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Yeni takımları oluşturmak için bir tane Team sınıfından nesne oluşturalım
            Takim yeniTakim = null;

            //oluşturduğum takımları listede tutmak için bir tane Team tipinde jenerik liste oluşturalım
            takimlar = new List<Takim>();

            //Burada takımları ve ülkeri ile birlikten takımlar listesine ekleyelim

            yeniTakim = new Takim("İsrail");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("İsveç");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Macaristan");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Romanya");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Sırbistan");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Brezilya");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Estonya");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Slovenya");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Norveç");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Azerbaycan");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Kazakistan");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Polonya");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Ukrayna");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Bosna Hersek");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Danimarka");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("İzlanda");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Fransa");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Çek Cumhuriyeti");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("İsviçre");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("İtalya");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Avusturya");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Slovakya");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Hırvatistan");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("İspanya");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Galler");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("İngiltere");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Portekiz");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Litvanya");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Hollanda");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Belçika");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Almanya");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Türkiye");
            takimlar.Add(yeniTakim);
        }

        private void btnTorbalariOlustur_Click(object sender, EventArgs e)
        {
            btnTorbalariOlustur.Enabled = false;
            btnGruplariOlustur.Enabled = true;
            Random rastgele = new Random();

            List<int> secilenTakimlar = new List<int>();

            for (int i = 0; i < takimlar.Count; i++)
            {
                int secilenTakim = rastgele.Next(0, takimlar.Count);

                if (secilenTakimlar.Contains(secilenTakim))
                {
                    i--;
                }
                 

                else
                {
                    secilenTakimlar.Add(secilenTakim);
                }
            }

            for (int i = 0; i < secilenTakimlar.Count; i++)
            {
                if(i<8)
                {
                    lstTorba1.Items.Add(takimlar[secilenTakimlar[i]]);
                }
                else if (i < 16)
                {
                    lstTorba2.Items.Add(takimlar[secilenTakimlar[i]]);
                }
                else if (i < 24)
                {
                    lstTorba3.Items.Add(takimlar[secilenTakimlar[i]]);
                }
                else
                {
                    lstTorba4.Items.Add(takimlar[secilenTakimlar[i]]);
                }
            }

            torbalar.Add(lstTorba1);
            torbalar.Add(lstTorba2);
            torbalar.Add(lstTorba3);
            torbalar.Add(lstTorba4);

             gruplar.Add(lstGrup1);
            gruplar.Add(lstGrup2);
            gruplar.Add(lstGrup3);
            gruplar.Add(lstGrup4);
            gruplar.Add(lstGrup5);
            gruplar.Add(lstGrup6);
            gruplar.Add(lstGrup7);
            gruplar.Add(lstGrup8);
        }

        private void btnGruplariOlustur_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            btnGruplariOlustur.Enabled = false;
            Random rastgele = new Random();

            List<int> secilenTakimlar = new List<int>();

            for (int j = 0; j < 4; j++)
            {
                secilenTakimlar.Clear();

                for (int i = 0; i < 8; i++)
                {
                    int secilenTakim = rastgele.Next(0, takimlar.Count / 4);

                    if (secilenTakimlar.Contains(secilenTakim))
                    {
                        i--;
                    }
                    else
                    {
                        secilenTakimlar.Add(secilenTakim);
                    }
                }
                    lstGrup1.Items.Add(torbalar[j].Items[secilenTakimlar[0]] as Takim);
                    lstGrup2.Items.Add(torbalar[j].Items[secilenTakimlar[1]] as Takim);
                    lstGrup3.Items.Add(torbalar[j].Items[secilenTakimlar[2]] as Takim);
                    lstGrup4.Items.Add(torbalar[j].Items[secilenTakimlar[3]] as Takim);
                    lstGrup5.Items.Add(torbalar[j].Items[secilenTakimlar[4]] as Takim);
                    lstGrup6.Items.Add(torbalar[j].Items[secilenTakimlar[5]] as Takim);
                    lstGrup7.Items.Add(torbalar[j].Items[secilenTakimlar[6]] as Takim);
                    lstGrup8.Items.Add(torbalar[j].Items[secilenTakimlar[7]] as Takim);
                
             
            }
        }

        private void grouper7_Load(object sender, EventArgs e)
        {

        }

        private void Button1(object sender, EventArgs e)
        {
           
            





            ///////// /////////
            ///////// /////////
            ///////// /////////
            
            form2.lbl1.Text = lstGrup1.Items[0].ToString();
            form2.lbl2.Text = lstGrup1.Items[1].ToString();
            form2.lbl3.Text = lstGrup1.Items[2].ToString();
            form2.lbl4.Text = lstGrup1.Items[3].ToString();
            //
            form2.lbl5.Text = lstGrup2.Items[0].ToString();
            form2.lbl6.Text = lstGrup2.Items[1].ToString();
            form2.lbl7.Text = lstGrup2.Items[2].ToString();
            form2.lbl8.Text = lstGrup2.Items[3].ToString();
            // 
            form2.lbl9.Text = lstGrup3.Items[0].ToString();
            form2.lbl10.Text = lstGrup3.Items[1].ToString();
            form2.lbl11.Text = lstGrup3.Items[2].ToString();
            form2.lbl12.Text = lstGrup3.Items[3].ToString();
            //
            form2.lbl13.Text = lstGrup4.Items[0].ToString();
            form2.lbl14.Text = lstGrup4.Items[1].ToString();
            form2.lbl15.Text = lstGrup4.Items[2].ToString();
            form2.lbl16.Text = lstGrup4.Items[3].ToString();
            //
            form2.lbl17.Text = lstGrup5.Items[0].ToString();
            form2.lbl18.Text = lstGrup5.Items[1].ToString();
            form2.lbl19.Text = lstGrup5.Items[2].ToString();
            form2.lbl20.Text = lstGrup5.Items[3].ToString();
            //
            form2.lbl21.Text = lstGrup6.Items[0].ToString();
            form2.lbl22.Text = lstGrup6.Items[1].ToString();
            form2.lbl23.Text = lstGrup6.Items[2].ToString();
            form2.lbl24.Text = lstGrup6.Items[3].ToString();
            // 
            form2.lbl25.Text = lstGrup7.Items[0].ToString();
            form2.lbl26.Text = lstGrup7.Items[1].ToString();
            form2.lbl27.Text = lstGrup7.Items[2].ToString();
            form2.lbl28.Text = lstGrup7.Items[3].ToString();
            //
            form2.lbl29.Text = lstGrup8.Items[0].ToString();
            form2.lbl30.Text = lstGrup8.Items[1].ToString();
            form2.lbl31.Text = lstGrup8.Items[2].ToString();
            form2.lbl32.Text = lstGrup8.Items[3].ToString();
   
   
            form2.Show();
            this.Hide();
        }
    }
}
