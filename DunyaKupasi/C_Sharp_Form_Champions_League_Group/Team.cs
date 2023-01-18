using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C_Sharp_Form_Champions_League_Group
{
    class Takim
    {
        private string takimIsmi;

        public Takim(string isim)
        {
            takimIsmi = isim;
            
        }

        public string TeamName 
        {
            get
            {
                return takimIsmi;
            }
            set
            {
                takimIsmi = value;
            }
        }

       

        public override string ToString()
        {
            return takimIsmi;
        }
    }
}
