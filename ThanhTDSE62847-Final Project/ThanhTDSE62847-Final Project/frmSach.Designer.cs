namespace ThanhTDSE62847_Final_Project
{
    partial class frmSach
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
            this.txtTrang = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbMaNXB = new System.Windows.Forms.ComboBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtGiaBanChoDL = new System.Windows.Forms.TextBox();
            this.txtGiaBia = new System.Windows.Forms.TextBox();
            this.txtTenTG = new System.Windows.Forms.TextBox();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridKhoSach = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKhoSach)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTrang);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbMaNXB);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.txtGiaBanChoDL);
            this.groupBox1.Controls.Add(this.txtGiaBia);
            this.groupBox1.Controls.Add(this.txtTenTG);
            this.groupBox1.Controls.Add(this.txtTenSach);
            this.groupBox1.Controls.Add(this.txtMaSach);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox1.Location = new System.Drawing.Point(19, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(932, 249);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sách";
            // 
            // txtTrang
            // 
            this.txtTrang.Location = new System.Drawing.Point(158, 180);
            this.txtTrang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTrang.Name = "txtTrang";
            this.txtTrang.Size = new System.Drawing.Size(252, 21);
            this.txtTrang.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(63, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "Số trang:";
            // 
            // cbMaNXB
            // 
            this.cbMaNXB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaNXB.FormattingEnabled = true;
            this.cbMaNXB.Location = new System.Drawing.Point(575, 128);
            this.cbMaNXB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbMaNXB.Name = "cbMaNXB";
            this.cbMaNXB.Size = new System.Drawing.Size(252, 23);
            this.cbMaNXB.TabIndex = 16;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(786, 182);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(123, 42);
            this.btnSua.TabIndex = 15;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(623, 182);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(123, 42);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(461, 182);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(123, 42);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtGiaBanChoDL
            // 
            this.txtGiaBanChoDL.Location = new System.Drawing.Point(575, 84);
            this.txtGiaBanChoDL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGiaBanChoDL.Name = "txtGiaBanChoDL";
            this.txtGiaBanChoDL.Size = new System.Drawing.Size(252, 21);
            this.txtGiaBanChoDL.TabIndex = 10;
            // 
            // txtGiaBia
            // 
            this.txtGiaBia.Location = new System.Drawing.Point(575, 42);
            this.txtGiaBia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGiaBia.Name = "txtGiaBia";
            this.txtGiaBia.Size = new System.Drawing.Size(252, 21);
            this.txtGiaBia.TabIndex = 9;
            // 
            // txtTenTG
            // 
            this.txtTenTG.Location = new System.Drawing.Point(158, 129);
            this.txtTenTG.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenTG.Name = "txtTenTG";
            this.txtTenTG.Size = new System.Drawing.Size(252, 21);
            this.txtTenTG.TabIndex = 8;
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(158, 84);
            this.txtTenSach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(252, 21);
            this.txtTenSach.TabIndex = 7;
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(158, 42);
            this.txtMaSach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(252, 21);
            this.txtMaSach.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(459, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mã nhà xuất bản:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(459, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giá bán cho đại lý:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(459, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giá bìa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên tác giả:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên sách:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sách:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridKhoSach);
            this.groupBox2.Location = new System.Drawing.Point(19, 313);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(932, 389);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kho sách";
            // 
            // dataGridKhoSach
            // 
            this.dataGridKhoSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridKhoSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridKhoSach.Location = new System.Drawing.Point(0, 30);
            this.dataGridKhoSach.MultiSelect = false;
            this.dataGridKhoSach.Name = "dataGridKhoSach";
            this.dataGridKhoSach.ReadOnly = true;
            this.dataGridKhoSach.Size = new System.Drawing.Size(931, 317);
            this.dataGridKhoSach.TabIndex = 0;
            this.dataGridKhoSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridKhoSach_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(111, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Tìm sách:";
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(177, 284);
            this.txtTim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(252, 20);
            this.txtTim.TabIndex = 12;
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(447, 280);
            this.btnTim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(93, 27);
            this.btnTim.TabIndex = 13;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // frmSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(971, 730);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSach";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Kho Sách";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKhoSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridKhoSach;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGiaBanChoDL;
        private System.Windows.Forms.TextBox txtGiaBia;
        private System.Windows.Forms.TextBox txtTenTG;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.ComboBox cbMaNXB;
        private System.Windows.Forms.TextBox txtTrang;
        private System.Windows.Forms.Label label8;
    }
}