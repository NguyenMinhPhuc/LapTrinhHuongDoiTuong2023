using ProQuanLyCuaHang;

internal class Program
{
    private static void Main(string[] args)
    {
        StoreManager storeManager = new StoreManager();
        storeManager.AddProduct();
        storeManager.UpdateProduct("p001");

        storeManager.PrintProduct();
    }
}