using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maatwerk_Toets
{
    public partial class Form1 : Form
    {
        private Administratie administratie;
        public Form1()
        {
            InitializeComponent();
            administratie = new Administratie();
            administratie.VoegToe(new Feestzaal(dtpNieuweVerhuringTijdstip.Value.Date, 2));
            VerversScherm();
        }

        private void VerversScherm()
        {
            lbVerhuringen.Items.Clear();
            foreach (Verhuur v in administratie.verhuringen)
            {
                lbVerhuringen.Items.Add(v);
            }
        }

        private void btnNieuweVerhuringToevoegen_Click(object sender, EventArgs e)
        {
            DateTime tijdstip = dtpNieuweVerhuringTijdstip.Value.Date;
            int urenVerhuurd = Convert.ToInt32(nudNieuweVerhuringUren.Value);
            Verhuur verhuur = new Verhuur(tijdstip, urenVerhuurd);
            VerversScherm();
        }
    }
}
