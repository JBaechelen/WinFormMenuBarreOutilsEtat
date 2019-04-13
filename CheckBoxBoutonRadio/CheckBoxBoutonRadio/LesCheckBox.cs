using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBoxBoutonRadio
{
    public partial class LesCheckBox : Form
    {
        public string texteSaise;

        public void RecuperationSaisie(string saisie)
        {
            texteSaise = saisie;
            textUser.Text = texteSaise;
        }

        public LesCheckBox()
        {
            InitializeComponent();
            textCopy.ReadOnly = true;
            textCopy.Visible = false;
            groupFond.Visible = false;
            groupCaractere.Visible = false;
            groupCasse.Visible = false;
            groupChoix.Enabled = false;
        }

        private void textUser_TextChanged(object sender, EventArgs e)
        {
            if (textUser.Text == "")
            {
                groupChoix.Enabled = false;
                textCopy.Visible = false;
            }
            else
            {
                groupChoix.Enabled = true;
                textCopy.Text = textUser.Text;
                textCopy.Visible = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (colorFond.Checked)
            {
                groupFond.Visible = true;
            }
            else
            {
                groupFond.Visible = false;
                fondRouge.Checked = false;
                fondVert.Checked = false;
                fondBleu.Checked = false;
                textCopy.BackColor = default(Color);
            }
        }

        private void colorCaractere_CheckedChanged(object sender, EventArgs e)
        {
            if (colorCaractere.Checked)
            {
                groupCaractere.Visible = true;
            }
            else
            {
                groupCaractere.Visible = false;
                carRouge.Checked = false;
                carBlanc.Checked = false;
                carNoir.Checked = false;
                textCopy.ForeColor = Color.Black;
            }
        }

        private void casseCaractere_CheckedChanged(object sender, EventArgs e)
        {
            if (casseCaractere.Checked)
            {
                groupCasse.Visible = true;
            }
            else
            {
                groupCasse.Visible = false;
                casseMin.Checked = false;
                casseMaj.Checked = false;
                textCopy.CharacterCasing = CharacterCasing.Normal;
                textCopy.Text = textUser.Text;
            }
        }

        private void fondRouge_CheckedChanged(object sender, EventArgs e)
        {
            if (fondRouge.Checked)
            {
                textCopy.BackColor = System.Drawing.Color.Red;
            }
        }

        private void fondVert_CheckedChanged(object sender, EventArgs e)
        {
            if (fondVert.Checked)
            {
                textCopy.BackColor = System.Drawing.Color.Green;
            }
        }

        private void bleuFond_CheckedChanged(object sender, EventArgs e)
        {
            if (fondBleu.Checked)
            {
                textCopy.BackColor = System.Drawing.Color.Blue;
            }
        }

        private void carRouge_CheckedChanged(object sender, EventArgs e)
        {
            if (carRouge.Checked)
            {
                textCopy.BackColor = textCopy.BackColor;
                textCopy.ForeColor = Color.Red;
            }
        }

        private void carBlanc_CheckedChanged(object sender, EventArgs e)
        {
            if (carBlanc.Checked)
            {
                textCopy.BackColor = textCopy.BackColor;                
                textCopy.ForeColor = Color.White;
            }
        }

        private void carNoir_CheckedChanged(object sender, EventArgs e)
        {
            if (carNoir.Checked)
            {
                textCopy.BackColor = textCopy.BackColor;
                textCopy.ForeColor = Color.Black;
            }
        }

        private void casseMin_CheckedChanged(object sender, EventArgs e)
        {
            if (casseMin.Checked)
            {
                textCopy.CharacterCasing = CharacterCasing.Lower;
            }
        }

        private void casseMaj_CheckedChanged(object sender, EventArgs e)
        {
            if (casseMaj.Checked)
            {
                textCopy.CharacterCasing = CharacterCasing.Upper;
            }
        }

        private void LesCheckBox_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
