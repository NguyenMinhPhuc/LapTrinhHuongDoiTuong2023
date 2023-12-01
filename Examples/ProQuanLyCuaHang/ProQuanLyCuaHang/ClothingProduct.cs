using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProQuanLyCuaHang
{
    internal class ClothingProduct : Product
    {
        string size;

        public string Size { get => size; set => size = value; }

        public ClothingProduct() : base() { }

        public override void InputProduct()
        {
            base.InputProduct();
            //them
            Console.Write("Size: ");
            size = Console.ReadLine();
        }

        public override void OutputProduct()
        {
            base.OutputProduct();
            //them
            Console.WriteLine($"Size: {size}");
        }
    }
}
