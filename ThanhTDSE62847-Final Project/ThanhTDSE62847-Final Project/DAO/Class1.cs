using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThanhTDSE62847_Final_Project.DAO;

namespace ThanhTDSE62847_Final_Project.DTO
{
    public class Class1
    {
        QuanLySachDBEntities db = new QuanLySachDBEntities();
        public void sth()
        {

            // SELECT * FROM tblDaiLy
            //var dtos = db.tblDaiLies.ToList();

            //var dtos2 = db.tblDaiLies.Where(n => n.maDaiLy.Equals("234")).ToList();

            //tblDaiLy dto = db.tblDaiLies.FirstOrDefault(n => n.dienThoai.Equals("22342")); //find

            //db.tblDaiLies.Remove(dto); //remove
            //dto.diaChi = "234234"; //update
            //db.tblDaiLies.Add(dto); //insert

            //db.tblChiTietHoaDons.Where(n => n.tblHoaDon.tblDaiLy.) //truy van khoa ngoai

            //db.SaveChanges(); //save to database

            //var a = db.tblChiTietHoaDons.GroupBy(n => n.soHoaDon);
            //foreach (var item in a)
            //{
            //    Console.WriteLine(item.Key);
            //    foreach (var it in item)
            //    {
            //        Console.Write(it.maSach + " - ");
            //        Console.WriteLine();
            //    }
            //}
        }
        
    }
}
