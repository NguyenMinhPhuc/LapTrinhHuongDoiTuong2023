using Exx202_QuanLySinhVien;
internal class Program
{
    private static void Main(string[] args)
    {
        StudentManager studentManager = new StudentManager();

        //them sinh vien 1
        Student student1 = new Student("SV01", "Nguyen Minh Phuc", new DateTime(2000, 1, 1), "Male", 7.5f);
        studentManager.AddStudent(student1);
        //them sinh vien 2
        Student student2 = new Student("SV02", "Nguyen Minh Hoang", new DateTime(2002, 5, 1), "Male", 8.8f);
        studentManager.AddStudent(student2);
        //Hien thi danh sach 2 sinh vien
        studentManager.DisplayAllStudent();

        // tim kiem
        List<Student> searchResult = studentManager.SearchStudents("SV02");
        foreach (var student in searchResult)
        {
            student.DisplayInfor();
        }

        // xoa sinh vien
        studentManager.RemoveStudent("SV01");

        //Cap nhat thong tin
        studentManager.UpdateStudent("SV02", "Nguyen Van Phuc", new DateTime(2009, 1, 1), "Female", 6f);

        // Hien thi laij
        studentManager.DisplayAllStudent();

        Console.ReadLine();

    }
}