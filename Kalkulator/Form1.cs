using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
   
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private decimal firstnumber = 0.0m;
        private decimal secondnumber = 0.0m;
        private decimal result = 0.0m;
        private string OperatorString = "-";
     

        private void offbutton_Click(object sender, EventArgs e)
        {
            onbutton.Show();
            offbutton.Hide();
            culbox.Text = "0";
            historylabel.Text = null;
            zerobutton.Enabled = false;
            onebutton.Enabled = false;
            twobutton.Enabled = false;
            thrreebutton.Enabled = false;
            fourbutton.Enabled = false;
            fivebutton.Enabled = false;
            sixbutton.Enabled = false;
            sevenbutton.Enabled = false;
            eightbutton.Enabled = false;
            ninebutton.Enabled = false;
            clearbutton.Enabled = false;
            reminderbutton.Enabled = false;
            doublebutton.Enabled = false;
            subbutton.Enabled = false;
            addbutton.Enabled = false;
            mulbutton.Enabled = false;
            divbutton.Enabled = false;
            dotbutton.Enabled = false;
            equalbutton.Enabled = false;

        }

        private void onbutton_Click(object sender, EventArgs e)
        {
            onbutton.Hide();
            offbutton.Show();
            culbox.Text = "0";
            historylabel.Text = null;
            zerobutton.Enabled = true;
            onebutton.Enabled = true;
            twobutton.Enabled = true;
            thrreebutton.Enabled = true;
            fourbutton.Enabled = true;
            fivebutton.Enabled = true;
            sixbutton.Enabled = true;
            sevenbutton.Enabled = true;
            eightbutton.Enabled = true;
            ninebutton.Enabled = true;
            clearbutton.Enabled = true;
            reminderbutton.Enabled = true;
            doublebutton.Enabled = true;
            subbutton.Enabled = true;
            addbutton.Enabled = true;
            mulbutton.Enabled = true;
            divbutton.Enabled = true;
            equalbutton.Enabled = true;
            dotbutton.Enabled = true;
        }

        private void zerobutton_Click(object sender, EventArgs e)
        {
            DeleteZero(0);

        }

        private void DeleteZero(int number)
        {
            if (culbox.Text == "0")
                culbox.Text = number.ToString();
            else
                culbox.Text += number.ToString();
        }

        private void onebutton_Click(object sender, EventArgs e)
        {
            DeleteZero(1);
        }

        private void twobutton_Click(object sender, EventArgs e)
        {
            DeleteZero(2);
        }

        private void thrreebutton_Click(object sender, EventArgs e)
        {
            DeleteZero(3);
        }

        private void fourbutton_Click(object sender, EventArgs e)
        {
            DeleteZero(4);
        }

        private void fivebutton_Click(object sender, EventArgs e)
        {
            DeleteZero(5);
        }

        private void sixbutton_Click(object sender, EventArgs e)
        {
            DeleteZero(6);
        }

        private void sevenbutton_Click(object sender, EventArgs e)
        {
            DeleteZero(7);
        }

        private void eightbutton_Click(object sender, EventArgs e)
        {
            DeleteZero(8);
        }

        private void ninebutton_Click(object sender, EventArgs e)
        {
            DeleteZero(9);
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            SuppliedOperators("+");
        }

        private void divbutton_Click(object sender, EventArgs e)
        {
            SuppliedOperators("/");
        }

        private void subbutton_Click(object sender, EventArgs e)
        {
            SuppliedOperators("-");
        }

        private void mulbutton_Click(object sender, EventArgs e)
        {
            SuppliedOperators("*");

        }

        private void reminderbutton_Click(object sender, EventArgs e)
        {
            SuppliedOperators("%");
        }

        private void SuppliedOperators(string OperatorSymbol)
        {
            OperatorString = OperatorSymbol;
            firstnumber = decimal.Parse(culbox.Text);
            culbox.Text = "";
            historylabel.Text = firstnumber + OperatorString.ToString();
        }

        private void doublebutton_Click(object sender, EventArgs e)
        {
            if (!culbox.Text.Contains("-"))
                culbox.Text = "-" + culbox.Text;
            else
                culbox.Text = culbox.Text.Trim('-');
        }

        private void equalbutton_Click(object sender, EventArgs e)
        {
            Result();
        }

        private void Result()
        {
            secondnumber = decimal.Parse(culbox.Text);
            switch (OperatorString)
            {
                case "+":
                    result = firstnumber + secondnumber;
                    break;

                case "-":
                    result = firstnumber - secondnumber;
                    break;
                case "*":
                    result = firstnumber * secondnumber;
                    break;
                case "/":
                    result = firstnumber / secondnumber;
                    break;

                case "%":
                    result = firstnumber % secondnumber;
                    break;
            }


            culbox.Text = result.ToString();
            historylabel.Text = firstnumber + OperatorString + secondnumber + equalbutton.Text.ToString();

        }

        private void dotbutton_Click(object sender, EventArgs e)
        {
            if (!culbox.Text.Contains("."))
                culbox.Text += ".";
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            this.culbox.Text = string.Empty;
        }
    }
}