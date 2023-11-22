namespace QuanLyVehicle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle1 = new Car();
            Vehicle vehicle2 = new MotorCycle();

            vehicle1.StartEngine();
            vehicle2.StartEngine();
        }
    }
}