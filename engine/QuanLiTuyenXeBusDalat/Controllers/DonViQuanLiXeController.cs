using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;
using Microsoft.EntityFrameworkCore;
using QuanLiTuyenXeBusDalat.Data;
using QuanLiTuyenXeBusDalat.Models;

namespace QuanLiTuyenXeBusDalat.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiVersion("0.9", Deprecated = true)]
    [ApiVersion("1.0")]
    [DisableRateLimiting]
    public class DonViQuanLiXeController : ControllerBase
    {
        private readonly MyDBContext _context;

        public DonViQuanLiXeController(MyDBContext myDBContext)
        {
            _context = myDBContext;
        }

        [HttpGet]
        //Interface dùng để trả về cho các action
        public IActionResult GetAll()
        {
            var dsLoai = _context.donViQuanLiXes.ToList();
            return Ok(dsLoai);

            //// Trả về danh sách các hàng hóa
            //try
            //{
            //    var dsLoai = _context.donViQuanLiXes.ToList();
            //    return Ok(dsLoai);
            //}
            //catch
            //{
            //    return BadRequest();
            //}
        }
        [HttpGet("{id}")]
        public IActionResult GetByID(int id)
        {
            try
            {
                //LinQ [Object] Query
                var dsLoai = _context.donViQuanLiXes.SingleOrDefault(loai =>
          loai.MaDonVi == id);
                if (dsLoai != null)
                {
                    return Ok(dsLoai);
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
        //Insert
        [HttpPost]
        [Authorize]
        public IActionResult Create(DonViQuanLiXeVM donViQuanLiXeVM)
        {
            try
            {
                var donViQuanLiXe = new DonViQuanLiXe
                {
                    TenDonVi = donViQuanLiXeVM.TenDonVi,
                    DiaChi = donViQuanLiXeVM.DiaChi,
                    SoDienThoai = donViQuanLiXeVM.SoDienThoai,
                    Email = donViQuanLiXeVM.Email
                };
                _context.Add(donViQuanLiXe);
                _context.SaveChanges();
                //return Ok(loai)
                return StatusCode(StatusCodes.Status201Created, donViQuanLiXe);
            }
            catch
            {
                //400: BadRequest
                return BadRequest();
            }
        }

        [HttpPut("{id}")]
        [Authorize]
        public IActionResult Edit(int id, DonViQuanLiXeModel donViQuanLiXeEdit)
        {
            try
            {
                //LINQ [Object] Query
                var donViQuanLiXe = _context.donViQuanLiXes.SingleOrDefault(donViQuanLiXe
                    => donViQuanLiXe.MaDonVi == id);
                if (donViQuanLiXe != null)
                {
                    donViQuanLiXe.TenDonVi = donViQuanLiXeEdit.TenDonVi;
                    donViQuanLiXe.DiaChi = donViQuanLiXeEdit.DiaChi;
                    donViQuanLiXe.Email = donViQuanLiXeEdit.Email;
                    donViQuanLiXe.SoDienThoai = donViQuanLiXeEdit.SoDienThoai;
                    _context.SaveChanges();
                    return Ok(new ApiResponse
                    {
                        Success = true,
                        Message = "Đã thay đổi thành công",
                        Data = donViQuanLiXe
                    });
                }
                else
                {
                    //404
                    return NotFound();
                }
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        [Authorize]
        public IActionResult Delete(int id)
        {
            try
            {
                //Linq [object] Query
                var dsDonViQuanLiXe = _context.donViQuanLiXes.SingleOrDefault(loai =>
             loai.MaDonVi == id);
                if (dsDonViQuanLiXe != null)
                {
                    _context.Remove(dsDonViQuanLiXe);
                    _context.SaveChanges();
                    return Ok(new ApiResponse
                    {
                        Success = true,
                        Message = "Đã xóa thông tin đơn vị quản lý số " + id
                    });

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
