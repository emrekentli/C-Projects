using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace WindowsFormsApplication1
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Form7.sql == "Gmail")
            {
                SmtpClient sc = new SmtpClient();
                sc.Port = 587;
                sc.Host = "smtp.gmail.com";
                sc.EnableSsl = true;

                string kime = textBox1.Text;
                string konu = "Şifreniz";
                string icerik = "Merhaba " + Form7.isim + " \n" + "Şifreniz : " + Form7.sifre + "'dır. \n İyi günler dileriz.";

                sc.Credentials = new NetworkCredential("ztbankasi@gmail.com", "1231233100e");
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("ztbankasi@gmail.com", "Ziraat Bankası");
                mail.To.Add(kime);
                mail.Subject = konu;
                mail.IsBodyHtml = true;
                mail.Body = icerik;
                sc.Send(mail);
                MessageBox.Show("Şifreniz e-posta adresinize gönderilmiştir.");
            }

            else if (Form7.sql == "Hotmail")
            {
                 SmtpClient sc = new SmtpClient();
                sc.Port = 587;
                sc.Host = "smtp.live.com";
                sc.EnableSsl = true;

                string kime = textBox1.Text;
                string konu = "Şifreniz";
                string icerik = "Merhaba " + Form7.isim + " \n" + "Şifreniz : " + Form7.sifre + "'dır. \n İyi günler dileriz.";

                sc.Credentials = new NetworkCredential("ZiraatB@outlook.com", "1231233100e");
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("ZiraatB@outlook.com", "Ziraat Bankası");
                mail.To.Add(kime);
                mail.Subject = konu;
                mail.IsBodyHtml = true;
                mail.Body = icerik;
                sc.Send(mail);
                MessageBox.Show("Şifreniz e-posta adresinize gönderilmiştir.");
            }
            else
            {
                MessageBox.Show("Bir hata oluştu. Geri dönün ve e-postanızı kontrol edin.");
            }
            
        }
    }
}
