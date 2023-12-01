namespace EX01_QuanLyChoGa
{
    public class DongVat
    {
        //field
        int soChan;
        string mauMat;
        public DongVat(){
            soChan=0;
            mauMat=string.Empty;
        }
        public DongVat(int soChan,string mauMat){
            this.soChan=soChan;
            this.mauMat=mauMat;
        }
        //Method
        public virtual void Nhap()
        {
            Console.Write("Nhap so chan: ");
            soChan = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap mau mat: ");
            mauMat = Console.ReadLine();
        }
        public void Xuat(){
            Console.WriteLine($"Dong vat co {soChan} chan va mau mat la mau {mauMat}");
        }
        public void BietChay()
        {
            Console.Write("Biet Chay");
        }

        public void BietNgu()
        {
            Console.Write("Biet Ngu");
        }
    }
}