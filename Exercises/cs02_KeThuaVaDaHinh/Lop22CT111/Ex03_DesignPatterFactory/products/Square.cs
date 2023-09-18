namespace Ex03_DesignPatterFactory
{
    public class Square:IShape{
        double side;
        public double CalculateArea(){
            return side*side;
        }
    }
}