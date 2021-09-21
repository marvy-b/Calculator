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
    public partial class Form1 : Form
    {
        double ResultValue = 0;
        string OperationPerformed = "";
        bool IsOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnNumerical(object sender, EventArgs e)
        {
            if ((textBox_Result.Text == "0") || (IsOperationPerformed))
                textBox_Result.Clear();

            IsOperationPerformed = false;
            Button button = (Button)sender;

            if (button.Text == ".")
            {
                if (!textBox_Result.Text.Contains("."))
                    textBox_Result.Text = textBox_Result.Text + button.Text;
            }
            else
                textBox_Result.Text = textBox_Result.Text + button.Text;
        }

        private void Operation_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (ResultValue != 0)
            {
                btnEquals.PerformClick();
                OperationPerformed = button.Text;
                labelCurrentOperation.Text = ResultValue + " " + OperationPerformed;
                IsOperationPerformed = true;
            }
            else
                OperationPerformed = button.Text;
            ResultValue = Convert.ToDouble(textBox_Result.Text);
            labelCurrentOperation.Text = ResultValue + " " + OperationPerformed;
            IsOperationPerformed = true;
        }

        private void Cancel_Entry_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
        }

        private void btnCancelOperations_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            ResultValue = 0;
            labelCurrentOperation.Text = "";
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            switch (OperationPerformed)
            {
                case "+":
                    textBox_Result.Text = (ResultValue + Convert.ToDouble(textBox_Result.Text)).ToString();
                    break;
                case "-":
                    textBox_Result.Text = (ResultValue - Convert.ToDouble(textBox_Result.Text)).ToString();
                    break;
                case "*":
                    textBox_Result.Text = (ResultValue * Convert.ToDouble(textBox_Result.Text)).ToString();
                    break;
                case "/":
                    textBox_Result.Text = (ResultValue / Convert.ToDouble(textBox_Result.Text)).ToString();
                    break;
            }
            ResultValue = Convert.ToDouble(textBox_Result.Text);
            labelCurrentOperation.Text = "";
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text.Length > 0)
            {
                textBox_Result.Text = textBox_Result.Text.Remove(textBox_Result.Text.Length - 1, 1);
            }
            if (textBox_Result.Text == "")
            {
                textBox_Result.Text = "0";
            }
        }
    }
}
