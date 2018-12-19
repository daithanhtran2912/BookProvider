using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ThanhTDSE62847_Final_Project.DAO;

namespace ThanhTDSE62847_Final_Project
{
    public partial class frmSach : Form
    {
        private SachDAO dao = new SachDAO();
        private bool addNew = false;

        public frmSach()
        {
            InitializeComponent();
            LoadData();
            LoadMaNXB();
            SetTextBoxStatus(false);
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
        }

        private void ClearTextBox()
        {
            txtMaSach.Clear();
            txtTenSach.Clear();
            txtTenTG.Clear();
            txtTrang.Clear();
            txtGiaBia.Clear();
            txtGiaBanChoDL.Clear();
            cbMaNXB.SelectedIndex = -1;
        }
        private void SetTextBoxStatus(bool status)
        {
            txtMaSach.Enabled = status;
            txtTenSach.Enabled = status;
            txtTenTG.Enabled = status;
            txtTrang.Enabled = status;
            txtGiaBia.Enabled = status;
            txtGiaBanChoDL.Enabled = status;
            cbMaNXB.Enabled = status;
        }

        private bool CheckValidate(string ID)
        {
            Regex numRegex = new Regex("^[0-9]*$");
            Regex IDRegex = new Regex("^([M][S]){1}([0-9]+)$");
            if (txtMaSach.Text.Trim().Equals(""))
            {
                MessageBox.Show("Mã sách không được rỗng!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (!IDRegex.IsMatch(txtMaSach.Text.Trim()))
            {
                MessageBox.Show("Mã sách phải bắt đầu bằng MS (VD: MS123)!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (dao.CheckDupplicateID(ID))
            {
                MessageBox.Show("Mã sách này đã tồn tại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtMaSach.Text.Trim().Length > 10)
            {
                MessageBox.Show("Mã sách không lớn hơn 10 ký tự!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtTenSach.Text.Trim().Equals(""))
            {
                MessageBox.Show("Tên sách không được rỗng!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if(txtTenSach.Text.Trim().Length > 100)
            {
                MessageBox.Show("Tên sách không lớn hơn 100 ký tự!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtTenTG.Text.Trim().Equals(""))
            {
                MessageBox.Show("Tên tác giả không được rỗng!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtTenTG.Text.Trim().Length > 50)
            {
                MessageBox.Show("Tên tác giả không lớn hơn 50 ký tự!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtGiaBia.Text.Trim().Equals(""))
            {
                MessageBox.Show("Giá bìa không được rỗng!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (!numRegex.IsMatch(txtGiaBia.Text.Trim()))
            {
                MessageBox.Show("Giá bìa phải là chữ số!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtGiaBia.Text.Trim().Length > 10)
            {
                MessageBox.Show("Giá bìa không lớn hơn 10 ký tự!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtGiaBanChoDL.Text.Trim().Equals(""))
            {
                MessageBox.Show("Giá bán cho đại lý không được rỗng!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (!numRegex.IsMatch(txtGiaBanChoDL.Text.Trim()))
            {
                MessageBox.Show("Giá bán cho đại lý phải là chữ số!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtGiaBanChoDL.Text.Trim().Length > 10)
            {
                MessageBox.Show("Giá bán cho đại lý không lớn hơn 10 ký tự!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtTrang.Text.Trim().Equals(""))
            {
                MessageBox.Show("Số trang không được rỗng!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (!numRegex.IsMatch(txtTrang.Text.Trim()))
            {
                MessageBox.Show("Số trang phải là chữ số!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (cbMaNXB.SelectedIndex == -1)
            {
                MessageBox.Show("Mã nhà xuất bản không được để trống!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (int.Parse(txtGiaBia.Text.Trim()) < int.Parse(txtGiaBanChoDL.Text.Trim()))
            {
                MessageBox.Show("Giá bìa không được lớn hơn giá bán cho đại lý!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void LoadData()
        {
            dataGridKhoSach.DataSource = dao.GetAllSach();
        }

        private void LoadMaNXB()
        {
            cbMaNXB.DataSource = dao.GetAllMaNXB();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!addNew)
            {
                ClearTextBox();
                SetTextBoxStatus(true);
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                addNew = true;
            }
            else
            {
                if (CheckValidate(txtMaSach.Text.Trim()))
                {
                    string maSach = txtMaSach.Text.Trim();
                    string tenSach = txtTenSach.Text.Trim();
                    string tenTG = txtTenTG.Text.Trim();
                    string giaBia = txtGiaBia.Text.Trim();
                    string giaBanDL = txtGiaBanChoDL.Text.Trim();
                    string trang = txtTrang.Text.Trim();
                    string maNXB = cbMaNXB.Text.Trim();
                    SachViewModel sach = new SachViewModel
                    {
                        maSach = maSach,
                        tenSach = tenSach,
                        tenTacGia = tenTG,
                        giaBia = giaBia,
                        giaBanChoDaiLy = giaBanDL,
                        trang = int.Parse(trang),
                        maNhaXB = maNXB
                    };
                    if (dao.InsertNewSach(sach))
                    {
                        ClearTextBox();
                        SetTextBoxStatus(false);
                        btnSua.Enabled = false;
                        btnXoa.Enabled = false;
                        LoadData();
                        LoadMaNXB();
                        MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        addNew = false;
                    }
                    else
                    {
                        MessageBox.Show("Thêm mới thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        addNew = true;
                    }
                }
                else
                {
                    addNew = true;
                }
            }
        }



        private void btnTim_Click(object sender, EventArgs e)
        {
            dataGridKhoSach.DataSource = dao.FindSachByLikeTenSachOrTenTG(txtTim.Text);
            ClearTextBox();
            SetTextBoxStatus(false);
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            addNew = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dataGridKhoSach.CurrentCell.RowIndex;
                string maSach = dataGridKhoSach.Rows[index].Cells[0].Value.ToString();
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (dao.RemoveSach(maSach))
                    {
                        LoadData();
                        ClearTextBox();
                        SetTextBoxStatus(false);
                        btnXoa.Enabled = false;
                        btnSua.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Xóa không thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
                cbMaNXB.Text = dataGridKhoSach.Rows[index].Cells[5].Value.ToString();
                txtTrang.Text = dataGridKhoSach.Rows[index].Cells[6].Value.ToString();
                SetTextBoxStatus(true);
                txtMaSach.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                addNew = false;
            }
            catch
            {
                addNew = false;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dataGridKhoSach.CurrentCell.RowIndex;
                string maSach = dataGridKhoSach.Rows[index].Cells[0].Value.ToString();
                string tenSach = txtTenSach.Text.Trim();
                string tenTG = txtTenTG.Text.Trim();
                string giaBia = txtGiaBia.Text.Trim();
                string giaBanDL = txtGiaBanChoDL.Text.Trim();
                string trang = txtTrang.Text.Trim();
                string maNXB = cbMaNXB.Text.Trim();
                if (CheckValidate(""))
                {
                    tblSach sach = new tblSach
                    {
                        maSach = maSach,
                        tenSach = tenSach,
                        tenTacGia = tenTG,
                        giaBia = giaBia,
                        giaBanChoDaiLy = giaBanDL,
                        trang = int.Parse(trang),
                        maNhaXB = maNXB,
                        cungCap = true
                    };
                    if (dao.UpdateSach(maSach, sach))
                    {
                        LoadData();
                        ClearTextBox();
                        SetTextBoxStatus(false);
                        addNew = false;
                        btnSua.Enabled = false;
                        btnXoa.Enabled = false;
                        MessageBox.Show("Đã cập nhật thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật không thành công!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Cập nhật không thành công!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
