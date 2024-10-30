namespace CalculatorApp
{
    public partial class CalculatorApp : Form
    {
        double FirstNumber = 0;
        string Operation = "";

        public CalculatorApp()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void AttemptAddToTextBox(string text)
        {
            if (textBox.Text == "0" && textBox.Text != null) {
                textBox.Text = text;
            }
            else {
                textBox.Text = textBox.Text + text;
            }
        }
        private void DoOperation(string operation)
        {
            FirstNumber = Convert.ToDouble(textBox.Text);
            operationText.Text += textBox.Text + operation;
            textBox.Text = "0";
            Operation = operation;
        }
        private void bEquals_Click(object sender, EventArgs e)
        {
            operationText.Text = "";
            double SecondNumber;
            double Result;

            SecondNumber = Convert.ToDouble(textBox.Text);

            if (Operation == "+") {
                Result = (FirstNumber + SecondNumber);
                textBox.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "-") {
                Result = (FirstNumber - SecondNumber);
                textBox.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "*") {
                Result = (FirstNumber * SecondNumber);
                textBox.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "/") {
                if (SecondNumber == 0) {
                    textBox.Text = "Error";

                }
                else {
                    Result = (FirstNumber / SecondNumber);
                    textBox.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            }
        }
        private void bBackspace_Click(object sender, EventArgs e)
        {

        }
        private void bClearEverything_Click(object sender, EventArgs e)
        {

        }
        private void bNegate_Click(object sender, EventArgs e)
        {

        }
        private void bMultiply_Click(object sender, EventArgs e)
        {
            DoOperation("*");
        }
        private void bSubtract_Click(object sender, EventArgs e)
        {
            DoOperation("-");
        }
        private void bAdd_Click(object sender, EventArgs e)
        {
            DoOperation("+");
        }
        private void bClear_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
        }
        private void bDivide_Click(object sender, EventArgs e)
        {
            DoOperation("/");
        }
        private void bPeriod_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + ".";
        }
        private void b1_Click(object sender, EventArgs e)
        {
            AttemptAddToTextBox("1");
        }
        private void b2_Click(object sender, EventArgs e)
        {
            AttemptAddToTextBox("2");
        }
        private void b3_Click(object sender, EventArgs e)
        {
            AttemptAddToTextBox("3");
        }
        private void b4_Click(object sender, EventArgs e)
        {
            AttemptAddToTextBox("4");
        }
        private void b5_Click(object sender, EventArgs e)
        {
            AttemptAddToTextBox("5");
        }
        private void b6_Click(object sender, EventArgs e)
        {
            AttemptAddToTextBox("6");
        }
        private void b7_Click(object sender, EventArgs e)
        {
            AttemptAddToTextBox("7");
        }
        private void b8_Click(object sender, EventArgs e)
        {
            AttemptAddToTextBox("8");
        }
        private void b9_Click(object sender, EventArgs e)
        {
            AttemptAddToTextBox("9");
        }
        private void b0_Click(object sender, EventArgs e)
        {
            AttemptAddToTextBox("0");
        }
    }
}
