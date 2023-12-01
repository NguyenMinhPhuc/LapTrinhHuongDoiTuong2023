public class StudentManager
{
    private List<Student> students;
    private StudentEventHandler studentEventHandler;

    public StudentManager()
    {
        students = new List<Student>();
        //Khai báo EventHandler
        studentEventHandler = new StudentEventHandler();
        //Khai bao event cho su kien add
        studentEventHandler.StudentAdded += StudentAddedHandler;
       // Khai bao event cho su kien update
        studentEventHandler.StudentUpdated -= StudentUpdatedHandler;

    }

    public void AddStudent(Student student)
    {
        students.Add(student);
        //Kích hoạt Event thêm sinh viên
        studentEventHandler.OnStudentAdded(student);
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
                studentToUpdate = student;
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
            //gọi sự kiện update
             studentEventHandler.OnStudentUpdated(studentToUpdate);
        }
        else
        {
            Console.WriteLine("Student not found.");
        }

    }

    private void StudentAddedHandler(object sender, StudentEventArgs e)
    {
        Console.WriteLine("New student added:");
        e.Student.DisplayInfo();
    }

    private void StudentUpdatedHandler(object sender, StudentEventArgs e)
    {
        Console.WriteLine("A Student Updated:");
        e.Student.DisplayInfo();
    }
}