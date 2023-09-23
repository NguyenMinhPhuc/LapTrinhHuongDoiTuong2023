# ví dụ 1: QuanLyTruongHoc

Một trường học muốn quản lý thông tin của Gv và sinh viên trong trường bao gồm các thông tin sau: ID, ho, ten, ngaySinh, Giới tính, địa chỉ; nhap thong tin xuất thông tin
- SinhVien: Lớp, Ngành học, diemTB, DiemRenLuyen, Xếp loại

- GiaoVien: học hàm, học vị, số giờ dạy, Tính tiền giảng

Phân tích:
- Nhập thông tin
- Xem thông tin
- Xếp loại sinh viên
- Tính tiền giảng
- Tìm kiếm Tên, ID
- Sửa thông tin
- Xóa
- Lưu file (text, ini ,bat)
### phan tích thành lớp đối tượng dữ liệu
- Person(MaSo, Ho, Ten,NgaySinh, GioiTinh,DiaChi,SoDienThoai)
- Teacher(HocHam, HocVi, SoGioDay)
- Student(Lop, Nganh, DiemTB, DiemRenLuyen)

### Các lớp đối tượng
- Person
  - field
  - Virtual Nhap
  - Virtual Xuat
- Teacher:Person
  - field
  - Override Nhap
  - Overried Xuat
  - TinhTienGiang
- Student:Person
- - field
  - Override Nhap
  - Overried Xuat
  - XepLoai
- PersonManager: quản lý danh sách
  - List
  - nhap list
  - tìm kiếm tên, id
  - sửa
  - xóa