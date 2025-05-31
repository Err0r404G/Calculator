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
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        private bool IsOperator(char c)
        {
            return c == '+' || c == '-' || c == '*' || c == '/';
        }
        private void acButton_Click(object sender, EventArgs e)
        {
            inputBox.Text = "";
        }

        private void percentButton_Click(object sender, EventArgs e)
        {
            string input = inputBox.Text;

            int lastOperatorIndex = input.LastIndexOfAny(new char[] { '+', '-', '*', '/' });

            string lastNumber;
            string beforeLastNumber;

            if (lastOperatorIndex == -1)
            {
                lastNumber = input;
                beforeLastNumber = "";
            }
            else
            {
                lastNumber = input.Substring(lastOperatorIndex + 1);
                beforeLastNumber = input.Substring(0, lastOperatorIndex + 1);
            }

            if (double.TryParse(lastNumber, out double number))
            {
                double percentValue = number / 100.0;
                inputBox.Text = beforeLastNumber + percentValue.ToString();
            }
            else
            {
            }
        }


        private void sevenButton_Click(object sender, EventArgs e)
        {
            inputBox.Text += "7";
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            inputBox.Text += "8";
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            inputBox.Text += "9";
        }



        private void fourButton_Click(object sender, EventArgs e)
        {
            inputBox.Text += "4";
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            inputBox.Text += "5";
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            inputBox.Text += "6";
        }


        private void oneButton_Click(object sender, EventArgs e)
        {
            inputBox.Text += "1";
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            inputBox.Text += "2";
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            inputBox.Text += "3";
        }


        private void zeroButton_Click(object sender, EventArgs e)
        {
            inputBox.Text += "0";
        }

        private void zerozeroButton_Click(object sender, EventArgs e)
        {
            inputBox.Text += "00";
        }
        //Sum button event handler
        private void sumButton_Click(object sender, EventArgs e)
        {
            if (inputBox.Text.Length == 0)
                return;

            char lastChar = inputBox.Text[inputBox.Text.Length - 1];
            if (!IsOperator(lastChar))
            {
                inputBox.Text += "+";
            }
            else
            {
                inputBox.Text = inputBox.Text.Substring(0, inputBox.Text.Length - 1) + "+";
            }
        }
        //Sub button event handler
        private void subButton_Click(object sender, EventArgs e)
        {
            if (inputBox.Text.Length == 0)
                return;

            char lastChar = inputBox.Text[inputBox.Text.Length - 1];
            if (!IsOperator(lastChar))
            {
                inputBox.Text += "-";
            }
            else
            {

                inputBox.Text = inputBox.Text.Substring(0, inputBox.Text.Length - 1) + "-";
            }
        }


        //Multiply button event handler
        private void multiplyButton_Click(object sender, EventArgs e)
        {
            if (inputBox.Text.Length == 0)
                return;

            char lastChar = inputBox.Text[inputBox.Text.Length - 1];
            if (!IsOperator(lastChar))
            {
                inputBox.Text += "*";
            }
            else
            {

                inputBox.Text = inputBox.Text.Substring(0, inputBox.Text.Length - 1) + "*";
            }
        }

        //Divide button event handler
        private void divideButton_Click(object sender, EventArgs e)
        {
            if (inputBox.Text.Length == 0)
                return;

            char lastChar = inputBox.Text[inputBox.Text.Length - 1];
            if (!IsOperator(lastChar))
            {
                inputBox.Text += "/";
            }
            else
            {
                inputBox.Text = inputBox.Text.Substring(0, inputBox.Text.Length - 1) + "/";
            }
        }
        //dot button event handler
        private void dotButton_Click(object sender, EventArgs e)
        {
            int lastOperatorIndex = inputBox.Text.LastIndexOfAny(new char[] { '+', '-', '*', '/' });

            string lastNumber;
            if (lastOperatorIndex == -1)
                lastNumber = inputBox.Text;
            else
                lastNumber = inputBox.Text.Substring(lastOperatorIndex + 1);

            if (!lastNumber.Contains("."))
            {
                inputBox.Text += ".";
            }
        }
        //Equal button event handler
        private void equalButton_Click(object sender, EventArgs e)
        {
            try
            {
                string expression = inputBox.Text;
                DataTable dt = new DataTable();
                var result = dt.Compute(expression, "");

                double numericResult = Convert.ToDouble(result);
                inputBox.Text = numericResult.ToString("F2");
                previousBox.Text = expression;

            }
            catch (Exception)
            {
                inputBox.Text = "Error";
            }
        }

        private void previousBox_Click(object sender, EventArgs e)
        {
            inputBox.Text = previousBox.Text;
        }
    }
}
