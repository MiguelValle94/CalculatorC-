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
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonNum1_Click(object sender, EventArgs e)
        {
            txtValue.Text = "1";
        }

        private void buttonNum2_Click(object sender, EventArgs e)
        {
            txtValue.Text = "2";
        }

        private void buttonNum3_Click(object sender, EventArgs e)
        {
            txtValue.Text = "3";
        }

        private void buttonNum4_Click(object sender, EventArgs e)
        {
            txtValue.Text = "4";
        }

        private void buttonNum5_Click(object sender, EventArgs e)
        {
            txtValue.Text = "5";
        }

        private void buttonNum6_Click(object sender, EventArgs e)
        {
            txtValue.Text = "6";
        }

        private void buttonNum7_Click(object sender, EventArgs e)
        {
            txtValue.Text = "7";
        }

        private void buttonNum8_Click(object sender, EventArgs e)
        {
            txtValue.Text = "8";
        }

        private void buttonNum9_Click(object sender, EventArgs e)
        {
            txtValue.Text = "9";
        }

        private void buttonNum0_Click(object sender, EventArgs e)
        {
            txtValue.Text = "0";
        }
    }
}
