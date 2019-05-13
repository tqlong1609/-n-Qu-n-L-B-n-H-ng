using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHang
{
    public partial class uct_SellProduct : UserControl
    {
        public uct_SellProduct()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            frm_AddCustomer temp = new frm_AddCustomer();
            temp.ShowDialog();
        }
    }
}
