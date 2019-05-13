using QuanLyCuaHang.BS_layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHang
{
    public partial class frm_AddEmployee : Form
    {
        private string path;
        private BS_Employee bS_Employee;
        private string id;
        private mode mMode;

        private enum mode { add, repaid}

        public frm_AddEmployee()
        {
            InitializeComponent();
            mMode = mode.add;
            load();
        }
        
        public frm_AddEmployee(string id)
        {
            InitializeComponent();
            tbx_user_name.Enabled = false;
            mMode = mode.repaid;
            load();
            this.id = id;
            btn_Find.Text = "Repair";
            loadData();
        }
        // load 
        private void load()
        {
            bS_Employee = new BS_Employee();
            pbx_Avatar.SizeMode = PictureBoxSizeMode.StretchImage;
            cbx_position.AddItem("warehouse");
            cbx_position.AddItem("employee");
            cbx_position.selectedIndex = 0;
        }
        private void loadData()
        {
            string pass = "";
            string name = "";
            string phone = "";
            string idcard = "";
            string address = "";
            string position = "";
            string urlImage = "";
            bS_Employee.loadDataEmployeeAll(this.id.Trim(),ref pass,ref name,ref phone
                ,ref idcard,ref address,ref position,ref urlImage);
            tbx_user_name.Text = id;
            tbx_password.Text = pass;
            tbx_name.Text = name;
            tbx_phone.Text = phone;
            tbx_idcard.Text = idcard;
            tbx_address.Text = address;

            for (int i = 0; i < cbx_position.Items.Count; i++)
            {
                if (cbx_position.Items[i].ToString().Equals(position))
                    cbx_position.selectedIndex = i;
            }
            // set image before load form
            if (urlImage != "" && urlImage != null)
            {
                Image image = ByteToImg(urlImage);
                pbx_Avatar.Image = image;
            }
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
        private void btn_Find_Click(object sender, EventArgs e)
        {
            if (mMode == mode.add)
            {
                string error = "";
                if (isEmpty()) { MessageBox.Show("Request enter full", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                else
                {
                    if (bS_Employee.isExistId(tbx_user_name.Text))
                    {
                        MessageBox.Show("Exist user name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        try
                        {
                            bS_Employee.addEmployee(tbx_user_name.Text, tbx_password.Text, tbx_name.Text, tbx_phone.Text,
                                tbx_idcard.Text, tbx_address.Text, cbx_position.selectedValue, path, ref error);
                            this.Close();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show(error);
                        }
                    }
                }
            }
            else
            {
                string error = "";
                if (isEmpty()) { MessageBox.Show("Request enter full", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                else
                {
                    
                    try
                    {
                        bS_Employee.repaidDataEmployee(tbx_user_name.Text, tbx_password.Text, tbx_name.Text, tbx_phone.Text,
                            tbx_idcard.Text, tbx_address.Text, cbx_position.selectedValue, path, ref error);
                        this.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(error);
                    }
                }
            }
        }
        // check empty value
        private bool isEmpty()
        {
            if ( tbx_user_name.Text == "" || tbx_name.Text == "" || tbx_password.Text == ""
                || tbx_phone.Text == "" || tbx_idcard.Text == "" || tbx_address.Text == "")
            {
                return true;
            }
            return false;
        }
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_EditAvatar_Click(object sender, EventArgs e)
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
