
namespace Calculator
{
    partial class Form1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.txtCalc = new System.Windows.Forms.TextBox();
            this.btnInvert = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btnClearError = new System.Windows.Forms.Button();
            this.btnDecimalPoint = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.txtValue, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtCalc, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 311);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtValue
            // 
            this.txtValue.BackColor = System.Drawing.Color.White;
            this.txtValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValue.Location = new System.Drawing.Point(3, 26);
            this.txtValue.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.txtValue.Name = "txtValue";
            this.txtValue.ReadOnly = true;
            this.txtValue.Size = new System.Drawing.Size(194, 31);
            this.txtValue.TabIndex = 1;
            this.txtValue.Text = "0";
            this.txtValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCalc
            // 
            this.txtCalc.BackColor = System.Drawing.Color.White;
            this.txtCalc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCalc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalc.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtCalc.Location = new System.Drawing.Point(3, 5);
            this.txtCalc.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.txtCalc.Name = "txtCalc";
            this.txtCalc.ReadOnly = true;
            this.txtCalc.Size = new System.Drawing.Size(194, 16);
            this.txtCalc.TabIndex = 2;
            this.txtCalc.TabStop = false;
            this.txtCalc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnInvert
            // 
            this.btnInvert.BackColor = System.Drawing.Color.Khaki;
            this.btnInvert.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnInvert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.btnInvert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.btnInvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvert.Location = new System.Drawing.Point(0, 200);
            this.btnInvert.Margin = new System.Windows.Forms.Padding(0);
            this.btnInvert.Name = "btnInvert";
            this.btnInvert.Size = new System.Drawing.Size(50, 50);
            this.btnInvert.TabIndex = 17;
            this.btnInvert.Text = "+/-";
            this.btnInvert.UseVisualStyleBackColor = false;
            this.btnInvert.Click += new System.EventHandler(this.btnInvert_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Gainsboro;
            this.btn1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btn1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(0, 150);
            this.btn1.Margin = new System.Windows.Forms.Padding(0);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(50, 50);
            this.btn1.TabIndex = 14;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btnSymb_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Gainsboro;
            this.btn4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btn4.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(0, 100);
            this.btn4.Margin = new System.Windows.Forms.Padding(0);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(50, 50);
            this.btn4.TabIndex = 10;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btnSymb_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.Gainsboro;
            this.btn7.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btn7.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(0, 50);
            this.btn7.Margin = new System.Windows.Forms.Padding(0);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(50, 50);
            this.btn7.TabIndex = 6;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btnSymb_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Coral;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSalmon;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(0, 0);
            this.btnClear.Margin = new System.Windows.Forms.Padding(0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(50, 50);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.Gainsboro;
            this.btn0.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btn0.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(50, 200);
            this.btn0.Margin = new System.Windows.Forms.Padding(0);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(50, 50);
            this.btn0.TabIndex = 18;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btnSymb_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Gainsboro;
            this.btn2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btn2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(50, 150);
            this.btn2.Margin = new System.Windows.Forms.Padding(0);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(50, 50);
            this.btn2.TabIndex = 15;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btnSymb_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Gainsboro;
            this.btn5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btn5.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(50, 100);
            this.btn5.Margin = new System.Windows.Forms.Padding(0);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(50, 50);
            this.btn5.TabIndex = 11;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btnSymb_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.Gainsboro;
            this.btn8.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btn8.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(50, 50);
            this.btn8.Margin = new System.Windows.Forms.Padding(0);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(50, 50);
            this.btn8.TabIndex = 7;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btnSymb_Click);
            // 
            // btnClearError
            // 
            this.btnClearError.BackColor = System.Drawing.Color.Coral;
            this.btnClearError.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClearError.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.btnClearError.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSalmon;
            this.btnClearError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearError.Location = new System.Drawing.Point(50, 0);
            this.btnClearError.Margin = new System.Windows.Forms.Padding(0);
            this.btnClearError.Name = "btnClearError";
            this.btnClearError.Size = new System.Drawing.Size(50, 50);
            this.btnClearError.TabIndex = 3;
            this.btnClearError.Text = "CE";
            this.btnClearError.UseVisualStyleBackColor = false;
            this.btnClearError.Click += new System.EventHandler(this.btnClearError_Click);
            // 
            // btnDecimalPoint
            // 
            this.btnDecimalPoint.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDecimalPoint.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDecimalPoint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnDecimalPoint.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDecimalPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecimalPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecimalPoint.Location = new System.Drawing.Point(100, 200);
            this.btnDecimalPoint.Margin = new System.Windows.Forms.Padding(0);
            this.btnDecimalPoint.Name = "btnDecimalPoint";
            this.btnDecimalPoint.Size = new System.Drawing.Size(50, 50);
            this.btnDecimalPoint.TabIndex = 19;
            this.btnDecimalPoint.Text = ".";
            this.btnDecimalPoint.UseVisualStyleBackColor = false;
            this.btnDecimalPoint.Click += new System.EventHandler(this.btnSymb_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Gainsboro;
            this.btn3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btn3.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(100, 150);
            this.btn3.Margin = new System.Windows.Forms.Padding(0);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(50, 50);
            this.btn3.TabIndex = 16;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btnSymb_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.Gainsboro;
            this.btn6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btn6.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(100, 100);
            this.btn6.Margin = new System.Windows.Forms.Padding(0);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(50, 50);
            this.btn6.TabIndex = 12;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btnSymb_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.Gainsboro;
            this.btn9.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btn9.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(100, 50);
            this.btn9.Margin = new System.Windows.Forms.Padding(0);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(50, 50);
            this.btn9.TabIndex = 8;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btnSymb_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.Color.Khaki;
            this.btnDivide.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDivide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.btnDivide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.btnDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.Location = new System.Drawing.Point(100, 0);
            this.btnDivide.Margin = new System.Windows.Forms.Padding(0);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(50, 50);
            this.btnDivide.TabIndex = 4;
            this.btnDivide.Text = "÷";
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Click += new System.EventHandler(this.btnSymb_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEqual.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEqual.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnEqual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(179)))), ((int)(((byte)(242)))));
            this.btnEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqual.Location = new System.Drawing.Point(150, 150);
            this.btnEqual.Margin = new System.Windows.Forms.Padding(0);
            this.btnEqual.Name = "btnEqual";
            this.tableLayoutPanel2.SetRowSpan(this.btnEqual, 2);
            this.btnEqual.Size = new System.Drawing.Size(50, 100);
            this.btnEqual.TabIndex = 20;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btnSymb_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Khaki;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(150, 100);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(50, 50);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnSymb_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.BackColor = System.Drawing.Color.Khaki;
            this.btnSubtract.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSubtract.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.btnSubtract.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.btnSubtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtract.Location = new System.Drawing.Point(150, 50);
            this.btnSubtract.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(50, 50);
            this.btnSubtract.TabIndex = 9;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = false;
            this.btnSubtract.Click += new System.EventHandler(this.btnSymb_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.BackColor = System.Drawing.Color.Khaki;
            this.btnMultiply.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMultiply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.btnMultiply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.btnMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply.Location = new System.Drawing.Point(150, 0);
            this.btnMultiply.Margin = new System.Windows.Forms.Padding(0);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(50, 50);
            this.btnMultiply.TabIndex = 5;
            this.btnMultiply.Text = "×";
            this.btnMultiply.UseVisualStyleBackColor = false;
            this.btnMultiply.Click += new System.EventHandler(this.btnSymb_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btn9, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn8, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn7, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btn5, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.btn6, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.btn1, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnInvert, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.btn2, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnClear, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn3, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnClearError, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnEqual, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnSubtract, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn0, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.btnDecimalPoint, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.btnAdd, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnMultiply, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnDivide, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 61);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 250);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(200, 311);
            this.Controls.Add(this.tableLayoutPanel1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(216, 350);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(216, 350);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Calculator";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.TextBox txtCalc;
        private System.Windows.Forms.Button btnInvert;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btnClearError;
        private System.Windows.Forms.Button btnDecimalPoint;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}

