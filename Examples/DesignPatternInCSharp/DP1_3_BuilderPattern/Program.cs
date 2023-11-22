//using DP1_3_BuilderPattern.VD1;
using DP1_3_BuilderPattern.VD2;

internal class Program
{
    private static void Main(string[] args)
    {
        // Tạo một đối tượng Director
        //Director director = new Director();

        //// Sử dụng ConcreteBuilder để xây dựng đối tượng
        //IBuilder builder = new ConcreteBuilder();
        //Product product = director.Construct(builder);

        //// Hiển thị thông tin về đối tượng đã xây dựng
        //Console.WriteLine(product);
        //------------------------------------------------------------
        Console.WriteLine("***Builder Pattern Demo***");
        Director director = new Director();
        IBuilder b1 = new Car("Ford");
        IBuilder b2 = new MotorCycle("Honda");
        // Making Car
        director.Construct(b1);
        Product p1 = b1.GetVehicle();
        p1.Show();
        //Making MotorCycle
        director.Construct(b2);
        Product p2 = b2.GetVehicle();
        p2.Show();
        Console.ReadLine();
    }
}