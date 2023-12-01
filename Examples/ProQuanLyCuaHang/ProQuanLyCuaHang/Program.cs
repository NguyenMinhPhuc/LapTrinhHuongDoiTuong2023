using ProQuanLyCuaHang;
using ProQuanLyCuaHang.Commons;
using ProQuanLyCuaHang.DataStorage;

internal class Program
{
    private static void Main(string[] args)
    {
        int chon = 0;
        StoreManager storeManager = new StoreManager();
        while (true)
        {
            chon = Menu();
            switch (chon)
            {
                case 1://Nhap san pham
                    storeManager.AddProduct();
                    break;
                case 2://in danh sach
                    storeManager.PrintProduct();
                    break;
                case 3:
                    string proID;
                    Console.Write("Nhap MaSP can tim: ");
                    proID = Console.ReadLine();
                    Product product = storeManager.SearchByID(proID);
                    if (product != null)
                        product.OutputProduct();
                    else
                        Console.WriteLine($"Khong tim thay {proID}");
                    break;
                case 4://tim kiem theo ten
                    string proName;
                    Console.Write("Nhap MaSP can tim: ");
                    proName = Console.ReadLine();
                    List<Product> products = storeManager.SearchByName(proName);
                    if (products.Count > 0)
                    {
                        foreach (Product p in products)
                        {
                            p.OutputProduct();
                        }
                    }
                    else
                        Console.WriteLine($"Khong tim thay {proName}");
                    break;

                case 5:
                    string proIDUpdate;
                    Console.Write("Nhap MaSP can Sua: ");
                    proIDUpdate = Console.ReadLine();
                    storeManager.UpdateProduct(proIDUpdate);
                    break;
                case 6:
                    string proIDDelete;
                    Console.Write("Nhap MaSP can Xoa: ");
                    proIDDelete = Console.ReadLine();
                    storeManager.RemoveProduct(proIDDelete);
                    break;
                case 7:
                    ProductStorageFactory productStorageFactory = new ProductStorageFactory();
                    string path = "";
                    productStorageFactory.CreateStorage(EFileName.TXT);
                    productStorageFactory.FileType.Write(path, storeManager.Products);
                    break;
                case 8:
                    return;

            }
        }
    }
    private static int Menu()
    {
        int chon = 0;
        Console.WriteLine("1. Nhap san pham");
        Console.WriteLine("2. in danh sach san pham");
        Console.WriteLine("3. tim kiem theo masp");
        Console.WriteLine("4. tim kiem theo ten sp");
        Console.WriteLine("5. sua ten sp theo id");
        Console.WriteLine("6. Xoa ten sp theo id");
        Console.WriteLine("7. Luu danh sach vao file");
        Console.WriteLine("8. Thoat chuong trinh");
        Console.Write("Chon chuc nang: ");
        chon = Convert.ToInt32(Console.ReadLine());
        return chon;
    }

}