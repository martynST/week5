using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private Boolean validNumbers()
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Invalid First Number");
                textBox1.Focus();
                return false;
            } else if (textBox2.Text == "")
            {
                MessageBox.Show("Invalid Second Number");
                textBox2.Focus();
                return false;
            } else
            {
                return true;
            }
        }
        private void add_Click(object sender, EventArgs e)
        {
            int a, b;
            if (validNumbers())
            {
                a = Int32.Parse(textBox1.Text);
                b = Int32.Parse(textBox2.Text);
                textBox3.Text = "" + (a + b);
            }
        }
        private void subtract_Click(object sender, EventArgs e)
        {
            int a, b;
            if (validNumbers())
            {
                a = Int32.Parse(textBox1.Text);
                b = Int32.Parse(textBox2.Text);
                textBox3.Text = "" + (a - b);
            }
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            int a, b;
            if (validNumbers())
            {
                a = Int32.Parse(textBox1.Text);
                b = Int32.Parse(textBox2.Text);
                textBox3.Text = "" + (a * b);
            }
        }

        private void divide_Click(object sender, EventArgs e)
        {
            int a, b;
            if (validNumbers())
            {
                a = Int32.Parse(textBox1.Text);
                b = Int32.Parse(textBox2.Text);
                if (b != 0)
                {                   
                    textBox3.Text = "" + ((float) a / b);
                } else
                {
                    MessageBox.Show("Invalid Denominator.");
                    textBox2.Focus();
                }
            }
        }

        
    }
}
