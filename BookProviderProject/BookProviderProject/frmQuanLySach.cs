using System;
using System.Windows.Forms;
using ThanhTDSE62847_Final_Project.DAO;

namespace ThanhTDSE62847_Final_Project
{
    public partial class frmQuanLySach : Form
    {
        private SachDAO dao = new SachDAO();

        public frmQuanLySach()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            dataGridKhoSach.DataSource = dao.GetAllSachDisabled();
        }

        private void dataGridKhoSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = dataGridKhoSach.CurrentCell.RowIndex;
                txtMaSach.Text = dataGridKhoSach.Rows[index].Cells[0].Value.ToString();
                txtTenSach.Text = dataGridKhoSach.Rows[index].Cells[1].Value.ToString();
                txtTenTG.Text = dataGridKhoSach.Rows[index].Cells[2].Value.ToString();
                txtGiaBia.Text = dataGridKhoSach.Rows[index].Cells[3].Value.ToString();
                txtGiaBanChoDL.Text = dataGridKhoSach.Rows[index].Cells[4].Value.ToString();
                txtMaNXB.Text = dataGridKhoSach.Rows[index].Cells[5].Value.ToString();
                txtTrang.Text = dataGridKhoSach.Rows[index].Cells[6].Value.ToString();
            }
            catch
            {
                //do nothing
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridKhoSach.RowCount != 0)
                {
                    int index = dataGridKhoSach.CurrentCell.RowIndex;
                    string maSach = dataGridKhoSach.Rows[index].Cells[0].Value.ToString();
                    if (dao.UpdateCungCap(maSach))
                    {
                        LoadData();
                        MessageBox.Show("Cập nhật trạng thái thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtMaNXB.Clear();
                        txtTenSach.Clear();
                        txtMaSach.Clear();
                        txtGiaBia.Clear();
                        txtGiaBanChoDL.Clear();
                        txtTenTG.Clear();
                        txtTrang.Clear();
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

        private void btnTim_Click(object sender, EventArgs e)
        {
            dataGridKhoSach.DataSource = dao.FindSachDisabledByLikeTenSachOrTenTG(txtTim.Text.Trim());
            txtMaNXB.Clear();
            txtTenSach.Clear();
            txtMaSach.Clear();
            txtGiaBia.Clear();
            txtGiaBanChoDL.Clear();
            txtTenTG.Clear();
            txtTrang.Clear();
        }
    }
}
