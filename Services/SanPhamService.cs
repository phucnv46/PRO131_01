using PRO131_01.Extentions;
using PRO131_01.Models;
using PRO131_01.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO131_01.Services
{
    public class SanPhamService
    {
        GenericRepository<SanPham> _repository;
        GenericRepository<LoaiSanPham> _lSPrepository;


        public SanPhamService()
        {
            _repository = new GenericRepository<SanPham>();
            _lSPrepository = new GenericRepository<LoaiSanPham>();
        }

        public List<SanPham> GetProducts()
        {
            return _repository.GetAll();
        }


        public List<LoaiSanPham> GetProductTypes()
        {
            return _lSPrepository.GetAll();
        }


        public List<SanPham> GetProductsWithInclude(params string[] includes)
        {
            return _repository.GetAllWithInClude(includes);
        }

        public void Them(SanPham sp)
        {
            _repository.Add(sp);
        }

        public void Sua(SanPham sp)
        {
            _repository.Update(sp);
        }

        public void Xoa(SanPham sp)
        {
            _repository.Remove(sp);
        }

        public List<SanPham> LocSanPhamTheoLoai(long maLoaiSanPham )
        {
            return GetProductsWithInclude(nameof(SanPham.MaLoaiSanPhamNavigation)).ToList()
                .Loc(sp=>sp.MaLoaiSanPham == maLoaiSanPham);
        }

       
    }
}
