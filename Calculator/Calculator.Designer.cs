namespace Calculator
{
    partial class Calculator
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
            inputBox = new TextBox();
            acButton = new Button();
            percentButton = new Button();
            divideButton = new Button();
            nineButton = new Button();
            sevenButton = new Button();
            multiplyButton = new Button();
            eightButton = new Button();
            subButton = new Button();
            sixButton = new Button();
            fourButton = new Button();
            fiveButton = new Button();
            equalButton = new Button();
            oneButton = new Button();
            twoButton = new Button();
            threeButton = new Button();
            sumButton = new Button();
            zerozeroButton = new Button();
            zeroButton = new Button();
            dotButton = new Button();
            previousBox = new TextBox();
            SuspendLayout();
            // 
            // inputBox
            // 
            inputBox.BackColor = SystemColors.Info;
            inputBox.BorderStyle = BorderStyle.FixedSingle;
            inputBox.Cursor = Cursors.IBeam;
            inputBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inputBox.Location = new Point(12, 72);
            inputBox.Name = "inputBox";
            inputBox.RightToLeft = RightToLeft.No;
            inputBox.Size = new Size(342, 47);
            inputBox.TabIndex = 0;
            inputBox.TextAlign = HorizontalAlignment.Right;
            // 
            // acButton
            // 
            acButton.BackColor = SystemColors.GrayText;
            acButton.Cursor = Cursors.Hand;
            acButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            acButton.ForeColor = SystemColors.Control;
            acButton.Location = new Point(18, 153);
            acButton.Name = "acButton";
            acButton.Size = new Size(155, 66);
            acButton.TabIndex = 1;
            acButton.Text = "AC";
            acButton.UseVisualStyleBackColor = false;
            acButton.Click += acButton_Click;
            // 
            // percentButton
            // 
            percentButton.BackColor = SystemColors.GrayText;
            percentButton.Cursor = Cursors.Hand;
            percentButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            percentButton.ForeColor = SystemColors.Control;
            percentButton.Location = new Point(193, 153);
            percentButton.Name = "percentButton";
            percentButton.Size = new Size(69, 66);
            percentButton.TabIndex = 2;
            percentButton.Text = "%";
            percentButton.UseVisualStyleBackColor = false;
            percentButton.Click += percentButton_Click;
            // 
            // divideButton
            // 
            divideButton.BackColor = SystemColors.GrayText;
            divideButton.Cursor = Cursors.Hand;
            divideButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            divideButton.ForeColor = SystemColors.Control;
            divideButton.Location = new Point(281, 153);
            divideButton.Name = "divideButton";
            divideButton.Size = new Size(67, 66);
            divideButton.TabIndex = 3;
            divideButton.Text = "/";
            divideButton.UseVisualStyleBackColor = false;
            divideButton.Click += divideButton_Click;
            // 
            // nineButton
            // 
            nineButton.BackColor = SystemColors.InfoText;
            nineButton.Cursor = Cursors.Hand;
            nineButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            nineButton.ForeColor = SystemColors.Control;
            nineButton.Location = new Point(195, 239);
            nineButton.Name = "nineButton";
            nineButton.Size = new Size(67, 66);
            nineButton.TabIndex = 5;
            nineButton.Text = "9";
            nineButton.UseVisualStyleBackColor = false;
            nineButton.Click += nineButton_Click;
            // 
            // sevenButton
            // 
            sevenButton.BackColor = SystemColors.InfoText;
            sevenButton.Cursor = Cursors.Hand;
            sevenButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            sevenButton.ForeColor = SystemColors.Control;
            sevenButton.Location = new Point(18, 239);
            sevenButton.Name = "sevenButton";
            sevenButton.Size = new Size(69, 66);
            sevenButton.TabIndex = 4;
            sevenButton.Text = "7";
            sevenButton.UseVisualStyleBackColor = false;
            sevenButton.Click += sevenButton_Click;
            // 
            // multiplyButton
            // 
            multiplyButton.BackColor = SystemColors.GrayText;
            multiplyButton.Cursor = Cursors.Hand;
            multiplyButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            multiplyButton.ForeColor = SystemColors.Control;
            multiplyButton.Location = new Point(281, 239);
            multiplyButton.Name = "multiplyButton";
            multiplyButton.Size = new Size(67, 66);
            multiplyButton.TabIndex = 7;
            multiplyButton.Text = "*";
            multiplyButton.UseVisualStyleBackColor = false;
            multiplyButton.Click += multiplyButton_Click;
            // 
            // eightButton
            // 
            eightButton.BackColor = SystemColors.InfoText;
            eightButton.Cursor = Cursors.Hand;
            eightButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            eightButton.ForeColor = SystemColors.Control;
            eightButton.Location = new Point(106, 239);
            eightButton.Name = "eightButton";
            eightButton.Size = new Size(69, 66);
            eightButton.TabIndex = 6;
            eightButton.Text = "8";
            eightButton.UseVisualStyleBackColor = false;
            eightButton.Click += eightButton_Click;
            // 
            // subButton
            // 
            subButton.BackColor = SystemColors.GrayText;
            subButton.Cursor = Cursors.Hand;
            subButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            subButton.ForeColor = SystemColors.Control;
            subButton.Location = new Point(281, 327);
            subButton.Name = "subButton";
            subButton.Size = new Size(67, 66);
            subButton.TabIndex = 11;
            subButton.Text = "-";
            subButton.UseVisualStyleBackColor = false;
            subButton.Click += subButton_Click;
            // 
            // sixButton
            // 
            sixButton.BackColor = SystemColors.InfoText;
            sixButton.Cursor = Cursors.Hand;
            sixButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            sixButton.ForeColor = SystemColors.Control;
            sixButton.Location = new Point(193, 327);
            sixButton.Name = "sixButton";
            sixButton.Size = new Size(69, 66);
            sixButton.TabIndex = 10;
            sixButton.Text = "6";
            sixButton.UseVisualStyleBackColor = false;
            sixButton.Click += sixButton_Click;
            // 
            // fourButton
            // 
            fourButton.BackColor = SystemColors.InfoText;
            fourButton.Cursor = Cursors.Hand;
            fourButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            fourButton.ForeColor = SystemColors.Control;
            fourButton.Location = new Point(20, 327);
            fourButton.Name = "fourButton";
            fourButton.Size = new Size(67, 66);
            fourButton.TabIndex = 9;
            fourButton.Text = "4";
            fourButton.UseVisualStyleBackColor = false;
            fourButton.Click += fourButton_Click;
            // 
            // fiveButton
            // 
            fiveButton.BackColor = SystemColors.InfoText;
            fiveButton.Cursor = Cursors.Hand;
            fiveButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            fiveButton.ForeColor = SystemColors.Control;
            fiveButton.Location = new Point(106, 327);
            fiveButton.Name = "fiveButton";
            fiveButton.Size = new Size(69, 66);
            fiveButton.TabIndex = 8;
            fiveButton.Text = "5";
            fiveButton.UseVisualStyleBackColor = false;
            fiveButton.Click += fiveButton_Click;
            // 
            // equalButton
            // 
            equalButton.BackColor = SystemColors.GrayText;
            equalButton.Cursor = Cursors.Hand;
            equalButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            equalButton.ForeColor = SystemColors.Control;
            equalButton.Location = new Point(281, 502);
            equalButton.Name = "equalButton";
            equalButton.Size = new Size(67, 66);
            equalButton.TabIndex = 19;
            equalButton.Text = "=";
            equalButton.UseVisualStyleBackColor = false;
            equalButton.Click += equalButton_Click;
            // 
            // oneButton
            // 
            oneButton.BackColor = SystemColors.InfoText;
            oneButton.Cursor = Cursors.Hand;
            oneButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            oneButton.ForeColor = SystemColors.Control;
            oneButton.Location = new Point(20, 414);
            oneButton.Name = "oneButton";
            oneButton.Size = new Size(69, 66);
            oneButton.TabIndex = 18;
            oneButton.Text = "1";
            oneButton.UseVisualStyleBackColor = false;
            oneButton.Click += oneButton_Click;
            // 
            // twoButton
            // 
            twoButton.BackColor = SystemColors.InfoText;
            twoButton.Cursor = Cursors.Hand;
            twoButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            twoButton.ForeColor = SystemColors.Control;
            twoButton.Location = new Point(108, 414);
            twoButton.Name = "twoButton";
            twoButton.Size = new Size(67, 66);
            twoButton.TabIndex = 17;
            twoButton.Text = "2";
            twoButton.UseVisualStyleBackColor = false;
            twoButton.Click += twoButton_Click;
            // 
            // threeButton
            // 
            threeButton.BackColor = SystemColors.InfoText;
            threeButton.Cursor = Cursors.Hand;
            threeButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            threeButton.ForeColor = SystemColors.Control;
            threeButton.Location = new Point(195, 414);
            threeButton.Name = "threeButton";
            threeButton.Size = new Size(69, 66);
            threeButton.TabIndex = 16;
            threeButton.Text = "3";
            threeButton.UseVisualStyleBackColor = false;
            threeButton.Click += threeButton_Click;
            // 
            // sumButton
            // 
            sumButton.BackColor = SystemColors.GrayText;
            sumButton.Cursor = Cursors.Hand;
            sumButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            sumButton.ForeColor = SystemColors.Control;
            sumButton.Location = new Point(281, 414);
            sumButton.Name = "sumButton";
            sumButton.Size = new Size(67, 66);
            sumButton.TabIndex = 15;
            sumButton.Text = "+";
            sumButton.UseVisualStyleBackColor = false;
            sumButton.Click += sumButton_Click;
            // 
            // zerozeroButton
            // 
            zerozeroButton.BackColor = SystemColors.InfoText;
            zerozeroButton.Cursor = Cursors.Hand;
            zerozeroButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            zerozeroButton.ForeColor = SystemColors.Control;
            zerozeroButton.Location = new Point(106, 502);
            zerozeroButton.Name = "zerozeroButton";
            zerozeroButton.Size = new Size(69, 66);
            zerozeroButton.TabIndex = 14;
            zerozeroButton.Text = "00";
            zerozeroButton.UseVisualStyleBackColor = false;
            zerozeroButton.Click += zerozeroButton_Click;
            // 
            // zeroButton
            // 
            zeroButton.BackColor = SystemColors.InfoText;
            zeroButton.Cursor = Cursors.Hand;
            zeroButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            zeroButton.ForeColor = SystemColors.Control;
            zeroButton.Location = new Point(20, 502);
            zeroButton.Name = "zeroButton";
            zeroButton.Size = new Size(67, 66);
            zeroButton.TabIndex = 13;
            zeroButton.Text = "0";
            zeroButton.UseVisualStyleBackColor = false;
            zeroButton.Click += zeroButton_Click;
            // 
            // dotButton
            // 
            dotButton.BackColor = SystemColors.InfoText;
            dotButton.Cursor = Cursors.Hand;
            dotButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            dotButton.ForeColor = SystemColors.Control;
            dotButton.Location = new Point(193, 502);
            dotButton.Name = "dotButton";
            dotButton.Size = new Size(69, 66);
            dotButton.TabIndex = 12;
            dotButton.Text = ".";
            dotButton.UseVisualStyleBackColor = false;
            dotButton.Click += dotButton_Click;
            // 
            // previousBox
            // 
            previousBox.BackColor = SystemColors.Info;
            previousBox.BorderStyle = BorderStyle.FixedSingle;
            previousBox.Cursor = Cursors.Hand;
            previousBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            previousBox.ImeMode = ImeMode.Off;
            previousBox.Location = new Point(12, 19);
            previousBox.Name = "previousBox";
            previousBox.ReadOnly = true;
            previousBox.RightToLeft = RightToLeft.Yes;
            previousBox.Size = new Size(342, 30);
            previousBox.TabIndex = 20;
            previousBox.Click += previousBox_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 606);
            Controls.Add(previousBox);
            Controls.Add(equalButton);
            Controls.Add(oneButton);
            Controls.Add(twoButton);
            Controls.Add(threeButton);
            Controls.Add(sumButton);
            Controls.Add(zerozeroButton);
            Controls.Add(zeroButton);
            Controls.Add(dotButton);
            Controls.Add(subButton);
            Controls.Add(sixButton);
            Controls.Add(fourButton);
            Controls.Add(fiveButton);
            Controls.Add(multiplyButton);
            Controls.Add(eightButton);
            Controls.Add(nineButton);
            Controls.Add(sevenButton);
            Controls.Add(divideButton);
            Controls.Add(percentButton);
            Controls.Add(acButton);
            Controls.Add(inputBox);
            Name = "Calculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputBox;
        private Button acButton;
        private Button percentButton;
        private Button divideButton;
        private Button nineButton;
        private Button sevenButton;
        private Button multiplyButton;
        private Button eightButton;
        private Button subButton;
        private Button sixButton;
        private Button fourButton;
        private Button fiveButton;
        private Button equalButton;
        private Button oneButton;
        private Button twoButton;
        private Button threeButton;
        private Button sumButton;
        private Button zerozeroButton;
        private Button zeroButton;
        private Button dotButton;
        private TextBox previousBox;
    }
}