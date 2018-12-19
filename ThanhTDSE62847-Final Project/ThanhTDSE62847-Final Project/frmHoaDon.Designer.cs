namespace ThanhTDSE62847_Final_Project
{
    partial class frmHoaDon
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridChiTietHoaDon = new System.Windows.Forms.DataGridView();
            this.dataGridHoaDon = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnTao = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridChiTietHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridChiTietHoaDon);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(958, 258);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn";
            // 
            // dataGridChiTietHoaDon
            // 
            this.dataGridChiTietHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridChiTietHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridChiTietHoaDon.Location = new System.Drawing.Point(4, 32);
            this.dataGridChiTietHoaDon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridChiTietHoaDon.Name = "dataGridChiTietHoaDon";
            this.dataGridChiTietHoaDon.ReadOnly = true;
            this.dataGridChiTietHoaDon.RowTemplate.Height = 24;
            this.dataGridChiTietHoaDon.Size = new System.Drawing.Size(950, 222);
            this.dataGridChiTietHoaDon.TabIndex = 0;
            // 
            // dataGridHoaDon
            // 
            this.dataGridHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHoaDon.Location = new System.Drawing.Point(9, 342);
            this.dataGridHoaDon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridHoaDon.MultiSelect = false;
            this.dataGridHoaDon.Name = "dataGridHoaDon";
            this.dataGridHoaDon.ReadOnly = true;
            this.dataGridHoaDon.RowTemplate.Height = 24;
            this.dataGridHoaDon.Size = new System.Drawing.Size(958, 247);
            this.dataGridHoaDon.TabIndex = 1;
            this.dataGridHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridHoaDon_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 296);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tìm hóa đơn:";
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(98, 295);
            this.txtTim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(108, 20);
            this.txtTim.TabIndex = 3;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(229, 295);
            this.btnTim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(65, 20);
            this.btnTim.TabIndex = 4;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnTao
            // 
            this.btnTao.Location = new System.Drawing.Point(650, 289);
            this.btnTao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(105, 31);
            this.btnTao.TabIndex = 5;
            this.btnTao.Text = "Tạo hóa đơn";
            this.btnTao.UseVisualStyleBackColor = true;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(807, 288);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(105, 31);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa hóa đơn";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 616);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnTao);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridHoaDon);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHoaDon";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Hóa Đơn";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridChiTietHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridHoaDon;
        private System.Windows.Forms.DataGridView dataGridChiTietHoaDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.Button btnXoa;
    }
}