# ASPNET-VX23TTK10-phamthihuyentrang-WebsiteDatPhongKhachSan
## Giới thiệu tổng quan về dự án
Website Đặt Phòng Khách Sạn là hệ thống quản lý đặt phòng, thuê phòng, dịch vụ và phản hồi khách hàng dành cho khách sạn. Dự án được xây dựng trên nền tảng ASP.NET MVC, sử dụng SQL Server làm cơ sở dữ liệu, giao diện hiện đại, dễ sử dụng cho cả khách hàng và nhân viên khách sạn.

Các chức năng chính:
- Quản lý khách hàng, nhân viên, phòng, loại phòng
- Đặt phòng, thuê phòng, trả phòng
- Quản lý dịch vụ đi kèm
- Quản lý hóa đơn, báo cáo doanh thu
- Quản lý quyền truy cập, phân quyền nhân viên
- Quản lý phản hồi, liên hệ từ khách hàng

## Hướng dẫn cách chạy dự án
1. Cài đặt SQL Server và Visual Studio (khuyến nghị bản mới nhất).
2. Thực thi file `setup/SQL_HMS.sql` để tạo database và dữ liệu mẫu.
3. Mở solution `scr/DoAnHMS/DoAnHMS.sln` bằng Visual Studio.
4. Kiểm tra và chỉnh sửa chuỗi kết nối trong file `Web.config` nếu cần.
5. Build và chạy project bằng cách nhấn F5 hoặc chọn "Start".
6. Truy cập website tại địa chỉ `http://localhost:xxxx` (xxxx là port Visual Studio cấp).
7. Đăng nhập bằng tài khoản mẫu:
   - Admin: `admin` / `1234`
   - Nhân viên: `ha` / `1234`