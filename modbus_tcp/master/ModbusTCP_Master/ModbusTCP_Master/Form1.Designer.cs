namespace ModbusTCP_Master
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
            this.AO3 = new System.Windows.Forms.TextBox();
            this.AO2 = new System.Windows.Forms.TextBox();
            this.AO1 = new System.Windows.Forms.TextBox();
            this.AO0 = new System.Windows.Forms.TextBox();
            this.AI3 = new System.Windows.Forms.TextBox();
            this.AI2 = new System.Windows.Forms.TextBox();
            this.AI1 = new System.Windows.Forms.TextBox();
            this.AI0 = new System.Windows.Forms.TextBox();
            this.DO3 = new System.Windows.Forms.PictureBox();
            this.DO2 = new System.Windows.Forms.PictureBox();
            this.DO1 = new System.Windows.Forms.PictureBox();
            this.DO0 = new System.Windows.Forms.PictureBox();
            this.DI3 = new System.Windows.Forms.PictureBox();
            this.DI2 = new System.Windows.Forms.PictureBox();
            this.DI1 = new System.Windows.Forms.PictureBox();
            this.DI0 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btStop = new System.Windows.Forms.Button();
            this.btStart = new System.Windows.Forms.Button();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DO3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DO2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DO1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DO0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DI3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DI2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DI1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DI0)).BeginInit();
            this.SuspendLayout();
            // 
            // AO3
            // 
            this.AO3.BackColor = System.Drawing.Color.White;
            this.AO3.Location = new System.Drawing.Point(419, 343);
            this.AO3.Name = "AO3";
            this.AO3.ReadOnly = true;
            this.AO3.Size = new System.Drawing.Size(110, 31);
            this.AO3.TabIndex = 71;
            this.AO3.Tag = "3";
            this.AO3.Click += new System.EventHandler(this.AO_Click);
            // 
            // AO2
            // 
            this.AO2.BackColor = System.Drawing.Color.White;
            this.AO2.Location = new System.Drawing.Point(303, 343);
            this.AO2.Name = "AO2";
            this.AO2.ReadOnly = true;
            this.AO2.Size = new System.Drawing.Size(110, 31);
            this.AO2.TabIndex = 70;
            this.AO2.Tag = "2";
            this.AO2.Click += new System.EventHandler(this.AO_Click);
            // 
            // AO1
            // 
            this.AO1.BackColor = System.Drawing.Color.White;
            this.AO1.Location = new System.Drawing.Point(187, 343);
            this.AO1.Name = "AO1";
            this.AO1.ReadOnly = true;
            this.AO1.Size = new System.Drawing.Size(110, 31);
            this.AO1.TabIndex = 69;
            this.AO1.Tag = "1";
            this.AO1.Click += new System.EventHandler(this.AO_Click);
            // 
            // AO0
            // 
            this.AO0.BackColor = System.Drawing.Color.White;
            this.AO0.Location = new System.Drawing.Point(71, 343);
            this.AO0.Name = "AO0";
            this.AO0.ReadOnly = true;
            this.AO0.Size = new System.Drawing.Size(110, 31);
            this.AO0.TabIndex = 68;
            this.AO0.Tag = "0";
            this.AO0.Click += new System.EventHandler(this.AO_Click);
            // 
            // AI3
            // 
            this.AI3.BackColor = System.Drawing.Color.White;
            this.AI3.Location = new System.Drawing.Point(419, 264);
            this.AI3.Name = "AI3";
            this.AI3.ReadOnly = true;
            this.AI3.Size = new System.Drawing.Size(110, 31);
            this.AI3.TabIndex = 67;
            // 
            // AI2
            // 
            this.AI2.BackColor = System.Drawing.Color.White;
            this.AI2.Location = new System.Drawing.Point(303, 264);
            this.AI2.Name = "AI2";
            this.AI2.ReadOnly = true;
            this.AI2.Size = new System.Drawing.Size(110, 31);
            this.AI2.TabIndex = 66;
            // 
            // AI1
            // 
            this.AI1.BackColor = System.Drawing.Color.White;
            this.AI1.Location = new System.Drawing.Point(187, 264);
            this.AI1.Name = "AI1";
            this.AI1.ReadOnly = true;
            this.AI1.Size = new System.Drawing.Size(110, 31);
            this.AI1.TabIndex = 65;
            // 
            // AI0
            // 
            this.AI0.BackColor = System.Drawing.Color.White;
            this.AI0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AI0.Location = new System.Drawing.Point(71, 264);
            this.AI0.Name = "AI0";
            this.AI0.ReadOnly = true;
            this.AI0.Size = new System.Drawing.Size(110, 31);
            this.AI0.TabIndex = 64;
            // 
            // DO3
            // 
            this.DO3.BackColor = System.Drawing.Color.Maroon;
            this.DO3.Location = new System.Drawing.Point(245, 176);
            this.DO3.Name = "DO3";
            this.DO3.Size = new System.Drawing.Size(52, 49);
            this.DO3.TabIndex = 63;
            this.DO3.TabStop = false;
            this.DO3.Tag = "3";
            this.DO3.Click += new System.EventHandler(this.DO_Click);
            // 
            // DO2
            // 
            this.DO2.BackColor = System.Drawing.Color.Maroon;
            this.DO2.Location = new System.Drawing.Point(187, 176);
            this.DO2.Name = "DO2";
            this.DO2.Size = new System.Drawing.Size(52, 49);
            this.DO2.TabIndex = 62;
            this.DO2.TabStop = false;
            this.DO2.Tag = "2";
            this.DO2.Click += new System.EventHandler(this.DO_Click);
            // 
            // DO1
            // 
            this.DO1.BackColor = System.Drawing.Color.Maroon;
            this.DO1.Location = new System.Drawing.Point(129, 176);
            this.DO1.Name = "DO1";
            this.DO1.Size = new System.Drawing.Size(52, 49);
            this.DO1.TabIndex = 61;
            this.DO1.TabStop = false;
            this.DO1.Tag = "1";
            this.DO1.Click += new System.EventHandler(this.DO_Click);
            // 
            // DO0
            // 
            this.DO0.BackColor = System.Drawing.Color.Maroon;
            this.DO0.Location = new System.Drawing.Point(71, 176);
            this.DO0.Name = "DO0";
            this.DO0.Size = new System.Drawing.Size(52, 49);
            this.DO0.TabIndex = 60;
            this.DO0.TabStop = false;
            this.DO0.Tag = "0";
            this.DO0.Click += new System.EventHandler(this.DO_Click);
            // 
            // DI3
            // 
            this.DI3.BackColor = System.Drawing.Color.Green;
            this.DI3.Location = new System.Drawing.Point(245, 82);
            this.DI3.Name = "DI3";
            this.DI3.Size = new System.Drawing.Size(52, 49);
            this.DI3.TabIndex = 59;
            this.DI3.TabStop = false;
            // 
            // DI2
            // 
            this.DI2.BackColor = System.Drawing.Color.Green;
            this.DI2.Location = new System.Drawing.Point(187, 82);
            this.DI2.Name = "DI2";
            this.DI2.Size = new System.Drawing.Size(52, 49);
            this.DI2.TabIndex = 58;
            this.DI2.TabStop = false;
            // 
            // DI1
            // 
            this.DI1.BackColor = System.Drawing.Color.Green;
            this.DI1.Location = new System.Drawing.Point(129, 82);
            this.DI1.Name = "DI1";
            this.DI1.Size = new System.Drawing.Size(52, 49);
            this.DI1.TabIndex = 57;
            this.DI1.TabStop = false;
            // 
            // DI0
            // 
            this.DI0.BackColor = System.Drawing.Color.Green;
            this.DI0.Location = new System.Drawing.Point(71, 82);
            this.DI0.Name = "DI0";
            this.DI0.Size = new System.Drawing.Size(52, 49);
            this.DI0.TabIndex = 56;
            this.DI0.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 25);
            this.label5.TabIndex = 55;
            this.label5.Text = "AO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 25);
            this.label4.TabIndex = 54;
            this.label4.Text = "AI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 25);
            this.label3.TabIndex = 53;
            this.label3.Text = "DO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 25);
            this.label2.TabIndex = 52;
            this.label2.Text = "DI";
            // 
            // btStop
            // 
            this.btStop.Location = new System.Drawing.Point(442, 8);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(96, 38);
            this.btStop.TabIndex = 51;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(340, 8);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(96, 38);
            this.btStart.TabIndex = 50;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(144, 12);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(162, 31);
            this.txtIP.TabIndex = 49;
            this.txtIP.Text = "10.0.0.69";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 48;
            this.label1.Text = "IP Address:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 417);
            this.Controls.Add(this.AO3);
            this.Controls.Add(this.AO2);
            this.Controls.Add(this.AO1);
            this.Controls.Add(this.AO0);
            this.Controls.Add(this.AI3);
            this.Controls.Add(this.AI2);
            this.Controls.Add(this.AI1);
            this.Controls.Add(this.AI0);
            this.Controls.Add(this.DO3);
            this.Controls.Add(this.DO2);
            this.Controls.Add(this.DO1);
            this.Controls.Add(this.DO0);
            this.Controls.Add(this.DI3);
            this.Controls.Add(this.DI2);
            this.Controls.Add(this.DI1);
            this.Controls.Add(this.DI0);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DO3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DO2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DO1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DO0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DI3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DI2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DI1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DI0)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AO3;
        private System.Windows.Forms.TextBox AO2;
        private System.Windows.Forms.TextBox AO1;
        private System.Windows.Forms.TextBox AO0;
        private System.Windows.Forms.TextBox AI3;
        private System.Windows.Forms.TextBox AI2;
        private System.Windows.Forms.TextBox AI1;
        private System.Windows.Forms.TextBox AI0;
        private System.Windows.Forms.PictureBox DO3;
        private System.Windows.Forms.PictureBox DO2;
        private System.Windows.Forms.PictureBox DO1;
        private System.Windows.Forms.PictureBox DO0;
        private System.Windows.Forms.PictureBox DI3;
        private System.Windows.Forms.PictureBox DI2;
        private System.Windows.Forms.PictureBox DI1;
        private System.Windows.Forms.PictureBox DI0;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}

