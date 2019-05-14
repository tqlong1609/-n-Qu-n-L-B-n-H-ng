namespace QuanLyCuaHang
{
    partial class frm_AddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AddProduct));
            this.btn_Add = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Price = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Name = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Position = new System.Windows.Forms.Label();
            this.txt_Id = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.cbx_IdCategory = new Bunifu.Framework.UI.BunifuDropdown();
            this.pbx_Avatar = new System.Windows.Forms.PictureBox();
            this.cbx_IdBlock = new Bunifu.Framework.UI.BunifuDropdown();
            this.btn_EditPhoto = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cbx_IdDetail = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Add
            // 
            this.btn_Add.Active = false;
            this.btn_Add.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(53)))), ((int)(((byte)(91)))));
            this.btn_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Add.BorderRadius = 0;
            this.btn_Add.ButtonText = "Add";
            this.btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Add.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Add.Iconimage = null;
            this.btn_Add.Iconimage_right = null;
            this.btn_Add.Iconimage_right_Selected = null;
            this.btn_Add.Iconimage_Selected = null;
            this.btn_Add.IconMarginLeft = 0;
            this.btn_Add.IconMarginRight = 0;
            this.btn_Add.IconRightVisible = true;
            this.btn_Add.IconRightZoom = 0D;
            this.btn_Add.IconVisible = true;
            this.btn_Add.IconZoom = 40D;
            this.btn_Add.IsTab = false;
            this.btn_Add.Location = new System.Drawing.Point(44, 467);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(53)))), ((int)(((byte)(91)))));
            this.btn_Add.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.btn_Add.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Add.selected = false;
            this.btn_Add.Size = new System.Drawing.Size(150, 48);
            this.btn_Add.TabIndex = 70;
            this.btn_Add.Text = "Add";
            this.btn_Add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Add.Textcolor = System.Drawing.Color.White;
            this.btn_Add.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(14, 412);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 22);
            this.label5.TabIndex = 65;
            this.label5.Text = "Detail ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 366);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 22);
            this.label4.TabIndex = 63;
            this.label4.Text = "ID Block:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 321);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 22);
            this.label3.TabIndex = 61;
            this.label3.Text = "Price:";
            // 
            // txt_Price
            // 
            this.txt_Price.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(53)))), ((int)(((byte)(91)))));
            this.txt_Price.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(145)))), ((int)(((byte)(24)))));
            this.txt_Price.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(53)))), ((int)(((byte)(91)))));
            this.txt_Price.BorderThickness = 3;
            this.txt_Price.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Price.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Price.ForeColor = System.Drawing.Color.White;
            this.txt_Price.isPassword = false;
            this.txt_Price.Location = new System.Drawing.Point(194, 314);
            this.txt_Price.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Price.MaxLength = 32767;
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(283, 39);
            this.txt_Price.TabIndex = 60;
            this.txt_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 275);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 22);
            this.label2.TabIndex = 59;
            this.label2.Text = "Name:";
            // 
            // txt_Name
            // 
            this.txt_Name.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(53)))), ((int)(((byte)(91)))));
            this.txt_Name.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(145)))), ((int)(((byte)(24)))));
            this.txt_Name.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(53)))), ((int)(((byte)(91)))));
            this.txt_Name.BorderThickness = 3;
            this.txt_Name.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Name.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.ForeColor = System.Drawing.Color.White;
            this.txt_Name.isPassword = false;
            this.txt_Name.Location = new System.Drawing.Point(194, 268);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Name.MaxLength = 32767;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(283, 39);
            this.txt_Name.TabIndex = 58;
            this.txt_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 230);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 22);
            this.label1.TabIndex = 57;
            this.label1.Text = "ID Category:";
            // 
            // lbl_Position
            // 
            this.lbl_Position.AutoSize = true;
            this.lbl_Position.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Position.ForeColor = System.Drawing.Color.White;
            this.lbl_Position.Location = new System.Drawing.Point(14, 184);
            this.lbl_Position.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Position.Name = "lbl_Position";
            this.lbl_Position.Size = new System.Drawing.Size(34, 22);
            this.lbl_Position.TabIndex = 55;
            this.lbl_Position.Text = "ID:";
            // 
            // txt_Id
            // 
            this.txt_Id.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(53)))), ((int)(((byte)(91)))));
            this.txt_Id.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(145)))), ((int)(((byte)(24)))));
            this.txt_Id.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(53)))), ((int)(((byte)(91)))));
            this.txt_Id.BorderThickness = 3;
            this.txt_Id.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Id.Enabled = false;
            this.txt_Id.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Id.ForeColor = System.Drawing.Color.White;
            this.txt_Id.isPassword = false;
            this.txt_Id.Location = new System.Drawing.Point(194, 177);
            this.txt_Id.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Id.MaxLength = 32767;
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(283, 39);
            this.txt_Id.TabIndex = 54;
            this.txt_Id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cbx_IdCategory
            // 
            this.cbx_IdCategory.BackColor = System.Drawing.Color.Transparent;
            this.cbx_IdCategory.BorderRadius = 3;
            this.cbx_IdCategory.DisabledColor = System.Drawing.Color.Gray;
            this.cbx_IdCategory.ForeColor = System.Drawing.Color.White;
            this.cbx_IdCategory.Location = new System.Drawing.Point(195, 227);
            this.cbx_IdCategory.Name = "cbx_IdCategory";
            this.cbx_IdCategory.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(145)))), ((int)(((byte)(24)))));
            this.cbx_IdCategory.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(145)))), ((int)(((byte)(24)))));
            this.cbx_IdCategory.selectedIndex = -1;
            this.cbx_IdCategory.Size = new System.Drawing.Size(283, 35);
            this.cbx_IdCategory.TabIndex = 71;
            // 
            // pbx_Avatar
            // 
            this.pbx_Avatar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbx_Avatar.BackgroundImage")));
            this.pbx_Avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbx_Avatar.Location = new System.Drawing.Point(171, 5);
            this.pbx_Avatar.Margin = new System.Windows.Forms.Padding(2);
            this.pbx_Avatar.Name = "pbx_Avatar";
            this.pbx_Avatar.Size = new System.Drawing.Size(150, 113);
            this.pbx_Avatar.TabIndex = 92;
            this.pbx_Avatar.TabStop = false;
            // 
            // cbx_IdBlock
            // 
            this.cbx_IdBlock.BackColor = System.Drawing.Color.Transparent;
            this.cbx_IdBlock.BorderRadius = 3;
            this.cbx_IdBlock.DisabledColor = System.Drawing.Color.Gray;
            this.cbx_IdBlock.ForeColor = System.Drawing.Color.White;
            this.cbx_IdBlock.Location = new System.Drawing.Point(195, 366);
            this.cbx_IdBlock.Name = "cbx_IdBlock";
            this.cbx_IdBlock.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(145)))), ((int)(((byte)(24)))));
            this.cbx_IdBlock.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(145)))), ((int)(((byte)(24)))));
            this.cbx_IdBlock.selectedIndex = -1;
            this.cbx_IdBlock.Size = new System.Drawing.Size(283, 35);
            this.cbx_IdBlock.TabIndex = 93;
            // 
            // btn_EditPhoto
            // 
            this.btn_EditPhoto.Active = false;
            this.btn_EditPhoto.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.btn_EditPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(53)))), ((int)(((byte)(91)))));
            this.btn_EditPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_EditPhoto.BorderRadius = 0;
            this.btn_EditPhoto.ButtonText = "Edit Photo";
            this.btn_EditPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_EditPhoto.DisabledColor = System.Drawing.Color.Gray;
            this.btn_EditPhoto.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_EditPhoto.Iconimage = null;
            this.btn_EditPhoto.Iconimage_right = null;
            this.btn_EditPhoto.Iconimage_right_Selected = null;
            this.btn_EditPhoto.Iconimage_Selected = null;
            this.btn_EditPhoto.IconMarginLeft = 0;
            this.btn_EditPhoto.IconMarginRight = 0;
            this.btn_EditPhoto.IconRightVisible = true;
            this.btn_EditPhoto.IconRightZoom = 0D;
            this.btn_EditPhoto.IconVisible = true;
            this.btn_EditPhoto.IconZoom = 40D;
            this.btn_EditPhoto.IsTab = false;
            this.btn_EditPhoto.Location = new System.Drawing.Point(171, 123);
            this.btn_EditPhoto.Name = "btn_EditPhoto";
            this.btn_EditPhoto.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(53)))), ((int)(((byte)(91)))));
            this.btn_EditPhoto.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.btn_EditPhoto.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_EditPhoto.selected = false;
            this.btn_EditPhoto.Size = new System.Drawing.Size(150, 48);
            this.btn_EditPhoto.TabIndex = 94;
            this.btn_EditPhoto.Text = "Edit Photo";
            this.btn_EditPhoto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_EditPhoto.Textcolor = System.Drawing.Color.White;
            this.btn_EditPhoto.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditPhoto.Click += new System.EventHandler(this.btn_EditPhoto_Click);
            // 
            // cbx_IdDetail
            // 
            this.cbx_IdDetail.BackColor = System.Drawing.Color.Transparent;
            this.cbx_IdDetail.BorderRadius = 3;
            this.cbx_IdDetail.DisabledColor = System.Drawing.Color.Gray;
            this.cbx_IdDetail.ForeColor = System.Drawing.Color.White;
            this.cbx_IdDetail.Location = new System.Drawing.Point(195, 412);
            this.cbx_IdDetail.Name = "cbx_IdDetail";
            this.cbx_IdDetail.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(145)))), ((int)(((byte)(24)))));
            this.cbx_IdDetail.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(145)))), ((int)(((byte)(24)))));
            this.cbx_IdDetail.selectedIndex = -1;
            this.cbx_IdDetail.Size = new System.Drawing.Size(283, 35);
            this.cbx_IdDetail.TabIndex = 95;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Active = false;
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(53)))), ((int)(((byte)(91)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Cancel";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 40D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(280, 467);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(53)))), ((int)(((byte)(91)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(150, 48);
            this.bunifuFlatButton1.TabIndex = 96;
            this.bunifuFlatButton1.Text = "Cancel";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // frm_AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(490, 527);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.cbx_IdDetail);
            this.Controls.Add(this.btn_EditPhoto);
            this.Controls.Add(this.cbx_IdBlock);
            this.Controls.Add(this.pbx_Avatar);
            this.Controls.Add(this.cbx_IdCategory);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Price);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Position);
            this.Controls.Add(this.txt_Id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_AddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_FindSP";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btn_Add;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Price;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Position;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Id;
        private Bunifu.Framework.UI.BunifuDropdown cbx_IdCategory;
        private System.Windows.Forms.PictureBox pbx_Avatar;
        private Bunifu.Framework.UI.BunifuDropdown cbx_IdBlock;
        private Bunifu.Framework.UI.BunifuFlatButton btn_EditPhoto;
        private Bunifu.Framework.UI.BunifuDropdown cbx_IdDetail;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
    }
}