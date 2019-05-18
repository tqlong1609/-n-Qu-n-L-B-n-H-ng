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
    public partial class frm_GiftCode : Form
    {
        private BS_Gift bS_Gift;
        private Mode mode;
        private int index = 0;
        private string id;

        private enum Mode { add, repaid, nomal, confirm};

        public frm_GiftCode()
        {
            InitializeComponent();
            mode = Mode.nomal;
            btn_Cancel.Enabled = false;
            bS_Gift = new BS_Gift();
            Enable();
            loadData();
            loadValueRepaid();
        }
        // enable
        private void Enable()
        {
            txt_id.Enabled = false;
            txt_discount.Enabled = false;
        }
        // unenable
        private void UnEnable()
        {
            txt_id.Enabled = true;
            txt_discount.Enabled = true;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Minisize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // load data
        private void loadData()
        {
            dataGid_Gift.DataSource = bS_Gift.loadData();
            if (dataGid_Gift.Rows.Count >= 7)
                btn_Discount.Location = new Point(242-9, btn_Discount.Location.Y);
            else
                btn_Discount.Location = new Point(242, btn_Discount.Location.Y);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (mode == Mode.nomal)
                mode = Mode.add;
            if (mode == Mode.confirm)
            {
                // check empty value
                if (txt_discount.Text == "" || txt_id.Text == "")
                    MessageBox.Show("Values does not empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    int discount;
                    // check value string
                    if (int.TryParse(txt_discount.Text, out discount))
                    {
                        // check exist id
                        if (!bS_Gift.isEsixt(txt_id.Text))
                        {
                            string error = "";
                            if (bS_Gift.addGift(txt_id.Text, discount, ref error))
                            {
                                mode = Mode.nomal;
                                Enable();
                                btn_Add.LabelText = "Add";
                                btn_Repair.Enabled = true;
                                btn_Delete.Enabled = true;
                                btn_Cancel.Enabled = false;
                                loadData();
                                MessageBox.Show("Add success", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                                MessageBox.Show(error);
                        }
                        else
                        {
                            txt_id.Text = "";
                            txt_id.Focus();
                            MessageBox.Show("ID Code haved esixted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("discount not string", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_discount.Text = "";
                        txt_discount.Focus();
                    }
                }
            }
            if (mode == Mode.add)
            {
                UnEnable();
                btn_Add.LabelText = "Confirm";
                mode = Mode.confirm;
                btn_Repair.Enabled = false;
                btn_Delete.Enabled = false;
                btn_Cancel.Enabled = true;
                txt_id.Text = "";
                txt_discount.Text = "";
                txt_id.Focus();
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string error = "";
            if (index >= 0 && dataGid_Gift.Rows.Count > 0 && dataGid_Gift.Rows[index].Cells[0].Value.ToString() != "")
            {
                if (MessageBox.Show("Are you sure ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    if (bS_Gift.deleteGift(dataGid_Gift.Rows[index].Cells[0].Value.ToString(), ref error))
                    {
                        MessageBox.Show("Delete Success", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadData();
                    }
                    else
                        MessageBox.Show("Error\n" + error);
                }
            }
        }
        // repaid
        private void btn_Repair_Click(object sender, EventArgs e)
        {
            if (mode == Mode.nomal)
                mode = Mode.repaid;
            if (mode == Mode.confirm)
            {
                if (txt_discount.Text == "" || txt_id.Text == "")
                    MessageBox.Show("Values does not empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    int discount;
                    // check value string
                    if (int.TryParse(txt_discount.Text, out discount))
                    {
                        // check exist id
                        if (!bS_Gift.isEsixt(id,txt_id.Text))
                        {
                            string error = "";
                            if (bS_Gift.repaidGift(id,txt_id.Text, discount, ref error))
                            {
                                mode = Mode.nomal;
                                Enable();
                                btn_Repair.LabelText = "Repaid";
                                btn_Add.Enabled = true;
                                btn_Delete.Enabled = true;
                                btn_Cancel.Enabled = false;
                                loadData();
                                MessageBox.Show("Repaid success", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                                MessageBox.Show(error);
                        }
                        else
                        {
                            txt_id.Text = "";
                            txt_id.Focus();
                            MessageBox.Show("ID Code haved esixted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("discount not string", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_discount.Text = "";
                        txt_discount.Focus();
                    }
                    
                }
            }
            if (mode == Mode.repaid)
            {
                UnEnable();
                btn_Repair.LabelText = "Confirm";
                mode = Mode.confirm;
                btn_Add.Enabled = false;
                btn_Delete.Enabled = false;
                btn_Cancel.Enabled = true;
                txt_id.Focus();
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Enable();
            mode = Mode.nomal;
            txt_discount.Text = "";
            btn_Add.LabelText = "Add";
            btn_Repair.LabelText = "Repaid";
            txt_id.Text = "";
            btn_Add.Enabled = true;
            btn_Repair.Enabled = true;
            btn_Delete.Enabled = true;
            btn_Cancel.Enabled = false;
        }

        private void dataGid_Gift_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index >= 0 && dataGid_Gift.Rows.Count > 0 && dataGid_Gift.Rows[index].Cells[0].Value.ToString() != "")
            {
                loadValueRepaid();
            }
        }
        // load value repaid
        private void loadValueRepaid()
        {
            if (index >= 0 && dataGid_Gift.Rows.Count > 0 && dataGid_Gift.Rows[index].Cells[1].Value.ToString().Trim() != "")
            {
                string discount = dataGid_Gift.Rows[index].Cells[1].Value.ToString().Trim();
                txt_discount.Text = discount.Split('%')[0];
                id = txt_id.Text = dataGid_Gift.Rows[index].Cells[0].Value.ToString().Trim();
            }
        }
    }
}
