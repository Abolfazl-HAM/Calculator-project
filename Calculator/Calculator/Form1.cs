using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    
    public partial class Form1 : Form
    {
       
        ICalculator calculator;
        public Form1()
        {
            InitializeComponent();
          
            calculator = new Calculator();
        }

       public bool ValidateInputs()
        {
            bool isValid = true;
            if (txtNumber1.Value == 0)
            {
                isValid = false;
                MessageBox.Show("لطفا عدد اول را وارد کنید");
            }
            else
            {
                if(txtNumber2.Value == 0)
                {
                    isValid = false;
                    MessageBox.Show("لطفا عدد دوم را وارد کنید");
                }
            }
            return isValid;
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int sum = calculator.Plus((int)txtNumber1.Value, (int)txtNumber2.Value);
                MessageBox.Show("The answer is plural : " + sum);
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int Minus = calculator.Minus((int)txtNumber1.Value, (int)txtNumber2.Value);
                MessageBox.Show("The answer is minus : " + Minus);
            }
        }

        private void btnMultipl_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int Multiple = calculator.Multiple((int)txtNumber1.Value, (int)txtNumber2.Value);
                MessageBox.Show("The answer is Multiple : " + Multiple);
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int Divide = calculator.Divide((int)txtNumber1.Value, (int)txtNumber2.Value);
                MessageBox.Show("The answer is Divide : " + Divide);
            }
        }
    }
}
