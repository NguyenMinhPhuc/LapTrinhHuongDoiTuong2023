namespace CS02_DesignPatterFactory
{
    public class MainShapeFactory : ShapeFactory
    {
        IShape shape = null;

        public IShape Shape { get => shape; set => shape = value; }

        public override IShape CreateShape(string shapeName)
        {
            IShape shape;
            switch (shapeName)
            {
                case "Circle":
                    shape = Circle(5);
                    break;
                case "Square":
                    shape = Square(5);
                    break;
                case "Rectangle":
                    shape = Rectangle(5,8);
                    break;
            }
            this.shape=shape;
            return shape;
        }
    }
}