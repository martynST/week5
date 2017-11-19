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
    public partial class NewAccount : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader data;
        public NewAccount(SqlConnection con, SqlCommand cmd, SqlDataReader data)
        {
            InitializeComponent();
            this.con = con;
            this.cmd = cmd;
            this.data = data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char accountType = current.Checked ? 'c' : 's';
            char gender = male.Checked ? 'm' : 'f';
            String newAccountNumber;
            cmd.CommandText = $"SELECT CONCAT('{accountType}','{gender}',RIGHT(CONCAT('000',ISNULL(MAX(SUBSTRING(accNo,3,3))+1,'001')),3)) AS newAccNo FROM accounts WHERE SUBSTRING(accNo,1,1) = '{accountType}'";
            data = cmd.ExecuteReader();
            data.Read();
            Console.Write(data.ToString());
            newAccountNumber = data["newAccNo"].ToString();
            data.Close();
            cmd.CommandText = $"INSERT INTO accounts VALUES('{newAccountNumber}','{name.Text}','{address.Text}','a')";
            cmd.ExecuteNonQuery();
        }

        private void NewAccount_Load(object sender, EventArgs e)
        {

        }
    }
}
