namespace ModbusRTU_Master
{
    partial class frmInputValue
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
            this.txtValue = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.btcommon = new System.Windows.Forms.Button();
            this.btdel = new System.Windows.Forms.Button();
            this.btMinus = new System.Windows.Forms.Button();
            this.btPlus = new System.Windows.Forms.Button();
            this.btClr = new System.Windows.Forms.Button();
            this.btnok = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(22, 15);
            this.txtValue.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(291, 30);
            this.txtValue.TabIndex = 0;
            this.txtValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 41);
            this.button1.TabIndex = 1;
            this.button1.Tag = "0";
            this.button1.Text = "0";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Number_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(22, 153);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 41);
            this.button2.TabIndex = 2;
            this.button2.Tag = "1";
            this.button2.Text = "1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Number_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(74, 153);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(46, 41);
            this.button3.TabIndex = 3;
            this.button3.Tag = "2";
            this.button3.Text = "2";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Number_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(126, 153);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(46, 41);
            this.button4.TabIndex = 4;
            this.button4.Tag = "3";
            this.button4.Text = "3";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Number_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(22, 106);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(46, 41);
            this.button5.TabIndex = 5;
            this.button5.Tag = "4";
            this.button5.Text = "4";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Number_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(74, 106);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(46, 41);
            this.button6.TabIndex = 6;
            this.button6.Tag = "5";
            this.button6.Text = "5";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Number_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(126, 106);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(46, 41);
            this.button7.TabIndex = 7;
            this.button7.Tag = "6";
            this.button7.Text = "6";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Number_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(22, 59);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(46, 41);
            this.button8.TabIndex = 8;
            this.button8.Tag = "7";
            this.button8.Text = "7";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Number_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(74, 59);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(46, 41);
            this.button9.TabIndex = 9;
            this.button9.Tag = "8";
            this.button9.Text = "8";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Number_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(126, 59);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(46, 41);
            this.button10.TabIndex = 10;
            this.button10.Tag = "9";
            this.button10.Text = "9";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.Number_Click);
            // 
            // btcommon
            // 
            this.btcommon.Location = new System.Drawing.Point(74, 200);
            this.btcommon.Name = "btcommon";
            this.btcommon.Size = new System.Drawing.Size(46, 41);
            this.btcommon.TabIndex = 11;
            this.btcommon.Tag = "";
            this.btcommon.Text = ".";
            this.btcommon.UseVisualStyleBackColor = true;
            this.btcommon.Click += new System.EventHandler(this.btcommon_Click);
            // 
            // btdel
            // 
            this.btdel.Location = new System.Drawing.Point(126, 200);
            this.btdel.Name = "btdel";
            this.btdel.Size = new System.Drawing.Size(46, 41);
            this.btdel.TabIndex = 12;
            this.btdel.Tag = "";
            this.btdel.Text = "<";
            this.btdel.UseVisualStyleBackColor = true;
            this.btdel.Click += new System.EventHandler(this.btdel_Click);
            // 
            // btMinus
            // 
            this.btMinus.Location = new System.Drawing.Point(178, 59);
            this.btMinus.Name = "btMinus";
            this.btMinus.Size = new System.Drawing.Size(46, 41);
            this.btMinus.TabIndex = 13;
            this.btMinus.Tag = "";
            this.btMinus.Text = "-";
            this.btMinus.UseVisualStyleBackColor = true;
            this.btMinus.Click += new System.EventHandler(this.btMinus_Click);
            // 
            // btPlus
            // 
            this.btPlus.Location = new System.Drawing.Point(178, 106);
            this.btPlus.Name = "btPlus";
            this.btPlus.Size = new System.Drawing.Size(46, 41);
            this.btPlus.TabIndex = 14;
            this.btPlus.Tag = "";
            this.btPlus.Text = "+";
            this.btPlus.UseVisualStyleBackColor = true;
            this.btPlus.Click += new System.EventHandler(this.btPlus_Click);
            // 
            // btClr
            // 
            this.btClr.Location = new System.Drawing.Point(178, 153);
            this.btClr.Name = "btClr";
            this.btClr.Size = new System.Drawing.Size(46, 41);
            this.btClr.TabIndex = 15;
            this.btClr.Tag = "";
            this.btClr.Text = "C";
            this.btClr.UseVisualStyleBackColor = true;
            this.btClr.Click += new System.EventHandler(this.btClr_Click);
            // 
            // btnok
            // 
            this.btnok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnok.Location = new System.Drawing.Point(230, 59);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(83, 41);
            this.btnok.TabIndex = 16;
            this.btnok.Tag = "";
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = true;
            // 
            // btncancel
            // 
            this.btncancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancel.Location = new System.Drawing.Point(230, 106);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(83, 41);
            this.btncancel.TabIndex = 17;
            this.btncancel.Tag = "";
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            // 
            // frmInputValue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 257);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.btClr);
            this.Controls.Add(this.btPlus);
            this.Controls.Add(this.btMinus);
            this.Controls.Add(this.btdel);
            this.Controls.Add(this.btcommon);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtValue);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmInputValue";
            this.Text = "InputValue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button btcommon;
        private System.Windows.Forms.Button btdel;
        private System.Windows.Forms.Button btMinus;
        private System.Windows.Forms.Button btPlus;
        private System.Windows.Forms.Button btClr;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Button btncancel;
    }
}