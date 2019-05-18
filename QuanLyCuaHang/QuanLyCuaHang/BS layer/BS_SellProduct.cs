using QuanLyCuaHang.DB_layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHang.BS_layer
{
    class BS_SellProduct
    {
        private DBMain dBMain;

        public BS_SellProduct()
        {
            dBMain = new DBMain();
        }
        #region load
        // load data customer
        public DataTable loadCustomer()
        {
            return dBMain.ExecuteQueryDataSet("select IDKhachHang, Name from KHACHHANG", CommandType.Text);
        }
        // load data products
        public DataTable loadProducts()
        {
            return dBMain.ExecuteQueryDataSet("select IDSanPham, Name, Price from SANPHAM", CommandType.Text);
        }
        // load id bill
        public string loadId()
        {
            DataTable dataTable = dBMain.ExecuteQueryDataSet("select IDHoaDon from HOADON", CommandType.Text);
            int num = 0;
            foreach (DataRow dataRow in dataTable.Rows)
            {
                if (!dataRow["IDHoaDon"].ToString().Contains(num.ToString()))
                    return "HD" + num;
                num++;
            }
            return "HD" + num;
        }
        #endregion

        #region handle
        // search customer
        public DataTable searchCustomer(string _search)
        {
            string sqlString = "select IDKhachHang, Name from KHACHHANG where IDKhachHang like '" + _search + "%' " +
                "or Name like N'" + _search + "%'";
            return dBMain.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }
        // search product
        public DataTable searchProducts(string _search)
        {
            string sqlString = "select IDSanPham, Name, Price from SANPHAM where IDSanPham like '"+_search+"%' " +
                "or Name like N'"+_search+"%'";
            return dBMain.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }
        // delete values after sell
        public bool deleteSelled(List<string> idProducts, string idDiscount, ref string error)
        {
            if (idDiscount != "")
            {
                string sqlString = "delete from KHUYENMAI where IDKhuyenMai = '" + idDiscount + "'";
                if (!dBMain.MyExecuteNonQuery(sqlString, CommandType.Text, ref error))
                    return false;
            }
            for (int i = 0; i < idProducts.Count; i++)
            {
                string sqlString = "delete from SANPHAM where IDSanPham = '" + idProducts[i] + "'";
                if (!dBMain.MyExecuteNonQuery(sqlString, CommandType.Text, ref error))
                    return false;
            }
            return true;
        }
        // save values into history
        public bool saveHistory(string idBill, string idEmployee, string idcustomer, int totalPrice,
            string dateSell, string idDiscount, int finalPrice, ref string error)
        {
            string sqlString;
            if (idDiscount != "")
            {
                sqlString = "insert into HOADON (IDHoaDon,IDNhanVien,IDKhachHang,TongTien,NgayBan,IDDiscount" +
                    ",TongTienCuoi) " + "values('" + idBill + "', '" + idEmployee + "', '" + idcustomer + "', "
                    + totalPrice + ", '" + dateSell + "', '" + idDiscount + "', " + finalPrice + ")";
            }
            else
            {
                sqlString = "insert into HOADON (IDHoaDon,IDNhanVien,IDKhachHang,TongTien,NgayBan,TongTienCuoi) " +
                    "values('" + idBill + "', '" + idEmployee + "', '" + idcustomer + "', " + totalPrice + ", '" + dateSell + "', " + finalPrice + ")";
            }
            if (dBMain.MyExecuteNonQuery(sqlString, CommandType.Text, ref error))
                return true;
            else
                return false;

        }
        #endregion

        #region check
        // check id discount
        public bool isDiscount(string id, ref string discount)
        {
            bool t = false;
            string sqlString = "select IDKhuyenMai, GiamGia from KHUYENMAI";
            DataTable dataTable = dBMain.ExecuteQueryDataSet(sqlString, CommandType.Text);
            foreach (DataRow dataRow in dataTable.Rows)
            {
                if (id.ToUpper().Equals(dataRow["IDKhuyenMai"].ToString().Trim()))
                {
                    discount = dataRow["GiamGia"].ToString().Trim();
                    t = true;
                }
            }
            return t;
        }
        #endregion
        
    }
}
