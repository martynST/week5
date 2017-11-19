using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OccilatingTextBox
{
    public partial class Form1 : Form
    {
        Boolean increasing = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) {
            if (increasing) {
                textBox1.Width += 10;
                if (this.Width - textBox1.Width - textBox1.Location.X <= 100)
                {
                    this.increasing = false;
                }
            } else {
                textBox1.Width -= 10;
                if (textBox1.Width <= 50)
                {
                    this.increasing = true;
                }
            }
        }

        private void dfg(object sender, EventArgs e)
        {

        }
    }
}
