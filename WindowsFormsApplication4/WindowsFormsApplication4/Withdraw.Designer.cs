namespace WindowsFormsApplication4
{
    partial class Withdraw
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.subWith = new System.Windows.Forms.Button();
            this.money = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
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
            this.groupBox2.SuspendLayout();
            this.accountDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.subWith);
            this.groupBox2.Controls.Add(this.money);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(12, 204);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 38);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // subWith
            // 
            this.subWith.Location = new System.Drawing.Point(167, 11);
            this.subWith.Name = "subWith";
            this.subWith.Size = new System.Drawing.Size(75, 23);
            this.subWith.TabIndex = 16;
            this.subWith.Text = "Withdraw";
            this.subWith.UseVisualStyleBackColor = true;
            this.subWith.Click += new System.EventHandler(this.subWith_Click);
            // 
            // money
            // 
            this.money.Location = new System.Drawing.Point(62, 13);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(100, 20);
            this.money.TabIndex = 15;
            this.money.KeyDown += new System.Windows.Forms.KeyEventHandler(this.money_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Withdraw: ";
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
            this.accountDetails.Location = new System.Drawing.Point(12, 66);
            this.accountDetails.Name = "accountDetails";
            this.accountDetails.Size = new System.Drawing.Size(247, 131);
            this.accountDetails.TabIndex = 18;
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
            this.search.Location = new System.Drawing.Point(184, 36);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 17;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // accountNumber
            // 
            this.accountNumber.Location = new System.Drawing.Point(78, 38);
            this.accountNumber.Name = "accountNumber";
            this.accountNumber.Size = new System.Drawing.Size(100, 20);
            this.accountNumber.TabIndex = 16;
            this.accountNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.accountNumber_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Account No:";
            // 
            // Withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.accountDetails);
            this.Controls.Add(this.search);
            this.Controls.Add(this.accountNumber);
            this.Controls.Add(this.label1);
            this.Name = "Withdraw";
            this.Text = "Withdraw";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.accountDetails.ResumeLayout(false);
            this.accountDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button subWith;
        private System.Windows.Forms.TextBox money;
        private System.Windows.Forms.Label label7;
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