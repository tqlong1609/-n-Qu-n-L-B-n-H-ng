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
        // add customer
        public bool addCustomer(string id, string name, int phone, string address, bool isFemale,ref string error)
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
    }
}
