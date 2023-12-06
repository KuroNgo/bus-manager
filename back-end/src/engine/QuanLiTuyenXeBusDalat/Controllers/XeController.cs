using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;
using Microsoft.EntityFrameworkCore;
using QuanLiTuyenXeBusDalat.Data;
using QuanLiTuyenXeBusDalat.Models;

namespace QuanLiTuyenXeBusDalat.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    [EnableRateLimiting("Api")]
    [EnableCors("MyCors2_AllowGETForGoogle")]
    [Route("api/{v:apiVersion}/[controller]")]
    [ApiVersion("0.9", Deprecated = true)]
    [ApiVersion("1.0")]
    [ApiVersion("2.0")]
    public class XeController : ControllerBase
    {
        private readonly MyDBContext _context;
        public XeController(MyDBContext context)
        {
            _context = context;
        }
        [HttpGet]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var Tuyen = _context.Xes.Include(t => t.Tuyen).ToList();
                var dsXe = _context.Xes
                     .Select(x => new
                     {
                         x.MaXe,
                         x.BienSo,
                         x.LoaiXe,
                         x.SoGhe,
                         x.CongSuat,
                         x.ChuKyBaoHanh,
                         x.NgaySX,
                         x.Tuyen
                     });

                return Ok(dsXe);
            }
            catch
            {
                return BadRequest();
            }
        }

        [DisableCors]
        [HttpGet("id")]
        [MapToApiVersion("1.0")]
        public IActionResult GetById(int id)
        {
            var query = from xe in _context.Xes
                        join tuyen in _context.tuyens on xe.MaTuyen
                        equals tuyen.MaTuyen
                        where xe.MaTuyen == id
                        select new
                        {
                            xe.MaXe,
                            xe.MaTuyen,
                            xe.BienSo,
                            xe.ChuKyBaoHanh,
                            xe.NgaySX,
                            xe.LoaiXe,
                            xe.CongSuat
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

        // Thêm 
        [HttpPost]
        [Authorize]
        [MapToApiVersion("1.0")]
        //Phải cấu hình mới thực hiện thực được lệnh authorize
        // Phải đăng nhập mới được làm
        public IActionResult CreateNew(XeVM XeModel)
        {
            var maTuyen = _context.tuyens.FirstOrDefault(t => t.MaTuyen == XeModel.MaTuyen);
            if (maTuyen == null)
            {
                return NotFound("Tuyen Id not found");
            }
            var xe = new Data.Xe
            {
                MaXe = 0,
                MaTuyen = XeModel.MaTuyen,
                // Vì MaXe mình dang đặt cho nó là identity nên nó sẽ tự động tăng
                // Không cần khai báo vào trong này
                BienSo = XeModel.BienSo,
                LoaiXe = XeModel.LoaiXe,
                SoGhe = XeModel.SoGhe,
                CongSuat = XeModel.CongSuat,
                NgaySX = XeModel.NgaySX,
                ChuKyBaoHanh = XeModel.ChuKyBaoHanh
            };
            _context.Xes.Add(xe);
            _context.SaveChanges();
            return Ok(new
            {
                Success = true,
                Data = xe
            });

        }

        [HttpPut("{id}")]
        [MapToApiVersion("1.0")]
        [MapToApiVersion("2.0")]
        public IActionResult EditXe(int id, Models.Xe xeEdit)
        {
            try
            {
                var maTuyen = _context.tuyens.FirstOrDefault(t => t.MaTuyen == xeEdit.MaTuyen);
                var xe = _context.Xes.SingleOrDefault(xe => xe.MaXe == id);
                if (xe == null)
                {
                    return NotFound();
                }
                if (id != xe.MaXe)
                {
                    return BadRequest();
                }
                //Update 
                xe.BienSo = xeEdit.BienSo;
                xe.LoaiXe = xeEdit.LoaiXe;
                xe.CongSuat = xeEdit.CongSuat;
                xe.ChuKyBaoHanh = xeEdit.ChuKyBaoHanh;
                xe.SoGhe = xeEdit.SoGhe;
                xe.NgaySX = xeEdit.NgaySX;
                xe.MaTuyen = xeEdit.MaTuyen;
                return Ok(new ApiResponse
                {
                    Success = true,
                    Message = "cập nhật thành công xe có id là " + xe.MaXe
                });
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        [MapToApiVersion("1.0")]
        [MapToApiVersion("2.0")]
        [Authorize]
        public IActionResult Delete(int id)
        {
            try
            {
                var xe = _context.Xes.SingleOrDefault(xe => xe.MaXe == id);
                if (xe == null)
                {
                    return NotFound();
                }
                _context.Remove(xe);
                _context.SaveChanges();
                return Ok(new ApiResponse
                {
                    Success = true,
                    Message = "Đã xóa xe có id là" + xe.MaXe
                });
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
