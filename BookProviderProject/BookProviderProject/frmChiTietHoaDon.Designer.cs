namespace ThanhTDSE62847_Final_Project
{
    partial class frmChiTietHoaDon
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.GetNewestBillBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QuanLySachDBDataSet = new ThanhTDSE62847_Final_Project.QuanLySachDBDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.GetNewestBillTableAdapter = new ThanhTDSE62847_Final_Project.QuanLySachDBDataSetTableAdapters.GetNewestBillTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.GetNewestBillBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLySachDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // GetNewestBillBindingSource
            // 
            this.GetNewestBillBindingSource.DataMember = "GetNewestBill";
            this.GetNewestBillBindingSource.DataSource = this.QuanLySachDBDataSet;
            // 
            // QuanLySachDBDataSet
            // 
            this.QuanLySachDBDataSet.DataSetName = "QuanLySachDBDataSet";
            this.QuanLySachDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.GetNewestBillBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ThanhTDSE62847_Final_Project.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1632, 936);
            this.reportViewer1.TabIndex = 0;
            // 
            // GetNewestBillTableAdapter
            // 
            this.GetNewestBillTableAdapter.ClearBeforeFill = true;
            // 
            // frmChiTietHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1632, 936);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmChiTietHoaDon";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi Tiết Hóa Đơn";
            this.Load += new System.EventHandler(this.frmChiTietHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GetNewestBillBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLySachDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource GetNewestBillBindingSource;
        private QuanLySachDBDataSet QuanLySachDBDataSet;
        private QuanLySachDBDataSetTableAdapters.GetNewestBillTableAdapter GetNewestBillTableAdapter;
    }
}