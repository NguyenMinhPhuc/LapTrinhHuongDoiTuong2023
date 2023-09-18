namespace EX02_QuanLyHinhHoc
{
    public class Rectangle:Shape{
        double width;
        double height;

        public double Width { get => width; set => width = value; }
        public double Height { get => height; set => height = value; }

        public Rectangle(double width,double height,string color):base(color){
            this.width=width;
            this.height=height;
        }

        public override double GetArea(){
            return width*height;
        }
    }

}