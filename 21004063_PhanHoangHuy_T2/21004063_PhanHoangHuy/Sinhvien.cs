using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21004063_PhanHoangHuy
{
    internal class Sinhvien
    {
        private string _hoten;
        private string _chuyennganh;
        private double _diemtrungbinh;

        public string Hoten { get => _hoten; set => _hoten = value; }
        public string Chuyennganh { get => _chuyennganh; set => _chuyennganh = value; }
        public double Diemtrungbinh { get => _diemtrungbinh; set => _diemtrungbinh = value; }

        public Sinhvien(string ht, string cn, double dtb)
        {
            this._hoten = ht;
            this._chuyennganh = cn;
            this._diemtrungbinh = dtb;
        }

        public Sinhvien()
        {
            this._hoten = "";
            this._chuyennganh = "";
            this._diemtrungbinh = 0;
        }

        public static Sinhvien NhapSV()
        {
            string ht, cn;
            do
            {
                Console.Write("nhap ten sinh vien: ");
                ht = Console.ReadLine().Trim();
            } while (ht.Length == 0);
            do
            {
                Console.Write("nhap chuyen nganh dao tao (1: Cong Nghe Thong Tin; 2: Vat ly; 3: Van): ");
                cn = Console.ReadLine().Trim();
            } while (cn != "1" && cn != "2" && cn != "3");
            double dtb=0;
            if (cn == "1")
            {
                cn = "Cong Nghe Thong Tin";
                SV_CNTT t = SV_CNTT.NhapDiem();
                dtb = (t.Cs + t.Pascal + t.Sql)/3;
            }
            
            if (cn == "2")
            {
                cn = "Vat Ly";
                SV_VL t = SV_VL.NhapDiem();
                dtb = (t.Cohoc + t.Quanghoc + t.Dienhoc + t.Vatlyhatnhan) / 4;
            }
            if (cn == "3")
            {
                cn = "Van";
                SV_Van t = SV_Van.NhapDiem();
                dtb = (t.Vanhochiendai + t.Vanhoccodien) / 2;
            }

            return new Sinhvien(ht,cn,dtb);
        }

        public void InSV()
        {
            Console.WriteLine("Ho ten sinh vien: "+ this.Hoten);
            Console.WriteLine("Chuyen nganh dao tao: "+ this.Chuyennganh);
            Console.WriteLine("Diem trung binh: "+ this.Diemtrungbinh);
        }






    }
}
