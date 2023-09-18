namespace Ex03_DesignPatterFactory
{
    public class Tangle:IShape{
        double height;
        double side;

        public double CalculateArea(){
            return height*side;
        }
    }
}