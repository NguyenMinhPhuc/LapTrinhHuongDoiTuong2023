using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP1_3_BuilderPattern.VD1
{
    public class Product
    {
        public string Part1 { get; set; }
        public string Part2 { get; set; }
        public string Part3 { get; set; }

        public override string ToString()
        {
            return $"Product - Part1: {Part1}, Part2: {Part2}, Part3: {Part3}";
        }
    }
}
