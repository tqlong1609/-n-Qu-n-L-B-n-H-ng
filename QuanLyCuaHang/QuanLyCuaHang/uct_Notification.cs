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
    public partial class uct_Notification : UserControl
    {
        private BS_Notification bS_Notification;
        private DataTable dataTable;
        private string id;
        private int index;
        public uct_Notification()
        {
            InitializeComponent();
            bS_Notification = new BS_Notification();
            loadNotification(frm_Login.id);
        }
        // load notification from id
        private void loadNotification(string id)
        {
            dataTable = bS_Notification.loadNotification(id);
            dataGid_Notification.DataSource = dataTable;
            foreach (DataRow dataRow in dataTable.Rows)
            {
                this.id = dataRow["IDThongBao"].ToString().Trim();
            }
            dataGid_Notification.Columns["IDThongBao"].Visible = false;
        }

        private void dataGid_Notification_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string error = "";
            int index = e.RowIndex;
            if (!bS_Notification.checkState(id, ref error))
                MessageBox.Show(error);
            else
            {
                new frm_TextNotification(dataGid_Notification.Rows[index].Cells[1].Value.ToString()).ShowDialog();
                loadNotification(frm_Login.id);
            }
        }

        private void dataGid_Notification_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
        }
        // delete
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (index >= 0 && dataGid_Notification.Rows.Count > 0 && dataGid_Notification.Rows[index].Cells[0].Value.ToString() != "")
            {
                if (MessageBox.Show("Are you sure ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    string error = "";
                    if (!bS_Notification.removeNotIdNotificate(dataGid_Notification.Rows[index].Cells[0].Value.ToString(), ref error))
                        MessageBox.Show(error);
                    else
                    {
                        MessageBox.Show("Success","Notification",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        loadNotification(frm_Login.id);
                    }
                }
            }
        }
    }
}
