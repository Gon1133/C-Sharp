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
    public partial class frm_dsSanpham : Form
    {
        public frm_dsSanpham()
        {
            InitializeComponent();
        }

        private void sanPhamBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sanPhamBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLBH_HUYDataSet);

        }

        private void frm_dsSanpham_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBH_HUYDataSet.SanPham' table. You can move, or remove it, as needed.
            this.sanPhamTableAdapter.Fill(this.qLBH_HUYDataSet.SanPham);

        }
    }
}
