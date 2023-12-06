using QuanLiTuyenXeBusDalat.Data;
using QuanLiTuyenXeBusDalat.Models;

namespace QuanLiTuyenXeBusDalat.DataSeeder
{
    public class DataSeeder : IDataSeeder
    {
        private readonly MyDBContext _myDBContext;
        public DataSeeder(MyDBContext myDBContext)
        {
            _myDBContext = myDBContext;
        }
        public void Initialize()
        {
            _myDBContext.Database.EnsureCreated();
            if (_myDBContext.tuyens.Any()) { return; }
            if (_myDBContext.Xes.Any()) { return; }
            if (_myDBContext.TaiXes.Any()) { return; }

            var donViQuanLiXe = AddDonViQuanLiXe();
            var taiKhoan = AddUser();
            var tuyen = AddTuyen(donViQuanLiXe);
        }

        private IList<DonViQuanLiXe> AddDonViQuanLiXe()
        {
            var donViQuanLiXes = new List<DonViQuanLiXe>()
            {
                new()
                {
                    TenDonVi = "Công ty cp vt ôtô Lâm Đồng",
                    DiaChi="Lâm Đồng",
                    SoDienThoai= "0263.3822120",
                    Email=""
                },
                new()
                {
                    TenDonVi = "Công ty TNHH Phương Trang Đà Lạt",
                    DiaChi="Lâm Đồng",
                    SoDienThoai= "0263.3585858",
                    Email=""
                },
                new()
                {
                     TenDonVi = "Airport Shuttle Bus",
                     DiaChi="Lâm Đồng",
                     SoDienThoai= "0263.3822120",
                     Email=""
                }
            };
            _myDBContext.donViQuanLiXes.AddRange(donViQuanLiXes);
            _myDBContext.SaveChanges();

            return donViQuanLiXes;
        }

