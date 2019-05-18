using QuanLyCuaHang.DB_layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHang.BS_layer
{

    class BS_History
    {
        private DBMain dBMain;

        public BS_History()
        {
            dBMain = new DBMain();
        }
        #region load
        // load data
        public DataTable loadData()
        {
            return dBMain.ExecuteQueryDataSet("select * from HOADON", CommandType.Text);
        }
        #endregion

        #region handle
        // delete data
        public bool deleteHoaDon(string id, ref string error)
        {
            if (!dBMain.MyExecuteNonQuery("delete from HOADON where IDHoaDon = '" + id + "'", CommandType.Text,
                ref error))
                return false;
            return true;
        }
        // search hoa don
        public DataTable searchHoaDon(string _search)
        {
            string sqlString = "select * from HOADON where IDHoaDon like '"+_search+"%' or IDNhanVien like '"+_search+"%' " +
                "or IDKhachHang like '"+_search+"%' or NgayBan like '%"+_search+"%'";
            return dBMain.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }
        #endregion
    }
}
