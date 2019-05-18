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
    public partial class frm_ReportHistory : Form
    {
        public frm_ReportHistory()
        {
            InitializeComponent();
        }

        private void frm_ReportHistory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QUANLYCUAHANGDataSet.HOADON' table. You can move, or remove it, as needed.
            this.HOADONTableAdapter.Fill(this.QUANLYCUAHANGDataSet.HOADON);

            this.reportViewer1.RefreshReport();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Minisize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Exit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
