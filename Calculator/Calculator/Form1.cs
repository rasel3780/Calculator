namespace Calculator
{
    public partial class Form1 : Form
    {

        string operation = "";
        double result = 0;
        bool performed = false;
        bool dividedByZero = false;

        public Form1()
        {
            InitializeComponent();
        }

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

            performed = false;

            //decimal point validation to prevent more than 1 decimal point input
            if (btn.Text == ".")
            {
                if (!displayTextBox.Text.Contains("."))
                {
                    displayTextBox.Text += btn.Text;
                }
            }
            else
            {
                displayTextBox.Text += btn.Text;
            }
        }

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
            }
            
            
            else
            {
                operation = btn.Text;
                result = Convert.ToDouble(displayTextBox.Text);
                
                //operation_lbl.Text = result + " " + operation;

                performed = true;
            }
            

        }

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
                    if(currentInput==0)
                    {
                        displayTextBox.Text = "Can't divide by zero";
                        dividedByZero = true;
                    }
                    else
                    {
                        displayTextBox.Text = (result / currentInput).ToString();
                    }
                    
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message.ToString());
            }

            //displayTextBox.Text = result.ToString();
            
        }

        private void equalBtn_Click(object sender, EventArgs e)
        {
            Calculation();
            result = 0;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

            int txtLength = displayTextBox.Text.Length;

            if (txtLength > 0)
            {
                displayTextBox.Text = displayTextBox.Text.Remove(displayTextBox.Text.Length - 1, 1);
                MessageBox.Show(txtLength.ToString());
                
            }

            if (displayTextBox.Text == "")
            {
                displayTextBox.Text = "0";
            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //displayTextBox.Text = "0";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            displayTextBox.Text = "0";
            result = 0;
        }

        private void clearEntryBtn_Click(object sender, EventArgs e)
        {
            displayTextBox.Text = "0";
        }
    }
}
