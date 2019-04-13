using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormSynthese
{
    public partial class Synthese : Form
    {
        string[] tabTypes = new string[5] {"Mensuelle", "Bimestrielle", "Trimestrielle", "Semestrielle", "Anuelle"};
        double periode, capital, tauxPeriodique, tauxAnnuel, nbRemboursement;

        public Synthese()
        {
            InitializeComponent();
            paybackLabel.Font = new Font(Label.DefaultFont, FontStyle.Bold);
            foreach (var item in tabTypes)
            {
                listBox.Items.Add(item);
            }
            Initialisation();
        }

        void Initialisation()
        {
            monthLabel.Text = monthBar.Value.ToString();
            listBox.SelectedIndex = 0;
            taux7.Checked = true;
            CapitalBox.Text = "";
            CapitalBox.MaxLength = 10;
            nbPayback.Text = "";
            nbPayback.ForeColor = Color.Red;
            montantLabel.Text = "";
            montantLabel.ForeColor = Color.Red;
        }

        void NombreRemboursement()
        {
            int period = Periodiciter();
            monthLabel.Text = monthBar.Value.ToString();
            nbPayback.Text = (int.Parse(monthLabel.Text) / period).ToString();
        }

        string MontantARembourser()
        {
            if (CapitalBox.Text != "" && monthLabel.Text != "1")
            {
                capital = double.Parse(CapitalBox.Text);
                tauxPeriodique = (tauxAnnuel / 100) / periode;
                nbRemboursement = double.Parse(nbPayback.Text);
                double montant = (capital*(tauxPeriodique/(1-Math.Pow((1+tauxPeriodique), -nbRemboursement))));
                montant = Math.Round(montant, 2);
                return montant.ToString();
            }
            else
            {
                return "";
            }
        }

        int Periodiciter()
        {
            if (listBox.SelectedItem != null)
            {
                string type = listBox.SelectedItem.ToString();
                switch (type)
                {
                    case "Mensuelle":
                        monthBar.SmallChange = 1;
                        monthBar.LargeChange = 1;
                        periode = 12;
                        return 1;
                    case "Bimestrielle":
                        monthBar.SmallChange = 2;
                        monthBar.LargeChange = 2;
                        periode = 6;
                        return 2;
                    case "Trimestrielle":
                        monthBar.SmallChange = 3;
                        monthBar.LargeChange = 3;
                        periode = 4;
                        return 3;
                    case "Semestrielle":
                        monthBar.SmallChange = 6;
                        monthBar.LargeChange = 6;
                        periode = 2;
                        return 6;
                    case "Anuelle":
                        monthBar.SmallChange = 12;
                        monthBar.LargeChange = 12;
                        periode = 1;
                        return 12;
                    default:
                        return 1;
                }
            }
            else
            {
                monthBar.SmallChange = 1;
                return 1;
            }            
        }

        private void nameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void CapitalBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (!char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
            montantLabel.Text = MontantARembourser();
        }

        private void monthBar_Scroll(object sender, ScrollEventArgs e)
        {
            NombreRemboursement();
            montantLabel.Text = MontantARembourser();
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Periodiciter();
            NombreRemboursement();
            montantLabel.Text = MontantARembourser();
        }

        private void taux7_CheckedChanged(object sender, EventArgs e)
        {
            tauxAnnuel = 7;
            montantLabel.Text = MontantARembourser();
        }

        private void taux8_CheckedChanged(object sender, EventArgs e)
        {
            tauxAnnuel = 8;
            montantLabel.Text = MontantARembourser();
        }

        private void taux9_CheckedChanged(object sender, EventArgs e)
        {
            tauxAnnuel = 9;
            montantLabel.Text = MontantARembourser();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            montantLabel.Text = MontantARembourser();
        }

        private void viderButton_Click(object sender, EventArgs e)
        {
            Initialisation();
        }

        private void Synthese_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
