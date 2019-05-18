namespace QuanLyCuaHang
{
    partial class uct_ProductView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uct_ProductView));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Laptop = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_ExtraDevice = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_SmartPhone = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_All = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txt_Search = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btn_Find = new Bunifu.Framework.UI.BunifuTileButton();
            this.dataGid_Device = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.IDSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDBlock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateSell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbx_Avatar = new System.Windows.Forms.PictureBox();
            this.btn_Watch = new Bunifu.Framework.UI.BunifuTileButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGid_Device)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Laptop
            // 
            this.btn_Laptop.Active = true;
            this.btn_Laptop.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(145)))), ((int)(((byte)(24)))));
            this.btn_Laptop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(145)))), ((int)(((byte)(24)))));
            this.btn_Laptop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Laptop.BorderRadius = 0;
            this.btn_Laptop.ButtonText = "Laptop";
            this.btn_Laptop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Laptop.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Laptop.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Laptop.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Laptop.Iconimage = null;
            this.btn_Laptop.Iconimage_right = null;
            this.btn_Laptop.Iconimage_right_Selected = null;
            this.btn_Laptop.Iconimage_Selected = null;
            this.btn_Laptop.IconMarginLeft = 0;
            this.btn_Laptop.IconMarginRight = 0;
            this.btn_Laptop.IconRightVisible = true;
            this.btn_Laptop.IconRightZoom = 0D;
            this.btn_Laptop.IconVisible = true;
            this.btn_Laptop.IconZoom = 40D;
            this.btn_Laptop.IsTab = true;
            this.btn_Laptop.Location = new System.Drawing.Point(0, 0);
            this.btn_Laptop.Name = "btn_Laptop";
            this.btn_Laptop.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            this.btn_Laptop.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(145)))), ((int)(((byte)(24)))));
            this.btn_Laptop.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Laptop.selected = true;
            this.btn_Laptop.Size = new System.Drawing.Size(172, 57);
            this.btn_Laptop.TabIndex = 16;
            this.btn_Laptop.Text = "Laptop";
            this.btn_Laptop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Laptop.Textcolor = System.Drawing.Color.White;
            this.btn_Laptop.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Laptop.Click += new System.EventHandler(this.btn_Laptop_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btn_ExtraDevice);
            this.panel1.Controls.Add(this.btn_SmartPhone);
            this.panel1.Controls.Add(this.btn_All);
            this.panel1.Controls.Add(this.btn_Laptop);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(691, 57);
            this.panel1.TabIndex = 84;
            // 
            // btn_ExtraDevice
            // 
            this.btn_ExtraDevice.Active = false;
            this.btn_ExtraDevice.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(145)))), ((int)(((byte)(24)))));
            this.btn_ExtraDevice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            this.btn_ExtraDevice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ExtraDevice.BorderRadius = 0;
            this.btn_ExtraDevice.ButtonText = "Extra Device";
            this.btn_ExtraDevice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ExtraDevice.DisabledColor = System.Drawing.Color.Gray;
            this.btn_ExtraDevice.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_ExtraDevice.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_ExtraDevice.Iconimage = null;
            this.btn_ExtraDevice.Iconimage_right = null;
            this.btn_ExtraDevice.Iconimage_right_Selected = null;
            this.btn_ExtraDevice.Iconimage_Selected = null;
            this.btn_ExtraDevice.IconMarginLeft = 0;
            this.btn_ExtraDevice.IconMarginRight = 0;
            this.btn_ExtraDevice.IconRightVisible = true;
            this.btn_ExtraDevice.IconRightZoom = 0D;
            this.btn_ExtraDevice.IconVisible = true;
            this.btn_ExtraDevice.IconZoom = 40D;
            this.btn_ExtraDevice.IsTab = true;
            this.btn_ExtraDevice.Location = new System.Drawing.Point(347, 0);
            this.btn_ExtraDevice.Name = "btn_ExtraDevice";
            this.btn_ExtraDevice.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            this.btn_ExtraDevice.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(145)))), ((int)(((byte)(24)))));
            this.btn_ExtraDevice.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_ExtraDevice.selected = false;
            this.btn_ExtraDevice.Size = new System.Drawing.Size(172, 57);
            this.btn_ExtraDevice.TabIndex = 19;
            this.btn_ExtraDevice.Text = "Extra Device";
            this.btn_ExtraDevice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_ExtraDevice.Textcolor = System.Drawing.Color.White;
            this.btn_ExtraDevice.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExtraDevice.Click += new System.EventHandler(this.btn_ExtraDevice_Click);
            // 
            // btn_SmartPhone
            // 
            this.btn_SmartPhone.Active = false;
            this.btn_SmartPhone.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(145)))), ((int)(((byte)(24)))));
            this.btn_SmartPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            this.btn_SmartPhone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_SmartPhone.BorderRadius = 0;
            this.btn_SmartPhone.ButtonText = "Smart Phone";
            this.btn_SmartPhone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SmartPhone.DisabledColor = System.Drawing.Color.Gray;
            this.btn_SmartPhone.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_SmartPhone.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_SmartPhone.Iconimage = null;
            this.btn_SmartPhone.Iconimage_right = null;
            this.btn_SmartPhone.Iconimage_right_Selected = null;
            this.btn_SmartPhone.Iconimage_Selected = null;
            this.btn_SmartPhone.IconMarginLeft = 0;
            this.btn_SmartPhone.IconMarginRight = 0;
            this.btn_SmartPhone.IconRightVisible = true;
            this.btn_SmartPhone.IconRightZoom = 0D;
            this.btn_SmartPhone.IconVisible = true;
            this.btn_SmartPhone.IconZoom = 40D;
            this.btn_SmartPhone.IsTab = true;
            this.btn_SmartPhone.Location = new System.Drawing.Point(172, 0);
            this.btn_SmartPhone.Name = "btn_SmartPhone";
            this.btn_SmartPhone.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            this.btn_SmartPhone.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(145)))), ((int)(((byte)(24)))));
            this.btn_SmartPhone.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_SmartPhone.selected = false;
            this.btn_SmartPhone.Size = new System.Drawing.Size(172, 57);
            this.btn_SmartPhone.TabIndex = 18;
            this.btn_SmartPhone.Text = "Smart Phone";
            this.btn_SmartPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_SmartPhone.Textcolor = System.Drawing.Color.White;
            this.btn_SmartPhone.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SmartPhone.Click += new System.EventHandler(this.btn_SmartPhone_Click);
            // 
            // btn_All
            // 
            this.btn_All.Active = false;
            this.btn_All.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(145)))), ((int)(((byte)(24)))));
            this.btn_All.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            this.btn_All.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_All.BorderRadius = 0;
            this.btn_All.ButtonText = "All of them";
            this.btn_All.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_All.DisabledColor = System.Drawing.Color.Gray;
            this.btn_All.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_All.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_All.Iconimage = null;
            this.btn_All.Iconimage_right = null;
            this.btn_All.Iconimage_right_Selected = null;
            this.btn_All.Iconimage_Selected = null;
            this.btn_All.IconMarginLeft = 0;
            this.btn_All.IconMarginRight = 0;
            this.btn_All.IconRightVisible = true;
            this.btn_All.IconRightZoom = 0D;
            this.btn_All.IconVisible = true;
            this.btn_All.IconZoom = 40D;
            this.btn_All.IsTab = true;
            this.btn_All.Location = new System.Drawing.Point(519, 0);
            this.btn_All.Name = "btn_All";
            this.btn_All.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            this.btn_All.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(145)))), ((int)(((byte)(24)))));
            this.btn_All.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_All.selected = false;
            this.btn_All.Size = new System.Drawing.Size(172, 57);
            this.btn_All.TabIndex = 17;
            this.btn_All.Text = "All of them";
            this.btn_All.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_All.Textcolor = System.Drawing.Color.White;
            this.btn_All.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_All.Click += new System.EventHandler(this.btn_All_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Search.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(53)))), ((int)(((byte)(91)))));
            this.txt_Search.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(145)))), ((int)(((byte)(24)))));
            this.txt_Search.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(53)))), ((int)(((byte)(91)))));
            this.txt_Search.BorderThickness = 3;
            this.txt_Search.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Search.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.ForeColor = System.Drawing.Color.White;
            this.txt_Search.isPassword = false;
            this.txt_Search.Location = new System.Drawing.Point(292, 109);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Search.MaxLength = 32767;
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(227, 36);
            this.txt_Search.TabIndex = 91;
            this.txt_Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Search.OnValueChanged += new System.EventHandler(this.txt_Search_OnValueChanged);
            // 
            // btn_Find
            // 
            this.btn_Find.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Find.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            this.btn_Find.color = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            this.btn_Find.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(25)))), ((int)(((byte)(198)))));
            this.btn_Find.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Find.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Find.ForeColor = System.Drawing.Color.White;
            this.btn_Find.Image = ((System.Drawing.Image)(resources.GetObject("btn_Find.Image")));
            this.btn_Find.ImagePosition = 14;
            this.btn_Find.ImageZoom = 30;
            this.btn_Find.LabelPosition = 29;
            this.btn_Find.LabelText = "Find";
            this.btn_Find.Location = new System.Drawing.Point(229, 99);
            this.btn_Find.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(57, 55);
            this.btn_Find.TabIndex = 90;
            // 
            // dataGid_Device
            // 
            this.dataGid_Device.AllowUserToAddRows = false;
            this.dataGid_Device.AllowUserToResizeColumns = false;
            this.dataGid_Device.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGid_Device.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGid_Device.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGid_Device.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            this.dataGid_Device.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGid_Device.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGid_Device.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(145)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGid_Device.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGid_Device.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGid_Device.ColumnHeadersVisible = false;
            this.dataGid_Device.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDSanPham,
            this.IDCategory,
            this.NameSP,
            this.Price,
            this.IDBlock,
            this.IDDetail,
            this.DateSell});
            this.dataGid_Device.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGid_Device.DoubleBuffered = true;
            this.dataGid_Device.EnableHeadersVisualStyles = false;
            this.dataGid_Device.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGid_Device.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dataGid_Device.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dataGid_Device.Location = new System.Drawing.Point(0, 174);
            this.dataGid_Device.Margin = new System.Windows.Forms.Padding(2);
            this.dataGid_Device.MultiSelect = false;
            this.dataGid_Device.Name = "dataGid_Device";
            this.dataGid_Device.ReadOnly = true;
            this.dataGid_Device.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGid_Device.RowHeadersVisible = false;
            this.dataGid_Device.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            this.dataGid_Device.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGid_Device.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(145)))), ((int)(((byte)(24)))));
            this.dataGid_Device.RowTemplate.Height = 30;
            this.dataGid_Device.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGid_Device.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGid_Device.Size = new System.Drawing.Size(691, 403);
            this.dataGid_Device.TabIndex = 92;
            this.dataGid_Device.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGid_Device_CellClick);
            // 
            // IDSanPham
            // 
            this.IDSanPham.DataPropertyName = "IDSanPham";
            this.IDSanPham.HeaderText = "ID Product";
            this.IDSanPham.Name = "IDSanPham";
            this.IDSanPham.ReadOnly = true;
            // 
            // IDCategory
            // 
            this.IDCategory.DataPropertyName = "IDCategory";
            this.IDCategory.HeaderText = "ID Category";
            this.IDCategory.Name = "IDCategory";
            this.IDCategory.ReadOnly = true;
            // 
            // NameSP
            // 
            this.NameSP.DataPropertyName = "Name";
            this.NameSP.HeaderText = "Name Product";
            this.NameSP.Name = "NameSP";
            this.NameSP.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price Product";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // IDBlock
            // 
            this.IDBlock.DataPropertyName = "IDBlock";
            this.IDBlock.HeaderText = "ID Block";
            this.IDBlock.Name = "IDBlock";
            this.IDBlock.ReadOnly = true;
            // 
            // IDDetail
            // 
            this.IDDetail.DataPropertyName = "IDDetail";
            this.IDDetail.HeaderText = "ID Detail";
            this.IDDetail.Name = "IDDetail";
            this.IDDetail.ReadOnly = true;
            // 
            // DateSell
            // 
            this.DateSell.DataPropertyName = "DateSell";
            this.DateSell.HeaderText = "Date Sell";
            this.DateSell.Name = "DateSell";
            this.DateSell.ReadOnly = true;
            // 
            // pbx_Avatar
            // 
            this.pbx_Avatar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbx_Avatar.BackgroundImage")));
            this.pbx_Avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbx_Avatar.Location = new System.Drawing.Point(12, 62);
            this.pbx_Avatar.Margin = new System.Windows.Forms.Padding(2);
            this.pbx_Avatar.Name = "pbx_Avatar";
            this.pbx_Avatar.Size = new System.Drawing.Size(124, 108);
            this.pbx_Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_Avatar.TabIndex = 93;
            this.pbx_Avatar.TabStop = false;
            // 
            // btn_Watch
            // 
            this.btn_Watch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Watch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            this.btn_Watch.color = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            this.btn_Watch.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(25)))), ((int)(((byte)(198)))));
            this.btn_Watch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Watch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Watch.ForeColor = System.Drawing.Color.White;
            this.btn_Watch.Image = ((System.Drawing.Image)(resources.GetObject("btn_Watch.Image")));
            this.btn_Watch.ImagePosition = 14;
            this.btn_Watch.ImageZoom = 30;
            this.btn_Watch.LabelPosition = 29;
            this.btn_Watch.LabelText = "Find";
            this.btn_Watch.Location = new System.Drawing.Point(592, 90);
            this.btn_Watch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_Watch.Name = "btn_Watch";
            this.btn_Watch.Size = new System.Drawing.Size(57, 55);
            this.btn_Watch.TabIndex = 94;
            this.btn_Watch.Click += new System.EventHandler(this.btn_Watch_Click);
            // 
            // uct_ProductView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            this.Controls.Add(this.btn_Watch);
            this.Controls.Add(this.pbx_Avatar);
            this.Controls.Add(this.dataGid_Device);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.btn_Find);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "uct_ProductView";
            this.Size = new System.Drawing.Size(691, 577);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGid_Device)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Avatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btn_Laptop;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_ExtraDevice;
        private Bunifu.Framework.UI.BunifuFlatButton btn_SmartPhone;
        private Bunifu.Framework.UI.BunifuFlatButton btn_All;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Search;
        private Bunifu.Framework.UI.BunifuTileButton btn_Find;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGid_Device;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDBlock;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateSell;
        private System.Windows.Forms.PictureBox pbx_Avatar;
        private Bunifu.Framework.UI.BunifuTileButton btn_Watch;
    }
}
