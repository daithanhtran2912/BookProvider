using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThanhTDSE62847_Final_Project.DAO
{
    public class HoaDonDAO
    {
        QuanLySachDBEntities db = new QuanLySachDBEntities();

        public List<HoaDonGetAllViewModel> GetAllHoaDon()
        {
            List<HoaDonGetAllViewModel> listVM = new List<HoaDonGetAllViewModel>();
            List<tblHoaDon> listHoaDon = db.tblHoaDons.Where(n => n.hieuLuc == true).ToList();
            foreach (var dto in listHoaDon)
            {
                HoaDonGetAllViewModel vm = new HoaDonGetAllViewModel
                {
                    maDaiLy = dto.maDaiLy,
                    ngayLapHD = dto.ngayLapHD,
                    soHoaDon = dto.soHoaDon
                };
                listVM.Add(vm);
            }
            return listVM;
        }

        public List<HoaDonDetailViewModel> GetHoaDonDetail(int maHD)
        {
            List<HoaDonDetailViewModel> listVM = new List<HoaDonDetailViewModel>();
            List<tblChiTietHoaDon> listHoaDon = db.tblChiTietHoaDons.Where(n => n.soHoaDon == maHD).ToList();
            foreach (var item in listHoaDon)
            {
                HoaDonDetailViewModel vm = new HoaDonDetailViewModel
                {
                    soHoaDon = item.soHoaDon,
                    soLuong = item.soLuong,
                    tenSach = item.tblSach.tenSach,
                    maDaiLy = item.tblHoaDon.maDaiLy,
                };
                listVM.Add(vm);
            }

            return listVM;
        }

        public List<HoaDonGetAllViewModel> FindHoaDonByLikeSoHDOrMaDL(int search)
        {
            List<HoaDonGetAllViewModel> listVM = new List<HoaDonGetAllViewModel>();
            List<tblHoaDon> listHoaDon = db.tblHoaDons.Where(n => n.hieuLuc == true && n.soHoaDon.Equals(search)).ToList();
            foreach (var dto in listHoaDon)
            {
                HoaDonGetAllViewModel vm = new HoaDonGetAllViewModel
                {
                    maDaiLy = dto.maDaiLy,
                    ngayLapHD = dto.ngayLapHD,
                    soHoaDon = dto.soHoaDon
                };
                listVM.Add(vm);
            }
            return listVM;
        }

        public bool RemoveHoaDon(int soHD)
        {
            try
            {
                tblHoaDon dto = db.tblHoaDons.FirstOrDefault(n => n.soHoaDon.Equals(soHD));
                dto.hieuLuc = false;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Load hóa đơn đã bị hủy
        public List<HoaDonGetAllViewModel> GetAllDisabledHoaDon()
        {
            List<HoaDonGetAllViewModel> listVM = new List<HoaDonGetAllViewModel>();
            List<tblHoaDon> listHoaDon = db.tblHoaDons.Where(n => n.hieuLuc == false).ToList();
            foreach (var dto in listHoaDon)
            {
                HoaDonGetAllViewModel vm = new HoaDonGetAllViewModel
                {
                    maDaiLy = dto.maDaiLy,
                    ngayLapHD = dto.ngayLapHD,
                    soHoaDon = dto.soHoaDon
                };
                listVM.Add(vm);
            }
            return listVM;
        }

        public bool InsertNewHoaDon(HoaDonViewModel dto, List<ChiTietHoaDonViewModel> listVM)
        {
            try
            {
                tblHoaDon hd = new tblHoaDon
                {
                    maDaiLy = dto.maDaiLy,
                    ngayLapHD = dto.ngayLapHD,
                    hieuLuc = true
                };
                db.tblHoaDons.Add(hd);
                db.SaveChanges();
                int soHoaDon = hd.soHoaDon;
                foreach (var item in listVM)
                {
                    tblChiTietHoaDon cthd = new tblChiTietHoaDon
                    {
                        soHoaDon = soHoaDon,
                        maSach = item.maSach,
                        soLuong = item.soLuong,
                        ghiChu = item.ghiChu,
                        hieuLuc = true
                    };
                    db.tblChiTietHoaDons.Add(cthd);
                    db.SaveChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

    }

    public class HoaDonViewModel
    {
        public int soHoaDon { get; set; }
        public Nullable<System.DateTime> ngayLapHD { get; set; }
        public string maDaiLy { get; set; }
        public bool hieuLuc { get; set; }
    }

    public class HoaDonGetAllViewModel
    {
        public int soHoaDon { get; set; }
        public Nullable<System.DateTime> ngayLapHD { get; set; }
        public string maDaiLy { get; set; }
    }

    public class HoaDonDetailViewModel
    {
        public int soHoaDon { get; set; }
        public string maDaiLy { get; set; }
        public string tenSach { get; set; }
        public Nullable<int> soLuong { get; set; }
    }

    public class ChiTietHoaDonViewModel
    {
        public int soHoaDon { get; set; }
        public string maSach { get; set; }
        public string ghiChu { get; set; }
        public Nullable<int> soLuong { get; set; }
        public bool hieuLuc { get; set; }
    }
}
