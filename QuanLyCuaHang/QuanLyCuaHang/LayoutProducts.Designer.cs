namespace QuanLyCuaHang
{
    partial class LayoutProducts
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnShowDetail = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlDetail = new System.Windows.Forms.Panel();
            this.lblGia = new System.Windows.Forms.Label();
            this.lblTenSanPham = new System.Windows.Forms.Label();
            this.pbxSanPham = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowDetail
            // 
            this.btnShowDetail.Active = false;
            this.btnShowDetail.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnShowDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnShowDetail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShowDetail.BorderRadius = 0;
            this.btnShowDetail.ButtonText = "Detail";
            this.btnShowDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowDetail.DisabledColor = System.Drawing.Color.Gray;
            this.btnShowDetail.Iconcolor = System.Drawing.Color.Transparent;
            this.btnShowDetail.Iconimage = null;
            this.btnShowDetail.Iconimage_right = null;
            this.btnShowDetail.Iconimage_right_Selected = null;
            this.btnShowDetail.Iconimage_Selected = null;
            this.btnShowDetail.IconMarginLeft = 0;
            this.btnShowDetail.IconMarginRight = 0;
            this.btnShowDetail.IconRightVisible = true;
            this.btnShowDetail.IconRightZoom = 0D;
            this.btnShowDetail.IconVisible = true;
            this.btnShowDetail.IconZoom = 90D;
            this.btnShowDetail.IsTab = false;
            this.btnShowDetail.Location = new System.Drawing.Point(125, 251);
            this.btnShowDetail.Name = "btnShowDetail";
            this.btnShowDetail.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnShowDetail.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnShowDetail.OnHoverTextColor = System.Drawing.Color.White;
            this.btnShowDetail.selected = false;
            this.btnShowDetail.Size = new System.Drawing.Size(59, 25);
            this.btnShowDetail.TabIndex = 13;
            this.btnShowDetail.Text = "Detail";
            this.btnShowDetail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnShowDetail.Textcolor = System.Drawing.Color.White;
            this.btnShowDetail.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowDetail.Click += new System.EventHandler(this.btnShowDetail_Click_1);
            // 
            // pnlDetail
            // 
            this.pnlDetail.Location = new System.Drawing.Point(4, 3);
            this.pnlDetail.Name = "pnlDetail";
            this.pnlDetail.Size = new System.Drawing.Size(180, 234);
            this.pnlDetail.TabIndex = 12;
            this.pnlDetail.Visible = false;
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGia.Location = new System.Drawing.Point(4, 216);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(52, 21);
            this.lblGia.TabIndex = 9;
            this.lblGia.Text = "Price:";
            // 
            // lblTenSanPham
            // 
            this.lblTenSanPham.AutoSize = true;
            this.lblTenSanPham.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSanPham.Location = new System.Drawing.Point(4, 192);
            this.lblTenSanPham.Name = "lblTenSanPham";
            this.lblTenSanPham.Size = new System.Drawing.Size(60, 15);
            this.lblTenSanPham.TabIndex = 8;
            this.lblTenSanPham.Text = "Sản phẩm";
            // 
            // pbxSanPham
            // 
            this.pbxSanPham.Location = new System.Drawing.Point(4, 3);
            this.pbxSanPham.Name = "pbxSanPham";
            this.pbxSanPham.Size = new System.Drawing.Size(180, 179);
            this.pbxSanPham.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSanPham.TabIndex = 7;
            this.pbxSanPham.TabStop = false;
            // 
            // LayoutProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.Controls.Add(this.btnShowDetail);
            this.Controls.Add(this.pnlDetail);
            this.Controls.Add(this.lblGia);
            this.Controls.Add(this.lblTenSanPham);
            this.Controls.Add(this.pbxSanPham);
            this.Name = "LayoutProducts";
            this.Size = new System.Drawing.Size(188, 279);
            ((System.ComponentModel.ISupportInitialize)(this.pbxSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnShowDetail;
        private System.Windows.Forms.Panel pnlDetail;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Label lblTenSanPham;
        private System.Windows.Forms.PictureBox pbxSanPham;
    }
}
