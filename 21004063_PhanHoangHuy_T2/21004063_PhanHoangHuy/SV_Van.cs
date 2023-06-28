using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21004063_PhanHoangHuy
{
    internal class SV_Van
    {
        private double _vanhoccodien;
        private double _vanhochiendai;

        public double Vanhoccodien { get => _vanhoccodien; set => _vanhoccodien = value; }
        public double Vanhochiendai { get => _vanhochiendai; set => _vanhochiendai = value; }

        public SV_Van(double vhcd, double vhhd) 
        {
            this._vanhochiendai= vhhd;
            this._vanhoccodien = vhcd;
        }

        public static SV_Van NhapDiem()
        {
            double vhcd, vhhd;
            do
            {
                Console.Write("nhap diem van hoc co dien: ");
                vhcd = Convert.ToDouble(Console.ReadLine());
            } while (vhcd < 0);

            do
            {
                Console.Write("nhap diem van hoc hien dai: ");
                vhhd = Convert.ToDouble(Console.ReadLine());
            } while (vhhd < 0);
            return new SV_Van(vhcd, vhhd);
        }

        public void InDiem()
        {
            Console.WriteLine("diem van hoc co dien = " + this.Vanhoccodien);
            Console.WriteLine("diem van hoc hien dai = " + this.Vanhochiendai);
        }

    }
}
