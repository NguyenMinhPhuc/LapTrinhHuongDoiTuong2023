public class StudentEventArgs : EventArgs
{
    public Student Student { get; }

    public StudentEventArgs(Student student)
    {
        Student = student;
    }
}
