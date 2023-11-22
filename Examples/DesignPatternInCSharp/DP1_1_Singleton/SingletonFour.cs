using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP1_1_Singleton
{

    /// <summary>
    /// Double checked locking
    /// </summary>
    public sealed class SingletonFour
    {
        private static volatile SingletonFour instance = null!;
        private static object lockObject = new object();
        private SingletonFour()
        {
            Console.WriteLine("Instantiating inside the private constructor");

        }
        public static SingletonFour Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObject)
                    {
                        if (instance == null)
                        {
                            instance = new SingletonFour();
                        }
                    }
                }
                return instance;
            }
        }
    }
}
