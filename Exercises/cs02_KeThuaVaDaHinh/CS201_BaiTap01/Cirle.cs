namespace CS201_BaiTap01
{
    public class Circle:Shape
    {
        double banKinh;

        public double BanKinh { get => banKinh; set => banKinh = value; }

        public Circle(double banKinh,string mauSac):base(mauSac){
            this.banKinh=banKinh;
        }
        public Circle():base(){
            this.BanKinh=0;
        }

        public override double GetArea()
        {
            return Math.PI.banKinh*banKinh;
        }
    }
}