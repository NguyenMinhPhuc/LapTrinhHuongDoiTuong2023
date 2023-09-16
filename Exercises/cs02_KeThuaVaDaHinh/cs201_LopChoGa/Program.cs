using cs201_LopChoGa;
internal class Program
{
    private static void Main(string[] args)
    {
        Cho cho=new Cho();
        cho.Chan=4;
        cho.Mat="Den";

        Ga ga=new Ga();
        ga.Chan=2;
        ga.Mat="Do";

        cho.Xuat();

        ga.Xuat();

        Console.ReadLine();

    }
}