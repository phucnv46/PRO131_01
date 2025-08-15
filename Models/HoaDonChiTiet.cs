using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRO131_01.Models
{
    public class HoaDonChiTiet
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]   
        public long MaHDCT { get; set; }

        [ForeignKey(nameof(HoaDon))]
        public string MaHoaDon { get; set; }
        public int SoLuong { get; set; }

        public decimal DonGia { get; set; }

        public HoaDon HoaDon { get; set; }

     
    }
}