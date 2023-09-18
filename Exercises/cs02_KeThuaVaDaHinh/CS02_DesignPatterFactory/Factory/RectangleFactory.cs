namespace CS02_DesignPatterFactory
{
    public class RectangleFactory : ShapeFactory
{
    private double length;
    private double width;

    public RectangleFactory(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    public override IShape CreateShape()
    {
        return new Rectangle(length, width);
    }
}
}