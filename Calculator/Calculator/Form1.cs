namespace Calculator
{
    public partial class Form1 : Form
    {

        string operation = "";
        double result = 0;
        bool performed = false;
        bool dividedByZero = false;
        bool equalClicked = false;
        

        public Form1()
        {
            InitializeComponent();
        }

        #region Digits
        private void digits_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;



            if (dividedByZero)
            {
                displayTextBox.Text = "0";
                dividedByZero = false;
            }

            if (displayTextBox.Text == "0" || performed)
            {
                displayTextBox.Clear();
            }


            //decimal point validation to prevent more than 1 decimal point input
            if (btn.Text == ".")
            {
                if (!displayTextBox.Text.Contains("."))
                {
                    displayTextBox.Text += btn.Text;
                    if(performed)
                    {
                        operation_lbl.Text += displayTextBox.Text;
                    }
                    else
                    {
                        operation_lbl.Text = displayTextBox.Text;
                    }
                    
                }
            }
            //concating digits
            else
            {
                displayTextBox.Text += btn.Text;
                if (performed)
                {
                    operation_lbl.Text += displayTextBox.Text;
                }
                else
                {
                    operation_lbl.Text = displayTextBox.Text;
                }
            }
        }
        #endregion

        #region Operators
        private void operator_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            
            if(dividedByZero)
            {
                displayTextBox.Text = "0";
                dividedByZero = false;
            }

            //checking if the minus button is used to represent negative number  
            if(displayTextBox.Text == "0" && btn.Text=="-")
            {
                displayTextBox.Clear() ;
                displayTextBox.Text += btn.Text;
                operation_lbl.Text += btn.Text;
            }
            
            
            else if(btn.Text != "/" && btn.Text != "x")
            {
                operation = btn.Text;
                result = Convert.ToDouble(displayTextBox.Text);
                performed = true;
                operation_lbl.Text += btn.Text;
            }
           


        }
        #endregion

        #region Calculation
        private void Calculation()
        {
            try
            {
                double currentInput = Convert.ToDouble(displayTextBox.Text);

                if (operation == "+")
                {
                    displayTextBox.Text = (result + currentInput).ToString();
                    
                }
                else if (operation == "-")
                {
                    displayTextBox.Text = (result - currentInput).ToString();
                    
                }
                else if (operation == "x")
                {
                    displayTextBox.Text = (result * currentInput).ToString();
                   
                }
                else
                {   
                    //checking if dividing by zero 
                    if(currentInput==0)
                    {
                        displayTextBox.Text = "Can't divide by zero";
                        operation_lbl.Text = "";
                        dividedByZero = true;
                    }
                    else
                    {
                        displayTextBox.Text = (result / currentInput).ToString();     
                    }
                    
                }
                if(!operation_lbl.Text.Contains("="))
                {
                    operation_lbl.Text += "=";
                }
                
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        #endregion

        #region Equal
        private void equalBtn_Click(object sender, EventArgs e)
        {
            equalClicked = true;

            if (performed) 
            {
                Calculation();
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
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            displayTextBox.Text = "0";
            operation_lbl.Text = "";
            result = 0;
        }

        private void clearEntryBtn_Click(object sender, EventArgs e)
        {
            operation_lbl.Text += displayTextBox.Text;
            displayTextBox.Text = "0";
            
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            operation_lbl.Text = "";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
