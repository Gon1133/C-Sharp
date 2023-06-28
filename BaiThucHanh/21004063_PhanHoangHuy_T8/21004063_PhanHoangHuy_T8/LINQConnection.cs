using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21004063_PhanHoangHuy_T8
{
    internal class LINQConnection
    {
        public static string strConn = @"Data Source=HUYPR0V1P;Initial Catalog=QLNS_HUY;User ID=sa; pwd = 123456";
        private QLNS_HUYDataContext _db = new QLNS_HUYDataContext(strConn);
        public QLNS_HUYDataContext db { get { return _db; } }

    }

}
