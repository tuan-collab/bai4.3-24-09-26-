namespace CalculatorApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtDisplay;

        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnClear;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtDisplay = new System.Windows.Forms.TextBox();

            this.btn0 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();

            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // txtDisplay
            this.txtDisplay.Location = new System.Drawing.Point(20, 20);
            this.txtDisplay.Size = new System.Drawing.Size(240, 30);
            this.txtDisplay.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDisplay.ReadOnly = true;

            // Kích thước chung cho các nút số
            System.Drawing.Size btnSize = new System.Drawing.Size(50, 50);

            // Hàng số 7 8 9 và phép chia
            this.btn7.Location = new System.Drawing.Point(20, 65);
            this.btn7.Size = btnSize;
            this.btn7.Text = "7";
            this.btn7.Click += new System.EventHandler(this.NumberButton_Click);

            this.btn8.Location = new System.Drawing.Point(75, 65);
            this.btn8.Size = btnSize;
            this.btn8.Text = "8";
            this.btn8.Click += new System.EventHandler(this.NumberButton_Click);

            this.btn9.Location = new System.Drawing.Point(130, 65);
            this.btn9.Size = btnSize;
            this.btn9.Text = "9";
            this.btn9.Click += new System.EventHandler(this.NumberButton_Click);

            this.btnDivide.Location = new System.Drawing.Point(185, 65);
            this.btnDivide.Size = btnSize;
            this.btnDivide.Text = "/";
            this.btnDivide.Click += new System.EventHandler(this.OperatorButton_Click);

            // Hàng số 4 5 6 và phép nhân
            this.btn4.Location = new System.Drawing.Point(20, 120);
            this.btn4.Size = btnSize;
            this.btn4.Text = "4";
            this.btn4.Click += new System.EventHandler(this.NumberButton_Click);

            this.btn5.Location = new System.Drawing.Point(75, 120);
            this.btn5.Size = btnSize;
            this.btn5.Text = "5";
            this.btn5.Click += new System.EventHandler(this.NumberButton_Click);

            this.btn6.Location = new System.Drawing.Point(130, 120);
            this.btn6.Size = btnSize;
            this.btn6.Text = "6";
            this.btn6.Click += new System.EventHandler(this.NumberButton_Click);

            this.btnMultiply.Location = new System.Drawing.Point(185, 120);
            this.btnMultiply.Size = btnSize;
            this.btnMultiply.Text = "*";
            this.btnMultiply.Click += new System.EventHandler(this.OperatorButton_Click);

            // Hàng số 1 2 3 và phép trừ
            this.btn1.Location = new System.Drawing.Point(20, 175);
            this.btn1.Size = btnSize;
            this.btn1.Text = "1";
            this.btn1.Click += new System.EventHandler(this.NumberButton_Click);

            this.btn2.Location = new System.Drawing.Point(75, 175);
            this.btn2.Size = btnSize;
            this.btn2.Text = "2";
            this.btn2.Click += new System.EventHandler(this.NumberButton_Click);

            this.btn3.Location = new System.Drawing.Point(130, 175);
            this.btn3.Size = btnSize;
            this.btn3.Text = "3";
            this.btn3.Click += new System.EventHandler(this.NumberButton_Click);

            this.btnSubtract.Location = new System.Drawing.Point(185, 175);
            this.btnSubtract.Size = btnSize;
            this.btnSubtract.Text = "-";
            this.btnSubtract.Click += new System.EventHandler(this.OperatorButton_Click);

            // Hàng số 0, C, =, +
            this.btn0.Location = new System.Drawing.Point(20, 230);
            this.btn0.Size = new System.Drawing.Size(105, 50); // nút 0 rộng gấp đôi
            this.btn0.Text = "0";
            this.btn0.Click += new System.EventHandler(this.NumberButton_Click);

            this.btnClear.Location = new System.Drawing.Point(130, 230);
            this.btnClear.Size = btnSize;
            this.btnClear.Text = "C";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            this.btnAdd.Location = new System.Drawing.Point(185, 230);
            this.btnAdd.Size = btnSize;
            this.btnAdd.Text = "+";
            this.btnAdd.Click += new System.EventHandler(this.OperatorButton_Click);

            this.btnEquals.Location = new System.Drawing.Point(20, 285);
            this.btnEquals.Size = new System.Drawing.Size(215, 50); // nút = rộng hết hàng
            this.btnEquals.Text = "=";
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);

            // Form1
            this.ClientSize = new System.Drawing.Size(260, 355);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEquals);
            this.Text = "Máy tính";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}