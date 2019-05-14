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
    public partial class frm_AddProduct : Form
    {
        private string path;
        private BS_Products bS_Products;
        private string id;

        private mode mMode;

        private enum mode { add, repaid }

        public frm_AddProduct()
        {
            InitializeComponent();
            mMode = mode.add;
            load();
        }
        // load 
        private void load()
        {
            bS_Products = new BS_Products();
            pbx_Avatar.SizeMode = PictureBoxSizeMode.StretchImage;
            loadDataBox();
            cbx_IdBlock.selectedIndex = 0;
            cbx_IdCategory.selectedIndex = 0;
            cbx_IdDetail.selectedIndex = 0;
        }
        // load data into combobox
        private void loadDataBox()
        {
            DataTable tableCategory = bS_Products.loadDataIDCatagory();
            DataTable tableBlock = bS_Products.loadDataIDBlock();
            DataTable tableDetail = bS_Products.loadDataIDDetail();

            foreach (DataRow dataRow in tableCategory.Rows)
            {
                cbx_IdCategory.AddItem(dataRow["IDCategory"].ToString().Trim());
            }
            foreach (DataRow dataRow in tableBlock.Rows)
            {
                cbx_IdBlock.AddItem(dataRow["IDBlock"].ToString().Trim());
            }
            foreach (DataRow dataRow in tableDetail.Rows)
            {
                cbx_IdDetail.AddItem(dataRow["IDDetail"].ToString().Trim());
            }
        }
        // load data
        private void loadData()
        {

        }
        // check input data
        private bool isEmpty()
        {
            int price;
            if (int.TryParse(txt_Price.Text, out price))
            {
                if (txt_Id.Text == "" || txt_Name.Text == "")
                    return true;
                else
                    return false;
            }
            else {
                MessageBox.Show("price is not string", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (!isEmpty())
            {
                string error = "Error";
                try
                {
                    bS_Products.addProduct(txt_Id.Text, cbx_IdCategory.selectedValue, txt_Name.Text, int.Parse(txt_Price.Text),
                        cbx_IdBlock.selectedValue, cbx_IdDetail.selectedValue, path, ref error);
                    this.Close();
                }
                catch (Exception) { MessageBox.Show(error); }
            }
        }

        private void btn_EditPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                pbx_Avatar.Image = Image.FromFile(fileDialog.FileName);
                path = fileDialog.FileName;
            }
        }
    }
}
