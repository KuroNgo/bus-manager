using Microsoft.EntityFrameworkCore;

namespace QuanLiTuyenXeBusDalat.Data
{
    public class MyDBContext : DbContext
    {

        #region DbSet
        public DbSet<RefreshToken> RefreshTokens { get; set; }
        public DbSet<TaiXe> TaiXes { get; set; }
        public DbSet<Xe> Xes { get; set; }
        public DbSet<TaiKhoan> taiKhoans { get; set; }
        public DbSet<Tuyen> tuyens { get; set; }
        public DbSet<DonViQuanLiXe> donViQuanLiXes { get; set; }

        public MyDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DonViQuanLiXe).Assembly);
        }
        #endregion
    }
}
