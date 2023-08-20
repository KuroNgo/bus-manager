using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLiTuyenXeBusDalat.Data
{
    [Table("Xe")]
    public class Xe
    {
        // Mã tự tăng do có identity
        // Do tên không kết thúc bằng chữ ID nên không set được khóa chính
        [Key]
        public int MaXe { get; set; }

        [Required]
        [MaxLength(50)]
        public string BienSo { get; set; }
        public string LoaiXe { get; set; }

        [Range(0,int.MaxValue)] // Giá trị số ghế phải lớn hơn 0 
        public int SoGhe { get; set; } 

        [Range(0,float.MaxValue)]
        public float CongSuat { get; set; }

        public string ChuKyBaoHanh { get; set; }
        
        public DateTime NgaySX { get; set; }
        public int MaTuyen { get; set; }
        [ForeignKey("MaTuyen")]
        public Tuyen Tuyen { get; set; }

    }
}
