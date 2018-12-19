using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ThanhTDSE62847_Final_Project.DAO;

namespace ThanhTDSE62847_Final_Project
{
    public partial class frmDaiLy : Form
    {

        bool addNew = false;
        DaiLyDAO dao = new DaiLyDAO();

        public frmDaiLy()
        {
            InitializeComponent();
            LoadData();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            SetTextBoxStatus(false);
        }

        private void ClearTextBox()
        {
            txtMaDL.Text = "";
            txtTenDL.Text = "";
            txtTenCDL.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
        }

        private void SetTextBoxStatus(bool status)
        {
            txtMaDL.Enabled = status;
            txtTenDL.Enabled = status;
            txtTenCDL.Enabled = status;
            txtDiaChi.Enabled = status;
            txtDienThoai.Enabled = status;
        }

        private bool CheckValid(string ID)
        {
            Regex numRegex = new Regex("^[0-9]*$");
            Regex idRegex = new Regex("^([D][L]){1}([0-9]+)$");
            if (txtMaDL.Text.Trim().Equals(""))
            {
                MessageBox.Show("Mã đại lý không được rỗng!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (!idRegex.IsMatch(txtMaDL.Text.Trim()))
            {
                MessageBox.Show("Sai định dạng - Mã đại lý phải bắt đầu bằng DL (VD: DL123)!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (dao.CheckDupplicateID(ID))
            {
                MessageBox.Show("Mã đại lý đã tồn tại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtMaDL.Text.Trim().Length > 10)
            {
                MessageBox.Show("Mã đại lý không dài hơn 10 ký tự!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtTenDL.Text.Trim().Equals(""))
            {
                MessageBox.Show("Tên đại lý không được rỗng!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtTenDL.Text.Trim().Length > 50)
            {
                MessageBox.Show("Tên đại lý không dài hơn 50 ký tự!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtTenCDL.Text.Trim().Equals(""))
            {
                MessageBox.Show("Tên chủ đại lý không được rỗng!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtTenCDL.Text.Trim().Length > 50)
            {
                MessageBox.Show("Tên chủ đại lý không dài hơn 50 ký tự!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtDiaChi.Text.Trim().Equals(""))
            {
                MessageBox.Show("Địa chỉ không được rỗng!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtDiaChi.Text.Trim().Length > 50)
            {
                MessageBox.Show("Địa chỉ không dài hơn 50 ký tự!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtDienThoai.Text.Trim().Equals(""))
            {
                MessageBox.Show("Số điện thoại không được rỗng!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtDienThoai.Text.Trim().Length > 11)
            {
                MessageBox.Show("Số điện thoại không dài hơn 11 ký tự!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (!numRegex.IsMatch(txtDienThoai.Text.Trim()))
            {
                MessageBox.Show("Số điện thoại phải là chữ số!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void LoadData()
        {
            dtGDaiLy.DataSource = dao.GetAllDaiLy();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (!addNew)
            {
                SetTextBoxStatus(true);
                ClearTextBox();
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                txtMaDL.Focus();
                addNew = true;
            }
            else
            {
                if (CheckValid(txtMaDL.Text.Trim()))
                {
                    string maDL = txtMaDL.Text.Trim();
                    string tenDL = txtTenDL.Text.Trim();
                    string tenChuDL = txtTenCDL.Text.Trim();
                    string diaChi = txtDiaChi.Text.Trim();
                    string dienThoai = txtDienThoai.Text.Trim();
                    DaiLyViewModel viewModel = new DaiLyViewModel
                    {
                        maDaiLy = maDL,
                        tenDaiLy = tenDL,
                        tenChuDaiLy = tenChuDL,
                        diaChi = diaChi,
                        dienThoai = dienThoai
                    };
                    if (dao.InsertNewDaiLy(viewModel))
                    {
                        LoadData();
                        MessageBox.Show("Thêm mới đại lý thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SetTextBoxStatus(false);
                        ClearTextBox();
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
                SetTextBoxStatus(true);
                txtMaDL.Enabled = false;
                addNew = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
            catch
            {

            }
        }


        //Thiếu kiểm tra ràng buộc khóa ngoại 
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    int index = dtGDaiLy.CurrentCell.RowIndex;
                    string maDL = dtGDaiLy.Rows[index].Cells[0].Value.ToString();
                    if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (dao.RemoveDaiLy(maDL))
                        {
                            LoadData();
                            ClearTextBox();
                            SetTextBoxStatus(false);
                            btnXoa.Enabled = false;
                            btnSua.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Xóa không thành công!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Xóa không thành công!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dtGDaiLy.CurrentCell.RowIndex;
                string maDL = dtGDaiLy.Rows[index].Cells[0].Value.ToString();
                string tenDL = txtTenDL.Text.Trim();
                string tenChuDL = txtTenCDL.Text.Trim();
                string diaChi = txtDiaChi.Text.Trim();
                string dienThoai = txtDienThoai.Text.Trim();
                try
                {
                    if (CheckValid(""))
                    {
                        tblDaiLy dl = new tblDaiLy
                        {
                            maDaiLy = maDL,
                            tenDaiLy = tenDL,
                            tenChuDaiLy = tenChuDL,
                            diaChi = diaChi,
                            dienThoai = dienThoai,
                            cungCap = true
                        };
                        if (dao.UpdateDaiLy(dl, maDL))
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
            catch
            {

            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            dtGDaiLy.DataSource = dao.FindDaiLyLikeByTenOrTenCDL(txtTim.Text.Trim());
        }
    }
}
