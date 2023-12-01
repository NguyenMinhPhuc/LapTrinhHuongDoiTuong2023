namespace Ex03_DesignPatterFactory
{

    public class MainFactory : ShapeFactory
    {
        IShape shape = null;
    public MainFactory(string shapeName){
        this.shapeName=shapeName;
    }
        public IShape shape { get => shape; set => shape = value; }
        public string ShapeName { get => shapeName; set => shapeName = value; }

        string shapeName = string.Empty;
        public IShape CreateShape()
        {
            switch (shapeName)
            {
                case "Circle":
                shape=new Circle();
                    break;
                     case "Square":
                shape=new Square();
                    break;
                     case "Rectangle":
                shape=new Rectangle();
                    break;
                     case "Tangle":
                shape=new Tangle();
                    break;
            }
        }
    }




}