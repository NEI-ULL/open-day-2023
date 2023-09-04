using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        bool nextClear = false;
        bool nextClearAll = false;

        private void ParseCalc(string calc)
        {
            DataTable dt = new DataTable();
            var a = dt.Compute(calc.Remove(calc.Length - 3, 2), "").ToString();
            double result = double.Parse(a);

            txtValue.Text = result.ToString();


        }

        private void AddToCalc(char c)
        {
            if ((c >= '0' && c <= '9') || c == '.' || c == ',')
            {
                if (c == ',') { c = '.'; }
                if ((nextClear || txtValue.Text == "0") && c != '.')
                {
                    txtValue.Text = "";
                }
                if (!(txtValue.Text.Contains(c) && c == '.'))
                {
                    txtValue.Text += c;
                }
                nextClear = false;
            }
            else if (("+-*/÷×=\r").Contains(c))
            {
                if (nextClearAll)
                {
                    txtCalc.Text = "";
                    nextClearAll = false;
                }

                if (c == '×') { c = '*'; }
                if (c == '÷') { c = '/'; }
                if (c == '\r') { c = '='; }

                if (!txtCalc.Text.Contains('='))
                {
                    txtCalc.Text += txtValue.Text + ' ' + c + ' ';
                }
                nextClear = true;
            }
            else if ("\b".Contains(c))
            {
                txtValue.Text = "0";
                if (c == '\b' && nextClear) { txtCalc.Text = ""; }
                nextClear = true;
            }
            if (c == '=')
            {
                ParseCalc(txtCalc.Text);
                nextClearAll = true;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            AddToCalc(e.KeyChar);
            e.Handled = false;
        }

        private void btnSymb_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            AddToCalc(btn.Text[0]);
        }

        private void btnClearError_Click(object sender, EventArgs e)
        {
            txtValue.Text = "0";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCalc.Text = "";
            txtValue.Text = "0";
        }

        private void btnInvert_Click(object sender, EventArgs e)
        {
            if (txtValue.Text != "0")
            {
                if (txtValue.Text[0] == '-')
                {
                    txtValue.Text = txtValue.Text.Remove(0, 1);
                }
                else if (nextClear)
                {
                    txtValue.Text = "0";
                }
                else
                {
                    txtValue.Text = '-' + txtValue.Text;
                }
            }
        }
    }
}
