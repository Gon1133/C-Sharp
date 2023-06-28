using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LapTrinhDotNet
{
    internal class Program
    {

        static void bai1()
        {
            int x = 0;
            for (x = 1; x < 10; x++)
                System.Console.Write("{0:3}\n", x);
        }

        static void bai2()
        {
            int x = 0;
            for (x = 1; x < 10; x++)
                System.Console.Write("{0:03}", x);

            for (int i = 0; i < 10; i++)
                System.Console.WriteLine("so :{0}", i);
        }

        static void bai3()
        {
            double myDouble;
            decimal myDecimal;
            myDouble = 3.14;
            myDecimal = 3.14m;
            Console.WriteLine("My Double: {0}", myDouble);
            Console.WriteLine("My Decimal: {0}", myDecimal);
        }

        static void bai4()
        {
            int value = 1000;
            if (value > 100) ;
            System.Console.WriteLine("Number is greater than 100");
            Console.ReadLine();
        }
        static void bai5()
        {
            int a, b, c;
            Console.WriteLine("Nhap 3 canh tam giac: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            if ((a + b) > c && (a + c) > b && (b + c) > a && a > 0 && b > 0 && c > 0)
                Console.WriteLine("3 canh la do dai cua tam giac");
            else Console.WriteLine("3 canh khong phai do dai tam giac");
        }

        static void bai6()
        {
            int n;
            // a)
            do
            {
                Console.Write("a) nhap n: ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n < 0);

            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            // b)
            do
            {
                Console.Write("b) nhap n: ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n < 0);

            for (int i = 0; i <= n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    Console.Write("$ ");
                }
                Console.WriteLine();
            }
            // c)
            do
            {
                Console.Write("b) nhap n: ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n < 0);

            for (int i = 0; i <= n; i++)
            {
                for (int k = i; k < n; k++)
                {
                    Console.Write(' ');
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        static void bai7()
        {
            double dcb, dnc;
            do
            {
                Console.Write("nhap diem co ban: ");
                dcb = Convert.ToDouble(Console.ReadLine());
            } while (dcb < 0);
            do
            {
                Console.Write("nhap diem nang cao: ");
                dnc = Convert.ToDouble(Console.ReadLine());
            } while (dnc < 0);

            double dtb = (dcb + dnc) / 2;
            Console.WriteLine(dtb);
            if (dtb >= 9)
                Console.WriteLine("xuat sac");
            else if (dtb >= 8 && dcb >= 7 && dnc >= 7)
                Console.WriteLine("gioi");
            else if (dtb >= 7 && dcb >= 6 && dnc >= 6)
                Console.WriteLine("kha");
            else if (dtb >= 5 && dcb >= 3 && dnc >= 3)
                Console.WriteLine("trung binh");
            else Console.WriteLine("khong dat");
        }
        static void bai9()
        {
            for (char n = '0'; n <= '9'; n++)
                Console.WriteLine("'{0}' : {1}", n, (int)n);
            for (char s = 'a'; s <= 'z'; s++)
                Console.WriteLine("'{0}' : {1}", s, (int)s);
        }

        static void bai12()
        {
            // cv, dt hinh thang
            float d1, d2 = 100 / 12, c1, c2;
            do
            {
                Console.Write("nhap 2 canh day: ");
                d1 = Convert.ToSingle(Console.ReadLine());
                d2 = Convert.ToSingle(Console.ReadLine());
                Console.Write("nhap 2 canh ben: ");
                c1 = Convert.ToSingle(Console.ReadLine());
                c2 = Convert.ToSingle(Console.ReadLine());
            } while (d1 <= 0 || d2 <= 0 || c1 <= 0 || c2 <= 0);
            double cv = d1 + d2 + c1 + c2;
            double cc = c1 * c1 - Math.Pow(c1 * c1 / d2, 2);
            double dt = cc * (d1 + d2) / 2;
            Console.WriteLine("chieu cao hinh thang: {0}", cc);
            Console.WriteLine("chu vi hinh thang: {0}", cv);
            Console.WriteLine("dien tich hinh thang: {0}", dt);
        }

        static void bai13()
        {
            int n;
            double S = 0;
            do
            {
                Console.Write("nhap n: ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n <= 0);
            for (int i = 1; i < n; i++)
            {
                S = S + (double)(i / (i + 1));
            }
            Console.WriteLine("Tong S = {0}", S);
        }

        static void bai16()
        {
            int n, m;
            long S = 0;
            do
            {
                Console.Write("nhap n: ");
                n = Convert.ToInt32(Console.ReadLine());
                Console.Write("nhap m: ");
                m = Convert.ToInt32(Console.ReadLine());
            } while (n <= 0 || m <= 0);
            for (int i = 1; i <= n; i++)
                for (int j = 1; j <= m; j++)
                    S = S + (i + 2 * j);
            Console.WriteLine("Tong S = {0}", S);
        }

        /*static void bai19()
        {
            int i, j, k, l;
            for (i=1; i<=10; i++)
            {
                for (k=i; k<=10; k++)
                    Console.Write(' ');
                for (j=i; j<=10; j++)
                {
                    int t = i * 2;
                    if (i * 2 >= 10)
                        t = (i * 2) % 10;
                    if (j == t)
                    {
                        break;
                    }
                    else
                    {
                        if (j == 10)
                        {
                            j = 0;
                        }
                        Console.Write("{0} ", j);
                    }
                }
                for (l=j-1; l<i; l--)
                {
                    if (l < 0)
                        l = 9;
                    Console.Write("{0} ", l);
                }
                Console.WriteLine();
        }*/


        /*static int bai22(int n)
        {
            int n;
            do
            {
                Console.Write("nhap n: ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n <= 0);

            Console.WriteLine(bai22(n));

            if (n == 1 || n == 2) return 1;
            else return bai22(n - 1) + bai22(n - 2);

            
        }*/

        public static bool KTNgto(int n)
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        public static void bai23()
        {
            int n;
            Console.Write("nhap so luong ptu: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n]; // khởi tạo mạng arr có n ptu

            // nhập mảng
            for (int i = 0; i < n; i++)
            {
                Console.Write("[{0}] = ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            // xuất mảng ngược
            for (int i = n - 1; i >= 0; i--)
                Console.Write("{0} ", arr[i]);
            /*foreach (int i in arr)
                Console.Write("{0} ", i);*/
            Console.WriteLine();

            // đếm các ptu là số ngto
            int d = 0;
            foreach (int i in arr)
                if (KTNgto(i))
                    d++;
            Console.WriteLine("co {0} so ngto trong mang", d);
        }

        static void bai24()
        {
            int n;
            Console.Write("nhap n: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            // nhap mang
            for (int i = 0; i < n; i++)
            {
                Console.Write("[{0}] = ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            // xuat mang
            foreach (int i in arr)
                Console.Write("{0} ", i);
            Console.WriteLine();
            // vi tri cac ptu lon nhat
            int max = arr[0];
            foreach (int i in arr)
                if (max < i)
                    max = i;
            Console.Write("vi tri cac ptu lon nhat la: ");
            for (int i = 0; i < n; i++)
                if (max == arr[i])
                    Console.Write("{0} ", i);
            Console.WriteLine();
            // trung binh cac ptu duong
            double tb;
            long S = 0;
            int d = 0;
            foreach (int i in arr)
                if (i > 0)
                {
                    S += i;
                    d++;
                }
            tb = S / d;
            Console.WriteLine("gia tri trung binh cac ptu duong = {0}", tb);
            // dem so ptu la luy thua cua K
            int K;
            d = 0;
            Console.Write("nhap K: ");
            K = Convert.ToInt32(Console.ReadLine());
            foreach (int i in arr)
                if (Math.Log(i, K) == (int)Math.Log(i, K))
                {
                    //Console.WriteLine(Math.Log(i,K));
                    d++;
                }
            Console.WriteLine("co {0} ptu la luy thua cua K", d);
        }

        static void bai26()
        {
            int n, m;
            Console.Write("Nhap so hang: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so cot: ");
            m = Convert.ToInt32(Console.ReadLine());
            float[,] arr = new float[n, m];
            // nhap mang
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    Console.Write("[{0},{1}] = ", i, j);
                    arr[i, j] = Convert.ToSingle(Console.ReadLine());
                }
            // xuat mang
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0} ", arr[i, j]);
                }
                Console.WriteLine();
            }
            // dem cai ptu nguyen chan    
            int d = 0;
            foreach (int i in arr)
                if ((int)i % 2 == 0)
                    d++;
            Console.WriteLine("co {0} ptu co phan nguyen la chan", d);
            // tinh tich ptu duong tren hang h
            int h;
            double M = 1;
            Console.Write("Nhap h: ");
            h = Convert.ToInt32(Console.ReadLine());
            for (int j = 0; j < m; j++)
                if (arr[h, j] % 2 == 0)
                    M = M * arr[h, j];
            Console.WriteLine("Tich tren hang h = {0}", M);
            // sap xep cot c tang dan
            int c;
            Console.Write("Nhap c: ");
            c = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
                if (arr[i, c] > arr[i + 1, c])
                {
                    float t = arr[i, c];
                    arr[i, c] = arr[i + 1, c];
                    arr[i + 1, c] = t;
                }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0} ", arr[i, j]);
                }
                Console.WriteLine();
            }
        }
        public static void InMT(char[,] arr, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0} ", arr[i, j]);
                }
                Console.WriteLine();
            }
        }

        static void bai27()
        {
            int n;
            Console.Write("Nhap n: ");
            n = Convert.ToInt32(Console.ReadLine());
            char[,] arr = new char[n, n];
            // nhap mang
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    Console.Write("[{0},{1}] = ", i, j);
                    arr[i, j] = Convert.ToChar(Console.ReadLine());
                }

            // xuat mang
            InMT(arr, n, n);

            // co bao nhieu ky tu 'T' trong mang
            int d = 0;
            foreach (char i in arr)
                if (i == 'T')
                    //if (i.Contains('T'))
                    d++;
            Console.WriteLine("co {0} ky tu T trong mang", d);

            // in cac ptu nam tren duong cheo phu
            Console.Write("cac ptu nam tren duong cheo phu: ");
            for (int i = 0; i < n; i++)
                Console.Write("{0} ", arr[i, n - i - 1]);
            Console.WriteLine();

            // ky tu lon nhat nam tren duong cheo chinh
            Console.Write("ptu nam tren duong cheo chinh: ");
            /*for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    if (i == j)
                        Console.Write("{0} ", arr[i, j]);
            Console.WriteLine();*/

            // chi ma tran vuong moi lam dc
            for (int i = 0; i < n; i++)
                Console.Write("{0} ", arr[i, i]);
            Console.WriteLine();

            // ky tu lon nhat tren duong cheo chinh
            char maxchar = arr[0, 0];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    if (i == j)
                        if (arr[i, j] > maxchar)
                            maxchar = arr[i, j];
            Console.WriteLine("Ky tu lon nhat tren duong cheo chinh la: " + maxchar);

            // co hang nao co thu tu tang dan hay ko
            bool HangGiam = true;
            for (int i = 0; i < n; i++)
            {
                bool Giam = true;
                for (int j = 1; j < n; j++)
                    if (arr[i, j] <= arr[i, j - 1])
                    {
                        Giam = false;
                        break;
                    }
                if (!Giam)
                {
                    HangGiam = false;
                    break;
                }
            }
            if (HangGiam)
                Console.WriteLine("Ma tran co hang co thu tu tang dan.");
            else
                Console.WriteLine("Ma tran khong co hang co thu tu tang dan.");
        }

        static void bai29()
        {
            int n;
            Console.Write("Nhap n: ");
            n = int.Parse(Console.ReadLine());
            int[][] pascal = new int[n][];

            // khoi tao mang tam giac pascal
            for (int i = 0; i < n; i++)
                pascal[i] = new int[i + 1];

            // tinh gia tri cac ptu trong pascal
            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || j == i)
                        pascal[i][j] = 1;
                    else
                        pascal[i][j] = pascal[i - 1][j - 1] + pascal[i - 1][j];
                }
            }
            // in ra tam giac pascal
            for (int i = 0; i < n; i++)
            {
                for (int k = i; k < n; k++)
                    Console.Write(" ");
                for (int j = 0; j <= i; j++)
                    Console.Write("{0} ", pascal[i][j]);
                Console.WriteLine();
            }
        }

        // bai 30

        class PhanSo
        {
            //fields
            private int x;
            private int y;

            //constructors
            public PhanSo()
            {
                Console.Write("nhap x: ");
                this.x = Convert.ToInt32(Console.ReadLine());
                Console.Write("nhap y: ");
                this.y = Convert.ToInt32(Console.ReadLine());
            }



            //b
            public int UCLN(int a, int b)
            {
                /*int max = Math.Max(a, b);
                int min = Math.Min(a, b);
                if (min == 1)
                    return 1;
                while (min != 1)
                {
                    if (max % min == 0)
                        return min;
                    else
                        max = max - min;
                }
                return 1;*/
                while (b != 0)
                {
                    int r = a % b;
                    a = b;
                    b = r;
                }
                return a;
            }
            public void ToiGian()
            {
                int a = this.x;
                int b = this.y;
                if (UCLN(a, b) == 1)
                    Console.Write("phan so da toi gian: ");
                else
                {
                    this.x = (this.x / UCLN(a, b));
                    this.y = (this.y / UCLN(a, b));
                    Console.Write("phan so sau khi toi gian: ");
                }

            }

            //c
            public void Output()
            {
                Console.WriteLine("{0}/{1}", this.x, this.y);
            }

            //d
            public static void tinhtoan(PhanSo a, PhanSo b)
            {
                Console.WriteLine("nhap phep toan: ");
                char t = Convert.ToChar(Console.ReadLine());
                switch (t)
                {
                    case '+': Console.WriteLine("{0} + {1} = {2}/{3}" + (a.x*b.y + a.y*b.x), a, b); 
                        break;
                    case '-': Console.WriteLine("{0} - {1} = " + (a.x * b.y - a.y * b.x), a, b); 
                        break;
                    case '*': Console.WriteLine("{0} * {1} = " + (a.x * b.x), a, b); 
                        break;
                    case '/': Console.WriteLine("{0} / {1} = " + (a.x * b.y + a.y * b.x), a, b);
                        break;
                    default:
                        Console.WriteLine("phep toan khong hop le"); break;
                }


            }



        }









        public static void Main(string[] args)
        {
            PhanSo ps1 = new PhanSo();
            Console.Write("phan so vua nhap la: ");
            ps1.Output();
            ps1.ToiGian();
            ps1.Output();
            PhanSo ps2 = new PhanSo();

            PhanSo.tinhtoan(ps1, ps2);
            Console.ReadLine();


        }




    
    }
}
