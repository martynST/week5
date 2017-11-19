namespace WindowsFormsApplication4
{
    partial class WithDepBal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.withDep = new System.Windows.Forms.GroupBox();
            this.withDepSub = new System.Windows.Forms.Button();
            this.money = new System.Windows.Forms.TextBox();
            this.withDepLabel = new System.Windows.Forms.Label();
            this.accountDetails = new System.Windows.Forms.GroupBox();
            this.balance = new System.Windows.Forms.TextBox();
            this.gender = new System.Windows.Forms.TextBox();
            this.accType = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.accountNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.withDep.SuspendLayout();
            this.accountDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // withDep
            // 
            this.withDep.Controls.Add(this.withDepSub);
            this.withDep.Controls.Add(this.money);
            this.withDep.Controls.Add(this.withDepLabel);
            this.withDep.Location = new System.Drawing.Point(12, 211);
            this.withDep.Name = "withDep";
            this.withDep.Size = new System.Drawing.Size(247, 38);
            this.withDep.TabIndex = 24;
            this.withDep.TabStop = false;
            // 
            // withDepSub
            // 
            this.withDepSub.Location = new System.Drawing.Point(167, 11);
            this.withDepSub.Name = "withDepSub";
            this.withDepSub.Size = new System.Drawing.Size(75, 23);
            this.withDepSub.TabIndex = 16;
            this.withDepSub.Text = "Withdraw";
            this.withDepSub.UseVisualStyleBackColor = true;
            // 
            // money
            // 
            this.money.Location = new System.Drawing.Point(62, 13);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(100, 20);
            this.money.TabIndex = 15;
            // 
            // withDepLabel
            // 
            this.withDepLabel.AutoSize = true;
            this.withDepLabel.Location = new System.Drawing.Point(5, 16);
            this.withDepLabel.Name = "withDepLabel";
            this.withDepLabel.Size = new System.Drawing.Size(58, 13);
            this.withDepLabel.TabIndex = 0;
            this.withDepLabel.Text = "Withdraw: ";
            // 
            // accountDetails
            // 
            this.accountDetails.Controls.Add(this.balance);
            this.accountDetails.Controls.Add(this.gender);
            this.accountDetails.Controls.Add(this.accType);
            this.accountDetails.Controls.Add(this.label6);
            this.accountDetails.Controls.Add(this.label5);
            this.accountDetails.Controls.Add(this.label4);
            this.accountDetails.Controls.Add(this.address);
            this.accountDetails.Controls.Add(this.name);
            this.accountDetails.Controls.Add(this.label3);
            this.accountDetails.Controls.Add(this.label2);
            this.accountDetails.Location = new System.Drawing.Point(12, 73);
            this.accountDetails.Name = "accountDetails";
            this.accountDetails.Size = new System.Drawing.Size(247, 131);
            this.accountDetails.TabIndex = 23;
            this.accountDetails.TabStop = false;
            this.accountDetails.Visible = false;
            // 
            // balance
            // 
            this.balance.Location = new System.Drawing.Point(96, 110);
            this.balance.Name = "balance";
            this.balance.ReadOnly = true;
            this.balance.Size = new System.Drawing.Size(100, 20);
            this.balance.TabIndex = 12;
            // 
            // gender
            // 
            this.gender.Location = new System.Drawing.Point(96, 87);
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            this.gender.Size = new System.Drawing.Size(100, 20);
            this.gender.TabIndex = 11;
            // 
            // accType
            // 
            this.accType.Location = new System.Drawing.Point(96, 64);
            this.accType.Name = "accType";
            this.accType.ReadOnly = true;
            this.accType.Size = new System.Drawing.Size(100, 20);
            this.accType.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Current Balance:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Gender:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Account Type:";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(96, 38);
            this.address.Name = "address";
            this.address.ReadOnly = true;
            this.address.Size = new System.Drawing.Size(100, 20);
            this.address.TabIndex = 6;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(96, 14);
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name:";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(184, 43);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 22;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            // 
            // accountNumber
            // 
            this.accountNumber.Location = new System.Drawing.Point(78, 45);
            this.accountNumber.Name = "accountNumber";
            this.accountNumber.Size = new System.Drawing.Size(100, 20);
            this.accountNumber.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Account No:";
            // 
            // WithDepBal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.withDep);
            this.Controls.Add(this.accountDetails);
            this.Controls.Add(this.search);
            this.Controls.Add(this.accountNumber);
            this.Controls.Add(this.label1);
            this.Name = "WithDepBal";
            this.Text = "WithDepBal";
            this.Load += new System.EventHandler(this.WithDepBal_Load);
            this.withDep.ResumeLayout(false);
            this.withDep.PerformLayout();
            this.accountDetails.ResumeLayout(false);
            this.accountDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox withDep;
        private System.Windows.Forms.Button withDepSub;
        private System.Windows.Forms.TextBox money;
        private System.Windows.Forms.Label withDepLabel;
        private System.Windows.Forms.GroupBox accountDetails;
        private System.Windows.Forms.TextBox balance;
        private System.Windows.Forms.TextBox gender;
        private System.Windows.Forms.TextBox accType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox accountNumber;
        private System.Windows.Forms.Label label1;
    }
}