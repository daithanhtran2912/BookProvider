using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using ThanhTDSE62847_Final_Project.DAO;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ThanhTDSE62847_Final_Project
{
    public partial class frmHoaDon : Form
    {
        private HoaDonDAO dao = new HoaDonDAO();
        public frmHoaDon()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            dataGridHoaDon.DataSource = dao.GetAllHoaDon();
        }

        private void dataGridHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = dataGridHoaDon.CurrentCell.RowIndex;
                string maHD = dataGridHoaDon.Rows[index].Cells[0].Value.ToString();
                dataGridChiTietHoaDon.DataSource = dao.GetHoaDonDetail(int.Parse(maHD));
            }
            catch
            {
                //do nothing
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                Regex regex = new Regex("^[0-9]+$");
                if (txtTim.Text.Trim() == "")
                {
                    LoadData();
                }
                else
                {
                    if (regex.IsMatch(txtTim.Text.Trim()))
                    {
                        dataGridHoaDon.DataSource = dao.FindHoaDonByLikeSoHDOrMaDL(int.Parse(txtTim.Text.Trim()));
                    }
                    else
                    {
                        MessageBox.Show("Số hóa đơn là chữ số!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                txtTim.Clear();
            }
            catch
            {

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridHoaDon.RowCount != 0)
                {
                    int index = dataGridChiTietHoaDon.CurrentCell.RowIndex;
                    int soHD = int.Parse(dataGridChiTietHoaDon.Rows[index].Cells[0].Value.ToString());
                    if (MessageBox.Show("Bạn có muốn hủy hóa đơn này?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (dao.RemoveHoaDon(soHD))
                        {
                            LoadData();
                            dataGridChiTietHoaDon.DataSource = dao.GetHoaDonDetail(int.Parse("0"));
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu để xóa!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                //Ngọt - Không làm gì =))
            }
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            frmTaoMoiHoaDon tm = new frmTaoMoiHoaDon();
            tm.Show();
        }
    }
}
