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
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
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
            button1.BackColor = Color.FromArgb(32, 32, 32);
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(286, 121);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(55, 30);
            button1.TabIndex = 2;
            button1.Text = "M-";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.Location = new Point(133, 258);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(85, 55);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(32, 32, 32);
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(231, 121);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(55, 30);
            button3.TabIndex = 4;
            button3.Text = "M-";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(32, 32, 32);
            button4.BackgroundImageLayout = ImageLayout.None;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Location = new Point(176, 121);
            button4.Margin = new Padding(0);
            button4.Name = "button4";
            button4.Size = new Size(55, 30);
            button4.TabIndex = 5;
            button4.Text = "M-";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(32, 32, 32);
            button5.BackgroundImageLayout = ImageLayout.None;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.White;
            button5.Location = new Point(121, 121);
            button5.Margin = new Padding(0);
            button5.Name = "button5";
            button5.Size = new Size(55, 30);
            button5.TabIndex = 6;
            button5.Text = "M-";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(32, 32, 32);
            button6.BackgroundImageLayout = ImageLayout.None;
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.White;
            button6.Location = new Point(66, 121);
            button6.Margin = new Padding(0);
            button6.Name = "button6";
            button6.Size = new Size(55, 30);
            button6.TabIndex = 7;
            button6.Text = "M-";
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(32, 32, 32);
            button7.BackgroundImageLayout = ImageLayout.None;
            button7.FlatStyle = FlatStyle.Flat;
            button7.ForeColor = Color.White;
            button7.Location = new Point(11, 121);
            button7.Margin = new Padding(0);
            button7.Name = "button7";
            button7.Size = new Size(55, 30);
            button7.TabIndex = 8;
            button7.Text = "M-";
            button7.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(350, 570);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
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
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
    }
}
