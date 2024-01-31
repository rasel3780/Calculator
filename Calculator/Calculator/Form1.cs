namespace Calculator
{
    public partial class Form1 : Form
    {

        string input = string.Empty;
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
                    input += btn.Text;
                }
            }
            else
            {
                input += btn.Text;
            }

            displayTextBox.Text = input;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            operation = btn.Text;
            result = Convert.ToDouble(displayTextBox.Text);
            operation_lbl.Text = result + " " + operation;


            performed = true;



        }

        private void Calculation()
        {
            double currentInput = Convert.ToDouble(input);

            if (operation == "+")
            {
                result += currentInput;
            }
            else if (operation == "-")
            {
                result -= currentInput;
            }
            else if (operation == "x")
            {
                result *= currentInput;
            }
            else
            {
                result /= currentInput;
            }

            displayTextBox.Text = result.ToString();
            input = string.Empty;
        }

        private void equalBtn_Click(object sender, EventArgs e)
        {
            Calculation();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

            int txtLength = input.Length;

            if (txtLength > 0)
            {
                input = input.Substring(0, txtLength - 1);
                displayTextBox.Text = input;
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
