# Hướng dẫn cài đặt và setup dự án Website Đặt Phòng Khách Sạn

## 1. Yêu cầu môi trường
- Windows
- Visual Studio (khuyến nghị bản mới nhất)
- SQL Server (Express hoặc Developer)
- .NET Framework 4.5 trở lên

## 2. Cài đặt cơ sở dữ liệu
1. Mở SQL Server Management Studio.
2. Mở file `SQL_HMS.sql` trong thư mục `setup`.
3. Thực thi toàn bộ script để tạo database và dữ liệu mẫu.

## 3. Cấu hình project
1. Mở Visual Studio.
2. Mở solution `DoAnHMS.sln` trong thư mục `scr/DoAnHMS`.
3. Kiểm tra file `Web.config`:
   - Đảm bảo chuỗi kết nối tới SQL Server đúng với tên server và database vừa tạo.

## 4. Chạy website
1. Build project trong Visual Studio.
2. Nhấn F5 hoặc chọn "Start" để chạy website.
3. Truy cập địa chỉ `http://localhost:xxxx` (xxxx là port Visual Studio cấp).

## 5. Tài khoản đăng nhập mẫu
- Admin: `admin` / `1234`
- Nhân viên: `ha` / `1234`

## 6. Sơ đồ triển khai
```
Client (Web Browser)
   |
   | HTTP
   v
IIS/ASP.NET MVC Application
   |
   | SQL Connection
   v
SQL Server Database
```

## 7. Lưu ý
- Nếu gặp lỗi kết nối database, kiểm tra lại chuỗi kết nối và quyền truy cập SQL Server.
- Có thể thay đổi dữ liệu test trong file `SQL_HMS.sql` để phù hợp với năm hiện tại.