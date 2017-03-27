using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc2
{
    public partial class CalcFrm : Form
    {
        Double resultValue = 0;
        string opereationPerformed = string.Empty;
        bool isOperationPerformed = false;
        public CalcFrm()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((txtCalcResult.Text=="0") || isOperationPerformed)
            {
                txtCalcResult.Clear();
            }

            isOperationPerformed = false;
            Button btn = (Button)sender;

            if (btn.Text==".")
            {
                if (!txtCalcResult.Text.Contains("."))
                {
                    txtCalcResult.Text = txtCalcResult.Text + btn.Text;
                }
            }
            else
            {
                txtCalcResult.Text = txtCalcResult.Text + btn.Text;
            }
           
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (resultValue != 0)
            {
                btnEqual.PerformClick();

                opereationPerformed = btn.Text;
                resultValue = double.Parse(txtCalcResult.Text);
                lblCurrentOperation.Text = resultValue + " " + opereationPerformed;
                isOperationPerformed = true;
            }
            else
            {
                opereationPerformed = btn.Text;
                resultValue = double.Parse(txtCalcResult.Text);
                lblCurrentOperation.Text = resultValue + " " + opereationPerformed;
                isOperationPerformed = true;
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtCalcResult.Text = "0";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCalcResult.Text = "0";
            resultValue = 0;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            switch (opereationPerformed)
            {
                case "+":
                    txtCalcResult.Text = (resultValue + double.Parse(txtCalcResult.Text)).ToString();
                    break;
                case "-":
                    txtCalcResult.Text = (resultValue - double.Parse(txtCalcResult.Text)).ToString();
                    break;
                case "/":
                    txtCalcResult.Text = (resultValue / double.Parse(txtCalcResult.Text)).ToString();
                    break;
                case "*":
                    txtCalcResult.Text = (resultValue * double.Parse(txtCalcResult.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultValue = double.Parse(txtCalcResult.Text);
            lblCurrentOperation.Text = string.Empty;
        }

        private void CalcFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
