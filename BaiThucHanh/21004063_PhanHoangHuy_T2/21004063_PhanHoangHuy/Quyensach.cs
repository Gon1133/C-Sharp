using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21004063_PhanHoangHuy
{
    internal class Quyensach
    {
        private string _tuasach;
        private string _tentacgia;
        private string _tennxb;
        private int _namxb;
        private int _sotrang;
        public string Tuasach { get => _tuasach; set => _tuasach = value; }
        public string Tentacgia { get => _tentacgia; set => _tentacgia = value; }
        public string Tennxb { get => _tennxb; set => _tennxb = value; }
        public int Namxb { get => _namxb; set => _namxb = value; }
        public int Sotrang { get => _sotrang; set => _sotrang = value; }

        public Quyensach(string ts, string ttg, string tnxb, int nxb, int st)
        {
            this._tuasach = ts;
            this._tentacgia = ttg;
            this._tennxb = tnxb;
            this._namxb = nxb;
            this._sotrang = st;
        }

        public static Quyensach NhapQS()
        {
            string ts,ttg,tnxb;
            do
            {
                Console.Write("nhap ten sach: ");
                ts = Console.ReadLine().Trim();
            } while (ts.Length == 0);

            do
            {
                Console.Write("nhap ten tac gia: ");
                ttg = Console.ReadLine();
            } while (ttg.Length == 0);

            do
            {
                Console.Write("nhap ten nha xuat ban: ");
                tnxb = Console.ReadLine();
            } while (tnxb.Length == 0);

            int nxb;
            do
            {
                try
                {
                    Console.Write("nhap nam xuat ban: ");
                    nxb = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {

                    
                }
            } while (true);
            int st;
            do
            {
                try
                {
                    Console.Write("nhap so trang: ");
                    st = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {

                    
                }
            } while (true);

            return new Quyensach(ts, ttg, tnxb, nxb, st);
        }

        public void InQS()
        {
            Console.Write("ten sach: ");
            Console.WriteLine(this.Tuasach);
            Console.Write("ten tac gia: ");
            Console.WriteLine(this.Tentacgia);
            Console.Write("ten nha xuat ban: ");
            Console.WriteLine(this.Tennxb);
            Console.Write("nam xuat ban: ");
            Console.WriteLine(this.Namxb);
            Console.Write("so trang: ");
            Console.WriteLine(this.Sotrang);
        }


    }
}
