using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorRadio
{
    public partial class Form1 : Form
    {
        Form2 f2 = new Form2();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a, b;
            a = Convert.ToSingle(textBox1.Text);
            b = Convert.ToSingle(textBox2.Text);
            if (Addition.Checked)
            {
                f2.setResult(a + b);
                reset();
            } else if (Subtraction.Checked) {
                f2.setResult(a - b);
                reset();
            } else if (Multiplication.Checked) {
                f2.setResult(a * b);
                reset();
            } else if (Division.Checked) {
                f2.setResult(a / b);
                reset();
            } else {

            }
        }
        private void reset()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            Addition.Checked = false;
            Subtraction.Checked = false;
            Multiplication.Checked = false;
            Division.Checked = false;

        }
    }
}
