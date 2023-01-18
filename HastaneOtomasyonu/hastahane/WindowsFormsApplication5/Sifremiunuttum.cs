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
using System.Data.OleDb;

namespace WindowsFormsApplication5
{
    public partial class Sifremiunuttum : Form
    {
        public Sifremiunuttum()
        {
            InitializeComponent();
        }
        public OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db.accdb");
        public OleDbCommand komut = new OleDbCommand();
        public OleDbDataAdapter adtr = new OleDbDataAdapter();
        public DataSet ds = new DataSet();
        public OleDbDataReader dr;

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Gmail")
            {
            
                    baglanti.Open();
                    OleDbCommand cmd = new OleDbCommand("Select * From Uyeler where TC='" + maskedtxtTC.Text + "'", baglanti);
                    OleDbDataReader dr = cmd.ExecuteReader();
                    if(dr.Read())
                    {
                        
                            SmtpClient smtpserver = new SmtpClient();
                            MailMessage mail = new MailMessage();

                            String mailadresin = ("pamukhastanesii@gmail.com"); // msn
                            String mailsifren = ("1231233100e"); // sifre
                            String smptsrvr = "smtp.gmail.com"; // dokunma
                            String kime = (dr["Eposta"].ToString());
                            String konu = ("Parola Hatırlatma"); //konu
                            String yazi = ("Sayın " + dr["Adı"].ToString() + " " + dr["Soyadı"].ToString() + "\nParolanız = " + dr["Parola"].ToString());  // metin

                            smtpserver.Credentials = new NetworkCredential(mailadresin, mailsifren);
                            smtpserver.Port = 587;
                            smtpserver.Host = smptsrvr;
                            smtpserver.EnableSsl = true;
                            mail.From = new MailAddress(mailadresin);
                            mail.To.Add(kime);
                            mail.Subject = konu;
                            mail.Body = yazi;
                            smtpserver.Send(mail);
                            MessageBox.Show("Mailinize gelen Şifreyle Hesabınıza giriş yapınız.\nGüvenliğiniz İçin Ardından Lütfen şifrenizi değiştiriniz.");
                       
                    baglanti.Close();
                }
                
            }

            else if (comboBox1.Text == "Hotmail")
            {

                baglanti.Open();
                OleDbCommand cmd = new OleDbCommand("Select * From Uyeler where TC='" + maskedtxtTC.Text + "'", baglanti);
                OleDbDataReader dr = cmd.ExecuteReader();
               
                if(dr.Read())
                {

                    SmtpClient smtpserver = new SmtpClient();
                    MailMessage mail = new MailMessage();

                    String mailadresin = ("pamukhastanesii@hotmail.com"); // msn
                    String mailsifren = ("1231233100e"); // sifre
                    String smptsrvr = "smtp.live.com"; // dokunma
                    String kime = (dr["Eposta"].ToString());
                    String konu = ("Parola Hatırlatma"); //konu
                    String yazi = ("Sayın " + dr["Adı"].ToString() + " " + dr["Soyadı"].ToString() + "\nParolanız = " + dr["Parola"].ToString());  // metin

                    smtpserver.Credentials = new NetworkCredential(mailadresin, mailsifren);
                    smtpserver.Port = 587;
                    smtpserver.Host = smptsrvr;
                    smtpserver.EnableSsl = true;
                    mail.From = new MailAddress(mailadresin);
                    mail.To.Add(kime);
                    mail.Subject = konu;
                    mail.Body = yazi;
                    smtpserver.Send(mail);
                    MessageBox.Show("Mailinize gelen Şifreyle Hesabınıza giriş yapınız.\nGüvenliğiniz İçin Ardından Lütfen şifrenizi değiştiriniz.");







                    baglanti.Close();
                }

            }
           
        }

        private void Sifremiunuttum_Load(object sender, EventArgs e)
        {

        }
    }
}
