using EX02_QuanLyHinhHoc;
internal class Program
{
    private static void Main(string[] args)
    {
        List<Shape> list = new List<Shape>();

        Shape shape = new Circle(5, "Red");
        list.Add(shape);
        shape = new Rectangle(5, 8, "Red");
        list.Add(shape);
        Console.WriteLine($"Dien tich hinh tron {list[0].GetArea()}");
         Console.WriteLine($"Dien tich hinh chu nhat {list[1].GetArea()}"); ;
    }
}