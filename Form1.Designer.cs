namespace exemplo
{
    partial class X
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
            imputTextX = new TextBox();
            btnClick = new Button();
            labelTitle = new Label();
            labelOutPut = new Label();
            inputTextY = new TextBox();
            colorDialog1 = new ColorDialog();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button1 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button9 = new Button();
            SuspendLayout();
            // 
            // imputTextX
            // 
            imputTextX.BackColor = Color.FromArgb(90, 90, 90);
            imputTextX.Location = new Point(82, 62);
            imputTextX.Name = "imputTextX";
            imputTextX.Size = new Size(220, 31);
            imputTextX.TabIndex = 1;
            imputTextX.TextChanged += imputTextX_TextChanged;
            // 
            // btnClick
            // 
            btnClick.BackColor = Color.Gold;
            btnClick.Cursor = Cursors.Hand;
            btnClick.FlatAppearance.BorderColor = SystemColors.Window;
            btnClick.FlatAppearance.BorderSize = 3;
            btnClick.FlatStyle = FlatStyle.Flat;
            btnClick.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnClick.ForeColor = SystemColors.ActiveCaptionText;
            btnClick.Location = new Point(28, 158);
            btnClick.Name = "btnClick";
            btnClick.Size = new Size(66, 66);
            btnClick.TabIndex = 3;
            btnClick.Text = " +";
            btnClick.TextAlign = ContentAlignment.TopLeft;
            btnClick.UseVisualStyleBackColor = false;
            btnClick.Click += onSomaClick;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelTitle.ForeColor = Color.Gold;
            labelTitle.Location = new Point(28, 9);
            labelTitle.MaximumSize = new Size(300, 65);
            labelTitle.MinimumSize = new Size(300, 65);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(300, 65);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Calculador:";
            labelTitle.Click += labelTitle_Click;
            // 
            // labelOutPut
            // 
            labelOutPut.AutoSize = true;
            labelOutPut.BackColor = Color.FromArgb(77, 77, 77);
            labelOutPut.ForeColor = Color.White;
            labelOutPut.Location = new Point(368, 15);
            labelOutPut.MaximumSize = new Size(400, 330);
            labelOutPut.MinimumSize = new Size(400, 330);
            labelOutPut.Name = "labelOutPut";
            labelOutPut.Padding = new Padding(10);
            labelOutPut.Size = new Size(400, 330);
            labelOutPut.TabIndex = 4;
            labelOutPut.Text = "...";
            labelOutPut.Visible = false;
            labelOutPut.Click += labelOutPut_Click;
            // 
            // inputTextY
            // 
            inputTextY.BackColor = Color.FromArgb(90, 90, 90);
            inputTextY.Location = new Point(82, 108);
            inputTextY.Name = "inputTextY";
            inputTextY.Size = new Size(220, 31);
            inputTextY.TabIndex = 2;
            inputTextY.TextChanged += inputTextY_TextChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.Gold;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = SystemColors.Window;
            button2.FlatAppearance.BorderSize = 3;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(136, 158);
            button2.Name = "button2";
            button2.Size = new Size(66, 66);
            button2.TabIndex = 5;
            button2.Text = " –";
            button2.TextAlign = ContentAlignment.TopCenter;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Gold;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderColor = SystemColors.Window;
            button3.FlatAppearance.BorderSize = 3;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(248, 158);
            button3.Name = "button3";
            button3.Size = new Size(66, 66);
            button3.TabIndex = 6;
            button3.Text = "x";
            button3.TextAlign = ContentAlignment.TopCenter;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Gold;
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderColor = SystemColors.Window;
            button4.FlatAppearance.BorderSize = 3;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Location = new Point(28, 242);
            button4.Name = "button4";
            button4.Size = new Size(66, 66);
            button4.TabIndex = 7;
            button4.Text = "÷";
            button4.TextAlign = ContentAlignment.TopCenter;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = SystemColors.Window;
            button1.FlatAppearance.BorderSize = 3;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(136, 242);
            button1.Name = "button1";
            button1.Size = new Size(66, 66);
            button1.TabIndex = 8;
            button1.Text = "x²";
            button1.TextAlign = ContentAlignment.TopRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Gold;
            button5.Cursor = Cursors.Hand;
            button5.FlatAppearance.BorderColor = SystemColors.Window;
            button5.FlatAppearance.BorderSize = 3;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button5.ForeColor = SystemColors.ActiveCaptionText;
            button5.Location = new Point(248, 242);
            button5.Name = "button5";
            button5.Size = new Size(66, 66);
            button5.TabIndex = 9;
            button5.Text = "√";
            button5.TextAlign = ContentAlignment.TopCenter;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Gold;
            button6.Cursor = Cursors.Hand;
            button6.FlatAppearance.BorderColor = SystemColors.Window;
            button6.FlatAppearance.BorderSize = 3;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button6.ForeColor = SystemColors.ActiveCaptionText;
            button6.Location = new Point(28, 324);
            button6.Name = "button6";
            button6.Size = new Size(66, 66);
            button6.TabIndex = 10;
            button6.Text = "%";
            button6.TextAlign = ContentAlignment.TopCenter;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Gold;
            button7.Cursor = Cursors.Hand;
            button7.FlatAppearance.BorderColor = SystemColors.Window;
            button7.FlatAppearance.BorderSize = 3;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button7.ForeColor = SystemColors.ActiveCaptionText;
            button7.Location = new Point(136, 324);
            button7.Name = "button7";
            button7.Size = new Size(66, 66);
            button7.TabIndex = 11;
            button7.Text = "01";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.Gold;
            button8.Cursor = Cursors.Hand;
            button8.FlatAppearance.BorderColor = SystemColors.Window;
            button8.FlatAppearance.BorderSize = 3;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button8.ForeColor = SystemColors.ActiveCaptionText;
            button8.Location = new Point(248, 328);
            button8.Name = "button8";
            button8.Size = new Size(66, 66);
            button8.TabIndex = 10;
            button8.Text = "x^y";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(77, 77, 77);
            label1.Font = new Font("Segoe UI", 50F);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(398, 158);
            label1.MaximumSize = new Size(350, 150);
            label1.MinimumSize = new Size(350, 150);
            label1.Name = "label1";
            label1.Size = new Size(350, 150);
            label1.TabIndex = 12;
            label1.Text = "...";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Visible = false;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Gold;
            label2.Location = new Point(38, 65);
            label2.Name = "label2";
            label2.Size = new Size(23, 25);
            label2.TabIndex = 13;
            label2.Text = "X";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Gold;
            label3.Location = new Point(38, 108);
            label3.Name = "label3";
            label3.Size = new Size(22, 25);
            label3.TabIndex = 14;
            label3.Text = "Y";
            label3.Click += label3_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.Gold;
            button9.Location = new Point(516, 356);
            button9.Name = "button9";
            button9.Size = new Size(112, 34);
            button9.TabIndex = 15;
            button9.Text = "Apagar";
            button9.UseVisualStyleBackColor = false;
            // 
            // X
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 26);
            ClientSize = new Size(800, 450);
            Controls.Add(button9);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(imputTextX);
            Controls.Add(inputTextY);
            Controls.Add(labelOutPut);
            Controls.Add(labelTitle);
            Controls.Add(btnClick);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "X";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox imputTextX;
        private Button btnClick;
        private Label labelTitle;
        private Label labelOutPut;
        private TextBox inputTextY;
        private ColorDialog colorDialog1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button1;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button9;
    }
}