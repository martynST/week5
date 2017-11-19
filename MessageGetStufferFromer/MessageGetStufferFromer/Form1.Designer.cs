namespace MessageGetStufferFromer
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.TextBox();
            this.count = new System.Windows.Forms.RadioButton();
            this.upper = new System.Windows.Forms.RadioButton();
            this.lower = new System.Windows.Forms.RadioButton();
            this.digits = new System.Windows.Forms.RadioButton();
            this.special = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Message";
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(69, 49);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(100, 20);
            this.input.TabIndex = 1;
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.Location = new System.Drawing.Point(16, 84);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(87, 17);
            this.count.TabIndex = 2;
            this.count.TabStop = true;
            this.count.Text = "Count Words";
            this.count.UseVisualStyleBackColor = true;
            // 
            // upper
            // 
            this.upper.AutoSize = true;
            this.upper.Location = new System.Drawing.Point(16, 107);
            this.upper.Name = "upper";
            this.upper.Size = new System.Drawing.Size(136, 17);
            this.upper.TabIndex = 3;
            this.upper.TabStop = true;
            this.upper.Text = "Copy Uppercase Leters";
            this.upper.UseVisualStyleBackColor = true;
            // 
            // lower
            // 
            this.lower.AutoSize = true;
            this.lower.Location = new System.Drawing.Point(16, 130);
            this.lower.Name = "lower";
            this.lower.Size = new System.Drawing.Size(139, 17);
            this.lower.TabIndex = 4;
            this.lower.TabStop = true;
            this.lower.Text = "Copy Lowercase Letters";
            this.lower.UseVisualStyleBackColor = true;
            // 
            // digits
            // 
            this.digits.AutoSize = true;
            this.digits.Location = new System.Drawing.Point(16, 153);
            this.digits.Name = "digits";
            this.digits.Size = new System.Drawing.Size(78, 17);
            this.digits.TabIndex = 5;
            this.digits.TabStop = true;
            this.digits.Text = "Copy Digits";
            this.digits.UseVisualStyleBackColor = true;
            // 
            // special
            // 
            this.special.AutoSize = true;
            this.special.Location = new System.Drawing.Point(16, 176);
            this.special.Name = "special";
            this.special.Size = new System.Drawing.Size(141, 17);
            this.special.TabIndex = 6;
            this.special.TabStop = true;
            this.special.Text = "Copy Special Characters";
            this.special.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Output";
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(57, 229);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(100, 20);
            this.output.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.output);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.special);
            this.Controls.Add(this.digits);
            this.Controls.Add(this.lower);
            this.Controls.Add(this.upper);
            this.Controls.Add(this.count);
            this.Controls.Add(this.input);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.RadioButton count;
        private System.Windows.Forms.RadioButton upper;
        private System.Windows.Forms.RadioButton lower;
        private System.Windows.Forms.RadioButton digits;
        private System.Windows.Forms.RadioButton special;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Button button1;
    }
}

