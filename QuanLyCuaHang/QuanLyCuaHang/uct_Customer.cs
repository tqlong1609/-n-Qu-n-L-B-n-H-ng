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
        private int index = 0;

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
        // delete
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (index >= 0 && dataGid_Customer.Rows.Count > 0 && dataGid_Customer.Rows[index].Cells[0].Value.ToString() != "")
            {
                if (MessageBox.Show("Are you sure", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    string error = "";
                    if (bS_Customer.deleteCustomer(dataGid_Customer.Rows[index].Cells[0].Value.ToString(), ref error))
                    {
                        MessageBox.Show("Success", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadData();
                    }
                    else MessageBox.Show("Fail","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void dataGid_Customer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
        }

        private void btn_Repair_Click(object sender, EventArgs e)
        {
            if (index >= 0 && dataGid_Customer.Rows.Count > 0 && dataGid_Customer.Rows[index].Cells[0].Value.ToString() != "")
            {
                new frm_AddCustomer(dataGid_Customer.Rows[index].Cells[0].Value.ToString()).ShowDialog();
            }
        }
    }
}
