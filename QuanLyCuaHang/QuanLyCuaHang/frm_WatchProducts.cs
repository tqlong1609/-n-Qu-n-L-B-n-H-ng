using QuanLyCuaHang.BS_layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHang
{
    public partial class frm_WatchProducts : Form
    {
        private BS_Products bS_Products;

        public frm_WatchProducts()
        {
            InitializeComponent();
            bS_Products = new BS_Products();
            DataTable dataTable = bS_Products.loadDetailAndProduct();
            int i = 0;
            foreach(DataRow dataRow in dataTable.Rows)
            {
                Image image;
                LayoutProducts layoutSanPham = new LayoutProducts();
                if (dataRow["Image"].ToString().Trim() == "")
                {
                    image = Image.FromFile("ilk.png");
                }
                else
                    image = ByteToImg(dataRow["Image"].ToString().Trim());
                layoutSanPham.SetValue(image, dataRow["Name"].ToString().Trim(),
                    formatMoney(dataRow["Price"].ToString().Trim()));
                layoutSanPham.SetDetail(dataRow["ManHinh"].ToString().Trim(),
                    dataRow["CameraTruoc"].ToString().Trim(), dataRow["CameraSau"].ToString().Trim()
                    , dataRow["OS"].ToString().Trim(), dataRow["Ram"].ToString().Trim(), dataRow["Rom"].ToString().Trim(),
                    dataRow["DungLuongPin"].ToString().Trim(), dataRow["Chip"].ToString().Trim());
                flpLayout.Controls.Add(layoutSanPham);
                i++;
            }
        }
        // format money vnd
        private string formatMoney(string money)
        {
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");   // try with "en-US"
            return double.Parse(money).ToString("#,###", cul.NumberFormat);
        }
        // convert byte to image
        private Image ByteToImg(string byteString)
        {
            byte[] imgBytes = Convert.FromBase64String(byteString);
            MemoryStream ms = new MemoryStream(imgBytes, 0, imgBytes.Length);
            ms.Write(imgBytes, 0, imgBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Minisize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
