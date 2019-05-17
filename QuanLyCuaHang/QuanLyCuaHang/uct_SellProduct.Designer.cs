namespace QuanLyCuaHang
{
    partial class uct_SellProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uct_SellProduct));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_Position = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_SearchCustomer = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_idDiscount = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_SearchProducts = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btn_Sell = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Add = new Bunifu.Framework.UI.BunifuImageButton();
            this.dataGid_Customer = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txt_customer_added = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btn_Clear = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dataGid_Products = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.lvw_ProductSell = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGid_Customer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGid_Products)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Position
            // 
            this.lbl_Position.AutoSize = true;
            this.lbl_Position.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Position.ForeColor = System.Drawing.Color.White;
            this.lbl_Position.Location = new System.Drawing.Point(284, 0);
            this.lbl_Position.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Position.Name = "lbl_Position";
            this.lbl_Position.Size = new System.Drawing.Size(104, 33);
            this.lbl_Position.TabIndex = 2;
            this.lbl_Position.Text = "ORDER";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Customer:";
            // 
            // txt_SearchCustomer
            // 
            this.txt_SearchCustomer.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(53)))), ((int)(((byte)(91)))));
            this.txt_SearchCustomer.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(145)))), ((int)(((byte)(24)))));
            this.txt_SearchCustomer.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(53)))), ((int)(((byte)(91)))));
            this.txt_SearchCustomer.BorderThickness = 3;
            this.txt_SearchCustomer.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_SearchCustomer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SearchCustomer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SearchCustomer.ForeColor = System.Drawing.Color.White;
            this.txt_SearchCustomer.isPassword = false;
            this.txt_SearchCustomer.Location = new System.Drawing.Point(134, 39);
            this.txt_SearchCustomer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_SearchCustomer.MaxLength = 32767;
            this.txt_SearchCustomer.Name = "txt_SearchCustomer";
            this.txt_SearchCustomer.Size = new System.Drawing.Size(286, 39);
            this.txt_SearchCustomer.TabIndex = 59;
            this.txt_SearchCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_SearchCustomer.OnValueChanged += new System.EventHandler(this.txt_SearchCustomer_OnValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(2, 271);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 60;
            this.label2.Text = "Products:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 479);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 22);
            this.label3.TabIndex = 67;
            this.label3.Text = "ID Discount:";
            // 
            // txt_idDiscount
            // 
            this.txt_idDiscount.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(53)))), ((int)(((byte)(91)))));
            this.txt_idDiscount.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(145)))), ((int)(((byte)(24)))));
            this.txt_idDiscount.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(53)))), ((int)(((byte)(91)))));
            this.txt_idDiscount.BorderThickness = 3;
            this.txt_idDiscount.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_idDiscount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_idDiscount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idDiscount.ForeColor = System.Drawing.Color.White;
            this.txt_idDiscount.isPassword = false;
            this.txt_idDiscount.Location = new System.Drawing.Point(134, 471);
            this.txt_idDiscount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_idDiscount.MaxLength = 32767;
            this.txt_idDiscount.Name = "txt_idDiscount";
            this.txt_idDiscount.Size = new System.Drawing.Size(283, 39);
            this.txt_idDiscount.TabIndex = 66;
            this.txt_idDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_SearchProducts
            // 
            this.txt_SearchProducts.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(53)))), ((int)(((byte)(91)))));
            this.txt_SearchProducts.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(145)))), ((int)(((byte)(24)))));
            this.txt_SearchProducts.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(53)))), ((int)(((byte)(91)))));
            this.txt_SearchProducts.BorderThickness = 3;
            this.txt_SearchProducts.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_SearchProducts.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SearchProducts.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SearchProducts.ForeColor = System.Drawing.Color.White;
            this.txt_SearchProducts.isPassword = false;
            this.txt_SearchProducts.Location = new System.Drawing.Point(131, 265);
            this.txt_SearchProducts.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_SearchProducts.MaxLength = 32767;
            this.txt_SearchProducts.Name = "txt_SearchProducts";
            this.txt_SearchProducts.Size = new System.Drawing.Size(286, 39);
            this.txt_SearchProducts.TabIndex = 70;
            this.txt_SearchProducts.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_SearchProducts.OnValueChanged += new System.EventHandler(this.txt_SearchProducts_OnValueChanged);
            // 
            // btn_Sell
            // 
            this.btn_Sell.Active = false;
            this.btn_Sell.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.btn_Sell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(53)))), ((int)(((byte)(91)))));
            this.btn_Sell.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Sell.BorderRadius = 0;
            this.btn_Sell.ButtonText = "Sell";
            this.btn_Sell.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Sell.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Sell.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Sell.Iconimage = null;
            this.btn_Sell.Iconimage_right = null;
            this.btn_Sell.Iconimage_right_Selected = null;
            this.btn_Sell.Iconimage_Selected = null;
            this.btn_Sell.IconMarginLeft = 0;
            this.btn_Sell.IconMarginRight = 0;
            this.btn_Sell.IconRightVisible = true;
            this.btn_Sell.IconRightZoom = 0D;
            this.btn_Sell.IconVisible = true;
            this.btn_Sell.IconZoom = 40D;
            this.btn_Sell.IsTab = false;
            this.btn_Sell.Location = new System.Drawing.Point(451, 359);
            this.btn_Sell.Name = "btn_Sell";
            this.btn_Sell.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(53)))), ((int)(((byte)(91)))));
            this.btn_Sell.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.btn_Sell.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Sell.selected = false;
            this.btn_Sell.Size = new System.Drawing.Size(111, 48);
            this.btn_Sell.TabIndex = 85;
            this.btn_Sell.Text = "Sell";
            this.btn_Sell.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Sell.Textcolor = System.Drawing.Color.White;
            this.btn_Sell.TextFont = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sell.Click += new System.EventHandler(this.btn_Sell_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Image = ((System.Drawing.Image)(resources.GetObject("btn_Add.Image")));
            this.btn_Add.ImageActive = null;
            this.btn_Add.Location = new System.Drawing.Point(426, 44);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(26, 28);
            this.btn_Add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Add.TabIndex = 87;
            this.btn_Add.TabStop = false;
            this.btn_Add.Zoom = 10;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // dataGid_Customer
            // 
            this.dataGid_Customer.AllowUserToAddRows = false;
            this.dataGid_Customer.AllowUserToDeleteRows = false;
            this.dataGid_Customer.AllowUserToResizeColumns = false;
            this.dataGid_Customer.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGid_Customer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGid_Customer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGid_Customer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            this.dataGid_Customer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGid_Customer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGid_Customer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGid_Customer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGid_Customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGid_Customer.ColumnHeadersVisible = false;
            this.dataGid_Customer.DoubleBuffered = true;
            this.dataGid_Customer.EnableHeadersVisualStyles = false;
            this.dataGid_Customer.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGid_Customer.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dataGid_Customer.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dataGid_Customer.Location = new System.Drawing.Point(137, 112);
            this.dataGid_Customer.Margin = new System.Windows.Forms.Padding(2);
            this.dataGid_Customer.MultiSelect = false;
            this.dataGid_Customer.Name = "dataGid_Customer";
            this.dataGid_Customer.ReadOnly = true;
            this.dataGid_Customer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGid_Customer.RowHeadersVisible = false;
            this.dataGid_Customer.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            this.dataGid_Customer.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGid_Customer.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(145)))), ((int)(((byte)(24)))));
            this.dataGid_Customer.RowTemplate.Height = 24;
            this.dataGid_Customer.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGid_Customer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGid_Customer.Size = new System.Drawing.Size(283, 148);
            this.dataGid_Customer.TabIndex = 88;
            this.dataGid_Customer.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGid_Customer_CellMouseDoubleClick);
            this.dataGid_Customer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGid_Customer_MouseDown);
            // 
            // txt_customer_added
            // 
            this.txt_customer_added.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(53)))), ((int)(((byte)(91)))));
            this.txt_customer_added.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(145)))), ((int)(((byte)(24)))));
            this.txt_customer_added.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(53)))), ((int)(((byte)(91)))));
            this.txt_customer_added.BorderThickness = 3;
            this.txt_customer_added.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_customer_added.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_customer_added.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_customer_added.ForeColor = System.Drawing.Color.White;
            this.txt_customer_added.isPassword = false;
            this.txt_customer_added.Location = new System.Drawing.Point(451, 157);
            this.txt_customer_added.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_customer_added.MaxLength = 32767;
            this.txt_customer_added.Name = "txt_customer_added";
            this.txt_customer_added.Size = new System.Drawing.Size(226, 39);
            this.txt_customer_added.TabIndex = 89;
            this.txt_customer_added.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Active = false;
            this.btn_Clear.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.btn_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(53)))), ((int)(((byte)(91)))));
            this.btn_Clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Clear.BorderRadius = 0;
            this.btn_Clear.ButtonText = "Clear ";
            this.btn_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Clear.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Clear.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Clear.Iconimage = null;
            this.btn_Clear.Iconimage_right = null;
            this.btn_Clear.Iconimage_right_Selected = null;
            this.btn_Clear.Iconimage_Selected = null;
            this.btn_Clear.IconMarginLeft = 0;
            this.btn_Clear.IconMarginRight = 0;
            this.btn_Clear.IconRightVisible = true;
            this.btn_Clear.IconRightZoom = 0D;
            this.btn_Clear.IconVisible = true;
            this.btn_Clear.IconZoom = 40D;
            this.btn_Clear.IsTab = false;
            this.btn_Clear.Location = new System.Drawing.Point(564, 359);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(53)))), ((int)(((byte)(91)))));
            this.btn_Clear.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.btn_Clear.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Clear.selected = false;
            this.btn_Clear.Size = new System.Drawing.Size(111, 48);
            this.btn_Clear.TabIndex = 91;
            this.btn_Clear.Text = "Clear ";
            this.btn_Clear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Clear.Textcolor = System.Drawing.Color.White;
            this.btn_Clear.TextFont = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // dataGid_Products
            // 
            this.dataGid_Products.AllowUserToAddRows = false;
            this.dataGid_Products.AllowUserToDeleteRows = false;
            this.dataGid_Products.AllowUserToResizeColumns = false;
            this.dataGid_Products.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGid_Products.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGid_Products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGid_Products.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            this.dataGid_Products.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGid_Products.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGid_Products.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGid_Products.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGid_Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGid_Products.ColumnHeadersVisible = false;
            this.dataGid_Products.DoubleBuffered = true;
            this.dataGid_Products.EnableHeadersVisualStyles = false;
            this.dataGid_Products.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGid_Products.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dataGid_Products.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dataGid_Products.Location = new System.Drawing.Point(134, 332);
            this.dataGid_Products.Margin = new System.Windows.Forms.Padding(2);
            this.dataGid_Products.MultiSelect = false;
            this.dataGid_Products.Name = "dataGid_Products";
            this.dataGid_Products.ReadOnly = true;
            this.dataGid_Products.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGid_Products.RowHeadersVisible = false;
            this.dataGid_Products.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            this.dataGid_Products.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGid_Products.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(145)))), ((int)(((byte)(24)))));
            this.dataGid_Products.RowTemplate.Height = 24;
            this.dataGid_Products.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGid_Products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGid_Products.Size = new System.Drawing.Size(283, 134);
            this.dataGid_Products.TabIndex = 92;
            this.dataGid_Products.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGid_Products_CellMouseDoubleClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(137, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 23);
            this.button1.TabIndex = 93;
            this.button1.Text = "ID Customer";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(278, 89);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 23);
            this.button2.TabIndex = 94;
            this.button2.Text = "Name";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Location = new System.Drawing.Point(134, 309);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 23);
            this.button4.TabIndex = 95;
            this.button4.Text = "ID Product";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(228, 309);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 23);
            this.button3.TabIndex = 96;
            this.button3.Text = "Name";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Location = new System.Drawing.Point(322, 309);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(95, 23);
            this.button5.TabIndex = 97;
            this.button5.Text = "Price";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // lvw_ProductSell
            // 
            this.lvw_ProductSell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            this.lvw_ProductSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvw_ProductSell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(145)))), ((int)(((byte)(24)))));
            this.lvw_ProductSell.Location = new System.Drawing.Point(451, 201);
            this.lvw_ProductSell.Margin = new System.Windows.Forms.Padding(2);
            this.lvw_ProductSell.MultiSelect = false;
            this.lvw_ProductSell.Name = "lvw_ProductSell";
            this.lvw_ProductSell.Size = new System.Drawing.Size(224, 153);
            this.lvw_ProductSell.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvw_ProductSell.TabIndex = 62;
            this.lvw_ProductSell.UseCompatibleStateImageBehavior = false;
            this.lvw_ProductSell.View = System.Windows.Forms.View.List;
            // 
            // uct_SellProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGid_Products);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.txt_customer_added);
            this.Controls.Add(this.dataGid_Customer);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Sell);
            this.Controls.Add(this.txt_SearchProducts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_idDiscount);
            this.Controls.Add(this.lvw_ProductSell);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_SearchCustomer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Position);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "uct_SellProduct";
            this.Size = new System.Drawing.Size(695, 516);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGid_Customer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGid_Products)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Position;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_SearchCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_idDiscount;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_SearchProducts;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Sell;
        private Bunifu.Framework.UI.BunifuImageButton btn_Add;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGid_Customer;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_customer_added;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Clear;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGid_Products;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ListView lvw_ProductSell;
    }
}
