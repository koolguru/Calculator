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
        public bool subtractButtonClicked = false;

        private void button2_Click(object sender, EventArgs e)
        {
            //Writes button number to primary output textbox
            if (clearOutputBox == true)
            {
                outputBox.Clear();
                clearOutputBox = false;
            }
            outputBox.Text = outputBox.Text + oneButton.Text;


        }
        private void twoButton_Click(object sender, EventArgs e)
        {

            if (clearOutputBox == true)
            {
                outputBox.Clear();
                clearOutputBox = false;
            }
            outputBox.Text = outputBox.Text + twoButton.Text;
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            if (clearOutputBox == true)
            {
                outputBox.Clear();
                clearOutputBox = false;
            }
            outputBox.Text = outputBox.Text + threeButton.Text;
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            if (clearOutputBox == true)
            {
                outputBox.Clear();
                clearOutputBox = false;
            }
            outputBox.Text = outputBox.Text + fourButton.Text;
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            if (clearOutputBox == true)
            {
                outputBox.Clear();
                clearOutputBox = false;
            }
            outputBox.Text = outputBox.Text + fiveButton.Text;
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            if (clearOutputBox == true)
            {
                outputBox.Clear();
                clearOutputBox = false;
            }
            outputBox.Text = outputBox.Text + sixButton.Text;
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            if (clearOutputBox == true)
            {
                outputBox.Clear();
                clearOutputBox = false;
            }
            outputBox.Text = outputBox.Text + sevenButton.Text;
        }
        private void eightButton_Click(object sender, EventArgs e)
        {
            if (clearOutputBox == true)
            {
                outputBox.Clear();
                clearOutputBox = false;
            }
            outputBox.Text = outputBox.Text + eightButton.Text;
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            if (clearOutputBox == true)
            {
                outputBox.Clear();
                clearOutputBox = false;
            }
            outputBox.Text = outputBox.Text + nineButton.Text;
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            if (clearOutputBox == true)
            {
                outputBox.Clear();
                clearOutputBox = false;
            }
            outputBox.Text = outputBox.Text + zeroButton.Text;
        }

        private void aboutForm_Click(object sender, EventArgs e)
        {
            About newAbout = new About();
            newAbout.Show();
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            plusButtonClicked = true;
            if (numberOneEntered == false)
            {
                numberOne = Convert.ToInt32(outputBox.Text);
                numberOneEntered = true;
            }
            clearOutputBox = true;
            outputBox.Clear();
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            clearOutputBox = true;

            if (plusButtonClicked == true)
            {
                if ((numberOneEntered == true))
                {
                    numberTwo = Convert.ToInt32(outputBox.Text); //Convert Output text to integer number
                    numberTwoEntered = true; //What the beans is this shizt doing here//Fuck you im not taking it out//Go Suck a bean//Go egg a suck//what?//
                    output = Convert.ToString(numberOne + numberTwo); //Add the numbers
                    outputBox.Text = output; //display the output
                    numberOneEntered = false;
                    numberTwoEntered = false;
                }
                else
                {
                    outputBox.Text = "Error";
                    clearOutputBox = true;
                }
            }
            if (subtractButtonClicked == true)
            {
                if ((numberOneEntered == true))
                {
                    numberTwo = Convert.ToInt32(outputBox.Text); //Convert Output text to integer number
                    numberTwoEntered = true; //What the beans is this shizt doing here//Fuck you im not taking it out//Go Suck a bean//Go egg a suck//what?//
                    output = Convert.ToString(numberOne - numberTwo); //Add the numbers
                    outputBox.Text = output; //display the output
                    numberOneEntered = false;
                    numberTwoEntered = false;
                }
                else
                {
                    outputBox.Text = "Error";
                    clearOutputBox = true;
                }
            }
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            subtractButtonClicked = true;
            if (numberOneEntered == false)
            {
                numberOne = Convert.ToInt32(outputBox.Text);
                numberOneEntered = true;
            }
            clearOutputBox = true;
            outputBox.Clear();
        }
    }
}
