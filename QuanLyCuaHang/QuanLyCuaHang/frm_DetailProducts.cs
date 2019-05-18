using QuanLyCuaHang.BS_layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHang
{
    public partial class frm_DetailProducts : Form
    {
        private BS_Products bS_Product;
        private int index;

        public frm_DetailProducts()
        {
            InitializeComponent();
            bS_Product = new BS_Products();
            loadData();
        }
        #region load
        // load data when handle
        private void dataGid_Detail_MouseDown(object sender, MouseEventArgs e)
        {
            if (frm_AddDetailProducts.isUpdate)
            {
                loadData();
                frm_AddDetailProducts.isUpdate = false;
            }
        }
        // load data product detail
        private void loadData()
        {
            dataGid_Detail.DataSource = bS_Product.loadDataProductDetail();
            index = 0;
        }
        #endregion

        #region handle
        // minisize
        private void btn_Minisize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        // exit
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult temp_close = MessageBox.Show("Do you want to logout ?", "Warning !!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (temp_close == DialogResult.Yes) this.Close();
        }
        // add
        private void btn_Add_Click(object sender, EventArgs e)
        {
            new frm_AddDetailProducts().ShowDialog();
        }
        private void dataGid_Detail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
        }
        // delete
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (index >= 0 && dataGid_Detail.Rows.Count > 0 && dataGid_Detail.Rows[index].Cells[0].Value.ToString() != "")
            {
                if (MessageBox.Show("Are you sure ? ", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    string error = "";
                    if (!bS_Product.removeDetailProduct(dataGid_Detail.Rows[index].Cells[0].Value.ToString(),
                        ref error))
                    {
                        MessageBox.Show(error);
                    }
                    else
                    {
                        MessageBox.Show("Remove Success", "Congratuation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadData();
                    }
                }
            }
        }
        // repair
        private void btn_Repair_Click(object sender, EventArgs e)
        {
            if (index >= 0 && dataGid_Detail.Rows.Count > 0 && dataGid_Detail.Rows[index].Cells[0].Value.ToString() != "")
            {
                new frm_AddDetailProducts(dataGid_Detail.Rows[index].Cells[0].Value.ToString()).ShowDialog();
            }
        }
        // search
        private void txt_Search_OnValueChanged(object sender, EventArgs e)
        {
            if (txt_Search.Text != "")
            {
                dataGid_Detail.DataSource = bS_Product.searchProductDetail(txt_Search.Text.Trim());
            }
            else
            {
                loadData();
            }
        }
        #endregion
    }
}
