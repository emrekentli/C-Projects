using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace OtoparkProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public OleDbConnection bag = new OleDbConnection("");
        public OleDbCommand kmt = new OleDbCommand();
        public OleDbDataAdapter adtr = new OleDbDataAdapter();
        public DataSet dtst = new DataSet();

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pgbar1.Value < 100)
            {
                pgbar1.Value = pgbar1.Value + 5;
            }
            else
            {
                timer1.Enabled = false;
                Kullanıcı_Girişi giris = new Kullanıcı_Girişi();
                giris.Show();
                this.Visible = false;
            }
        }
    }
}
