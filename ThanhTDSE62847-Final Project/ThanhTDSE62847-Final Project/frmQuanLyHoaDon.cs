using ThanhTDSE62847_Final_Project.DAO;
using System.Windows.Forms;

namespace ThanhTDSE62847_Final_Project
{
    public partial class frmQuanLyHoaDon : Form
    {
        private HoaDonDAO dao = new HoaDonDAO();
        public frmQuanLyHoaDon()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            dataGridDSHD.DataSource = dao.GetAllDisabledHoaDon();
        }
    }
}
