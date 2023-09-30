using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProQuanLyCuaHang
{
    internal class ElectronicsProduct : Product
    {
        string brand;

        public string Brand { get => brand; set => brand = value; }
        public ElectronicsProduct() : base() { }

        public override void InputProduct()
        {
            base.InputProduct();
            //Them
            Console.Write("brand: ");
            brand = Console.ReadLine();
        }
        public override void OutputProduct()
        {
            base.OutputProduct();
            //them
            Console.WriteLine($"brand: {brand}");
        }
    }
}
