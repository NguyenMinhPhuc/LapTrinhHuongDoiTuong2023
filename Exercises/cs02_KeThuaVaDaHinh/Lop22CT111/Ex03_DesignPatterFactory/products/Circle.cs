namespace Ex03_DesignPatterFactory
{
    public class Circle:IShape{
        double radius;

        public double CalculateArea(){
            return Math.PI*radius*radius;
        }
    }
}