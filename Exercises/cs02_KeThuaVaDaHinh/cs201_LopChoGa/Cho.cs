namespace cs201_LopChoGa
{
    public class Cho : DongVat
    {
        string duoi;

        public string Duoi { get => duoi; set => duoi = value; }
        //Constructor
        public Cho(string duoi,int soChan,string mauMat):base(soChan,mauMat){
            this.duoi=duoi;
        }

        public Cho():base(){
            this.duoi=string.Empty;
        }
        //method
        public string BietSua()
        {
            string tiengSua = "go go";
            return tiengSua;
        }
        public new void Xuat(){
            base.Xuat();
            Console.Write($" dong vat nay co Duoi {duoi}");
        }
        public bool BietVayDuoi(string hinhDang)
        {
            if (hinhDang =="dai")
            {
                return true;
            }
            return false;
        }
    }
}