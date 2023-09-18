namespace EX01_QuanLyChoGa
{
    public class Cho:DongVat{
        //field
        double doDaiDuoi;
        public Cho():base(){
            doDaiDuoi=0.0;
        }

        public Cho(double doDaiDuoi,int soChan,string mauMat):base(soChan,mauMat){
            this.doDaiDuoi=doDaiDuoi;
        }
        public override void Nhap(){
            base.Nhap();
            Console.Write("Nhap do dai duoi");
            doDaiDuoi=Convert.ToDouble(Console.ReadLine());
        }
        public bool BietSua()
        {
            return true;
        }
        public bool BietVayDuoi(double doDaiDuoi){
            if( doDaiDuoi>1){
                return true;
            }
            return false;
        }
    }
}