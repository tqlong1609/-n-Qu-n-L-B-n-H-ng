namespace QuanLyCuaHang
{
    partial class frm_SendNotification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_SendNotification));
            this.cbx_idEmployee = new Bunifu.Framework.UI.BunifuDropdown();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Exit = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Minisize = new Bunifu.Framework.UI.BunifuImageButton();
            this.txt_Text = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.btn_Send = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minisize)).BeginInit();
            this.SuspendLayout();
            // 
            // cbx_idEmployee
            // 
            this.cbx_idEmployee.BackColor = System.Drawing.Color.Transparent;
            this.cbx_idEmployee.BorderRadius = 3;
            this.cbx_idEmployee.DisabledColor = System.Drawing.Color.Gray;
            this.cbx_idEmployee.ForeColor = System.Drawing.Color.White;
            this.cbx_idEmployee.Location = new System.Drawing.Point(276, 12);
            this.cbx_idEmployee.Name = "cbx_idEmployee";
            this.cbx_idEmployee.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(145)))), ((int)(((byte)(24)))));
            this.cbx_idEmployee.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(145)))), ((int)(((byte)(24)))));
            this.cbx_idEmployee.selectedIndex = -1;
            this.cbx_idEmployee.Size = new System.Drawing.Size(215, 35);
            this.cbx_idEmployee.TabIndex = 87;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(140, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 22);
            this.label2.TabIndex = 95;
            this.label2.Text = "ID Employee:";
            // 
            // btn_Exit
            // 
            this.btn_Exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exit.Image")));
            this.btn_Exit.ImageActive = null;
            this.btn_Exit.Location = new System.Drawing.Point(643, 4);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(19, 20);
            this.btn_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Exit.TabIndex = 97;
            this.btn_Exit.TabStop = false;
            this.btn_Exit.Zoom = 10;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Minisize
            // 
            this.btn_Minisize.Image = ((System.Drawing.Image)(resources.GetObject("btn_Minisize.Image")));
            this.btn_Minisize.ImageActive = null;
            this.btn_Minisize.Location = new System.Drawing.Point(616, 4);
            this.btn_Minisize.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Minisize.Name = "btn_Minisize";
            this.btn_Minisize.Size = new System.Drawing.Size(22, 24);
            this.btn_Minisize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Minisize.TabIndex = 96;
            this.btn_Minisize.TabStop = false;
            this.btn_Minisize.Zoom = 10;
            this.btn_Minisize.Click += new System.EventHandler(this.btn_Minisize_Click);
            // 
            // txt_Text
            // 
            this.txt_Text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.txt_Text.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Text.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txt_Text.Location = new System.Drawing.Point(12, 53);
            this.txt_Text.Multiline = true;
            this.txt_Text.Name = "txt_Text";
            this.txt_Text.Size = new System.Drawing.Size(643, 234);
            this.txt_Text.TabIndex = 98;
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
            this.btn_Send.Location = new System.Drawing.Point(276, 293);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(53)))), ((int)(((byte)(91)))));
            this.btn_Send.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.btn_Send.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Send.selected = false;
            this.btn_Send.Size = new System.Drawing.Size(150, 48);
            this.btn_Send.TabIndex = 99;
            this.btn_Send.Text = "Send";
            this.btn_Send.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Send.Textcolor = System.Drawing.Color.White;
            this.btn_Send.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // frm_SendNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(667, 343);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.txt_Text);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Minisize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbx_idEmployee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_SendNotification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_SendNotification";
            ((System.ComponentModel.ISupportInitialize)(this.btn_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minisize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuDropdown cbx_idEmployee;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuImageButton btn_Exit;
        private Bunifu.Framework.UI.BunifuImageButton btn_Minisize;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_Text;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Send;
    }
}