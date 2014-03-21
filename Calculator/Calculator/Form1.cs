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

        private void button2_Click(object sender, EventArgs e)
        {
            //Writes button number to primary output textbox
            outputBox.Text = outputBox.Text + oneButton.Text;
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            outputBox.Text = outputBox.Text + twoButton.Text;
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            outputBox.Text = outputBox.Text + threeButton.Text;
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            outputBox.Text = outputBox.Text + fourButton.Text;
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            outputBox.Text = outputBox.Text + fiveButton.Text;
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            outputBox.Text = outputBox.Text + sixButton.Text;
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            outputBox.Text = outputBox.Text + sevenButton.Text;
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            outputBox.Text = outputBox.Text + eightButton.Text;
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            outputBox.Text = outputBox.Text + nineButton.Text;
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            outputBox.Text = outputBox.Text + zeroButton.Text;
        }

        private void aboutForm_Click(object sender, EventArgs e)
        {
            About newAbout = new About();
            newAbout.Show();
        }
    }
}
