# Nguyễn Duy Tuấn - 24810310492
## Máy Tính – Event Handler Dùng Chung Cho Nút Số

Bài tập Windows Forms (C#): form máy tính đơn giản, minh họa việc gán chung một sự kiện cho nhiều nút bằng cách ép kiểu `object sender`.

## Đề bài

Thiết kế Form máy tính, gán chung 1 Event Handler cho 10 nút bấm số từ 0 đến 9 bằng tham số `object sender`.

## Yêu cầu và cách đáp ứng

| Yêu cầu | Cách thực hiện |
|---|---|
| Tạo 10 nút `btn0..btn9`, gán chung sự kiện `NumberButton_Click` | Cả 10 nút đều `Click += NumberButton_Click` trong `Form1.Designer.cs` |
| Ép kiểu `Button btn = (Button)sender;` và nối chuỗi vào `txtDisplay.Text` | Thực hiện trong `NumberButton_Click` (`Form1.cs`) |
| Các nút phép toán `+ - * / =` và `C` (Clear) | `OperatorButton_Click` dùng chung cho `+ - * /`; `btnEquals_Click` tính kết quả; `btnClear_Click` reset màn hình |

## Công nghệ

- C# / .NET Windows Forms

## Cấu trúc project

```
CalculatorApp/
├── Form1.cs              # NumberButton_Click, OperatorButton_Click, tính toán, Clear
├── Form1.Designer.cs     # Khai báo 10 nút số, 4 nút phép toán, nút =, nút C, txtDisplay
├── Program.cs            # Điểm khởi chạy ứng dụng
└── README.md
```

## Cách chạy

1. Mở Visual Studio → **File > New Project** → chọn **Windows Forms App (.NET)**.
2. Đặt tên project là `CalculatorApp` (trùng namespace trong code).
3. Thay nội dung 3 file `Form1.cs`, `Form1.Designer.cs`, `Program.cs` bằng code trong repo.
4. Nhấn **F5** để chạy.

## Kết quả

- Bấm các nút số → chuỗi số hiện lên `txtDisplay` (nối tiếp, không ghi đè).
- Bấm phép toán → lưu số hạng đầu, chờ nhập số hạng sau.
- Bấm `=` → hiện kết quả (có cảnh báo nếu chia cho 0).
- Bấm `C` → xóa màn hình, reset phép tính.

<!-- Chèn ảnh chụp màn hình giao diện thực tế vào đây, ví dụ: -->
<img width="1383" height="550" alt="Screenshot 2026-09-24 153928" src="https://github.com/user-attachments/assets/36f0239c-7f17-4954-9d75-bdda9897a62c" />
