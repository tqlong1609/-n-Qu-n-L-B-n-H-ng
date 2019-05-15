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

        #region load data
        // load data product detail
        public DataTable loadDataProductDetail()
        {
            return dBMain.ExecuteQueryDataSet("Select * from DETAIL", CommandType.Text);
        }
        // load data follow id
        public void loadDataId(string id, ref string idCategory, ref string name, ref int Price, ref string idBlock,
            ref string idDetail, ref Image image)
        {
            string sqlString = "select * from SANPHAM where IDSanPham = '" + id + "'";
            DataTable dataTable = dBMain.ExecuteQueryDataSet(sqlString, CommandType.Text);
            foreach (DataRow dataRow in dataTable.Rows)
            {
                idCategory = dataRow["IDCategory"].ToString().Trim();
                name = dataRow["Name"].ToString().Trim();
                Price = int.Parse(dataRow["Price"].ToString().Trim());
                idBlock = dataRow["IDBlock"].ToString().Trim();
                idCategory = dataRow["IDCategory"].ToString().Trim();
                idDetail = dataRow["IDDetail"].ToString().Trim();
                if (dataRow["Image"].ToString().Trim() != "")
                    image = ByteToImg(dataRow["Image"].ToString().Trim());
            }
        }
        // load image from id
        public Image loadImage(string id)
        {
            string sqlString = "select Image from SANPHAM where IDSanPham = '" + id + "'";
            DataTable dataTable = dBMain.ExecuteQueryDataSet(sqlString, CommandType.Text);
            string pathImg = "";
            foreach (DataRow dataRow in dataTable.Rows)
            {
                if (dataRow["Image"].ToString().Trim() == "")
                    return null;
                pathImg = dataRow["Image"].ToString().Trim();
            }
            return ByteToImg(pathImg);
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
        #endregion

        #region convert image
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
        #endregion

        #region load id

        // load id catagory
        public DataTable loadDataIDCatagory()
        {
            string sqlString = "SELECT IDCategory from CATEGORY";
            return dBMain.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }
        // load id block
        public DataTable loadDataIDBlock()
        {
            string sqlString = "SELECT distinct IDBlock from BLOCK";
            return dBMain.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }
        // load id detail
        public DataTable loadDataIDDetail()
        {
            string sqlString = "SELECT distinct IDDetail from DETAIL";
            return dBMain.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }
        // load id product
        public DataTable loadDataIdProduct()
        {
            string sqlString = "SELECT distinct IDSanPham from SANPHAM";
            return dBMain.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }
        #endregion

        #region handle
        // delete product
        public bool removeProduct(string id, ref string error)
        {
            string sqlString = "delete from SANPHAM where IDSanPham = '" + id + "'";
            return dBMain.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }
        // add product
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
                    "values('" + id + "', '" + idCategory + "', N'" + name + "', " + Price + ", '" + idBlock + "', '" + idDetail + "', '" +
                    Convert.ToBase64String(imgdata) + "')";
            }
            if (dBMain.MyExecuteNonQuery(sqlString, CommandType.Text, ref error))
                MessageBox.Show("Success", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Fail", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        // repaid
        public void repaidProduct(string id, string idcategory, string name, string price, string idblock,
            string detail, string path, ref string error)
        {
            string sqlString = "";
            if (path == null)
            {
                sqlString = "update SANPHAM set IDCategory = '" + idcategory + "', Name = N'" + name + "', Price = " + price + "," +
                    " IDBlock = '" + idblock + "', IDDetail = '" + detail + "' " +
                    "where IDSanPham = '" + id + "'";
            }
            else
            {
                byte[] imgdata = converImgToByte(path);
                sqlString = "update SANPHAM set IDCategory = '" + idcategory + "', Name = N'" + name + "', " +
                    "Price = " + price + ", " + "IDBlock = '" + idblock + "', IDDetail = '" + detail + "'," +
                    " Image = '" + Convert.ToBase64String(imgdata) + "' where IDSanPham = '" + id + "'";
            }
            if (dBMain.MyExecuteNonQuery(sqlString, CommandType.Text, ref error))
                MessageBox.Show("Success", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Fail", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        // search
        public DataTable searchProducts(string _search)
        {
            return dBMain.ExecuteQueryDataSet("select * from SANPHAM " +
                "where IDSanPham like '" + _search + "%' or IDCategory like '" + _search + "%' " +
                "or Name like N'" + _search + "%' or IDBlock like '" + _search + "%' " +
                "or IDDetail like '" + _search + "%'", CommandType.Text);
        }
        #endregion

        #region detail product
        // add detail product
        public void AddDetailProduct(string id, string screen, string frontCam, string backCam, string os,
            string ram, string rom, string battery, string chip, ref string error)
        {
            string sqlString = "insert into DETAIL (IDDetail, ManHinh, CameraTruoc, CameraSau, OS, Ram, Rom, DungLuongPin, Chip) " +
                "values('" + id + "', N'" + screen + "', '" + frontCam + "', '" + backCam + "', '" + os + "', '" +
                ram + "', '" + rom + "', '" + battery + "', '" + chip + "')";
            if (dBMain.MyExecuteNonQuery(sqlString, CommandType.Text, ref error))
            {
                MessageBox.Show("Add success", "Congratuation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Fail", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        // check exist id detail
        public bool isExistIDDetail(string id)
        {
            DataTable dataTable = dBMain.ExecuteQueryDataSet("select IDDetail from DETAIL", CommandType.Text);
            foreach (DataRow dataRow in dataTable.Rows)
            {
                if (id.Equals(dataRow["IDDetail"].ToString().Trim().ToLower()))
                    return true;
            }
            return false;
        }
        // remove id detail
        public bool removeDetailProduct(string id,ref string error)
        {
            string sqlString = "delete from DETAIL where IDDetail = '"+id+"'";
            if (dBMain.MyExecuteNonQuery(sqlString, CommandType.Text, ref error))
                return true;
            return false;
        }
        // load data detail from id
        public void loadDataDetail(string id,ref string screen, ref string frontCam, ref string backCam, ref string os, 
            ref string ram, ref string rom, ref string battery, ref string chip)
        {
            DataTable data;
            string sqlString = "select * from DETAIL where IDDetail = '"+id+"'";
            if ((data = dBMain.ExecuteQueryDataSet(sqlString, CommandType.Text)) != null)
            {
                foreach (DataRow dataRow in data.Rows)
                {
                    screen = dataRow["ManHinh"].ToString().Trim();
                    frontCam = dataRow["CameraTruoc"].ToString().Trim();
                    backCam = dataRow["CameraSau"].ToString().Trim();
                    os = dataRow["OS"].ToString().Trim();
                    ram = dataRow["Ram"].ToString().Trim();
                    rom = dataRow["Rom"].ToString().Trim();
                    battery = dataRow["DungLuongPin"].ToString().Trim();
                    chip = dataRow["Chip"].ToString().Trim();
                }
            }
        }
        // update product detail
        public bool repaidProductDetail(string id, string screen, string frontCam, string backCam, string os, string ram,
            string rom, string battery, string chip, ref string error)
        {
            string sqlString = "update DETAIL set ManHinh = N'"+screen+"', CameraTruoc = '"+frontCam+"'," +
                " CameraSau = '"+backCam+"', " +"OS = '"+os+"',Ram = '"+ram+"', Rom = '"+rom+"'," +
                "DungLuongPin = '"+battery+"', Chip = '"+chip+"' where IDDetail = '"+id+"'";
            if (dBMain.MyExecuteNonQuery(sqlString, CommandType.Text, ref error))
                return true;
            return false;
        }
        // search product detail
        public DataTable searchProductDetail(string _search)
        {
            string sqlString = "select * from DETAIL where IDDetail like '"+_search+"%' or ManHinh like '"+_search+"%' " +
                "or CameraTruoc like '"+_search+"%' or CameraSau like '"+_search+"%'or OS like '"+_search+"%' or Ram like '"+_search+"%' " +
                "or Rom like '"+_search+"%' or DungLuongPin like '"+_search+"%' or Chip like '"+_search+"%'";
            return dBMain.ExecuteQueryDataSet(sqlString,CommandType.Text);
        }
        #endregion
    }
}
