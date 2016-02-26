using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ModbusRTU_Master
{
    public partial class frmInputValue : Form
    {
        public frmInputValue()
        {
            InitializeComponent();
        }
        public double Value
        {
            set
            {
                this.txtValue.Text = value.ToString();
            }
            get { return Convert_To_Double(this.txtValue.Text); }
        }

        public string StringValue
        {
            set
            {
                this.txtValue.Text = value;
            }
            get
            {
                return this.txtValue.Text;
            }
        }
        private double Convert_To_Double(string sKey)
        {
            if (sKey == "")
                sKey = "0";
            return double.Parse(sKey);
        }

        private void Number_Click(object sender, EventArgs e)
        {
            txtValue.Text = txtValue.Text + ((Button)sender).Tag;
        }

        private void btcommon_Click(object sender, EventArgs e)
        {
            if (txtValue.Text.IndexOf(".") < 0)
                txtValue.Text += ".";            
        }

        private void btdel_Click(object sender, EventArgs e)
        {
            txtValue.Text = txtValue.Text.Substring(0, txtValue.Text.Length - 1);
        }

        private void btClr_Click(object sender, EventArgs e)
        {
            txtValue.Text = "";
        }

        private void btMinus_Click(object sender, EventArgs e)
        {
            if (Convert_To_Double(txtValue.Text) > 0)
            {
                txtValue.Text = (Convert_To_Double(txtValue.Text) * (-1)).ToString();
            }
        }

        private void btPlus_Click(object sender, EventArgs e)
        {
            if (Convert_To_Double(txtValue.Text) < 0)
            {
                txtValue.Text = (Convert_To_Double(txtValue.Text) * (-1)).ToString();
            }
        }
    }
}