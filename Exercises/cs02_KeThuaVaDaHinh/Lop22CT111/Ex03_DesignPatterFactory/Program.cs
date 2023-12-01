internal class Program
{
    private static void Main(string[] args)
    {
        MainFactory factory = new MainFactory("Square");


        IShape shape = factory.CreateShape();

    }
}