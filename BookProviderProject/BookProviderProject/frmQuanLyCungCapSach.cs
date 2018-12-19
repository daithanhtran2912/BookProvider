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
    public partial class frmQuanLyCungCapSach : Form
    {
        public frmQuanLyCungCapSach()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void đạiLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDaiLy daiLy = new frmDaiLy();
            daiLy.MdiParent = this;
            daiLy.Show();
        }

        private void cácNhàXuấtBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhaXB nhaxb = new frmNhaXB();
            nhaxb.MdiParent = this;
            nhaxb.Show();
        }

        private void quảnLýHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDon hoaDon = new frmHoaDon();
            hoaDon.MdiParent = this;
            hoaDon.Show();
        }

        private void quảnLýCácLoạiSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSach sach = new frmSach();
            sach.MdiParent = this;
            sach.Show();
        }

        private void quảnLýNhàXuấtBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyNXB nxb = new frmQuanLyNXB();
            nxb.MdiParent = this;
            nxb.Show();
        }

        private void qToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyDaiLy dl = new frmQuanLyDaiLy();
            dl.MdiParent = this;
            dl.Show();
        }

        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLySach qlSach = new frmQuanLySach();
            qlSach.MdiParent = this;
            qlSach.Show();
        }

        private void quảnLýDanhSáchHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyHoaDon dshd = new frmQuanLyHoaDon();
            dshd.MdiParent = this;
            dshd.Show();
        }

        private void thốngKêCácLoạiSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDanhSachThongKeSach dstk = new frmDanhSachThongKeSach();
            dstk.MdiParent = this;
            dstk.Show();
        }
    }
}
