namespace CS02_DesignPatterFactory
{
    public class SquareFactory : ShapeFactory
    {
        private double side;

        public SquareFactory(double side)
        {
            this.side = side;
        }

        public override IShape CreateShape()
        {
            return new Square(side);
        }
    }
}