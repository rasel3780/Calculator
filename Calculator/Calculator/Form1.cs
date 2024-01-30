namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string input = "";
        string operations;

        private void digits_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if(btn.Text==".")
            {
                if(!displayTextBox.Text.Contains("."))
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
