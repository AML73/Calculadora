namespace WF2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button0 = new Button();
            btnAdd = new Button();
            btnResult = new Button();
            Display = new TextBox();
            btnSubs = new Button();
            btnMult = new Button();
            btnClear = new Button();
            dump = new TextBox();
            btnDiv = new Button();
            btnClearE = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(10, 267);
            button1.Name = "button1";
            button1.Size = new Size(59, 59);
            button1.TabIndex = 2;
            button1.Text = "&1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += NumberInput;
            // 
            // button2
            // 
            button2.Location = new Point(75, 267);
            button2.Name = "button2";
            button2.Size = new Size(59, 59);
            button2.TabIndex = 3;
            button2.Text = "&2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += NumberInput;
            // 
            // button3
            // 
            button3.Location = new Point(140, 267);
            button3.Name = "button3";
            button3.Size = new Size(59, 59);
            button3.TabIndex = 4;
            button3.Text = "&3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += NumberInput;
            // 
            // button6
            // 
            button6.Location = new Point(140, 202);
            button6.Name = "button6";
            button6.Size = new Size(59, 59);
            button6.TabIndex = 7;
            button6.Text = "&6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += NumberInput;
            // 
            // button5
            // 
            button5.Location = new Point(75, 202);
            button5.Name = "button5";
            button5.Size = new Size(59, 59);
            button5.TabIndex = 6;
            button5.Text = "&5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += NumberInput;
            // 
            // button4
            // 
            button4.Location = new Point(10, 202);
            button4.Name = "button4";
            button4.Size = new Size(59, 59);
            button4.TabIndex = 5;
            button4.Text = "&4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += NumberInput;
            // 
            // button9
            // 
            button9.Location = new Point(140, 137);
            button9.Name = "button9";
            button9.Size = new Size(59, 59);
            button9.TabIndex = 10;
            button9.Text = "&9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += NumberInput;
            // 
            // button8
            // 
            button8.Location = new Point(75, 137);
            button8.Name = "button8";
            button8.Size = new Size(59, 59);
            button8.TabIndex = 9;
            button8.Text = "&8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += NumberInput;
            // 
            // button7
            // 
            button7.Location = new Point(10, 137);
            button7.Name = "button7";
            button7.Size = new Size(59, 59);
            button7.TabIndex = 8;
            button7.Text = "&7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += NumberInput;
            // 
            // button0
            // 
            button0.Location = new Point(10, 330);
            button0.Name = "button0";
            button0.Size = new Size(189, 59);
            button0.TabIndex = 1;
            button0.Text = "&0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += NumberInput;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(205, 267);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(59, 122);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "&+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnResult
            // 
            btnResult.BackColor = Color.FromArgb(0, 192, 192);
            btnResult.Location = new Point(270, 202);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(59, 187);
            btnResult.TabIndex = 0;
            btnResult.Text = "&=";
            btnResult.UseVisualStyleBackColor = false;
            btnResult.Click += Result_Click;
            // 
            // Display
            // 
            Display.Dock = DockStyle.Top;
            Display.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Display.Location = new Point(0, 0);
            Display.Name = "Display";
            Display.ReadOnly = true;
            Display.Size = new Size(341, 39);
            Display.TabIndex = 14;
            Display.TextAlign = HorizontalAlignment.Right;
            // 
            // btnSubs
            // 
            btnSubs.Location = new Point(205, 202);
            btnSubs.Name = "btnSubs";
            btnSubs.Size = new Size(59, 59);
            btnSubs.TabIndex = 12;
            btnSubs.Text = "&-";
            btnSubs.UseVisualStyleBackColor = true;
            btnSubs.Click += btnSubs_Click;
            // 
            // btnMult
            // 
            btnMult.Location = new Point(205, 137);
            btnMult.Name = "btnMult";
            btnMult.Size = new Size(59, 59);
            btnMult.TabIndex = 13;
            btnMult.Text = "×";
            btnMult.UseVisualStyleBackColor = true;
            btnMult.Click += btnMult_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(192, 0, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(205, 72);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(124, 59);
            btnClear.TabIndex = 15;
            btnClear.Text = "&C";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // dump
            // 
            dump.BackColor = SystemColors.Control;
            dump.BorderStyle = BorderStyle.None;
            dump.Dock = DockStyle.Top;
            dump.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dump.ForeColor = SystemColors.GrayText;
            dump.Location = new Point(0, 39);
            dump.Name = "dump";
            dump.ReadOnly = true;
            dump.Size = new Size(341, 18);
            dump.TabIndex = 16;
            dump.TabStop = false;
            dump.TextAlign = HorizontalAlignment.Right;
            // 
            // btnDiv
            // 
            btnDiv.Location = new Point(270, 137);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(59, 59);
            btnDiv.TabIndex = 17;
            btnDiv.Text = "÷";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnDiv_Click;
            // 
            // btnClearE
            // 
            btnClearE.BackColor = Color.FromArgb(255, 128, 128);
            btnClearE.ForeColor = SystemColors.ControlText;
            btnClearE.Location = new Point(140, 72);
            btnClearE.Name = "btnClearE";
            btnClearE.Size = new Size(59, 59);
            btnClearE.TabIndex = 18;
            btnClearE.Text = "C&E";
            btnClearE.UseVisualStyleBackColor = false;
            btnClearE.Click += btnClearE_Click;
            // 
            // Form1
            // 
            AcceptButton = btnResult;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(341, 403);
            Controls.Add(btnClearE);
            Controls.Add(btnDiv);
            Controls.Add(dump);
            Controls.Add(btnClear);
            Controls.Add(btnMult);
            Controls.Add(btnSubs);
            Controls.Add(Display);
            Controls.Add(btnResult);
            Controls.Add(btnAdd);
            Controls.Add(button0);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Calculadora";
            KeyPress += Form1_KeyPress;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button0;
        private Button btnAdd;
        private Button btnResult;
        private TextBox Display;
        private Button btnSubs;
        private Button btnMult;
        private Button btnClear;
        private TextBox dump;
        private Button btnDiv;
        private Button btnClearE;
    }
}
