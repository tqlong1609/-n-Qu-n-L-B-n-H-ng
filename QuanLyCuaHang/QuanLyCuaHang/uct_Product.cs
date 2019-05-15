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
using System.IO;

namespace QuanLyCuaHang
{
    public partial class uct_Product : UserControl
    {
        private BS_Products product;
        private TypeDevice typeDevice;
        private int index;

        private enum TypeDevice { Laptop, SmartPhone, ExtraDevice, All };

        public uct_Product()
        {
            InitializeComponent();
            product = new BS_Products();
            typeDevice = TypeDevice.Laptop;
            loadDataLaptop();
            index = 0;
        }

        #region load data
        // load data all
        private void loadDataAll()
        {
            dataGid_Device.DataSource = product.loadAll();
            dataGid_Device.Columns["Image"].Visible = false;

        }
        // load data laptop
        private void loadDataLaptop()
        {
            dataGid_Device.DataSource = product.loadLaptop();
            dataGid_Device.Columns["Image"].Visible = false;
        }
        // load smart phone
        private void loadSmartPhone()
        {
            dataGid_Device.DataSource = product.loadSmartPhone();
        }
        // load extra device
        private void loadExtraDevice()
        {
            dataGid_Device.DataSource = product.loadExtraDevice();
            typeDevice = TypeDevice.ExtraDevice;
        }
        #endregion
        
        #region handle click
        private void dataGid_Device_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index >= 0 && dataGid_Device.Rows.Count > 0)
            {
                pbx_Avatar.Image = product.loadImage(dataGid_Device.Rows[index].Cells[0].Value.ToString());
            }
        }
        // tab smart phone
        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            loadSmartPhone();
            typeDevice = TypeDevice.SmartPhone;
        }
        // tab extra device
        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            loadExtraDevice();
            typeDevice = TypeDevice.ExtraDevice;
        }
        // click image avatar
        private void btn_EditAvatar_Click(object sender, EventArgs e)
        {
            loadDataLaptop();
            typeDevice = TypeDevice.Laptop;
        }
        // tab all
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            loadDataAll();
            typeDevice = TypeDevice.All;
        }
        // add
        private void btn_Add_Click(object sender, EventArgs e)
        {
            frm_AddProduct temp = new frm_AddProduct();
            temp.ShowDialog();
        }
        // delete
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string error = "";
            if (index >= 0 && dataGid_Device.Rows.Count > 0)
            {
                try
                {
                    string id = dataGid_Device.Rows[index].Cells[0].Value.ToString();
                    if (id != null)
                    {
                        if (MessageBox.Show("Are you sure ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                            == DialogResult.Yes)
                        {
                            if (product.removeProduct(id, ref error))
                            {
                                MessageBox.Show("Remove success", "Congratuation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                checkLoadProduct();
                            }
                            else
                                MessageBox.Show("Remove fail\n" + error, "fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception) { };
            }
        }
        // repaid
        private void btn_Repair_Click(object sender, EventArgs e)
        {
            if (index >= 0 && dataGid_Device.Rows.Count > 0)
            {
                new frm_AddProduct(dataGid_Device.Rows[index].Cells[0].Value.ToString()).ShowDialog();
            }
        }
        #endregion

        // check load product
        private void checkLoadProduct()
        {
            switch (typeDevice)
            {
                case TypeDevice.Laptop:
                    loadDataLaptop();
                    break;
                case TypeDevice.ExtraDevice:
                    loadExtraDevice();
                    break;
                case TypeDevice.SmartPhone:
                    loadSmartPhone();
                    break;
                case TypeDevice.All:
                    loadDataAll();
                    break;
            }
        }
        // show form detail product
        private void btn_ShowDetail_Click(object sender, EventArgs e)
        {

        }

        private void txt_Search_OnValueChanged(object sender, EventArgs e)
        {
            if (txt_Search.Text != "")
            {
                dataGid_Device.DataSource = product.searchProducts(txt_Search.Text.Trim());
            }
            else
            {
                checkLoadProduct();
            }
        }
    }
}
