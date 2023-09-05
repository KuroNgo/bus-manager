using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuanLiTuyenXeBusDalat.Data;
using QuanLiTuyenXeBusDalat.Models;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Microsoft.AspNetCore.RateLimiting;

namespace QuanLiTuyenXeBusDalat.Controllers
{
    [Route("api/{v:apiVersion}/[controller]")]
    [ApiVersion("0.9", Deprecated = true)]
    [ApiVersion("1.0")]
    [ApiController]
    [EnableRateLimiting("Api")]
    public class TaiXesController : ControllerBase
    {
        private readonly MyDBContext _context;
        public TaiXesController(MyDBContext context)
        {
            _context = context;
        }

        [HttpGet]

        public IActionResult GetAll()
        {
            try
            {
                var taixe = _context.TaiXes.Include(t => t.Xe).ToList();
                return Ok(taixe);

            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpGet("{id}")]
        public IActionResult GetByID(int id)
        {
            var query = from tx in _context.TaiXes
                        join x in _context.Xes on tx.MaXe
                        equals x.MaXe
                        where tx.MaXe == id
                        select new
                        {
                            tx.MaXe,
                            tx.MaTX,
                            tx.HoVaTen,
                            tx.GioiTinh,
                            tx.DiaChi,
                            tx.BangLai
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
        public IActionResult Create([FromBody] TaiXeVM taiXeVM)
        {
            var xe = _context.Xes.FirstOrDefault(x => x.MaXe ==
            taiXeVM.MaXe);
            if (xe == null)
            {
                return NotFound("Xe Not Found");
            }
            var taiXe = new Data.TaiXe
            {
                MaTX = 0,
                MaXe = taiXeVM.MaXe,
                HoVaTen = taiXeVM.TenTaiXe,
                GioiTinh = taiXeVM.GioiTinh,
                NgaySinh = taiXeVM.NgaySinh,
                DiaChi = taiXeVM.DiaChi,
                QueQuan = taiXeVM.QueQuan,
                NgayBDHopDong = taiXeVM.NgayBDHopDong,
                Luong = taiXeVM.Luong,
                BangLai = taiXeVM.BangLai
            };
            _context.TaiXes.Add(taiXe);
            _context.SaveChanges();
            return Ok(new
            {
                Success = true,
                Data = taiXe
            });
        }

        [HttpPut("{id}")]
        public IActionResult Edit(int id, Models.TaiXe taiXeEdit)
        {
            try
            {
                //LINQ [Object] Query
                var taiXe = _context.TaiXes.SingleOrDefault(tx =>
                tx.MaTX == id); ;
                if (taiXe == null) { return NotFound(); }
                if (id != taiXe.MaTX) { return BadRequest(); }
                //Update
                taiXe.HoVaTen = taiXeEdit.TenTaiXe;
                taiXe.GioiTinh = taiXeEdit.GioiTinh;
                taiXe.NgaySinh = taiXeEdit.NgaySinh;
                taiXe.DiaChi = taiXeEdit.DiaChi;
                taiXe.QueQuan = taiXeEdit.QueQuan;
                taiXe.NgayBDHopDong = taiXeEdit.NgayBDHopDong;
                taiXe.Luong = taiXeEdit.Luong;
                taiXe.BangLai = taiXeEdit.BangLai;
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
                //Linq [object] Query
                var taiXe = _context.TaiXes.SingleOrDefault(tx =>
                tx.MaTX == id);
                if (taiXe == null) { return NotFound(); }
                _context.Remove(taiXe);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }

    }
}
