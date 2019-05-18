namespace QuanLyCuaHang
{
    partial class frm_TextNotification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_TextNotification));
            this.txt_Notification = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Exit = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Minisize = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minisize)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Notification
            // 
            this.txt_Notification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.txt_Notification.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_Notification.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Notification.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_Notification.Location = new System.Drawing.Point(3, 49);
            this.txt_Notification.Multiline = true;
            this.txt_Notification.Name = "txt_Notification";
            this.txt_Notification.Size = new System.Drawing.Size(468, 201);
            this.txt_Notification.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(177, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 22);
            this.label1.TabIndex = 83;
            this.label1.Text = "Notification";
            // 
            // btn_Exit
            // 
            this.btn_Exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exit.Image")));
            this.btn_Exit.ImageActive = null;
            this.btn_Exit.Location = new System.Drawing.Point(452, 3);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(19, 20);
            this.btn_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Exit.TabIndex = 99;
            this.btn_Exit.TabStop = false;
            this.btn_Exit.Zoom = 10;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Minisize
            // 
            this.btn_Minisize.Image = ((System.Drawing.Image)(resources.GetObject("btn_Minisize.Image")));
            this.btn_Minisize.ImageActive = null;
            this.btn_Minisize.Location = new System.Drawing.Point(425, 3);
            this.btn_Minisize.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Minisize.Name = "btn_Minisize";
            this.btn_Minisize.Size = new System.Drawing.Size(22, 24);
            this.btn_Minisize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Minisize.TabIndex = 98;
            this.btn_Minisize.TabStop = false;
            this.btn_Minisize.Zoom = 10;
            this.btn_Minisize.Click += new System.EventHandler(this.btn_Minisize_Click);
            // 
            // frm_TextNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(473, 253);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Minisize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Notification);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_TextNotification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_TextNotification";
            ((System.ComponentModel.ISupportInitialize)(this.btn_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minisize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_Notification;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton btn_Exit;
        private Bunifu.Framework.UI.BunifuImageButton btn_Minisize;
    }
}