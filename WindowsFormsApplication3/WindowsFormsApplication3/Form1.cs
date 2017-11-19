using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader data;
        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='c:\\users\\admin\\documents\\visual studio 2015\\Projects\\WindowsFormsApplication3\\WindowsFormsApplication3\\Database1.mdf';Integrated Security=True;";
            con.Open();
            cmd = con.CreateCommand();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "SELECT MAX(StudentNumber+1) AS newNum FROM school";
            SqlDataReader R = cmd.ExecuteReader();
            if (R.Read())
            {
                String newStudentNumber = R["newNum"].ToString();
                R.Close();
                cmd.CommandText = $"INSERT INTO school VALUES({newStudentNumber},'{textBox2.Text}',{textBox3.Text})";
                cmd.ExecuteNonQuery();
            } else {
                R.Close();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "SELECT * FROM school";
            data = cmd.ExecuteReader();
            if (data.Read())
            {
                textBox1.Text = data["StudentNumber"].ToString();
                textBox2.Text = data["Names"].ToString();
                textBox3.Text = data["Marks"].ToString();
            }
            data.Close();
        }
    }
}
