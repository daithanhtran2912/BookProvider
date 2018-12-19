namespace ThanhTDSE62847_Final_Project
{
    partial class frmDanhSachThongKeSach
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
            this.tblSachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QuanLySachDBDataSet = new ThanhTDSE62847_Final_Project.QuanLySachDBDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tblSachTableAdapter = new ThanhTDSE62847_Final_Project.QuanLySachDBDataSetTableAdapters.tblSachTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblSachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLySachDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tblSachBindingSource
            // 
            this.tblSachBindingSource.DataMember = "tblSach";
            this.tblSachBindingSource.DataSource = this.QuanLySachDBDataSet;
            // 
            // QuanLySachDBDataSet
            // 
            this.QuanLySachDBDataSet.DataSetName = "QuanLySachDBDataSet";
            this.QuanLySachDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tblSachBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ThanhTDSE62847_Final_Project.SachRP.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1199, 829);
            this.reportViewer1.TabIndex = 1;
            // 
            // tblSachTableAdapter
            // 
            this.tblSachTableAdapter.ClearBeforeFill = true;
            // 
            // frmDanhSachThongKeSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 829);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmDanhSachThongKeSach";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống Kê Các Loại Sách";
            this.Load += new System.EventHandler(this.frmDanhSachThongKeSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblSachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLySachDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tblSachBindingSource;
        private QuanLySachDBDataSet QuanLySachDBDataSet;
        private QuanLySachDBDataSetTableAdapters.tblSachTableAdapter tblSachTableAdapter;
    }
}