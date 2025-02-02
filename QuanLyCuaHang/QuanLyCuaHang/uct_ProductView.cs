﻿using System;
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
    public partial class uct_ProductView : UserControl
    {
        private int index;
        private TypeDevice typeDevice;
        private BS_Products product;

        private enum TypeDevice { Laptop, SmartPhone, ExtraDevice, All };

        public uct_ProductView()
        {
            InitializeComponent();
            product = new BS_Products();
            typeDevice = TypeDevice.Laptop;
            index = 0;
            loadDataLaptop();
        }
        #region load
        // load data all
        private void loadDataAll()
        {
            dataGid_Device.DataSource = product.loadAll();
            dataGid_Device.Columns["Image"].Visible = false;
            changeLocation();

        }
        // load data laptop
        private void loadDataLaptop()
        {
            dataGid_Device.DataSource = product.loadLaptop();
            dataGid_Device.Columns["Image"].Visible = false;
            changeLocation();

        }
        // load smart phone
        private void loadSmartPhone()
        {
            dataGid_Device.DataSource = product.loadSmartPhone();
            changeLocation();

        }
        // load extra device
        private void loadExtraDevice()
        {
            dataGid_Device.DataSource = product.loadExtraDevice();
            typeDevice = TypeDevice.ExtraDevice;
            changeLocation();

        }

        private void btn_Laptop_Click(object sender, EventArgs e)
        {
            loadDataLaptop();
            typeDevice = TypeDevice.Laptop;

        }

        private void btn_SmartPhone_Click(object sender, EventArgs e)
        {
            loadSmartPhone();
            typeDevice = TypeDevice.SmartPhone;
        }

        private void btn_ExtraDevice_Click(object sender, EventArgs e)
        {
            loadExtraDevice();
            typeDevice = TypeDevice.ExtraDevice;
        }

        private void btn_All_Click(object sender, EventArgs e)
        {
            loadDataAll();
            typeDevice = TypeDevice.All;
        }
        
        #endregion
        private void dataGid_Device_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index >= 0 && dataGid_Device.Rows.Count > 0 && dataGid_Device.Rows[index].Cells[6].Value.ToString() != null)
            {
                pbx_Avatar.Image = product.loadImage(dataGid_Device.Rows[index].Cells[0].Value.ToString());
            }
        }
        // search
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
            changeLocation();
        }
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
        private void changeLocation()
        {
            if (dataGid_Device.Rows.Count > 13)
            {
                btn_2.Location = new Point(115 - 3, btn_2.Location.Y);
                btn_3.Location = new Point(230 - 7, btn_3.Location.Y);
                btn_4.Location = new Point(345 - 10, btn_3.Location.Y);
                btn_5.Location = new Point(460 - 12, btn_3.Location.Y);
                btn_6.Location = new Point(575 - 15, btn_3.Location.Y);
            }
            else
            {
                btn_2.Location = new Point(115, btn_2.Location.Y);
                btn_3.Location = new Point(230, btn_3.Location.Y);
                btn_4.Location = new Point(345, btn_4.Location.Y);
                btn_5.Location = new Point(460, btn_4.Location.Y);
                btn_6.Location = new Point(575, btn_4.Location.Y);
            }
        }
        private void btn_Watch_Click(object sender, EventArgs e)
        {
            new frm_WatchProducts().Show();
        }
    }
}
