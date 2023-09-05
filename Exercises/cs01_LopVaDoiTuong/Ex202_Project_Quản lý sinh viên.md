# Xây dựng ứng dụng quản lý sinh viên, bao gồm phân tích bài toán theo hướng đối tượng.

## 1. Phân tích bài toán: Quản lý sinh viên

Bài toán yêu cầu xây dựng một ứng dụng quản lý sinh viên. Mỗi sinh viên có các thông tin như mã sinh viên, tên, ngày sinh, giới tính và điểm số. Ứng dụng cần hỗ trợ các chức năng sau:

1. Thêm sinh viên mới vào hệ thống.
2. Hiển thị danh sách tất cả sinh viên.
3. Tìm kiếm sinh viên theo mã sinh viên hoặc tên.
4. Xóa sinh viên khỏi hệ thống.
5. Cập nhật thông tin của sinh viên.

## 2. Phân tích hướng đối tượng:

Dựa vào phân tích bài toán trên, chúng ta có thể xác định một số lớp và đối tượng liên quan:

1. Lớp `Student` (Sinh viên):
   - Thuộc tính:
     - Mã sinh viên
     - Tên
     - Ngày sinh
     - Giới tính
     - Điểm số
   - Phương thức:
     - Constructor (Hàm khởi tạo)
     - Getter và Setter cho các thuộc tính
     - Phương thức để hiển thị thông tin sinh viên

2. Lớp `StudentManager` (Quản lý sinh viên):
   - Thuộc tính:
     - Danh sách sinh viên (`List<Student>`)
   - Phương thức:
     - Thêm sinh viên mới vào danh sách
     - Hiển thị danh sách sinh viên
     - Tìm kiếm sinh viên theo mã sinh viên hoặc tên
     - Xóa sinh viên khỏi danh sách
     - Cập nhật thông tin của sinh viên

Với phân tích trên, chúng ta có thể triển khai mã nguồn C# cho dự án quản lý sinh viên như sau:

```csharp
using System;
using System.Collections.Generic;

class Student
{
    public string StudentID { get; set; }
    public string Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Gender { get; set; }
    public float Score { get; set; }

    public Student(string studentID, string name, DateTime dateOfBirth, string gender, float score)
    {
        StudentID = studentID;
        Name = name;
        DateOfBirth = dateOfBirth;
        Gender = gender;
        Score = score;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Student ID: {StudentID}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Date of Birth: {DateOfBirth.ToShortDateString()}");
        Console.WriteLine($"Gender: {Gender}");
        Console.WriteLine($"Score: {Score}");
        Console.WriteLine();
    }
}

class StudentManager
{
    private List<Student> students;

    public StudentManager()
    {
        students = new List<Student>();
    }

    public void AddStudent(Student student)
    {
        students.Add(student);
    }

    public void DisplayAllStudents()
    {
        Console.WriteLine("List of Students:");
        foreach (Student student in students)
        {
            student.DisplayInfo();
        }
    }

    public List<Student> SearchStudents(string keyword)
    {
        List<Student> searchResults = new List<Student>();
        foreach (Student student in students)
        {
            if (student.StudentID.Contains(keyword) || student.Name.Contains(keyword))
            {
                searchResults.Add(student);
            }
        }
        return searchResults;
    }

    public void RemoveStudent(string studentID)
    {
        Student studentToRemove = null;
        foreach (Student student in students)
        {
            if (student.StudentID == studentID)
            {
                studentToRemove = student;
                break;
            }
        }
        if (studentToRemove != null)
        {
            students.Remove(studentToRemove);
            Console.WriteLine("Student removed successfully.");
        }
        else
        {
            Console.WriteLine("Student not found.");
        }
    }

    public void UpdateStudent(string studentID, string name, DateTime dateOfBirth, string gender, float score)
    {
        Student studentToUpdate = null;
        foreach (Student student in students)
        {
            if (student.StudentID == studentID)
            {
                studentToUpdate =student;
                break;
            }
        }
        if (studentToUpdate != null)
        {
            studentToUpdate.Name = name;
            studentToUpdate.DateOfBirth = dateOfBirth;
            studentToUpdate.Gender = gender;
            studentToUpdate.Score = score;
            Console.WriteLine("Student information updated successfully.");
        }
        else
        {
            Console.WriteLine("Student not found.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        StudentManager studentManager = new StudentManager();

        // Thêm sinh viên
        Student student1 = new Student("S001", "John Doe", new DateTime(2000, 1, 1), "Male", 8.5f);
        studentManager.AddStudent(student1);

        Student student2 = new Student("S002", "Jane Smith", new DateTime(2001, 2, 2), "Female", 9.0f);
        studentManager.AddStudent(student2);

        // Hiển thị danh sách sinh viên
        studentManager.DisplayAllStudents();

        // Tìm kiếm sinh viên
        List<Student> searchResults = studentManager.SearchStudents("John");
        Console.WriteLine("Search results:");
        foreach (Student student in searchResults)
        {
            student.DisplayInfo();
        }

        // Xóa sinh viên
        studentManager.RemoveStudent("S001");

        // Cập nhật thông tin sinh viên
        studentManager.UpdateStudent("S002", "Jane Doe", new DateTime(2001, 2, 2), "Female", 9.5f);

        // Hiển thị danh sách sinh viên sau khi cập nhật
        studentManager.DisplayAllStudents();

        Console.ReadLine();
    }
}
```

>Trên đây là một ví dụ về cách sử dụng lớp và đối tượng để xây dựng một ứng dụng quản lý sinh viên đơn giản. Bạn có thể mở rộng chức năng của ứng dụng này hoặc thêm các lớp và phương thức khác tùy theo yêu cầu của dự án cụ thể.


` Yêu cầu thêm:
Tương tự như ví dụ ở trên hay phân tích ứng dụng quản lý nhân sự của một công ty gồm các chức năng sau: 1. Nhập thông tin nhân viên, 2. Phân phòng ban cho nhân viên; 3. tìm kiếm nhân viên theo tên; 4. Tìm kiếm nhân viên theo maNhanVien; 5. cập nhật nhân viên nghỉ làm; 6. Tính lương cho nhân viên; 7. Chuyển phòng ban làm việc; 8. In danh sách nhân viên.
`