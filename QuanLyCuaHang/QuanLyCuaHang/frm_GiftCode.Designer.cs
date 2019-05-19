namespace QuanLyCuaHang
{
    partial class frm_GiftCode
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_GiftCode));
            this.dataGid_Gift = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btn_Repair = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_Delete = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_Add = new Bunifu.Framework.UI.BunifuTileButton();
            this.txt_id = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txt_discount = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Exit = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Minisize = new Bunifu.Framework.UI.BunifuImageButton();
            this.tbn_ID = new System.Windows.Forms.Button();
            this.btn_Discount = new System.Windows.Forms.Button();
            this.btn_Cancel = new Bunifu.Framework.UI.BunifuTileButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGid_Gift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minisize)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGid_Gift
            // 
            this.dataGid_Gift.AllowUserToAddRows = false;
            this.dataGid_Gift.AllowUserToResizeColumns = false;
            this.dataGid_Gift.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGid_Gift.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGid_Gift.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGid_Gift.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.dataGid_Gift.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGid_Gift.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGid_Gift.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGid_Gift.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGid_Gift.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGid_Gift.ColumnHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(145)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGid_Gift.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGid_Gift.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGid_Gift.DoubleBuffered = true;
            this.dataGid_Gift.EnableHeadersVisualStyles = false;
            this.dataGid_Gift.GridColor = System.Drawing.Color.Black;
            this.dataGid_Gift.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dataGid_Gift.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dataGid_Gift.Location = new System.Drawing.Point(0, 151);
            this.dataGid_Gift.Margin = new System.Windows.Forms.Padding(2);
            this.dataGid_Gift.MultiSelect = false;
            this.dataGid_Gift.Name = "dataGid_Gift";
            this.dataGid_Gift.ReadOnly = true;
            this.dataGid_Gift.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGid_Gift.RowHeadersVisible = false;
            this.dataGid_Gift.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.dataGid_Gift.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(145)))), ((int)(((byte)(24)))));
            this.dataGid_Gift.RowTemplate.Height = 30;
            this.dataGid_Gift.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGid_Gift.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGid_Gift.Size = new System.Drawing.Size(484, 197);
            this.dataGid_Gift.TabIndex = 87;
            this.dataGid_Gift.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGid_Gift_CellClick);
            // 
            // btn_Repair
            // 
            this.btn_Repair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Repair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.btn_Repair.color = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.btn_Repair.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(25)))), ((int)(((byte)(198)))));
            this.btn_Repair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Repair.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Repair.ForeColor = System.Drawing.Color.White;
            this.btn_Repair.Image = ((System.Drawing.Image)(resources.GetObject("btn_Repair.Image")));
            this.btn_Repair.ImagePosition = 14;
            this.btn_Repair.ImageZoom = 30;
            this.btn_Repair.LabelPosition = 29;
            this.btn_Repair.LabelText = "Repair";
            this.btn_Repair.Location = new System.Drawing.Point(227, 1);
            this.btn_Repair.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_Repair.Name = "btn_Repair";
            this.btn_Repair.Size = new System.Drawing.Size(71, 71);
            this.btn_Repair.TabIndex = 90;
            this.btn_Repair.Click += new System.EventHandler(this.btn_Repair_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.btn_Delete.color = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.btn_Delete.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(25)))), ((int)(((byte)(198)))));
            this.btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Delete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_Delete.Image")));
            this.btn_Delete.ImagePosition = 14;
            this.btn_Delete.ImageZoom = 30;
            this.btn_Delete.LabelPosition = 29;
            this.btn_Delete.LabelText = "Delete";
            this.btn_Delete.Location = new System.Drawing.Point(153, 1);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(57, 71);
            this.btn_Delete.TabIndex = 89;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.btn_Add.color = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.btn_Add.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(25)))), ((int)(((byte)(198)))));
            this.btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Image = ((System.Drawing.Image)(resources.GetObject("btn_Add.Image")));
            this.btn_Add.ImagePosition = 14;
            this.btn_Add.ImageZoom = 30;
            this.btn_Add.LabelPosition = 29;
            this.btn_Add.LabelText = "Add";
            this.btn_Add.Location = new System.Drawing.Point(65, 1);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(78, 71);
            this.btn_Add.TabIndex = 88;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.txt_id.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_id.Location = new System.Drawing.Point(77, 73);
            this.txt_id.Multiline = true;
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(123, 29);
            this.txt_id.TabIndex = 91;
            // 
            // txt_discount
            // 
            this.txt_discount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.txt_discount.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_discount.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_discount.Location = new System.Drawing.Point(374, 73);
            this.txt_discount.Multiline = true;
            this.txt_discount.Name = "txt_discount";
            this.txt_discount.Size = new System.Drawing.Size(47, 29);
            this.txt_discount.TabIndex = 92;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 22);
            this.label1.TabIndex = 93;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(280, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 22);
            this.label2.TabIndex = 94;
            this.label2.Text = "Discount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(423, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 22);
            this.label3.TabIndex = 95;
            this.label3.Text = "%";
            // 
            // btn_Exit
            // 
            this.btn_Exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exit.Image")));
            this.btn_Exit.ImageActive = null;
            this.btn_Exit.Location = new System.Drawing.Point(454, 11);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(19, 20);
            this.btn_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Exit.TabIndex = 104;
            this.btn_Exit.TabStop = false;
            this.btn_Exit.Zoom = 10;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Minisize
            // 
            this.btn_Minisize.Image = ((System.Drawing.Image)(resources.GetObject("btn_Minisize.Image")));
            this.btn_Minisize.ImageActive = null;
            this.btn_Minisize.Location = new System.Drawing.Point(427, 9);
            this.btn_Minisize.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Minisize.Name = "btn_Minisize";
            this.btn_Minisize.Size = new System.Drawing.Size(22, 24);
            this.btn_Minisize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Minisize.TabIndex = 103;
            this.btn_Minisize.TabStop = false;
            this.btn_Minisize.Zoom = 10;
            this.btn_Minisize.Click += new System.EventHandler(this.btn_Minisize_Click);
            // 
            // tbn_ID
            // 
            this.tbn_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.tbn_ID.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.tbn_ID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbn_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbn_ID.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tbn_ID.Location = new System.Drawing.Point(0, 128);
            this.tbn_ID.Name = "tbn_ID";
            this.tbn_ID.Size = new System.Drawing.Size(243, 23);
            this.tbn_ID.TabIndex = 105;
            this.tbn_ID.Text = "ID Code";
            this.tbn_ID.UseVisualStyleBackColor = false;
            // 
            // btn_Discount
            // 
            this.btn_Discount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.btn_Discount.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Discount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Discount.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Discount.Location = new System.Drawing.Point(242, 128);
            this.btn_Discount.Name = "btn_Discount";
            this.btn_Discount.Size = new System.Drawing.Size(242, 23);
            this.btn_Discount.TabIndex = 106;
            this.btn_Discount.Text = "Discount";
            this.btn_Discount.UseVisualStyleBackColor = false;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.btn_Cancel.color = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.btn_Cancel.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(25)))), ((int)(((byte)(198)))));
            this.btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.ForeColor = System.Drawing.Color.White;
            this.btn_Cancel.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cancel.Image")));
            this.btn_Cancel.ImagePosition = 14;
            this.btn_Cancel.ImageZoom = 30;
            this.btn_Cancel.LabelPosition = 29;
            this.btn_Cancel.LabelText = "Cancel";
            this.btn_Cancel.Location = new System.Drawing.Point(308, 1);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(71, 71);
            this.btn_Cancel.TabIndex = 107;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // frm_GiftCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(484, 348);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Discount);
            this.Controls.Add(this.tbn_ID);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Minisize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_discount);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.btn_Repair);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dataGid_Gift);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_GiftCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_GiftCode";
            ((System.ComponentModel.ISupportInitialize)(this.dataGid_Gift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minisize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGid_Gift;
        private Bunifu.Framework.UI.BunifuTileButton btn_Repair;
        private Bunifu.Framework.UI.BunifuTileButton btn_Delete;
        private Bunifu.Framework.UI.BunifuTileButton btn_Add;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_id;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_discount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuImageButton btn_Exit;
        private Bunifu.Framework.UI.BunifuImageButton btn_Minisize;
        private System.Windows.Forms.Button tbn_ID;
        private System.Windows.Forms.Button btn_Discount;
        private Bunifu.Framework.UI.BunifuTileButton btn_Cancel;
    }
}