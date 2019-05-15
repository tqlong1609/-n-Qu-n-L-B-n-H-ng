namespace QuanLyCuaHang
{
    partial class frm_AddCustomer
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Id = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Address = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Phone = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lbl_Position = new System.Windows.Forms.Label();
            this.txt_Name = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btn_Find = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ckbx_Male = new Bunifu.Framework.UI.BunifuCheckbox();
            this.ckBx_Female = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(82, 206);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 22);
            this.label2.TabIndex = 65;
            this.label2.Text = "Male:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 22);
            this.label1.TabIndex = 63;
            this.label1.Text = "ID:";
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
            this.txt_Id.Location = new System.Drawing.Point(194, 18);
            this.txt_Id.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Id.MaxLength = 32767;
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(283, 39);
            this.txt_Id.TabIndex = 62;
            this.txt_Id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(14, 161);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 22);
            this.label6.TabIndex = 60;
            this.label6.Text = "Address:";
            // 
            // txt_Address
            // 
            this.txt_Address.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(53)))), ((int)(((byte)(91)))));
            this.txt_Address.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(145)))), ((int)(((byte)(24)))));
            this.txt_Address.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(53)))), ((int)(((byte)(91)))));
            this.txt_Address.BorderThickness = 3;
            this.txt_Address.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Address.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Address.ForeColor = System.Drawing.Color.White;
            this.txt_Address.isPassword = false;
            this.txt_Address.Location = new System.Drawing.Point(194, 154);
            this.txt_Address.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Address.MaxLength = 32767;
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(283, 39);
            this.txt_Address.TabIndex = 59;
            this.txt_Address.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 22);
            this.label4.TabIndex = 56;
            this.label4.Text = "Phone Number:";
            // 
            // txt_Phone
            // 
            this.txt_Phone.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(53)))), ((int)(((byte)(91)))));
            this.txt_Phone.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(145)))), ((int)(((byte)(24)))));
            this.txt_Phone.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(53)))), ((int)(((byte)(91)))));
            this.txt_Phone.BorderThickness = 3;
            this.txt_Phone.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Phone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Phone.ForeColor = System.Drawing.Color.White;
            this.txt_Phone.isPassword = false;
            this.txt_Phone.Location = new System.Drawing.Point(194, 109);
            this.txt_Phone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Phone.MaxLength = 32767;
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(283, 39);
            this.txt_Phone.TabIndex = 55;
            this.txt_Phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbl_Position
            // 
            this.lbl_Position.AutoSize = true;
            this.lbl_Position.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Position.ForeColor = System.Drawing.Color.White;
            this.lbl_Position.Location = new System.Drawing.Point(14, 71);
            this.lbl_Position.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Position.Name = "lbl_Position";
            this.lbl_Position.Size = new System.Drawing.Size(71, 22);
            this.lbl_Position.TabIndex = 54;
            this.lbl_Position.Text = "Name:";
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
            this.txt_Name.Location = new System.Drawing.Point(194, 63);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Name.MaxLength = 32767;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(283, 39);
            this.txt_Name.TabIndex = 53;
            this.txt_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btn_Find
            // 
            this.btn_Find.Active = false;
            this.btn_Find.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.btn_Find.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(53)))), ((int)(((byte)(91)))));
            this.btn_Find.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Find.BorderRadius = 0;
            this.btn_Find.ButtonText = "Add";
            this.btn_Find.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Find.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Find.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Find.Iconimage = null;
            this.btn_Find.Iconimage_right = null;
            this.btn_Find.Iconimage_right_Selected = null;
            this.btn_Find.Iconimage_Selected = null;
            this.btn_Find.IconMarginLeft = 0;
            this.btn_Find.IconMarginRight = 0;
            this.btn_Find.IconRightVisible = true;
            this.btn_Find.IconRightZoom = 0D;
            this.btn_Find.IconVisible = true;
            this.btn_Find.IconZoom = 40D;
            this.btn_Find.IsTab = false;
            this.btn_Find.Location = new System.Drawing.Point(54, 260);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(53)))), ((int)(((byte)(91)))));
            this.btn_Find.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.btn_Find.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Find.selected = false;
            this.btn_Find.Size = new System.Drawing.Size(150, 48);
            this.btn_Find.TabIndex = 71;
            this.btn_Find.Text = "Add";
            this.btn_Find.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Find.Textcolor = System.Drawing.Color.White;
            this.btn_Find.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Find.Click += new System.EventHandler(this.btn_Find_Click);
            // 
            // ckbx_Male
            // 
            this.ckbx_Male.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.ckbx_Male.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.ckbx_Male.Checked = true;
            this.ckbx_Male.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.ckbx_Male.ForeColor = System.Drawing.Color.White;
            this.ckbx_Male.Location = new System.Drawing.Point(147, 208);
            this.ckbx_Male.Name = "ckbx_Male";
            this.ckbx_Male.Size = new System.Drawing.Size(20, 20);
            this.ckbx_Male.TabIndex = 72;
            this.ckbx_Male.OnChange += new System.EventHandler(this.ckbx_Male_OnChange);
            // 
            // ckBx_Female
            // 
            this.ckBx_Female.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.ckBx_Female.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.ckBx_Female.Checked = false;
            this.ckBx_Female.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.ckBx_Female.ForeColor = System.Drawing.Color.White;
            this.ckBx_Female.Location = new System.Drawing.Point(377, 208);
            this.ckBx_Female.Name = "ckBx_Female";
            this.ckBx_Female.Size = new System.Drawing.Size(20, 20);
            this.ckBx_Female.TabIndex = 74;
            this.ckBx_Female.OnChange += new System.EventHandler(this.ckBx_Female_OnChange);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(291, 208);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 22);
            this.label3.TabIndex = 73;
            this.label3.Text = "Female:";
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(295, 260);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(53)))), ((int)(((byte)(91)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(150, 48);
            this.bunifuFlatButton1.TabIndex = 75;
            this.bunifuFlatButton1.Text = "Cancel";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // frm_AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(490, 330);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.ckBx_Female);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ckbx_Male);
            this.Controls.Add(this.btn_Find);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Address);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Phone);
            this.Controls.Add(this.lbl_Position);
            this.Controls.Add(this.txt_Name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_AddCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_FindKH";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Id;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Address;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Phone;
        private System.Windows.Forms.Label lbl_Position;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Name;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Find;
        private Bunifu.Framework.UI.BunifuCheckbox ckbx_Male;
        private Bunifu.Framework.UI.BunifuCheckbox ckBx_Female;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
    }
}