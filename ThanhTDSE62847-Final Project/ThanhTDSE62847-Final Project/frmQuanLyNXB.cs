using ThanhTDSE62847_Final_Project.DAO;
using System.Windows.Forms;
using System.Collections.Generic;
using System;

namespace ThanhTDSE62847_Final_Project
{
    public partial class frmQuanLyNXB : Form
    {
        private NhaXBDAO dao = new NhaXBDAO();
        public frmQuanLyNXB()
        {
            InitializeComponent();
            LoadData();
            txtMaNXB.ReadOnly = true;
            txtTenNXB.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            txtDienThoai.ReadOnly = true;
        }

        private void LoadData()
        {
            dataGridNXB.DataSource = dao.GetUnavailableNXB();
        }

        private void dataGridNXB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = dataGridNXB.CurrentCell.RowIndex;
                txtMaNXB.Text = dataGridNXB.Rows[index].Cells[0].Value.ToString();
                txtTenNXB.Text = dataGridNXB.Rows[index].Cells[1].Value.ToString();
                txtDiaChi.Text = dataGridNXB.Rows[index].Cells[2].Value.ToString();
                txtDienThoai.Text = dataGridNXB.Rows[index].Cells[3].Value.ToString();
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
                if (dataGridNXB.RowCount != 0)
                {
                    int index = dataGridNXB.CurrentCell.RowIndex;
                    string maNXB = dataGridNXB.Rows[index].Cells[0].Value.ToString();
                    if (dao.UpdateCungCap(maNXB))
                    {
                        LoadData();
                        MessageBox.Show("Cập nhật trạng thái thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtMaNXB.Clear();
                        txtTenNXB.Clear();
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

        private void btnTim_Click(object sender, EventArgs e)
        {
            dataGridNXB.DataSource = dao.FindNXBDisabledByName(txtTim.Text.Trim());
        }
    }
}
