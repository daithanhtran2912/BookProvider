using System;
using ThanhTDSE62847_Final_Project.DAO;
using System.Windows.Forms;

namespace ThanhTDSE62847_Final_Project
{
    public partial class frmQuanLyDaiLy : Form
    {
        private DaiLyDAO dao = new DaiLyDAO();

        public frmQuanLyDaiLy()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            dtGDaiLy.DataSource = dao.GetUnavailableDaiLy();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtGDaiLy.RowCount != 0)
                {
                    int index = dtGDaiLy.CurrentCell.RowIndex;
                    string maDL = dtGDaiLy.Rows[index].Cells[0].Value.ToString();
                    if (dao.UpdateCungCap(maDL))
                    {
                        LoadData();
                        MessageBox.Show("Cập nhật trạng thái thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtMaDL.Clear();
                        txtTenDL.Clear();
                        txtTenCDL.Clear();
                        txtDiaChi.Clear();
                        txtDienThoai.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật trạng thái không thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu để thay đổi!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Không có dữ liệu để thay đổi!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dtGDaiLy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = dtGDaiLy.CurrentCell.RowIndex;
                txtMaDL.Text = dtGDaiLy.Rows[index].Cells[0].Value.ToString();
                txtTenDL.Text = dtGDaiLy.Rows[index].Cells[1].Value.ToString();
                txtTenCDL.Text = dtGDaiLy.Rows[index].Cells[2].Value.ToString();
                txtDiaChi.Text = dtGDaiLy.Rows[index].Cells[3].Value.ToString();
                txtDienThoai.Text = dtGDaiLy.Rows[index].Cells[4].Value.ToString();
            }
            catch
            {
                //Ngọt-không làm gì
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            dtGDaiLy.DataSource = dao.FindDisabledDaiLyLikeByTenOrTenCDL(txtTim.Text.Trim());
        }
    }
}
