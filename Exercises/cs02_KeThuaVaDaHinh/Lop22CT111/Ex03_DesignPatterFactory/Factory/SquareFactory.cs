namespace Ex03_DesignPatterFactory
{
    public class SquareFactory:ShapeFactory{

        public override IShape CreateShape(){
            return new Square();
        }
    }
}