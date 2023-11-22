using DP1_1_Singleton;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Demo Singleton Pattern");
        Console.WriteLine("try to create instance S1");
        Singleton s1 = Singleton.Instance;
        Singleton s2 = Singleton.Instance;
        if (s1 == s2)
        {
            Console.WriteLine("Only on instance exits");
        }
        else
        {
            Console.WriteLine("Different instances exist.");
        }
        Console.ReadLine();
    }
}