using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRO131_01.Models
{
    public class KhachHang
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Ma { get; set; }

        public string SoDienThoai { get; set; }

        public string HoTen { get; set; }

        public string? Email { get; set; }

        public List<HoaDon> HoaDons { get; set; } = new();
    }
}