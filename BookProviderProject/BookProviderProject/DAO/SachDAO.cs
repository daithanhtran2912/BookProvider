using System;
using System.Collections.Generic;
using System.Linq;

namespace ThanhTDSE62847_Final_Project.DAO
{
    public class SachDAO
    {

        QuanLySachDBEntities db = new QuanLySachDBEntities();

        public List<SachGetAllViewModel> GetAllSach()
        {
            List<tblSach> listSach = new List<tblSach>();
            listSach = db.tblSaches.Where(n => n.cungCap == true && n.tblNhaXB.cungCap == true).ToList();
            List<SachGetAllViewModel> listViewModel = new List<SachGetAllViewModel>();
            foreach (var dto in listSach)
            {
                SachGetAllViewModel vm = new SachGetAllViewModel
                {
                    maSach = dto.maSach,
                    maNhaXB = dto.maNhaXB,
                    tenSach = dto.tenSach,
                    tenTacGia = dto.tenTacGia,
                    giaBia = dto.giaBia,
                    giaBanChoDaiLy = dto.giaBanChoDaiLy,
                    trang = dto.trang
                    //cungCap = dto.cungCap
                };
                listViewModel.Add(vm);
            }
            listSach.Clear();
            return listViewModel;
        }

        public List<string> GetAllMaNXB()
        {
            List<tblNhaXB> listSach = db.tblNhaXBs.Where(n => n.cungCap == true).ToList();
            List<string> listMaNXB = new List<string>();
            foreach (var dto in listSach)
            {
                string maNXB = dto.maNhaXB;
                listMaNXB.Add(maNXB);
            }
            return listMaNXB;
        }

