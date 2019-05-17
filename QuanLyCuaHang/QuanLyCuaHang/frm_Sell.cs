using QuanLyCuaHang.BS_layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHang
{
    public partial class frm_Sell : Form
    {
        private BS_SellProduct bS_SellProduct;

        public frm_Sell(string name, int total, string dateSell, string idDiscount, string discount)
        {
            InitializeComponent();
            bS_SellProduct = new BS_SellProduct();
            loadData(name, total, dateSell, idDiscount);
            loadIdBill();
            if (idDiscount == "")
                discount = "0%";
            txt_FinalTotal.Text = formatMoney(getFinalPrice(discount, total).ToString());
        }
        private string formatMoney(string money)
        {
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");   // try with "en-US"
            return double.Parse(money).ToString("#,###", cul.NumberFormat);
        }
        private void loadData(string idCus, int total,string dateSell,string idDis)
        {
            txt_idEmployee.Text = frm_Login.id;
            txt_idCustomer.Text = idCus;
            txt_TotalPrice.Text = formatMoney(total.ToString());
            txt_DateSell.Text = dateSell;
            txt_idDiscount.Text = idDis;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // load id bill
        private void loadIdBill()
        {
            txt_idBill.Text = bS_SellProduct.loadId();
        }
        // get final total price
        private double getFinalPrice(string _discount, int price)
        {
            int idcount = int.Parse(_discount.Split('%')[0]);
            return price - ((price * idcount) / 100);
        }

    }
}
