namespace Calculator3
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
            this.t1 = new System.Windows.Forms.TextBox();
            this.num1 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.num7 = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.opAdd = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.opSub = new System.Windows.Forms.Button();
            this.num0 = new System.Windows.Forms.Button();
            this.numDec = new System.Windows.Forms.Button();
            this.opDiv = new System.Windows.Forms.Button();
            this.opMul = new System.Windows.Forms.Button();
            this.opEq = new System.Windows.Forms.Button();
            this.opClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // t1
            // 
            this.t1.Location = new System.Drawing.Point(12, 12);
            this.t1.Name = "t1";
            this.t1.ReadOnly = true;
            this.t1.Size = new System.Drawing.Size(134, 20);
            this.t1.TabIndex = 0;
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(12, 113);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(29, 23);
            this.num1.TabIndex = 2;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = true;
            this.num1.Click += new System.EventHandler(this.num_Clicked);
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(47, 113);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(29, 23);
            this.num2.TabIndex = 3;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = true;
            this.num2.Click += new System.EventHandler(this.num_Clicked);
            // 
            // num3
            // 
            this.num3.Location = new System.Drawing.Point(82, 113);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(29, 23);
            this.num3.TabIndex = 4;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = true;
            this.num3.Click += new System.EventHandler(this.num_Clicked);
            // 
            // num7
            // 
            this.num7.Location = new System.Drawing.Point(12, 55);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(29, 23);
            this.num7.TabIndex = 8;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = true;
            this.num7.Click += new System.EventHandler(this.num_Clicked);
            // 
            // num6
            // 
            this.num6.Location = new System.Drawing.Point(82, 84);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(29, 23);
            this.num6.TabIndex = 7;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = true;
            this.num6.Click += new System.EventHandler(this.num_Clicked);
            // 
            // num5
            // 
            this.num5.Location = new System.Drawing.Point(47, 84);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(29, 23);
            this.num5.TabIndex = 6;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = true;
            this.num5.Click += new System.EventHandler(this.num_Clicked);
            // 
            // num4
            // 
            this.num4.Location = new System.Drawing.Point(12, 84);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(29, 23);
            this.num4.TabIndex = 5;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = true;
            this.num4.Click += new System.EventHandler(this.num_Clicked);
            // 
            // opAdd
            // 
            this.opAdd.Location = new System.Drawing.Point(117, 55);
            this.opAdd.Name = "opAdd";
            this.opAdd.Size = new System.Drawing.Size(29, 23);
            this.opAdd.TabIndex = 11;
            this.opAdd.Text = "+";
            this.opAdd.UseVisualStyleBackColor = true;
            this.opAdd.Click += new System.EventHandler(this.op_Clicked);
            // 
            // num9
            // 
            this.num9.Location = new System.Drawing.Point(82, 55);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(29, 23);
            this.num9.TabIndex = 10;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = true;
            this.num9.Click += new System.EventHandler(this.num_Clicked);
            // 
            // num8
            // 
            this.num8.Location = new System.Drawing.Point(47, 55);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(29, 23);
            this.num8.TabIndex = 9;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = true;
            this.num8.Click += new System.EventHandler(this.num_Clicked);
            // 
            // opSub
            // 
            this.opSub.Location = new System.Drawing.Point(117, 84);
            this.opSub.Name = "opSub";
            this.opSub.Size = new System.Drawing.Size(29, 23);
            this.opSub.TabIndex = 16;
            this.opSub.Text = "-";
            this.opSub.UseVisualStyleBackColor = true;
            this.opSub.Click += new System.EventHandler(this.op_Clicked);
            // 
            // num0
            // 
            this.num0.Location = new System.Drawing.Point(12, 142);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(64, 23);
            this.num0.TabIndex = 14;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = true;
            this.num0.Click += new System.EventHandler(this.num_Clicked);
            // 
            // numDec
            // 
            this.numDec.Location = new System.Drawing.Point(82, 142);
            this.numDec.Name = "numDec";
            this.numDec.Size = new System.Drawing.Size(29, 23);
            this.numDec.TabIndex = 13;
            this.numDec.Text = ".";
            this.numDec.UseVisualStyleBackColor = true;
            this.numDec.Click += new System.EventHandler(this.num_Clicked);
            // 
            // opDiv
            // 
            this.opDiv.Location = new System.Drawing.Point(117, 113);
            this.opDiv.Name = "opDiv";
            this.opDiv.Size = new System.Drawing.Size(29, 23);
            this.opDiv.TabIndex = 20;
            this.opDiv.Text = "/";
            this.opDiv.UseVisualStyleBackColor = true;
            this.opDiv.Click += new System.EventHandler(this.op_Clicked);
            // 
            // opMul
            // 
            this.opMul.Location = new System.Drawing.Point(117, 142);
            this.opMul.Name = "opMul";
            this.opMul.Size = new System.Drawing.Size(29, 23);
            this.opMul.TabIndex = 19;
            this.opMul.Text = "*";
            this.opMul.UseVisualStyleBackColor = true;
            this.opMul.Click += new System.EventHandler(this.op_Clicked);
            // 
            // opEq
            // 
            this.opEq.Location = new System.Drawing.Point(82, 171);
            this.opEq.Name = "opEq";
            this.opEq.Size = new System.Drawing.Size(64, 23);
            this.opEq.TabIndex = 18;
            this.opEq.Text = "=";
            this.opEq.UseVisualStyleBackColor = true;
            this.opEq.Click += new System.EventHandler(this.op_Clicked);
            // 
            // opClear
            // 
            this.opClear.Location = new System.Drawing.Point(12, 171);
            this.opClear.Name = "opClear";
            this.opClear.Size = new System.Drawing.Size(64, 23);
            this.opClear.TabIndex = 17;
            this.opClear.Text = "clear";
            this.opClear.UseVisualStyleBackColor = true;
            this.opClear.Click += new System.EventHandler(this.opClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(159, 203);
            this.Controls.Add(this.opDiv);
            this.Controls.Add(this.opMul);
            this.Controls.Add(this.opEq);
            this.Controls.Add(this.opClear);
            this.Controls.Add(this.opSub);
            this.Controls.Add(this.num0);
            this.Controls.Add(this.numDec);
            this.Controls.Add(this.opAdd);
            this.Controls.Add(this.num9);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.t1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox t1;
        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button opAdd;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.Button opSub;
        private System.Windows.Forms.Button num0;
        private System.Windows.Forms.Button numDec;
        private System.Windows.Forms.Button opDiv;
        private System.Windows.Forms.Button opMul;
        private System.Windows.Forms.Button opEq;
        private System.Windows.Forms.Button opClear;
    }
}

