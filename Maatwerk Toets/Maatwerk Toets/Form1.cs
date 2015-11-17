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
        }

        private void VerversScherm()
        {
            lbVerhuringen.Items.Clear();
            foreach (Verhuur v in administratie.Verhuringen)
            {
                lbVerhuringen.Items.Add(v);
            }
            lbVerkopen.Items.Clear();
            foreach (Verkoop k in administratie.Verkopen)
            {
                lbVerkopen.Items.Add(k);
            }
        }

        private void btnNieuweVerhuringToevoegen_Click(object sender, EventArgs e)
        {
            DateTime tijdstip = dtpNieuweVerhuringTijdstip.Value.Date;
            int urenVerhuurd = Convert.ToInt32(nudNieuweVerhuringUren.Value);
            if (cbNieuweVerhuring.Text == "Feestzaal")
            {
                administratie.VoegToe(new Feestzaal(tijdstip, urenVerhuurd));
            }
            else if (cbNieuweVerhuring.Text == "Sportzaal")
            {
                administratie.VoegToe(new Sportzaal(tijdstip, urenVerhuurd));
            }
            else if (cbNieuweVerhuring.Text == "Vergaderruimte")
            {
                administratie.VoegToe(new Vergaderruimte(tijdstip, urenVerhuurd));
            }

            VerversScherm();
        }

        private void btnNieuweVerkoopToevoegen_Click(object sender, EventArgs e)
        {
            int aantal = Convert.ToInt32(nudNieuweVerkoopAantal.Value);
            if (cbNieuweVerkoop.Text == "Sterkedrank")
            {
                administratie.VoegToe(new Sterkedrank(aantal));
            }
            else if (cbNieuweVerkoop.Text == "Broodje")
            {
                administratie.VoegToe(new Broodje(aantal));
            }
            else if (cbNieuweVerkoop.Text == "Frisdrank")
            {
                administratie.VoegToe(new Frisdrank(aantal));
            }

            VerversScherm();
        }

        private void btnOverzichtDatumbereik_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Join(Environment.NewLine, administratie.Overzicht(dtpOverzichtVan.Value, dtpOverzichtTot.Value)));
        }

        private void btnOverzichtExporteer_Click(object sender, EventArgs e)
        {

        }
    }
}
