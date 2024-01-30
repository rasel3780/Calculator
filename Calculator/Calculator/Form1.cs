namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string input = "";

        private void digits(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            input += btn.Text;
            displayTextBox.Text  = input;
        }
    }
}
