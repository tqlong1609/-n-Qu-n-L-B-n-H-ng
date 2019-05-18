using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHang
{
    public partial class LayoutProducts : UserControl
    {
        DetailLayout detailLayout = new DetailLayout();

        public LayoutProducts()
        {
            InitializeComponent();
            Bunifu.Framework.Lib.Elipse.Apply(this, 15);
            Bunifu.Framework.Lib.Elipse.Apply(pbxSanPham, 15);
        }
        // Tạo ra layout đè khi di chuột vào ảnh
        public void SetDetail(string manhinh, string camtruoc, string camsau, string os, string ram, string rom, string pin, string chip)
        {
            detailLayout.SetValue(manhinh, camtruoc, camsau, os, ram, rom, pin, chip);
            pnlDetail.Controls.Add(detailLayout);
        }

        // Set giá trị cho layout
        public void SetValue(Image image, string tensanpham, int gia)
        {
            pbxSanPham.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxSanPham.Image = image;
            lblTenSanPham.Text = tensanpham;
            lblGia.Text += gia;
        }

        private void btnShowDetail_Click_1(object sender, EventArgs e)
        {
            if (!pnlDetail.Visible)
                pnlDetail.Visible = true;
            else
                pnlDetail.Visible = false;
        }
    }
}
