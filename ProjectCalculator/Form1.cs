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

        private void button2_Click(object sender, EventArgs e)
        {

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

        }

        private void btnThree_Click(object sender, EventArgs e)
        {

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
    }
}
