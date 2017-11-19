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

namespace WindowsFormsApplication4
{
    public partial class Main : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader data;
        NewAccount newAcc;
        Deposit despoit;
        Withdraw withdraw;
        WithDepBal withDepBal;


        public Main()
        {                       
            InitializeComponent();
            con = new SqlConnection();
            con.ConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = \"c:\\users\\admin\\documents\\visual studio 2015\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\Database1.mdf\"; Integrated Security = True;";
            con.Open();
            cmd = con.CreateCommand();
            withDepBal = new WithDepBal(con, cmd, data);
            despoit = new Deposit(con, cmd, data);
            newAcc = new NewAccount(con, cmd, data);
            withdraw = new Withdraw(con, cmd, data);
        }
        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void newAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newAcc.ShowDialog();
        }

        private void depositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            withDepBal.setType("d");
            withDepBal.ShowDialog();
        }

        private void withdrawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            withDepBal.setType("w");
            withDepBal.ShowDialog();
        }

        private void balanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            withDepBal.setType("b");
            withDepBal.ShowDialog();
        }
    }
}
