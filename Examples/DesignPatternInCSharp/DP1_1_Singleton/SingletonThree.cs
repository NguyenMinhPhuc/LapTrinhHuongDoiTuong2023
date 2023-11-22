using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP1_1_Singleton
{
    /// <summary>
    /// Trường hợp không sử dụng từ khóa seale để cô lập lớp,
    /// dùng trong trường hợp có lớp dẫn xuất lồng phía trong.
    /// </summary>
    public class SingletonThree
    {
        private static SingletonThree instance = null!;
        private int numberOfInstantces = 0;
        private SingletonThree()
        {
            Console.WriteLine("Instantiating inside the private constructor");
            Console.WriteLine($"Number of Instances = {++numberOfInstantces} ");
        }
        public static SingletonThree Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SingletonThree();
                }
                return instance;
            }
        }
        //Lớp dẫn xuất lồng phía trong của lớp singleton
        public class NestedDerived : SingletonThree { }
    }
}
