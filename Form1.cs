using System;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        // Lưu số hạng thứ nhất và phép toán đang chọn
        private double firstNumber = 0;
        private string currentOperator = "";
        private bool isNewInput = true; // true = đang chờ nhập số mới (sau khi bấm phép toán / =)

        public Form1()
        {
            InitializeComponent();
        }

        // Sự kiện DÙNG CHUNG cho 10 nút số 0..9
        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender; // ép kiểu object sender về Button

            if (isNewInput)
            {
                txtDisplay.Text = btn.Text; // bắt đầu chuỗi số mới
                isNewInput = false;
            }
            else
            {
                txtDisplay.Text += btn.Text; // nối chuỗi số vào ô hiển thị
            }
        }

        // Sự kiện dùng chung cho các nút phép toán +, -, *, /
        private void OperatorButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            firstNumber = double.Parse(txtDisplay.Text);
            currentOperator = btn.Text;
            isNewInput = true;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentOperator))
                return;

            double secondNumber = double.Parse(txtDisplay.Text);
            double result = 0;

            switch (currentOperator)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    if (secondNumber == 0)
                    {
                        MessageBox.Show("Không thể chia cho 0!", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    result = firstNumber / secondNumber;
                    break;
            }

            txtDisplay.Text = result.ToString();
            currentOperator = "";
            isNewInput = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            firstNumber = 0;
            currentOperator = "";
            isNewInput = true;
        }
    }
}