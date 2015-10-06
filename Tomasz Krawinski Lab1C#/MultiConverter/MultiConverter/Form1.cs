// Name: Tomasz Krawinski
// Student Number: C00172709
// Title: Multi Converter using Menu C# Lab1 Question 3 + 4


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //veriable declaration
        String input;
        String conversion;
        double answer;

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
            this.label1.Text = String.Empty;
        }
        // Menu items - conversion options
        private void eURTOGBPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // veriable declaration - to parse string into double
            double n1;
            //parsing input into  a double n1
            double.TryParse(input, out n1);

            answer = n1 * 0.75; // conversions
            display.Text = answer.ToString(); //display answer in label

            this.input = String.Empty; //clear data(numbers) from veriables so that we can use it again

            input += answer; // enables to reuse answer as input again

            this.label1.Text = "EUR To GBP"; // updates label to display which conversion was made
        }

        private void inchesToFeetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double n1;

            double.TryParse(input, out n1);

            answer = n1 * 0.0833333;
            display.Text = answer.ToString();

            this.input = String.Empty;

            input += answer;

            this.label1.Text = "Inches To Feet";
        }

        private void kilometresToMilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double n1;

            double.TryParse(input, out n1);

            answer = n1 * 0.621371;
            display.Text = answer.ToString();

            this.input = String.Empty;

            input += answer;

            this.label1.Text = "Kilometers To Miles";
        }

        private void inchesToCentimetersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double n1;

            double.TryParse(input, out n1);

            answer = n1 * 2.54;
            display.Text = answer.ToString();

            this.input = String.Empty;

            input += answer;

            this.label1.Text = "Inches To Centimeters";
        }

        private void celsiusToFahrenheitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double n1;

            double.TryParse(input, out n1);

            answer = (n1 * 9) / 5 + 32;
            display.Text = answer.ToString();

            this.input = String.Empty;

            input += answer;

            this.label1.Text = "Celsious To Farenheit";
        }
        // Menu item, closes the application
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
