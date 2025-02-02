﻿using QuanLyCuaHang.BS_layer;
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

        #region contrustor
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
            loadDataFromId(id);
            mode = Mode.repaid;
            btn_Find.Text = "Repaid";
        }
        #endregion

        #region load
        // load data from id
        private void loadDataFromId(string id)
        {
            DataTable dataTable = bS_Customer.loadDataFromId(id);
            foreach (DataRow dataRow in dataTable.Rows)
            {
                txt_Id.Text = id;
                txt_Name.Text = dataRow["Name"].ToString();
                txt_Phone.Text = dataRow["phoneNumber"].ToString();
                txt_Address.Text = dataRow["Address"].ToString();
                if (dataRow["gender"].ToString().Trim().Equals("True"))
                {
                    ckBx_Female.Checked = true;
                    ckbx_Male.Checked = false;
                }
                else
                {
                    ckbx_Male.Checked = true;
                    ckBx_Female.Checked = false;
                }
            }
        }
        // load id customer
        private void loadId()
        {
            string id = bS_Customer.loadId();
            txt_Id.Text = id;
        }
        #endregion

        #region handle
        // add/repaid
        private void btn_Find_Click(object sender, EventArgs e)
        {
            // add
            if (mode == Mode.add)
            {
                if (!isEmpty())
                {
                    string error = "";
                    if (bS_Customer.addCustomer(txt_Id.Text, txt_Name.Text, txt_Phone.Text, txt_Address.Text, isFemale(), ref error))
                    {
                        MessageBox.Show("Success", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        isUpdate = true;
                        this.Close();
                    }
                    else MessageBox.Show(error);
                }
                else { MessageBox.Show("Values does not empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            else // repaid
            {
                if (!isEmpty())
                {
                    string error = "";
                    if (bS_Customer.repaidCustomer(txt_Id.Text, txt_Name.Text, txt_Phone.Text, txt_Address.Text, isFemale(), ref error))
                    {
                        MessageBox.Show("Success", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        isUpdate = true;
                        this.Close();
                    }
                    else MessageBox.Show(error);
                }
                else { MessageBox.Show("Values does not empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
        }
        #endregion

        #region check
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
        #endregion

        private void ckbx_Male_OnChange(object sender, EventArgs e)
        {
            ckBx_Female.Checked = false;
        }

        private void ckBx_Female_OnChange(object sender, EventArgs e)
        {
            ckbx_Male.Checked = false;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
