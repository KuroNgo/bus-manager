using System.ComponentModel.DataAnnotations;

namespace QuanLiTuyenXeBusDalat.Models
{
    // Cái khu vực model là để người dùng nhập zào 
    public class LoginModel
    {
        // Validation
        [Required]
        [MaxLength(50)]
        public string UserName { get; set; }

        [Required]
        [MaxLength(250)]
        public string Password { get; set; }
    }

    // Cho người dùng chỉnh sửa thông tin cá nhân
    public class UserModel
    {
        [Required]
        [MaxLength(50)]
        public string HoTen { get; set; }

        [Required]
        public DateTime NgayThangNamSinh { get; set; }

        [Required]
        [MaxLength(150)]
        public string Email { get; set; }

        [Required]
        [MaxLength(20)]
        public string SDT { get; set; }

        [Required]
        [MaxLength(50)]
        public string UserName { get; set; }

        [Required]
        [MaxLength(250)]
        public string Password { get; set; }
    }
}
