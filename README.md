# Nguyễn Duy Tuấn - 24810310492
Bài tập Windows Forms (C#): form máy tính đơn giản, minh họa việc gán chung một sự kiện cho nhiều nút bằng cách ép kiểu `object sender`.
## Đề bài

## Cấu trúc project

```
CalculatorApp/
├── Form1.cs              # NumberButton_Click, OperatorButton_Click, tính toán, Clear
├── Form1.Designer.cs     # Khai báo 10 nút số, 4 nút phép toán, nút =, nút C, txtDisplay
├── Program.cs            # Điểm khởi chạy ứng dụng
└── README.md
```

## Kết quả

- Bấm các nút số → chuỗi số hiện lên `txtDisplay` (nối tiếp, không ghi đè).
- Bấm phép toán → lưu số hạng đầu, chờ nhập số hạng sau.
- Bấm `=` → hiện kết quả (có cảnh báo nếu chia cho 0).
- Bấm `C` → xóa màn hình, reset phép tính.

<!-- Chèn ảnh chụp màn hình giao diện thực tế vào đây, ví dụ: -->
<img width="1383" height="550" alt="Screenshot 2026-09-24 153928" src="https://github.com/user-attachments/assets/36f0239c-7f17-4954-9d75-bdda9897a62c" />
