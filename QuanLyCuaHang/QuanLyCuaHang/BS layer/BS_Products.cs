using QuanLyCuaHang.DB_layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return dBMain.ExecuteQueryDataSet(sqlString,CommandType.Text);
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
        // load image device
        //public Image loadImage(string id)
        //{
        //    string sqlString = "select Image from SANPHAM where IDSanPham = '" + id + "'";
        //    DataTable dataTable = dBMain.ExecuteQueryDataSet(sqlString, CommandType.Text);
        //    foreach (DataRow dataRow in dataTable.Rows)
        //    {
                
        //    }
        //    return ByteToImg(dBMain.ExecuteQueryDataSet(sqlString,CommandType.Text).Rows["Image"]);
        //}
        // convert byte to image
        private Image ByteToImg(string byteString)
        {
            byte[] imgBytes = Convert.FromBase64String(byteString);
            MemoryStream ms = new MemoryStream(imgBytes, 0, imgBytes.Length);
            ms.Write(imgBytes, 0, imgBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }
    }
}
