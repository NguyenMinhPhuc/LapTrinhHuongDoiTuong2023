namespace EX01_QuanLyChoGa
{
    public class Ga : DongVat
    {
        //field
        bool coCanh;
        public Ga():base(){
            coCanh=false;
        }

        public Ga(bool coCanh,int soChan,string mauMat):base(soChan,mauMat){
            this.coCanh=coCanh;
        }
        public bool BietBay()
        {
            if (coCanh)
                return true;
            return false;
        }
        public void VayCanh()
        {
            if (coCanh)
                Console.Write("Biet vay canh");
            else
                Console.Write("Khong biet vay canh");
        }


    }

}