        public bool InsertNewSach(SachViewModel dto)
        {
            try
            {
                tblSach sach = new tblSach
                {
                    maSach = dto.maSach,
                    tenSach = dto.tenSach,
                    tenTacGia = dto.tenTacGia,
                    maNhaXB = dto.maNhaXB,
                    giaBia = dto.giaBia,
                    giaBanChoDaiLy = dto.giaBanChoDaiLy,
                    trang = dto.trang,
                    cungCap = true
                };
                db.tblSaches.Add(sach);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public tblSach FindSach(string maSach)
        {
            tblSach dto = db.tblSaches.FirstOrDefault(n => n.maSach.Equals(maSach) && n.cungCap == true);
            return dto;
        }

        public List<SachGetAllViewModel> FindSachByLikeTenSachOrTenTG(string searchString)
        {
            List<tblSach> listSach = db.tblSaches.Where(n => ((n.tenSach.Contains(searchString) || n.tenTacGia.Contains(searchString) || n.maNhaXB.Contains(searchString)) && n.cungCap == true) && n.tblNhaXB.cungCap == true).ToList();
            List<SachGetAllViewModel> listViewModel = new List<SachGetAllViewModel>();
            foreach (var dto in listSach)
            {
                SachGetAllViewModel vm = new SachGetAllViewModel
                {
                    maSach = dto.maSach,
                    maNhaXB = dto.maNhaXB,
                    tenSach = dto.tenSach,
                    tenTacGia = dto.tenTacGia,
                    giaBia = dto.giaBia,
                    giaBanChoDaiLy = dto.giaBanChoDaiLy,
                    trang = dto.trang
                    //cungCap = dto.cungCap
                };
                listViewModel.Add(vm);
            }
            return listViewModel;
        }

        public bool UpdateSach(string maSach, tblSach dto)
        {
            try
            {
                tblSach sach = FindSach(maSach);
                sach.maSach = dto.maSach;
                sach.tenSach = dto.tenSach;
                sach.tenTacGia = dto.tenTacGia;
                sach.giaBia = dto.giaBia;
                sach.giaBanChoDaiLy = dto.giaBanChoDaiLy;
                sach.maNhaXB = dto.maNhaXB;
                sach.trang = dto.trang;
                sach.cungCap = dto.cungCap;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool RemoveSach(string maSach)
        {
            try
            {
                tblSach sach = FindSach(maSach);
                if (sach != null)
                {
                    sach.cungCap = false;
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public bool CheckDupplicateID(string ID)
        {
            tblSach dto = db.tblSaches.FirstOrDefault(n => n.maSach.Equals(ID));
            if (dto == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //public bool CheckRelation(string maSach)
        //{
        //    //return false nếu có sự ràng buộc
        //   List<tblChiTietHoaDon> lst = db.tblChiTietHoaDons.Where(n => n.maSach.Equals(maSach)).ToList();
        //    return lst.Count() > 0 ? false : true;
        //}

        //lấy hết các tựa sách đã bị xóa
        public List<SachGetAllViewModel> GetAllSachDisabled()
        {
            List<tblSach> listSach = new List<tblSach>();
            listSach = db.tblSaches.Where(n => n.cungCap == false && n.tblNhaXB.cungCap == true).ToList();
            List<SachGetAllViewModel> listViewModel = new List<SachGetAllViewModel>();
            foreach (var dto in listSach)
            {
                SachGetAllViewModel vm = new SachGetAllViewModel
                {
                    maSach = dto.maSach,
                    maNhaXB = dto.maNhaXB,
                    tenSach = dto.tenSach,
                    tenTacGia = dto.tenTacGia,
                    giaBia = dto.giaBia,
                    giaBanChoDaiLy = dto.giaBanChoDaiLy,
                    trang = dto.trang
                    //cungCap = dto.cungCap
                };
                listViewModel.Add(vm);
            }
            listSach.Clear();
            return listViewModel;
        }


        //thay đổi trạng thái cungCap của sách
        public bool UpdateCungCap(string maSach)
        {
            try
            {
                tblSach sach = db.tblSaches.FirstOrDefault(n => n.maSach.Equals(maSach) && n.cungCap == false);
                sach.cungCap = true;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }


        //tìm tựa sách đã bị xóa (cungCap = false) theo tên sách, tên tác giả, mã nhà xb 
        //với điều kiện nhà xuất bản chưa bị xóa
        public List<SachGetAllViewModel> FindSachDisabledByLikeTenSachOrTenTG(string searchString)
        {
            List<tblSach> listSach = db.tblSaches.Where(n => ((n.tenSach.Contains(searchString) || n.tenTacGia.Contains(searchString) || n.maNhaXB.Contains(searchString)) && n.cungCap == false) && n.tblNhaXB.cungCap == true).ToList();
            List<SachGetAllViewModel> listViewModel = new List<SachGetAllViewModel>();
            foreach (var dto in listSach)
            {
                SachGetAllViewModel vm = new SachGetAllViewModel
                {
                    maSach = dto.maSach,
                    maNhaXB = dto.maNhaXB,
                    tenSach = dto.tenSach,
                    tenTacGia = dto.tenTacGia,
                    giaBia = dto.giaBia,
                    giaBanChoDaiLy = dto.giaBanChoDaiLy,
                    trang = dto.trang
                    //cungCap = dto.cungCap
                };
                listViewModel.Add(vm);
            }
            return listViewModel;
        }

    }

    public class SachViewModel
    {
        public string maSach { get; set; }
        public string tenSach { get; set; }
        public string tenTacGia { get; set; }
        public string giaBia { get; set; }
        public string giaBanChoDaiLy { get; set; }
        public string maNhaXB { get; set; }
        public Nullable<int> trang { get; set; }
        public bool cungCap { get; set; }
    }

    public class SachGetAllViewModel
    {
        public string maSach { get; set; }
        public string tenSach { get; set; }
        public string tenTacGia { get; set; }
        public string giaBia { get; set; }
        public string giaBanChoDaiLy { get; set; }
        public string maNhaXB { get; set; }
        public Nullable<int> trang { get; set; }
    }
}
