using System.Collections.Generic;
using System.Linq;

namespace ThanhTDSE62847_Final_Project.DAO
{
    public class NhaXBDAO
    {
        QuanLySachDBEntities db = new QuanLySachDBEntities();

        public List<NhaXBGetAllViewModel> GetAllNhaXB()
        {
            List<tblNhaXB> listNXB = db.tblNhaXBs.Where(n => n.cungCap == true).ToList();
            //int c = 0;
            //foreach (var item in listNXB)
            //{
            //    Console.WriteLine(c++ + "a: " + item.cungCap);
            //}
            List<NhaXBGetAllViewModel> listViewModel = new List<NhaXBGetAllViewModel>();
            foreach (var dto in listNXB)
            {
                NhaXBGetAllViewModel vm = new NhaXBGetAllViewModel
                {
                    maNhaXB = dto.maNhaXB,
                    tenNhaXB = dto.tenNhaXB,
                    diaChi = dto.diaChi,
                    dienThoai = dto.dienThoai
                };
                listViewModel.Add(vm);
            }
            //int i = 0;
            //foreach (var item in listViewModel)
            //{
            //    Console.WriteLine(i++ + "b: " + item.cungCap);
            //}
            return listViewModel;
        }

        public bool InsertNewNhaXB(NhaXBViewModel dto)
        {
            try
            {
                tblNhaXB nxb = new tblNhaXB
                {
                    maNhaXB = dto.maNhaXB,
                    tenNhaXB = dto.tenNhaXB,
                    diaChi = dto.diaChi,
                    dienThoai = dto.dienThoai,
                    cungCap = true
                };
                db.tblNhaXBs.Add(nxb);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public tblNhaXB FindNhaXB(string maNhaXB, bool trangThai)
        {
            tblNhaXB dto = db.tblNhaXBs.FirstOrDefault(n => n.maNhaXB.Equals(maNhaXB) && n.cungCap == trangThai);
            return dto;
        }

        public bool RemoveNhaXB(string maNhaXB)
        {
            bool isRemoveSucess = false;
            try
            {
                //tblNhaXB nxb = FindNhaXB(maNhaXB, true);
                tblNhaXB nxb = db.tblNhaXBs.FirstOrDefault(n => n.maNhaXB.Equals(maNhaXB) && n.cungCap == true);
                //Console.WriteLine("Mã: " + nxb.maNhaXB);
                //Console.WriteLine("trước: " + nxb.cungCap);
                nxb.cungCap = false;
                //Console.WriteLine("sau: " + nxb.cungCap);
                db.SaveChanges();
                isRemoveSucess = true;
            }
            catch
            {
                isRemoveSucess = false;

            }
            return isRemoveSucess;
        }

        public bool UpdateNhaXB(tblNhaXB dto, string maNhaXB)
        {
            try
            {
                tblNhaXB nxb = FindNhaXB(maNhaXB, true);
                nxb.tenNhaXB = dto.tenNhaXB;
                nxb.diaChi = dto.diaChi;
                nxb.dienThoai = dto.dienThoai;
                nxb.cungCap = dto.cungCap;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool CheckDupplicateID(string maNhaXB)
        {
            tblNhaXB dto = db.tblNhaXBs.FirstOrDefault(n => n.maNhaXB.Equals(maNhaXB));
            if (dto == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool CheckRelation(string maNhaXB)
        {
            //Nếu có ràng buộc thì trả về false, ngược lại trả về true
            List<tblSach> list = db.tblSaches.Where(n => n.maNhaXB.Equals(maNhaXB)).ToList();
            return list.Count() > 0 ? false : true;
        }

        //dùng để quản lý việc cung cấp của các NXB
        public List<NhaXBGetAllViewModel> GetUnavailableNXB()
        {
            List<NhaXBGetAllViewModel> listNXB = new List<NhaXBGetAllViewModel>();
            List<tblNhaXB> listDTO = db.tblNhaXBs.Where(n => n.cungCap == false).ToList();
            foreach (var dto in listDTO)
            {
                NhaXBGetAllViewModel vm = new NhaXBGetAllViewModel
                {
                    maNhaXB = dto.maNhaXB,
                    tenNhaXB = dto.tenNhaXB,
                    diaChi = dto.diaChi,
                    dienThoai = dto.dienThoai,
                };
                listNXB.Add(vm);
            }
            return listNXB;
        }

        //thay đổi lại trạng thái cung cấp của nhà xb thành true
        public bool UpdateCungCap(string maNhaXB)
        {
            try
            {
                tblNhaXB nxb = FindNhaXB(maNhaXB, false);
                nxb.cungCap = true;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //lấy danh sách các tựa sách tương ứng với một nhà xb
        public List<string> getAllSachFromNXB(string maNXB)
        {
            List<tblSach> listMaSachDB = db.tblSaches.Where(n => n.maNhaXB.Equals(maNXB)).ToList();
            List<string> listMaSach = new List<string>();
            foreach (var maSach in listMaSachDB)
            {
                string tmp = maSach.maSach.ToString();
                listMaSach.Add(tmp);
            }
            return listMaSach;
        }

        //thực hiện xóa các tựa sách có liên quan đến một nhà xuất bản khi nhà xuất bản đó bị xóa
        public bool RemoveSachWhenNXBIsDisable(List<string> listMaSach)
        {
            bool isRemoved = false;
            try
            {
                foreach (var item in listMaSach)
                {
                    tblSach tmpSach = db.tblSaches.FirstOrDefault(n => n.maSach.Equals(item));
                    tmpSach.cungCap = false;
                    db.SaveChanges();
                }
                return true;
            }
            catch
            {
                isRemoved = false;
            }
            return isRemoved;
        }

        public List<NhaXBGetAllViewModel> FindNXBDisabledByName(string search)
        {
            List<tblNhaXB> listNXB = db.tblNhaXBs.Where(n => n.cungCap == false && n.tenNhaXB.Contains(search)).ToList();
            List<NhaXBGetAllViewModel> listViewModel = new List<NhaXBGetAllViewModel>();
            foreach (var dto in listNXB)
            {
                NhaXBGetAllViewModel vm = new NhaXBGetAllViewModel
                {
                    maNhaXB = dto.maNhaXB,
                    tenNhaXB = dto.tenNhaXB,
                    diaChi = dto.diaChi,
                    dienThoai = dto.dienThoai
                };
                listViewModel.Add(vm);
            }
            return listViewModel;
        }

        public List<NhaXBGetAllViewModel> FindNXBLikeByName(string search)
        {
            List<tblNhaXB> listNXB = db.tblNhaXBs.Where(n => n.cungCap == true && n.tenNhaXB.Contains(search)).ToList();
            List<NhaXBGetAllViewModel> listViewModel = new List<NhaXBGetAllViewModel>();
            foreach (var dto in listNXB)
            {
                NhaXBGetAllViewModel vm = new NhaXBGetAllViewModel
                {
                    maNhaXB = dto.maNhaXB,
                    tenNhaXB = dto.tenNhaXB,
                    diaChi = dto.diaChi,
                    dienThoai = dto.dienThoai
                };
                listViewModel.Add(vm);
            }
            return listViewModel;
        }
    }

    public class NhaXBViewModel
    {
        public string maNhaXB { get; set; }
        public string tenNhaXB { get; set; }
        public string diaChi { get; set; }
        public string dienThoai { get; set; }
        public bool cungCap { get; set; }
    }
    public class NhaXBGetAllViewModel
    {
        public string maNhaXB { get; set; }
        public string tenNhaXB { get; set; }
        public string diaChi { get; set; }
        public string dienThoai { get; set; }
    }
}
