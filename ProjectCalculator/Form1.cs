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

        private void btnNine_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + "9";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (txtBox.Text.Length > 0)
            {
                txtBox.Text = txtBox.Text.Remove(txtBox.Text.Length - 1, 1);
            }
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + "3";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + "7";
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + "8";
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + "4";
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + "5";
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + "6";
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + "1";
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + "2";
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + "0";
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + ".";
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
    }
        

}
