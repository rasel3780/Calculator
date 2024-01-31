namespace Calculator
{
    public partial class Form1 : Form
    {

        string operation = "";
        double result = 0;
        bool performed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void digits_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;


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
            if(displayTextBox.Text == "0" && btn.Text=="-")
            {
                displayTextBox.Clear() ;
                displayTextBox.Text += btn.Text;
            }
            
            else
            {
                operation = btn.Text;
                result = Convert.ToDouble(displayTextBox.Text);
                operation_lbl.Text = result + " " + operation;

                performed = true;
            }
            

        }

        private void Calculation()
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
                displayTextBox.Text = (result / currentInput).ToString();
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
                displayTextBox.Text = displayTextBox.Text.Substring(0, txtLength - 1);
                
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
