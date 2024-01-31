namespace Calculator
{
    public partial class Form1 : Form
    {

        string input = string.Empty;
        string operations;
        double result = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void digits_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

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
            Calculation();
        }

        private void Calculation()
        {
            double currentInput = Convert.ToDouble(input);

            if (operations == "+")
            {
                result += currentInput;
            }
            else if (operations == "-")
            {
                result -= currentInput;
            }
            else if (operations == "x")
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
            
            int txtLength = displayTextBox.Text.Length;
            if(txtLength > 0) 
            {
                displayTextBox.Text = displayTextBox.Text.Remove(txtLength - 1, 1);
            }
            if(displayTextBox.Text == "")
            {
                displayTextBox.Text = "0";
            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        
    }
}
