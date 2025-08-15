using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRO131_01.Models
{
    public class HoaDon
    {
        [Key]
        public string Ma { get; set; }

        public DateTime ThoiGianTao { get; set; }

        public decimal TongTien
        {
            get
            { 
                return HoaDonChiTiets.Sum(hdct=>hdct.DonGia); 
            }
        }
        public decimal SoTienGiam { get; set; } = 0;
        public decimal ThanhTien { get; set; } = 0;

        public TrangThaiHoaDon TrangThai { get; set; } = TrangThaiHoaDon.ChuaThanhToan;

        public Voucher? Voucher { get; set; }

        public NhanVien NhanVien { get; set; }

        public KhachHang? KhachHang { get; set; }

        public List<HoaDonChiTiet> HoaDonChiTiets { get; set; } = new List<HoaDonChiTiet>();

        [ForeignKey(nameof(Voucher))]

        public string? MaVoucher { get; set; }

        [ForeignKey(nameof(NhanVien))]
        public string? MaNhanVien { get; set; }
        [ForeignKey(nameof(KhachHang))]
        public long? MaKhachHang { get; set; }
    }

    public enum TrangThaiHoaDon
    {
        ChuaThanhToan, DaThanhToan, DaHuy
    }
}