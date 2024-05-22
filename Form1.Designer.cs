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
            customButton1 = new CustomButton();
            customButton2 = new CustomButton();
            customButton3 = new CustomButton();
            customButton4 = new CustomButton();
            customButton5 = new CustomButton();
            customButton6 = new CustomButton();
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
            // customButton1
            // 
            customButton1.BackColor = Color.FromArgb(32, 32, 32);
            customButton1.BackgroundColor = Color.FromArgb(32, 32, 32);
            customButton1.BorderColor = Color.Silver;
            customButton1.BorderRadius = 0;
            customButton1.BorderSize = 0;
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.FlatStyle = FlatStyle.Flat;
            customButton1.ForeColor = Color.White;
            customButton1.Location = new Point(294, 123);
            customButton1.Margin = new Padding(0);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(50, 30);
            customButton1.TabIndex = 9;
            customButton1.Text = "M^";
            customButton1.TextColor = Color.White;
            customButton1.UseVisualStyleBackColor = false;
            // 
            // customButton2
            // 
            customButton2.BackColor = Color.FromArgb(32, 32, 32);
            customButton2.BackgroundColor = Color.FromArgb(32, 32, 32);
            customButton2.BorderColor = Color.Silver;
            customButton2.BorderRadius = 0;
            customButton2.BorderSize = 0;
            customButton2.FlatAppearance.BorderSize = 0;
            customButton2.FlatStyle = FlatStyle.Flat;
            customButton2.ForeColor = Color.White;
            customButton2.Location = new Point(237, 123);
            customButton2.Margin = new Padding(0);
            customButton2.Name = "customButton2";
            customButton2.Size = new Size(50, 30);
            customButton2.TabIndex = 10;
            customButton2.Text = "MS";
            customButton2.TextColor = Color.White;
            customButton2.UseVisualStyleBackColor = false;
            // 
            // customButton3
            // 
            customButton3.BackColor = Color.FromArgb(32, 32, 32);
            customButton3.BackgroundColor = Color.FromArgb(32, 32, 32);
            customButton3.BorderColor = Color.Silver;
            customButton3.BorderRadius = 0;
            customButton3.BorderSize = 0;
            customButton3.FlatAppearance.BorderSize = 0;
            customButton3.FlatStyle = FlatStyle.Flat;
            customButton3.ForeColor = Color.White;
            customButton3.Location = new Point(180, 123);
            customButton3.Margin = new Padding(0);
            customButton3.Name = "customButton3";
            customButton3.Size = new Size(50, 30);
            customButton3.TabIndex = 11;
            customButton3.Text = "M-";
            customButton3.TextColor = Color.White;
            customButton3.UseVisualStyleBackColor = false;
            // 
            // customButton4
            // 
            customButton4.BackColor = Color.FromArgb(32, 32, 32);
            customButton4.BackgroundColor = Color.FromArgb(32, 32, 32);
            customButton4.BorderColor = Color.Silver;
            customButton4.BorderRadius = 0;
            customButton4.BorderSize = 0;
            customButton4.FlatAppearance.BorderSize = 0;
            customButton4.FlatStyle = FlatStyle.Flat;
            customButton4.ForeColor = Color.White;
            customButton4.Location = new Point(123, 123);
            customButton4.Margin = new Padding(0);
            customButton4.Name = "customButton4";
            customButton4.Size = new Size(50, 30);
            customButton4.TabIndex = 12;
            customButton4.Text = "M+";
            customButton4.TextColor = Color.White;
            customButton4.UseVisualStyleBackColor = false;
            // 
            // customButton5
            // 
            customButton5.BackColor = Color.FromArgb(32, 32, 32);
            customButton5.BackgroundColor = Color.FromArgb(32, 32, 32);
            customButton5.BorderColor = Color.Silver;
            customButton5.BorderRadius = 0;
            customButton5.BorderSize = 0;
            customButton5.FlatAppearance.BorderSize = 0;
            customButton5.FlatStyle = FlatStyle.Flat;
            customButton5.ForeColor = Color.White;
            customButton5.Location = new Point(66, 123);
            customButton5.Margin = new Padding(0);
            customButton5.Name = "customButton5";
            customButton5.Size = new Size(50, 30);
            customButton5.TabIndex = 13;
            customButton5.Text = "MR";
            customButton5.TextColor = Color.White;
            customButton5.UseVisualStyleBackColor = false;
            // 
            // customButton6
            // 
            customButton6.BackColor = Color.FromArgb(32, 32, 32);
            customButton6.BackgroundColor = Color.FromArgb(32, 32, 32);
            customButton6.BorderColor = Color.Silver;
            customButton6.BorderRadius = 0;
            customButton6.BorderSize = 0;
            customButton6.FlatAppearance.BorderSize = 0;
            customButton6.FlatStyle = FlatStyle.Flat;
            customButton6.ForeColor = Color.White;
            customButton6.Location = new Point(9, 123);
            customButton6.Margin = new Padding(0);
            customButton6.Name = "customButton6";
            customButton6.Size = new Size(50, 30);
            customButton6.TabIndex = 14;
            customButton6.Text = "MC";
            customButton6.TextColor = Color.White;
            customButton6.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(350, 570);
            Controls.Add(customButton6);
            Controls.Add(customButton5);
            Controls.Add(customButton4);
            Controls.Add(customButton3);
            Controls.Add(customButton2);
            Controls.Add(customButton1);
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
        private CustomButton customButton1;
        private CustomButton customButton2;
        private CustomButton customButton3;
        private CustomButton customButton4;
        private CustomButton customButton5;
        private CustomButton customButton6;
    }
}
