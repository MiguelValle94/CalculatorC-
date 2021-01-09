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
        string selectedOperator;
        int acumulatedValue;

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

        private void OperatorAction (object sender, EventArgs e)
        {
            Button button = (Button)sender;
            selectedOperator = button.Text;
            acumulatedValue = int.Parse(txtValue.Text);
            txtValue.Text = "0";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            txtValue.Text = "0";
            acumulatedValue = 0;
            selectedOperator = string.Empty;
        }

        private void buttonEq_Click(object sender, EventArgs e)
        {
            int secondAcumulatedVale = int.Parse(txtValue.Text);
            int result = 0;

            switch (selectedOperator)
            {
                case "+":
                    result = acumulatedValue + secondAcumulatedVale;
                    break;
                case "-":
                    result = acumulatedValue - secondAcumulatedVale;
                    break;
                case "*":
                    result = acumulatedValue * secondAcumulatedVale;
                    break;
                case "/":
                    result = acumulatedValue / secondAcumulatedVale;
                    break;
            }

            txtValue.Text = result.ToString();
        }
    }
}
