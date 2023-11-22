using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenTac5
{
    internal class Email : IMessager
    {
        public void SendMessager()
        {
            Console.WriteLine("send Messager");
        }
    }
}
