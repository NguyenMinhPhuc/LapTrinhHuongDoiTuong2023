using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP1_1_Singleton
{
    /// <summary>
    /// trường hợp này chúng ta khai báo instance nhưng không khởi tạo
    /// khi nào cần tạo instance lần đầu tiên thì sẽ khởi tạo
    /// </summary>
    public sealed class SingletonTypeTwo
    {
        private static SingletonTypeTwo instance = null!;
        private int numberOfInstantces = 0;
        private SingletonTypeTwo()
        {
            Console.WriteLine("Instantiating inside the private constructor");
            Console.WriteLine($"Number of Instances = {++numberOfInstantces} ");
        }
        public static SingletonTypeTwo Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SingletonTypeTwo();
                }
                return instance;
            }
        }
    }
}
