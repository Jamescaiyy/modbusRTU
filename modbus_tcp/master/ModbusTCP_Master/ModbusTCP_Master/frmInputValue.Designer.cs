namespace ModbusTCP_Master
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
            this.btdel = new System.Windows.Forms.Button();
            this.btcommon = new System.Windows.Forms.Button();
            this.bt0 = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.btClr = new System.Windows.Forms.Button();
            this.btMinus = new System.Windows.Forms.Button();
            this.btPlus = new System.Windows.Forms.Button();
            this.btncancal = new System.Windows.Forms.Button();
            this.btnok = new System.Windows.Forms.Button();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btdel
            // 
            this.btdel.Location = new System.Drawing.Point(105, 169);
            this.btdel.Name = "btdel";
            this.btdel.Size = new System.Drawing.Size(41, 35);
            this.btdel.TabIndex = 43;
            this.btdel.Text = "<";
            this.btdel.UseVisualStyleBackColor = true;
            this.btdel.Click += new System.EventHandler(this.btdel_Click);
            // 
            // btcommon
            // 
            this.btcommon.Location = new System.Drawing.Point(58, 169);
            this.btcommon.Name = "btcommon";
            this.btcommon.Size = new System.Drawing.Size(41, 35);
            this.btcommon.TabIndex = 42;
            this.btcommon.Text = ".";
            this.btcommon.UseVisualStyleBackColor = true;
            this.btcommon.Click += new System.EventHandler(this.btcommon_Click);
            // 
            // bt0
            // 
            this.bt0.Location = new System.Drawing.Point(11, 169);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(41, 35);
            this.bt0.TabIndex = 41;
            this.bt0.Tag = "0";
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = true;
            this.bt0.Click += new System.EventHandler(this.Number_Click);
            // 
            // bt9
            // 
            this.bt9.Location = new System.Drawing.Point(105, 48);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(41, 35);
            this.bt9.TabIndex = 40;
            this.bt9.Tag = "9";
            this.bt9.Text = "9";
            this.bt9.UseVisualStyleBackColor = true;
            this.bt9.Click += new System.EventHandler(this.Number_Click);
            // 
            // bt8
            // 
            this.bt8.Location = new System.Drawing.Point(58, 48);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(41, 35);
            this.bt8.TabIndex = 39;
            this.bt8.Tag = "8";
            this.bt8.Text = "8";
            this.bt8.UseVisualStyleBackColor = true;
            this.bt8.Click += new System.EventHandler(this.Number_Click);
            // 
            // bt7
            // 
            this.bt7.Location = new System.Drawing.Point(11, 48);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(41, 35);
            this.bt7.TabIndex = 38;
            this.bt7.Tag = "7";
            this.bt7.Text = "7";
            this.bt7.UseVisualStyleBackColor = true;
            this.bt7.Click += new System.EventHandler(this.Number_Click);
            // 
            // bt6
            // 
            this.bt6.Location = new System.Drawing.Point(105, 89);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(41, 35);
            this.bt6.TabIndex = 37;
            this.bt6.Tag = "6";
            this.bt6.Text = "6";
            this.bt6.UseVisualStyleBackColor = true;
            this.bt6.Click += new System.EventHandler(this.Number_Click);
            // 
            // bt5
            // 
            this.bt5.Location = new System.Drawing.Point(58, 89);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(41, 35);
            this.bt5.TabIndex = 36;
            this.bt5.Tag = "5";
            this.bt5.Text = "5";
            this.bt5.UseVisualStyleBackColor = true;
            this.bt5.Click += new System.EventHandler(this.Number_Click);
            // 
            // bt4
            // 
            this.bt4.Location = new System.Drawing.Point(11, 89);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(41, 35);
            this.bt4.TabIndex = 35;
            this.bt4.Tag = "4";
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = true;
            this.bt4.Click += new System.EventHandler(this.Number_Click);
            // 
            // bt3
            // 
            this.bt3.Location = new System.Drawing.Point(105, 128);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(41, 35);
            this.bt3.TabIndex = 34;
            this.bt3.Tag = "3";
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.Number_Click);
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(58, 128);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(41, 35);
            this.bt2.TabIndex = 33;
            this.bt2.Tag = "2";
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.Number_Click);
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(11, 128);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(41, 35);
            this.bt1.TabIndex = 32;
            this.bt1.Tag = "1";
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.Number_Click);
            // 
            // btClr
            // 
            this.btClr.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btClr.Location = new System.Drawing.Point(152, 128);
            this.btClr.Name = "btClr";
            this.btClr.Size = new System.Drawing.Size(41, 35);
            this.btClr.TabIndex = 31;
            this.btClr.Text = "C";
            this.btClr.Click += new System.EventHandler(this.btClr_Click);
            // 
            // btMinus
            // 
            this.btMinus.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.btMinus.Location = new System.Drawing.Point(152, 48);
            this.btMinus.Name = "btMinus";
            this.btMinus.Size = new System.Drawing.Size(41, 35);
            this.btMinus.TabIndex = 30;
            this.btMinus.Text = "-";
            this.btMinus.Click += new System.EventHandler(this.btMinus_Click);
            // 
            // btPlus
            // 
            this.btPlus.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.btPlus.Location = new System.Drawing.Point(152, 89);
            this.btPlus.Name = "btPlus";
            this.btPlus.Size = new System.Drawing.Size(41, 35);
            this.btPlus.TabIndex = 29;
            this.btPlus.Text = "+";
            this.btPlus.Click += new System.EventHandler(this.btPlus_Click);
            // 
            // btncancal
            // 
            this.btncancal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btncancal.Location = new System.Drawing.Point(199, 89);
            this.btncancal.Name = "btncancal";
            this.btncancal.Size = new System.Drawing.Size(72, 35);
            this.btncancal.TabIndex = 28;
            this.btncancal.Text = "Cancel";
            // 
            // btnok
            // 
            this.btnok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnok.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnok.Location = new System.Drawing.Point(199, 48);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(72, 35);
            this.btnok.TabIndex = 27;
            this.btnok.Text = "OK";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(11, 10);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(260, 31);
            this.txtValue.TabIndex = 26;
            this.txtValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmInputValue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 212);
            this.Controls.Add(this.btdel);
            this.Controls.Add(this.btcommon);
            this.Controls.Add(this.bt0);
            this.Controls.Add(this.bt9);
            this.Controls.Add(this.bt8);
            this.Controls.Add(this.bt7);
            this.Controls.Add(this.bt6);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.btClr);
            this.Controls.Add(this.btMinus);
            this.Controls.Add(this.btPlus);
            this.Controls.Add(this.btncancal);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.txtValue);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "frmInputValue";
            this.Text = "frmInputValue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btdel;
        private System.Windows.Forms.Button btcommon;
        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button btClr;
        private System.Windows.Forms.Button btMinus;
        private System.Windows.Forms.Button btPlus;
        private System.Windows.Forms.Button btncancal;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.TextBox txtValue;
    }
}