1. S - Single Responsibility principle (SRP)
2. O - Open Close Principle (OCP)
3. L - Liskov Substitution Principle (LSP)
4. I - Interface segregation principle (ISP)
5. D - Dependency Inversion
6. --------------------------
**Nguyên tắc 1: Đơn trách nhiệm**
Ví dụ:
 Bạn có một công cụ được kết hợp bởi rất nhiều các công cụ nhỏ khác nhau như dao, cắt móng tay, tước nơ vít….Bạn có muốn mua cái này? Tôi không nghĩ là muốn mua. Bởi vì có một vấn đề với nó, nếu bạn muốn thêm bất cứ một công cụ nào vào nó, bạn cần phải thay đổi toàn bộ cấu tạo của nó, điều này là không ổn. Đây là một kiến trúc tồi với bất cứ hệ thống nào. Tốt hơn hết nếu bấm móng tay chỉ nên sử dụng để bấm móng tay, hoặc dao chỉ nên sử dụng để thái rau
 **Nguyên tắc 2: Open / Closed**
 Các thực thể của phần mềm (classes, modules, functions) nên được thiết kế sao cho có thể mở rộng mà không cần sửa đổi mã nguồn gốc. Điều này đảm bảo tính linh hoạt và giảm rủi ro gây lỗi khi thay đổ
 **Liskov substitution principle (LSP)**
 Class con không nên phá vỡ các định nghĩa và hành vi của class cha
 **Interface segregation principle (ISP)**
 Nguyên tắc này nói rằng bất cứ một client nào không nên triển khai một interface không phù hợp với nó. Điều này có nghĩa, giả sử có một CSDL để lưu trữ tất cả các loại của nhân viên (cố định, tạm thời), vậy cách tiếp cận tốt nhất là gì?

**Dependency inversion principle (DIP)**
Nguyên tắc này nói cho bạn rằng bạn không nên viết code gắn chặt với nhau bởi vì sẽ là cơn ác mộng cho việc bảo trì khi ứn dụng trở lên lớn dần. Nếu một class phụ thuộc một class khác