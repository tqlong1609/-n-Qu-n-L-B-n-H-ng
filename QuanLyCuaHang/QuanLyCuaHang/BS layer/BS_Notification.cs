using QuanLyCuaHang.DB_layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHang.BS_layer
{
    class BS_Notification
    {
        private DBMain dBMain;

        public BS_Notification()
        {
            dBMain = new DBMain();
        }
        
        #region load
        // load id
        public string loadId()
        {
            DataTable dataTable = dBMain.ExecuteQueryDataSet("select IDThongBao from THONGBAO", CommandType.Text);
            int num = 0;
            foreach (DataRow dataRow in dataTable.Rows)
            {
                if (!dataRow["IDThongBao"].ToString().Contains(num.ToString()))
                    return "TB" + num;
                num++;
            }
            return "TB" + num;
        }
        // load notification from id
        public DataTable loadNotification(string id)
        {
            return dBMain.ExecuteQueryDataSet("select IDThongBao ,NoiDung, TrangThai from THONGBAO where IDNhanVien = '"+id+"'",
                CommandType.Text);
        }
        #endregion

        #region check
        // check state readed
        public bool checkState(string id, ref string error)
        {
            if (dBMain.MyExecuteNonQuery("update THONGBAO set TrangThai = 1 where IDThongBao = '" + id + "'", CommandType.Text, ref error))
                return true;
            return false;
        }
        #endregion

        #region handle
        // send notification
        public bool sendNotification(string idEmployee, string context, ref string error)
        {
            string id = loadId();
            if (dBMain.MyExecuteNonQuery("insert into THONGBAO (IDThongBao,IDNhanVien,NoiDung) " +
                "values ('" + id + "','" + idEmployee + "',N'" + context + "')",
                System.Data.CommandType.Text, ref error))
                return true;
            return false;
        }
        //remove notification from id employee
        public bool removeNotIdEmployee(string id,ref string error)
        {
            if (dBMain.MyExecuteNonQuery("delete from THONGBAO where IDNhanVien = '"+id+"'", CommandType.Text, ref error))
                return true;
            return false;
        }
        // remove notification from id notification
        public bool removeNotIdNotificate(string id, ref string error)
        {
            if (dBMain.MyExecuteNonQuery("delete from THONGBAO where IDThongBao = '" + id + "'", CommandType.Text, ref error))
                return true;
            return false;
        }
        #endregion
    }
}
