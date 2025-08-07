using PRO131_01.Models;
using PRO131_01.Services;

namespace PRO131_01
{
    public partial class Form1 : Form
    {
        SanPhamService _sanPhamservice;


        private string currentImagePath = "";
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
            if (dataGridView1.CurrentRow.DataBoundItem is SanPham sanPham)
            {
                textBoxMa.Text = sanPham.MaSanPham;
                textBoxTen.Text = sanPham.TenSanPham;
                numericUpDownSoLuong.Value = sanPham.SoLuong;
                comboBoxLoaiSP.SelectedValue = sanPham.MaLoaiSanPham;

                string path = @"../../../Images/NoImage.png";
                if (!File.Exists(path))
                {
                    path = @"../../../Images/NoImage.png";

                }
                else path = string.IsNullOrEmpty(sanPham.HinhAnh.Trim()) ? @"../../../Images/NoImage.png" : sanPham.HinhAnh;


                if (File.Exists(path))
                {
                    pictureBox1.Image = Image.FromFile(path);
                }
                currentImagePath = path;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Chọn ảnh";
                openFileDialog.Filter = "Ảnh (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string sourcePath = openFileDialog.FileName;

                    // Lấy đường dẫn thư mục "images" trong thư mục dự án
                    string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
                    string imagesFolder = Path.Combine(projectDirectory, "Images");

                    // Tạo thư mục nếu chưa có
                    if (!Directory.Exists(imagesFolder))
                    {
                        Directory.CreateDirectory(imagesFolder);
                    }

                    // Tạo tên file đích (giữ nguyên tên gốc)
                    string fileName = Path.GetFileName(sourcePath);
                    string destinationPath = Path.Combine(imagesFolder, fileName);

                    // Copy ảnh vào thư mục images (ghi đè nếu đã tồn tại)
                    File.Copy(sourcePath, destinationPath, true);

                    currentImagePath = destinationPath;

                    // Hiển thị ảnh từ thư mục images
                    pictureBox1.Image = Image.FromFile(destinationPath);
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

                }
            }

        }



        private void BindingToModel(SanPham sanPham)
        {
            sanPham.MaSanPham = textBoxMa.Text;
            sanPham.TenSanPham = textBoxTen.Text;
            sanPham.MoTa = richTextBoxMoTa.Text;
            sanPham.MaLoaiSanPham = (long)comboBoxLoaiSP.SelectedValue;
            sanPham.SoLuong = (int)numericUpDownSoLuong.Value;
            sanPham.HinhAnh = currentImagePath;
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            SanPham sanPham = new SanPham();
            BindingToModel(sanPham);
            _sanPhamservice.Them(sanPham);
            LoadTable();
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.DataBoundItem is SanPham sanPham)
            {
                int index = dataGridView1.CurrentRow.Index;
                BindingToModel(sanPham);
                _sanPhamservice.Sua(sanPham);
                LoadTable();
                dataGridView1.Rows[index].Selected = true;
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.DataBoundItem is SanPham sanPham)
            {
                _sanPhamservice.Xoa(sanPham);
                LoadTable();
            }
        }

        private void buttonLM_Click(object sender, EventArgs e)
        {
            textBoxMa.ResetText();
            textBoxTen.ResetText();
            comboBoxLoaiSP.SelectedIndex = -1;
            numericUpDownSoLuong.Value = 0;
            richTextBoxMoTa.ResetText();
            pictureBox1.Image = null;
        }
    }
}
