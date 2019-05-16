namespace QuanLyCuaHang
{
    partial class frm_SendProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Send = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cbx_IDBlock = new Bunifu.Framework.UI.BunifuDropdown();
            this.txt_Cancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 22);
            this.label1.TabIndex = 82;
            this.label1.Text = "ID Block:";
            // 
            // btn_Send
            // 
            this.btn_Send.Active = false;
            this.btn_Send.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.btn_Send.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(53)))), ((int)(((byte)(91)))));
            this.btn_Send.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Send.BorderRadius = 0;
            this.btn_Send.ButtonText = "Send";
            this.btn_Send.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Send.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Send.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Send.Iconimage = null;
            this.btn_Send.Iconimage_right = null;
            this.btn_Send.Iconimage_right_Selected = null;
            this.btn_Send.Iconimage_Selected = null;
            this.btn_Send.IconMarginLeft = 0;
            this.btn_Send.IconMarginRight = 0;
            this.btn_Send.IconRightVisible = true;
            this.btn_Send.IconRightZoom = 0D;
            this.btn_Send.IconVisible = true;
            this.btn_Send.IconZoom = 40D;
            this.btn_Send.IsTab = false;
            this.btn_Send.Location = new System.Drawing.Point(9, 69);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(53)))), ((int)(((byte)(91)))));
            this.btn_Send.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.btn_Send.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Send.selected = false;
            this.btn_Send.Size = new System.Drawing.Size(150, 48);
            this.btn_Send.TabIndex = 85;
            this.btn_Send.Text = "Send";
            this.btn_Send.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Send.Textcolor = System.Drawing.Color.White;
            this.btn_Send.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // cbx_IDBlock
            // 
            this.cbx_IDBlock.BackColor = System.Drawing.Color.Transparent;
            this.cbx_IDBlock.BorderRadius = 3;
            this.cbx_IDBlock.DisabledColor = System.Drawing.Color.Gray;
            this.cbx_IDBlock.ForeColor = System.Drawing.Color.White;
            this.cbx_IDBlock.Location = new System.Drawing.Point(98, 12);
            this.cbx_IDBlock.Name = "cbx_IDBlock";
            this.cbx_IDBlock.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(145)))), ((int)(((byte)(24)))));
            this.cbx_IDBlock.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(145)))), ((int)(((byte)(24)))));
            this.cbx_IDBlock.selectedIndex = -1;
            this.cbx_IDBlock.Size = new System.Drawing.Size(215, 35);
            this.cbx_IDBlock.TabIndex = 86;
            // 
            // txt_Cancel
            // 
            this.txt_Cancel.Active = false;
            this.txt_Cancel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.txt_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(53)))), ((int)(((byte)(91)))));
            this.txt_Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txt_Cancel.BorderRadius = 0;
            this.txt_Cancel.ButtonText = "Cancel";
            this.txt_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_Cancel.DisabledColor = System.Drawing.Color.Gray;
            this.txt_Cancel.Iconcolor = System.Drawing.Color.Transparent;
            this.txt_Cancel.Iconimage = null;
            this.txt_Cancel.Iconimage_right = null;
            this.txt_Cancel.Iconimage_right_Selected = null;
            this.txt_Cancel.Iconimage_Selected = null;
            this.txt_Cancel.IconMarginLeft = 0;
            this.txt_Cancel.IconMarginRight = 0;
            this.txt_Cancel.IconRightVisible = true;
            this.txt_Cancel.IconRightZoom = 0D;
            this.txt_Cancel.IconVisible = true;
            this.txt_Cancel.IconZoom = 40D;
            this.txt_Cancel.IsTab = false;
            this.txt_Cancel.Location = new System.Drawing.Point(167, 69);
            this.txt_Cancel.Name = "txt_Cancel";
            this.txt_Cancel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(53)))), ((int)(((byte)(91)))));
            this.txt_Cancel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.txt_Cancel.OnHoverTextColor = System.Drawing.Color.White;
            this.txt_Cancel.selected = false;
            this.txt_Cancel.Size = new System.Drawing.Size(150, 48);
            this.txt_Cancel.TabIndex = 87;
            this.txt_Cancel.Text = "Cancel";
            this.txt_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txt_Cancel.Textcolor = System.Drawing.Color.White;
            this.txt_Cancel.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cancel.Click += new System.EventHandler(this.txt_Cancel_Click);
            // 
            // frm_SendProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(329, 129);
            this.Controls.Add(this.txt_Cancel);
            this.Controls.Add(this.cbx_IDBlock);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_SendProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_SendProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Send;
        private Bunifu.Framework.UI.BunifuDropdown cbx_IDBlock;
        private Bunifu.Framework.UI.BunifuFlatButton txt_Cancel;
    }
}