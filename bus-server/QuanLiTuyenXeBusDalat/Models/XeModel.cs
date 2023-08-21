using System.ComponentModel.DataAnnotations;

namespace QuanLiTuyenXeBusDalat.Models
{
    public class XeVM
    {
        public int MaTuyen { get; set; }
        public string BienSo { get; set; }

        public string LoaiXe { get; set; }

        public int SoGhe { get; set; }

        public float CongSuat { get; set; }

        public string ChuKyBaoHanh { get; set; }

        public DateTime NgaySX { get; set; }
    }

    public class Xe : XeVM
    {
        public int MaXe { get; set; }
    }
    public class XeModel
    {
        public string BienSo { get; set; }
        public string LoaiXe { get; set; }

        public int SoGhe { get; set; }

        public float CongSuat { get; set; }

        public string ChuKyBaoHanh { get; set; }

        public DateTime NgaySX { get; set; }
        public int MaTuyen { get; set; }

    }
}
