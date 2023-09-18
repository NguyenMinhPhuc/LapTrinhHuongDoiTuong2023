namespace Ex03_DesignPatterFactory
{
    public class Rectangle:IShape{
        double width;
        double height;

        public double CalculateArea(){
            return width*height;
        }
    }
}