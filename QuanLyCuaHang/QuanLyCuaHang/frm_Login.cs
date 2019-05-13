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
    public partial class frm_Login : Form
    {
        public static string id;
        private BS_Employee employee;

        public frm_Login()
        {
            InitializeComponent();
            employee = new BS_Employee();
        }
        // exit
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult temp_close = MessageBox.Show("Do you want to exit ?", "Warning !!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (temp_close == DialogResult.Yes) Application.Exit();
        }
        // login account
        private void btn_Login_Click(object sender, EventArgs e)
        {
            string position = "";
            bool isRight =
                employee.checkAccount(tbx_UserName.Text, btn_Password.Text, ref position);
            if (isRight)
            {
                id = tbx_UserName.Text;
                switch (position)
                {
                    case "admin":
                        frm_Main frm_Main = new frm_Main();
                        frm_Main.ShowDialog();
                        this.Show();
                        break;
                    case "employee":
                        frm_MainEmployee temp_main = new frm_MainEmployee();
                        temp_main.ShowDialog();
                        this.Show();
                        break;
                    case "warehouse":
                        frm_MainWarehouseStaff frm_warehouse = new frm_MainWarehouseStaff();
                        frm_warehouse.ShowDialog();
                        this.Show();
                        break;
                }
            }
            else
            {
                MessageBox.Show("User name or password not true","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }
    }
}
