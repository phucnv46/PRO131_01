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
        GenericRepository<Giay> _repository;

        public SanPhamService()
        {
            _repository = new GenericRepository<Giay>();

        }

        public List<Giay> LayDsGiay()
        {
             return _repository.GetAll();
        }

        public List<string> LayDanhSachHang()
        {
            var list = LayDsGiay().ToList();
            return list.Select(s=>s.Hang).Distinct().ToList();
        }
    }
}
