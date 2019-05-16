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
    public partial class frm_SendProduct : Form
    {
        private BS_Block bS_Block;
        public static bool Sended = false;
        private string idBlock;

        public frm_SendProduct(string idBlock)
        {
            InitializeComponent();
            bS_Block = new BS_Block();
            this.idBlock = idBlock;
            loadId(idBlock);
        }
        // load id product
        private void loadId(string idBlock)
        {
            DataTable dataTable = bS_Block.loadIdBlock(idBlock);
            foreach (DataRow dataRow in dataTable.Rows)
            {
                cbx_IDBlock.AddItem(dataRow["IDBlock"].ToString().Trim());
            }
        }

        private void txt_Cancel_Click(object sender, EventArgs e)
        {
            Sended = false;
            this.Close();
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            Sended = true;
            sendProduct(cbx_IDBlock.selectedValue);
            this.Close();
        }

        // send product
        private void sendProduct(string id)
        {
            bS_Block.sendProduct(this.idBlock, id);
        }
    }
}
