using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenTac02
{
    internal class TaoBaoCao
    {
        int kieuBaoCao;

        public int KieuBaoCao { get => kieuBaoCao; set => kieuBaoCao = value; }

        public void SinhBaoCao(int kieuBaoCao)
        {
            if (kieuBaoCao == 1)
                Console.WriteLine("Tao bao cao Excel");
            if (kieuBaoCao == 2)
                Console.WriteLine("Tao bao cao bang PDF");
            if (kieuBaoCao == 3)
                Console.WriteLine("Tao bao cao bang Power BI");
        }
    }
}
