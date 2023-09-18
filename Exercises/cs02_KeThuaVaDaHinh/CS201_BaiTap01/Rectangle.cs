namespace CS201_BaiTap01
{
    public class Rectangle : Shape
    {
        double chieuRong,chieuDai;

        public double ChieuRong { get => chieuRong; set => chieuRong = value; }
        public double ChieuDai { get => chieuDai; set => chieuDai = value; }

        public Rectangle(double chieuRong,double chieuDai,string mauSac):base(mauSac){
            this.chieuDai=chieuDai;
            this.chieuRong=chieuRong;
        }
        public override double GetArea()
        {
            return chieuDai*chieuRong;
        }
    }
}