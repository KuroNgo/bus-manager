using System.ComponentModel.DataAnnotations;

namespace QuanLiTuyenXeBusDalat.Models
{
    
    public class TaiXeVM
    {
        public string TenTaiXe { get; set; }
        public bool GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string QueQuan { get; set; }
        public DateTime NgayBDHopDong { get; set; }
        public double Luong { get; set; }
        public string BangLai { get; set; }
        public int MaXe { get; set; }
    }

   
    public class TaiXe : TaiXeVM
    {
        public int MaTaiXe { get; set; }
    }
}
