using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21004063_PhanHoangHuy
{
    internal class SV_VL
    {
        private double _cohoc;
        private double _dienhoc;
        private double _quanghoc;
        private double _vatlyhatnhan;

        public double Cohoc { get => _cohoc; set => _cohoc = value; }
        public double Dienhoc { get => _dienhoc; set => _dienhoc = value; }
        public double Quanghoc { get => _quanghoc; set => _quanghoc = value; }
        public double Vatlyhatnhan { get => _vatlyhatnhan; set => _vatlyhatnhan = value; }

        public SV_VL(double ch, double dh, double qh, double vlhn)
        {
            double _cohoc = ch;
            double _dienhoc = dh;
            double _quanghoc = qh;
            double _vatlyhan = vlhn;
        }

        public static SV_VL NhapDiem()
        {
            double ch, dh, qh, vlhn;
            do
            {
                Console.Write("nhap diem co hoc: ");
                ch = Convert.ToDouble(Console.ReadLine());
            } while (ch < 0);
            do
            {
                Console.Write("nhap diem dien hoc: ");
                dh = Convert.ToDouble(Console.ReadLine());
            } while (dh < 0);
            do
            {
                Console.Write("nhap diem quang hoc: ");
                qh = Convert.ToDouble(Console.ReadLine());
            } while (qh < 0);
            do
            {
                Console.Write("nhap diem vat ly hat nhan: ");
                vlhn = Convert.ToDouble(Console.ReadLine());
            } while (vlhn < 0);
            return new SV_VL(ch, dh, qh, vlhn);
        }

        public void InDiem()
        {
            Console.WriteLine("Diem co hoc = "+this.Cohoc);
            Console.WriteLine("Diem dien hoc = "+this.Dienhoc);
            Console.WriteLine("Diem quang hoc = "+this.Quanghoc);
            Console.WriteLine("Diem vat ly hat nhan = "+this.Vatlyhatnhan);
        }



    }
}
