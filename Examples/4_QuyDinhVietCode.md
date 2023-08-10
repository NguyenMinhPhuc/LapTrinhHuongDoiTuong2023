## 1. Quy tắc đặt tên
|Kiểu|Ví dụ|
|:--|:--|
|Pascal|      BackColor|
|Camel|      backColor
|UpperCase|   BACKCOLOR|

## 2. Một số quy tắc đặt tên

|Loại | Kiểu đặt tên|Ví dụ| Ghi chú|
|:--|:--|:--|:--|
|Tên biến|Camel|backColor| |
|Hằng số|Uppercase| NUMBER_OF_STUDENT| có gạch chân giữa các từ|
|Tên class,enum|Pascal|SmartSnake| |
|Tham số| Camel|displayTime| |
|Thuộc tính |Pascal|BackColor| |
|Phương thức|Pascal|GetPath()| |
|Sự kiện|Pascal|ClickEvenHandler|Có hậu tố EventHandler|
|Giao diện  - Interface|Pascal|IButtonControl|Có tiền tố I|

## 3. Quy định comment
Sử dụng tiếng việt có dấu để viết comment (nếu dùng được tiếng anh càng tốt)

- **Comment cho module, class:** mỗi module, class cần có mô tả ngắn về mục đích của module hay class đó, nội dung bao gồm:
  - Mục đích: Module hay class thực hiện những công việc gì
  - Người lập: Người tạo module hay class
  - Những biến/ hàm quan trọng: liệt kê tên các biến và hàm quan trong trong module/ class.
- **Comment cho method và event**: Tất cả các method và event phải có comment, Comment cho method/event gồm hai phần:
  - Phẩn 1: (Không bắt buộc): mô tả mục đích và diễn giải ngắn gọn ý nghĩa các tham số đầu vào, đầu ra. Lưu ý: mô tả method đó làm gì (what), không mô tả method đó thực hiện thế nào (how). Lập trình viên có thể không cần viết phần mô tả mục đích này với các method/event đơn giản, không phức tạp
  - phần 2: (Bắt buộc) ghi thông tin về lịch sử tạo và sửa method/event đó (người tạo/ngày tạo, người sửa/ngày sửa). Thông tin này bắt buộc phải có với mọi method/event. Mẫu comment cho method/event đơn giản.
- **Comment cho đoạn code**: Những đoạn code phức tạp cần có comment gắn liền bên trên để chú giải. Những đoạn code được sửa đổi (modified), bổ sung (added) hoặc rem (removed) bởi người không phải tác giả cần có comment rõ ngay tại nơi sửa đổi, bổ sung: người sửa, ngày sửa, mục đích.

## 4. Quy định phân nhóm (region) khi coding.

Phải sử dụng region phân nhóm code để tiện cho việc sửa đổi, bảo trì. Phân nhóm code
theo cấu trúc như sau (theo thứ tự bắt buộc, nhưng không bắt buộc có đủ tất cả các region): Declaration, Constructor, Property, Method/Function, Event. Tùy theo yêu cầu của các form, class và module, lập trình viên có thể chia nhỏ các region chính trên thành các sub-region. VD: region Method/Function có thể chứa các region con sau: Method/Function Public, Overridable (trường hợp là base form/class), Override (trường hợp là derive form/class), Private, Other. Trường hợp form hoặc class có sử dụng các component độc lập (Security, Document, MassEmail,…) thì phải tạo các region riêng cho từng component, chứa toàn bộ code liên quan đến việc tương tác với các component đó
