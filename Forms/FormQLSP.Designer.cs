namespace PRO131_01.Forms
{
    partial class FormQLSP
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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            table1 = new AntdUI.Table();
            label1 = new AntdUI.Label();
            input1 = new AntdUI.Input();
            label2 = new AntdUI.Label();
            label3 = new AntdUI.Label();
            input2 = new AntdUI.Input();
            label4 = new AntdUI.Label();
            input3 = new AntdUI.Input();
            avatar1 = new AntdUI.Avatar();
            label5 = new AntdUI.Label();
            select1 = new AntdUI.Select();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(select1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(avatar1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(input3);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(input2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(input1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1742, 534);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin Giày";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(table1);
            groupBox2.Controls.Add(label1);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 534);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1742, 461);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách giày";
            // 
            // table1
            // 
            table1.Dock = DockStyle.Fill;
            table1.Gap = 12;
            table1.Location = new Point(3, 27);
            table1.Name = "table1";
            table1.Size = new Size(1736, 431);
            table1.TabIndex = 1;
            table1.Text = "table1";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 19F);
            label1.Location = new Point(521, 193);
            label1.Name = "label1";
            label1.Size = new Size(613, 94);
            label1.TabIndex = 0;
            label1.Text = "Danh sách đang trống";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // input1
            // 
            input1.Location = new Point(160, 72);
            input1.Name = "input1";
            input1.ReadOnly = true;
            input1.Size = new Size(321, 54);
            input1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Location = new Point(40, 82);
            label2.Name = "label2";
            label2.Size = new Size(112, 34);
            label2.TabIndex = 1;
            label2.Text = "Mã giày";
            // 
            // label3
            // 
            label3.Location = new Point(669, 82);
            label3.Name = "label3";
            label3.Size = new Size(112, 34);
            label3.TabIndex = 3;
            label3.Text = "Mã giày";
            // 
            // input2
            // 
            input2.Location = new Point(799, 72);
            input2.Name = "input2";
            input2.Size = new Size(311, 54);
            input2.TabIndex = 2;
            // 
            // label4
            // 
            label4.Location = new Point(30, 192);
            label4.Name = "label4";
            label4.Size = new Size(112, 34);
            label4.TabIndex = 5;
            label4.Text = "Mã giày";
            // 
            // input3
            // 
            input3.Location = new Point(160, 182);
            input3.Multiline = true;
            input3.Name = "input3";
            input3.SelectionStart = 6;
            input3.Size = new Size(321, 188);
            input3.TabIndex = 4;
            input3.Text = "input3";
            // 
            // avatar1
            // 
            avatar1.Location = new Point(1324, 89);
            avatar1.Name = "avatar1";
            avatar1.Size = new Size(376, 319);
            avatar1.TabIndex = 6;
            avatar1.Text = "a";
            // 
            // label5
            // 
            label5.Location = new Point(655, 192);
            label5.Name = "label5";
            label5.Size = new Size(112, 34);
            label5.TabIndex = 7;
            label5.Text = "Hãng";
            // 
            // select1
            // 
            select1.Location = new Point(799, 182);
            select1.Name = "select1";
            select1.SelectionStart = 4;
            select1.Size = new Size(311, 55);
            select1.TabIndex = 8;
            select1.Text = "Nhập";
            // 
            // FormQLSP
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1742, 995);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormQLSP";
            Text = "FormQLSP";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private AntdUI.Table table1;
        private AntdUI.Label label1;
        private AntdUI.Label label3;
        private AntdUI.Input input2;
        private AntdUI.Label label2;
        private AntdUI.Input input1;
        private AntdUI.Avatar avatar1;
        private AntdUI.Label label4;
        private AntdUI.Input input3;
        private AntdUI.Select select1;
        private AntdUI.Label label5;
    }
}