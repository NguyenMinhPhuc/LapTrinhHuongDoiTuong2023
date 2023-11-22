using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13_QuanLyBanHang
{
    public class ProductManager
    {
        public List<Product> Products { get; set; } = new List<Product>();

        public void AddProduct(Product product)
        {
            product.ProductId = Products.Count + 1;
            Products.Add(product);
        }

        public Product GetProductById(int productId)
        {
            return Products.Find(p => p.ProductId == productId);
        }
    }
}
