namespace ModbusRTU_Master
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
            this.components = new System.ComponentModel.Container();
            this.openbtn = new System.Windows.Forms.Button();
            this.closebtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comcmb = new System.Windows.Forms.ComboBox();
            this.baudcmb = new System.Windows.Forms.ComboBox();
            this.dbcmb = new System.Windows.Forms.ComboBox();
            this.ptycmb = new System.Windows.Forms.ComboBox();
            this.sbcmb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.AI0 = new System.Windows.Forms.TextBox();
            this.AI1 = new System.Windows.Forms.TextBox();
            this.AI2 = new System.Windows.Forms.TextBox();
            this.AI3 = new System.Windows.Forms.TextBox();
            this.AO0 = new System.Windows.Forms.TextBox();
            this.AO1 = new System.Windows.Forms.TextBox();
            this.AO2 = new System.Windows.Forms.TextBox();
            this.AO3 = new System.Windows.Forms.TextBox();
            this.DI0 = new System.Windows.Forms.PictureBox();
            this.DI1 = new System.Windows.Forms.PictureBox();
            this.DI2 = new System.Windows.Forms.PictureBox();
            this.DI3 = new System.Windows.Forms.PictureBox();
            this.DO0 = new System.Windows.Forms.PictureBox();
            this.DO1 = new System.Windows.Forms.PictureBox();
            this.DO2 = new System.Windows.Forms.PictureBox();
            this.DO3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DI0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DI1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DI2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DI3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DO0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DO1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DO2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DO3)).BeginInit();
            this.SuspendLayout();
            // 
            // openbtn
            // 
            this.openbtn.Location = new System.Drawing.Point(718, 69);
            this.openbtn.Margin = new System.Windows.Forms.Padding(5);
            this.openbtn.Name = "openbtn";
            this.openbtn.Size = new System.Drawing.Size(135, 43);
            this.openbtn.TabIndex = 0;
            this.openbtn.Text = "Open COM";
            this.openbtn.UseVisualStyleBackColor = true;
            this.openbtn.Click += new System.EventHandler(this.openbtn_Click);
            // 
            // closebtn
            // 
            this.closebtn.Location = new System.Drawing.Point(718, 131);
            this.closebtn.Margin = new System.Windows.Forms.Padding(4);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(135, 41);
            this.closebtn.TabIndex = 1;
            this.closebtn.Text = "Close COM";
            this.closebtn.UseVisualStyleBackColor = true;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Com";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Baud.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(366, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data Bit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(533, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Parity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(704, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Stop Bit";
            // 
            // comcmb
            // 
            this.comcmb.FormattingEnabled = true;
            this.comcmb.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM7"});
            this.comcmb.Location = new System.Drawing.Point(66, 18);
            this.comcmb.Margin = new System.Windows.Forms.Padding(4);
            this.comcmb.Name = "comcmb";
            this.comcmb.Size = new System.Drawing.Size(93, 31);
            this.comcmb.TabIndex = 7;
            // 
            // baudcmb
            // 
            this.baudcmb.FormattingEnabled = true;
            this.baudcmb.Items.AddRange(new object[] {
            "115200",
            "9600"});
            this.baudcmb.Location = new System.Drawing.Point(246, 19);
            this.baudcmb.Margin = new System.Windows.Forms.Padding(4);
            this.baudcmb.Name = "baudcmb";
            this.baudcmb.Size = new System.Drawing.Size(100, 31);
            this.baudcmb.TabIndex = 8;
            // 
            // dbcmb
            // 
            this.dbcmb.FormattingEnabled = true;
            this.dbcmb.Items.AddRange(new object[] {
            "8",
            "7",
            "6",
            "5",
            "4"});
            this.dbcmb.Location = new System.Drawing.Point(450, 18);
            this.dbcmb.Margin = new System.Windows.Forms.Padding(4);
            this.dbcmb.Name = "dbcmb";
            this.dbcmb.Size = new System.Drawing.Size(52, 31);
            this.dbcmb.TabIndex = 9;
            // 
            // ptycmb
            // 
            this.ptycmb.FormattingEnabled = true;
            this.ptycmb.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd"});
            this.ptycmb.Location = new System.Drawing.Point(592, 18);
            this.ptycmb.Margin = new System.Windows.Forms.Padding(4);
            this.ptycmb.Name = "ptycmb";
            this.ptycmb.Size = new System.Drawing.Size(91, 31);
            this.ptycmb.TabIndex = 10;
            // 
            // sbcmb
            // 
            this.sbcmb.FormattingEnabled = true;
            this.sbcmb.Items.AddRange(new object[] {
            "1",
            "2"});
            this.sbcmb.Location = new System.Drawing.Point(787, 19);
            this.sbcmb.Margin = new System.Windows.Forms.Padding(4);
            this.sbcmb.Name = "sbcmb";
            this.sbcmb.Size = new System.Drawing.Size(66, 31);
            this.sbcmb.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 93);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "DI";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.No;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 168);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "DO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 232);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 23);
            this.label8.TabIndex = 14;
            this.label8.Text = "AI";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 290);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 23);
            this.label9.TabIndex = 15;
            this.label9.Text = "AO";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AI0
            // 
            this.AI0.Location = new System.Drawing.Point(66, 229);
            this.AI0.Margin = new System.Windows.Forms.Padding(4);
            this.AI0.Name = "AI0";
            this.AI0.Size = new System.Drawing.Size(113, 30);
            this.AI0.TabIndex = 26;
            // 
            // AI1
            // 
            this.AI1.Location = new System.Drawing.Point(196, 229);
            this.AI1.Margin = new System.Windows.Forms.Padding(4);
            this.AI1.Name = "AI1";
            this.AI1.Size = new System.Drawing.Size(113, 30);
            this.AI1.TabIndex = 27;
            // 
            // AI2
            // 
            this.AI2.Location = new System.Drawing.Point(329, 229);
            this.AI2.Margin = new System.Windows.Forms.Padding(4);
            this.AI2.Name = "AI2";
            this.AI2.Size = new System.Drawing.Size(113, 30);
            this.AI2.TabIndex = 28;
            // 
            // AI3
            // 
            this.AI3.Location = new System.Drawing.Point(459, 229);
            this.AI3.Margin = new System.Windows.Forms.Padding(4);
            this.AI3.Name = "AI3";
            this.AI3.Size = new System.Drawing.Size(113, 30);
            this.AI3.TabIndex = 29;
            // 
            // AO0
            // 
            this.AO0.Location = new System.Drawing.Point(66, 287);
            this.AO0.Margin = new System.Windows.Forms.Padding(4);
            this.AO0.Name = "AO0";
            this.AO0.Size = new System.Drawing.Size(113, 30);
            this.AO0.TabIndex = 30;
            this.AO0.Tag = "0";
            this.AO0.Click += new System.EventHandler(this.AO_click);
            // 
            // AO1
            // 
            this.AO1.Location = new System.Drawing.Point(196, 287);
            this.AO1.Margin = new System.Windows.Forms.Padding(4);
            this.AO1.Name = "AO1";
            this.AO1.Size = new System.Drawing.Size(113, 30);
            this.AO1.TabIndex = 31;
            this.AO1.Tag = "1";
            this.AO1.Click += new System.EventHandler(this.AO_click);
            // 
            // AO2
            // 
            this.AO2.Location = new System.Drawing.Point(329, 287);
            this.AO2.Margin = new System.Windows.Forms.Padding(4);
            this.AO2.Name = "AO2";
            this.AO2.Size = new System.Drawing.Size(113, 30);
            this.AO2.TabIndex = 32;
            this.AO2.Tag = "2";
            this.AO2.Click += new System.EventHandler(this.AO_click);
            // 
            // AO3
            // 
            this.AO3.Location = new System.Drawing.Point(459, 287);
            this.AO3.Margin = new System.Windows.Forms.Padding(4);
            this.AO3.Name = "AO3";
            this.AO3.Size = new System.Drawing.Size(113, 30);
            this.AO3.TabIndex = 33;
            this.AO3.Tag = "3";
            this.AO3.Click += new System.EventHandler(this.AO_click);
            // 
            // DI0
            // 
            this.DI0.BackColor = System.Drawing.Color.Navy;
            this.DI0.Location = new System.Drawing.Point(66, 80);
            this.DI0.Name = "DI0";
            this.DI0.Size = new System.Drawing.Size(68, 50);
            this.DI0.TabIndex = 34;
            this.DI0.TabStop = false;
            // 
            // DI1
            // 
            this.DI1.BackColor = System.Drawing.Color.Navy;
            this.DI1.Location = new System.Drawing.Point(154, 80);
            this.DI1.Name = "DI1";
            this.DI1.Size = new System.Drawing.Size(68, 50);
            this.DI1.TabIndex = 35;
            this.DI1.TabStop = false;
            // 
            // DI2
            // 
            this.DI2.BackColor = System.Drawing.Color.Navy;
            this.DI2.Location = new System.Drawing.Point(241, 80);
            this.DI2.Name = "DI2";
            this.DI2.Size = new System.Drawing.Size(68, 50);
            this.DI2.TabIndex = 36;
            this.DI2.TabStop = false;
            // 
            // DI3
            // 
            this.DI3.BackColor = System.Drawing.Color.Navy;
            this.DI3.Location = new System.Drawing.Point(329, 80);
            this.DI3.Name = "DI3";
            this.DI3.Size = new System.Drawing.Size(68, 50);
            this.DI3.TabIndex = 37;
            this.DI3.TabStop = false;
            // 
            // DO0
            // 
            this.DO0.BackColor = System.Drawing.Color.DarkRed;
            this.DO0.Location = new System.Drawing.Point(66, 154);
            this.DO0.Name = "DO0";
            this.DO0.Size = new System.Drawing.Size(68, 50);
            this.DO0.TabIndex = 38;
            this.DO0.TabStop = false;
            this.DO0.Tag = "0";
            this.DO0.Click += new System.EventHandler(this.DO_click);
            // 
            // DO1
            // 
            this.DO1.BackColor = System.Drawing.Color.DarkRed;
            this.DO1.Location = new System.Drawing.Point(154, 154);
            this.DO1.Name = "DO1";
            this.DO1.Size = new System.Drawing.Size(68, 50);
            this.DO1.TabIndex = 39;
            this.DO1.TabStop = false;
            this.DO1.Tag = "1";
            this.DO1.Click += new System.EventHandler(this.DO_click);
            // 
            // DO2
            // 
            this.DO2.BackColor = System.Drawing.Color.DarkRed;
            this.DO2.Location = new System.Drawing.Point(241, 154);
            this.DO2.Name = "DO2";
            this.DO2.Size = new System.Drawing.Size(68, 50);
            this.DO2.TabIndex = 40;
            this.DO2.TabStop = false;
            this.DO2.Tag = "2";
            this.DO2.Click += new System.EventHandler(this.DO_click);
            // 
            // DO3
            // 
            this.DO3.BackColor = System.Drawing.Color.DarkRed;
            this.DO3.Location = new System.Drawing.Point(329, 154);
            this.DO3.Name = "DO3";
            this.DO3.Size = new System.Drawing.Size(68, 50);
            this.DO3.TabIndex = 41;
            this.DO3.TabStop = false;
            this.DO3.Tag = "3";
            this.DO3.Click += new System.EventHandler(this.DO_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 343);
            this.Controls.Add(this.DO3);
            this.Controls.Add(this.DO2);
            this.Controls.Add(this.DO1);
            this.Controls.Add(this.DO0);
            this.Controls.Add(this.DI3);
            this.Controls.Add(this.DI2);
            this.Controls.Add(this.DI1);
            this.Controls.Add(this.DI0);
            this.Controls.Add(this.AO3);
            this.Controls.Add(this.AO2);
            this.Controls.Add(this.AO1);
            this.Controls.Add(this.AO0);
            this.Controls.Add(this.AI3);
            this.Controls.Add(this.AI2);
            this.Controls.Add(this.AI1);
            this.Controls.Add(this.AI0);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sbcmb);
            this.Controls.Add(this.ptycmb);
            this.Controls.Add(this.dbcmb);
            this.Controls.Add(this.baudcmb);
            this.Controls.Add(this.comcmb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closebtn);
            this.Controls.Add(this.openbtn);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Modbus RTU_Master";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DI0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DI1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DI2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DI3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DO0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DO1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DO2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DO3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openbtn;
        private System.Windows.Forms.Button closebtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comcmb;
        private System.Windows.Forms.ComboBox baudcmb;
        private System.Windows.Forms.ComboBox dbcmb;
        private System.Windows.Forms.ComboBox ptycmb;
        private System.Windows.Forms.ComboBox sbcmb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox AI0;
        private System.Windows.Forms.TextBox AI1;
        private System.Windows.Forms.TextBox AI2;
        private System.Windows.Forms.TextBox AI3;
        private System.Windows.Forms.TextBox AO0;
        private System.Windows.Forms.TextBox AO1;
        private System.Windows.Forms.TextBox AO2;
        private System.Windows.Forms.TextBox AO3;
        private System.Windows.Forms.PictureBox DI0;
        private System.Windows.Forms.PictureBox DI1;
        private System.Windows.Forms.PictureBox DI2;
        private System.Windows.Forms.PictureBox DI3;
        private System.Windows.Forms.PictureBox DO0;
        private System.Windows.Forms.PictureBox DO1;
        private System.Windows.Forms.PictureBox DO2;
        private System.Windows.Forms.PictureBox DO3;
    }
}

