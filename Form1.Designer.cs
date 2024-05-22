namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TxtDisplay = new TextBox();
            SuspendLayout();
            // 
            // TxtDisplay
            // 
            TxtDisplay.BackColor = Color.FromArgb(32, 32, 32);
            TxtDisplay.BorderStyle = BorderStyle.None;
            TxtDisplay.Dock = DockStyle.Top;
            TxtDisplay.Font = new Font("Gadugi", 34F);
            TxtDisplay.ForeColor = Color.DarkGray;
            TxtDisplay.Location = new Point(0, 0);
            TxtDisplay.Margin = new Padding(0);
            TxtDisplay.Multiline = true;
            TxtDisplay.Name = "TxtDisplay";
            TxtDisplay.Size = new Size(350, 72);
            TxtDisplay.TabIndex = 0;
            TxtDisplay.Text = "0";
            TxtDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(350, 570);
            Controls.Add(TxtDisplay);
            Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtDisplay;
    }
}
