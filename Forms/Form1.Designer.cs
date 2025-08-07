namespace PRO131_01
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            label1 = new Label();
            textBoxMa = new TextBox();
            textBoxTen = new TextBox();
            label2 = new Label();
            label3 = new Label();
            richTextBoxMoTa = new RichTextBox();
            label4 = new Label();
            label5 = new Label();
            comboBoxLoaiSP = new ComboBox();
            numericUpDownSoLuong = new NumericUpDown();
            buttonThem = new Button();
            buttonSua = new Button();
            buttonLM = new Button();
            buttonXoa = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSoLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 717);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1920, 327);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 48);
            label1.Name = "label1";
            label1.Size = new Size(122, 25);
            label1.TabIndex = 1;
            label1.Text = "Mã Sản phẩm";
            // 
            // textBoxMa
            // 
            textBoxMa.Location = new Point(223, 47);
            textBoxMa.Name = "textBoxMa";
            textBoxMa.Size = new Size(245, 31);
            textBoxMa.TabIndex = 2;
            // 
            // textBoxTen
            // 
            textBoxTen.Location = new Point(738, 48);
            textBoxTen.Name = "textBoxTen";
            textBoxTen.Size = new Size(265, 31);
            textBoxTen.TabIndex = 4;
            textBoxTen.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(578, 49);
            label2.Name = "label2";
            label2.Size = new Size(121, 25);
            label2.TabIndex = 3;
            label2.Text = "Tên sản phẩm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 217);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 5;
            label3.Text = "Mô tả";
            // 
            // richTextBoxMoTa
            // 
            richTextBoxMoTa.Location = new Point(223, 188);
            richTextBoxMoTa.Name = "richTextBoxMoTa";
            richTextBoxMoTa.Size = new Size(457, 144);
            richTextBoxMoTa.TabIndex = 6;
            richTextBoxMoTa.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1165, 51);
            label4.Name = "label4";
            label4.Size = new Size(85, 25);
            label4.TabIndex = 7;
            label4.Text = "Số lượng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(816, 181);
            label5.Name = "label5";
            label5.Size = new Size(127, 25);
            label5.TabIndex = 9;
            label5.Text = "Loại sản phẩm";
            // 
            // comboBoxLoaiSP
            // 
            comboBoxLoaiSP.FormattingEnabled = true;
            comboBoxLoaiSP.Location = new Point(975, 178);
            comboBoxLoaiSP.Name = "comboBoxLoaiSP";
            comboBoxLoaiSP.Size = new Size(308, 33);
            comboBoxLoaiSP.TabIndex = 10;
            // 
            // numericUpDownSoLuong
            // 
            numericUpDownSoLuong.Location = new Point(1274, 55);
            numericUpDownSoLuong.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numericUpDownSoLuong.Name = "numericUpDownSoLuong";
            numericUpDownSoLuong.Size = new Size(268, 31);
            numericUpDownSoLuong.TabIndex = 11;
            // 
            // buttonThem
            // 
            buttonThem.Location = new Point(356, 447);
            buttonThem.Name = "buttonThem";
            buttonThem.Size = new Size(112, 34);
            buttonThem.TabIndex = 12;
            buttonThem.Text = "Thêm";
            buttonThem.UseVisualStyleBackColor = true;
            buttonThem.Click += buttonThem_Click;
            // 
            // buttonSua
            // 
            buttonSua.Location = new Point(588, 447);
            buttonSua.Name = "buttonSua";
            buttonSua.Size = new Size(112, 34);
            buttonSua.TabIndex = 13;
            buttonSua.Text = "Sửa";
            buttonSua.UseVisualStyleBackColor = true;
            buttonSua.Click += buttonSua_Click;
            // 
            // buttonLM
            // 
            buttonLM.Location = new Point(1018, 447);
            buttonLM.Name = "buttonLM";
            buttonLM.Size = new Size(112, 34);
            buttonLM.TabIndex = 15;
            buttonLM.Text = "Làm mới";
            buttonLM.UseVisualStyleBackColor = true;
            buttonLM.Click += buttonLM_Click;
            // 
            // buttonXoa
            // 
            buttonXoa.Location = new Point(786, 447);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(112, 34);
            buttonXoa.TabIndex = 14;
            buttonXoa.Text = "Xóa";
            buttonXoa.UseVisualStyleBackColor = true;
            buttonXoa.Click += buttonXoa_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(1437, 155);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(379, 326);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 1044);
            Controls.Add(pictureBox1);
            Controls.Add(buttonLM);
            Controls.Add(buttonXoa);
            Controls.Add(buttonSua);
            Controls.Add(buttonThem);
            Controls.Add(numericUpDownSoLuong);
            Controls.Add(comboBoxLoaiSP);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(richTextBoxMoTa);
            Controls.Add(label3);
            Controls.Add(textBoxTen);
            Controls.Add(label2);
            Controls.Add(textBoxMa);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textBoxMa;
        private TextBox textBoxTen;
        private Label label2;
        private Label label3;
        private RichTextBox richTextBoxMoTa;
        private Label label4;
        private Label label5;
        private ComboBox comboBoxLoaiSP;
        private NumericUpDown numericUpDownSoLuong;
        private Button buttonThem;
        private Button buttonSua;
        private Button buttonLM;
        private Button buttonXoa;
        private PictureBox pictureBox1;
    }
}
