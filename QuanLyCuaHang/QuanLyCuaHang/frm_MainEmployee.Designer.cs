namespace QuanLyCuaHang
{
    partial class frm_MainEmployee
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
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MainEmployee));
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.btn_Notification = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Logout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pbx_LogoSlide = new System.Windows.Forms.PictureBox();
            this.btn_Product = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Exit = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Minisize = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbl_Position = new System.Windows.Forms.Label();
            this.lbl_IconPosition = new System.Windows.Forms.PictureBox();
            this.btn_Profile = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pbx_Logo = new System.Windows.Forms.PictureBox();
            this.bt_MenuAnimation = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.pnl_Menu = new System.Windows.Forms.Panel();
            this.btn_Help = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Sell = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnl_Bar = new System.Windows.Forms.Panel();
            this.btn_Menu = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_LogoSlide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minisize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_IconPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Logo)).BeginInit();
            this.pnl_Menu.SuspendLayout();
            this.pnl_Bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Menu)).BeginInit();
            this.SuspendLayout();
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
            this.pnl_Main.TabIndex = 5;
            this.pnl_Main.Click += new System.EventHandler(this.btn_Menu_Click);
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
            this.btn_Notification.Location = new System.Drawing.Point(2, 292);
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
            this.btn_Logout.Location = new System.Drawing.Point(2, 401);
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
            // btn_Product
            // 
            this.btn_Product.Active = false;
            this.btn_Product.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(206)))));
            this.btn_Product.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btn_Product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Product.BorderRadius = 0;
            this.btn_Product.ButtonText = "    Product";
            this.btn_Product.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_MenuAnimation.SetDecoration(this.btn_Product, BunifuAnimatorNS.DecorationType.None);
            this.btn_Product.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Product.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Product.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Product.Iconimage")));
            this.btn_Product.Iconimage_right = null;
            this.btn_Product.Iconimage_right_Selected = null;
            this.btn_Product.Iconimage_Selected = null;
            this.btn_Product.IconMarginLeft = 0;
            this.btn_Product.IconMarginRight = 0;
            this.btn_Product.IconRightVisible = true;
            this.btn_Product.IconRightZoom = 0D;
            this.btn_Product.IconVisible = true;
            this.btn_Product.IconZoom = 40D;
            this.btn_Product.IsTab = true;
            this.btn_Product.Location = new System.Drawing.Point(2, 184);
            this.btn_Product.Name = "btn_Product";
            this.btn_Product.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btn_Product.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(206)))));
            this.btn_Product.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Product.selected = false;
            this.btn_Product.Size = new System.Drawing.Size(207, 48);
            this.btn_Product.TabIndex = 16;
            this.btn_Product.Text = "    Product";
            this.btn_Product.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Product.Textcolor = System.Drawing.Color.White;
            this.btn_Product.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Product.Click += new System.EventHandler(this.btn_Product_Click);
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
            this.lbl_Position.Size = new System.Drawing.Size(177, 22);
            this.lbl_Position.TabIndex = 1;
            this.lbl_Position.Text = "Position: Employee";
            this.lbl_Position.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Bar_MouseDown);
            this.lbl_Position.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Bar_MouseMove);
            this.lbl_Position.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_Bar_MouseUp);
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
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 1;
            animation3.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 2F;
            animation3.TransparencyCoeff = 0F;
            this.bt_MenuAnimation.DefaultAnimation = animation3;
            // 
            // pnl_Menu
            // 
            this.pnl_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.pnl_Menu.Controls.Add(this.btn_Help);
            this.pnl_Menu.Controls.Add(this.btn_Sell);
            this.pnl_Menu.Controls.Add(this.btn_Notification);
            this.pnl_Menu.Controls.Add(this.btn_Logout);
            this.pnl_Menu.Controls.Add(this.pbx_LogoSlide);
            this.pnl_Menu.Controls.Add(this.btn_Product);
            this.pnl_Menu.Controls.Add(this.btn_Profile);
            this.pnl_Menu.Controls.Add(this.btn_Menu);
            this.pnl_Menu.Controls.Add(this.pbx_Logo);
            this.bt_MenuAnimation.SetDecoration(this.pnl_Menu, BunifuAnimatorNS.DecorationType.None);
            this.pnl_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Menu.Location = new System.Drawing.Point(0, 46);
            this.pnl_Menu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_Menu.Name = "pnl_Menu";
            this.pnl_Menu.Size = new System.Drawing.Size(209, 577);
            this.pnl_Menu.TabIndex = 3;
            // 
            // btn_Help
            // 
            this.btn_Help.Active = false;
            this.btn_Help.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(206)))));
            this.btn_Help.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btn_Help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Help.BorderRadius = 0;
            this.btn_Help.ButtonText = "    Help";
            this.btn_Help.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_MenuAnimation.SetDecoration(this.btn_Help, BunifuAnimatorNS.DecorationType.None);
            this.btn_Help.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Help.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Help.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Help.Iconimage")));
            this.btn_Help.Iconimage_right = null;
            this.btn_Help.Iconimage_right_Selected = null;
            this.btn_Help.Iconimage_Selected = null;
            this.btn_Help.IconMarginLeft = 0;
            this.btn_Help.IconMarginRight = 0;
            this.btn_Help.IconRightVisible = true;
            this.btn_Help.IconRightZoom = 0D;
            this.btn_Help.IconVisible = true;
            this.btn_Help.IconZoom = 40D;
            this.btn_Help.IsTab = true;
            this.btn_Help.Location = new System.Drawing.Point(2, 347);
            this.btn_Help.Name = "btn_Help";
            this.btn_Help.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btn_Help.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(206)))));
            this.btn_Help.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Help.selected = false;
            this.btn_Help.Size = new System.Drawing.Size(207, 48);
            this.btn_Help.TabIndex = 25;
            this.btn_Help.Text = "    Help";
            this.btn_Help.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Help.Textcolor = System.Drawing.Color.White;
            this.btn_Help.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_Sell
            // 
            this.btn_Sell.Active = false;
            this.btn_Sell.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(206)))));
            this.btn_Sell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btn_Sell.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Sell.BorderRadius = 0;
            this.btn_Sell.ButtonText = "    Sell";
            this.btn_Sell.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_MenuAnimation.SetDecoration(this.btn_Sell, BunifuAnimatorNS.DecorationType.None);
            this.btn_Sell.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Sell.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Sell.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Sell.Iconimage")));
            this.btn_Sell.Iconimage_right = null;
            this.btn_Sell.Iconimage_right_Selected = null;
            this.btn_Sell.Iconimage_Selected = null;
            this.btn_Sell.IconMarginLeft = 0;
            this.btn_Sell.IconMarginRight = 0;
            this.btn_Sell.IconRightVisible = true;
            this.btn_Sell.IconRightZoom = 0D;
            this.btn_Sell.IconVisible = true;
            this.btn_Sell.IconZoom = 40D;
            this.btn_Sell.IsTab = true;
            this.btn_Sell.Location = new System.Drawing.Point(2, 238);
            this.btn_Sell.Name = "btn_Sell";
            this.btn_Sell.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btn_Sell.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(206)))));
            this.btn_Sell.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Sell.selected = false;
            this.btn_Sell.Size = new System.Drawing.Size(207, 48);
            this.btn_Sell.TabIndex = 24;
            this.btn_Sell.Text = "    Sell";
            this.btn_Sell.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sell.Textcolor = System.Drawing.Color.White;
            this.btn_Sell.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sell.Click += new System.EventHandler(this.btn_Sell_Click);
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
            this.pnl_Bar.TabIndex = 4;
            this.pnl_Bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Bar_MouseDown);
            this.pnl_Bar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Bar_MouseMove);
            this.pnl_Bar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_Bar_MouseUp);
            // 
            // btn_Menu
            // 
            this.btn_Menu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_MenuAnimation.SetDecoration(this.btn_Menu, BunifuAnimatorNS.DecorationType.None);
            this.btn_Menu.Image = ((System.Drawing.Image)(resources.GetObject("btn_Menu.Image")));
            this.btn_Menu.ImageActive = null;
            this.btn_Menu.Location = new System.Drawing.Point(175, 17);
            this.btn_Menu.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(22, 24);
            this.btn_Menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Menu.TabIndex = 1;
            this.btn_Menu.TabStop = false;
            this.btn_Menu.Zoom = 10;
            // 
            // frm_MainEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 623);
            this.Controls.Add(this.pnl_Main);
            this.Controls.Add(this.pnl_Menu);
            this.Controls.Add(this.pnl_Bar);
            this.bt_MenuAnimation.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_MainEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_MainEmployee";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_LogoSlide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minisize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_IconPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Logo)).EndInit();
            this.pnl_Menu.ResumeLayout(false);
            this.pnl_Bar.ResumeLayout(false);
            this.pnl_Bar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Menu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Main;
        private BunifuAnimatorNS.BunifuTransition bt_MenuAnimation;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Notification;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Logout;
        private System.Windows.Forms.PictureBox pbx_LogoSlide;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Product;
        private Bunifu.Framework.UI.BunifuImageButton btn_Exit;
        private Bunifu.Framework.UI.BunifuImageButton btn_Minisize;
        private System.Windows.Forms.Label lbl_Position;
        private System.Windows.Forms.PictureBox lbl_IconPosition;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Profile;
        private System.Windows.Forms.PictureBox pbx_Logo;
        private System.Windows.Forms.Panel pnl_Menu;
        private System.Windows.Forms.Panel pnl_Bar;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Sell;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Help;
        private Bunifu.Framework.UI.BunifuImageButton btn_Menu;
    }
}