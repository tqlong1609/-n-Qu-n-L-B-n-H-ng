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

        private void btn_Add_Click(object sender, EventArgs e)
        {
            frm_AddProduct temp = new frm_AddProduct();
            temp.ShowDialog();
        }
        // load data all
        private void loadDataAll()
        {
            dataGid_Device.DataSource = product.loadAll();
            dataGid_Device.Columns["Image"].Visible = false;

        }
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            loadDataAll();
            typeDevice = TypeDevice.All;
        }
        // load data laptop
        private void loadDataLaptop()
        {
            dataGid_Device.DataSource = product.loadLaptop();
            dataGid_Device.Columns["Image"].Visible = false;
        }
        private void btn_EditAvatar_Click(object sender, EventArgs e)
        {
            loadDataLaptop();
            typeDevice = TypeDevice.Laptop;
        }
        // load smart phone
        private void loadSmartPhone()
        {
            dataGid_Device.DataSource = product.loadSmartPhone();
        }
        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            loadSmartPhone();
            typeDevice = TypeDevice.SmartPhone;
        }
        // load extra device
        private void loadExtraDevice()
        {
            dataGid_Device.DataSource = product.loadExtraDevice();
            typeDevice = TypeDevice.ExtraDevice;
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            loadExtraDevice();
            typeDevice = TypeDevice.ExtraDevice;
        }

        private void dataGid_Device_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
