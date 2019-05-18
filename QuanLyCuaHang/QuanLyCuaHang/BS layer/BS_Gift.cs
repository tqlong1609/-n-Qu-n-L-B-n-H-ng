using QuanLyCuaHang.DB_layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHang.BS_layer
{
    class BS_Gift
    {
        private DBMain dBMain;

        public BS_Gift()
        {
            dBMain = new DBMain();
        }
        #region load
        // load data
        public DataTable loadData()
        {
            return dBMain.ExecuteQueryDataSet("Select * from KHUYENMAI", CommandType.Text);
        }
        #endregion

        #region handle
        // add gift
        public bool addGift(string id, int giamgia,ref string error)
        {
            string sqlString = "insert into KHUYENMAI (IDKhuyenMai, GiamGia) values ('"+id.ToUpper()+"','"+giamgia+"%')";
            if (dBMain.MyExecuteNonQuery(sqlString, CommandType.Text, ref error))
                return true;
            return false;
        }
        // delete gift
        public bool deleteGift(string id,ref string error)
        {
            string sqlString = "delete from KHUYENMAI where IDKhuyenMai = '"+id+"'";
            if (dBMain.MyExecuteNonQuery(sqlString, CommandType.Text, ref error))
                return true;
            return false;
        }
        // repaid gift
        public bool repaidGift(string id,string idnew, int discount,ref string error)
        {
            string sqlString = "update KHUYENMAI set IDKhuyenMai = '"+ idnew + "', GiamGia = '"+discount+"%'" +
                " where IDKhuyenMai = '"+id+"'";
            if (dBMain.MyExecuteNonQuery(sqlString, CommandType.Text, ref error))
                return true;
            return false;
        }
        #endregion

        #region check
        // check exist id
        public bool isEsixt(string id)
        {
            DataTable dataTable = loadData();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                if (dataRow["IDKhuyenMai"].ToString().Trim().Equals(id.ToUpper()))
                    return true;
            }
            return false;
        }
        // check exist id
        public bool isEsixt(string id,string idnew)
        {
            DataTable dataTable = dBMain.ExecuteQueryDataSet("select * from KHUYENMAI where not IDKhuyenMai = '" + idnew + "'",
                CommandType.Text);
            foreach (DataRow dataRow in dataTable.Rows)
            {
                if (dataRow["IDKhuyenMai"].ToString().Trim().Equals(id.ToUpper()))
                    return true;
            }
            return false;
        }
        #endregion
    }
}
