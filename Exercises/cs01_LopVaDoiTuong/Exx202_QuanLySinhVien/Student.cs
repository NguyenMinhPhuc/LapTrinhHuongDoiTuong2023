
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exx202_QuanLySinhVien
{
    public class Student
    {
        //field
        string studentID,name;
        DateTime dateOfBirth;
        string gender;
        float score;

        public string StudentID { get => studentID; set => studentID = value; }
        public string Name { get => name; set => name = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string Gender { get => gender; set => gender = value; }
        public float Score { get => score; set => score = value; }
        public Student(){}
        public Student(string studentID,string name,DateTime dateOfBirth,string gender,float score){
            this.studentID = studentID;
            this.name = name;
            this.dateOfBirth = dateOfBirth;
            this.gender = gender;
            this.score = score;
        }
        //method
        public void DisplayInfor(){
            Console.WriteLine($"Student ID: {studentID}");
            Console.WriteLine($"Student Name: {name}");
            Console.WriteLine($"Date of Birth: {dateOfBirth}");
            Console.WriteLine($"Gender : {gender}");
            Console.WriteLine($"Score: {score}");
            Console.WriteLine("");
        }
    }
}