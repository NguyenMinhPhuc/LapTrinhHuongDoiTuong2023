
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exx202_QuanLySinhVien
{
    public class StudentManager
    {
        List<Student> students;//null

        public List<Student> Students { get => students; set => students = value; }

        public StudentManager()
        {
            students = new List<Student>();//!=null
        }
        //add student
        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        //Display list students
        public void DisplayAllStudent()
        {
            Console.WriteLine("\nList of Students:");
            Console.WriteLine("----------------------");
            foreach (var student in students)
            {
                student.DisplayInfor();
            }
        }

        //Remove studetn
        public void RemoveStudent(string studetnID)
        {
            Student studentRemove = null;
            foreach (Student student in students)
            {
                if (student.StudentID == studetnID)
                {
                    studentRemove = student;
                    break;
                }
            }
            if (studentRemove != null)
            {
                students.Remove(studentRemove);
                Console.Write("Student removed successfully");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }

        //update student

        public void UpdateStudent(string studentID, string name, DateTime dateOfBirth, string gender, float Score)
        {
            Student studentUpdate = null;
            foreach (Student student in students)
            {
                if (student.StudentID == studentID)
                {
                    studentUpdate = student;
                    break;
                }
            }
            if (studentUpdate != null)
            {
                studentUpdate.Name = name;
                studentUpdate.DateOfBirth = dateOfBirth;
                studentUpdate.Gender = gender;
                studentUpdate.Score = Score;
                Console.WriteLine("Student Information Updated successfully.");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }

        public void UpdateStudent(string studentID)
        {
            Student studentUpdate = null;
            foreach (Student student in students)
            {
                if (student.StudentID == studentID)
                {
                    studentUpdate = student;
                    break;
                }
            }
            if (studentUpdate != null)
            {
                  Console.WriteLine("\nInput Student Infor: ");
                Console.Write("Student Name: ");
                studentUpdate.Name = Console.ReadLine();

                Console.Write("Date Of Birth: ");
                studentUpdate.DateOfBirth = Convert.ToDateTime(Console.ReadLine());

                Console.Write("Gender: ");
                studentUpdate.Gender = Console.ReadLine();

                Console.Write("Score: ");
                studentUpdate.Score = float.Parse(Console.ReadLine());
                Console.WriteLine("Student Information Updated successfully.");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }

        public List<Student> SearchStudents(string keyword)
        {
            List<Student> searchResult = new List<Student>();

            foreach (Student student in students)
            {
                if (student.Name.Contains(keyword))
                {
                    searchResult.Add(student);
                }
            }
            return searchResult;
        }

        public Student SearchStudentByID(string studentID)
        {
            Student searchResult = null;
            foreach (Student student in students)
            {
                if (student.StudentID.Equals(studentID))
                {
                    searchResult = student;
                }
            }
            return searchResult;
        }
    }
}