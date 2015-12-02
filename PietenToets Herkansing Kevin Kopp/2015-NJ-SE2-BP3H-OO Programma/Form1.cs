using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2015_NJ_SE2_BP3H_OO_Programma
{
    public partial class Form1 : Form
    {
        public List<Gemeente> gemeenten = new List<Gemeente>();
        public List<Provincie> provincies;
        Administratie admin = new Administratie();

        public Form1()
        {
            InitializeComponent();
            provincies = new List<Provincie>();

            FileStream file;
            StreamReader reader;

            string fileContents = "";
            try
            {
                file = new FileStream(@"C:\Users\Kevin\Documents\GitHub\Maatwerk-Kevin\PietenToets Herkansing Kevin Kopp\2015-NJ-SE2-BP3H-OO Programma\coordinaten.csv", FileMode.Open);
                reader = new StreamReader(file);

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    fileContents = fileContents.Split(';').ToString();
                    //gemeenten.Add(gemeente);
                }

                reader.Close();
                file.Close();

                lbGemeenten.Items.Add(gemeenten);
            }
            catch (IOException)
            {
                MessageBox.Show("File is niet bereikbaar");
            }

            Provincie provincie1 = new Provincie("Drenthe");
            Provincie provincie2 = new Provincie("Flevoland");
            Provincie provincie3 = new Provincie("Fiesland");
            Provincie provincie4 = new Provincie("Gelderland");
            Provincie provincie5 = new Provincie("Groningen");
            Provincie provincie6 = new Provincie("Limburg");
            Provincie provincie7 = new Provincie("Noord-Brabant");
            Provincie provincie8 = new Provincie("Noord-Holland");
            Provincie provincie9 = new Provincie("Overijssel");
            Provincie provincie10 = new Provincie("Utrecht");
            Provincie provincie11 = new Provincie("Zeeland");
            Provincie provincie12 = new Provincie("Zuid-Holland");

            lbProvincies.Items.Add(provincie1);
            lbProvincies.Items.Add(provincie2);
            lbProvincies.Items.Add(provincie3);
            lbProvincies.Items.Add(provincie4);
            lbProvincies.Items.Add(provincie5);
            lbProvincies.Items.Add(provincie6);
            lbProvincies.Items.Add(provincie7);
            lbProvincies.Items.Add(provincie8);
            lbProvincies.Items.Add(provincie9);
            lbProvincies.Items.Add(provincie10);
            lbProvincies.Items.Add(provincie11);
            lbProvincies.Items.Add(provincie12);
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            Provincie provincie = new Provincie(cbProvincie.SelectedItem.ToString());
            Gemeente gemeente = new Gemeente(tbGemeente.Text, provincie, Convert.ToInt32(nudAantalKinderen.Value), Convert.ToInt32(nudX.Value), Convert.ToInt32(nudY.Value));
            gemeenten.Add(gemeente);
        }
    }
}
