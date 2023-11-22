namespace DP1_1_Singleton
{
    public sealed class Singleton
    {
        private static readonly Singleton instance = new Singleton();
        private int numberOfInstantces = 0;
        private Singleton()
        {
            Console.WriteLine("Instantiating inside the private constructor");
            Console.WriteLine($"Number of Instances = {++numberOfInstantces} ");
        }
        public static Singleton Instance
        {
            get
            {
                Console.WriteLine("we already have an instance now. Use it.");
                return instance;
            }
        }

    }
}
//Trong tài liệu còn thể hiện 2 biết thể của Singleton 