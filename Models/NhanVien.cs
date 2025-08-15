using System.ComponentModel.DataAnnotations;

namespace PRO131_01.Models
{
    public class NhanVien
    {
        [Key]
        [MaxLength(255)]
        public string Ma { get; set; }

        public string HoTen { get; set; }

        public string? Email { get; set; }
        public string? DiaChi { get; set; }
        public bool? GioiTinh { get; set; }
        [Required]
        public string TaiKhoan { get; set; }
        [Required]
        public string MatKhau { get; set; }

        public VaiTro VaiTro { get; set; } = VaiTro.NhanVien;

        public List<HoaDon> HoaDons { get; set; } = new List<HoaDon>();

        public bool TrangThai { get; set; } = true;
    }

    public enum VaiTro
    {
        NhanVien,QuanLy
    }
}