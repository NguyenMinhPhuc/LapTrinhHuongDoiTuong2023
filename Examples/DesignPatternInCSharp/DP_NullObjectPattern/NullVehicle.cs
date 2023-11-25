using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace DP_NullObjectPattern
{
    public class NullVehicle : IVehicle
    {
        private static readonly NullVehicle instance = new NullVehicle();
        public static int nullVehicleCount = 0;
        public static NullVehicle Instance
        {
            get
            {
                //Console.WriteLine("We already have an instance now.Use it.");
                return instance;
            }
        }
        public void Travel()
        {
            //Do Nothing
        }
    }
}
