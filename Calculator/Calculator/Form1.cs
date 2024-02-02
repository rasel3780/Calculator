using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Net;
using System.Runtime.CompilerServices;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double number1, number2;
        double result = 0;
        string divZeroError = "Can't divide by zero";
        string undefinedError = "Result is undefined";
        string input = string.Empty;
        string operation = string.Empty;
        char option;
        bool isMinus = false;
        bool isFloat = false;

        bool num1Flag = false;
        bool num2Flag = false;
        bool perfomedFlag = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void msgClear()
        {
            if (displayTextBox.Text == divZeroError || displayTextBox.Text == undefinedError)
            {
                displayTextBox.Clear();
                input = string.Empty;
                operation = string.Empty;
                result = 0;
            }

        }

        #region Digits Button 
        private void digits_click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;

            msgClear();

            if (btn.Text == ".")
            {
                if (!isFloat)
                {
                    input += ".";
                    displayTextBox.Text = input;
                    isFloat = true;
                }
            }

            else
            {
                input += btn.Text;
                displayTextBox.Text = input;
            }
        }
        #endregion

        #region Operators Button
        private void operator_click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;

            msgClear();

            if (displayTextBox.Text == "0" && btn.Text == "-")
            {
                displayTextBox.Clear();
                input += btn.Text;
                displayTextBox.Text = input;
                isMinus = true;
            }

            if (!string.IsNullOrEmpty(input) && !IsLastCharOperator())
            {
                operation = btn.Text;
                input += operation;
                displayTextBox.Text = input;
                isFloat = false;
            }

            else if (IsLastCharOperator())
            {
                input = input.Substring(0, input.Length - 1) + btn.Text;
                operation = btn.Text;
                displayTextBox.Text = input;
                isFloat = false;
            }


        }
        #endregion

        #region Calculation
        private void Calculation(char option)
        {
            try
            {

                bool zeroProblem = false;
                string[] inputArr = new string[5];

                string displayString = input.ToString();
                inputArr = displayString.Split(option);

                if (inputArr[1] != "")
                {
                    number1 = Convert.ToDouble(inputArr[0]);
                    number2 = Convert.ToDouble(inputArr[1]);
                    if (isMinus)
                    {
                        double positiveNumber = Convert.ToDouble(inputArr[0]);
                        number1 = -positiveNumber;
                        isMinus = false;
                    }
                    else
                    {
                        number1 = Convert.ToDouble(inputArr[0]);
                    }
                    number2 = Convert.ToDouble(inputArr[1]);

                    if (option == '+')
                    {
                        result = number1 + number2;
                    }
                    else if (option == '-')
                    {
                        result = number1 - number2;
                    }
                    else if (option == 'x')
                    {
                        result = number1 * number2;
                    }
                    else if (option == '/')
                    {
                        if (number1 == 0 && number2 == 0)
                        {
                            displayTextBox.Text = undefinedError;
                            zeroProblem = true;
                        }
                        else if (number2 == 0)
                        {
                            displayTextBox.Text = divZeroError;
                            zeroProblem = true;
                        }
                        else
                        {
                            result = number1 / number2;
                        }
                    }

                    if (!zeroProblem)
                    {
                        displayTextBox.Text = result.ToString();
                        input = result.ToString();
                    }
                }

            }
            catch (Exception ex)
            {
                displayTextBox.Text = ex.Message;
            }

        }
        #endregion
        private bool IsLastCharOperator()
        {
            if (string.IsNullOrEmpty(input))
                return false;

            char lastChar = input[input.Length - 1];
            return (lastChar == '+' || lastChar == '-' || lastChar == 'x' || lastChar == '/');
        }

        #region Equal
        private void equalBtn_Click(object sender, EventArgs e)
        {
            if (input.StartsWith('-'))
            {
                input = input.Substring(1, input.Length - 1);
                isMinus = true;
            }

            string inputString = input.ToString();

            if (inputString.Contains("+"))
            {
                option = '+';
                Calculation(option);


            }
            else if (inputString.Contains("-"))
            {

                option = '-';
                Calculation(option);

            }
            else if (inputString.Contains("x"))
            {
                option = 'x';
                Calculation(option);

            }

            else if (inputString.Contains("/"))
            {
                option = '/';
                Calculation(option);



            }
            isFloat = false;
        }
        #endregion


        #region Delete
        private void deleteBtn_Click(object sender, EventArgs e)
        {

            int txtLength = displayTextBox.Text.Length;

            if (txtLength > 0 && displayTextBox.Text != "Can't divide by zero")
            {
                char lastCharOperator = displayTextBox.Text[displayTextBox.Text.Length - 1];
                input = displayTextBox.Text.Remove(displayTextBox.Text.Length - 1, 1);

                if (lastCharOperator == '+' || lastCharOperator == '-'
                    || lastCharOperator == 'x' || lastCharOperator == '/')
                {

                }
                displayTextBox.Text = input.ToString();

            }

            if (displayTextBox.Text == "")
            {
                displayTextBox.Text = "0";
                result = 0;
                input = string.Empty;
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {

            input = string.Empty;
            operation = string.Empty;
            displayTextBox.Text = "0";

        }
        #endregion


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
