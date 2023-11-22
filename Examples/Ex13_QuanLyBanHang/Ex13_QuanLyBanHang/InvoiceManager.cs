using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13_QuanLyBanHang
{
    public class InvoiceManager
    {
        public List<Invoice> Invoices { get; set; } = new List<Invoice>();

        public void AddInvoice(Invoice invoice)
        {
            invoice.InvoiceId = Invoices.Count + 1;
            Invoices.Add(invoice);
        }

        public void DisplayInvoices()
        {
            foreach (var invoice in Invoices)
            {
                Console.WriteLine($"Invoice ID: {invoice.InvoiceId}, Date: {invoice.Date}, Customer: {invoice.Customer.Name}");
                Console.WriteLine("Products:");
                foreach (var product in invoice.Products)
                {
                    Console.WriteLine($"  - {product.Name}, Price: {product.Price}");
                }
                Console.WriteLine("---------------------------");
            }
        }
    }
}
