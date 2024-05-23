namespace Calculator
{
    public partial class Form1 : Form
    {
        //Fields
        Double result = 0;
        string operation = string.Empty;
        string fstNum, secNum;
        bool enterValue = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnNum_Click(object sender, EventArgs e)
        {
            if (TxtDisplay1.Text == "0" || enterValue) TxtDisplay1.Text = string.Empty;

            enterValue = false;
            CustomButton button = (CustomButton) sender;
            if (button.Text == ".")
            {
                if (!TxtDisplay1.Text.Contains("."))
                    TxtDisplay1.Text = TxtDisplay1.Text + button.Text;
            }
            else TxtDisplay1.Text = TxtDisplay1.Text + button.Text;
        }

        private void BtnMathOperation_Click(object sender, EventArgs e)
        {
            if (result != 0) BtnEquals.PerformClick();
            else result = Double.Parse(TxtDisplay1.Text);

            CustomButton button = (CustomButton) sender;
            operation = button.Text;
            enterValue = true;
            if (TxtDisplay1.Text != "0")
            {
                TxtDisplay2.Text = fstNum = $"{result} {operation}";
                TxtDisplay1.Text = string.Empty;
            }
        }
    }
}
