using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCuaHang.BS_layer;

namespace QuanLyCuaHang
{
    public partial class uct_Customer : UserControl
    {
        private BS_Customer bS_Customer;

        public uct_Customer()
        {
            InitializeComponent();
            bS_Customer = new BS_Customer();
            loadData();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            frm_AddCustomer temp = new frm_AddCustomer();
            temp.ShowDialog();
        }

        // load data all
        private void loadData()
        {
            dataGid_Customer.DataSource = bS_Customer.loadDataAll();
        }

        private void dataGid_Customer_MouseDown(object sender, MouseEventArgs e)
        {
            if (frm_AddCustomer.isUpdate)
                loadData();
        }
    }
}
