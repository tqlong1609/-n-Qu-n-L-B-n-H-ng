using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyCuaHang.DB_layer
{
    class DBMain
    {
        string connStr = "Data Source=DESKTOP-LKT5F30;Initial Catalog=QUANLYCUAHANG;Integrated Security=True";
        SqlConnection connect = null;
        SqlCommand command = null;
        SqlDataAdapter adapter = null;

        public DBMain()
        {
            connect = new SqlConnection(connStr);
            command = connect.CreateCommand();
        }

        public DataTable ExecuteQueryDataSet(string strSql, CommandType type)
        {
            if (connect.State == ConnectionState.Open) { connect.Close(); }
            connect.Open();
            command.CommandText = strSql;
            command.CommandType = type;
            adapter = new SqlDataAdapter(command);
            DataTable dataSet = new DataTable();
            adapter.Fill(dataSet);
            return dataSet;
        }

        public bool MyExecuteNonQuery(string strSql, CommandType type, ref string error)
        {
            bool isError = false;
            if (connect.State == ConnectionState.Open) { connect.Close(); }
            connect.Open();
            command.CommandText = strSql;
            command.CommandType = type;
            try
            {
                command.ExecuteNonQuery();
                isError = true;
            }
            catch (SqlException err)
            {
                error = err.Message;
            }
            finally
            {
                connect.Close(); 
            }
            return isError;
        }

    }
}
