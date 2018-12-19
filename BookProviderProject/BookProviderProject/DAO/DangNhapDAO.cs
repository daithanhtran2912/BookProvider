using System.Linq;

namespace ThanhTDSE62847_Final_Project.DAO
{
    public class DangNhapDAO
    {
        QuanLySachDBEntities db = new QuanLySachDBEntities();

        public bool IsAdmin(string username, string password)
        {
            bool isAdmin = false;
            
            isAdmin = db.tblDangNhaps.FirstOrDefault(n => n.username.Equals(username) && n.password.Equals(password)).isAdmin;
            if (isAdmin.Equals("True") || isAdmin.Equals("true"))
            {
                return isAdmin;
            }
            else
            {
                return isAdmin;
            }
        }

    }
}
