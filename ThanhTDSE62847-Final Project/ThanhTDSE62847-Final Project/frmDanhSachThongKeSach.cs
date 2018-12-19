using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThanhTDSE62847_Final_Project
{
    public partial class frmDanhSachThongKeSach : Form
    {
        public frmDanhSachThongKeSach()
        {
            InitializeComponent();
        }

        private void frmDanhSachThongKeSach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QuanLySachDBDataSet.tblSach' table. You can move, or remove it, as needed.
            this.tblSachTableAdapter.Fill(this.QuanLySachDBDataSet.tblSach);

            this.reportViewer1.RefreshReport();
        }
    }
}
