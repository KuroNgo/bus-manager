using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLiTuyenXeBusDalat.Data
{
    [Table("Tuyen")]
    public class Tuyen
    {
        [Key]
        public int MaTuyen { get; set; }
        public int? MaDonVi { get; set; }
        [ForeignKey("MaDonVi")]
        public DonViQuanLiXe DonViQuanLiXe { get; set; }
        public string TenTuyen { get; set; }
        public string ThoiGianBatDau { get; set; }
        public string ThoiGianKetThuc { get; set; }
        public string ThoiGianGianCach { get; set; }
        public string LoTrinhLuotDi { get; set; }
        public string LoTrinhLuotVe { get; set; }
        public string LoaiTuyen { get; set; }

        // 2 giá trị này nhận hiển thị vị trí lên gg map
        //public string KinhDo { get; set; }
        //public string ViDo { get; set; }
    }
}
