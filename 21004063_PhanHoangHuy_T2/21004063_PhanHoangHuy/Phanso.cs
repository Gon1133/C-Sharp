using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21004063_PhanHoangHuy
{
    internal class Phanso
    {
        //fied
        private int Tuso;
        private int Mauso;

        //property
        public int tuso { get => Tuso; set => Tuso = value; }
        public int mauso { get => Mauso; set => Mauso = value; }

        public Phanso(int tu, int mau)
        {
            this.Tuso = tu;
            this.Mauso = mau;
        }
        // a. phuong thuc nhap 1 ps bat ky
        public static Phanso NhapPS()
        {
            int tu;
            int mau;
            do
            {
                try
                {
                    Console.Write("\ntu so = ");
                    tu = Convert.ToInt32(Console.ReadLine());
                    do
                    {
                        Console.Write("mau so = ");
                        mau = Convert.ToInt32(Console.ReadLine());
                    } while (mau==0);
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Ban nhap sai.");
                    //throw;
                }
                
            } while (true);
            return new Phanso(tu, mau);
        }
        
        

        // b. 
        // phuong thuc UCLN
        public static int UCLN(int a, int b)
        {
            if (b == 0)
                return a;
            return UCLN(b, a % b);
        }

        // kiem tra ps toi gian hay chua
        public static Phanso KtTG(Phanso a)
        {
            if (UCLN(a.tuso, a.mauso) == 1)
                return new Phanso(a.tuso, a.mauso);
            else
            {
                a.tuso = a.tuso / UCLN(a.tuso, a.mauso);
                a.mauso = a.mauso / UCLN(a.tuso, a.mauso);
                return new Phanso(a.tuso, a.mauso);
            }
        }

        // c. 
        // phuong thuc in ps theo dung dang
        public void InPS()
        {
            Phanso t = Phanso.KtTG(this);
            if (t.mauso < 0)
            {
                t.tuso = t.tuso * -1;
                t.mauso = t.mauso * -1;
            }
            if (t.mauso == 1)
                Console.WriteLine("{0}", t.tuso);
            else 
                Console.WriteLine("{0}/{1}", t.tuso, t.mauso);
        }

        // d.
        // phuong thuc tinh toan
        public static void tinhtoan(Phanso a, Phanso b) 
        {
            char pt;
            Phanso kq = new Phanso(0,0);
            do
            {
                try
                {
                    Console.Write("Nhap phep toan: ");
                    pt = Convert.ToChar(Console.ReadLine());
                    
                }
                catch (Exception)
                {

                    throw;
                }
            } while (pt != '+' && pt != '-' && pt != '*' && pt != '/');

            switch (pt)
            {
                case '+':
                    
                    Console.Write("tong 2 phan so = ");
                    kq = new Phanso(a.tuso*b.mauso+b.Tuso*a.mauso,a.mauso*b.mauso); break;
                case '-':
                    
                    Console.Write("hieu 2 phan so = ");
                    kq = new Phanso(a.tuso * b.mauso - b.Tuso * a.mauso, a.mauso * b.mauso); break;
                case '*':
                    
                    Console.Write("tich 2 phan so = ");
                    kq = new Phanso(a.tuso * b.tuso, a.mauso * b.mauso); break;
                case '/':
                    
                    Console.Write("thuong 2 phan so = ");
                    kq = new Phanso(a.tuso * b.mauso, b.Tuso * a.mauso); break;
            }
            kq.InPS();
        }
        public static bool operator <(Phanso a, Phanso b)
        {
            if (a.tuso * b.mauso - b.Tuso * a.mauso < 0)
                return true;
            else return false;
        }
        public static bool operator >(Phanso a, Phanso b)
        {
            if (a.tuso * b.mauso - b.Tuso * a.mauso > 0)
                return true;
            else return false;
        }
        public static bool operator ==(Phanso a, Phanso b)
        {
            KtTG(a); KtTG(b);
            if (a.tuso == b.tuso && b.mauso == a.mauso)
                return true;
            else return false;
        }
        public static bool operator !=(Phanso a, Phanso b)
        {
            KtTG(a); KtTG(b);
            if (a.tuso != b.tuso || b.mauso != a.mauso)
                return true;
            else return false;
        }




    }
}
