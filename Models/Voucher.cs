using System.ComponentModel.DataAnnotations;

namespace PRO131_01.Models
{
    public class Voucher
    {
        [Key]
        public string MaVoucher { get; set; }

        public string TenVoucher { get; set; }

        public decimal? GiaTriApDung { get; set; } = 0;

        public decimal GiaTriGiam { get; set; } // Dùng cho cả 2 trường hợp

        public decimal? GiaTriGiamToiDa { get; set; }

        public LoaiVoucher LoaiVoucher { get; set; }
    }

    public enum LoaiVoucher
    {
        GiamTrucTiep, GiamPhamTram
    }

}