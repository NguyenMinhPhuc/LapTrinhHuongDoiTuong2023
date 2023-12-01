namespace Ex03_DesignPatterFactory
{
    public class CircleFactory:ShapeFactory{

        public override IShape CreateShape(){
            return new Circle();
        }
    }
}
