using QuanLyCuaHang.DB_layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyCuaHang.BS_layer
{
    class BS_Customer
    {
        private DBMain dBMain;

        public BS_Customer()
        {
            dBMain = new DBMain();
        }
        #region load
        // load data all
        public DataTable loadDataAll()
        {
            return dBMain.ExecuteQueryDataSet("select * from KHACHHANG", CommandType.Text);
        }
        // load id
        public string loadId()
        {
            DataTable dataTable = dBMain.ExecuteQueryDataSet("select IDKhachHang from KHACHHANG", CommandType.Text);
            int num = 0;
            foreach (DataRow dataRow in dataTable.Rows)
            {
                if (!dataRow["IDKhachHang"].ToString().Contains(num.ToString()))
                    return "KH" + num;
                num++;
            }
            return "KH" + num;
        }
        // load data from id
        public DataTable loadDataFromId(string id)
        {
            string sqlString = "select * from KHACHHANG where IDKhachHang = '" + id + "'";
            return dBMain.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }
        #endregion

        #region handle
        // add customer
        public bool addCustomer(string id, string name, string phone, string address, bool isFemale,ref string error)
        {
            byte _isFemale = 0;
            if (isFemale) _isFemale = 1;
                string sqlString = "insert into KHACHHANG (IDKhachHang, Name, phoneNumber, Address, gender) " +
                    "values ('" + id + "',N'" + name + "','" + phone + "',N'" + address + "',"+_isFemale+")";
            if (dBMain.MyExecuteNonQuery(sqlString, CommandType.Text, ref error)) return true;
            return false;
        }
        // delete customer
        public bool deleteCustomer(string id, ref string error)
        {
            string sqlString = "delete from KHACHHANG where IDKhachHang = '"+id+"'";
            if (dBMain.MyExecuteNonQuery(sqlString, CommandType.Text, ref error))
                return true;
            return false;
        }
        // repaid customer
        public bool repaidCustomer(string id, string name, string phone, string address, bool gender,ref string error)
        {
            byte _gender = 0;
            if (gender) _gender = 1;
            string sqlString = "update KHACHHANG set name = N'"+name+"', phoneNumber = '"+phone+"'," +
                " Address = N'"+address+"', gender = "+_gender+" where IDKhachHang = '"+id+"'";
            if (dBMain.MyExecuteNonQuery(sqlString, CommandType.Text, ref error))
                return true;
            return false;
        }
        // Search customer
        public DataTable searchCustomer(string _search)
        {
            string sqlString = "select * from KHACHHANG where IDKhachHang like '" + _search + "%' or Name like N'" + _search + "%' " +
                "or phoneNumber like '" + _search + "%' or Address like N'" + _search + "%'";
            return dBMain.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }
        #endregion
    }
}
