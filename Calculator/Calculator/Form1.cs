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
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }
        //Class Level Variables
        public int numberOne;
        public int numberTwo;
        public bool plusButtonClicked = false;
        public bool numberOneEntered = false;
        public bool numberTwoEntered = false;
        public string output;
        public bool clearOutputBox = false;

        private void button2_Click(object sender, EventArgs e)
        {
            //Writes button number to primary output textbox
            if (clearOutputBox == true)
            {
                outputBox.Clear();
                clearOutputBox = false;
            }
            outputBox.Text = outputBox.Text + oneButton.Text;
            if (numberOneEntered == true)
            {
                numberTwo = 1;
                numberTwoEntered = true;
            }
            else if (numberOneEntered == false)
            {
                numberOne = 1;
                numberOneEntered = true;
            }

        }
        private void twoButton_Click(object sender, EventArgs e)
        {
            outputBox.Text = outputBox.Text + twoButton.Text;
            if (clearOutputBox == true)
            {
                outputBox.Clear();
                clearOutputBox = false;
            }
            if (numberOneEntered == true)
            {
                numberTwo = 2;
                numberTwoEntered = true;
            }
            else if (numberOneEntered == false)
            {
                numberOne = 2;
                numberOneEntered = true;
            }
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            outputBox.Text = outputBox.Text + threeButton.Text;
            if (clearOutputBox == true)
            {
                outputBox.Clear();
                clearOutputBox = false;
            }
            if (numberOneEntered == true)
            {
                numberTwo = 3;
                numberTwoEntered = true;
            }
            else if (numberOneEntered == false)
            {
                numberOne = 3;
                numberOneEntered = true;
            }
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            outputBox.Text = outputBox.Text + fourButton.Text;
            if (clearOutputBox == true)
            {
                outputBox.Clear();
                clearOutputBox = false;
            }
            if (numberOneEntered == true)
            {
                numberTwo = 4;
                numberTwoEntered = true;
            }
            else if (numberOneEntered == false)
            {
                numberOne = 4;
                numberOneEntered = true;
            }
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            outputBox.Text = outputBox.Text + fiveButton.Text;
            if (clearOutputBox == true)
            {
                outputBox.Clear();
                clearOutputBox = false;
            }
            if (numberOneEntered == true)
            {
                numberTwo = 5;
                numberTwoEntered = true;
            }
            else if (numberOneEntered == false)
            {
                numberOne = 5;
                numberOneEntered = true;
            }
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            outputBox.Text = outputBox.Text + sixButton.Text;
            if (clearOutputBox == true)
            {
                outputBox.Clear();
                clearOutputBox = false;
            }
            if (numberOneEntered == true)
            {
                numberTwo = 6;
                numberTwoEntered = true;
            }
            else if (numberOneEntered == false)
            {
                numberOne = 6;
                numberOneEntered = true;
            }
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            outputBox.Text = outputBox.Text + sevenButton.Text;
            if (clearOutputBox == true)
            {
                outputBox.Clear();
                clearOutputBox = false;
            }
            if (numberOneEntered == true)
            {
                numberTwo = 7;
                numberTwoEntered = true;
            }
            else if (numberOneEntered == false)
            {
                numberOne = 7;
                numberOneEntered = true;
            }
        }
        private void eightButton_Click(object sender, EventArgs e)
        {
            outputBox.Text = outputBox.Text + eightButton.Text;
            if (clearOutputBox == true)
            {
                outputBox.Clear();
                clearOutputBox = false;
            }
            if (numberOneEntered == true)
            {
                numberTwo = 8;
                numberTwoEntered = true;
            }
            else if (numberOneEntered == false)
            {
                numberOne = 8;
                numberOneEntered = true;
            }
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            outputBox.Text = outputBox.Text + nineButton.Text;
            if (clearOutputBox == true)
            {
                outputBox.Clear();
                clearOutputBox = false;
            }
            if (numberOneEntered == true)
            {
                numberTwo = 9;
                numberTwoEntered = true;
            }
            else if (numberOneEntered == false)
            {
                numberOne = 9;
                numberOneEntered = true;
            }
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            outputBox.Text = outputBox.Text + zeroButton.Text;
            if (clearOutputBox == true)
            {
                outputBox.Clear();
                clearOutputBox = false;
            }
            if (numberOneEntered == true)
            {
                numberTwo = 0;
                numberTwoEntered = true;
            }
            else if (numberOneEntered == false)
            {
                numberOne = 0;
                numberOneEntered = true;
            }
        }

        private void aboutForm_Click(object sender, EventArgs e)
        {
            About newAbout = new About();
            newAbout.Show();
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            outputBox.Text = outputBox.Text + " + ";
            plusButtonClicked = true;
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            clearOutputBox = true;
            if (plusButtonClicked == true)
            {
                if ((numberOneEntered == true) || (numberTwoEntered == true))
                {
                    output = Convert.ToString(numberOne + numberTwo);
                    outputBox.Text = output;
                    numberOneEntered = false;
                    numberTwoEntered = false;
                }
                else
                {
                    outputBox.Text = "Error";
                }
            }
        }
    }
}
