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
    public partial class frm_AddDetailProducts : Form
    {
        public static bool isUpdate = false;
        private BS_Products bS_Products;
        private Mode mode;

        private enum Mode { add, repaid};

        #region contrustor
        public frm_AddDetailProducts()
        {
            // mode add
            InitializeComponent();
            bS_Products = new BS_Products();
            mode = Mode.add;
        }
        public frm_AddDetailProducts(string id)
        {
            // mode repaid
            InitializeComponent();
            bS_Products = new BS_Products();
            mode = Mode.repaid;
            loadDataId(id);
            btn_Add.Text = "Repaid";
            txt_Id.Enabled = false;
        }
        #endregion

        #region load
        // load data from id for repaid
        private void loadDataId(string id)
        {
            string manhinh = "";
            string frontCam = "";
            string backCam = "";
            string os = "";
            string ram = "";
            string rom = "";
            string battery = "";
            string chip = "";
            bS_Products.loadDataDetail(id, ref manhinh, ref frontCam, ref backCam, ref os, ref ram, 
                ref rom, ref battery, ref chip);
            txt_Id.Text = id;
            txt_Screen.Text = manhinh;
            txt_FrontCamera.Text = frontCam;
            txt_BackCamera.Text = backCam;
            txt_Os.Text = os;
            txt_Ram.Text = ram;
            txt_Rom.Text = rom;
            txt_Battery.Text = battery;
            txt_Chip.Text = chip;
        }
        #endregion

        #region handle
        private void btn_Add_Click(object sender, EventArgs e)
        {
            // mode add
            if (mode == Mode.add) 
            {
                if (!isEmpty())
                {
                    if (!isExist())
                    {
                        string error = "";
                        try
                        {
                            bS_Products.AddDetailProduct(txt_Id.Text, txt_Screen.Text, txt_FrontCamera.Text, txt_BackCamera.Text,
                                txt_Os.Text, txt_Ram.Text, txt_Rom.Text, txt_Battery.Text, txt_Chip.Text, ref error);
                            this.Close();
                            isUpdate = true;
                        }
                        catch (Exception) { MessageBox.Show(error); }
                    }
                    else MessageBox.Show("Exist id detail", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("Enter full values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else // mode repaid
            {
                if (!isEmpty())
                {
                    string error = "";
                    if (!bS_Products.repaidProductDetail(txt_Id.Text, txt_Screen.Text, txt_FrontCamera.Text, 
                        txt_BackCamera.Text, txt_Os.Text,
                        txt_Ram.Text, txt_Rom.Text, txt_Battery.Text, txt_Chip.Text, ref error))
                    {
                        MessageBox.Show(error);
                    }
                    else
                    {
                        MessageBox.Show("Repaid Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        isUpdate = true;
                        this.Close();
                    }
                }
                else MessageBox.Show("Enter full values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region check
        // check exist id
        private bool isExist()
        {
            return bS_Products.isExistIDDetail(txt_Id.Text.Trim().ToLower());
        }
        // Check empty values
        private bool isEmpty()
        {
            if (txt_Id.Text == "" || txt_Os.Text == "" || txt_Ram.Text == "" || txt_Rom.Text == ""
                || txt_Screen.Text == "" || txt_Chip.Text == "" || txt_Battery.Text == ""
                || txt_FrontCamera.Text == "" || txt_BackCamera.Text == "")
                return true;
            return false;
        }
        #endregion

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
