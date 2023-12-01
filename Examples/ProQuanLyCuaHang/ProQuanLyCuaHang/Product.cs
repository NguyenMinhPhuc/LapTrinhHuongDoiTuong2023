using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProQuanLyCuaHang
{
    internal class Product
    {
        //field
        string proID, proName;
        int price, quantity;
        //properties
        public string ProID { get => proID; set => proID = value; }
        public string ProName { get => proName; set => proName = value; }
        public int Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }

        //constructor

        //method
        public virtual void InputProduct()
        {
            Console.WriteLine("Nhap san pham");
            Console.Write("Product ID: ");
            proID = Console.ReadLine();

            Console.Write("Product Name: ");
            proName = Console.ReadLine();

            Console.Write("Price: ");
            price = Convert.ToInt32(Console.ReadLine());

            Console.Write("Quantity: ");
            quantity = Convert.ToInt32(Console.ReadLine());

        }
        public virtual void OutputProduct()
        {
            Console.WriteLine($" Product ID: {proID}");
            Console.WriteLine($" Product Name: {proName}");
            Console.WriteLine($" price: {price}");
            Console.WriteLine($" quantity:  {quantity}");
        }
    }
}
