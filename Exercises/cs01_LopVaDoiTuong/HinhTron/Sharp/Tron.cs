using System.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HinhTron.Sharp
{
    public class Tron
    {

        private float banKinh;

        public float BanKinh
        {
            get { return banKinh; }
            set { banKinh = value; }
        }

        public Tron()
        {
            banKinh=0;
        }
        public Tron(float banKinh)
        {
            this.banKinh=banKinh;
        }

        public float ChuVi(){
            return banKinh*3.14f;
        }
        public float DienTich(){

            return banKinh*banKinh*3.14f;
        }
    }
}