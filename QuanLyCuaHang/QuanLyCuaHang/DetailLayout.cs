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
    public partial class DetailLayout : UserControl
    {
        public DetailLayout()
        {
            InitializeComponent();
            Bunifu.Framework.Lib.Elipse.Apply(this, 15);

        }
        public void SetValue(string manhinh, string camtruoc, string camsau, string os, string ram, string rom, string pin, string chip)
        {
            lblManHinh.Text += manhinh;
            lblCamTruoc.Text += camtruoc;
            lblCamSau.Text += camsau;
            lblOS.Text += os;
            lblRam.Text += ram;
            lblRom.Text += rom;
            lblPin.Text += pin;
            lblChip.Text += chip;
        }
    }
}
