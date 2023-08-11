# Nội dung ôn tập
### 1. Cài đặt và sử dụng vs code
- [ ] Cài đặt vs code
- [ ] Cài đặt .NET core
- [ ] Cài đặt các Extensions cần thiết để học C#
### 2. Sử dụng git để quản lý version code
- [ ] Tạo tài khoản github
- [ ] Cài đặt git trên máy tính
- [ ] Sử dụng git để quản lý version code. (xem file)
- [ ] Sử dụng git để làm việc nhóm (team work) (xem file)
### <div style="color:Blue;">3. Tạo dự án và cấu trúc</div>
#### <div style="color:Yellow">3.1. Cách tạo dự án C# trên CS code</div>

- **Bước 1:** Tạo thư mục chứa project
```
mkdir <Tên thư mục>
```
- **Bước 2:** Di chuyển vào thư mục vừa tạo và Tạo project

```
cd <tên thư mục vừa tạo>
dotnet new console
```
- **Bước 3:** Sau khi thực hiện code cho project tiến hành chạy project
  - **Cách 1**: Thực hiện chạy từng lần:
  - **Cách 2**: Chạy 1 lần và kết quả sẽ được cập nhật khi thay đổi và lưu code
```
dotnet run
dotnet watch run
```

#### <div style="color:Yellow">3.2. Tạo dự án có tham chiếu thư viện (DLL)</div>

Thực hiện tạo một solution gồm 02 project theo template classLibrary và 1 project thực thi
hãy tham chiếu để sử dụng.

- **Bước 1**: Tạo một thư mục chứa solution
```
mkdir Pro_QuanLyThuVien
```
- **Bước 2**: di chuyển về thư mục đó
```
cd pro_QuanLyThuVien
```
- **Bước 3**: Tại thư mục Pro_QuanLyThuVien thực hiện lệnh tạo một Solution

```
dotnet new sln
```
Sau khi tạo xong nếu xuất hiện thông báo
> The template "Solution File" was created successfully.

là đã tạo thành công! ==> tiếp tục nào....

- **Bước 4**: Thực hiện tạo project theo template Classlibrary

``` C#
dotnet new classlib -o StringLibrary
```
Trong đó:
- StringLibrary là tên của project
- classlib là tên ngắn gọn của loại project ClassLibrary (có thể xem bằng lệnh ```dotnet new list```)
- -o hay --output là lệnh chỉ định vị trí đầu ra được tạo.

- **Bước 5**: Thêm project vừa tạo vào trong solution

```C#
dotnet sln add StringLibrary/StringLibrary.csproj
```
Nếu xuất hiện dòng:
> Project 'StringLibrary\StringLibrary.csproj added to the solution

thì project đã được thêm vào solution thành công.

`Ghi chú: Nên kiểm tra version của project vửa tạo là net mấy, để khi tiến hành tạo các project khác trong Solution nên chọn cùng phiên bản .NET`

Để kiểm tra có thể mở file StringLibrary.csproj trong Explorer hoặc dùng lệnh sau để mở
```
code StringLibrary.csproj
```
- **Bước 6**: Tiến thành viết code cho project  ClassLibrary này (sau đó build project bằng lệnh)
```
dotnet build
```
Việc này sẽ tạo ra một file có tên là StringLibrary.dll trong kết quả file này sẽ được add vào projec thực thi sau này.

- **Bước 7**: Tiến thành tạo một project thực thi (Console Application ) và thêm project này vào Solution.

```
dotnet new console -o ShowCase
```
và thêm vào Solution
```
dotnet sln add ShowCase/ShowCase.csproj
```
- **Bước 8**: Thực hiện thêm tham chiếu thư viên StringLibrary.dll vào project ShowCase

```
dotnet add ShowCase/ShowCase.csproj reference StringLibrary/StringLibrary.csproj
```
nếu kết quả xuất ra thông báo

> `Reference '..\StringLibrary\StringLibrary.csproj added to the project`

Thì đã add thành công!

- **Bước 9**: Tiến hành chạy ứng dụng để kiểm tra kết quả

Cách 1: sử dụng lệnh
```
dotnet run --project ShowCase/ShowCase.csproj
```
hoặc di chuyển vào trong project ShowCase và dùng lệnh dotnet run để chạy APP
```
cd ShowCase
dotnet run
```
___
### 4. Nội dung ôn tập lại
- [ ] Biến và kiểu dữ liệu, nhập xuất
- [ ] Cấu trúc điều khiển (toán tử so sánh/ logic)
- [ ] Vòng lặp  (for/foreach/while/ do...while)
- [ ] Cấu trúc mảng, dữ liệu mảng
- [ ] Chuỗi kí tự
- [ ] Struct và Enum
- [ ] Namespace