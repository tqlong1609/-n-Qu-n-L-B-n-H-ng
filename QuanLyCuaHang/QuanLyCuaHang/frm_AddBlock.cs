using QuanLyCuaHang.BS_layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHang
{
    public partial class frm_AddBlock : Form
    {
        private Mode mode;
        private BS_Block bS_Block;
        public static bool isUpdate =false;

        private enum Mode { add, repaid};

        public frm_AddBlock()
        {
            InitializeComponent();
            bS_Block = new BS_Block();
            loadId();
            mode = Mode.add;
        }

        public frm_AddBlock(string id)
        {
            InitializeComponent();
            bS_Block = new BS_Block();
            txt_id.Text = id;
            btn_Add.Text = "Repaid";
            loadName(id);
            mode = Mode.repaid;
        }
        // load name from id
        private void loadName(string id)
        {
            string name = "";
            bS_Block.loadName(id, ref name);
            txt_Name.Text = name;
        }
        // load id block
        private void loadId()
        {
            string id = bS_Block.loadId();
            txt_id.Text = id;
        }
        private void btn_Find_Click(object sender, EventArgs e)
        {
            //add 
            if (mode == Mode.add)
            {
                if (!isEmpty())
                {
                    bS_Block.addBlock(txt_id.Text, txt_Name.Text);
                    isUpdate = true;
                    this.Close();
                }
                else MessageBox.Show("Empty values input", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else // repaid
            {
                string error = "";
                if (txt_Name.Text != "")
                {
                    if (bS_Block.repaidBlock(txt_id.Text, txt_Name.Text, ref error))
                    {
                        MessageBox.Show("Success", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        isUpdate = true;
                        this.Close();
                    }
                    else MessageBox.Show("Fail\n" + error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Do not enter empty values","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        // check empty input
        private bool isEmpty()
        {
            if (txt_Name.Text == "")
                return true;
            return false;
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
