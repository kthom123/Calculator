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
        }
    }
}
