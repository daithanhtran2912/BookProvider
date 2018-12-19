using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThanhTDSE62847_Final_Project.DAO
{
    public class DaiLyDAO
    {
        QuanLySachDBEntities db = new QuanLySachDBEntities();

        public List<DaiLyGetAllViewModel> GetAllDaiLy()
        {
            List<tblDaiLy> listDaiLy = null;
            listDaiLy = db.tblDaiLies.Where(n => n.cungCap == true).ToList();
            List<DaiLyGetAllViewModel> listViewModel = new List<DaiLyGetAllViewModel>();
            foreach (var tmp in listDaiLy)
            {
                DaiLyGetAllViewModel vm = new DaiLyGetAllViewModel
                {
                    diaChi = tmp.diaChi,
                    dienThoai = tmp.dienThoai,
                    maDaiLy = tmp.maDaiLy,
                    tenChuDaiLy = tmp.tenChuDaiLy,
                    tenDaiLy = tmp.tenDaiLy,
                };
                listViewModel.Add(vm);
            }
            return listViewModel;
        }

        public bool InsertNewDaiLy(DaiLyViewModel dto)
        {
            try
            {
                tblDaiLy dl = new tblDaiLy
                {
                    maDaiLy = dto.maDaiLy,
                    tenDaiLy = dto.tenDaiLy,
                    tenChuDaiLy = dto.tenChuDaiLy,
                    diaChi = dto.diaChi,
                    dienThoai = dto.dienThoai,
                    cungCap = true
                };
                db.tblDaiLies.Add(dl);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public tblDaiLy FindDaiLy(string maDL, bool trangThai)
        {
            tblDaiLy dto = db.tblDaiLies.FirstOrDefault(n => n.maDaiLy.Equals(maDL) && n.cungCap == trangThai);
            return dto;
        }

        public bool RemoveDaiLy(string maDL)
        {
            try
            {
                tblDaiLy dl = FindDaiLy(maDL, true);
                dl.cungCap = false;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public bool UpdateDaiLy(tblDaiLy dto, string maDL)
        {
            try
            {
                tblDaiLy dl = FindDaiLy(maDL, true);
                dl.tenDaiLy = dto.tenDaiLy;
                dl.tenChuDaiLy = dto.tenChuDaiLy;
                dl.diaChi = dto.diaChi;
                dl.dienThoai = dto.dienThoai;
                dl.cungCap = dto.cungCap;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool CheckDupplicateID(string maDL)
        {
            tblDaiLy dto = db.tblDaiLies.FirstOrDefault(n => n.maDaiLy.Equals(maDL));
            if (dto == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool CheckRelation(string maDL)
        {
            //Nếu có ràng buộc thì trả về false, ngược lại trả về true
            List<tblHoaDon> list = db.tblHoaDons.Where(n => n.maDaiLy.Equals(maDL)).ToList();
            return list.Count() > 0 ? false : true;
        }


        //Tìm các đại lý còn hợp tác
        public List<DaiLyGetAllViewModel> FindDaiLyLikeByTenOrTenCDL(string search)
        {
            List<tblDaiLy> listDaiLy = null;
            listDaiLy = db.tblDaiLies.Where(n => n.cungCap == true && (n.tenDaiLy.Contains(search) || n.tenChuDaiLy.Contains(search))).ToList();
            List<DaiLyGetAllViewModel> listViewModel = new List<DaiLyGetAllViewModel>();
            foreach (var tmp in listDaiLy)
            {
                DaiLyGetAllViewModel vm = new DaiLyGetAllViewModel
                {
                    diaChi = tmp.diaChi,
                    dienThoai = tmp.dienThoai,
                    maDaiLy = tmp.maDaiLy,
                    tenChuDaiLy = tmp.tenChuDaiLy,
                    tenDaiLy = tmp.tenDaiLy,
                };
                listViewModel.Add(vm);
            }
            return listViewModel;
        }

        //dùng để quản lý việc cung cấp của các Đại lý
        public List<DaiLyGetAllViewModel> GetUnavailableDaiLy()
        {
            List<DaiLyGetAllViewModel> listVM = new List<DaiLyGetAllViewModel>();
            List<tblDaiLy> listDTO = db.tblDaiLies.Where(n => n.cungCap == false).ToList();
            foreach (var dto in listDTO)
            {
                DaiLyGetAllViewModel vm = new DaiLyGetAllViewModel
                {
                    maDaiLy = dto.maDaiLy,
                    tenDaiLy = dto.tenDaiLy,
                    tenChuDaiLy = dto.tenChuDaiLy,
                    diaChi = dto.diaChi,
                    dienThoai = dto.dienThoai
                    //cungCap = dto.cungCap
                };
                listVM.Add(vm);
            }
            return listVM;
        }

        public bool UpdateCungCap(string maDaiLy)
        {
            try
            {
                tblDaiLy dl = FindDaiLy(maDaiLy, false);
                dl.cungCap = true;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Tìm các đại lý không còn hợp tác
        public List<DaiLyGetAllViewModel> FindDisabledDaiLyLikeByTenOrTenCDL(string search)
        {
            List<tblDaiLy> listDaiLy = null;
            listDaiLy = db.tblDaiLies.Where(n => n.cungCap == false && (n.tenDaiLy.Contains(search) || n.tenChuDaiLy.Contains(search))).ToList();
            List<DaiLyGetAllViewModel> listViewModel = new List<DaiLyGetAllViewModel>();
            foreach (var tmp in listDaiLy)
            {
                DaiLyGetAllViewModel vm = new DaiLyGetAllViewModel
                {
                    diaChi = tmp.diaChi,
                    dienThoai = tmp.dienThoai,
                    maDaiLy = tmp.maDaiLy,
                    tenChuDaiLy = tmp.tenChuDaiLy,
                    tenDaiLy = tmp.tenDaiLy,
                };
                listViewModel.Add(vm);
            }
            return listViewModel;
        }
    }

    public class DaiLyViewModel
    {
        public string maDaiLy { get; set; }
        public string tenDaiLy { get; set; }
        public string tenChuDaiLy { get; set; }
        public string diaChi { get; set; }
        public string dienThoai { get; set; }
        public bool cungCap { get; set; }
    }

    public class DaiLyGetAllViewModel
    {
        public string maDaiLy { get; set; }
        public string tenDaiLy { get; set; }
        public string tenChuDaiLy { get; set; }
        public string diaChi { get; set; }
        public string dienThoai { get; set; }
    }
}
