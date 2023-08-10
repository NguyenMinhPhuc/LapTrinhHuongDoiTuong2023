# 1. Download và cài đặt
Download file cài đặt  git theo đúng flatform để cài đặt trên máy tính : [Link download](https://git-scm.com/download/win)
Cấu hình
Mọi cấu hình của git được đặt trong file gitconfig. Một số lệnh cấu hình ban đầu khi sử dụng
# 2. Thiết lập tên trên hệ thống git:
```
git config --global user.name "Tên của Bạn"
```

Email của bạn trên git
```
git config --global user.email emailcuaban@domain.com
```

Hiển thị các tham số thiết lập
```
git config --list
```

# 3. Các lệnh git thường dùng
### Kiểm tra phiên bản GIT
```
git --version
```

### Danh sách các thiết lập cấu hình
```
git config --list
```

### Thiết lập tên
```
git config --global user.name "Tên của Bạn"
```

### Tạo dự án Git mới
```
git init
or
git init --bare
```
trong đó :
Khi bạn cần tạo ra một Repo Git mà nó chỉ có chức năng lưu trữ - không có thư mục làm việc thì thực hiện lệnh ```git init --bare```


### Lệnh git add
```
git add .

or
git add --all
or
git add -A
```
Thêm tất cả những file có thay đổi
Ngoài ra có thể thêm từng file như sau.
Ví dụ: Đưa vào staging file index.html và file about.html
```
git add index.html about.html
```
Đưa thư mục css (và file, thư mục con) vào staging
```
git add css
```
## Xem trạng thái git
```
git status
```


## Sử dụng lệnh git commit
```
git commit -m "Ghi chú về commit"
```

Thực hiện commit với tham số -a:  Khi cho tham số -a thì nó tương đương thực hiện lệnh git add để đưa các file đang được giám sát có sự thay đổi vào staging rồi tự động chạy git commit
```
git commit -a -m "Ghi chú về commit"
```

Thay thế commit cuối bằng tham số --amend: Nếu commit đã được tạo ra nhưng chưa thực hiện push lên remote (khi có làm việc với Remote Repo - nói ở các phần sau) thì bạn có thể tạo ra commit mới thay thế cho commit cuối cùng đó. Dùng trong trường hợp không muốn tạo ra nhiều commit trong lịch sử commit thì cho vào lệnh tham số --amend
```
git commit --amend -m "Thông tin về commit"
```

## Dùng lệnh git reset hủy commit cuối hoặc staging

```
git reset --soft HEAD~1
or
git reset --hard HEAD~1
```



Một vài trường hợp dùng git reset khác:
Hủy git add:
git reset

Hủy đưa một file vào staging:
git reset -- filename
## Đẩy nội dụng đã commit lên server
```
git push origin main
```
## Lấy nội dung về local
```
git pull origin main
```