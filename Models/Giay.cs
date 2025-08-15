using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO131_01.Models
{
    public class Giay
    {
        [Key]
        [StringLength(50)]
        public string MaGiay { get; set; }

        public string TenGiay { get; set; }

        public int? TongSoLuong
        {
            get
            { return (int)GiayChiTiets.Sum(gct => gct.SoLuong); }
        }

        public string? MoTa { get; set; }

        [MaxLength(255)]
        public string Hang { get; set; }

        public string? HinhAnh { get; set; }

        public List<GiayChiTiet> GiayChiTiets { get; set; } = new List<GiayChiTiet>(); // Có nhiều giày chi tiết


    }
}