        private IList<Data.Tuyen> AddTuyen(IList<DonViQuanLiXe> donViQuanLiXes)
        {
            var tuyens = new List<Data.Tuyen>()
            {
                new()
                {
                    DonViQuanLiXe=donViQuanLiXes[0],
                    TenTuyen = "Tuyến Đà Lạt – Đức Trọng",
                    ThoiGianBatDau = "5h30",
                    ThoiGianKetThuc = "19h00",
                    ThoiGianGianCach = "15 - 30 phút chuyến",
                    LoaiTuyen = "70",
                    LoTrinhLuotDi="Bến xe buýt đường Mai Anh Đào, P8, Đà Lạt " +
                    "– đường Phù Đổng Thiên Vương – đường Đinh Tiên Hoàng - " +
                    "đường Nguyễn Thái Học- đường Lê Đại Hành - " +
                    "khu Hoà Bình – Đường 3/2 – đường Trần Phú – " +
                    "đường 3/4-QL 20- Bến xe Đức Trọng",
                    LoTrinhLuotVe ="Bến xe Đức Trọng -  " +
                    "đường 3/4-QL 20 – đường Trần Phú – " +
                    "Đường 3/2 - khu Hoà Bình- đường Lê Đại Hành - " +
                    "đường Nguyễn Thái Học – đường Đinh Tiên Hoàng – " +
                    "đường Phù Đổng Thiên Vương –  " +
                    "Bến xe buýt đường Mai Anh Đào, P8, Đà Lạt"
                },
                new()
                {
                    DonViQuanLiXe= donViQuanLiXes[1],
                    TenTuyen = "Tuyến Đà Lạt – Đơn Dương",
                    ThoiGianBatDau = "5h30",
                    ThoiGianKetThuc = "19h00",
                    ThoiGianGianCach = "15 - 30 phút chuyến",
                    LoaiTuyen = "",
                    LoTrinhLuotDi="Bến xe buýt đường Mai Anh Đào, P8, Đà Lạt – " +
                    "đường Phù Đổng Thiên Vương – " +
                    "đường Đinh Tiên Hoàng - " +
                    "đường Nguyễn Thái Học - " +
                    "đường Lê Đại Hành - " +
                    "khu Hoà Bình – " +
                    "Đường 3/2 - " +
                    "Phan Đình Phùng - " +
                    "Xô Viết Nghệ Tĩnh – " +
                    "Tùng Lâm – " +
                    "khu du lịch Langbiang ",
                    LoTrinhLuotVe ="khu du lịch Langbiang - " +
                    "Tùng Lâm - " +
                    "Xô Viết Nghệ Tĩnh – " +
                    "Phan Đình Phùng – " +
                    "Đường 3/2 - " +
                    "khu Hoà Bình - " +
                    "đường Lê Đại Hành – " +
                    "đường Nguyễn Thái Học – " +
                    "đường Đinh Tiên Hoàng – " +
                    "đường Phù Đổng Thiên Vương - " +
                    "Bến xe buýt đường Mai Anh Đào, P8, Đà Lạt"
                },
                new()
                {
                    DonViQuanLiXe= donViQuanLiXes[1],
                    TenTuyen = "Tuyến Đà Lạt – Lạc Dương",
                    ThoiGianBatDau = "5h30",
                    ThoiGianKetThuc = "19h00",
                    ThoiGianGianCach = "15 - 30 phút chuyến",
                    LoaiTuyen = "48",
                    LoTrinhLuotDi="Bến xe buýt đường Mai Anh Đào, P8, Đà Lạt – " +
                    "đường Phù Đổng Thiên Vương – đường Đinh Tiên Hoàng - " +
                    "đường Nguyễn Thái Học- đường Lê Đại Hành - " +
                    "khu Hoà Bình – Đường 3/2 - Phan Đình Phùng- " +
                    "Xô Viết Nghệ Tĩnh – Tùng Lâm – khu du lịch Langbiang ",
                    LoTrinhLuotVe ="khu du lịch Langbiang - Tùng Lâm , " +
                    "Xô Viết Nghệ Tĩnh – Phan Đình Phùng – " +
                    "Đường 3/2 - khu Hoà Bình- đường Lê Đại Hành - " +
                    "đường Nguyễn Thái Học – " +
                    "đường Đinh Tiên Hoàng – " +
                    "đường Phù Đổng Thiên Vương - " +
                    "Bến xe buýt đường Mai Anh Đào, P8, Đà Lạt,"
                },
                new()
                {
                    DonViQuanLiXe= donViQuanLiXes[1],
                    TenTuyen = "Tuyến Đà Lạt – Bảo Lộc",
                    ThoiGianBatDau = "5h30",
                    ThoiGianKetThuc = "19h00",
                    ThoiGianGianCach = "15 - 30 phút chuyến",
                    LoaiTuyen = "60",
                    LoTrinhLuotDi=" Bến xe buýt đường Mai Anh Đào, P8, Đà Lạt – " +
                    "đường Phù Đổng Thiên Vương – " +
                    "đường Đinh Tiên Hoàng - " +
                    "đường Nguyễn Thái Học - " +
                    "đường Lê Đại Hành - " +
                    "khu Hoà Bình – " +
                    "Đường 3/2 – " +
                    "đường Trần Phú – " +
                    "đường 3/4 - " +
                    "QL 20 – " +
                    "đường Thống Nhất (Đức Trọng) – " +
                    "Ngã ba Phú Hội – " +
                    "QL20 – " +
                    "đường Lê Hồng Phong (Bảo Lộc) – " +
                    "đường Nguyễn Công Trứ - " +
                    "đường 28/3 – " +
                    "số 458 Trần Phú Bảo Lộc",
                    LoTrinhLuotVe ="số 458 Trần Phú Bảo Lộc – " +
                    "đường 28/3 - " +
                    "đường Nguyễn Công Trứ – " +
                    "đường Lê Hồng Phong (Bảo Lộc) – " +
                    "QL20 –  " +
                    "Ngã ba Phú Hội – " +
                    "đường Thống Nhất (Đức Trọng) - " +
                    "QL 20 - " +
                    "đường 3/4 - " +
                    "đường Trần Phú - " +
                    "Đường 3/2 - " +
                    "khu Hoà Bình - " +
                    "đường Lê Đại Hành - " +
                    "đường Nguyễn Thái Học - " +
                    "đường Đinh Tiên Hoàng - " +
                    "đường Phù Đổng Thiên Vương – " +
                    "Bến xe buýt đường Mai Anh Đào, P8, Đà Lạt "
                },
                new()
                {
                    DonViQuanLiXe= donViQuanLiXes[1],
                    TenTuyen = "Tuyến Đà Lạt – Xuân Trường",
                    ThoiGianBatDau = "5h30",
                    ThoiGianKetThuc = "19h00",
                    ThoiGianGianCach = "15 - 30 phút chuyến",
                    LoaiTuyen = "40",
                    LoTrinhLuotDi="Bến xe buýt đường Mai Anh Đào, P8, Đà Lạt – " +
                    "đường Phù Đổng Thiên Vương – " +
                    "đường Đinh Tiên Hoàng - " +
                    "đường Nguyễn Thái Học - " +
                    "đường Lê Đại Hành - " +
                    "khu Hoà Bình – " +
                    "Đường 3/2 – " +
                    "đường Trần Phú – " +
                    "đườngTrần Hưng Đạo – " +
                    "QL 20 – " +
                    "Thôn Trạm Hành 2",
                    LoTrinhLuotVe ="Thôn Trạm Hành 2 - " +
                    "QL 20 - " +
                    "đườngTrần Hưng Đạo – " +
                    "đường Trần Phú – " +
                    "Đường 3/2 - " +
                    "khu Hoà Bình- " +
                    "đường Lê Đại Hành - " +
                    "đường Nguyễn Thái Học – " +
                    "đường Đinh Tiên Hoàng – " +
                    "đường Phù Đổng Thiên Vương-P8 -" +
                    "Đà Lạt,Bến xe buýt đường Mai Anh Đào"
                },
                new()
                {
                    DonViQuanLiXe=donViQuanLiXes[0],
                    TenTuyen = "Tuyến Đà Lạt – Phú Sơn",
                    ThoiGianBatDau = "5h30",
                    ThoiGianKetThuc = "19h00",
                    ThoiGianGianCach = "15 - 30 phút chuyến",
                    LoaiTuyen = "",
                    LoTrinhLuotDi="Bến xe buýt đường Mai Anh Đào, P8, Đà Lạt – " +
                    "đường Phù Đổng Thiên Vương – " +
                    "đường Đinh Tiên Hoàng - " +
                    "đường Nguyễn Thái Học - " +
                    "đường Lê Đại Hành - " +
                    "khu Hoà Bình – " +
                    "Đường 3/2 – " +
                    "đường Hòang Văn Thụ - " +
                    "ĐT 725 – " +
                    "Tà Nung – " +
                    "Nam Ban – " +
                    "QL27 – " +
                    "Đinh Văn – " +
                    "Phú Sơn",
                    LoTrinhLuotVe ="Phú Sơn - " +
                    "Đinh Văn - " +
                    "QL27 – " +
                    "Nam Ban – " +
                    "Tà Nung - " +
                    "ĐT 725 - " +
                    "đường Hòang Văn Thụ - " +
                    "Đường 3/2 - " +
                    "khu Hoà Bình- " +
                    "đường Lê Đại Hành - " +
                    "đường Nguyễn Thái Học – " +
                    "đường Đinh Tiên Hoàng – " +
                    "đường Phù Đổng Thiên Vương-P8 -" +
                    "Đà Lạt,Bến xe buýt đường Mai Anh Đào"
                },
                new()
                {
                    DonViQuanLiXe=donViQuanLiXes[0],
                    TenTuyen = "Tuyến Liên nghĩa – Tân Thanh",
                    ThoiGianBatDau = "5h30",
                    ThoiGianKetThuc = "19h00",
                    ThoiGianGianCach = "15 - 30 phút chuyến",
                    LoaiTuyen = "",
                    LoTrinhLuotDi=" BX Đức Trọng – " +
                    "QL 20 – " +
                    "thôn Bạch Đằng – " +
                    "N’ thôn Hạ QL 27 - " +
                    "Đinh Văn – " +
                    "Chợ Tân Thanh (Lâm Hà)",
                    LoTrinhLuotVe ="Chợ Tân Thanh (Lâm Hà) - " +
                    "Đinh Văn - " +
                    "N’ thôn Hạ QL 27 – " +
                    "thôn Bạch Đằng – " +
                    "QL 20 - " +
                    "BX Đức Trọng"
                },
                new()
                {
                    DonViQuanLiXe=donViQuanLiXes[2],
                    TenTuyen = "Tuyến Đà Lạt – Sân bay Liên Khương",
                    ThoiGianBatDau = "5h30",
                    ThoiGianKetThuc = "19h00",
                    ThoiGianGianCach = "15 - 30 phút chuyến",
                    LoaiTuyen = "",
                    LoTrinhLuotDi="Số 1 Lê Thị Hồng Gấm - Sân bay Liên Khương",
                    LoTrinhLuotVe =""
                },
                new()
                {
                    DonViQuanLiXe= donViQuanLiXes[0],
                    TenTuyen = "Tuyến Đà Lạt – Đại Lào",
                    ThoiGianBatDau = "5h30",
                    ThoiGianKetThuc = "19h00",
                    ThoiGianGianCach = "15 - 30 phút chuyến",
                    LoaiTuyen = "47",
                    LoTrinhLuotDi="Bến xe nội thành – Khu Hòa Bình – 3/2 – Trần Phú – Ngã tư kim Cúc – 3/4 –" +
                    " đèo Prenn – Qlộ 20 – Ngã ba Finom – thị xã Bảo Lộc – chợ Bảo Lộc – Nguyễn Công Trứ –" +
                    " đường 28/3 – Trần Phú – chợ Đại Lào.",
                    LoTrinhLuotVe =""
                },
                new()
                {
                    DonViQuanLiXe=donViQuanLiXes[1],
                    TenTuyen = "Tuyến Đà Lạt – Lạc Dương",
                    ThoiGianBatDau = "5h30",
                    ThoiGianKetThuc = "19h00",
                    ThoiGianGianCach = "30 - 45 phút chuyến",
                    LoaiTuyen = "36",
                    LoTrinhLuotDi="Bến xe nội thành – Khu Hòa Bình – 3/2 – Trần Phú – Palace – Hồ Tùng Mậu –" +
                    " Yersin – Quang Trung – Chi Lăng – Mê Linh – chợ Thái Phiên.",
                    LoTrinhLuotVe=""
                }

            };
            _myDBContext.tuyens.AddRange(tuyens);
            _myDBContext.SaveChanges();

            return tuyens;
        }
        private IList<TaiKhoan> AddUser()
        {
            var users = new List<TaiKhoan>()
            {
                new()
                {
                    UserName="admin",
                    Password="123",
                    Email="abc@gmail.com",
                    HoTen="Nguyen Van A",
                    SDT="0123456789",
                    NgayThangNamSinh=new DateTime(2001,6,11)
                }
            };
            _myDBContext.taiKhoans.AddRange(users);
            _myDBContext.SaveChanges();

            return users;
        }
    }
}
