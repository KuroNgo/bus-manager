using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;
using Microsoft.EntityFrameworkCore;
using QuanLiTuyenXeBusDalat.Data;
using QuanLiTuyenXeBusDalat.Models;
using System.ComponentModel.DataAnnotations;

namespace QuanLiTuyenXeBusDalat.Controllers
{
    // THông tin của bảng này được lấy từ database
    [Route("api/{v:apiVersion}/[controller]")]
    [ApiController]
    [ApiVersion("0.9", Deprecated = true)]
    [ApiVersion("1.0")]
    public class TuyenController : ControllerBase
    {
        private readonly MyDBContext _context;

        public TuyenController(MyDBContext myDBContext)
        {
            _context = myDBContext;
        }

        [HttpGet]
        [Authorize]
        //Interface dùng để trả về cho các action
        public IActionResult GetAll()
        {

            // Trả về danh sách các hàng hóa
            try
            {
                var tuyens = _context.tuyens.Include(t => t.DonViQuanLiXe).ToList();
                return Ok(new ApiResponse
                {
                    Success = true,
                    Data = tuyens
                });
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetByID(int id)
        {
            var query = from t in _context.tuyens
                        join dvql in _context.donViQuanLiXes on t.MaDonVi
                        equals dvql.MaDonVi
                        where t.MaDonVi == id
                        select new
                        {
                            t.TenTuyen,
                            t.LoaiTuyen,
                            dvql.TenDonVi,
                            t.LoTrinhLuotDi,
                            t.LoTrinhLuotVe,
                            t.ThoiGianBatDau,
                            t.ThoiGianGianCach,
                            t.ThoiGianKetThuc
                        };
            var result = query.FirstOrDefault();
            if (result == null)
            {
                return NotFound();
            }

            return Ok(new ApiResponse
            {
                Success = true,
                Data = result
            });
        }

        //Insert
        [HttpPost]
        public IActionResult Create([FromBody] TuyenVM tuyenVM)
        {
            var MaDonVi = _context.donViQuanLiXes.FirstOrDefault(dvql =>
            dvql.MaDonVi == tuyenVM.MaDonVi);

            if (MaDonVi == null)
            {
                return NotFound("DonViQuanLiXe not found");
            }


            var tuyen = new Data.Tuyen
            {
                MaTuyen = 0,
                MaDonVi = tuyenVM.MaDonVi,
                TenTuyen = tuyenVM.TenTuyen,
                ThoiGianBatDau = tuyenVM.ThoiGianBatDau,
                ThoiGianKetThuc = tuyenVM.ThoiGianKetThuc,
                ThoiGianGianCach = tuyenVM.ThoiGianGianCach,
                LoTrinhLuotDi = tuyenVM.LoTrinhLuotDi,
                LoTrinhLuotVe = tuyenVM.LoTrinhLuotVe,
                LoaiTuyen = tuyenVM.LoaiTuyen,
            };
            _context.tuyens.Add(tuyen);
            _context.SaveChanges();
            return Ok(new
            {
                Success = true,
                Data = tuyen
            });
        }

        [HttpPut("{id}")]
        public IActionResult Edit(int id, Models.Tuyen tuyenEdit)
        {
            try
            {
                var maDVQL = _context.donViQuanLiXes.FirstOrDefault(dvql => dvql.MaDonVi == id);
                //LINQ [Object] Query
                var tuyen = _context.tuyens.SingleOrDefault(t => t.MaTuyen == id);
                if (tuyen == null) { return NotFound(); }
                if (id != tuyen.MaTuyen) { return BadRequest(); }
                //Update
                tuyen.TenTuyen = tuyenEdit.TenTuyen;
                tuyen.ThoiGianBatDau = tuyenEdit.ThoiGianBatDau;
                tuyen.ThoiGianKetThuc = tuyenEdit.ThoiGianKetThuc;
                tuyen.ThoiGianGianCach = tuyenEdit.ThoiGianGianCach;
                tuyen.LoTrinhLuotDi = tuyenEdit.LoTrinhLuotDi;
                tuyen.LoTrinhLuotVe = tuyenEdit.LoTrinhLuotVe;
                tuyen.LoaiTuyen = tuyenEdit.LoaiTuyen;
                tuyen.MaDonVi = tuyenEdit.MaDonVi;
                return Ok(new ApiResponse
                {
                    Success = true,
                    Message = "Thay đổi thành công"
                });
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var tuyen = _context.tuyens.SingleOrDefault(t => t.MaTuyen == id);
                if (tuyen != null)
                {
                    _context.Remove(tuyen);
                    _context.SaveChanges();
                    return StatusCode(StatusCodes.Status200OK);
                }
                else
                {
                    return NotFound();
                }
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
