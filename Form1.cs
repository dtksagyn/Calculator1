using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //*********VARIBALES**************
        string calTotal;
        string operation = "";
        double num1;
        double num2;
        double result;

        private void UpdateDisplay(string value)
        {
            txtDisplay.Text += value;
        }

        //**********DIGITS**************
        private void btn1_Click(object sender, EventArgs e)
        {
            UpdateDisplay(btn1.Text);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            UpdateDisplay(btn1.Text);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            UpdateDisplay(btn1.Text);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            UpdateDisplay(btn1.Text);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            UpdateDisplay(btn1.Text);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            UpdateDisplay(btn1.Text);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            UpdateDisplay(btn1.Text);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            UpdateDisplay(btn1.Text);
        }
       

        private void btn9_Click(object sender, EventArgs e)
        {
            UpdateDisplay(btn1.Text);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            UpdateDisplay(btn1.Text);
        }


        //***********OPERATIONS************
        private void btnSub_Click(object sender, EventArgs e)
        {
            operation = "+";
            num1 = double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            operation = "*";
            num1 = double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
        }



        private void btnDiv_Click(object sender, EventArgs e)
        {
            operation = "/";
            num1 = double.Parse(txtDisplay.Text);  // Change to double.Parse
            txtDisplay.Text = txtDisplay.Text + "/";
        }


        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            operation = "+";
            num1 = int.Parse(txtDisplay.Text);
            txtDisplay.Clear();
        }
        private void btnClr_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            result = 0;
            num1 = 0;
            num2 = 0;
        }
        private void btnRst_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(txtDisplay.Text);
            if (operation.Equals("/") && num2 == 0) // Check for division by zero
            {
                // Handle division by zero error (e.g., display an error message)
                txtDisplay.Text = "Error: Division by zero";
            }
            else
            {
                if (operation.Equals("+"))
                    result = num1 + num2;
                else if (operation.Equals("*"))
                    result = num1 * num2;
                else if (operation.Equals("/"))
                    result = num1 / num2;
                txtDisplay.Text = result + "";
            }
        }






    }
}
