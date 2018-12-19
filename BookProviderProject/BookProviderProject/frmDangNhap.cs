using System;
using System.Windows.Forms;
using ThanhTDSE62847_Final_Project.DAO;

namespace ThanhTDSE62847_Final_Project
{
    public partial class frmDangNhap : Form
    {
        private DangNhapDAO dao = new DangNhapDAO();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckValid())
                {
                    if (dao.IsAdmin(txtUsername.Text.Trim(), txtPassword.Text.Trim()))
                    {
                        frmQuanLyCungCapSach tmp = new frmQuanLyCungCapSach();
                        this.Hide();
                        tmp.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool CheckValid()
        {
            if (txtUsername.Text.Trim().Equals(""))
            {
                MessageBox.Show("Tên đăng nhập không được rỗng!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtUsername.Text.Trim().Length > 30)
            {
                MessageBox.Show("Tên đăng nhập không dài hơn 30 ký tự!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtPassword.Text.Trim().Equals(""))
            {
                MessageBox.Show("Mật khẩu không được rỗng!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtPassword.Text.Trim().Length > 30)
            {
                MessageBox.Show("Mật khẩu không dài hơn 30 ký tự!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void frmDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
