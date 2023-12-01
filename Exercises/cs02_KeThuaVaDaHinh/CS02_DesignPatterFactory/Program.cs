using CS02_DesignPatterFactory;
internal class Program
{
    private static void Main(string[] args)
    {
        string shapeName="Circle";
        ShapeFactory factory = new MainShapeFactory();
        IShape shape = factory.CreateShape(shapeName);
        Console.WriteLine($"Area of {shapeName}: " + shape.CalculateArea());


    }
}