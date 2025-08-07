using PRO131_01.Models;
using PRO131_01.Services;

namespace PRO131_01
{
    public partial class Form1 : Form
    {
        SanPhamService _sanPhamservice;
        public Form1()
        {
            InitializeComponent();
            _sanPhamservice = new SanPhamService();
            LoadTable();
        }


        private void LoadTable()
        {
            dataGridView1.DataSource = _sanPhamservice.GetProductsWithInclude(nameof(SanPham.MaLoaiSanPhamNavigation));
            comboBoxLoaiSP.DataSource = _sanPhamservice.GetProductTypes();
            comboBoxLoaiSP.ValueMember = nameof(LoaiSanPham.MaLoai);
            comboBoxLoaiSP.DisplayMember = nameof(LoaiSanPham.TenLoai);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.CurrentRow.DataBoundItem is SanPham sanPham)
            {
                textBoxMa.Text = sanPham.MaSanPham;
                textBoxTen.Text = sanPham.TenSanPham;
                numericUpDownSoLuong.Value = sanPham.SoLuong;
                comboBoxLoaiSP.SelectedValue = sanPham.MaLoaiSanPham;
            }
        }
    }
}
