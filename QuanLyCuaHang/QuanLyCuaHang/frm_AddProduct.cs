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
        public static bool isUpdate = false;

        private mode mMode;

        private enum mode { add, repaid }

        // contrustor add
        public frm_AddProduct()
        {
            InitializeComponent();
            mMode = mode.add;
            load();
        }
        // contrustor repaid
        public frm_AddProduct(string id)
        {
            InitializeComponent();
            mMode = mode.repaid;
            load();
            this.id = id;
            loadData();
            btn_Add.Text = "Repaid";
        }

        #region load data
        // load 
        private void load()
        {
            bS_Products = new BS_Products();
            pbx_Avatar.SizeMode = PictureBoxSizeMode.StretchImage;
            loadDataBox();
            if (cbx_IdBlock.Items.Count > 0)
                cbx_IdBlock.selectedIndex = 0;
            if (cbx_IdCategory.Items.Count > 0)
                cbx_IdCategory.selectedIndex = 0;
            if(cbx_IdDetail.Items.Count > 0)
                cbx_IdDetail.selectedIndex = 0;
        }
        // load data into combobox
        private void loadDataBox()
        {
            DataTable tableCategory = bS_Products.loadDataIDCatagory();
            DataTable tableBlock = bS_Products.loadDataIDBlock();
            DataTable tableDetail = bS_Products.loadDataIDDetail();
            DataTable tableProduct = bS_Products.loadDataIdProduct();

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
            txt_Id.Text = loadIdProduct(tableProduct);
        }
        // load id product
        private string loadIdProduct(DataTable dataTable)
        {
            int num = 0;
            foreach (DataRow dataRow in dataTable.Rows)
            {
                if (!dataRow["IDSanPham"].ToString().Contains(num.ToString()))
                    return "SP" + num;
                num++;
            }
            return "SP" + num;
        }
        // load data repaid
        private void loadData()
        {
            txt_Id.Text = id;
            string idCategory = "";
            string name = "";
            int price = 0;
            string block = "";
            string idDetail = "";
            Image avatar = null;
            bS_Products.loadDataId(id, ref idCategory, ref name, ref price, ref block, ref idDetail, ref avatar);
            int j = 0;
            foreach (string i in cbx_IdCategory.Items)
            {
                if (i.Equals(idCategory))
                {
                    cbx_IdCategory.selectedIndex = j; break;
                }
                j++;
            }
            j = 0;
            foreach (string i in cbx_IdBlock.Items)
            {
                if (i.Equals(block))
                {
                    cbx_IdBlock.selectedIndex = j; break;
                }
                j++;
            }
            j = 0;
            foreach (string i in cbx_IdDetail.Items)
            {
                if (i.Equals(idDetail))
                {
                    cbx_IdDetail.selectedIndex = j; break;
                }
                j++;
            }
            txt_Name.Text = name;
            txt_Price.Text = price.ToString();
            if(avatar != null)
                pbx_Avatar.Image = avatar;
        }
        #endregion
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

        #region handle click
        // add/repaid click
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (mMode == mode.add)
            {
                // add
                if (!isEmpty())
                {
                    string error = "Error";
                    try
                    {
                        bS_Products.addProduct(txt_Id.Text, cbx_IdCategory.selectedValue, txt_Name.Text, int.Parse(txt_Price.Text),
                            cbx_IdBlock.selectedValue, cbx_IdDetail.selectedValue, path, ref error);
                        isUpdate = true;
                        this.Close();
                    }
                    catch (Exception) { MessageBox.Show(error); }
                }
                else MessageBox.Show("Request enter full","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                // repaid
                if (!isEmpty())
                {
                    string error = "Error";
                    try
                    {
                        bS_Products.repaidProduct(id, cbx_IdCategory.selectedValue, txt_Name.Text, txt_Price.Text, cbx_IdBlock.selectedValue,
                            cbx_IdDetail.selectedValue, path, ref error);
                        this.Close();
                    }
                    catch (Exception) { MessageBox.Show(error); }
                }
                else MessageBox.Show("Request enter full", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
