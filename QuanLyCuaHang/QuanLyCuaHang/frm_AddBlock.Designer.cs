namespace QuanLyCuaHang
{
    partial class frm_AddBlock
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
            this.btn_Add = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lbl_Position = new System.Windows.Forms.Label();
            this.txt_Name = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btn_Cancel = new Bunifu.Framework.UI.BunifuFlatButton();
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
            this.btn_Add.Location = new System.Drawing.Point(43, 129);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(53)))), ((int)(((byte)(91)))));
            this.btn_Add.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.btn_Add.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Add.selected = false;
            this.btn_Add.Size = new System.Drawing.Size(150, 48);
            this.btn_Add.TabIndex = 84;
            this.btn_Add.Text = "Add";
            this.btn_Add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Add.Textcolor = System.Drawing.Color.White;
            this.btn_Add.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Click += new System.EventHandler(this.btn_Find_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 22);
            this.label1.TabIndex = 81;
            this.label1.Text = "ID:";
            // 
            // txt_id
            // 
            this.txt_id.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(53)))), ((int)(((byte)(91)))));
            this.txt_id.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(145)))), ((int)(((byte)(24)))));
            this.txt_id.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(53)))), ((int)(((byte)(91)))));
            this.txt_id.BorderThickness = 3;
            this.txt_id.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_id.Enabled = false;
            this.txt_id.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.ForeColor = System.Drawing.Color.White;
            this.txt_id.isPassword = false;
            this.txt_id.Location = new System.Drawing.Point(194, 15);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_id.MaxLength = 32767;
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(283, 39);
            this.txt_id.TabIndex = 80;
            this.txt_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbl_Position
            // 
            this.lbl_Position.AutoSize = true;
            this.lbl_Position.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Position.ForeColor = System.Drawing.Color.White;
            this.lbl_Position.Location = new System.Drawing.Point(14, 67);
            this.lbl_Position.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Position.Name = "lbl_Position";
            this.lbl_Position.Size = new System.Drawing.Size(71, 22);
            this.lbl_Position.TabIndex = 73;
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
            this.txt_Name.Location = new System.Drawing.Point(194, 60);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Name.MaxLength = 32767;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(283, 39);
            this.txt_Name.TabIndex = 72;
            this.txt_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Active = false;
            this.btn_Cancel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(53)))), ((int)(((byte)(91)))));
            this.btn_Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Cancel.BorderRadius = 0;
            this.btn_Cancel.ButtonText = "Cancel";
            this.btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cancel.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Cancel.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Cancel.Iconimage = null;
            this.btn_Cancel.Iconimage_right = null;
            this.btn_Cancel.Iconimage_right_Selected = null;
            this.btn_Cancel.Iconimage_Selected = null;
            this.btn_Cancel.IconMarginLeft = 0;
            this.btn_Cancel.IconMarginRight = 0;
            this.btn_Cancel.IconRightVisible = true;
            this.btn_Cancel.IconRightZoom = 0D;
            this.btn_Cancel.IconVisible = true;
            this.btn_Cancel.IconZoom = 40D;
            this.btn_Cancel.IsTab = false;
            this.btn_Cancel.Location = new System.Drawing.Point(292, 129);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(53)))), ((int)(((byte)(91)))));
            this.btn_Cancel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.btn_Cancel.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Cancel.selected = false;
            this.btn_Cancel.Size = new System.Drawing.Size(150, 48);
            this.btn_Cancel.TabIndex = 85;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Cancel.Textcolor = System.Drawing.Color.White;
            this.btn_Cancel.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // frm_AddBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(490, 189);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_Position);
            this.Controls.Add(this.txt_Name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_AddBlock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_FindB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btn_Add;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_id;
        private System.Windows.Forms.Label lbl_Position;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Name;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Cancel;
    }
}