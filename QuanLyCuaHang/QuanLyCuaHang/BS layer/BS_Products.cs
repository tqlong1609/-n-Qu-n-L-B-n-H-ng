using QuanLyCuaHang.DB_layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHang.BS_layer
{
    class BS_Products
    {
        DBMain dBMain = null;

        public BS_Products()
        {
            dBMain = new DBMain();
        }
        // load products all
        public DataTable loadAll()
        {
            string sqlString = "select * from SANPHAM";
            return dBMain.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }
        // load product laptop
        public DataTable loadLaptop()
        {
            string sqlString = "select * from SANPHAM where IDCategory = 'CATE1'";
            return dBMain.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }
        // load product smart phone
        public DataTable loadSmartPhone()
        {
            string sqlString = "select * from SANPHAM where IDCategory = 'CATE2'";
            return dBMain.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }
        // load product laptop
        public DataTable loadExtraDevice()
        {
            string sqlString = "select * from SANPHAM where IDCategory = 'CATE3'";
            return dBMain.ExecuteQueryDataSet(sqlString, CommandType.Text);
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
        // conver image to byte
        private byte[] converImgToByte(string path)
        {
            FileStream fs;
            fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            byte[] picbyte = new byte[fs.Length];
            fs.Read(picbyte, 0, System.Convert.ToInt32(fs.Length));
            fs.Close();
            return picbyte;
        }
        // TO Do
        // load data follow id
        public void loadDataId(string id, ref string idCategory, ref string name, ref int Price, ref string idBlock,
            ref string idDetail)
        {
            string sqlString = "select * from SANPHAM where IDDetail = '" + id +"'";
            dBMain.ExecuteQueryDataSet(sqlString, CommandType.Text);

        }
        public void addProduct(string id, string idCategory, string name, int Price, string idBlock,
            string idDetail, string path, ref string error)
        {
            string sqlString;
            if (path == null)
            {
                sqlString = "insert into SANPHAM (IDSanPham, IDCategory, Name, Price, IDBlock, IDDetail) " +
                    "values ('" + id + "','" + idCategory + "',N'" + name + "'," + Price + ",'" + idBlock + "','" + idDetail + "')";
            }
            else
            {
                byte[] imgdata = converImgToByte(path);
                sqlString = "insert into SANPHAM (IDSanPham, IDCategory, Name, Price, IDBlock, IDDetail,Image) " +
                    "values('"+id+"', '"+idCategory+"', N'"+name+"', "+Price+", '"+idBlock+"', '"+idDetail+"', '"+ 
                    Convert.ToBase64String(imgdata) + "')";
            }
            if (dBMain.MyExecuteNonQuery(sqlString, CommandType.Text, ref error))
                MessageBox.Show("Success", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Fail", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        // load id catagory
        public DataTable loadDataIDCatagory()
        {
            string sqlString = "SELECT distinct IDCategory from SANPHAM";
            return dBMain.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }
        // load id block
        public DataTable loadDataIDBlock()
        {
            string sqlString = "SELECT distinct IDBlock from SANPHAM";
            return dBMain.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }
        // load id detail
        public DataTable loadDataIDDetail()
        {
            string sqlString = "SELECT distinct IDDetail from SANPHAM";
            return dBMain.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }
    }
}
