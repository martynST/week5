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
    public partial class WithDepBal : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader data;
        String type;

        public WithDepBal(SqlConnection con, SqlCommand cmd, SqlDataReader data)
        {
            InitializeComponent();
            this.con = con;
            this.cmd = cmd;
            this.data = data;
        }
        private void WithDepBal_Load(object sender, EventArgs e)
        {
            
        }
        private void search_Click(object sender, EventArgs e)
        {
            accountDetails.Visible = false;
            String accountNum = accountNumber.Text;
            cmd.CommandText = $"SELECT * FROM accounts WHERE accNo = '{accountNum}'";
            data = cmd.ExecuteReader();
            if (data.Read())
            {
                name.Text = data["Name"].ToString();
                address.Text = data["address"].ToString();
                accType.Text = (accountNum.Substring(0, 1) == "c") ? "Current" : "Saving";
                gender.Text = (accountNum.Substring(1, 1) == "m") ? "Male" : "Female";
                data.Close();
                getBalance(accountNum);
                accountDetails.Visible = true;
            }
            else
            {
                data.Close();
                MessageBox.Show("Invalid Account Number");
            }
        }
        private void getBalance(String accountNum)
        {

            cmd.CommandText = $"SELECT ISNULL(SUM(amount),'0') AS total FROM deposit where accNo = '{accountNum}'";
            data = cmd.ExecuteReader();
            data.Read();
            String totalDep = data["total"].ToString();
            data.Close();
            cmd.CommandText = $"SELECT ISNULL(SUM(amount),'0') AS total FROM withdraw where accNo = '{accountNum}'";
            data = cmd.ExecuteReader();
            data.Read();
            String totalWith = data["total"].ToString();
            float myBalance = Convert.ToSingle(totalDep) - Convert.ToSingle(totalWith);
            data.Close();
            balance.Text = myBalance.ToString();
        }

        private void subWith_Click(object sender, EventArgs e)
        {
            String accountNum = accountNumber.Text;
            getBalance(accountNum);
            String myBalance = balance.Text;
            String amountWithdraw = money.Text;
            if (Convert.ToSingle(myBalance) >= Convert.ToSingle(amountWithdraw))
            {
                String withMoney = money.Text;
                cmd.CommandText = $"INSERT INTO withdraw VALUES('{accountNum}',{withMoney},'{DateTime.Now.ToString("M/d/yyyy")}')";
                cmd.ExecuteNonQuery();
                getBalance(accountNum);
            }
            else
            {
                MessageBox.Show("Not Enough Money In Account.");
            }
            money.Text = "";
        }

        private void subDep_Click(object sender, EventArgs e)
        {
            String accountNum = accountNumber.Text;
            String depMoney = money.Text;
            cmd.CommandText = $"INSERT INTO deposit VALUES('{accountNum}',{depMoney},'{DateTime.Now.ToString("M/d/yyyy")}')";
            cmd.ExecuteNonQuery();
            getBalance(accountNum);
            money.Text = "";
        }

        private void accountNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                search_Click(sender, e);
            }
        }

        private void money_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (type == "w")
                    subWith_Click(sender, e);
                else
                    subDep_Click(sender, e);
            }
        }

        public void setType(String type)
        {
            this.type = type;
            if (type == "w")
            {
                withDep.Visible = true;
                withDepLabel.Text = "Withdraw";
                withDepSub.Text = "Withdraw";
                this.Text = "Withdraw";
            }
            else if (type == "d")
            {
                withDep.Visible = true;
                withDepLabel.Text = "Deposit";
                withDepSub.Text = "Deposit";
                this.Text = "Deposit";
            }
            else
            {
                withDep.Visible = false;
                this.Text = "Balance";
            }
        }
    }
}
