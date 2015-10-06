// Name: Tomasz Krawinski
// Student Number: C00172709
// Title: Currency Converter C# Lab1 Question 2


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConverter
{
    public partial class Form1 : Form
    {
        //veriable declaration
        String input;
        String conversion;
        double answer;


        public Form1()
        {
            InitializeComponent();
        }
        // Buttons for numbers and decimal point
        private void zero_Click(object sender, EventArgs e)
        {
            this.display.Text = "";
            input += '0';
            this.display.Text += input;
        }

        private void one_Click(object sender, EventArgs e)
        {
            this.display.Text = "";
            input += '1';
            this.display.Text += input;
        }

        private void two_Click(object sender, EventArgs e)
        {
            this.display.Text = "";
            input += '2';
            this.display.Text += input;
        }

        private void three_Click(object sender, EventArgs e)
        {
            this.display.Text = "";
            input += '3';
            this.display.Text += input;
        }

        private void four_Click(object sender, EventArgs e)
        {
            this.display.Text = "";
            input += '4';
            this.display.Text += input;
        }

        private void five_Click(object sender, EventArgs e)
        {
            this.display.Text = "";
            input += '5';
            this.display.Text += input;
        }

        private void six_Click(object sender, EventArgs e)
        {
            this.display.Text = "";
            input += '6';
            this.display.Text += input;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            this.display.Text = "";
            input += '7';
            this.display.Text += input;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            this.display.Text = "";
            input += '8';
            this.display.Text += input;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            this.display.Text = "";
            input += '9';
            this.display.Text += input;
        }

        private void point_Click(object sender, EventArgs e)
        {
            this.display.Text = "";
            input += '.';
            this.display.Text += input;
        }
        //clear screen + data button
        private void clear_Click(object sender, EventArgs e)
        {
            //clear data in veriables and label
            this.display.Text = "";
            this.input = String.Empty;
        }
        //convert button - calculations
        private void convert_Click(object sender, EventArgs e)
        {
            // veriable declaration - to parse string into double
               double n1;
            //parsing input into  a double n1
            double.TryParse(input, out n1);

            conversion = comboBox1.Text.ToString(); // converts picked position in combobox to a string, saves it so it can be compared
            // compares what is currently in conversion and does the correct calculation
              if (conversion == "EUR to GBP")
               {
                   answer = n1 * 0.75; // conversions
                   display.Text = answer.ToString(); //display answer in label
               }

              if (conversion == "EUR to USD")
               {
                   answer = n1 * 1.11;
                   display.Text = answer.ToString();
               }

              if (conversion == "GBP to USD")
               {
                   answer = n1 * 1.52;
                   display.Text = answer.ToString();
               }

               if (conversion == "GBP to EUR")
               {
                   answer = n1 * 1.35;
                   display.Text = answer.ToString();
               }

               if (conversion == "USD to EUR")
               {
                   answer = n1 * 0.89;
                   display.Text = answer.ToString();
               }

               if (conversion == "USD to GBP")
               {
                   answer = n1 * 0.66;
                   display.Text = answer.ToString();
               }
            //clear data(numbers) from veriables so that we can use it again
            this.input = String.Empty;

            input += answer;// enables to reuse answer as input again
        }


    }
}
