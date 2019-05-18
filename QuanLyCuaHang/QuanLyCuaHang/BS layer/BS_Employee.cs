using QuanLyCuaHang.DB_layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHang.BS_layer
{
    class BS_Employee
    {
        DBMain db = null;
        DataTable dataTable;

        public BS_Employee()
        {
            db = new DBMain();
        }
        #region check
        // check login account
        public bool checkAccount(string _taikhoan, string _matkhau, ref string _position)
        {
            dataTable = new DataTable();
            dataTable = db.ExecuteQueryDataSet("select IDNhanVien, Password, Position from NHANVIEN", CommandType.Text);
            foreach (DataRow dataRow in dataTable.Rows)
            {
                if ((_taikhoan.Equals(dataRow["IDNhanVien"].ToString().Trim()))
                    && (_matkhau.Equals(dataRow["PassWord"].ToString().Trim())))
                {
                    _position = (string)dataRow["Position"].ToString().Trim();
                    return true;
                }
            }
            return false;
        }
        // check exist id
        public bool isExistId(string id)
        {
            DataTable dataTable = new DataTable();
            dataTable = db.ExecuteQueryDataSet("select IDNhanVien from NHANVIEN", CommandType.Text);
            foreach (DataRow dataRow in dataTable.Rows)
            {
                if (id.Equals(dataRow["IDNhanVien"].ToString().Trim()))
                {
                    return true;
                }
            }
            return false;
        }
        #endregion

        #region load
        // load data salesman
        public DataTable loadDataSalesMan()
        {
            return db.ExecuteQueryDataSet("select IDNhanVien, Password, Name,PhoneNumber, IDCard, Address " +
                "from NHANVIEN where Position = 'employee'",
                CommandType.Text);
        }
        // load data all employee
        public DataTable loadDataEmployee()
        {
            return db.ExecuteQueryDataSet("select IDNhanVien, Password, Name,PhoneNumber, IDCard, Address " +
                "from NHANVIEN where Position = 'employee' or Position = 'warehouse'",
                CommandType.Text);
        }
        // load data all ware house staff
        public DataTable loadDataWareHouseStaff()
        {
            return db.ExecuteQueryDataSet("select IDNhanVien, Password, Name,PhoneNumber, IDCard, Address " +
                "from NHANVIEN where Position = 'warehouse'",
                CommandType.Text);
        }
        // load information employee from id
        public void getDataEmployee(string id, ref string _password, ref string _name, ref string _phone, ref string _idcard
                                    , ref string _address, ref string _urlImage)
        {
            dataTable = new DataTable();
            dataTable = db.ExecuteQueryDataSet("select IDNhanVien, Password, Name, PhoneNumber, IDCard, Address, UrlImage from NHANVIEN"
                , CommandType.Text);
            foreach (DataRow dataRow in dataTable.Rows)
            {
                if (id.Equals(dataRow["IDNhanVien"].ToString().Trim()))
                {
                    _password = (string)dataRow["Password"].ToString().Trim();
                    _name = (string)dataRow["Name"].ToString().Trim();
                    _phone = (string)dataRow["PhoneNumber"].ToString().Trim();
                    _idcard = (string)dataRow["IDCard"].ToString().Trim();
                    _address = (string)dataRow["Address"].ToString().Trim();
                    _urlImage = dataRow["UrlImage"].ToString().Trim();
                }
            }
        }
        // load date employee all
        public void loadDataEmployeeAll(string id, ref string _password, ref string _name, ref string _phone, ref string _idcard
                                    , ref string _address, ref string position, ref string _urlImage)
        {
            DataTable dataTable = db.ExecuteQueryDataSet("select * from NHANVIEN", CommandType.Text);
            foreach (DataRow dataRow in dataTable.Rows)
            {
                if (id.Equals(dataRow["IDNhanVien"].ToString().Trim()))
                {
                    _password = (string)dataRow["Password"].ToString().Trim();
                    _name = (string)dataRow["Name"].ToString().Trim();
                    _phone = (string)dataRow["PhoneNumber"].ToString().Trim();
                    _idcard = (string)dataRow["IDCard"].ToString().Trim();
                    _address = (string)dataRow["Address"].ToString().Trim();
                    position = (string)dataRow["Position"].ToString().Trim();
                    _urlImage = dataRow["UrlImage"].ToString().Trim();
                }
            }
        }
        // load id employee
        public DataTable loadIdEmployee(string id)
        {
            return db.ExecuteQueryDataSet("select IDNhanVien from NHANVIEN where not IDNhanVien = '" + id + "'", CommandType.Text);
        }
        #endregion

        #region convert
        // convert image to byte
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

        #region handle
        // update information employee
        public void setDataEmployee(string id, string idNew, string password
                                    , string name, string phone, string idcard, string address, string path, ref string error)
        {
            string sqlString;
            if (path != null)
            {
                byte[] imgdata = converImgToByte(path);
                sqlString = "update NHANVIEN set idnhanvien = '" + idNew + "', Password = '" + password + "', Name = N'" + name + "'," +
                " PhoneNumber = '" + phone + "', IDCard = '" + idcard + "', Address = N'" + address + "', UrlImage = '"
                + Convert.ToBase64String(imgdata)
                + "'where IDNhanVien = '" + id + "' ";
            }
            else
            {
                sqlString = "update NHANVIEN set idnhanvien = '" + idNew + "', Password = '" + password + "', Name = N'" + name + "'," +
                " PhoneNumber = '" + phone + "', IDCard = '" + idcard + "', Address = N'" + address
                + "'where IDNhanVien = '" + id + "' ";
            }
            db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }
        // add employee
        public void addEmployee(string username, string password, string name, string phone, string idcard,
            string address, string position, string path, ref string error)
        {
            string sqlString;
            if (path == null)
            {
                sqlString = "insert into NHANVIEN (IDNhanVien, Password, Name, " +
                    "PhoneNumber, IDCard, Address, Position) " +
                    "values ('" + username + "', '" + password + "', N'" + name + "', '" + phone + "', '" + idcard + "'" +
                    ", N'" + address + "', '" + position + "')";
            }
            else
            {
                byte[] imgdata = converImgToByte(path);
                sqlString = "insert into NHANVIEN (IDNhanVien, Password, Name, " +
                    "PhoneNumber, IDCard, Address, Position,UrlImage) " +
                    "values ('" + username + "', '" + password + "', N'" + name + "', '" + phone + "', '" + idcard + "', N'" + address + "'" +
                    ", '" + position + "', '" + Convert.ToBase64String(imgdata) + "')";
            }
            if (db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error))
                MessageBox.Show("Success", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Fail", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        // delete employee
        public void deleteEmployee(string id, ref string error)
        {
            string sqlString = "delete from NHANVIEN where IDNhanVien = '" + id.Trim() + "'";
            db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }
        // repaid
        public void repaidDataEmployee(string id, string password, string name, string phone, string idcard
            , string address, string position, string path, ref string error)
        {
            string sqlString;
            if (path == null)
            {
                sqlString = "update NHANVIEN set Password = '" + password + "', Name = N'" + name + "'," +
                    " PhoneNumber = '" + phone + "', IDCard = '" + idcard + "', Address = N'" + address + "'" +
                    ",Position = '" + position + "'where IDNhanVien = '" + id + "'";
            }
            else
            {
                byte[] imgdata = converImgToByte(path);
                sqlString = "update NHANVIEN set Password = '" + password + "', Name = N'" + name + "'," +
                    " PhoneNumber = '" + phone + "', IDCard = '" + idcard + "', Address = N'" + address + "'" +
                    ",Position = '" + position + "',UrlImage = '" + Convert.ToBase64String(imgdata) + "'where IDNhanVien = '" + id + "'";
            }
            if (db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error))
            { MessageBox.Show("Repaid success", "Congratuation", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else
            { MessageBox.Show("Repaid fail", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        // search
        public DataTable searchEmployee(string _search)
        {
            return db.ExecuteQueryDataSet("select IDNhanVien, Password, Name, PhoneNumber," +
                "IdCard, Address from NHANVIEN where (Position = 'employee' or Position = 'warehouse') and (IDNhanVien like '" + _search + "%"
                + "' or Name like N'" + _search + "%" + "' or address like N'" + _search + "%" + "')", CommandType.Text);
        }
        #endregion
    }
}
