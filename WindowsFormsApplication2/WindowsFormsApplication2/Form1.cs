using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        Boolean isSaved = true;
        Boolean hasPath = false;
        String path = "";
        Boolean cancel = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            textBox.Height = this.Height - menuStrip1.Height;
            textBox.Width = this.Width;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isSaved)
            {
                textBox.Text = "";
                isSaved = true;
                hasPath = false;
            } else {
                checkSave(sender, e);
                if (!cancel)
                {
                    newToolStripMenuItem_Click(sender, e);
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isSaved)
            {
                openFile.FileName = "";
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    path = openFile.FileName;
                    textBox.LoadFile(path);
                    isSaved = true;
                    hasPath = true;
                }
            }
            else
            {
                checkSave(sender, e);
                if (!cancel)
                {
                    openToolStripMenuItem_Click(sender, e);
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (hasPath)
            {
                textBox.SaveFile(path);
                isSaved = true;
            } else {
                saveAsToolStripMenuItem_Click(sender, e);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile.FileName = "";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                path = saveFile.FileName;
                textBox.SaveFile(path);
                hasPath = true;
                isSaved = true;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isSaved)
            {
                Application.Exit();
            } else {
                checkSave(sender, e);
                if (!cancel)
                {
                    exitToolStripMenuItem_Click(sender, e);
                }                
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            isSaved = false;
        }

        private void checkSave(object sender, EventArgs e)
        {
            cancel = false;
            DialogResult dialogResult = MessageBox.Show("Would you like to save this file first?", "Save", MessageBoxButtons.YesNoCancel);
            if (dialogResult == DialogResult.Yes)
            {
                saveToolStripMenuItem_Click(sender, e);
            } else if (dialogResult == DialogResult.No) {
                isSaved = true;
            } else if (dialogResult == DialogResult.Cancel) {
                cancel = true;
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myFont.ShowDialog();
            textBox.SelectionFont = myFont.Font;
        }

        private void colourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myColour.ShowDialog();
            textBox.SelectionColor = myColour.Color;

        }

        private void fontAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.SelectAll();
            fontToolStripMenuItem_Click(sender, e);
            textBox.DeselectAll();
        }

        private void colourAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.SelectAll();
            colourToolStripMenuItem_Click(sender, e);
            textBox.DeselectAll();
        }
    }
}
