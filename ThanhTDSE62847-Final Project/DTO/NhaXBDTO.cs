using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class NhaXBDTO
    {
        public NhaXBDTO(string maNhaXB, string tenNhaXB, string diaChi, string dienThoai)
        {
            this.MaNhaXB = maNhaXB;
            this.TenNhaXB = tenNhaXB;
            this.DiaChi = diaChi;
            this.DienThoai = dienThoai;
        }

        public string MaNhaXB { get; set; }
        public string TenNhaXB { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
    }
}
