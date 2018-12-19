using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ThanhTDSE62847_Final_Project.DAO;

namespace ThanhTDSE62847_Final_Project
{
    public partial class frmNhaXB : Form
    {
        private bool addNew = false;
        private NhaXBDAO dao = new NhaXBDAO();
        public frmNhaXB()
        {
            InitializeComponent();
            LoadData();
            SetTextBoxStatus(false);
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void ClearTextBox()
        {
            txtMaNXB.Clear();
            txtTenNXB.Clear();
            txtDiaChi.Clear();
            txtDienThoai.Clear();
        }

        private void SetTextBoxStatus(bool status)
        {
            txtMaNXB.Enabled = status;
            txtTenNXB.Enabled = status;
            txtDiaChi.Enabled = status;
            txtDienThoai.Enabled = status
;
        }

        private bool CheckValid(string ID)
        {
            Regex numRegex = new Regex("^[0-9]*$");
            Regex IDRegex = new Regex("^([N][X][B]){1}([0-9]+)$");
            if (txtMaNXB.Text.Trim().Equals(""))
            {
                MessageBox.Show("Mã nhà xuất bản không được rỗng!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (!IDRegex.IsMatch(txtMaNXB.Text.Trim()))
            {
                MessageBox.Show("Sai định dạng - Mã nhà xuất bản phải bắt đầu bằng NXB (VD: NXB123)!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (dao.CheckDupplicateID(ID))
            {
                MessageBox.Show("Mã nhà xuất bản đã tồn tại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtMaNXB.Text.Trim().Length > 10)
            {
                MessageBox.Show("Mã nhà xuất bản không dài hơn 10 ký tự!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtTenNXB.Text.Trim().Equals(""))
            {
                MessageBox.Show("Tên nhà xuất bản không được rỗng!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtTenNXB.Text.Trim().Length > 100)
            {
                MessageBox.Show("Tên nhà xuất bản không dài hơn 100 ký tự!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtDiaChi.Text.Trim().Equals(""))
            {
                MessageBox.Show("Địa chỉ không được rỗng!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtDiaChi.Text.Trim().Length > 100)
            {
                MessageBox.Show("Địa chỉ không dài hơn 100 ký tự!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtDienThoai.Text.Trim().Equals(""))
            {
                MessageBox.Show("Số điện thoại không được rỗng!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (!numRegex.IsMatch(txtDienThoai.Text.Trim()))
            {
                MessageBox.Show("Số điện thoại phải là chữ số!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtDienThoai.Text.Trim().Length > 11)
            {
                MessageBox.Show("Số điện thoại không dài hơn 11 ký tự!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void LoadData()
        {
            dataGridNXB.DataSource = dao.GetAllNhaXB();
        }

        private void btnThem_Click(object sender, System.EventArgs e)
        {
            if (!addNew)
            {
                ClearTextBox();
                SetTextBoxStatus(true);
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
                txtMaNXB.Focus();
                addNew = true;
            }
            else
            {
                if (CheckValid(txtMaNXB.Text.Trim()))
                {
                    string maNXB = txtMaNXB.Text.Trim();
                    string tenNXB = txtTenNXB.Text.Trim();
                    string diaChi = txtDiaChi.Text.Trim();
                    string dienThoai = txtDienThoai.Text.Trim();
                    NhaXBViewModel vm = new NhaXBViewModel
                    {
                        maNhaXB = maNXB,
                        tenNhaXB = tenNXB,
                        diaChi = diaChi,
                        dienThoai = dienThoai
                    };
                    if (dao.InsertNewNhaXB(vm))
                    {
                        ClearTextBox();
                        SetTextBoxStatus(false);
                        btnSua.Enabled = false;
                        btnXoa.Enabled = false;
                        LoadData();
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

        private void dataGridNXB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridNXB.CurrentCell.RowIndex;
            txtMaNXB.Text = dataGridNXB.Rows[index].Cells[0].Value.ToString();
            txtTenNXB.Text = dataGridNXB.Rows[index].Cells[1].Value.ToString();
            txtDiaChi.Text = dataGridNXB.Rows[index].Cells[2].Value.ToString();
            txtDienThoai.Text = dataGridNXB.Rows[index].Cells[3].Value.ToString();
            SetTextBoxStatus(true);
            txtMaNXB.Enabled = false;
            addNew = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnSua_Click(object sender, System.EventArgs e)
        {
            int index = dataGridNXB.CurrentCell.RowIndex;
            string maNXB = dataGridNXB.Rows[index].Cells[0].Value.ToString();
            string tenNXB = txtTenNXB.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            string dienThoai = txtDienThoai.Text.Trim();
            try
            {
                if (CheckValid(""))
                {
                    tblNhaXB nxb = new tblNhaXB
                    {
                        maNhaXB = maNXB,
                        tenNhaXB = tenNXB,
                        diaChi = diaChi,
                        dienThoai = dienThoai,
                        cungCap = true
                    };
                    if (dao.UpdateNhaXB(nxb, maNXB))
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

        private void btnXoa_Click(object sender, System.EventArgs e)
        {
            int index = dataGridNXB.CurrentCell.RowIndex;
            string maNXB = dataGridNXB.Rows[index].Cells[0].Value.ToString();
            try
            {
                if (dao.CheckRelation(maNXB))
                {
                    if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (dao.RemoveNhaXB(maNXB))
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
                else
                {
                    if (MessageBox.Show("Vẫn còn dữ liệu liên quan đến nhà xuất bản này. Việc thực hiện xóa nhà xuất bản có thể xóa các dữ liệu liên quan đến nhà xuất bản. Bạn có muốn xóa?", "Cảnh báo!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        List<string> listMaSach = dao.getAllSachFromNXB(maNXB);
                        if (dao.RemoveSachWhenNXBIsDisable(listMaSach) && dao.RemoveNhaXB(maNXB))
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
            }
            catch
            {
                MessageBox.Show("Xóa không thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnTim_Click(object sender, System.EventArgs e)
        {
            dataGridNXB.DataSource = dao.FindNXBLikeByName(txtTim.Text.Trim());
        }
    }
}
