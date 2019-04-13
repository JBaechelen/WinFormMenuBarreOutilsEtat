using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsListBox
{
    public partial class LesListBox : Form
    {
        public LesListBox()
        {
            InitializeComponent();
            newElemLabel.Font = new Font(Label.DefaultFont, FontStyle.Bold);
            indexLabel.Font = new Font(Label.DefaultFont, FontStyle.Bold);
            listLabel.Font = new Font(Label.DefaultFont, FontStyle.Bold);
            propertyLabel.Font = new Font(Label.DefaultFont, FontStyle.Bold);
            countBox.ReadOnly = true;
            selIndexBox.ReadOnly = true;
            textBox.ReadOnly = true;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (newElemText.Text != "")
            {
                if (!listBox.Items.Contains(newElemText.Text))
                {
                    listBox.Items.Add(newElemText.Text);
                    newElemText.Text = "";
                    newElemText.Select();
                    errorAddElement.SetError(newElemText, "");
                }
                else
                {
                    errorAddElement.SetError(newElemText, "Cette valeur est déjà présente dans la liste.");
                }
            }
            if (countBox.Text != "")
            {
                countBox.Text = listBox.Items.Count.ToString();
            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            countBox.Text = listBox.Items.Count.ToString();
            selIndexBox.Text = (listBox.SelectedIndex).ToString();
            textBox.Text = listBox.GetItemText(listBox.SelectedItem);
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            if (indexBox.Text != "")
            {
                int index;
                bool testIndex = int.TryParse(indexBox.Text, out index);
                if (testIndex)
                {
                    if (Math.Abs(index) < listBox.Items.Count)
                    {
                        listBox.SelectedIndex = index;
                        errorIndex.SetError(indexBox, "");
                        indexBox.Text = "";
                    }
                    else
                    {
                        errorIndex.SetError(indexBox, "L'index sélectionné ne correspond à aucun élément de la liste.");
                    }
                }
                else
                {
                    errorIndex.SetError(indexBox, "Veuillez entrer un nombre correspondant à l'object à sélectionner.");
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            countBox.Text = "";
            selIndexBox.Text = "";
            textBox.Text = "";
        }

        private void LesListBox_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
