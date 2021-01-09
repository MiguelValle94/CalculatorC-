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

        private void NumberAction(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int buttonValue = int.Parse(button.Text);
            int currentValue = int.Parse(txtValue.Text);
            currentValue = currentValue * 10 + buttonValue;
            txtValue.Text = currentValue.ToString();
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            txtValue.Text = "0";
        }
    }
}
