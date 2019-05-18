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
    public partial class frm_SendNotification : Form
    {
        private BS_Employee bS_Employee;
        private BS_Notification bS_Notification;
        public frm_SendNotification()
        {
            InitializeComponent();
            bS_Employee = new BS_Employee();
            bS_Notification = new BS_Notification();
            loadIdEmployee();
        }
        // load id employee
        private void loadIdEmployee()
        {
            DataTable dataTable = bS_Employee.loadIdEmployee(frm_Login.id);
            foreach (DataRow dataRow in dataTable.Rows)
            {
                cbx_idEmployee.AddItem(dataRow["IDNhanVien"].ToString().Trim());
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Minisize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            if (cbx_idEmployee.selectedIndex != -1)
            {
                string error = "";
                if (bS_Notification.sendNotification(cbx_idEmployee.selectedValue, txt_Text.Text, ref error))
                    MessageBox.Show("Send success","Notification",MessageBoxButtons.OK,MessageBoxIcon.Information);
                else
                    MessageBox.Show("Send fail", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Request choose id employee before send notification", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
