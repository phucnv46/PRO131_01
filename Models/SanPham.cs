using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace PRO131_01.Models;

public partial class SanPham
{
    [DisplayName("Mã Sản phẩm")]
    public string MaSanPham { get; set; } = null!;


    [DisplayName("Tên sản phẩm")]

    public string TenSanPham { get; set; } = null!;

    public string? MoTa { get; set; }

    public int SoLuong { get; set; }

    public long MaLoaiSanPham { get; set; }

    public string? HinhAnh { get; set; }

    [Browsable(false)]
    public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; } = new List<HoaDonChiTiet>();
    [Browsable(false)]

    public virtual LoaiSanPham MaLoaiSanPhamNavigation { get; set; } = null!;
    [Browsable(false)]

    public virtual ICollection<SanPhamChiTiet> SanPhamChiTiets { get; set; } = new List<SanPhamChiTiet>();

    public string TenLoaiSanPham
    {
        get
        { return MaLoaiSanPhamNavigation.TenLoai ?? "Chưa rõ"; }

    }
}
