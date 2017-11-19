using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator3
{
    public partial class Form1 : Form
    {
        float a, b, c;
        String op;
        Boolean displayNumber = true;
        Boolean lastOp = false;
        List<String> inputs = new List<String>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        //Numbers
        private void num_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (displayNumber)
            {
                t1.Text = btn.Text;
                displayNumber = false;
            }
            else
            {
                t1.Text += btn.Text;
                lastOp = false;
            }
        }

        //Operations
        private void op_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            displayNumber = false;
            if (lastOp)
            {
                inputs[inputs.Count - 1] = (btn.Text);
            } else {
                if (t1.Text != "")
                {
                    inputs.Add(t1.Text);
                    inputs.Add(btn.Text);
                    lastOp = true;
                    resolveCalc();
                }
            }
        }
        private void opClear_Click(object sender, EventArgs e)
        {
            inputs = new List<String>();
            t1.Text = "";
        }
        private void resolveCalc()
        {
            t1.Text = "";
            if (this.inputs.Count > 2)
            {
                a = Convert.ToSingle(inputs[0]);
                op = inputs[1];
                b = Convert.ToSingle(inputs[2]);
                switch(op)
                {
                    case "+":
                        c = a + b;
                        break;
                    case "-":
                        c = a - b;
                        break;
                    case "*":
                        c = a * b;
                        break;
                    case "/":
                        c = a / b;
                        break;
                }
                op = inputs[3];
                inputs = new List<String>();

                inputs.Add(""+c);                
                inputs.Add(op);
                if (isFinished())
                {
                    t1.Text = inputs[0];
                    displayNumber = true;
                    lastOp = false;
                    inputs = new List<String>();
                }
            }
            else
            {
                a = Convert.ToSingle(inputs[0]);
                op = inputs[1];
            }

        }
        private Boolean isFinished()
        {
            if (inputs[1] == "=")
            {
                return true;
            } else {
                return false;
            }
        }

    }
}
