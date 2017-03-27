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
    public partial class FrmCalculator : Form
    {
        public FrmCalculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtCalcResult.Text = txtCalcResult.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtCalcResult.Text = txtCalcResult.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtCalcResult.Text = txtCalcResult.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtCalcResult.Text = txtCalcResult.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtCalcResult.Text = txtCalcResult.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtCalcResult.Text = txtCalcResult.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtCalcResult.Text = txtCalcResult.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtCalcResult.Text = txtCalcResult.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtCalcResult.Text = txtCalcResult.Text + "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            txtCalcResult.Text = txtCalcResult.Text + "0";
        }

        float num, ans;
        int count; 
        public void CalculateValue()
        {
            switch (count)
            {
                case 1: ans = num + float.Parse(txtCalcResult.Text);
                    txtCalcResult.Text = ans.ToString();
                    break;
                case 2:
                    ans = num + float.Parse(txtCalcResult.Text);
                    txtCalcResult.Text = ans.ToString();
                    break;
                case 3:
                    ans = num + float.Parse(txtCalcResult.Text);
                    txtCalcResult.Text = ans.ToString();
                    break;
                case 4:
                    ans = num + float.Parse(txtCalcResult.Text);
                    txtCalcResult.Text = ans.ToString();
                    break;
                default:
                    break;
            }
        }
    }
}
