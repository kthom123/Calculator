﻿namespace Calculator
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
            Title = new TextBox();
            TxtDisplay1 = new TextBox();
            customButton1 = new CustomButton();
            customButton2 = new CustomButton();
            customButton3 = new CustomButton();
            customButton4 = new CustomButton();
            customButton5 = new CustomButton();
            customButton6 = new CustomButton();
            BtnC = new CustomButton();
            BtnAC = new CustomButton();
            BtnPercent = new CustomButton();
            Btn1X = new CustomButton();
            BtnX2 = new CustomButton();
            BtnSquare = new CustomButton();
            BtnDivide = new CustomButton();
            Btn7 = new CustomButton();
            Btn8 = new CustomButton();
            Btn9 = new CustomButton();
            BtnMultiply = new CustomButton();
            Btn4 = new CustomButton();
            Btn5 = new CustomButton();
            Btn6 = new CustomButton();
            BtnMinus = new CustomButton();
            Btn1 = new CustomButton();
            Btn2 = new CustomButton();
            Btn3 = new CustomButton();
            BtnPlus = new CustomButton();
            BtnPM = new CustomButton();
            Btn0 = new CustomButton();
            BtnDecimal = new CustomButton();
            BtnEquals = new CustomButton();
            TxtDisplay2 = new TextBox();
            SuspendLayout();
            // 
            // Title
            // 
            Title.BackColor = Color.FromArgb(32, 32, 32);
            Title.BorderStyle = BorderStyle.None;
            Title.Dock = DockStyle.Top;
            Title.Font = new Font("Gadugi", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.ForeColor = Color.DarkGray;
            Title.Location = new Point(0, 0);
            Title.Margin = new Padding(0);
            Title.Multiline = true;
            Title.Name = "Title";
            Title.Size = new Size(370, 30);
            Title.TabIndex = 0;
            Title.Text = " 🖩 ";
            // 
            // TxtDisplay1
            // 
            TxtDisplay1.BackColor = Color.FromArgb(32, 32, 32);
            TxtDisplay1.BorderStyle = BorderStyle.None;
            TxtDisplay1.Dock = DockStyle.Top;
            TxtDisplay1.Font = new Font("Gadugi", 34F, FontStyle.Bold);
            TxtDisplay1.ForeColor = Color.Silver;
            TxtDisplay1.Location = new Point(0, 30);
            TxtDisplay1.Margin = new Padding(0);
            TxtDisplay1.Multiline = true;
            TxtDisplay1.Name = "TxtDisplay1";
            TxtDisplay1.Size = new Size(370, 74);
            TxtDisplay1.TabIndex = 1;
            TxtDisplay1.Text = "0";
            TxtDisplay1.TextAlign = HorizontalAlignment.Right;
            // 
            // customButton1
            // 
            customButton1.BackColor = Color.FromArgb(32, 32, 32);
            customButton1.BackgroundColor = Color.FromArgb(32, 32, 32);
            customButton1.BorderColor = Color.FromArgb(32, 32, 32);
            customButton1.BorderRadius = 15;
            customButton1.BorderSize = 0;
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.FlatStyle = FlatStyle.Flat;
            customButton1.ForeColor = Color.White;
            customButton1.Location = new Point(304, 161);
            customButton1.Margin = new Padding(0);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(50, 30);
            customButton1.TabIndex = 9;
            customButton1.Text = "M⌄";
            customButton1.TextColor = Color.White;
            customButton1.UseVisualStyleBackColor = false;
            // 
            // customButton2
            // 
            customButton2.BackColor = Color.FromArgb(32, 32, 32);
            customButton2.BackgroundColor = Color.FromArgb(32, 32, 32);
            customButton2.BorderColor = Color.FromArgb(32, 32, 32);
            customButton2.BorderRadius = 15;
            customButton2.BorderSize = 0;
            customButton2.FlatAppearance.BorderSize = 0;
            customButton2.FlatStyle = FlatStyle.Flat;
            customButton2.ForeColor = Color.White;
            customButton2.Location = new Point(246, 161);
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
            customButton3.BorderColor = Color.FromArgb(32, 32, 32);
            customButton3.BorderRadius = 15;
            customButton3.BorderSize = 0;
            customButton3.FlatAppearance.BorderSize = 0;
            customButton3.FlatStyle = FlatStyle.Flat;
            customButton3.ForeColor = Color.White;
            customButton3.Location = new Point(188, 161);
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
            customButton4.BorderColor = Color.FromArgb(32, 32, 32);
            customButton4.BorderRadius = 15;
            customButton4.BorderSize = 0;
            customButton4.FlatAppearance.BorderSize = 0;
            customButton4.FlatStyle = FlatStyle.Flat;
            customButton4.ForeColor = Color.White;
            customButton4.Location = new Point(130, 161);
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
            customButton5.BorderColor = Color.FromArgb(32, 32, 32);
            customButton5.BorderRadius = 15;
            customButton5.BorderSize = 0;
            customButton5.FlatAppearance.BorderSize = 0;
            customButton5.FlatStyle = FlatStyle.Flat;
            customButton5.ForeColor = Color.White;
            customButton5.Location = new Point(72, 161);
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
            customButton6.BorderColor = Color.FromArgb(32, 32, 32);
            customButton6.BorderRadius = 15;
            customButton6.BorderSize = 0;
            customButton6.FlatAppearance.BorderSize = 0;
            customButton6.FlatStyle = FlatStyle.Flat;
            customButton6.ForeColor = Color.White;
            customButton6.Location = new Point(14, 161);
            customButton6.Margin = new Padding(0);
            customButton6.Name = "customButton6";
            customButton6.Size = new Size(50, 30);
            customButton6.TabIndex = 14;
            customButton6.Text = "MC";
            customButton6.TextColor = Color.White;
            customButton6.UseVisualStyleBackColor = false;
            // 
            // BtnC
            // 
            BtnC.BackColor = Color.FromArgb(50, 50, 50);
            BtnC.BackgroundColor = Color.FromArgb(50, 50, 50);
            BtnC.BorderColor = Color.FromArgb(32, 32, 32);
            BtnC.BorderRadius = 10;
            BtnC.BorderSize = 0;
            BtnC.FlatAppearance.BorderSize = 0;
            BtnC.FlatStyle = FlatStyle.Flat;
            BtnC.ForeColor = Color.White;
            BtnC.Location = new Point(232, 215);
            BtnC.Margin = new Padding(0);
            BtnC.Name = "BtnC";
            BtnC.Size = new Size(130, 50);
            BtnC.TabIndex = 16;
            BtnC.Text = "C";
            BtnC.TextColor = Color.White;
            BtnC.UseVisualStyleBackColor = false;
            BtnC.Click += BtnC_Click;
            // 
            // BtnAC
            // 
            BtnAC.BackColor = Color.FromArgb(50, 50, 50);
            BtnAC.BackgroundColor = Color.FromArgb(50, 50, 50);
            BtnAC.BorderColor = Color.FromArgb(32, 32, 32);
            BtnAC.BorderRadius = 10;
            BtnAC.BorderSize = 0;
            BtnAC.FlatAppearance.BorderSize = 0;
            BtnAC.FlatStyle = FlatStyle.Flat;
            BtnAC.ForeColor = Color.White;
            BtnAC.Location = new Point(99, 215);
            BtnAC.Margin = new Padding(0);
            BtnAC.Name = "BtnAC";
            BtnAC.Size = new Size(130, 50);
            BtnAC.TabIndex = 17;
            BtnAC.Text = "AC";
            BtnAC.TextColor = Color.White;
            BtnAC.UseVisualStyleBackColor = false;
            BtnAC.Click += BtnAC_Click;
            // 
            // BtnPercent
            // 
            BtnPercent.BackColor = Color.FromArgb(50, 50, 50);
            BtnPercent.BackgroundColor = Color.FromArgb(50, 50, 50);
            BtnPercent.BorderColor = Color.FromArgb(32, 32, 32);
            BtnPercent.BorderRadius = 10;
            BtnPercent.BorderSize = 0;
            BtnPercent.FlatAppearance.BorderSize = 0;
            BtnPercent.FlatStyle = FlatStyle.Flat;
            BtnPercent.ForeColor = Color.White;
            BtnPercent.Location = new Point(11, 215);
            BtnPercent.Margin = new Padding(0);
            BtnPercent.Name = "BtnPercent";
            BtnPercent.Size = new Size(85, 50);
            BtnPercent.TabIndex = 18;
            BtnPercent.Text = "%";
            BtnPercent.TextColor = Color.White;
            BtnPercent.UseVisualStyleBackColor = false;
            BtnPercent.Click += BtnOperations_Click;
            // 
            // Btn1X
            // 
            Btn1X.BackColor = Color.FromArgb(50, 50, 50);
            Btn1X.BackgroundColor = Color.FromArgb(50, 50, 50);
            Btn1X.BorderColor = Color.FromArgb(32, 32, 32);
            Btn1X.BorderRadius = 10;
            Btn1X.BorderSize = 0;
            Btn1X.FlatAppearance.BorderSize = 0;
            Btn1X.FlatStyle = FlatStyle.Flat;
            Btn1X.ForeColor = Color.White;
            Btn1X.Location = new Point(11, 274);
            Btn1X.Margin = new Padding(0);
            Btn1X.Name = "Btn1X";
            Btn1X.Size = new Size(85, 50);
            Btn1X.TabIndex = 22;
            Btn1X.Text = "¹⁄ₓ";
            Btn1X.TextColor = Color.White;
            Btn1X.UseVisualStyleBackColor = false;
            Btn1X.Click += BtnOperations_Click;
            // 
            // BtnX2
            // 
            BtnX2.BackColor = Color.FromArgb(50, 50, 50);
            BtnX2.BackgroundColor = Color.FromArgb(50, 50, 50);
            BtnX2.BorderColor = Color.FromArgb(32, 32, 32);
            BtnX2.BorderRadius = 10;
            BtnX2.BorderSize = 0;
            BtnX2.FlatAppearance.BorderSize = 0;
            BtnX2.FlatStyle = FlatStyle.Flat;
            BtnX2.ForeColor = Color.White;
            BtnX2.Location = new Point(99, 274);
            BtnX2.Margin = new Padding(0);
            BtnX2.Name = "BtnX2";
            BtnX2.Size = new Size(85, 50);
            BtnX2.TabIndex = 21;
            BtnX2.Text = "x²";
            BtnX2.TextColor = Color.White;
            BtnX2.UseVisualStyleBackColor = false;
            BtnX2.Click += BtnOperations_Click;
            // 
            // BtnSquare
            // 
            BtnSquare.BackColor = Color.FromArgb(50, 50, 50);
            BtnSquare.BackgroundColor = Color.FromArgb(50, 50, 50);
            BtnSquare.BorderColor = Color.FromArgb(32, 32, 32);
            BtnSquare.BorderRadius = 10;
            BtnSquare.BorderSize = 0;
            BtnSquare.FlatAppearance.BorderSize = 0;
            BtnSquare.FlatStyle = FlatStyle.Flat;
            BtnSquare.ForeColor = Color.White;
            BtnSquare.Location = new Point(187, 274);
            BtnSquare.Margin = new Padding(0);
            BtnSquare.Name = "BtnSquare";
            BtnSquare.Size = new Size(85, 50);
            BtnSquare.TabIndex = 20;
            BtnSquare.Text = "√x";
            BtnSquare.TextColor = Color.White;
            BtnSquare.UseVisualStyleBackColor = false;
            BtnSquare.Click += BtnOperations_Click;
            // 
            // BtnDivide
            // 
            BtnDivide.BackColor = Color.FromArgb(50, 50, 50);
            BtnDivide.BackgroundColor = Color.FromArgb(50, 50, 50);
            BtnDivide.BorderColor = Color.FromArgb(32, 32, 32);
            BtnDivide.BorderRadius = 10;
            BtnDivide.BorderSize = 0;
            BtnDivide.FlatAppearance.BorderSize = 0;
            BtnDivide.FlatStyle = FlatStyle.Flat;
            BtnDivide.ForeColor = Color.White;
            BtnDivide.Location = new Point(275, 274);
            BtnDivide.Margin = new Padding(0);
            BtnDivide.Name = "BtnDivide";
            BtnDivide.Size = new Size(85, 50);
            BtnDivide.TabIndex = 19;
            BtnDivide.Text = "÷";
            BtnDivide.TextColor = Color.White;
            BtnDivide.UseVisualStyleBackColor = false;
            BtnDivide.Click += BtnMathOperation_Click;
            // 
            // Btn7
            // 
            Btn7.BackColor = Color.FromArgb(60, 60, 60);
            Btn7.BackgroundColor = Color.FromArgb(60, 60, 60);
            Btn7.BorderColor = Color.FromArgb(32, 32, 32);
            Btn7.BorderRadius = 10;
            Btn7.BorderSize = 0;
            Btn7.FlatAppearance.BorderSize = 0;
            Btn7.FlatStyle = FlatStyle.Flat;
            Btn7.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            Btn7.ForeColor = Color.White;
            Btn7.Location = new Point(11, 333);
            Btn7.Margin = new Padding(0);
            Btn7.Name = "Btn7";
            Btn7.Size = new Size(85, 50);
            Btn7.TabIndex = 26;
            Btn7.Text = "7";
            Btn7.TextColor = Color.White;
            Btn7.UseVisualStyleBackColor = false;
            Btn7.Click += BtnNum_Click;
            // 
            // Btn8
            // 
            Btn8.BackColor = Color.FromArgb(60, 60, 60);
            Btn8.BackgroundColor = Color.FromArgb(60, 60, 60);
            Btn8.BorderColor = Color.FromArgb(32, 32, 32);
            Btn8.BorderRadius = 10;
            Btn8.BorderSize = 0;
            Btn8.FlatAppearance.BorderSize = 0;
            Btn8.FlatStyle = FlatStyle.Flat;
            Btn8.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            Btn8.ForeColor = Color.White;
            Btn8.Location = new Point(99, 333);
            Btn8.Margin = new Padding(0);
            Btn8.Name = "Btn8";
            Btn8.Size = new Size(85, 50);
            Btn8.TabIndex = 25;
            Btn8.Text = "8";
            Btn8.TextColor = Color.White;
            Btn8.UseVisualStyleBackColor = false;
            Btn8.Click += BtnNum_Click;
            // 
            // Btn9
            // 
            Btn9.BackColor = Color.FromArgb(60, 60, 60);
            Btn9.BackgroundColor = Color.FromArgb(60, 60, 60);
            Btn9.BorderColor = Color.FromArgb(32, 32, 32);
            Btn9.BorderRadius = 10;
            Btn9.BorderSize = 0;
            Btn9.FlatAppearance.BorderSize = 0;
            Btn9.FlatStyle = FlatStyle.Flat;
            Btn9.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            Btn9.ForeColor = Color.White;
            Btn9.Location = new Point(187, 333);
            Btn9.Margin = new Padding(0);
            Btn9.Name = "Btn9";
            Btn9.Size = new Size(85, 50);
            Btn9.TabIndex = 24;
            Btn9.Text = "9";
            Btn9.TextColor = Color.White;
            Btn9.UseVisualStyleBackColor = false;
            Btn9.Click += BtnNum_Click;
            // 
            // BtnMultiply
            // 
            BtnMultiply.BackColor = Color.FromArgb(50, 50, 50);
            BtnMultiply.BackgroundColor = Color.FromArgb(50, 50, 50);
            BtnMultiply.BorderColor = Color.FromArgb(32, 32, 32);
            BtnMultiply.BorderRadius = 10;
            BtnMultiply.BorderSize = 0;
            BtnMultiply.FlatAppearance.BorderSize = 0;
            BtnMultiply.FlatStyle = FlatStyle.Flat;
            BtnMultiply.ForeColor = Color.White;
            BtnMultiply.Location = new Point(276, 333);
            BtnMultiply.Margin = new Padding(0);
            BtnMultiply.Name = "BtnMultiply";
            BtnMultiply.Size = new Size(85, 50);
            BtnMultiply.TabIndex = 23;
            BtnMultiply.Text = "×";
            BtnMultiply.TextColor = Color.White;
            BtnMultiply.UseVisualStyleBackColor = false;
            BtnMultiply.Click += BtnMathOperation_Click;
            // 
            // Btn4
            // 
            Btn4.BackColor = Color.FromArgb(60, 60, 60);
            Btn4.BackgroundColor = Color.FromArgb(60, 60, 60);
            Btn4.BorderColor = Color.FromArgb(32, 32, 32);
            Btn4.BorderRadius = 10;
            Btn4.BorderSize = 0;
            Btn4.FlatAppearance.BorderSize = 0;
            Btn4.FlatStyle = FlatStyle.Flat;
            Btn4.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            Btn4.ForeColor = Color.White;
            Btn4.Location = new Point(11, 392);
            Btn4.Margin = new Padding(0);
            Btn4.Name = "Btn4";
            Btn4.Size = new Size(85, 50);
            Btn4.TabIndex = 30;
            Btn4.Text = "4";
            Btn4.TextColor = Color.White;
            Btn4.UseVisualStyleBackColor = false;
            Btn4.Click += BtnNum_Click;
            // 
            // Btn5
            // 
            Btn5.BackColor = Color.FromArgb(60, 60, 60);
            Btn5.BackgroundColor = Color.FromArgb(60, 60, 60);
            Btn5.BorderColor = Color.FromArgb(32, 32, 32);
            Btn5.BorderRadius = 10;
            Btn5.BorderSize = 0;
            Btn5.FlatAppearance.BorderSize = 0;
            Btn5.FlatStyle = FlatStyle.Flat;
            Btn5.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            Btn5.ForeColor = Color.White;
            Btn5.Location = new Point(99, 392);
            Btn5.Margin = new Padding(0);
            Btn5.Name = "Btn5";
            Btn5.Size = new Size(85, 50);
            Btn5.TabIndex = 29;
            Btn5.Text = "5";
            Btn5.TextColor = Color.White;
            Btn5.UseVisualStyleBackColor = false;
            Btn5.Click += BtnNum_Click;
            // 
            // Btn6
            // 
            Btn6.BackColor = Color.FromArgb(60, 60, 60);
            Btn6.BackgroundColor = Color.FromArgb(60, 60, 60);
            Btn6.BorderColor = Color.FromArgb(32, 32, 32);
            Btn6.BorderRadius = 10;
            Btn6.BorderSize = 0;
            Btn6.FlatAppearance.BorderSize = 0;
            Btn6.FlatStyle = FlatStyle.Flat;
            Btn6.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            Btn6.ForeColor = Color.White;
            Btn6.Location = new Point(187, 392);
            Btn6.Margin = new Padding(0);
            Btn6.Name = "Btn6";
            Btn6.Size = new Size(85, 50);
            Btn6.TabIndex = 28;
            Btn6.Text = "6";
            Btn6.TextColor = Color.White;
            Btn6.UseVisualStyleBackColor = false;
            Btn6.Click += BtnNum_Click;
            // 
            // BtnMinus
            // 
            BtnMinus.BackColor = Color.FromArgb(50, 50, 50);
            BtnMinus.BackgroundColor = Color.FromArgb(50, 50, 50);
            BtnMinus.BorderColor = Color.FromArgb(32, 32, 32);
            BtnMinus.BorderRadius = 10;
            BtnMinus.BorderSize = 0;
            BtnMinus.FlatAppearance.BorderSize = 0;
            BtnMinus.FlatStyle = FlatStyle.Flat;
            BtnMinus.ForeColor = Color.White;
            BtnMinus.Location = new Point(275, 392);
            BtnMinus.Margin = new Padding(0);
            BtnMinus.Name = "BtnMinus";
            BtnMinus.Size = new Size(85, 50);
            BtnMinus.TabIndex = 27;
            BtnMinus.Text = "-";
            BtnMinus.TextColor = Color.White;
            BtnMinus.UseVisualStyleBackColor = false;
            BtnMinus.Click += BtnMathOperation_Click;
            // 
            // Btn1
            // 
            Btn1.BackColor = Color.FromArgb(60, 60, 60);
            Btn1.BackgroundColor = Color.FromArgb(60, 60, 60);
            Btn1.BorderColor = Color.FromArgb(32, 32, 32);
            Btn1.BorderRadius = 10;
            Btn1.BorderSize = 0;
            Btn1.FlatAppearance.BorderSize = 0;
            Btn1.FlatStyle = FlatStyle.Flat;
            Btn1.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            Btn1.ForeColor = Color.White;
            Btn1.Location = new Point(11, 451);
            Btn1.Margin = new Padding(0);
            Btn1.Name = "Btn1";
            Btn1.Size = new Size(85, 50);
            Btn1.TabIndex = 34;
            Btn1.Text = "1";
            Btn1.TextColor = Color.White;
            Btn1.UseVisualStyleBackColor = false;
            Btn1.Click += BtnNum_Click;
            // 
            // Btn2
            // 
            Btn2.BackColor = Color.FromArgb(60, 60, 60);
            Btn2.BackgroundColor = Color.FromArgb(60, 60, 60);
            Btn2.BorderColor = Color.FromArgb(32, 32, 32);
            Btn2.BorderRadius = 10;
            Btn2.BorderSize = 0;
            Btn2.FlatAppearance.BorderSize = 0;
            Btn2.FlatStyle = FlatStyle.Flat;
            Btn2.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            Btn2.ForeColor = Color.White;
            Btn2.Location = new Point(99, 451);
            Btn2.Margin = new Padding(0);
            Btn2.Name = "Btn2";
            Btn2.Size = new Size(85, 50);
            Btn2.TabIndex = 33;
            Btn2.Text = "2";
            Btn2.TextColor = Color.White;
            Btn2.UseVisualStyleBackColor = false;
            Btn2.Click += BtnNum_Click;
            // 
            // Btn3
            // 
            Btn3.BackColor = Color.FromArgb(60, 60, 60);
            Btn3.BackgroundColor = Color.FromArgb(60, 60, 60);
            Btn3.BorderColor = Color.FromArgb(32, 32, 32);
            Btn3.BorderRadius = 10;
            Btn3.BorderSize = 0;
            Btn3.FlatAppearance.BorderSize = 0;
            Btn3.FlatStyle = FlatStyle.Flat;
            Btn3.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            Btn3.ForeColor = Color.White;
            Btn3.Location = new Point(187, 451);
            Btn3.Margin = new Padding(0);
            Btn3.Name = "Btn3";
            Btn3.Size = new Size(85, 50);
            Btn3.TabIndex = 32;
            Btn3.Text = "3";
            Btn3.TextColor = Color.White;
            Btn3.UseVisualStyleBackColor = false;
            Btn3.Click += BtnNum_Click;
            // 
            // BtnPlus
            // 
            BtnPlus.BackColor = Color.FromArgb(50, 50, 50);
            BtnPlus.BackgroundColor = Color.FromArgb(50, 50, 50);
            BtnPlus.BorderColor = Color.FromArgb(32, 32, 32);
            BtnPlus.BorderRadius = 10;
            BtnPlus.BorderSize = 0;
            BtnPlus.FlatAppearance.BorderSize = 0;
            BtnPlus.FlatStyle = FlatStyle.Flat;
            BtnPlus.ForeColor = Color.White;
            BtnPlus.Location = new Point(275, 451);
            BtnPlus.Margin = new Padding(0);
            BtnPlus.Name = "BtnPlus";
            BtnPlus.Size = new Size(85, 50);
            BtnPlus.TabIndex = 31;
            BtnPlus.Text = "+";
            BtnPlus.TextColor = Color.White;
            BtnPlus.UseVisualStyleBackColor = false;
            BtnPlus.Click += BtnMathOperation_Click;
            // 
            // BtnPM
            // 
            BtnPM.BackColor = Color.FromArgb(60, 60, 60);
            BtnPM.BackgroundColor = Color.FromArgb(60, 60, 60);
            BtnPM.BorderColor = Color.FromArgb(32, 32, 32);
            BtnPM.BorderRadius = 10;
            BtnPM.BorderSize = 0;
            BtnPM.FlatAppearance.BorderSize = 0;
            BtnPM.FlatStyle = FlatStyle.Flat;
            BtnPM.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            BtnPM.ForeColor = Color.White;
            BtnPM.Location = new Point(11, 510);
            BtnPM.Margin = new Padding(0);
            BtnPM.Name = "BtnPM";
            BtnPM.Size = new Size(85, 50);
            BtnPM.TabIndex = 38;
            BtnPM.Text = "±";
            BtnPM.TextColor = Color.White;
            BtnPM.UseVisualStyleBackColor = false;
            BtnPM.Click += BtnOperations_Click;
            // 
            // Btn0
            // 
            Btn0.BackColor = Color.FromArgb(60, 60, 60);
            Btn0.BackgroundColor = Color.FromArgb(60, 60, 60);
            Btn0.BorderColor = Color.FromArgb(32, 32, 32);
            Btn0.BorderRadius = 10;
            Btn0.BorderSize = 0;
            Btn0.FlatAppearance.BorderSize = 0;
            Btn0.FlatStyle = FlatStyle.Flat;
            Btn0.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            Btn0.ForeColor = Color.White;
            Btn0.Location = new Point(99, 510);
            Btn0.Margin = new Padding(0);
            Btn0.Name = "Btn0";
            Btn0.Size = new Size(85, 50);
            Btn0.TabIndex = 37;
            Btn0.Text = "0";
            Btn0.TextColor = Color.White;
            Btn0.UseVisualStyleBackColor = false;
            Btn0.Click += BtnNum_Click;
            // 
            // BtnDecimal
            // 
            BtnDecimal.BackColor = Color.FromArgb(60, 60, 60);
            BtnDecimal.BackgroundColor = Color.FromArgb(60, 60, 60);
            BtnDecimal.BorderColor = Color.FromArgb(32, 32, 32);
            BtnDecimal.BorderRadius = 10;
            BtnDecimal.BorderSize = 0;
            BtnDecimal.FlatAppearance.BorderSize = 0;
            BtnDecimal.FlatStyle = FlatStyle.Flat;
            BtnDecimal.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            BtnDecimal.ForeColor = Color.White;
            BtnDecimal.Location = new Point(187, 510);
            BtnDecimal.Margin = new Padding(0);
            BtnDecimal.Name = "BtnDecimal";
            BtnDecimal.Size = new Size(85, 50);
            BtnDecimal.TabIndex = 36;
            BtnDecimal.Text = ".";
            BtnDecimal.TextColor = Color.White;
            BtnDecimal.UseVisualStyleBackColor = false;
            BtnDecimal.Click += BtnNum_Click;
            // 
            // BtnEquals
            // 
            BtnEquals.BackColor = SystemColors.Highlight;
            BtnEquals.BackgroundColor = SystemColors.Highlight;
            BtnEquals.BorderColor = Color.FromArgb(32, 32, 32);
            BtnEquals.BorderRadius = 10;
            BtnEquals.BorderSize = 0;
            BtnEquals.FlatAppearance.BorderSize = 0;
            BtnEquals.FlatStyle = FlatStyle.Flat;
            BtnEquals.ForeColor = Color.White;
            BtnEquals.Location = new Point(275, 510);
            BtnEquals.Margin = new Padding(0);
            BtnEquals.Name = "BtnEquals";
            BtnEquals.Size = new Size(85, 50);
            BtnEquals.TabIndex = 35;
            BtnEquals.Text = "=";
            BtnEquals.TextColor = Color.White;
            BtnEquals.UseVisualStyleBackColor = false;
            BtnEquals.Click += BtnEquals_Click;
            // 
            // TxtDisplay2
            // 
            TxtDisplay2.BackColor = Color.FromArgb(32, 32, 32);
            TxtDisplay2.BorderStyle = BorderStyle.None;
            TxtDisplay2.Dock = DockStyle.Top;
            TxtDisplay2.Font = new Font("Gadugi", 14F);
            TxtDisplay2.ForeColor = Color.DarkGray;
            TxtDisplay2.Location = new Point(0, 104);
            TxtDisplay2.Margin = new Padding(0);
            TxtDisplay2.Multiline = true;
            TxtDisplay2.Name = "TxtDisplay2";
            TxtDisplay2.Size = new Size(370, 30);
            TxtDisplay2.TabIndex = 39;
            TxtDisplay2.TextAlign = HorizontalAlignment.Right;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(370, 570);
            Controls.Add(TxtDisplay2);
            Controls.Add(BtnPM);
            Controls.Add(Btn0);
            Controls.Add(BtnDecimal);
            Controls.Add(BtnEquals);
            Controls.Add(Btn1);
            Controls.Add(Btn2);
            Controls.Add(Btn3);
            Controls.Add(BtnPlus);
            Controls.Add(Btn4);
            Controls.Add(Btn5);
            Controls.Add(Btn6);
            Controls.Add(BtnMinus);
            Controls.Add(Btn7);
            Controls.Add(Btn8);
            Controls.Add(Btn9);
            Controls.Add(BtnMultiply);
            Controls.Add(Btn1X);
            Controls.Add(BtnX2);
            Controls.Add(BtnSquare);
            Controls.Add(BtnDivide);
            Controls.Add(BtnPercent);
            Controls.Add(BtnAC);
            Controls.Add(BtnC);
            Controls.Add(customButton6);
            Controls.Add(customButton5);
            Controls.Add(customButton4);
            Controls.Add(customButton3);
            Controls.Add(customButton2);
            Controls.Add(customButton1);
            Controls.Add(TxtDisplay1);
            Controls.Add(Title);
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

        private TextBox Title;
        private TextBox TxtDisplay1;
        private CustomButton customButton1;
        private CustomButton customButton2;
        private CustomButton customButton3;
        private CustomButton customButton4;
        private CustomButton customButton5;
        private CustomButton customButton6;
        private CustomButton BtnC;
        private CustomButton BtnAC;
        private CustomButton BtnPercent;
        private CustomButton Btn1X;
        private CustomButton BtnX2;
        private CustomButton BtnSquare;
        private CustomButton BtnDivide;
        private CustomButton Btn7;
        private CustomButton Btn8;
        private CustomButton Btn9;
        private CustomButton BtnMultiply;
        private CustomButton Btn4;
        private CustomButton Btn5;
        private CustomButton Btn6;
        private CustomButton BtnMinus;
        private CustomButton Btn1;
        private CustomButton Btn2;
        private CustomButton Btn3;
        private CustomButton BtnPlus;
        private CustomButton BtnPM;
        private CustomButton Btn0;
        private CustomButton BtnDecimal;
        private CustomButton BtnEquals;
        private TextBox TxtDisplay2;
    }
}
