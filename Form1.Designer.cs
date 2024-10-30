namespace CalculatorApp
{
    partial class CalculatorApp
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
            if (disposing && (components != null)) {
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
            textBox = new TextBox();
            bNegate = new Button();
            bEquals = new Button();
            b0 = new Button();
            bPeriod = new Button();
            b1 = new Button();
            b2 = new Button();
            b3 = new Button();
            bAdd = new Button();
            b4 = new Button();
            b5 = new Button();
            b6 = new Button();
            bSubtract = new Button();
            b7 = new Button();
            b8 = new Button();
            b9 = new Button();
            bMultiply = new Button();
            bBackspace = new Button();
            bClearEverything = new Button();
            bClear = new Button();
            bDivide = new Button();
            operationText = new TextBox();
            SuspendLayout();
            // 
            // textBox
            // 
            textBox.BackColor = Color.FromArgb(30, 30, 30);
            textBox.BorderStyle = BorderStyle.None;
            textBox.Font = new Font("Segoe UI", 30F);
            textBox.ForeColor = SystemColors.Control;
            textBox.Location = new Point(13, 12);
            textBox.Margin = new Padding(4, 3, 4, 3);
            textBox.Name = "textBox";
            textBox.ReadOnly = true;
            textBox.RightToLeft = RightToLeft.No;
            textBox.Size = new Size(288, 54);
            textBox.TabIndex = 1;
            textBox.TextAlign = HorizontalAlignment.Right;
            // 
            // bNegate
            // 
            bNegate.BackColor = Color.FromArgb(60, 60, 60);
            bNegate.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 60);
            bNegate.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 30, 30);
            bNegate.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            bNegate.FlatStyle = FlatStyle.Flat;
            bNegate.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            bNegate.ForeColor = SystemColors.Control;
            bNegate.Location = new Point(13, 372);
            bNegate.Margin = new Padding(4, 3, 4, 3);
            bNegate.Name = "bNegate";
            bNegate.Size = new Size(66, 66);
            bNegate.TabIndex = 8;
            bNegate.Text = "+/-";
            bNegate.UseVisualStyleBackColor = false;
            bNegate.Click += bNegate_Click;
            // 
            // bEquals
            // 
            bEquals.BackColor = Color.FromArgb(60, 60, 60);
            bEquals.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 60);
            bEquals.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 30, 30);
            bEquals.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            bEquals.FlatStyle = FlatStyle.Flat;
            bEquals.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            bEquals.ForeColor = SystemColors.Control;
            bEquals.Location = new Point(235, 372);
            bEquals.Margin = new Padding(4, 3, 4, 3);
            bEquals.Name = "bEquals";
            bEquals.Size = new Size(66, 66);
            bEquals.TabIndex = 9;
            bEquals.Text = "=";
            bEquals.UseVisualStyleBackColor = false;
            bEquals.Click += bEquals_Click;
            // 
            // b0
            // 
            b0.BackColor = Color.FromArgb(60, 60, 60);
            b0.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 60);
            b0.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 30, 30);
            b0.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            b0.FlatStyle = FlatStyle.Flat;
            b0.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            b0.ForeColor = SystemColors.Control;
            b0.Location = new Point(87, 372);
            b0.Margin = new Padding(4, 3, 4, 3);
            b0.Name = "b0";
            b0.Size = new Size(66, 66);
            b0.TabIndex = 10;
            b0.Text = "0";
            b0.UseVisualStyleBackColor = false;
            b0.Click += b0_Click;
            // 
            // bPeriod
            // 
            bPeriod.BackColor = Color.FromArgb(60, 60, 60);
            bPeriod.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 60);
            bPeriod.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 30, 30);
            bPeriod.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            bPeriod.FlatStyle = FlatStyle.Flat;
            bPeriod.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            bPeriod.ForeColor = SystemColors.Control;
            bPeriod.Location = new Point(161, 372);
            bPeriod.Margin = new Padding(4, 3, 4, 3);
            bPeriod.Name = "bPeriod";
            bPeriod.Size = new Size(66, 66);
            bPeriod.TabIndex = 11;
            bPeriod.Text = ".";
            bPeriod.UseVisualStyleBackColor = false;
            bPeriod.Click += bPeriod_Click;
            // 
            // b1
            // 
            b1.BackColor = Color.FromArgb(60, 60, 60);
            b1.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 60);
            b1.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 30, 30);
            b1.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            b1.FlatStyle = FlatStyle.Flat;
            b1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            b1.ForeColor = SystemColors.Control;
            b1.Location = new Point(13, 300);
            b1.Margin = new Padding(4, 3, 4, 3);
            b1.Name = "b1";
            b1.Size = new Size(66, 66);
            b1.TabIndex = 12;
            b1.Text = "1";
            b1.UseVisualStyleBackColor = false;
            b1.Click += b1_Click;
            // 
            // b2
            // 
            b2.BackColor = Color.FromArgb(60, 60, 60);
            b2.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 60);
            b2.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 30, 30);
            b2.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            b2.FlatStyle = FlatStyle.Flat;
            b2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            b2.ForeColor = SystemColors.Control;
            b2.Location = new Point(87, 300);
            b2.Margin = new Padding(4, 3, 4, 3);
            b2.Name = "b2";
            b2.Size = new Size(66, 66);
            b2.TabIndex = 13;
            b2.Text = "2";
            b2.UseVisualStyleBackColor = false;
            b2.Click += b2_Click;
            // 
            // b3
            // 
            b3.BackColor = Color.FromArgb(60, 60, 60);
            b3.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 60);
            b3.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 30, 30);
            b3.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            b3.FlatStyle = FlatStyle.Flat;
            b3.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            b3.ForeColor = SystemColors.Control;
            b3.Location = new Point(161, 300);
            b3.Margin = new Padding(4, 3, 4, 3);
            b3.Name = "b3";
            b3.Size = new Size(66, 66);
            b3.TabIndex = 14;
            b3.Text = "3";
            b3.UseVisualStyleBackColor = false;
            b3.Click += b3_Click;
            // 
            // bAdd
            // 
            bAdd.BackColor = Color.FromArgb(60, 60, 60);
            bAdd.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 60);
            bAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 30, 30);
            bAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            bAdd.FlatStyle = FlatStyle.Flat;
            bAdd.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            bAdd.ForeColor = SystemColors.Control;
            bAdd.Location = new Point(235, 300);
            bAdd.Margin = new Padding(4, 3, 4, 3);
            bAdd.Name = "bAdd";
            bAdd.Size = new Size(66, 66);
            bAdd.TabIndex = 15;
            bAdd.Text = "+";
            bAdd.UseVisualStyleBackColor = false;
            bAdd.Click += bAdd_Click;
            // 
            // b4
            // 
            b4.BackColor = Color.FromArgb(60, 60, 60);
            b4.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 60);
            b4.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 30, 30);
            b4.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            b4.FlatStyle = FlatStyle.Flat;
            b4.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            b4.ForeColor = SystemColors.Control;
            b4.Location = new Point(13, 228);
            b4.Margin = new Padding(4, 3, 4, 3);
            b4.Name = "b4";
            b4.Size = new Size(66, 66);
            b4.TabIndex = 16;
            b4.Text = "4";
            b4.UseVisualStyleBackColor = false;
            b4.Click += b4_Click;
            // 
            // b5
            // 
            b5.BackColor = Color.FromArgb(60, 60, 60);
            b5.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 60);
            b5.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 30, 30);
            b5.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            b5.FlatStyle = FlatStyle.Flat;
            b5.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            b5.ForeColor = SystemColors.Control;
            b5.Location = new Point(87, 228);
            b5.Margin = new Padding(4, 3, 4, 3);
            b5.Name = "b5";
            b5.Size = new Size(66, 66);
            b5.TabIndex = 17;
            b5.Text = "5";
            b5.UseVisualStyleBackColor = false;
            b5.Click += b5_Click;
            // 
            // b6
            // 
            b6.BackColor = Color.FromArgb(60, 60, 60);
            b6.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 60);
            b6.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 30, 30);
            b6.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            b6.FlatStyle = FlatStyle.Flat;
            b6.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            b6.ForeColor = SystemColors.Control;
            b6.Location = new Point(161, 228);
            b6.Margin = new Padding(4, 3, 4, 3);
            b6.Name = "b6";
            b6.Size = new Size(66, 66);
            b6.TabIndex = 18;
            b6.Text = "6";
            b6.UseVisualStyleBackColor = false;
            b6.Click += b6_Click;
            // 
            // bSubtract
            // 
            bSubtract.BackColor = Color.FromArgb(60, 60, 60);
            bSubtract.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 60);
            bSubtract.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 30, 30);
            bSubtract.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            bSubtract.FlatStyle = FlatStyle.Flat;
            bSubtract.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            bSubtract.ForeColor = SystemColors.Control;
            bSubtract.Location = new Point(235, 228);
            bSubtract.Margin = new Padding(4, 3, 4, 3);
            bSubtract.Name = "bSubtract";
            bSubtract.Size = new Size(66, 66);
            bSubtract.TabIndex = 19;
            bSubtract.Text = "-";
            bSubtract.UseVisualStyleBackColor = false;
            bSubtract.Click += bSubtract_Click;
            // 
            // b7
            // 
            b7.BackColor = Color.FromArgb(60, 60, 60);
            b7.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 60);
            b7.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 30, 30);
            b7.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            b7.FlatStyle = FlatStyle.Flat;
            b7.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            b7.ForeColor = SystemColors.Control;
            b7.Location = new Point(13, 156);
            b7.Margin = new Padding(4, 3, 4, 3);
            b7.Name = "b7";
            b7.Size = new Size(66, 66);
            b7.TabIndex = 20;
            b7.Text = "7";
            b7.UseVisualStyleBackColor = false;
            b7.Click += b7_Click;
            // 
            // b8
            // 
            b8.BackColor = Color.FromArgb(60, 60, 60);
            b8.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 60);
            b8.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 30, 30);
            b8.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            b8.FlatStyle = FlatStyle.Flat;
            b8.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            b8.ForeColor = SystemColors.Control;
            b8.Location = new Point(87, 156);
            b8.Margin = new Padding(4, 3, 4, 3);
            b8.Name = "b8";
            b8.Size = new Size(66, 66);
            b8.TabIndex = 21;
            b8.Text = "8";
            b8.UseVisualStyleBackColor = false;
            b8.Click += b8_Click;
            // 
            // b9
            // 
            b9.BackColor = Color.FromArgb(60, 60, 60);
            b9.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 60);
            b9.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 30, 30);
            b9.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            b9.FlatStyle = FlatStyle.Flat;
            b9.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            b9.ForeColor = SystemColors.Control;
            b9.Location = new Point(161, 156);
            b9.Margin = new Padding(4, 3, 4, 3);
            b9.Name = "b9";
            b9.Size = new Size(66, 66);
            b9.TabIndex = 22;
            b9.Text = "9";
            b9.UseVisualStyleBackColor = false;
            b9.Click += b9_Click;
            // 
            // bMultiply
            // 
            bMultiply.BackColor = Color.FromArgb(60, 60, 60);
            bMultiply.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 60);
            bMultiply.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 30, 30);
            bMultiply.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            bMultiply.FlatStyle = FlatStyle.Flat;
            bMultiply.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            bMultiply.ForeColor = SystemColors.Control;
            bMultiply.Location = new Point(235, 156);
            bMultiply.Margin = new Padding(4, 3, 4, 3);
            bMultiply.Name = "bMultiply";
            bMultiply.Size = new Size(66, 66);
            bMultiply.TabIndex = 23;
            bMultiply.Text = "*";
            bMultiply.UseVisualStyleBackColor = false;
            bMultiply.Click += bMultiply_Click;
            // 
            // bBackspace
            // 
            bBackspace.BackColor = Color.FromArgb(60, 60, 60);
            bBackspace.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 60);
            bBackspace.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 30, 30);
            bBackspace.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            bBackspace.FlatStyle = FlatStyle.Flat;
            bBackspace.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            bBackspace.ForeColor = SystemColors.Control;
            bBackspace.Location = new Point(13, 84);
            bBackspace.Margin = new Padding(4, 3, 4, 3);
            bBackspace.Name = "bBackspace";
            bBackspace.Size = new Size(66, 66);
            bBackspace.TabIndex = 24;
            bBackspace.Text = "<-";
            bBackspace.UseVisualStyleBackColor = false;
            bBackspace.Click += bBackspace_Click;
            // 
            // bClearEverything
            // 
            bClearEverything.BackColor = Color.FromArgb(60, 60, 60);
            bClearEverything.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 60);
            bClearEverything.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 30, 30);
            bClearEverything.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            bClearEverything.FlatStyle = FlatStyle.Flat;
            bClearEverything.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            bClearEverything.ForeColor = SystemColors.Control;
            bClearEverything.Location = new Point(87, 84);
            bClearEverything.Margin = new Padding(4, 3, 4, 3);
            bClearEverything.Name = "bClearEverything";
            bClearEverything.Size = new Size(66, 66);
            bClearEverything.TabIndex = 25;
            bClearEverything.Text = "CE";
            bClearEverything.UseVisualStyleBackColor = false;
            bClearEverything.Click += bClearEverything_Click;
            // 
            // bClear
            // 
            bClear.BackColor = Color.FromArgb(60, 60, 60);
            bClear.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 60);
            bClear.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 30, 30);
            bClear.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            bClear.FlatStyle = FlatStyle.Flat;
            bClear.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            bClear.ForeColor = SystemColors.Control;
            bClear.Location = new Point(161, 84);
            bClear.Margin = new Padding(4, 3, 4, 3);
            bClear.Name = "bClear";
            bClear.Size = new Size(66, 66);
            bClear.TabIndex = 26;
            bClear.Text = "C";
            bClear.UseVisualStyleBackColor = false;
            bClear.Click += bClear_Click;
            // 
            // bDivide
            // 
            bDivide.BackColor = Color.FromArgb(60, 60, 60);
            bDivide.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 60);
            bDivide.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 30, 30);
            bDivide.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            bDivide.FlatStyle = FlatStyle.Flat;
            bDivide.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            bDivide.ForeColor = SystemColors.Control;
            bDivide.Location = new Point(235, 84);
            bDivide.Margin = new Padding(4, 3, 4, 3);
            bDivide.Name = "bDivide";
            bDivide.Size = new Size(66, 66);
            bDivide.TabIndex = 27;
            bDivide.Text = "/";
            bDivide.UseVisualStyleBackColor = false;
            bDivide.Click += bDivide_Click;
            // 
            // operationText
            // 
            operationText.BackColor = Color.FromArgb(30, 30, 30);
            operationText.BorderStyle = BorderStyle.None;
            operationText.Font = new Font("Segoe UI", 10F);
            operationText.ForeColor = SystemColors.Control;
            operationText.Location = new Point(13, 8);
            operationText.Margin = new Padding(4, 3, 4, 3);
            operationText.Name = "operationText";
            operationText.ReadOnly = true;
            operationText.RightToLeft = RightToLeft.No;
            operationText.Size = new Size(288, 18);
            operationText.TabIndex = 28;
            operationText.TextAlign = HorizontalAlignment.Right;
            // 
            // CalculatorApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(314, 450);
            Controls.Add(operationText);
            Controls.Add(bDivide);
            Controls.Add(bClear);
            Controls.Add(bClearEverything);
            Controls.Add(bBackspace);
            Controls.Add(bMultiply);
            Controls.Add(b9);
            Controls.Add(b8);
            Controls.Add(b7);
            Controls.Add(bSubtract);
            Controls.Add(b6);
            Controls.Add(b5);
            Controls.Add(b4);
            Controls.Add(bAdd);
            Controls.Add(b3);
            Controls.Add(b2);
            Controls.Add(b1);
            Controls.Add(bPeriod);
            Controls.Add(b0);
            Controls.Add(bEquals);
            Controls.Add(bNegate);
            Controls.Add(textBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            Name = "CalculatorApp";
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox;
        private Button bNegate;
        private Button bEquals;
        private Button b0;
        private Button bPeriod;
        private Button b1;
        private Button b2;
        private Button b3;
        private Button bAdd;
        private Button b4;
        private Button b5;
        private Button b6;
        private Button bSubtract;
        private Button b7;
        private Button b8;
        private Button b9;
        private Button bMultiply;
        private Button bBackspace;
        private Button bClearEverything;
        private Button bClear;
        private Button bDivide;
        private TextBox operationText;
    }
}
