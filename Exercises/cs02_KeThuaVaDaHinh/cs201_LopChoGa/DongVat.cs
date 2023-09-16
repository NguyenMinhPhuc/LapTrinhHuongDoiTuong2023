namespace cs201_LopChoGa
{
    public class DongVat{
        int chan;//số chân
        string mat;//màu Mắt

        public int Chan { get => chan; set => chan = value; }
        public string Mat { get => mat; set => mat = value; }

        //method
        //Nhap đong vât
        public void Nhap(){
            Console.Write("Nhap so chan mau mat");
        }
        //Xuat
        public void Xuat(){
            Console.Write($"Dong vat co so chan: {chan} va mau mat : {mat}");
        }
        //chay
        public void Chay(){
            Console.Write("Biet chay");
        }
        //Ngu
        public void Ngu(){
            Console.Write("Biet ngu");
        }
        //Construtor
        public DongVat(int soChan,string mauMat)
        {
            this.chan=soChan;
            this.mat=mauMat;
        }

        public DongVat(){
            chan=0;
            mat=string.Empty;
        }
    }
}