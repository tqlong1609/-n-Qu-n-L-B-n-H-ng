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
    public partial class uct_History : UserControl
    {
        private BS_History bS_History;
        private int index = 0;

        public uct_History()
        {
            InitializeComponent();
            bS_History = new BS_History();
            loadData();
        }
        // load data
        private void loadData()
        {
            dataGid_History.DataSource = bS_History.loadData();
        }

        private void dataGid_History_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string id;
            if (index >= 0 && dataGid_History.Rows.Count > 0 &&
                (id = dataGid_History.Rows[index].Cells[0].Value.ToString()) != "")
            {
                string error = "";
                if (!bS_History.deleteHoaDon(id, ref error))
                    MessageBox.Show(error);
                else
                {
                    MessageBox.Show("Delete success","Notification",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    loadData();
                }
            }
        }

        private void txt_Search_OnValueChanged(object sender, EventArgs e)
        {
            if (txt_Search.Text != "")
            {
                dataGid_History.DataSource = bS_History.searchHoaDon(txt_Search.Text.Trim().ToLower());
            }
            else
            {
                loadData();
            }
        }
    }
}
