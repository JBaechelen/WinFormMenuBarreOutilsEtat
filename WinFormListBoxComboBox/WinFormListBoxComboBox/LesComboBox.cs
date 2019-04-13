using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormListBoxComboBox
{
    public partial class LesComboBox : Form
    {
        string[] tabSource = new string[5] {"France", "Japon", "Allemagne", "Portugal", "Espagne"};

        public LesComboBox()
        {
            InitializeComponent();
            foreach (var item in tabSource)
            {
                sourceList.Items.Add(item);
            }
            addCible.Enabled = false;
            addSource.Enabled = false;
            addAllSource.Enabled = false;
            moveUp.Enabled = false;
            moveDown.Enabled = false;
        }

        private void sourceList_DropDown(object sender, EventArgs e)
        {
            if (!sourceList.Items.Contains(sourceList.Text) && !listBox.Items.Contains(sourceList.Text) && sourceList.Text != "")
            {
                sourceList.Items.Add(sourceList.Text);
                addCible.Enabled = true;
                addAllCible.Enabled = true;
            }
        }

        private void addCible_Click(object sender, EventArgs e)
        {
            if (sourceList.SelectedItem != null)
            {
                int index = sourceList.SelectedIndex;
                listBox.Items.Add(sourceList.SelectedItem);
                sourceList.Items.Remove(sourceList.SelectedItem);
                if (index < sourceList.Items.Count)
                {
                    sourceList.Text = sourceList.Items[index].ToString();
                }
                else
                {
                    sourceList.Text = "";
                    addCible.Enabled = false;
                }
                addAllSource.Enabled = true;
                if (sourceList.Items.Count == 0)
                {
                    addAllCible.Enabled = false;
                }
            }
        }

        private void addAllCible_Click(object sender, EventArgs e)
        {
            foreach (var item in sourceList.Items)
            {
                listBox.Items.Add(item);
            }
            sourceList.Items.Clear();
            sourceList.Text = "";
            addAllSource.Enabled = true;
            addAllCible.Enabled = false;
            addCible.Enabled = false;
        }

        private void addSource_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                int index = listBox.SelectedIndex;
                sourceList.Items.Add(listBox.SelectedItem);
                listBox.Items.Remove(listBox.SelectedItem);
                if (index < listBox.Items.Count)
                {
                    listBox.SelectedIndex = index;
                }
                else
                {
                    addSource.Enabled = false;
                }
                moveUp.Enabled = false;
                moveDown.Enabled = false;
                addAllCible.Enabled = true;
                if (listBox.Items.Count == 0)
                {
                    addSource.Enabled = false;
                    addAllSource.Enabled = false;
                }
                else if (listBox.Items.Count < 2)
                {
                    moveUp.Enabled = false;
                    moveDown.Enabled = false;
                }
            }
        }

        private void addAllSource_Click(object sender, EventArgs e)
        {
            foreach (var item in listBox.Items)
            {
                sourceList.Items.Add(item);
            }
            listBox.Items.Clear();
            addAllCible.Enabled = true;
            addAllSource.Enabled = false;
            addSource.Enabled = false;
            moveUp.Enabled = false;
            moveDown.Enabled = false;
        }

        private void sourceList_SelectedValueChanged(object sender, EventArgs e)
        {
            if (sourceList.Text != null)
            {
                addCible.Enabled = true;
            }
        }

        private void listBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                addSource.Enabled = true;
            }            
        }

        private void moveUp_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex > 0)
            {
                int index = listBox.SelectedIndex;
                listBox.Items.Insert(index - 1, listBox.Items[index]);
                listBox.Items.RemoveAt(index + 1);
                listBox.SelectedIndex = index - 1;
                if (index - 1 == 0)
                {
                    moveUp.Enabled = false;
                }
            }
        }

        private void moveDown_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex < listBox.Items.Count - 1)
            {
                int index = listBox.SelectedIndex;
                listBox.Items.Insert(index + 2, listBox.Items[index]);
                listBox.Items.RemoveAt(index);
                listBox.SelectedIndex = index + 1;
                if (index + 1 == listBox.Items.Count -1)
                {
                    moveDown.Enabled = false;
                }
            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                if (listBox.SelectedIndex == 0)
                {
                    moveUp.Enabled = false;
                    if (listBox.Items.Count > 1)
                    {
                        moveDown.Enabled = true;
                    }                    
                }
                else if (listBox.SelectedIndex == listBox.Items.Count - 1)
                {
                    moveDown.Enabled = false;
                    moveUp.Enabled = true;
                }
                else
                {
                    moveUp.Enabled = true;
                    moveDown.Enabled = true;
                }
            }            
        }

        private void LesComboBox_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}