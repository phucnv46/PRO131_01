using AntdUI;
using PRO131_01.Models;
using PRO131_01.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRO131_01.Forms
{
    public partial class FormQLSP : Form
    {
        SanPhamService _sanPhamService;
        List<Giay> _giays;
        public FormQLSP()
        {
            InitializeComponent();
            _sanPhamService = new SanPhamService();
            LoadControls();
        }

        private void LoadControls()
        {
            _giays = _sanPhamService.LayDsGiay();
            table1.Visible = false;
            if (_giays.Count > 0)
            {
                table1.Show();
                table1.DataSource = _giays;

                table1.Columns = new AntdUI.ColumnCollection()
                {
                    new AntdUI.Column(nameof(Giay.MaGiay),"Mã giày"),
                    new AntdUI.Column(nameof(Giay.TenGiay),"Tên giày"),
                    new AntdUI.Column(nameof(Giay.TongSoLuong),"Tổng giày"),
                    new AntdUI.Column(nameof(Giay.Hang),"Hãng giày"),
                    new AntdUI.Column("act","Thao tác")
                    {
                        Render = (data, record, index) =>
                        {
                            AntdUI.CellButton details =
                            new AntdUI.CellButton("detail","Giày chi tiết"){
                                Type= AntdUI.TTypeMini.Primary,
                            };
                            return details;
                        }
                    },
                };



                foreach (string hang in _sanPhamService.LayDanhSachHang())
                {
                    select1.Items.Add(new SelectItem(hang,hang));
                }

               
              
                
                
            }
        }
    }
}
