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
            TxtDisplay2 = new TextBox();
            TxtDisplay1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // TxtDisplay2
            // 
            TxtDisplay2.BackColor = Color.FromArgb(32, 32, 32);
            TxtDisplay2.BorderStyle = BorderStyle.None;
            TxtDisplay2.Dock = DockStyle.Top;
            TxtDisplay2.Font = new Font("Gadugi", 14F);
            TxtDisplay2.ForeColor = Color.DarkGray;
            TxtDisplay2.Location = new Point(0, 0);
            TxtDisplay2.Margin = new Padding(0);
            TxtDisplay2.Multiline = true;
            TxtDisplay2.Name = "TxtDisplay2";
            TxtDisplay2.Size = new Size(350, 32);
            TxtDisplay2.TabIndex = 0;
            TxtDisplay2.Text = "0";
            TxtDisplay2.TextAlign = HorizontalAlignment.Right;
            // 
            // TxtDisplay1
            // 
            TxtDisplay1.BackColor = Color.FromArgb(32, 32, 32);
            TxtDisplay1.BorderStyle = BorderStyle.None;
            TxtDisplay1.Dock = DockStyle.Top;
            TxtDisplay1.Font = new Font("Gadugi", 34F, FontStyle.Bold);
            TxtDisplay1.ForeColor = Color.Silver;
            TxtDisplay1.Location = new Point(0, 32);
            TxtDisplay1.Margin = new Padding(0);
            TxtDisplay1.Multiline = true;
            TxtDisplay1.Name = "TxtDisplay1";
            TxtDisplay1.Size = new Size(350, 72);
            TxtDisplay1.TabIndex = 1;
            TxtDisplay1.Text = "0";
            TxtDisplay1.TextAlign = HorizontalAlignment.Right;
            // 
            // button1
            // 
            button1.Location = new Point(161, 242);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(350, 570);
            Controls.Add(button1);
            Controls.Add(TxtDisplay1);
            Controls.Add(TxtDisplay2);
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

        private TextBox TxtDisplay2;
        private TextBox TxtDisplay1;
        private Button button1;
    }
}
