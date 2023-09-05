internal class Program
{
    private static void Main(string[] args)
    {
       StudentManager studentManager = new StudentManager();

        // Thêm sinh viên
        Student student1 = new Student("S001", "John Doe", new DateTime(2000, 1, 1), "Male", 8.5f);
        studentManager.AddStudent(student1);

        Student student2 = new Student("S002", "Jane Smith", new DateTime(2001, 2, 2), "Female", 9.0f);
        studentManager.AddStudent(student2);
        //Updated sinh vien
        studentManager.UpdateStudent("S002", "Nguyen Minh", new DateTime(2012, 2, 2),"Male", 10f);

        // Hiển thị danh sách sinh viên
        studentManager.DisplayAllStudents();

        // Tìm kiếm sinh viên
        List<Student> searchResults = studentManager.SearchStudents("John");
        Console.WriteLine("Search results:");
        foreach (Student student in searchResults)
        {
            student.DisplayInfo();
        }
    }
}