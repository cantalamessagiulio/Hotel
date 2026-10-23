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





        private void btn_1_Click(object sender, EventArgs e)
        {
            int giorni, errore;
            float prezzotot;
            giorni = Convert.ToInt32(txt_1);
            prezzotot = 0;
            errore = 1;

            if (cmb_1.SelectedIndex == 0)
            {
                prezzotot = prezzotot + 0;
            }
            else if (cmb_1.SelectedIndex == 1)
            {
                prezzotot = prezzotot + 15 * giorni;
            }
            else if (cmb_1.SelectedIndex == 2)
            {
                prezzotot = prezzotot + 30 * giorni;
            }
            else
            {
                errore = 0;
            }

            if (chb_1.Checked)
            {
                prezzotot = prezzotot + 5 * giorni;
            }
            if (cmb_2.SelectedIndex == 0)
            {
                prezzotot = prezzotot + 0;
            }
            else if (cmb_2.SelectedIndex == 1)
            {
                prezzotot = prezzotot + 15 * giorni;
            }
            else if (cmb_2.SelectedIndex == 2)
            {
                prezzotot = prezzotot + 30 * giorni;
            }
            else
            {
                errore = 0;
            }
            if (giorni > 7)
            {
                prezzotot = prezzotot - prezzotot * 35 / 100;
            }
            else if (giorni > 3)
            {
                prezzotot = prezzotot - prezzotot * 25 / 100;
            }
            if (errore == 0)
            {
                MessageBox.Show("Una o più caselle non sono state selezionate o i varoli inseriti non sono validi");
            }
            else
            {
                MessageBox.Show("Il prezzo totale è " + prezzotot);
            }
        }





        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nel reparto stagione inserire in quale stagione è desiderato andare." +
                "" +
                "Nel reparto camera inserire in che tipo di camera alloggiare." +
                "" +
                "Nel reparto numero di giorni inserire quanti giorni si vuole alloggiare, se si alloggia dai 3-7 giorni si avrà uno sconto del 25% sul totale e se si alloggia per più di 7 giorni si avrà uno sconto del 35%." +
                "" +
                "Inserire se si vuole aggiungere il parcheggio.");
        }



    }
}

