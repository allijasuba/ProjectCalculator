using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCalculator
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        float num, ans;
        int count;

        public void disable()
        {
            txtBox.Enabled = false;
            button1.Show();
            button2.Hide();
            btnOne.Enabled = false;
            btnTwo.Enabled = false;
            btnThree.Enabled = false;
            btnFour.Enabled = false;
            btnFive.Enabled = false;
            btnSix.Enabled = false;
            btnSeven.Enabled = false;
            btnEight.Enabled = false;
            btnNine.Enabled = false;
            btnZero.Enabled = false;
            btnDot.Enabled = false;
            btnClear.Enabled = false;
            btnPlus.Enabled = false;
            btnMinus.Enabled = false;
            btnMultiply.Enabled = false;
            btnDivide.Enabled = false;
            btnEquals.Enabled = false;
            btnBack.Enabled = false;

        }

        public void enable()
        {
            txtBox.Enabled = true;
            button1.Hide();
            button2.Show();
            btnOne.Enabled = true;
            btnTwo.Enabled = true;
            btnThree.Enabled = true;
            btnFour.Enabled = true;
            btnFive.Enabled = true;
            btnSix.Enabled = true;
            btnSeven.Enabled = true;
            btnEight.Enabled = true;
            btnNine.Enabled = true;
            btnZero.Enabled = true;
            btnDot.Enabled = true;
            btnClear.Enabled = true;
            btnPlus.Enabled = true;
            btnMinus.Enabled = true;
            btnMultiply.Enabled = true;
            btnDivide.Enabled = true;
            btnEquals.Enabled = true;
            btnBack.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            if (txtBox.Text.Length > 0)
            {
                txtBox.Text = txtBox.Text.Remove(txtBox.Text.Length - 1, 1);
            }
        }


        private void btnButton1_Click(object sender, EventArgs e)
        {
            enable();
        }

        private void btnButton2_Click(object sender, EventArgs e)
        {
            disable();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBox.Clear();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            num = float.Parse(txtBox.Text);
            txtBox.Clear();
            txtBox.Focus();
            count = 1;
            label.Text = num.ToString() + "+";
        }


        private void btnMinus_Click(object sender, EventArgs e)
        {
            num = float.Parse(txtBox.Text);
            txtBox.Clear();
            txtBox.Focus();
            count = 2;
            label.Text = num.ToString() + "-";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            num = float.Parse(txtBox.Text);
            txtBox.Clear();
            txtBox.Focus();
            count = 3;
            label.Text = num.ToString() + "*";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            num = float.Parse(txtBox.Text);
            txtBox.Clear();
            txtBox.Focus();
            count = 4;
            label.Text = num.ToString() + "/";
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            compute();
            label.Text = "";
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            txtBox.Text = txtBox.Text + b.Text;
        }

        public void compute()
        {
                switch(count)
                {
                    case 1:
                    ans = num + float.Parse(txtBox.Text);
                    txtBox.Text = ans.ToString();
                    break;

                case 2:
                    ans = num - float.Parse(txtBox.Text);
                    txtBox.Text = ans.ToString();
                    break;

                case 3:
                    ans = num * float.Parse(txtBox.Text);
                    txtBox.Text = ans.ToString();
                    break;

                    case 4:
                    ans = num / float.Parse(txtBox.Text);
                    txtBox.Text = ans.ToString();
                    break;

                    default:
                    break;
                }
        }
    }
        

}
