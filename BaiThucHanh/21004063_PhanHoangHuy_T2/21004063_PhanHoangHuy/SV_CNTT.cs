using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21004063_PhanHoangHuy
{
    internal class SV_CNTT : Sinhvien
    {
        private double _pascal;
        private double _cs;
        private double _sql;

        public double Pascal { get => _pascal; set => _pascal = value; }
        public double Cs { get => _cs; set => _cs = value; }
        public double Sql { get => _sql; set => _sql = value; }

        public SV_CNTT(double pc, double cs, double sql)
        {
            this._pascal = pc;
            this._cs = cs;
            this._sql = sql;
        }

        public static SV_CNTT NhapDiem()
        {
            double ps, cs, sql;
            do
            {
                Console.Write("nhap diem Pascal: ");
                ps = Convert.ToDouble(Console.ReadLine());
            } while (ps < 0);
            do
            {
                Console.Write("nhap diem C#: ");
                cs = Convert.ToDouble(Console.ReadLine());
            } while (cs < 0);
            do
            {
                Console.Write("nhap diem SQL: ");
                sql = Convert.ToDouble(Console.ReadLine());
            } while (sql < 0);
            return new SV_CNTT(ps, cs, sql);
        }

        public void InDiem()
        {
            Console.WriteLine("Diem Pascal = "+this.Pascal);
            Console.WriteLine("Diem C# = "+this.Cs);
            Console.WriteLine("Diem SQL = "+this.Sql);
        }
        


    }
}
