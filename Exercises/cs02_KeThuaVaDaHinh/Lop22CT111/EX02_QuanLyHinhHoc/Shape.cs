namespace EX02_QuanLyHinhHoc
{
    public class Shape{
        string color;
        public string Color { get => color; set => color = value; }

        public Shape(string color)
        {
            this.color=color;
        }

        public virtual double GetArea(){
            return 0;
        }
    }

}