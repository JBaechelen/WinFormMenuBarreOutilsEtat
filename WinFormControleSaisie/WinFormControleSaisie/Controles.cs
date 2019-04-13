using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Globalization; // Pour la commande DateTimeStyles
using System.Text.RegularExpressions; // Pour la commande Regex
using System.Media; // Pour la commande SystemSounds
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormControleSaisie
{
    public partial class Controles : Form
    {
        public Controles()
        {
            InitializeComponent();
        }

        private void txtNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);            
        }

        bool NomValide(string s)
        {
            //tester la string nom avec une regex de min 3 max 30 et envoyer une icone d'erreur si non conforme
            if (!Regex.IsMatch(txtNom.Text, @"^[A-Za-z]{3,30}"))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void txtNom_Leave(object sender, EventArgs e)
        {
            if (NomValide(txtNom.Text))
            {
                testNom.SetError(txtNom, "");
            }
            else
            {
                testNom.SetError(txtNom, "Le nom saisie est incorrect.");
            }
        }

        private void txtDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            // verifier que le caractère donnée est bien un chiffre ou un separateur /
            if (!char.IsControl(e.KeyChar) && (!char.IsDigit(e.KeyChar))
                && (e.KeyChar != '/'))
            {
                e.Handled = true;
            }
        }

        bool DateValide(string s)
        {
            DateTime test;
            /*TryParseExact -> string s, string format, provider, DateTimeStyles, out result : 
             s: la string a verifier, format: le format dans la quel doit etre la string, provider: format spécifiques à la culture sur s peux etre null,
             style: format autorisé du paramètre s peut être .None*/
            if (DateTime.TryParseExact(txtDate.Text, "dd/MM/yyyy", null, DateTimeStyles.None, out test) == true)
            {
                //Verifier que la date donnée est supérieur à la date du jour
                DateTime dateUser = DateTime.Parse(txtDate.Text);
                int resultat = DateTime.Compare(dateUser, DateTime.Now);
                if (resultat > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void txtDate_Leave(object sender, EventArgs e)
        {
            if (DateValide(txtDate.Text))
            {
                testDate.SetError(txtDate, "");
            }
            else
            {
                testDate.SetError(txtDate, "La date n'est pas valide, elle doit être au format indiqué.");
            }
        }

        private void txtMontant_KeyPress(object sender, KeyPressEventArgs e)
        {
            // verifier que le caractère donnée est bien un chiffre ou une virgule
            if (!char.IsControl(e.KeyChar) && (!char.IsDigit(e.KeyChar))
                && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            //Si l'utilisateur tape une virgule, celle-ci est remplacer par un point
            if (e.KeyChar == ',')
            {
                e.KeyChar = '.';
            }

            // une seule virgule pour les nombre decimaux
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        bool MontantValide(string s)
        {
            if (!Regex.IsMatch(txtMontant.Text, @"^[1-9]\d*(\.\d{2})?$"))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void txtMontant_Leave(object sender, EventArgs e)
        {
            if (MontantValide(txtMontant.Text))
            {
                testMontant.SetError(txtMontant, "");
            }
            else
            {
                testMontant.SetError(txtMontant, "Le montant ne peux avoir que 2 chiffres après la virgule.");
            }
        }

        private void txtCP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (!char.IsDigit(e.KeyChar))
                && txtCP.Text.Length < 6)
            {
                e.Handled = true;
            }
        }

        bool CPValide(string s)
        {
            if (txtCP.Text.Length < 5)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void txtCP_Leave(object sender, EventArgs e)
        {
            if (CPValide(txtCP.Text))
            {
                testCP.SetError(txtCP, "");
            }
            else
            {
                testCP.SetError(txtCP, "Le code postal doit comporter 5 chiffres.");
            }
        }

        private void bouttonValider_Click(object sender, EventArgs e)
        {

            if (!NomValide(txtNom.Text))
            {
                SystemSounds.Beep.Play();
                txtNom.Select();
            }
            else if (!DateValide(txtDate.Text))
            {
                SystemSounds.Beep.Play();
                txtDate.Select();
            }
            else if (!MontantValide(txtMontant.Text))
            {
                SystemSounds.Beep.Play();
                txtMontant.Select();
            }
            else if (!CPValide(txtCP.Text))
            {
                SystemSounds.Beep.Play();
                txtCP.Select();
            }
            else
            {
                MessageBox.Show("Nom : " + txtNom.Text + "\nDate : " + txtDate.Text + "\nMontant : " + txtMontant.Text + "\nCode Postal : " + txtCP.Text,
                            "Validation effectuée", MessageBoxButtons.OK);
            }
        }

        private void bouttonAnnuler_Click(object sender, EventArgs e)
        {
            ViderTextBox(this);
        }

        void ViderTextBox(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
            }
        }

        private void FermetureFormulaire(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Fin de l'application?", "Fin", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                e.Cancel = true;
                this.Hide();
            }
        }
    }
}
