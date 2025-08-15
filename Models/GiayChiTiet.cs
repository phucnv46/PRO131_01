using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRO131_01.Models
{
    public class GiayChiTiet
    {
        [Key]
        [MaxLength(255)]
        public string MaGiayChiTiet { get; set; }

        public string Mau { get; set; }
        public string Size { get; set; }
        public string? HinhAnh { get; set; }

        public decimal Gia { get; set; }

        public uint SoLuong { get; set; } = 0;

        public Giay Giay { get; set; }

        public HoaDonChiTiet? HoaDonChiTiet { get; set; } 

        [ForeignKey(nameof(Giay))]
        public string MaGiay { get; set; }

        [ForeignKey("HoaDonChiTiet")]
        public long? MaHoaDonChiTiet { get; set; }



    }
}