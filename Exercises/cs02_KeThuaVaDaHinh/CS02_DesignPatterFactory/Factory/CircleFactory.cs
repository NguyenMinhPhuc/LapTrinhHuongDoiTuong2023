namespace CS02_DesignPatterFactory
{
    public class CircleFactory : ShapeFactory
    {
        private double radius;

        public CircleFactory(double radius)
        {
            this.radius = radius;
        }

        public override IShape CreateShape()
        {
            return new Circle(radius);
        }
    }
}