using Microsoft.EntityFrameworkCore;
using PRO131_01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO131_01.Data
{
    public class SneakerShopDbContext : DbContext
    {

        public virtual DbSet<Giay> Giay { get; set; }
        public virtual DbSet<GiayChiTiet> GiayChiTiet { get; set; }
        public virtual DbSet<HoaDon> HoaDon { get; set; }
        public virtual DbSet<NhanVien> NhanVien { get; set; }
        public virtual DbSet<HoaDonChiTiet> HoaDonChiTiet { get; set; }
        public virtual DbSet<Voucher> Voucher { get; set; }
        public virtual DbSet<KhachHang> KhachHang { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=np:\\\\.\\pipe\\LOCALDB#6A74E0E7\\tsql\\query;" +
                "Database=PRO131_01_NEW;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
