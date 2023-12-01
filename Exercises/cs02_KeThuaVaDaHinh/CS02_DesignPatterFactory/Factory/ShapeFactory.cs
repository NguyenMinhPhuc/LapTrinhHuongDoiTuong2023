namespace CS02_DesignPatterFactory
{
    public abstract class ShapeFactory
    {
        public IShape CreateShape();
        public abstract IShape CreateShape(string shapeName);
    }
}