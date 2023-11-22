using Ex13_QuanLyBanHang;

public class Program
{
    private static void Main(string[] args)
    {
        ProductManager productManager = new ProductManager();
        InvoiceManager invoiceManager = new InvoiceManager();

        while (true)
        {
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. Display Products");
            Console.WriteLine("3. Add Invoice");
            Console.WriteLine("4. Display Invoices");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    AddProduct(productManager);
                    break;
                case "2":
                    DisplayProducts(productManager);
                    break;
                case "3":
                    AddInvoice(invoiceManager, productManager);
                    break;
                case "4":
                    DisplayInvoices(invoiceManager);
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    static void AddProduct(ProductManager productManager)
    {
        Console.Write("Enter product name: ");
        string name = Console.ReadLine();

        Console.Write("Enter product price: ");
        if (decimal.TryParse(Console.ReadLine(), out decimal price))
        {
            Product product = new Product { Name = name, Price = price };
            productManager.AddProduct(product);
            Console.WriteLine("Product added successfully.");
        }
        else
        {
            Console.WriteLine("Invalid price format. Please try again.");
        }
    }

    static void DisplayProducts(ProductManager productManager)
    {
        Console.WriteLine("Products:");
        foreach (var product in productManager.Products)
        {
            Console.WriteLine($"- {product.Name}, Price: {product.Price}");
        }
    }

    static void AddInvoice(InvoiceManager invoiceManager, ProductManager productManager)
    {
        Invoice invoice = new Invoice { Date = DateTime.Now };

        Console.Write("Enter customer name: ");
        string customerName = Console.ReadLine();
        Customer customer = new Customer { Name = customerName };
        invoice.Customer = customer;

        while (true)
        {
            DisplayProducts(productManager);
            Console.Write("Enter product ID to add to the invoice (0 to finish): ");
            if (int.TryParse(Console.ReadLine(), out int productId) && productId > 0)
            {
                Product selectedProduct = productManager.GetProductById(productId);
                if (selectedProduct != null)
                {
                    invoice.Products.Add(selectedProduct);
                    Console.WriteLine("Product added to the invoice.");
                }
                else
                {
                    Console.WriteLine("Invalid product ID. Please try again.");
                }
            }
            else if (productId == 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid product ID.");
            }
        }

        invoiceManager.AddInvoice(invoice);
        Console.WriteLine("Invoice added successfully.");
    }

    static void DisplayInvoices(InvoiceManager invoiceManager)
    {
        invoiceManager.DisplayInvoices();
    }
}
