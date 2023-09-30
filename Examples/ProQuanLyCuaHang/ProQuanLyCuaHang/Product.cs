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

        }
        public virtual void OutputProduct()
        {

        }
    }
}
