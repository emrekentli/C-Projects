using System;

using System.Collections.Generic;

using System.ComponentModel;

using System.Data;

using System.Drawing;

using System.Linq;

using System.Text;

using System.Windows.Forms;



namespace WindowsFormsApplication3

{

    

    public partial class Form3 : Form

    {

        /// <summary>

        /// //////////////

        /// 

        /// 

        /// 

        /// /////Verileri alıyoruz

        /// 

        /// 

        /// 

        /// 

        /// 

        /// </summary>

        public static  TextBox mail;

        public static TextBox sifre;

        public static ComboBox smtp;



       



        public Form3()

        {

            InitializeComponent();

        }

      

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text + textBox2.Text == "")
            {



                MessageBox.Show("Boş alan bırakmayınız..!");





            }



            else
            {





                mailgonder gonder = new mailgonder();

                mail = textBox1;

                sifre = textBox2;

                smtp = comboBox1;







                gonder.ShowDialog();

            }
        }

    }

}