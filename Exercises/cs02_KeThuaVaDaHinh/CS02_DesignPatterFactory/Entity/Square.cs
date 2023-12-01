namespace CS02_DesignPatterFactory
{
    public class Square : IShape
    {
        private double side;

        public Square(double side)
        {
            this.side = side;
        }

        public double CalculateArea()
        {
            return side * side;
        }

    }
}
