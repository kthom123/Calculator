using System;
using System.Drawing;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        // Fields
        decimal result = 0;
        string operation = string.Empty;
        bool enterValue = false;
        bool isResultDisplayed = false;
        const int MaxDisplayLength = 20;

        public Form1()
        {
            InitializeComponent();
            InitializeDisplay();
        }

        // Initializes the display properties
        private void InitializeDisplay()
        {
            TxtDisplay1.Text = "0";
            TxtDisplay1.MaxLength = MaxDisplayLength;
            TxtDisplay1.TextAlign = HorizontalAlignment.Right;
            TxtDisplay1.Font = new Font("Gadugi", 34, FontStyle.Bold);
            TxtDisplay1.WordWrap = false;
            TxtDisplay1.AutoSize = false;
            TxtDisplay1.TextChanged += TxtDisplay1_TextChanged;
        }

        // Handles number button click
        private void BtnNum_Click(object sender, EventArgs e)
        {
            if (TxtDisplay1.Text.Length >= MaxDisplayLength)
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

        // Handles math operation button click
        private void BtnMathOperation_Click(object sender, EventArgs e)
        {
            if (result != 0 && !enterValue)
            {
                BtnEquals.PerformClick();
                enterValue = true;
            }
            else
            {
                result = decimal.Parse(TxtDisplay1.Text);
            }

            CustomButton button = (CustomButton)sender;
            operation = button.Text;
            enterValue = true;

            // Update TxtDisplay2 to show the current operation
            TxtDisplay2.Text = $"{result} {operation}";

            // Check if the number is too long and format it accordingly
            if (TxtDisplay1.Text.Length > MaxDisplayLength - 2)
            {
                TxtDisplay1.Text = "0"; // Reset TxtDisplay1 to "0"
            }
        }

        // Handles equals button click
        private void BtnEquals_Click(object sender, EventArgs e)
        {
            if (operation == string.Empty || TxtDisplay1.Text == string.Empty)
                return;

            decimal secondNum = decimal.Parse(TxtDisplay1.Text);

            switch (operation)
            {
                case "+":
                    TxtDisplay1.Text = (result + secondNum).ToString("0.#############################");
                    break;
                case "-":
                    TxtDisplay1.Text = (result - secondNum).ToString("0.#############################");
                    break;
                case "×":
                    TxtDisplay1.Text = (result * secondNum).ToString("0.#############################");
                    break;
                case "÷":
                    TxtDisplay1.Text = (result / secondNum).ToString("0.#############################");
                    break;
            }

            result = decimal.Parse(TxtDisplay1.Text);
            TxtDisplay2.Text = string.Empty;
            operation = string.Empty;
            enterValue = false;
            isResultDisplayed = true;
        }

        // Handles C button click
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
            ResetFontSize(); // Reset font size after clearing
        }

        // Handles AC button click
        private void BtnAC_Click(object sender, EventArgs e)
        {
            TxtDisplay1.Text = "0";
            result = 0;
            operation = string.Empty;
            TxtDisplay2.Text = string.Empty;
            ResetFontSize(); // Reset font size after clearing
        }

        // Resets font size
        private void ResetFontSize()
        {
            TxtDisplay1.Font = new Font("Gadugi", 34, FontStyle.Bold); // Reset font size to initial size
        }

        // Handles other operation buttons click
        private void BtnOperations_Click(object sender, EventArgs e)
        {
            CustomButton button = (CustomButton)sender;
            operation = button.Text;
            switch (operation)
            {
                case "√x":
                    TxtDisplay2.Text = $"√({TxtDisplay1.Text})";
                    TxtDisplay1.Text = Math.Sqrt((double)decimal.Parse(TxtDisplay1.Text)).ToString("0.#############################");
                    break;
                case "x²":
                    TxtDisplay2.Text = $"({TxtDisplay1.Text})²";
                    TxtDisplay1.Text = (decimal.Parse(TxtDisplay1.Text) * decimal.Parse(TxtDisplay1.Text)).ToString("0.#############################");
                    break;
                case "¹⁄ₓ":
                    TxtDisplay2.Text = $"¹⁄({TxtDisplay1.Text})";
                    TxtDisplay1.Text = (1 / decimal.Parse(TxtDisplay1.Text)).ToString("0.#############################");
                    break;
                case "%":
                    TxtDisplay2.Text = $"%({TxtDisplay1.Text})";
                    TxtDisplay1.Text = (decimal.Parse(TxtDisplay1.Text) / 100).ToString("0.#############################");
                    break;
                case "±":
                    TxtDisplay1.Text = (-decimal.Parse(TxtDisplay1.Text)).ToString("0.#############################");
                    break;
            }
        }

        // Handles text change in TxtDisplay1
        private void TxtDisplay1_TextChanged(object sender, EventArgs e)
        {
            AdjustFontSize();
        }

        // Adjusts font size based on text length
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
