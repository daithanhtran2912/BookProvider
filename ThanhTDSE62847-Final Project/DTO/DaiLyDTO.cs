
namespace DTO
{
    public class DaiLyDTO
    {
        public DaiLyDTO(string maDL, string tenDL, string tenChuDL, string diaChi, string dienThoai)
        {
            this.MaDL = maDL;
            this.TenDL = tenDL;
            this.TenChuDL = tenChuDL;
            this.DiaChi = diaChi;
            this.DienThoai = dienThoai;
        }

        public string MaDL { get; set; }
        public string TenDL { get; set; }
        public string TenChuDL { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }

    }

}
