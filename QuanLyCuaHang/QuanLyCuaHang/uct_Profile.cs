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
    public partial class uct_Profile : UserControl
    {
        private BS_Employee bs;
        string urlImage;
        private string path;

        public uct_Profile()
        {
            InitializeComponent();
            Bunifu.Framework.Lib.Elipse.Apply(btn_EditAvatar, 30);
            Bunifu.Framework.Lib.Elipse.Apply(btn_UpdateInformation, 30);
            pbx_Avatar.SizeMode = PictureBoxSizeMode.StretchImage;
            bs = new BS_Employee();
            setData();
        }
        // set data start
        private void setData()
        {
            string id = frm_Login.id;
            string pass = "";
            string name = "";
            string phone = "";
            string idcard = "";
            string address = "";
            bs.getDataEmployee(id, ref pass, ref name, ref phone
                , ref idcard, ref address, ref urlImage);
            tbx_UserName.Text = id;
            tbx_Password.Text = pass;
            tbx_Name.Text = name;
            tbx_PhoneNumber.Text = phone;
            tbx_idCard.Text = idcard;
            tbx_address.Text = address;
            tbx_ConfirmPassword.Text = pass;
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
        // updata information
        private void btn_UpdateInformation_Click(object sender, EventArgs e)
        {
            string error = "";
            if (tbx_Password.Text.Equals(tbx_ConfirmPassword.Text)) {
                // check exist main key
                try
                {
                    if (tbx_UserName.Text != "")
                    {
                        if (!bs.isExistId(tbx_UserName.Text) || tbx_UserName.Text.Equals(frm_Login.id))
                        {
                            bs.setDataEmployee(frm_Login.id, tbx_UserName.Text, tbx_Password.Text, tbx_Name.Text, tbx_PhoneNumber.Text,
                                tbx_idCard.Text, tbx_address.Text,path, ref error);
                            MessageBox.Show("Update success", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Warning!!! User name is exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            tbx_UserName.Text = "";
                            tbx_UserName.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Warning!!! User name is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception) { MessageBox.Show(error); }
            }
            else
            {
                MessageBox.Show("Password and Confirm Password are different!!!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                tbx_ConfirmPassword.Text = tbx_Password.Text = "";
                tbx_Password.Focus();
            }
        }
        // edit avatar
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
