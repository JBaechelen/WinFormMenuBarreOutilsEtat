using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormAdditioneur
{
    public partial class Additionneur : Form
    {
        public Additionneur()
        {
            InitializeComponent();
        }

        void button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Affichage.Text += btn.Tag + "+";
        }

        private void bouttonCalcul_Click(object sender, EventArgs e)
        {
            int resultat = 0, chiffre;
            string[] dejaCalculer = Affichage.Text.Split('=');
            string[] calcul = dejaCalculer[dejaCalculer.Length-1].Split('+');
            for (int i = 0; i < calcul.Length - 1; i++)
            {
                if (calcul[i] != "")
                {
                    chiffre = int.Parse(calcul[i]);
                    resultat += chiffre;
                }                
            }
            Affichage.Text += "=" + resultat + "+";
        }

        // Remettre l'affiche à zero.
        private void bouttonVider_Click(object sender, EventArgs e)
        {
            Affichage.Text = "";
        }

        private void Additionneur_FormClosing(object sender, FormClosingEventArgs e)
        {            
            e.Cancel = true;
            this.Hide();
        }
    }
}
