namespace pro_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string err = string.Empty;
            Documents a = new Documents();
            a.Read(ref err, "");
            a.Write("", "");
            a.Status = true;

            IStorable b = new Documents();
            b.Write("", "");
            b.Status = false;
            b.Read(ref err, "");


        }
    }
}