using System.ComponentModel.DataAnnotations;

namespace QuanLiTuyenXeBusDalat.Models
{
    public class DonViQuanLiXeModel
    {
        // Có model để người dùng nhập vào
        [Required]
        [MaxLength(50)]
        public string TenDonVi { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
    }

    public class DonViQuanLiXeVM
    {
        public int MaDonVi { get; set; }
        public string TenDonVi { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
    }
}
