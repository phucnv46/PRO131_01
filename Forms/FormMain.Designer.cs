namespace PRO131_01.Forms
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AntdUI.MenuItem menuItem1 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem2 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem3 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem4 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem5 = new AntdUI.MenuItem();
            menu1 = new AntdUI.Menu();
            panel1 = new AntdUI.Panel();
            SuspendLayout();
            // 
            // menu1
            // 
            menu1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            menu1.Font = new Font("Segoe UI", 12F);
            menuItem1.ID = "bh";
            menuItem1.Text = "Bán hàng";
            menuItem2.ID = "sp";
            menuItem2.Text = "Quản lý sản phẩm";
            menuItem3.ID = "hd";
            menuItem3.Text = "Quản lý hóa đơn";
            menuItem4.ID = "nv";
            menuItem4.Text = "Quản lý nhân viên";
            menuItem5.ID = "bc";
            menuItem5.Text = "Báo cáo thống kê";
            menu1.Items.Add(menuItem1);
            menu1.Items.Add(menuItem2);
            menu1.Items.Add(menuItem3);
            menu1.Items.Add(menuItem4);
            menu1.Items.Add(menuItem5);
            menu1.Location = new Point(1, 69);
            menu1.Name = "menu1";
            menu1.Size = new Size(513, 1020);
            menu1.TabIndex = 0;
            menu1.Text = "menu1";
            menu1.SelectChanged += menu1_SelectChanged;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Location = new Point(520, 69);
            panel1.Name = "panel1";
            panel1.Size = new Size(1504, 1029);
            panel1.TabIndex = 1;
            panel1.Text = "panel1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2024, 1095);
            Controls.Add(panel1);
            Controls.Add(menu1);
            Name = "FormMain";
            Text = "FormMain";
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Menu menu1;
        private AntdUI.Panel panel1;
    }
}