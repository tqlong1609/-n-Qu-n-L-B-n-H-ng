namespace QuanLyCuaHang
{
    partial class frm_MainWarehouseStaff
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MainWarehouseStaff));
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            this.lbl_IconPosition = new System.Windows.Forms.PictureBox();
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.btn_Notification = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Logout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pbx_LogoSlide = new System.Windows.Forms.PictureBox();
            this.btn_AddProduct = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Exit = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Minisize = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbl_Position = new System.Windows.Forms.Label();
            this.btn_Profile = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Menu = new Bunifu.Framework.UI.BunifuImageButton();
            this.pbx_Logo = new System.Windows.Forms.PictureBox();
            this.bt_MenuAnimation = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.pnl_Menu = new System.Windows.Forms.Panel();
            this.pnl_Bar = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_IconPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_LogoSlide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minisize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Logo)).BeginInit();
            this.pnl_Menu.SuspendLayout();
            this.pnl_Bar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_IconPosition
            // 
            this.lbl_IconPosition.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lbl_IconPosition.BackgroundImage")));
            this.bt_MenuAnimation.SetDecoration(this.lbl_IconPosition, BunifuAnimatorNS.DecorationType.None);
            this.lbl_IconPosition.Image = ((System.Drawing.Image)(resources.GetObject("lbl_IconPosition.Image")));
            this.lbl_IconPosition.Location = new System.Drawing.Point(9, 10);
            this.lbl_IconPosition.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbl_IconPosition.Name = "lbl_IconPosition";
            this.lbl_IconPosition.Size = new System.Drawing.Size(24, 26);
            this.lbl_IconPosition.TabIndex = 0;
            this.lbl_IconPosition.TabStop = false;
            this.lbl_IconPosition.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Bar_MouseDown);
            this.lbl_IconPosition.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Bar_MouseMove);
            this.lbl_IconPosition.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_Bar_MouseUp);
            // 
            // pnl_Main
            // 
            this.pnl_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            this.bt_MenuAnimation.SetDecoration(this.pnl_Main, BunifuAnimatorNS.DecorationType.None);
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(209, 46);
            this.pnl_Main.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(691, 577);
            this.pnl_Main.TabIndex = 8;
            // 
            // btn_Notification
            // 
            this.btn_Notification.Active = false;
            this.btn_Notification.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(206)))));
            this.btn_Notification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btn_Notification.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Notification.BorderRadius = 0;
            this.btn_Notification.ButtonText = "    Notification";
            this.btn_Notification.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_MenuAnimation.SetDecoration(this.btn_Notification, BunifuAnimatorNS.DecorationType.None);
            this.btn_Notification.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Notification.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Notification.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Notification.Iconimage")));
            this.btn_Notification.Iconimage_right = null;
            this.btn_Notification.Iconimage_right_Selected = null;
            this.btn_Notification.Iconimage_Selected = null;
            this.btn_Notification.IconMarginLeft = 0;
            this.btn_Notification.IconMarginRight = 0;
            this.btn_Notification.IconRightVisible = true;
            this.btn_Notification.IconRightZoom = 0D;
            this.btn_Notification.IconVisible = true;
            this.btn_Notification.IconZoom = 40D;
            this.btn_Notification.IsTab = true;
            this.btn_Notification.Location = new System.Drawing.Point(2, 238);
            this.btn_Notification.Name = "btn_Notification";
            this.btn_Notification.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btn_Notification.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(206)))));
            this.btn_Notification.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Notification.selected = false;
            this.btn_Notification.Size = new System.Drawing.Size(207, 48);
            this.btn_Notification.TabIndex = 23;
            this.btn_Notification.Text = "    Notification";
            this.btn_Notification.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Notification.Textcolor = System.Drawing.Color.White;
            this.btn_Notification.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Notification.Click += new System.EventHandler(this.btn_Notification_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.Active = false;
            this.btn_Logout.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(206)))));
            this.btn_Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btn_Logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Logout.BorderRadius = 0;
            this.btn_Logout.ButtonText = "    Logout";
            this.btn_Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_MenuAnimation.SetDecoration(this.btn_Logout, BunifuAnimatorNS.DecorationType.None);
            this.btn_Logout.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Logout.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Logout.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Logout.Iconimage")));
            this.btn_Logout.Iconimage_right = null;
            this.btn_Logout.Iconimage_right_Selected = null;
            this.btn_Logout.Iconimage_Selected = null;
            this.btn_Logout.IconMarginLeft = 0;
            this.btn_Logout.IconMarginRight = 0;
            this.btn_Logout.IconRightVisible = true;
            this.btn_Logout.IconRightZoom = 0D;
            this.btn_Logout.IconVisible = true;
            this.btn_Logout.IconZoom = 40D;
            this.btn_Logout.IsTab = true;
            this.btn_Logout.Location = new System.Drawing.Point(2, 292);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btn_Logout.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(206)))));
            this.btn_Logout.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Logout.selected = false;
            this.btn_Logout.Size = new System.Drawing.Size(207, 48);
            this.btn_Logout.TabIndex = 21;
            this.btn_Logout.Text = "    Logout";
            this.btn_Logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Logout.Textcolor = System.Drawing.Color.White;
            this.btn_Logout.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // pbx_LogoSlide
            // 
            this.bt_MenuAnimation.SetDecoration(this.pbx_LogoSlide, BunifuAnimatorNS.DecorationType.None);
            this.pbx_LogoSlide.Image = ((System.Drawing.Image)(resources.GetObject("pbx_LogoSlide.Image")));
            this.pbx_LogoSlide.Location = new System.Drawing.Point(-5, 47);
            this.pbx_LogoSlide.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbx_LogoSlide.Name = "pbx_LogoSlide";
            this.pbx_LogoSlide.Size = new System.Drawing.Size(58, 76);
            this.pbx_LogoSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_LogoSlide.TabIndex = 20;
            this.pbx_LogoSlide.TabStop = false;
            this.pbx_LogoSlide.Visible = false;
            // 
            // btn_AddProduct
            // 
            this.btn_AddProduct.Active = false;
            this.btn_AddProduct.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(206)))));
            this.btn_AddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btn_AddProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_AddProduct.BorderRadius = 0;
            this.btn_AddProduct.ButtonText = "    Add Product";
            this.btn_AddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_MenuAnimation.SetDecoration(this.btn_AddProduct, BunifuAnimatorNS.DecorationType.None);
            this.btn_AddProduct.DisabledColor = System.Drawing.Color.Gray;
            this.btn_AddProduct.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_AddProduct.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_AddProduct.Iconimage")));
            this.btn_AddProduct.Iconimage_right = null;
            this.btn_AddProduct.Iconimage_right_Selected = null;
            this.btn_AddProduct.Iconimage_Selected = null;
            this.btn_AddProduct.IconMarginLeft = 0;
            this.btn_AddProduct.IconMarginRight = 0;
            this.btn_AddProduct.IconRightVisible = true;
            this.btn_AddProduct.IconRightZoom = 0D;
            this.btn_AddProduct.IconVisible = true;
            this.btn_AddProduct.IconZoom = 40D;
            this.btn_AddProduct.IsTab = true;
            this.btn_AddProduct.Location = new System.Drawing.Point(2, 184);
            this.btn_AddProduct.Name = "btn_AddProduct";
            this.btn_AddProduct.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btn_AddProduct.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(206)))));
            this.btn_AddProduct.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_AddProduct.selected = false;
            this.btn_AddProduct.Size = new System.Drawing.Size(207, 48);
            this.btn_AddProduct.TabIndex = 16;
            this.btn_AddProduct.Text = "    Add Product";
            this.btn_AddProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddProduct.Textcolor = System.Drawing.Color.White;
            this.btn_AddProduct.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddProduct.Click += new System.EventHandler(this.btn_AddProduct_Click);
            // 
            // btn_Exit
            // 
            this.bt_MenuAnimation.SetDecoration(this.btn_Exit, BunifuAnimatorNS.DecorationType.None);
            this.btn_Exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exit.Image")));
            this.btn_Exit.ImageActive = null;
            this.btn_Exit.Location = new System.Drawing.Point(870, 10);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(19, 20);
            this.btn_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Exit.TabIndex = 28;
            this.btn_Exit.TabStop = false;
            this.btn_Exit.Zoom = 10;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_Minisize
            // 
            this.bt_MenuAnimation.SetDecoration(this.btn_Minisize, BunifuAnimatorNS.DecorationType.None);
            this.btn_Minisize.Image = ((System.Drawing.Image)(resources.GetObject("btn_Minisize.Image")));
            this.btn_Minisize.ImageActive = null;
            this.btn_Minisize.Location = new System.Drawing.Point(843, 10);
            this.btn_Minisize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Minisize.Name = "btn_Minisize";
            this.btn_Minisize.Size = new System.Drawing.Size(22, 24);
            this.btn_Minisize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Minisize.TabIndex = 4;
            this.btn_Minisize.TabStop = false;
            this.btn_Minisize.Zoom = 10;
            this.btn_Minisize.Click += new System.EventHandler(this.btn_Minisize_Click);
            // 
            // lbl_Position
            // 
            this.lbl_Position.AutoSize = true;
            this.bt_MenuAnimation.SetDecoration(this.lbl_Position, BunifuAnimatorNS.DecorationType.None);
            this.lbl_Position.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Position.ForeColor = System.Drawing.Color.White;
            this.lbl_Position.Location = new System.Drawing.Point(38, 10);
            this.lbl_Position.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Position.Name = "lbl_Position";
            this.lbl_Position.Size = new System.Drawing.Size(231, 22);
            this.lbl_Position.TabIndex = 1;
            this.lbl_Position.Text = "Position: WarehouseStaff";
            this.lbl_Position.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Bar_MouseDown);
            this.lbl_Position.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Bar_MouseMove);
            this.lbl_Position.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_Bar_MouseUp);
            // 
            // btn_Profile
            // 
            this.btn_Profile.Active = true;
            this.btn_Profile.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(206)))));
            this.btn_Profile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(206)))));
            this.btn_Profile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Profile.BorderRadius = 0;
            this.btn_Profile.ButtonText = "    Profile";
            this.btn_Profile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_MenuAnimation.SetDecoration(this.btn_Profile, BunifuAnimatorNS.DecorationType.None);
            this.btn_Profile.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Profile.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Profile.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Profile.Iconimage")));
            this.btn_Profile.Iconimage_right = null;
            this.btn_Profile.Iconimage_right_Selected = null;
            this.btn_Profile.Iconimage_Selected = null;
            this.btn_Profile.IconMarginLeft = 0;
            this.btn_Profile.IconMarginRight = 0;
            this.btn_Profile.IconRightVisible = true;
            this.btn_Profile.IconRightZoom = 0D;
            this.btn_Profile.IconVisible = true;
            this.btn_Profile.IconZoom = 40D;
            this.btn_Profile.IsTab = true;
            this.btn_Profile.Location = new System.Drawing.Point(2, 129);
            this.btn_Profile.Name = "btn_Profile";
            this.btn_Profile.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btn_Profile.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(206)))));
            this.btn_Profile.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Profile.selected = true;
            this.btn_Profile.Size = new System.Drawing.Size(207, 48);
            this.btn_Profile.TabIndex = 15;
            this.btn_Profile.Text = "    Profile";
            this.btn_Profile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Profile.Textcolor = System.Drawing.Color.White;
            this.btn_Profile.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Profile.Click += new System.EventHandler(this.btn_Profile_Click);
            // 
            // btn_Menu
            // 
            this.btn_Menu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_MenuAnimation.SetDecoration(this.btn_Menu, BunifuAnimatorNS.DecorationType.None);
            this.btn_Menu.Image = ((System.Drawing.Image)(resources.GetObject("btn_Menu.Image")));
            this.btn_Menu.ImageActive = null;
            this.btn_Menu.Location = new System.Drawing.Point(175, 17);
            this.btn_Menu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(22, 24);
            this.btn_Menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Menu.TabIndex = 1;
            this.btn_Menu.TabStop = false;
            this.btn_Menu.Zoom = 10;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // pbx_Logo
            // 
            this.bt_MenuAnimation.SetDecoration(this.pbx_Logo, BunifuAnimatorNS.DecorationType.None);
            this.pbx_Logo.Image = ((System.Drawing.Image)(resources.GetObject("pbx_Logo.Image")));
            this.pbx_Logo.Location = new System.Drawing.Point(-26, 17);
            this.pbx_Logo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbx_Logo.Name = "pbx_Logo";
            this.pbx_Logo.Size = new System.Drawing.Size(193, 93);
            this.pbx_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_Logo.TabIndex = 0;
            this.pbx_Logo.TabStop = false;
            // 
            // bt_MenuAnimation
            // 
            this.bt_MenuAnimation.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.bt_MenuAnimation.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 1;
            animation1.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 2F;
            animation1.TransparencyCoeff = 0F;
            this.bt_MenuAnimation.DefaultAnimation = animation1;
            // 
            // pnl_Menu
            // 
            this.pnl_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.pnl_Menu.Controls.Add(this.btn_Notification);
            this.pnl_Menu.Controls.Add(this.btn_Logout);
            this.pnl_Menu.Controls.Add(this.pbx_LogoSlide);
            this.pnl_Menu.Controls.Add(this.btn_AddProduct);
            this.pnl_Menu.Controls.Add(this.btn_Profile);
            this.pnl_Menu.Controls.Add(this.btn_Menu);
            this.pnl_Menu.Controls.Add(this.pbx_Logo);
            this.bt_MenuAnimation.SetDecoration(this.pnl_Menu, BunifuAnimatorNS.DecorationType.None);
            this.pnl_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Menu.Location = new System.Drawing.Point(0, 46);
            this.pnl_Menu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_Menu.Name = "pnl_Menu";
            this.pnl_Menu.Size = new System.Drawing.Size(209, 577);
            this.pnl_Menu.TabIndex = 6;
            // 
            // pnl_Bar
            // 
            this.pnl_Bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(206)))));
            this.pnl_Bar.Controls.Add(this.btn_Exit);
            this.pnl_Bar.Controls.Add(this.btn_Minisize);
            this.pnl_Bar.Controls.Add(this.lbl_Position);
            this.pnl_Bar.Controls.Add(this.lbl_IconPosition);
            this.bt_MenuAnimation.SetDecoration(this.pnl_Bar, BunifuAnimatorNS.DecorationType.None);
            this.pnl_Bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Bar.Location = new System.Drawing.Point(0, 0);
            this.pnl_Bar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_Bar.Name = "pnl_Bar";
            this.pnl_Bar.Size = new System.Drawing.Size(900, 46);
            this.pnl_Bar.TabIndex = 7;
            this.pnl_Bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Bar_MouseDown);
            this.pnl_Bar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Bar_MouseMove);
            this.pnl_Bar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_Bar_MouseUp);
            // 
            // frm_MainWarehouseStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(900, 623);
            this.Controls.Add(this.pnl_Main);
            this.Controls.Add(this.pnl_Menu);
            this.Controls.Add(this.pnl_Bar);
            this.bt_MenuAnimation.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_MainWarehouseStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_MainWarehouseStaff";
            ((System.ComponentModel.ISupportInitialize)(this.lbl_IconPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_LogoSlide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minisize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Logo)).EndInit();
            this.pnl_Menu.ResumeLayout(false);
            this.pnl_Bar.ResumeLayout(false);
            this.pnl_Bar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox lbl_IconPosition;
        private BunifuAnimatorNS.BunifuTransition bt_MenuAnimation;
        private System.Windows.Forms.Panel pnl_Main;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Notification;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Logout;
        private System.Windows.Forms.PictureBox pbx_LogoSlide;
        private Bunifu.Framework.UI.BunifuFlatButton btn_AddProduct;
        private Bunifu.Framework.UI.BunifuImageButton btn_Exit;
        private Bunifu.Framework.UI.BunifuImageButton btn_Minisize;
        private System.Windows.Forms.Label lbl_Position;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Profile;
        private Bunifu.Framework.UI.BunifuImageButton btn_Menu;
        private System.Windows.Forms.PictureBox pbx_Logo;
        private System.Windows.Forms.Panel pnl_Menu;
        private System.Windows.Forms.Panel pnl_Bar;
    }
}