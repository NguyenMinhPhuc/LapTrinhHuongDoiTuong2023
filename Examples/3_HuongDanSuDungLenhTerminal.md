#### 1. Lệnh tạo folder
 ```terminal
 >mkdir <tên thư mục>
 ```

ví dụ tạo thư mục có tên là cs_101:
```Terminal
>mkdir cs_101
```
#### 2. Chuyển thư mục
```Terminal
>cd <tên đường dẫn>
> cd .. (lùi một cấp thư mục)
```

ví dụ từ thư mục hiện tại vào thư mục vừa tạo:
```Terminal
>cd cs_101
```
quay trở lại thư mục trước đó:
```
>cd ..
```
#### 3. Kiểm tra version .net
```
>dotnet --version
```

(nếu version dotnet chưa đúng thì cài version phù hợp từ trang web của microsoft)
#### 4. Tạo Project
```
> dotnet new <tên viết tắt của Project
```

ví dụ: tạo một console project:>dotnet new console

tạo project web mvc sử dụng Net6 :> dotnet new mvc -n OnlineShop -f net6.0
#### 5. Kiểm tra tên viết tắt
```
> dotnet new list
```

#### 6. Tạo project console

```
> dotnet new console [-f net6.0] [-n <tên project>]
```

#### 7. mở file trong vs code
```
> code <tên file muốn mở>
```

#### 8. Chạy thực thi project
```
>dotnet run
```

#### 9. Chạy thực thi project để khi thay đổi code chương trình tự thay đổi
```
>dotnet watch run\
```

#### 10. Tạo file
```
>code -n <tên file>
```

## Những Extensions
1. OmniSharp
2. C# for Visual Studio Code (powered by OmniSharp)
3. Code Runner
4. C# Extensions
5. Paste JSON as Code

> Nên tìm thiểu thêm về những Extensions hỗ trợ cho ngôn ngữ lập trình đang làm việc để nhận được hỗ trợ tốt nhất