using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21004063_PhanHoangHuy_T8
{
    public partial class frm_Bophan : Form
    {
        public frm_Bophan()
        {
            InitializeComponent();
        }

        private void frm_Bophan_Load(object sender, EventArgs e)
        {
            LINQConnection conn = new LINQConnection();
            var dsBophan = conn.db.Bophans;
            dgv_bophan.DataSource = from bp in dsBophan select new { bp.MSBophan, bp.TenBophan };
            dgv_bophan.AutoGenerateColumns = false;
        }
    }
}
