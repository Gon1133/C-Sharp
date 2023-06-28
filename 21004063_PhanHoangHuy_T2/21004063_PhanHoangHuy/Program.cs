using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21004063_PhanHoangHuy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bai 30
            /*Console.Write("nhap ps 1: ");
            Phanso ps1 = Phanso.NhapPS();
            Console.Write("Phan so vua nhap sau khi toi gian: ");
            ps1.InPS();

            Console.Write("nhap ps 2: ");
            Phanso ps2 = Phanso.NhapPS();
            Console.Write("Phan so vua nhap sau khi toi gian: ");
            ps2.InPS();
            // d.
            Phanso.tinhtoan(ps1, ps2);
            // e.
            Console.WriteLine("\nkiem tra nap chong");
            if (ps1 < ps2)
                Console.WriteLine("ps1 > ps2");
            if (ps1 > ps2)
                Console.WriteLine("ps1 < ps2");
            if (ps1 == ps2)
                Console.WriteLine("ps1 == ps2");
            if (ps1 != ps2)
                Console.WriteLine("ps1 != ps2");    
            */

            //bai 31
            /*int n;
            do
            {
                try
                {
                    Console.Write("nhap so luong sach: ");
                    n = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    n = 0;
                }
            } while (n<=0);

            List<Quyensach> listQS = new List<Quyensach>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("nhap thong tin quyen sach thu " + (i + 1));
                Quyensach t = Quyensach.NhapQS();
                listQS.Add(t);
            }
            int d = 0;
            foreach(Quyensach i in listQS)
            {
                Console.WriteLine("thong tin quyen sach thu " + (d + 1));
                i.InQS();
                d++;
            }

            int S = 0;
            foreach(Quyensach i in listQS)
            {
                if (i.Namxb == 2013)
                    S += i.Sotrang;
            }
            Console.WriteLine("tong so trang cua cac quyen sach duoc xuat ban vao nam 2013 = "+S);

            Console.WriteLine("quyen sach co so trang nhieu nhat la: ");
            int maxST = listQS[0].Sotrang;
            foreach(Quyensach i in listQS)
                if (i.Sotrang > maxST)
                    maxST = i.Sotrang;
            for (int i = 0; i < n; i++)
                if (maxST == listQS[i].Sotrang)
                    listQS[i].InQS();

            // in tua sach, ten tac gia co so trang la P
            int P;
            do
            {
                try
                {
                    Console.Write("nhap so luong trang sach can tim: ");
                    P = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    P = 0;
                }
            } while (P <= 0);
            Console.WriteLine("cac quyen sach co so trang = {0} la:", P);
            foreach (Quyensach i in listQS)
                if (P == i.Sotrang)
                {
                    Console.WriteLine("Ten sach: "+ i.Tuasach);
                    Console.WriteLine("Ten tac gia: "+ i.Tentacgia);
                }
            */

            // bai 33
            int n;
            do
            {
                try
                {
                    Console.Write("nhap so luong sinh vien: ");
                    n = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    n = 0;
                }
            } while (n<=0);
            List<Sinhvien> SV = new List<Sinhvien>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("nhap thong tin sinh vien thu " + (i + 1));
                Sinhvien sv = Sinhvien.NhapSV();
                SV.Add(sv);
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("thong tin sinh vien thu " + (i + 1));
                SV[i].InSV();
            }


            Console.ReadLine();
        }
    }
}
