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
    public partial class uct_Block : UserControl
    {
        private BS_Block bS_Block;
        private int index = 0;
        public uct_Block()
        {
            InitializeComponent();
            bS_Block = new BS_Block();
            loadAmount();
            loadData();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            frm_AddBlock temp = new frm_AddBlock();
            temp.ShowDialog();
        }
        #region load
        // load Data Block
        private void loadData()
        {
            dataGrid_Block.DataSource = bS_Block.loadData();
        }
        // load amount product
        private void loadAmount()
        {
            DataTable dataAmount = bS_Block.loadAmountProduct();
            DataTable dataBlock = bS_Block.loadData();
            foreach (DataRow dataRow in dataBlock.Rows)
            {
                foreach (DataRow dataRow2 in dataAmount.Rows)
                {
                    if (dataRow2["IDBlock"].ToString().Trim().Equals(dataRow["IDBlock"].ToString().Trim()))
                    {
                        bS_Block.updateAmount(dataRow2["AmountProduct"].ToString().Trim(), dataRow2["IDBlock"].ToString().Trim());
                    }
                }
            }
        }
        #endregion

        #region handle
        private void dataGrid_Block_MouseDown(object sender, MouseEventArgs e)
        {
            if (frm_AddBlock.isUpdate)
            {
                loadAmount();
                loadData();
                frm_AddBlock.isUpdate = false;
            }
        }
        // delete
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string idBlock;
            int amount; 
            if (index >= 0 && dataGrid_Block.Rows.Count > 0 
                && (idBlock = dataGrid_Block.Rows[index].Cells[0].Value.ToString()) != "")
            {
                if (MessageBox.Show("Are you Sure", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                    == DialogResult.Yes)
                {
                    if (int.TryParse(dataGrid_Block.Rows[index].Cells[2].Value.ToString(), out amount) && amount > 0)
                    {
                        new frm_SendProduct(idBlock).ShowDialog();
                        if (frm_SendProduct.Sended)
                        {
                            bS_Block.deleteBlock(idBlock);
                            loadAmount();
                            loadData();
                        }
                        else MessageBox.Show("You doesn't choose any block", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        bS_Block.deleteBlock(idBlock);
                        loadAmount();
                        loadData();
                    }
                }
            }
        }

        private void dataGrid_Block_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
        }
        // repaid
        private void btn_Repair_Click(object sender, EventArgs e)
        {
            string idBlock;
            if (index >= 0 && dataGrid_Block.Rows.Count > 0
                && (idBlock = dataGrid_Block.Rows[index].Cells[0].Value.ToString()) != "") {
                frm_AddBlock temp = new frm_AddBlock(idBlock);
                temp.ShowDialog();
            }
        }
        // search
        private void txt_Search_OnValueChanged(object sender, EventArgs e)
        {
            if (txt_Search.Text != "")
            {
                dataGrid_Block.DataSource = bS_Block.searchBlock(txt_Search.Text.Trim().ToLower());
            }
            else
            {
                loadData();
            }
        }
        #endregion
    }
}
