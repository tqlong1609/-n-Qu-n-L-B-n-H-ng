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
    }
}
