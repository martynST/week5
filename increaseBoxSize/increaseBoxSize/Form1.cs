using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace increaseBoxSize
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.Width - textBox1.Width - textBox1.Location.X > 100)
            {
                textBox1.Width += 10;
            } else
            {
                this.Text = "Maximum Width Reached";
            }
        }
    }
}
