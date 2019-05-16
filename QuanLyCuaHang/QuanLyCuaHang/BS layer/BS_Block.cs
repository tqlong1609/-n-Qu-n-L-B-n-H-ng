using QuanLyCuaHang.DB_layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHang.BS_layer
{
    class BS_Block
    {
        private DBMain dBMain;

        public BS_Block()
        {
            dBMain = new DBMain();
        }

        // load data block
        public DataTable loadData()
        {
            string sqlString = "Select * from BLOCK";
            return dBMain.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }
        // load amount product within block
        public DataTable loadAmountProduct()
        {
            // return 2 column: name block and amountProduct
            string sqlString = "select BLOCK.IDBlock, COUNT(IDSanPham) AS AmountProduct from BLOCK left outer join SANPHAM " +
                "on BLOCK.IDBlock = SANPHAM.IDBlock group by BLOCK.IDBlock";
            return dBMain.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }
        // update amount product
        public void updateAmount(string amount, string id)
        {
            string error = "";
            string sqlString = "update BLOCK set Amount = '" + amount + "' where IDBlock = '" + id + "'";
            if (!dBMain.MyExecuteNonQuery(sqlString, CommandType.Text, ref error))
                MessageBox.Show("Fail " + error);
        }
        // load id
        public string loadId()
        {
            DataTable dataTable = dBMain.ExecuteQueryDataSet("select IDBlock from BLOCK", CommandType.Text);
            int num = 0;
            foreach (DataRow dataRow in dataTable.Rows)
            {
                if (!dataRow["IDBlock"].ToString().Contains(num.ToString()))
                    return "BLOCK" + num;
                num++;
            }
            return "BLOCK" + num;
        }
        // add block
        public void addBlock(string id, string name)
        {
            string error = "";
            string sqlString = "insert into BLOCK (IDBlock, Name, Amount) values ('"+id+"','"+name+"',0)";
            if (!dBMain.MyExecuteNonQuery(sqlString, CommandType.Text, ref error))
                MessageBox.Show("Fail\n" + error,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            else
                MessageBox.Show("Success","Congratuation",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        // delete block
        public void deleteBlock(string id)
        {
            string error = "";
            string sqlString = "delete from BLOCK where IDBlock = '"+id+"'";
            if (!dBMain.MyExecuteNonQuery(sqlString, CommandType.Text, ref error))
                MessageBox.Show("Fail\n" + error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Success", "Congratuation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        // load id block send
        public DataTable loadIdBlock(string idBlock)
        {
            return dBMain.ExecuteQueryDataSet("select IDBlock from BLOCK where not IDBlock = '"+idBlock+"'", CommandType.Text);
        }
        // send product 
        public void sendProduct(string id_temp, string id_new)
        {
            string sqlString = "select IDBlock from SANPHAM";
            string error = "";
            DataTable dataTable = dBMain.ExecuteQueryDataSet(sqlString, CommandType.Text);
            if (!dBMain.MyExecuteNonQuery("update SANPHAM set IDBlock = '" + id_new + "' where IDBlock = '" + id_temp + "'",
                        CommandType.Text, ref error))
                MessageBox.Show("Fail\n" + error);
        }
        // load name from id
        public void loadName(string id, ref string name)
        {
            DataTable dataTable = dBMain.ExecuteQueryDataSet("Select * from BLOCK", CommandType.Text);
            foreach (DataRow dataRow in dataTable.Rows)
            {
                if (dataRow["IDBlock"].ToString().Trim().Equals(id.Trim()))
                {
                    name = dataRow["Name"].ToString().Trim();
                    return;
                }
            }
        }
        // repaid block
        public bool repaidBlock(string id, string name, ref string error)
        {
            if (dBMain.MyExecuteNonQuery("update BLOCK set Name = N'"+name+"' where IDBlock = '" + id + "'",
                CommandType.Text, ref error)){
                return true;
            }
            return false;
        }
        // Search block
        public DataTable searchBlock(string _search)
        {
            string sqlString = "select * from BLOCK where IDBlock like N'"+_search+"%' or Name like N'"+_search+"%'";
            return dBMain.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }
    }
}
