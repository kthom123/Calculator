using System;
using System.Drawing;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        // Fields
        double result = 0;
        string operation = string.Empty;
        bool enterValue = false;
        bool isResultDisplayed = false;

        public Form1()
        {
            InitializeComponent();
            TxtDisplay1.Text = "0";
            TxtDisplay1.MaxLength = 20;
            TxtDisplay1.TextAlign = HorizontalAlignment.Right;
            TxtDisplay1.Font = new Font("Gadugi", 34, FontStyle.Bold);
            TxtDisplay1.WordWrap = false;
            TxtDisplay1.AutoSize = false;
            TxtDisplay1.TextChanged += TxtDisplay1_TextChanged;
        }

        private void BtnNum_Click(object sender, EventArgs e)
        {
            if (TxtDisplay1.Text.Length >= 20)
                return;

            if (TxtDisplay1.Text == "0" || enterValue)
            {
                TxtDisplay1.Text = string.Empty;
                enterValue = false;
            }

            CustomButton button = (CustomButton)sender;
            if (button.Text == ".")
            {
                if (!TxtDisplay1.Text.Contains("."))
                    TxtDisplay1.Text += button.Text;
            }
            else
            {
                TxtDisplay1.Text += button.Text;
            }

            isResultDisplayed = false;
        }

        private void BtnMathOperation_Click(object sender, EventArgs e)
        {
            if (result != 0 && !enterValue)
            {
                BtnEquals.PerformClick();
                enterValue = true;
            }
            else
            {
                result = double.Parse(TxtDisplay1.Text);
            }

            CustomButton button = (CustomButton)sender;
            operation = button.Text;
            enterValue = true;
            TxtDisplay2.Text = $"{result} {operation}";
        }

        private void BtnEquals_Click(object sender, EventArgs e)
        {
            if (operation == string.Empty)
                return;

            double secondNum = double.Parse(TxtDisplay1.Text);

            switch (operation)
            {
                case "+":
                    TxtDisplay1.Text = (result + secondNum).ToString();
                    break;
                case "-":
                    TxtDisplay1.Text = (result - secondNum).ToString();
                    break;
                case "×":
                    TxtDisplay1.Text = (result * secondNum).ToString();
                    break;
                case "÷":
                    TxtDisplay1.Text = (result / secondNum).ToString("0.####################");
                    break;
            }

            result = double.Parse(TxtDisplay1.Text);
            TxtDisplay2.Text = string.Empty;
            operation = string.Empty;
            enterValue = false;
            isResultDisplayed = true;
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            if (TxtDisplay1.Text.Length > 1)
            {
                TxtDisplay1.Text = TxtDisplay1.Text.Remove(TxtDisplay1.Text.Length - 1, 1);
            }
            else
            {
                TxtDisplay1.Text = "0";
            }
        }

        private void BtnAC_Click(object sender, EventArgs e)
        {
            TxtDisplay1.Text = "0";
            result = 0;
            operation = string.Empty;
            TxtDisplay2.Text = string.Empty;
        }

        private void BtnOperations_Click(object sender, EventArgs e)
        {
            CustomButton button = (CustomButton)sender;
            operation = button.Text;
            switch (operation)
            {
                case "√x":
                    TxtDisplay2.Text = $"√({TxtDisplay1.Text})";
                    TxtDisplay1.Text = Convert.ToString(Math.Sqrt(double.Parse(TxtDisplay1.Text)));
                    break;
                case "x²":
                    TxtDisplay2.Text = $"({TxtDisplay1.Text})²";
                    TxtDisplay1.Text = Convert.ToString(Convert.ToDouble(TxtDisplay1.Text) * Convert.ToDouble(TxtDisplay1.Text));
                    break;
                case "¹⁄ₓ":
                    TxtDisplay2.Text = $"¹⁄({TxtDisplay1.Text})";
                    TxtDisplay1.Text = Convert.ToString(1.0 / Convert.ToDouble(TxtDisplay1.Text));
                    break;
                case "%":
                    TxtDisplay2.Text = $"%({TxtDisplay1.Text})";
                    TxtDisplay1.Text = Convert.ToString(Convert.ToDouble(TxtDisplay1.Text) / 100);
                    break;
                case "±":
                    TxtDisplay1.Text = Convert.ToString(-1 * Convert.ToDouble(TxtDisplay1.Text));
                    break;
            }
        }

        private void TxtDisplay1_TextChanged(object sender, EventArgs e)
        {
            AdjustFontSize();
        }

        private void AdjustFontSize()
        {
            const int maxWidth = 300; // Adjust as needed
            int fontSize = 34; // Initial font size
            Size textSize = TextRenderer.MeasureText(TxtDisplay1.Text, TxtDisplay1.Font);

            while (textSize.Width > TxtDisplay1.Width && fontSize > 6)
            {
                TxtDisplay1.Font = new Font("Gadugi", fontSize, FontStyle.Bold);
                textSize = TextRenderer.MeasureText(TxtDisplay1.Text, TxtDisplay1.Font);
                fontSize--;
            }
        }
    }
}