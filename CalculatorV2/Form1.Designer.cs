namespace CalculatorV2
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.resultText = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.ceButton = new System.Windows.Forms.Button();
            this.cButton = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.equation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(12, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 75);
            this.button1.TabIndex = 0;
            this.button1.Text = "7";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.addNumber);
            // 
            // resultText
            // 
            this.resultText.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resultText.Location = new System.Drawing.Point(12, 12);
            this.resultText.Multiline = true;
            this.resultText.Name = "resultText";
            this.resultText.Size = new System.Drawing.Size(399, 72);
            this.resultText.TabIndex = 1;
            this.resultText.Text = "0";
            this.resultText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(93, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 75);
            this.button2.TabIndex = 2;
            this.button2.Text = "8";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.addNumber);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(174, 90);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 75);
            this.button3.TabIndex = 3;
            this.button3.Text = "9";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.addNumber);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.Location = new System.Drawing.Point(12, 171);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 75);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.addNumber);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.Location = new System.Drawing.Point(93, 171);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 75);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.addNumber);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button6.Location = new System.Drawing.Point(174, 171);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 75);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.addNumber);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button7.Location = new System.Drawing.Point(12, 252);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 75);
            this.button7.TabIndex = 7;
            this.button7.Text = "1";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.addNumber);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button8.Location = new System.Drawing.Point(93, 252);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 75);
            this.button8.TabIndex = 8;
            this.button8.Text = "2";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.addNumber);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button9.Location = new System.Drawing.Point(174, 252);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 75);
            this.button9.TabIndex = 9;
            this.button9.Text = "3";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.addNumber);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button10.Location = new System.Drawing.Point(12, 333);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(156, 75);
            this.button10.TabIndex = 10;
            this.button10.Text = "0";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.addNumber);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button11.Location = new System.Drawing.Point(174, 333);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 75);
            this.button11.TabIndex = 11;
            this.button11.Text = ",";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.addNumber);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button12.Location = new System.Drawing.Point(255, 90);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 75);
            this.button12.TabIndex = 12;
            this.button12.Text = "+";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.operation_Click);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button13.Location = new System.Drawing.Point(255, 171);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 75);
            this.button13.TabIndex = 13;
            this.button13.Text = "-";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.operation_Click);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button14.Location = new System.Drawing.Point(255, 252);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 75);
            this.button14.TabIndex = 14;
            this.button14.Text = "*";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.operation_Click);
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button15.Location = new System.Drawing.Point(255, 333);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 75);
            this.button15.TabIndex = 15;
            this.button15.Text = "/";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.operation_Click);
            // 
            // ceButton
            // 
            this.ceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ceButton.Location = new System.Drawing.Point(336, 90);
            this.ceButton.Name = "ceButton";
            this.ceButton.Size = new System.Drawing.Size(75, 75);
            this.ceButton.TabIndex = 16;
            this.ceButton.Text = "CE";
            this.ceButton.UseVisualStyleBackColor = true;
            this.ceButton.Click += new System.EventHandler(this.ceButton_Click);
            // 
            // cButton
            // 
            this.cButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cButton.Location = new System.Drawing.Point(336, 171);
            this.cButton.Name = "cButton";
            this.cButton.Size = new System.Drawing.Size(75, 75);
            this.cButton.TabIndex = 17;
            this.cButton.Text = "C";
            this.cButton.UseVisualStyleBackColor = true;
            this.cButton.Click += new System.EventHandler(this.cButton_Click);
            // 
            // equal
            // 
            this.equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.equal.Location = new System.Drawing.Point(336, 252);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(75, 156);
            this.equal.TabIndex = 18;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.button18_Click);
            // 
            // equation
            // 
            this.equation.AutoSize = true;
            this.equation.BackColor = System.Drawing.SystemColors.Window;
            this.equation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.equation.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.equation.Location = new System.Drawing.Point(22, 30);
            this.equation.Name = "equation";
            this.equation.Size = new System.Drawing.Size(0, 25);
            this.equation.TabIndex = 19;
            this.equation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 420);
            this.Controls.Add(this.equation);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.cButton);
            this.Controls.Add(this.ceButton);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.resultText);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox resultText;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button ceButton;
        private System.Windows.Forms.Button cButton;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Label equation;
    }
}

