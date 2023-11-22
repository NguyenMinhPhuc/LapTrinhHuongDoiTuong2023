using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyHinhHoc
{
    internal class Circle : IShape
    {
        double radius;
        public double CaculateArea()
        {
            return Math.PI * 2 * radius;
        }
    }
}
