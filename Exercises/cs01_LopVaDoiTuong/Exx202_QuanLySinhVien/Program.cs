using Exx202_QuanLySinhVien;

using System.Text;
internal class Program
{
    private static void Main(string[] args)
    {

        Console.OutputEncoding = Encoding.UTF8;
        StudentManager studentManager = new StudentManager();

        do
        {
            int chon = Menu();
            switch (chon)
            {
                case 1:
                    Console.Write("Input number student");
                    int n = Convert.ToInt32(Console.ReadLine());
                    Student student;
                    for (int i = 0; i < n; i++)
                    {
                        student = new Student();
                        Console.Write("Student ID: ");
                        student.StudentID = Console.ReadLine();

                        Console.Write("Student Name: ");
                        student.Name = Console.ReadLine();

                        Console.Write("Date Of Birth: ");
                        student.DateOfBirth = Convert.ToDateTime(Console.ReadLine());

                        Console.Write("Gender: ");
                        student.Gender = Console.ReadLine();

                        Console.Write("Score: ");
                        student.Score = float.Parse(Console.ReadLine());
                        studentManager.AddStudent(student);
                    }
                    break;
                case 2:
                    Console.Write("Display list students");
                    studentManager.DisplayAllStudent();
                    break;
                case 3:
                    Console.Write("Search student by ID");
                    Console.Write("Input student ID: ");
                    string studentID = Console.ReadLine();
                    Student student1 = studentManager.SearchStudentByID(studentID);
                    if (student1 != null)
                        student1.DisplayInfor();
                    else
                        Console.Write("Student not found.");
                    break;
                case 4:
                    Console.WriteLine("\nSearch student by Name");
                    Console.Write("Input student Name: ");
                    string name = Console.ReadLine();

                    List<Student> list = studentManager.SearchStudents(name);
                    if (list.Count > 0)
                    {
                        foreach (var item in list)
                        {
                            item.DisplayInfor();
                        }
                    }
                    else
                    {
                        Console.Write("Student not Found.");
                    }
                    break;
                case 5:
                    Console.Write("Update student");
                    Console.Write("Input student ID (Update): ");
                    string IDUpdate = Console.ReadLine();
                    studentManager.UpdateStudent(IDUpdate);
                    studentManager.DisplayAllStudent();
                    break;
                case 6:
                    Console.Write("Remove student");
                    Console.Write("Input student ID (Remove): ");
                    string IDRemove = Console.ReadLine();
                    studentManager.RemoveStudent(IDRemove);
                    studentManager.DisplayAllStudent();
                    break;
                case 7:
                    return;
            }

        } while (true);
        Console.ReadLine();
    }
    private static int Menu()
    {
        int count = 0;
        Console.WriteLine("\nStudent manager System");
        Console.WriteLine("1. Add Student");
        Console.WriteLine("2. Display All Student");
        Console.WriteLine("3. Search student by id");
        Console.WriteLine("4. Search student by name");
        Console.WriteLine("5. Update Student");
        Console.WriteLine("6. Remove Student");
        Console.WriteLine("7. Exit");
        count = Convert.ToInt32(Console.ReadLine());
        return count;

    }
}