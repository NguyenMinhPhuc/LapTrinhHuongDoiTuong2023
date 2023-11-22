using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP1_3_BuilderPattern.VD1
{
    internal class ConcreteBuilder : IBuilder
    {
        private Product product = new Product();

        public void BuildPart1()
        {
            product.Part1 = "Part1";
        }

        public void BuildPart2()
        {
            product.Part2 = "Part2";
        }

        public void BuildPart3()
        {
            product.Part3 = "Part3";
        }

        public Product GetResult()
        {
            return product;
        }
    }
}
