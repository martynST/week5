using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MessageGetStufferFromer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex rgx;
            String outputString = "";
            if (count.Checked)
            {
                output.Text = "" + input.Text.Split(' ').Length;
            }
            else if (upper.Checked)
            {
                rgx = new Regex("[^A-Z]");
                output.Text = rgx.Replace(input.Text, "");
            }
            else if (lower.Checked)
            {
                rgx = new Regex("[^a-z]");
                output.Text = rgx.Replace(input.Text, "");
            }
            else if (digits.Checked)
            {
                rgx = new Regex("[^0-9]");
                output.Text = rgx.Replace(input.Text, "");
            }
            else if (special.Checked)
            {
                char test;
                for (int i = 0; i < input.Text.Length; i++)
                {
                    test = (char)input.Text[i];

                    if (Char.IsNumber(test) || Char.IsUpper(test) || Char.IsLower(test))
                    {
                    } else
                    {
                        outputString += input.Text[i];

                    }
                }
            }
            else
            {

            }
        }
    }
}
