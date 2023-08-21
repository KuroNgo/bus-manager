using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace QuanLiTuyenXeBusDalat.Data
{
    [Table("TaiXe")]
    public class TaiXe
    {
        [Key] //Chỉ định Mã Tài xế là khóa chính
        public int MaTX { get; set; }

        [Required] // Bắt buộc phải nhập = not null
        [MaxLength(100)] // Ràng buộc số ký tự nhập vào
        public string HoVaTen { get; set; }
        public DateTime NgaySinh { get; set; }

        public bool GioiTinh { get; set; }

        // Không nói gì hết thì được null, nvarchar max
        // Nullable là loại dữ liệu chứa dữ liệu được định nghĩa hoặc giá trị null.
        // Lưu ý ở đây loại dữ liệu biến đã được chỉ định và có thể sử dụng
        public string DiaChi { get; set; }

        public string QueQuan { get; set; }

        public DateTime NgayBDHopDong { get; set; }

        [Range(0,double.MaxValue)]
        public double Luong { get; set; }

        public string BangLai { get; set; }

        public int MaXe { get; set; }
        [ForeignKey("MaXe")]

        public Xe Xe { get; set; }
        
    }
}
