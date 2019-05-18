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
    public partial class uct_Employee : UserControl
    {
        private BS_Employee bS_Employee;
        private BS_Notification bS_Notification;
        private DataTable data;
        private int index ;
        private string error;
        public static Employee employee;

        public enum Employee { salesman, both, warehouse}

        public uct_Employee()
        {
            InitializeComponent();
            bS_Employee = new BS_Employee();
            bS_Notification = new BS_Notification();
            loadDataSalesman();
            employee = Employee.salesman;
        }

        #region load
        // load data both
        private void loadDataBoth()
        {
            data = bS_Employee.loadDataEmployee();
            dataGrid_Employee.DataSource = data;
            employee = Employee.both;
        }
        // load data salesman
        private void loadDataSalesman()
        {
            data = bS_Employee.loadDataSalesMan();
            dataGrid_Employee.DataSource = data;
            employee = Employee.salesman;
        }
        // load data warehouse staff
        private void loadDataWareHouseStaff()
        {
            data = bS_Employee.loadDataWareHouseStaff();
            dataGrid_Employee.DataSource = data;
            employee = Employee.warehouse;
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            frm_AddEmployee temp = new frm_AddEmployee();
            temp.ShowDialog();
        }
        // data sale man
        private void btn_SalesMan_Click(object sender, EventArgs e)
        {
            loadDataSalesman();
        }
        // data both staff
        private void btn_Both_Click(object sender, EventArgs e)
        {
            loadDataBoth();
        }
        // data wore house staff
        private void btn_WareHouseStaff_Click(object sender, EventArgs e)
        {
            loadDataWareHouseStaff();
        }
        #endregion

        #region handle
        private void dataGrid_Employee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
        }
        // repaid
        private void btn_Repair_Click(object sender, EventArgs e)
        {
            if (index >= 0 && dataGrid_Employee.Rows.Count > 0)
            {
                frm_AddEmployee temp = new frm_AddEmployee(dataGrid_Employee.Rows[index].Cells[0].Value.ToString());
                temp.ShowDialog();
            }
        }

        private void bunifuMetroTextbox3_OnValueChanged(object sender, EventArgs e)
        {
            if (txt_search.Text != "")
            {
                dataGrid_Employee.DataSource = bS_Employee.searchEmployee(txt_search.Text.Trim());
            }
            else
            {
                checkLoadEmployee();
            }
        }

        private void btn_Notification_Click(object sender, EventArgs e)
        {
            new frm_SendNotification().ShowDialog();
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (index >= 0 &&  dataGrid_Employee.Rows.Count > 0)
            {
                try
                {
                    if (MessageBox.Show("Are you sure", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        == DialogResult.Yes)
                    {
                        bS_Notification.removeNotIdEmployee(dataGrid_Employee.Rows[index].Cells[0].Value.ToString(), ref error);
                        bS_Employee.deleteEmployee(dataGrid_Employee.Rows[index].Cells[0].Value.ToString(), ref error);
                        MessageBox.Show("Remove success", "Congratuation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        checkLoadEmployee();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show(error);
                }
            }
        }
        #endregion

        // check load employee
        public void checkLoadEmployee()
        {
            switch (employee)
            {
                case Employee.salesman:
                    loadDataSalesman();
                    break;
                case Employee.both:
                    loadDataBoth();
                    break;
                case Employee.warehouse:
                    loadDataWareHouseStaff();
                    break;
            }
        }
        
    }
}
