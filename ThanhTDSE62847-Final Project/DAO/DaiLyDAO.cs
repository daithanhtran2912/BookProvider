using DTO;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DAO
{
    public class DaiLyDAO
    {
        public DaiLyDAO()
        {

        }
       

        public DataTable getAllDaiLy()
        {
            string connectString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            DataTable listDaiLy = new DataTable();
            listDaiLy.Columns.Add("maDaiLy");
            listDaiLy.Columns.Add("tenDaiLy");
            listDaiLy.Columns.Add("tenChuDaiLy");
            listDaiLy.Columns.Add("diaChi");
            listDaiLy.Columns.Add("dienThoai");
            listDaiLy.Clear();

            using (SqlConnection conn =
            new SqlConnection(connectString))
            {
                conn.Open();
                string sql = "select maDaiLy, tenDaiLy, tenChuDaiLy, diaChi, dienThoai from tblDaiLy";
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    DataRow data = listDaiLy.NewRow();
                    data["maDaiLy"] = reader.GetString(0);
                    data["tenDaiLy"] = reader.GetString(1);
                    data["tenChuDaiLy"] = reader.GetString(2);
                    data["diaChi"] = reader.GetString(3);
                    data["dienThoai"] = reader.GetString(4);
                    listDaiLy.Rows.Add(data);
                }
                reader.Close();
            }
            return listDaiLy;
        }


    }
}
