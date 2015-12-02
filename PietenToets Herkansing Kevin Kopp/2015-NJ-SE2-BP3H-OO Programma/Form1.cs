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

        public Form1()
        {
            InitializeComponent();

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
                    gemeenten.Add(gemeente);
                }

                reader.Close();
                file.Close();

                lbGemeenten.Items.Add(gemeenten);
            }
            catch (IOException)
            {
                MessageBox.Show("File is niet bereikbaar");
            }
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            Provincie provincie = new Provincie(cbProvincie.SelectedItem.ToString());
            Gemeente gemeente = new Gemeente(tbGemeente.Text, provincie, Convert.ToInt32(nudAantalKinderen.Value), Convert.ToInt32(nudX.Value), Convert.ToInt32(nudY.Value));
            gemeenten.Add(gemeente);
        }
    }
}
