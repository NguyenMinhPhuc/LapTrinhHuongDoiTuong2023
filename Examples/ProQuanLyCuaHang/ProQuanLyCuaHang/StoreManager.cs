using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProQuanLyCuaHang
{
    internal class StoreManager
    {
        List<Product> products;

        public StoreManager()
        {
            products = new List<Product>();
        }

        //Add product
        public void AddProduct()
        {
            Product product;
            while (true)
            {
                Console.Write("Nhap san pham nao: (E/C): ");
                string option = Console.ReadLine();
                if (option.ToLower().Equals("e"))
                {
                    product = new ElectronicsProduct();
                }
                else if (option.ToLower().Equals("c"))
                {
                    product = new ClothingProduct();

                }
                else { break; }
                product.InputProduct();
                products.Add(product);
            }
            Console.WriteLine("Hoan thanh qua trinh nhap san pham");
        }
        //Update Product
        public void UpdateProduct(string productID)
        {
            Product productUpdate = null;
            foreach (Product product in products)
            {
                if (product.ProID.Equals(productID))
                {
                    productUpdate = product;
                    break;
                }
            }
            if (productUpdate != null)
            {
                Console.WriteLine($"Chinh sua product {productID}");

                Console.Write("Product Name: ");
                productUpdate.ProName = Console.ReadLine();
                Console.Write("Price: ");
                productUpdate.Price = Convert.ToInt32(Console.ReadLine());

                Console.Write("Quantity: ");
                productUpdate.Quantity = Convert.ToInt32(Console.ReadLine());
                if (productUpdate is ElectronicsProduct)
                {
                    Console.Write("Hang sx: ");
                    ((ElectronicsProduct)productUpdate).Brand = Console.ReadLine();
                }
                else if (productUpdate is ClothingProduct)
                {
                    Console.Write("Size: ");
                    ((ClothingProduct)productUpdate).Size = Console.ReadLine();
                }
                productUpdate.OutputProduct();
            }

        }
        //Remove Product
        public bool RemoveProduct(string productID)
        {
            Product productRemove;
            foreach (Product product in products)
            {
                if (product.ProID.Equals(productID))
                {
                    productRemove = product;
                    products.Remove(productRemove);
                    return true;
                }
            }
            return false;
        }
        //Print Products
        public void PrintProduct()
        {
            foreach (Product product in products)
            {
                product.OutputProduct();
            }
        }
        //Search Prouct by ID
        public Product SearchByID(string productID)
        {
            Product productSearch = null;
            foreach (Product product in products)
            {
                if (product.ProID.Equals(productID))
                { productSearch = product; break; }

            }
            return productSearch;
        }
        //Search product by name

        public List<Product> SearchByName(string productName)
        {
            List<Product> productsSearch = new List<Product>();

            foreach (Product product in products)
            {
                if (product.ProName.Equals(productName))
                {
                    productsSearch.Add(product);
                }

            }
            return productsSearch;
        }
    }
}
