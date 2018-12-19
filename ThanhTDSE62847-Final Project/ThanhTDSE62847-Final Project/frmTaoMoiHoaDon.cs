using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ThanhTDSE62847_Final_Project.DAO;

namespace ThanhTDSE62847_Final_Project
{
    public partial class frmTaoMoiHoaDon : Form
    {
        private DaiLyDAO dlDao = new DaiLyDAO();
        private SachDAO sachDao = new SachDAO();
        private HoaDonDAO dao = new HoaDonDAO();
        private Regex regex = new Regex("^[0-9]+$");
        public frmTaoMoiHoaDon()
        {
            InitializeComponent();
            LoadMaDL();
            LoadListSach();
        }

        private void LoadMaDL()
        {
            try
            {
                List<string> tmp = new List<string>();
                foreach (var item in dlDao.GetAllDaiLy())
                {
                    tmp.Add(item.maDaiLy);
                }
                cbMaDL.DataSource = tmp;
            }
            catch
            {

            }
        }

        private void LoadListSach()
        {
            dataGridSach.DataSource = sachDao.GetAllSach();
        }

        private void btnTaoMoi_Click(object sender, System.EventArgs e)
        {
            try
            {
                Dictionary<string, int> listHoaDon = new Dictionary<string, int>();
                //duyệt các phần tử của dataGridView
                foreach (DataGridViewRow row in dataGridSach.Rows)
                {
                    //kiểm tra xem người dùng có check chọn dữ liệu trong dataGrid hay không
                    bool isSelected = Convert.ToBoolean(row.Cells[0].Value);
                    if (isSelected)
                    {
                        //lấy mã sách và số lượng của những checkbox đã đc checked
                        string tmp = Convert.ToString(row.Cells[2].Value); //mã sách
                        string num = Convert.ToString(row.Cells[1].Value); //số lượng
                        if (!regex.IsMatch(num))
                        {
                            MessageBox.Show("Số lượng phải là chữ số và không được để trống!!!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        else
                        {
                            //bỏ vào Dict một cặp key, value là mã sách và số lượng
                            listHoaDon.Add(tmp, int.Parse(num));
                        }
                    }
                }
                //kiểm tra Dict có chứa dữ liệu hay không
                if (listHoaDon.Count != 0)
                {
                    //thực hiện việc tạo mới hóa đơn
                    string maDaiLy = cbMaDL.Text;
                    string ngayTao = dtpNgayTao.Text;
                    List<ChiTietHoaDonViewModel> listVM = new List<ChiTietHoaDonViewModel>();
                    foreach (var item in listHoaDon)
                    {
                        ChiTietHoaDonViewModel cthdvm = new ChiTietHoaDonViewModel
                        {
                            maSach = item.Key,
                            soLuong = item.Value
                        };
                        listVM.Add(cthdvm);
                    }
                    HoaDonViewModel vm = new HoaDonViewModel
                    {
                        maDaiLy = maDaiLy,
                        ngayLapHD = Convert.ToDateTime(ngayTao)
                    };
                    if (dao.InsertNewHoaDon(vm, listVM))
                    {
                        MessageBox.Show("Tạo mới thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmChiTietHoaDon cthd = new frmChiTietHoaDon();
                        cthd.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Tạo mới không thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn sách", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Không thể tạo mới hóa đơn này!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridSach_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = dataGridSach.CurrentCell.RowIndex;
                if (!regex.IsMatch(dataGridSach.Rows[index].Cells[1].Value.ToString()))
                {
                    MessageBox.Show("Số lượng phải là chữ số!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                //do nothing
            }
        }

        private void dataGridSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = dataGridSach.CurrentCell.RowIndex;
                dataGridSach.Rows[index].Cells[2].ReadOnly = true;
                dataGridSach.Rows[index].Cells[3].ReadOnly = true;
                dataGridSach.Rows[index].Cells[4].ReadOnly = true;
                dataGridSach.Rows[index].Cells[5].ReadOnly = true;
                dataGridSach.Rows[index].Cells[6].ReadOnly = true;
                dataGridSach.Rows[index].Cells[7].ReadOnly = true;
                dataGridSach.Rows[index].Cells[8].ReadOnly = true;
            }
            catch
            {
                //do nothing
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            dataGridSach.DataSource = sachDao.FindSachByLikeTenSachOrTenTG(txtTim.Text.Trim());
        }
    }
}
