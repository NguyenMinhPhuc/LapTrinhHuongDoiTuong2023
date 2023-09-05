using System;
using System.Collections.Generic;

public class Student
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