public class StudentEventHandler
{
    //sự kiện thêm
    public delegate void StudentAddedEventHandler(object sender, StudentEventArgs e);
    public event StudentAddedEventHandler StudentAdded;
    //Sự kiện update
    public delegate void StudentUpdatedEventHandler(object sender, StudentEventArgs e);
    public event StudentUpdatedEventHandler StudentUpdated;
    //Thêm sự kiện GhiLogThemSV(SinhVien sv)
    //Thêm sự kiện GuiEmailXacNhan(SinhVien sv)
    //LuuFileExcel()
    public void OnStudentAdded(Student student)
    {
        StudentAdded?.Invoke(this, new StudentEventArgs(student));
    }
    public void OnStudentUpdated(Student student)
    {
        StudentUpdated?.Invoke(this, new StudentEventArgs(student));
    }
}
