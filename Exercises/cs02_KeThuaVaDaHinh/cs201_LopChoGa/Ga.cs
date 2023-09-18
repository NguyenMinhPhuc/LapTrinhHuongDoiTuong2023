namespace cs201_LopChoGa
{
    public class Ga:DongVat
    {
        string canh;

        public string Canh { get => canh; set => canh = value; }
         public Ga(string canh,int soChan,string mauMat):base(soChan,mauMat){
            this.canh=canh;
        }
        public Ga():base(){
            this.canh=string.Empty;
        }
        //biet bay
        public void BietBay(){
            Console.Write("Biet bay");
        }
        //Vay canh
        public void VayCanh(){
            Console.Write("Vay Canh");
        }
    }
}