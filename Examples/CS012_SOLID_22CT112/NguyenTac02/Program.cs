namespace NguyenTac02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ILamBaoCao lamBaoCao = new BaoCaoPDF();
            lamBaoCao.SinhBaoCao();
        }
    }
}