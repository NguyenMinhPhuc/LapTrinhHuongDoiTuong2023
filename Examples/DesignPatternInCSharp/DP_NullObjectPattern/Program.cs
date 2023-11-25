using DP_NullObjectPattern;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("***Null Object Pattern Demo***\n");
        string input = String.Empty;
        int totalObjects = 0;
        while (true)
        {
            Console.WriteLine("Enter your choice( Type 'a' for Bus, 'b' for Train.Type 'exit' to quit) ");
            input = Console.ReadLine()!;
            IVehicle vehicle = null!;
            switch (input)
            {
                case "a":
                    vehicle = new Bus();
                    break;
                case "b":
                    vehicle = new Train();
                    break;
                case "exit":
                    Console.WriteLine("Closing the application");
                    vehicle = NullVehicle.Instance;
                    return;
                default:
                    vehicle = NullVehicle.Instance;
                    break;
            }
            totalObjects = Bus.busCount + Train.trainCount + NullVehicle.nullVehicleCount;

            vehicle.Travel();

            Console.WriteLine("Total objects created in the system ={0}", totalObjects);
        }

    }
}