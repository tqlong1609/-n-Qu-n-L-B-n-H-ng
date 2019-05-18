namespace QuanLyCuaHang
{
    partial class frm_ReportHistory
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.QUANLYCUAHANGDataSet = new QuanLyCuaHang.QUANLYCUAHANGDataSet();
            this.HOADONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HOADONTableAdapter = new QuanLyCuaHang.QUANLYCUAHANGDataSetTableAdapters.HOADONTableAdapter();
            this.btn_Exit = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.QUANLYCUAHANGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HOADONBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportViewer1.ForeColor = System.Drawing.Color.Gray;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.HOADONBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyCuaHang.ReportHistory.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(810, 379);
            this.reportViewer1.TabIndex = 0;
            // 
            // QUANLYCUAHANGDataSet
            // 
            this.QUANLYCUAHANGDataSet.DataSetName = "QUANLYCUAHANGDataSet";
            this.QUANLYCUAHANGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // HOADONBindingSource
            // 
            this.HOADONBindingSource.DataMember = "HOADON";
            this.HOADONBindingSource.DataSource = this.QUANLYCUAHANGDataSet;
            // 
            // HOADONTableAdapter
            // 
            this.HOADONTableAdapter.ClearBeforeFill = true;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Active = false;
            this.btn_Exit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(53)))), ((int)(((byte)(91)))));
            this.btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Exit.BorderRadius = 0;
            this.btn_Exit.ButtonText = "Exit";
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Exit.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Exit.Iconimage = null;
            this.btn_Exit.Iconimage_right = null;
            this.btn_Exit.Iconimage_right_Selected = null;
            this.btn_Exit.Iconimage_Selected = null;
            this.btn_Exit.IconMarginLeft = 0;
            this.btn_Exit.IconMarginRight = 0;
            this.btn_Exit.IconRightVisible = true;
            this.btn_Exit.IconRightZoom = 0D;
            this.btn_Exit.IconVisible = true;
            this.btn_Exit.IconZoom = 40D;
            this.btn_Exit.IsTab = false;
            this.btn_Exit.Location = new System.Drawing.Point(702, 388);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(53)))), ((int)(((byte)(91)))));
            this.btn_Exit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.btn_Exit.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Exit.selected = false;
            this.btn_Exit.Size = new System.Drawing.Size(111, 48);
            this.btn_Exit.TabIndex = 86;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Exit.Textcolor = System.Drawing.Color.White;
            this.btn_Exit.TextFont = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click_1);
            // 
            // frm_ReportHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(817, 439);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_ReportHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_ReportHistory";
            this.Load += new System.EventHandler(this.frm_ReportHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QUANLYCUAHANGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HOADONBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource HOADONBindingSource;
        private QUANLYCUAHANGDataSet QUANLYCUAHANGDataSet;
        private QUANLYCUAHANGDataSetTableAdapters.HOADONTableAdapter HOADONTableAdapter;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Exit;
    }
}