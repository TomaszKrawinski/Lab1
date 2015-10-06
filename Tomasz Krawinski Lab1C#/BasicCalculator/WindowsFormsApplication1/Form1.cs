// Name: Tomasz Krawinski
// Student Number: C00172709
// Title: Basic Calculator C# Lab1 Question 1

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        //veriable declaration
        String input = "";
        String in1 = "";
        String in2 = "";
        double answer = 0;
        char calculation ;

        public Form1()
        {
            InitializeComponent();
        }

        // Buttons for numbers and decimal point
        private void point_Click(object sender, EventArgs e)
        {
            this.label1.Text = "";
            input += '.';
            this.label1.Text += input;
        }

        private void zero_Click(object sender, EventArgs e)
        {
            this.label1.Text = "";
            input += '0';
            this.label1.Text += input;
        }

        private void one_Click(object sender, EventArgs e)
        {
            this.label1.Text = "";
            input += '1';
            this.label1.Text += input;
        }

        private void two_Click(object sender, EventArgs e)
        {
            this.label1.Text = "";
            input += '2';
            this.label1.Text += input;
        }

        private void three_Click(object sender, EventArgs e)
        {
            this.label1.Text = "";
            input += '3';
            this.label1.Text += input;
        }

        private void four_Click(object sender, EventArgs e)
        {
            this.label1.Text = "";
            input += '4';
            this.label1.Text += input;
        }

        private void five_Click(object sender, EventArgs e)
        {
            this.label1.Text = "";
            input += '5';
            this.label1.Text += input;
        }

        private void six_Click(object sender, EventArgs e)
        {
            this.label1.Text = "";
            input += '6';
            this.label1.Text += input;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            this.label1.Text = "";
            input += '7';
            this.label1.Text += input;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            this.label1.Text = "";
            input += '8';
            this.label1.Text += input;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            this.label1.Text = "";
            input += '9';
            this.label1.Text += input;
        }
        //clear screen + data button
        private void clear_Click(object sender, EventArgs e)
        {
            //clear data in veriables and label
            this.label1.Text = "";
            this.input = String.Empty;
            this.in1 = String.Empty;
            this.in2 = String.Empty;

            //re-enable buttons
            plus.Enabled = true;
            divide.Enabled = true;
            multiply.Enabled = true;
            minus.Enabled = true;
        }
        // / + * - Buttons
        private void divide_Click(object sender, EventArgs e)
        {
            //to avoid being able to click operands multiple times (eg. ***** or *+-//-) im locking the operand buttons after one is hit
            if (divide.Enabled = true)
            {
                plus.Enabled = false;
                divide.Enabled = false;
                multiply.Enabled = false;
                minus.Enabled = false;
            }

            in1 = input; // save first number in in1
            calculation = '/'; // calc operation
            input = String.Empty;// empty out input
            input += '/'; // add operand to input (for display purpuses)
            this.label1.Text += input; //display
            input = String.Empty; // empty it again, to store number 2
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            if(multiply.Enabled = true)
            {
                plus.Enabled = false;
                divide.Enabled = false;
                multiply.Enabled = false;
                minus.Enabled = false;
            }

            in1 = input;
            calculation = '*';
            input = String.Empty;
            input += '*';
            this.label1.Text += input;
            input = String.Empty;
        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (minus.Enabled = true)
            {
                plus.Enabled = false;
                divide.Enabled = false;
                multiply.Enabled = false;
                minus.Enabled = false;
            }

            in1 = input;
            calculation = '-';
            input = String.Empty;
            input += '-';
            this.label1.Text += input;
            input = String.Empty;
        }

        private void plus_Click(object sender, EventArgs e)
        {

            if (plus.Enabled = true)
            {
                plus.Enabled = false;
                divide.Enabled = false;
                multiply.Enabled = false;
                minus.Enabled = false;
            }

            in1 = input;
            calculation = '+';
            input = String.Empty;
            input += '+';
            this.label1.Text += input;
            input = String.Empty;
        }
        //equals button - calculations
        private void equals_Click(object sender, EventArgs e)
        {
            // veriable declaration - to parse string into double
            double n1;
            double n2;

            in2 = input; // store input(second number) as in2
            // equals re-enables the operand buttons which are locked after you choose one
            plus.Enabled = true;
            divide.Enabled = true;
            multiply.Enabled = true;
            minus.Enabled = true;
            //parsing in1 and in2 into doubles n1 and n2
            double.TryParse(in1, out n1);
            double.TryParse(in2, out n2);


                  if (calculation == '-')
                  {
                      answer = n1 - n2; //calculation
                      label1.Text = answer.ToString(); //answer display
                  }

                  if (calculation == '+')
                  {
                      answer = n1 + n2;
                      label1.Text = answer.ToString();
                  }

                  if (calculation == '*')
                  {
                      answer = n1 * n2;
                      label1.Text = answer.ToString();
                  }

                  if (calculation == '/')
                  {
                      answer = n1 / n2;
                      label1.Text = answer.ToString();
                  }
            //clear data(numbers) from veriables so that we can use it again
            this.in1 = String.Empty;
            this.in2 = String.Empty;
            this.input = String.Empty;

            input += answer; // enables to reuse answer again

        }

    }
}
