using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int giorni, prezzostagione, prezzostanza, prezzotot;

       

        private void btn_1_Click(object sender, EventArgs e)
        {
         

        }

        private void cmb_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_1.SelectedIndex == 0)
            {
                prezzostagione = 15;
            }
            else if (cmb_1.SelectedIndex == 1)
            {
                prezzostagione = 20;
            }
            else if (cmb_1.SelectedIndex == 2)
            {
                prezzostagione = 25;
            }
            else
            {
                prezzostagione = 0;
            }
        }


    }
}

