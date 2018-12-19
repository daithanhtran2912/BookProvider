namespace ThanhTDSE62847_Final_Project
{
    partial class frmTaoMoiHoaDon
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
            this.btnTaoMoi = new System.Windows.Forms.Button();
            this.dtpNgayTao = new System.Windows.Forms.DateTimePicker();
            this.cbMaDL = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridSach = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSach)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTaoMoi);
            this.groupBox1.Controls.Add(this.dtpNgayTao);
            this.groupBox1.Controls.Add(this.cbMaDL);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1235, 185);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết hóa đơn";
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.Location = new System.Drawing.Point(805, 76);
            this.btnTaoMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(169, 58);
            this.btnTaoMoi.TabIndex = 5;
            this.btnTaoMoi.Text = "Tạo mới";
            this.btnTaoMoi.UseVisualStyleBackColor = true;
            this.btnTaoMoi.Click += new System.EventHandler(this.btnTaoMoi_Click);
            // 
            // dtpNgayTao
            // 
            this.dtpNgayTao.Enabled = false;
            this.dtpNgayTao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayTao.Location = new System.Drawing.Point(223, 58);
            this.dtpNgayTao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgayTao.Name = "dtpNgayTao";
            this.dtpNgayTao.Size = new System.Drawing.Size(235, 24);
            this.dtpNgayTao.TabIndex = 4;
            // 
            // cbMaDL
            // 
            this.cbMaDL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaDL.FormattingEnabled = true;
            this.cbMaDL.Location = new System.Drawing.Point(223, 130);
            this.cbMaDL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMaDL.Name = "cbMaDL";
            this.cbMaDL.Size = new System.Drawing.Size(235, 26);
            this.cbMaDL.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã đại lý:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày lập hóa đơn:";
            // 
            // dataGridSach
            // 
            this.dataGridSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridSach.Location = new System.Drawing.Point(12, 294);
            this.dataGridSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridSach.MultiSelect = false;
            this.dataGridSach.Name = "dataGridSach";
            this.dataGridSach.RowTemplate.Height = 24;
            this.dataGridSach.Size = new System.Drawing.Size(1235, 274);
            this.dataGridSach.TabIndex = 1;
            this.dataGridSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSach_CellClick);
            this.dataGridSach.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSach_CellValueChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "luaChon";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "soLuong";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(119, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tìm sách:";
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(475, 245);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(87, 24);
            this.btnTim.TabIndex = 3;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(209, 245);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(234, 22);
            this.txtTim.TabIndex = 4;
            // 
            // frmTaoMoiHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 610);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridSach);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTaoMoiHoaDon";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo Hóa Đơn";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMaDL;
        private System.Windows.Forms.DateTimePicker dtpNgayTao;
        private System.Windows.Forms.DataGridView dataGridSach;
        private System.Windows.Forms.Button btnTaoMoi;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTim;
    }
}