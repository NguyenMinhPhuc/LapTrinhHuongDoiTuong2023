namespace CS201_BaiTap01
{
    public class Shape{
        string color;

        public string Color { get => color; set => color = value; }

        public Shape(){
            color=string.Empty;
        }
        public Shape(string color){
            this.color=color;
        }

        public virtual double GetArea(){
            return 0;
        }
    }
}