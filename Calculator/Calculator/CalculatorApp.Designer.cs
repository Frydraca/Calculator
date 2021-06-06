
namespace Calculator
{
    partial class CalculatorApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonEquals = new System.Windows.Forms.Button();
            this.buttonDot = new System.Windows.Forms.Button();
            this.buttonRightParenthesis = new System.Windows.Forms.Button();
            this.buttonLeftParenthesis = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ScreenText = new System.Windows.Forms.Label();
            this.ScreenBackground = new System.Windows.Forms.Panel();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.ScreenBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.buttonMinus);
            this.panel1.Controls.Add(this.buttonPlus);
            this.panel1.Controls.Add(this.buttonDivide);
            this.panel1.Controls.Add(this.buttonMultiply);
            this.panel1.Controls.Add(this.buttonClear);
            this.panel1.Controls.Add(this.buttonBack);
            this.panel1.Controls.Add(this.buttonEquals);
            this.panel1.Controls.Add(this.buttonDot);
            this.panel1.Controls.Add(this.buttonRightParenthesis);
            this.panel1.Controls.Add(this.buttonLeftParenthesis);
            this.panel1.Controls.Add(this.button0);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.ScreenBackground);
            this.panel1.Location = new System.Drawing.Point(32, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 212);
            this.panel1.TabIndex = 0;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(205, 71);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(40, 25);
            this.buttonClear.TabIndex = 16;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(159, 71);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(40, 25);
            this.buttonBack.TabIndex = 15;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonEquals
            // 
            this.buttonEquals.Location = new System.Drawing.Point(205, 164);
            this.buttonEquals.Name = "buttonEquals";
            this.buttonEquals.Size = new System.Drawing.Size(40, 25);
            this.buttonEquals.TabIndex = 14;
            this.buttonEquals.Text = "=";
            this.buttonEquals.UseVisualStyleBackColor = true;
            this.buttonEquals.Click += new System.EventHandler(this.buttonEquals_Click);
            // 
            // buttonDot
            // 
            this.buttonDot.Location = new System.Drawing.Point(159, 164);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(40, 25);
            this.buttonDot.TabIndex = 13;
            this.buttonDot.Text = ".";
            this.buttonDot.UseVisualStyleBackColor = true;
            this.buttonDot.Click += new System.EventHandler(this.buttonDot_Click);
            // 
            // buttonRightParenthesis
            // 
            this.buttonRightParenthesis.Location = new System.Drawing.Point(113, 164);
            this.buttonRightParenthesis.Name = "buttonRightParenthesis";
            this.buttonRightParenthesis.Size = new System.Drawing.Size(40, 25);
            this.buttonRightParenthesis.TabIndex = 12;
            this.buttonRightParenthesis.Text = ")";
            this.buttonRightParenthesis.UseVisualStyleBackColor = true;
            this.buttonRightParenthesis.Click += new System.EventHandler(this.buttonRightParenthesis_Click);
            // 
            // buttonLeftParenthesis
            // 
            this.buttonLeftParenthesis.Location = new System.Drawing.Point(67, 164);
            this.buttonLeftParenthesis.Name = "buttonLeftParenthesis";
            this.buttonLeftParenthesis.Size = new System.Drawing.Size(40, 25);
            this.buttonLeftParenthesis.TabIndex = 11;
            this.buttonLeftParenthesis.Text = "(";
            this.buttonLeftParenthesis.UseVisualStyleBackColor = true;
            this.buttonLeftParenthesis.Click += new System.EventHandler(this.buttonLeftParenthesis_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(21, 164);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(40, 25);
            this.button0.TabIndex = 10;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(113, 133);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(40, 25);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(67, 133);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(40, 25);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(21, 133);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(40, 25);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(113, 102);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(40, 25);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(67, 102);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(40, 25);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(21, 102);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(40, 25);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(113, 71);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 25);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(67, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 25);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ScreenText
            // 
            this.ScreenText.AutoSize = true;
            this.ScreenText.Location = new System.Drawing.Point(16, 10);
            this.ScreenText.Name = "ScreenText";
            this.ScreenText.Size = new System.Drawing.Size(0, 13);
            this.ScreenText.TabIndex = 0;
            // 
            // ScreenBackground
            // 
            this.ScreenBackground.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ScreenBackground.Controls.Add(this.ScreenText);
            this.ScreenBackground.Location = new System.Drawing.Point(21, 21);
            this.ScreenBackground.Name = "ScreenBackground";
            this.ScreenBackground.Size = new System.Drawing.Size(224, 33);
            this.ScreenBackground.TabIndex = 17;
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Location = new System.Drawing.Point(159, 102);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(40, 25);
            this.buttonMultiply.TabIndex = 18;
            this.buttonMultiply.Text = "*";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.buttonMultiply_Click);
            // 
            // buttonDivide
            // 
            this.buttonDivide.Location = new System.Drawing.Point(205, 102);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(40, 25);
            this.buttonDivide.TabIndex = 19;
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseVisualStyleBackColor = true;
            this.buttonDivide.Click += new System.EventHandler(this.buttonDivide_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Location = new System.Drawing.Point(159, 133);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(40, 25);
            this.buttonPlus.TabIndex = 20;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Location = new System.Drawing.Point(205, 133);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(40, 25);
            this.buttonMinus.TabIndex = 21;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 315);
            this.Controls.Add(this.panel1);
            this.Name = "Calculator";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.panel1.ResumeLayout(false);
            this.ScreenBackground.ResumeLayout(false);
            this.ScreenBackground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ScreenText;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonEquals;
        private System.Windows.Forms.Button buttonDot;
        private System.Windows.Forms.Button buttonRightParenthesis;
        private System.Windows.Forms.Button buttonLeftParenthesis;
        private System.Windows.Forms.Panel ScreenBackground;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button buttonMultiply;
    }
}

