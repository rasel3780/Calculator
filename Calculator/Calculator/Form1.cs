using System.Data;
using System.Net;

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

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            operation_lbl.Text = string.Empty;
        }

        #region Digits
        private void digits_click(object sender, EventArgs e)
        {
            
            Button btn = (Button)sender;
            input += btn.Text;
            displayTextBox.Text = input;
            

        }
        #endregion

        #region Operators
        private void operator_click(object sender, EventArgs e)
        {
        
            
            Button btn = (Button)sender;

            if (!string.IsNullOrEmpty(input) && !IsLastCharOperator())
            {
                operation = btn.Text;
                input += operation;
                displayTextBox.Text = input;
            }
          
            else if (IsLastCharOperator())
            {
                input = input.Substring(0, input.Length - 1) + btn.Text;
                operation = btn.Text;
                displayTextBox.Text = input;
            }

        }
        #endregion

        private bool IsLastCharOperator()
        {
            if (string.IsNullOrEmpty(input))
                return false;

            char lastChar = input[input.Length - 1];
            return (lastChar == '+' || lastChar == '-' || lastChar == '*' || lastChar == '/');
        }

        #region Calculation
        private void Calculation()
        {
            //if(operation=='+')
            //{
            //    result = number1+
            //}
            
        }
        #endregion

        #region Equal
        private void equalBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string displayString = input.ToString();
                bool plus = displayString.Contains("+");
                bool minus = displayString.Contains("-");
                bool multi = displayString.Contains("x");
                bool divi = displayString.Contains("/");
                bool zeroProblem = false;

                string[] inputArr = new string[3];

                if(plus)
                {
                    inputArr = displayString.Split('+');
                    number1 = Convert.ToDouble(inputArr[0]);
                    number2 = Convert.ToDouble(inputArr[1]);  
                    result = number1+number2;
 
                }
                else if(minus)
                {
                    inputArr = displayString.Split('-');
                    number1 = Convert.ToDouble(inputArr[0]);
                    number2 = Convert.ToDouble(inputArr[1]);
                    result = number1 - number2;

                }
                else if(multi)
                {
                    inputArr = displayString.Split('*');
                    number1 = Convert.ToDouble(inputArr[0]);
                    number2 = Convert.ToDouble(inputArr[1]);
                    result = number1 * number2;

                }
                else if(divi)
                {
                    inputArr = displayString.Split('/');
                    number1 = Convert.ToDouble(inputArr[0]);
                    number2 = Convert.ToDouble(inputArr[1]);
                    if(number1==0 && number2==0)
                    {
                        displayTextBox.Text = undefinedError;
                        zeroProblem = true;
                    }
                    else if(number2==0) 
                    {
                        displayTextBox.Text = divZeroError;
                        zeroProblem = true;
                    }
                    else
                    {
                        result = number1 / number2;
                    }
                    
                }

                if(!zeroProblem)
                {
                    displayTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                
            }
            catch (Exception ex)
            {
                displayTextBox.Text = ex.Message.ToString();
            }
        }
        #endregion

        #region Delete
        private void deleteBtn_Click(object sender, EventArgs e)
        {

            int txtLength = displayTextBox.Text.Length;

            if (txtLength > 0 && displayTextBox.Text!="Can't divide by zero")
            {
                displayTextBox.Text = displayTextBox.Text.Remove(displayTextBox.Text.Length - 1, 1);
                operation_lbl.Text = displayTextBox.Text;
            }

            if (displayTextBox.Text == "")
            {
                displayTextBox.Text = "0";
                //performed= false;
                result = 0;
                operation_lbl.Text = string.Empty;
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            
            input = string.Empty;
            operation = string.Empty;
            displayTextBox.Text = string.Empty;
        }
        #endregion

        

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
