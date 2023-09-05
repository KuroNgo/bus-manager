using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace QuanLiTuyenXeBusDalat.Data
{
    [Table("RefreshToken")]
    public class RefreshToken
    {
        [Key]
        public Guid Id { get; set; }
        public int UserId { get; set; }
        [ForeignKey(nameof(UserId))]

        // Token đang của người dùng nào
        public TaiKhoan taiKhoan { get; set; }

        // Nội dung của token
        public string Token { get; set; }
        
        // Refresh token
        public string JwtId { get; set; }
        // Sài hay chưa
        public bool IsUsed { get; set; }

        // Đã được thu hồi hay chưa
        public bool IsRevoked { get; set; }

        // Được tạo vào ngày nào
        public DateTime IsSuedAt { get; set; }

        // Sẽ hết hạn vào lúc nào
        public DateTime ExpireAt { get; set; }

    }
}
