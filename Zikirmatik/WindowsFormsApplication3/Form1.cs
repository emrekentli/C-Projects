using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        Int32 zs;
        Int32 zt;
        public Form1()
        {
            InitializeComponent();
        }

      

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            button4.Text =" ";
         zs=0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


          

            private void label1_Click(object sender, EventArgs e)
            {

            }

            private void button3_Click(object sender, EventArgs e)
            {
                label1.Text = " ";
                zs = 0;
                zt = 0;
                label2.Text = " ";
            }

            private void button4_Click_1(object sender, EventArgs e)
            {
                zs++;
                if (zs % 33 == 0)
                {
                    label1.ForeColor = Color.Red;
                    zt++;
                    label2.Text = zt.ToString();
                }
                label1.Text = zs.ToString();
                if (zs % 33 == 1)
                {
                    label1.ForeColor = Color.Black;
                    
                }
                
            }

            private void radioButton3_CheckedChanged(object sender, EventArgs e)
            {
                 
            SoundPlayer ses = new SoundPlayer();
            string dizin = Application.StartupPath + "\\song.wav";
            ses.SoundLocation = dizin;
            ses.Play();
      
            }

            private void radioButton2_CheckedChanged(object sender, EventArgs e)
            {
          
            SoundPlayer ses = new SoundPlayer();
            string dizin = Application.StartupPath + "\\sonng.wav";
            ses.SoundLocation = dizin;
            ses.Play();
        
            }

            private void radioButton1_CheckedChanged(object sender, EventArgs e)
            {
                SoundPlayer ses = new SoundPlayer();
                string dizin = Application.StartupPath + "\\sonnng.wav";
                ses.SoundLocation = dizin;
                ses.Play();
            }

        }
    }

