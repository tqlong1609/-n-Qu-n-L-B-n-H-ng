namespace QuanLyCuaHang
{
    partial class uct_Notification
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uct_Notification));
            this.dataGid_Notification = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.tbn_ID = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Delete = new Bunifu.Framework.UI.BunifuTileButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGid_Notification)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGid_Notification
            // 
            this.dataGid_Notification.AllowUserToAddRows = false;
            this.dataGid_Notification.AllowUserToDeleteRows = false;
            this.dataGid_Notification.AllowUserToResizeColumns = false;
            this.dataGid_Notification.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGid_Notification.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGid_Notification.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGid_Notification.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            this.dataGid_Notification.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGid_Notification.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGid_Notification.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGid_Notification.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGid_Notification.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGid_Notification.ColumnHeadersVisible = false;
            this.dataGid_Notification.DoubleBuffered = true;
            this.dataGid_Notification.EnableHeadersVisualStyles = false;
            this.dataGid_Notification.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGid_Notification.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dataGid_Notification.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dataGid_Notification.Location = new System.Drawing.Point(2, 106);
            this.dataGid_Notification.Margin = new System.Windows.Forms.Padding(2);
            this.dataGid_Notification.MultiSelect = false;
            this.dataGid_Notification.Name = "dataGid_Notification";
            this.dataGid_Notification.ReadOnly = true;
            this.dataGid_Notification.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGid_Notification.RowHeadersVisible = false;
            this.dataGid_Notification.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            this.dataGid_Notification.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGid_Notification.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(145)))), ((int)(((byte)(24)))));
            this.dataGid_Notification.RowTemplate.Height = 24;
            this.dataGid_Notification.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGid_Notification.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGid_Notification.Size = new System.Drawing.Size(687, 469);
            this.dataGid_Notification.TabIndex = 89;
            this.dataGid_Notification.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGid_Notification_CellClick);
            this.dataGid_Notification.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGid_Notification_CellDoubleClick);
            // 
            // tbn_ID
            // 
            this.tbn_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.tbn_ID.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.tbn_ID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbn_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbn_ID.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tbn_ID.Location = new System.Drawing.Point(2, 82);
            this.tbn_ID.Name = "tbn_ID";
            this.tbn_ID.Size = new System.Drawing.Size(344, 23);
            this.tbn_ID.TabIndex = 106;
            this.tbn_ID.Text = "Context";
            this.tbn_ID.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(345, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(344, 23);
            this.button1.TabIndex = 107;
            this.button1.Text = "Readed";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            this.btn_Delete.color = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            this.btn_Delete.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(25)))), ((int)(((byte)(198)))));
            this.btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Delete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_Delete.Image")));
            this.btn_Delete.ImagePosition = 14;
            this.btn_Delete.ImageZoom = 30;
            this.btn_Delete.LabelPosition = 29;
            this.btn_Delete.LabelText = "Delete";
            this.btn_Delete.Location = new System.Drawing.Point(317, 3);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(57, 71);
            this.btn_Delete.TabIndex = 108;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // uct_Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbn_ID);
            this.Controls.Add(this.dataGid_Notification);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "uct_Notification";
            this.Size = new System.Drawing.Size(691, 577);
            ((System.ComponentModel.ISupportInitialize)(this.dataGid_Notification)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGid_Notification;
        private System.Windows.Forms.Button tbn_ID;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuTileButton btn_Delete;
    }
}
