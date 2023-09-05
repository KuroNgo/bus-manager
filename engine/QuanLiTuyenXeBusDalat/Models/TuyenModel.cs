namespace QuanLiTuyenXeBusDalat.Models
{
    public class TuyenVM
    {
        public int MaDonVi { get; set; }
        public string TenTuyen { get; set; }
        public string ThoiGianBatDau { get; set; }
        public string ThoiGianKetThuc { get; set; }
        public string ThoiGianGianCach { get; set; }
        public string LoTrinhLuotDi { get; set; }
        public string LoTrinhLuotVe { get; set; }
        // So tuyen
        public string LoaiTuyen { get; set; }

    }

    public class Tuyen : TuyenVM
    {
        public int MaTuyen { get; set; }
    }
    public class TuyenModel
    {
        public string TenTuyen { get; set; }
        public string ThoiGianBatDau { get; set; }
        public string ThoiGianKetThuc { get; set; }
        public string ThoiGianGianCach { get; set; }
        public string LoTrinhLuotDi { get; set; }
        public string LoTrinhLuotVe { get; set; }
        public string LoaiTuyen { get; set; }
        public int MaDonVi { get; set; }

    }
}
