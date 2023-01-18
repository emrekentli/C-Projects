
using System;

using System.Collections.Generic;

using System.ComponentModel;

using System.Data;

using System.Drawing;

using System.Linq;

using System.Text;

using System.Windows.Forms;

using System.Net;

using System.Net.Mail;

namespace WindowsFormsApplication3
{

    public partial class mailgonder : Form
    {

        public mailgonder()
        {

            InitializeComponent();

        }



        private void button1_Click(object sender, EventArgs e)
        {


            try
            {

                button1.Text = "Mail Gönderiliyor..!";

                string smtp = "";



     
             if (Form3.smtp.Text == "Hotmail")
                {


                    smtp = "smtp.live.com";
                   
                }










                SmtpClient client = new SmtpClient(smtp, 587);

                client.Credentials = new NetworkCredential(Form3.mail.Text, Form3.sifre.Text);

                MailMessage mesaj = new MailMessage();

                mesaj.To.Add(new MailAddress(textBox1.Text));

                mesaj.From = new MailAddress(textBox2.Text);

                mesaj.Subject = textBox2.Text;

                mesaj.Body = textBox1.Text;

                client.EnableSsl = true;

                client.Send(mesaj);

                MessageBox.Show("Mesajınız gönderildi");

                button1.Text = "Mail Gönderildi..!";

            }

            catch (Exception ex)
            {



                button1.Text = "Mail Gönderme Başarısız..!";

                MessageBox.Show(ex.ToString());







            }




        }

        private void button1_Click_1(object sender, EventArgs e)
        {


            try
            {

                button1.Text = "Mail Gönderiliyor..!";

                string smtp = "";



                if (Form3.smtp.Text == "Gmail")
                {
                    smtp = "smtp.gmail.com";
                }
                else if (Form3.smtp.Text == "Hotmail")
                {


                    smtp = "smtp.live.com";
                }










                SmtpClient client = new SmtpClient(smtp, 587);

                client.Credentials = new NetworkCredential(Form3.mail.Text, Form3.sifre.Text);

                MailMessage mesaj = new MailMessage();

                mesaj.To.Add(new MailAddress("pamukpizza@hotmail.com"));

                mesaj.From = new MailAddress(Form3.mail.Text);

              

                mesaj.Subject = textBox3.Text;

                mesaj.Body =textBox4.Text;

                client.EnableSsl = true;

                client.Send(mesaj);

                MessageBox.Show("Mesajınız gönderildi");

                button1.Text = "Mail Gönderildi..!";

            }

            catch (Exception ex)
            {



                button1.Text = "Mail Gönderme Başarısız..!";

                MessageBox.Show(ex.ToString());







            }
        }

        private void mailgonder_Load(object sender, EventArgs e)
        {
            textBox2.Text = Form3.mail.Text;

            textBox1.Text = "PamukPizza@hotmail.com";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }

}