namespace EX02_QuanLyHinhHoc
{
    public class Circle:Shape{
        double radius;

        public double Radius { get => radius; set => radius = value; }

        public Circle(double radius,string color):base(color){
            this.radius=radius;
        }
        public override double GetArea(){
            return Math.PI*radius*radius;
        }
    }

}