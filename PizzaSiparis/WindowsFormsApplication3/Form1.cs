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
    public partial class Form1 : Form
    {
        double fiyat = 3;
        Int32 adet;
        public Form1()
        {
            
            
            InitializeComponent();
        }

        private void bxboyut_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

       

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtadet.Text = "1";
            comboBox1.Text = comboBox1.Items[1].ToString();
            rdbtnkck.Checked = false;
            rdbtnorta.Checked = false;
            rdbtnbyk.Checked = false;
            rdbtnincecik.Checked = false;

        }

       
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
  
        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Text = " ";
            lblfiyat.Text = " ";
            button1.Enabled = true;
            button2.Enabled = false;
            rdbtnkck.Enabled = true;
            rdbtnorta.Enabled = true;
            rdbtnbyk.Enabled = true;
            rdbtnincecik.Enabled = true;
            rdbtnince.Enabled = true;
            rdbtntiporta.Enabled = true;
            rdbtnkalin.Enabled = true;
            chckboxaci.Enabled = true;
            chckboxdmts.Enabled = true;
            chckboxbiber.Enabled = true;
            chckboxsck.Enabled = true;
            chckboxpeynir.Enabled = true;
            chckboxzeytin.Enabled = true;
            chckboxmoz.Enabled = true;
            chckboxsalam.Enabled = true;
            chckboxkasar.Enabled = true;
            chckboxfanta.Enabled = true;
            chckboxlmn.Enabled = true;
            chckboxpepsi.Enabled = true;
            chckboxayran.Enabled = true;
            chckboxicetea.Enabled = true;
            chckboxtavuk.Enabled = true;
            chckboxsosis.Enabled = true;
            chckboxmantar.Enabled = true;
            fiyat = 3;
            //////////////////////////////
            rdbtnkck.Checked = false;
            rdbtnorta.Checked = false;
            rdbtnbyk.Checked = false;
            rdbtnincecik.Checked = false;
            rdbtnince.Checked = false;
            rdbtntiporta.Checked = false;
            rdbtnkalin.Checked = false;
            chckboxaci.Checked = false;
            chckboxdmts.Checked = false;
            chckboxbiber.Checked = false;
            chckboxsck.Checked = false;
            chckboxpeynir.Checked = false;
            chckboxzeytin.Checked = false;
            chckboxmoz.Checked = false;
            chckboxsalam.Checked  = false;
            chckboxkasar.Checked = false;
            chckboxfanta.Checked = false;
            chckboxlmn.Checked = false;
            chckboxpepsi.Checked = false;
            chckboxayran.Checked = false;
            chckboxicetea.Checked = false;
            chckboxtavuk.Checked = false;
            chckboxsosis.Checked = false;
            chckboxmantar.Checked = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
            button1.Enabled = false;
            button2.Enabled = true;
            rdbtnkck.Enabled = false;
            rdbtnorta.Enabled = false;
            rdbtnbyk.Enabled = false;
            rdbtnincecik.Enabled = false;
            rdbtnince.Enabled = false;
            rdbtntiporta.Enabled = false;
            rdbtnkalin.Enabled = false;
            chckboxaci.Enabled = false;
            chckboxdmts.Enabled = false;
            chckboxbiber.Enabled = false;
            chckboxsck.Enabled = false;
            chckboxpeynir.Enabled = false;
            chckboxzeytin.Enabled = false;
            chckboxmoz.Enabled = false;
            chckboxsalam.Enabled = false;
            chckboxkasar.Enabled = false;
            chckboxfanta.Enabled = false;
            chckboxlmn.Enabled = false;
            chckboxpepsi.Enabled = false;
            chckboxayran.Enabled = false;
            chckboxicetea.Enabled = false;
            chckboxtavuk.Enabled = false;
            chckboxsosis.Enabled = false;
            chckboxmantar.Enabled = false;

            if (rdbtnkck.Checked == false && rdbtnorta.Checked == false && rdbtnbyk.Checked == false)
            {

                MessageBox.Show("Lütfen Hamur Boyutunu Seçin.");
                comboBox1.Text = " ";
                lblfiyat.Text = " ";
                button1.Enabled = true;
                button2.Enabled = false;
                rdbtnkck.Enabled = true;
                rdbtnorta.Enabled = true;
                rdbtnbyk.Enabled = true;
                rdbtnincecik.Enabled = true;
                rdbtnince.Enabled = true;
                rdbtntiporta.Enabled = true;
                rdbtnkalin.Enabled = true;
                chckboxaci.Enabled = true;
                chckboxdmts.Enabled = true;
                chckboxbiber.Enabled = true;
                chckboxsck.Enabled = true;
                chckboxpeynir.Enabled = true;
                chckboxzeytin.Enabled = true;
                chckboxmoz.Enabled = true;
                chckboxsalam.Enabled = true;
                chckboxkasar.Enabled = true;
                chckboxfanta.Enabled = true;
                chckboxlmn.Enabled = true;
                chckboxpepsi.Enabled = true;
                chckboxayran.Enabled = true;
                chckboxicetea.Enabled = true;
                chckboxtavuk.Enabled = true;
                chckboxsosis.Enabled = true;
                chckboxmantar.Enabled = true;
                fiyat = 3;
                //////////////////////////////
                rdbtnkck.Checked = false;
                rdbtnorta.Checked = false;
                rdbtnbyk.Checked = false;
                rdbtnincecik.Checked = false;
                rdbtnince.Checked = false;
                rdbtntiporta.Checked = false;
                rdbtnkalin.Checked = false;
                chckboxaci.Checked = false;
                chckboxdmts.Checked = true;
                chckboxbiber.Checked = true;
                chckboxsck.Checked = true;
                chckboxpeynir.Checked = true;
                chckboxzeytin.Checked = false;
                chckboxmoz.Checked = false;
                chckboxsalam.Checked = false;
                chckboxkasar.Checked = false;
                chckboxfanta.Checked = false;
                chckboxlmn.Checked = false;
                chckboxpepsi.Checked = false;
                chckboxayran.Checked = false;
                chckboxicetea.Checked = false;
                chckboxtavuk.Checked = false;
                chckboxsosis.Checked = false;
                chckboxmantar.Checked = false;

            }

            if (rdbtnincecik.Checked == false && rdbtnince.Checked == false && rdbtntiporta.Checked == false && rdbtnbyk.Checked == false)
            {

                MessageBox.Show("Lütfen Hamur Tipini Seçin.");
                comboBox1.Text = " ";
                lblfiyat.Text = " ";
                button1.Enabled = true;
                button2.Enabled = false;
                rdbtnkck.Enabled = true;
                rdbtnorta.Enabled = true;
                rdbtnbyk.Enabled = true;
                rdbtnincecik.Enabled = true;
                rdbtnince.Enabled = true;
                rdbtntiporta.Enabled = true;
                rdbtnkalin.Enabled = true;
                chckboxaci.Enabled = true;
                chckboxdmts.Enabled = true;
                chckboxbiber.Enabled = true;
                chckboxsck.Enabled = true;
                chckboxpeynir.Enabled = true;
                chckboxzeytin.Enabled = true;
                chckboxmoz.Enabled = true;
                chckboxsalam.Enabled = true;
                chckboxkasar.Enabled = true;
                chckboxfanta.Enabled = true;
                chckboxlmn.Enabled = true;
                chckboxpepsi.Enabled = true;
                chckboxayran.Enabled = true;
                chckboxicetea.Enabled = true;
                chckboxtavuk.Enabled = true;
                chckboxsosis.Enabled = true;
                chckboxmantar.Enabled = true;
                fiyat = 3;
                //////////////////////////////
                rdbtnkck.Checked = false;
                rdbtnorta.Checked = false;
                rdbtnbyk.Checked = false;
                rdbtnincecik.Checked = false;
                rdbtnince.Checked = false;
                rdbtntiporta.Checked = false;
                rdbtnkalin.Checked = false;
                chckboxaci.Checked = false;
                chckboxdmts.Checked = true;
                chckboxbiber.Checked = true;
                chckboxsck.Checked = true;
                chckboxpeynir.Checked = true;
                chckboxzeytin.Checked = false;
                chckboxmoz.Checked = false;
                chckboxsalam.Checked = false;
                chckboxkasar.Checked = false;
                chckboxfanta.Checked = false;
                chckboxlmn.Checked = false;
                chckboxpepsi.Checked = false;
                chckboxayran.Checked = false;
                chckboxicetea.Checked = false;
                chckboxtavuk.Checked = false;
                chckboxsosis.Checked = false;
                chckboxmantar.Checked = false;

            }


            if (comboBox1.Text=="" ||comboBox1.Text==" ")
            {

                MessageBox.Show("Lütfen Herhangi Bir Kampanya Seçin.");
                comboBox1.Text = " ";
                lblfiyat.Text = " ";
                button1.Enabled = true;
                button2.Enabled = false;
                rdbtnkck.Enabled = true;
                rdbtnorta.Enabled = true;
                rdbtnbyk.Enabled = true;
                rdbtnincecik.Enabled = true;
                rdbtnince.Enabled = true;
                rdbtntiporta.Enabled = true;
                rdbtnkalin.Enabled = true;
                chckboxaci.Enabled = true;
                chckboxdmts.Enabled = true;
                chckboxbiber.Enabled = true;
                chckboxsck.Enabled = true;
                chckboxpeynir.Enabled = true;
                chckboxzeytin.Enabled = true;
                chckboxmoz.Enabled = true;
                chckboxsalam.Enabled = true;
                chckboxkasar.Enabled = true;
                chckboxfanta.Enabled = true;
                chckboxlmn.Enabled = true;
                chckboxpepsi.Enabled = true;
                chckboxayran.Enabled = true;
                chckboxicetea.Enabled = true;
                chckboxtavuk.Enabled = true;
                chckboxsosis.Enabled = true;
                chckboxmantar.Enabled = true;
                fiyat = 3;
                //////////////////////////////
                rdbtnkck.Checked = false;
                rdbtnorta.Checked = false;
                rdbtnbyk.Checked = false;
                rdbtnincecik.Checked = false;
                rdbtnince.Checked = false;
                rdbtntiporta.Checked = false;
                rdbtnkalin.Checked = false;
                chckboxaci.Checked = false;
                chckboxdmts.Checked = true;
                chckboxbiber.Checked = true;
                chckboxsck.Checked = true;
                chckboxpeynir.Checked = true;
                chckboxzeytin.Checked = false;
                chckboxmoz.Checked = false;
                chckboxsalam.Checked = false;
                chckboxkasar.Checked = false;
                chckboxfanta.Checked = false;
                chckboxlmn.Checked = false;
                chckboxpepsi.Checked = false;
                chckboxayran.Checked = false;
                chckboxicetea.Checked = false;
                chckboxtavuk.Checked = false;
                chckboxsosis.Checked = false;
                chckboxmantar.Checked = false;

            }
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (chckboxdmts.Checked == true)
            {
                fiyat = fiyat + 1.5;
            }
            if (chckboxsck.Checked == true)
            {
                fiyat = fiyat + 3.5;
            }
            if (chckboxbiber.Checked == true)
            {
                fiyat = fiyat + 3;
            }
            if (chckboxpeynir.Checked == true)
            {
                fiyat = fiyat + 3;
            }
            ////////////
            if (chckboxzeytin.Checked == true)
            {
                fiyat = fiyat + 2;
            }
            if (chckboxmoz.Checked == true)
            {
                fiyat = fiyat + 3;
            }
            if (chckboxsalam.Checked == true)
            {
                fiyat = fiyat + 3;
            }
            if (chckboxkasar.Checked == true)
            {
                fiyat = fiyat + 5;
            }
            if (chckboxtavuk.Checked == true)
            {
                fiyat = fiyat + 3;
            }
            if (chckboxsosis.Checked == true)
            {
                fiyat = fiyat + 3;
            }
            if (chckboxmantar.Checked == true)
            {
                fiyat = fiyat + 1;
            }

            /////
            if (chckboxayran.Checked == true)
            {

                fiyat = fiyat + 1;
            }
            if (chckboxpepsi.Checked == true)
            {

                fiyat = fiyat + 1;
            }
            if (chckboxlmn.Checked == true)
            {

                fiyat = fiyat + 1;
            }
            if (chckboxfanta.Checked == true)
            {

                fiyat = fiyat + 1;
            }
            if (chckboxicetea.Checked == true)
            {

                fiyat = fiyat + 1;
            }

            ////

            ///////
            if (rdbtnkck.Checked == true)
            {

                fiyat = fiyat + 4;
            }
            if (rdbtnorta.Checked == true)
            {

                fiyat = fiyat + 7;
            }
            if (rdbtnbyk.Checked == true)
            {

                fiyat = fiyat + 10;
            }

            /////
            if (rdbtnincecik.Checked == true)
            {

                fiyat = fiyat + 2;
            }
            if (rdbtnince.Checked == true)
            {

                fiyat = fiyat + 3;
            }
            if (rdbtntiporta.Checked == true)
            {

                fiyat = fiyat + 5;
            }
            if (rdbtnkalin.Checked == true)
            {
                fiyat = fiyat + 7;
            }

            if (chckboxaci.Checked == true)
            {
                fiyat = fiyat + 1;
            }
           
                adet = Convert.ToInt32(txtadet.Text);
                lblfiyat.Text = (adet * fiyat).ToString();
                if (comboBox1.Text == "Kampanya (Orta Boy Alana Orta Boy + Pepsi)")
                {

                    MessageBox.Show("Kampanyamızdan yararlandığınız için teşekkürler.");
                }

                DialogResult dialog = new DialogResult();
                dialog = MessageBox.Show("Siparişi Tamamlamak İstiyor musunuz ?", "Uyarı", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    Form1 formkapa = new Form1();
                    formkapa.Close();
                    Form5 form = new Form5();
                    form.Show();
                    this.Hide();
                }

                if (dialog == DialogResult.No)
                {
                    MessageBox.Show("Sipariş Verme Ekranına Geri Dönüldü!");

                }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 show = new Form2();
            show.ShowDialog();﻿
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.Text== "Kampanya (Orta Boy Alana Orta Boy + Pepsi)" )
            {
            
                  rdbtnkck.Checked = false;
            rdbtnorta.Checked = false;
            rdbtnbyk.Checked = false;
            rdbtnincecik.Checked = false;
            rdbtnince.Checked = false;
            rdbtntiporta.Checked = false;
            rdbtnkalin.Checked = false;
            chckboxaci.Checked = false;
            chckboxzeytin.Checked = false;
            chckboxmoz.Checked = false;
            chckboxsalam.Checked  = false;
            chckboxkasar.Checked = false;
            chckboxfanta.Checked = false;
            chckboxlmn.Checked = false;
            chckboxpepsi.Checked = false;
            chckboxayran.Checked = false;
            chckboxicetea.Checked = false;
            chckboxtavuk.Checked = false;
            chckboxsosis.Checked = false;
            chckboxmantar.Checked = false;
                ////////
            rdbtnorta.Checked = true;
            rdbtntiporta.Checked = true;
            rdbtnkck.Enabled = false;
            rdbtnbyk.Enabled = false;
            rdbtnincecik.Enabled = false;
            rdbtnince.Enabled = false;
            rdbtnkalin.Enabled = false;

        }
            else
                if (comboBox1.Text == "Kendin YAP!")
            { 
            
                   
          
            rdbtnkck.Enabled = true;
            rdbtnorta.Enabled = true;
            rdbtnbyk.Enabled = true;
            rdbtnincecik.Enabled = true;
            rdbtnince.Enabled = true;
            rdbtntiporta.Enabled = true;
            rdbtnkalin.Enabled = true;
            chckboxaci.Enabled = true;
            chckboxdmts.Enabled = true;
            chckboxbiber.Enabled = true;
            chckboxsck.Enabled = true;
            chckboxpeynir.Enabled = true;
            chckboxzeytin.Enabled = true;
            chckboxmoz.Enabled = true;
            chckboxsalam.Enabled = true;
            chckboxkasar.Enabled = true;
            chckboxfanta.Enabled = true;
            chckboxlmn.Enabled = true;
            chckboxpepsi.Enabled = true;
            chckboxayran.Enabled = true;
            chckboxicetea.Enabled = true;
            chckboxtavuk.Enabled = true;
            chckboxsosis.Enabled = true;
            chckboxmantar.Enabled = true;
            fiyat = 3;
            //////////////////////////////
            rdbtnkck.Checked = false;
            rdbtnorta.Checked = false;
            rdbtnbyk.Checked = false;
            rdbtnincecik.Checked = false;
            rdbtnince.Checked = false;
            rdbtntiporta.Checked = false;
            rdbtnkalin.Checked = false;
            chckboxaci.Checked = false;
            chckboxdmts.Checked = true;
            chckboxbiber.Checked = true;
            chckboxsck.Checked = true;
            chckboxpeynir.Checked = true;
            chckboxzeytin.Checked = false;
            chckboxmoz.Checked = false;
            chckboxsalam.Checked  = false;
            chckboxkasar.Checked = false;
            chckboxfanta.Checked = false;
            chckboxlmn.Checked = false;
            chckboxpepsi.Checked = false;
            chckboxayran.Checked = false;
            chckboxicetea.Checked = false;
            chckboxtavuk.Checked = false;
            chckboxsosis.Checked = false;
            chckboxmantar.Checked = false;
       

            }
            
            
          
        }
     

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form3 show = new Form3();
            show.ShowDialog();﻿
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/pamukpizza"); ;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start("http://pamukpizza.tr.gg/");
        }

        private void txtadet_TextChanged(object sender, EventArgs e)
        {

        }

      
       
  
        }

      
}
