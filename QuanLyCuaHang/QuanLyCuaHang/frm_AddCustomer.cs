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
    public partial class frm_AddCustomer : Form
    {
        private BS_Customer bS_Customer;
        private Mode mode;
        public static bool isUpdate = false;

        private enum Mode { add, repaid};

        // constructor add
        public frm_AddCustomer()
        {
            InitializeComponent();
            bS_Customer = new BS_Customer();
            ckbx_Male.Checked = true;
            ckBx_Female.Checked = false;
            loadId();
            mode = Mode.add;
        }
        // constructor repaid
        public frm_AddCustomer(string id)
        {
            InitializeComponent();
            bS_Customer = new BS_Customer();
            ckbx_Male.Checked = true;
            ckBx_Female.Checked = false;
            mode = Mode.repaid;
        }
        // load id customer
        private void loadId()
        {
            string id = bS_Customer.loadId();
            txt_Id.Text = id;
        }
        // add/repaid
        private void btn_Find_Click(object sender, EventArgs e)
        {
            // add
            if (mode == Mode.add)
            {
                if (!isEmpty())
                {
                    int numPhone;
                    if (int.TryParse(txt_Phone.Text, out numPhone))
                    {
                        string error = "";
                        if (bS_Customer.addCustomer(txt_Id.Text, txt_Name.Text, numPhone, txt_Address.Text, isFemale(), ref error))
                        {
                            MessageBox.Show("Success", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            isUpdate = true;
                            this.Close();
                        }
                        else MessageBox.Show(error);
                    }
                    else { MessageBox.Show("Phone number is not string","Error",MessageBoxButtons.OK,MessageBoxIcon.Error); txt_Phone.Text = ""; txt_Phone.Focus(); }
                }
                else { MessageBox.Show("Values does not empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            else // repaid
            {
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // check male/female
        private bool isFemale()
        {
            if (ckbx_Male.Checked) return false;
            return true;
        }
        // check empty values input
        private bool isEmpty()
        {
            if (txt_Name.Text == "" || txt_Id.Text == "" || txt_Phone.Text == "" || txt_Address.Text == "")
                return true;
            return false;
        }

        private void ckbx_Male_OnChange(object sender, EventArgs e)
        {
            ckBx_Female.Checked = false;
        }

        private void ckBx_Female_OnChange(object sender, EventArgs e)
        {
            ckbx_Male.Checked = false;
        }
    }
}
