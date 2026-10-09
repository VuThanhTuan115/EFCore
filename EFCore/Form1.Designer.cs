namespace EFCore
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
            dgvSinhVien = new DataGridView();
            bttThem = new Button();
            bttSua = new Button();
            bttXoa = new Button();
            bttTai = new Button();
            bttLoc = new Button();
            lblHoten = new Label();
            lblDiem = new Label();
            lblQLySV = new Label();
            txtDiem = new TextBox();
            txtHoTen = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).BeginInit();
            SuspendLayout();
            // 
            // dgvSinhVien
            // 
            dgvSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSinhVien.Location = new Point(12, 207);
            dgvSinhVien.Name = "dgvSinhVien";
            dgvSinhVien.RowHeadersWidth = 51;
            dgvSinhVien.Size = new Size(776, 306);
            dgvSinhVien.TabIndex = 0;
            // 
            // bttThem
            // 
            bttThem.Location = new Point(37, 154);
            bttThem.Name = "bttThem";
            bttThem.Size = new Size(92, 37);
            bttThem.TabIndex = 1;
            bttThem.Text = "Thêm";
            bttThem.UseVisualStyleBackColor = true;
            bttThem.Click += btnThem_Click;
            // 
            // bttSua
            // 
            bttSua.Location = new Point(171, 154);
            bttSua.Name = "bttSua";
            bttSua.Size = new Size(94, 37);
            bttSua.TabIndex = 2;
            bttSua.Text = "Sửa";
            bttSua.UseVisualStyleBackColor = true;
            bttSua.Click += bttSua_Click;
            // 
            // bttXoa
            // 
            bttXoa.Location = new Point(308, 154);
            bttXoa.Name = "bttXoa";
            bttXoa.Size = new Size(94, 37);
            bttXoa.TabIndex = 3;
            bttXoa.Text = "Xóa";
            bttXoa.UseVisualStyleBackColor = true;
            bttXoa.Click += bttXoa_Click;
            // 
            // bttTai
            // 
            bttTai.Location = new Point(440, 154);
            bttTai.Name = "bttTai";
            bttTai.Size = new Size(125, 37);
            bttTai.TabIndex = 4;
            bttTai.Text = "Tải lại danh";
            bttTai.UseVisualStyleBackColor = true;
            bttTai.Click += bttTai_Click;
            // 
            // bttLoc
            // 
            bttLoc.Location = new Point(606, 154);
            bttLoc.Name = "bttLoc";
            bttLoc.Size = new Size(161, 37);
            bttLoc.TabIndex = 5;
            bttLoc.Text = "Lọc SV đạt (LINQ)";
            bttLoc.UseVisualStyleBackColor = true;
            bttLoc.Click += bttLoc_Click;
            // 
            // lblHoten
            // 
            lblHoten.AutoSize = true;
            lblHoten.Location = new Point(24, 112);
            lblHoten.Name = "lblHoten";
            lblHoten.Size = new Size(57, 20);
            lblHoten.TabIndex = 6;
            lblHoten.Text = "Họ tên:";
            // 
            // lblDiem
            // 
            lblDiem.AutoSize = true;
            lblDiem.Location = new Point(416, 116);
            lblDiem.Name = "lblDiem";
            lblDiem.Size = new Size(48, 20);
            lblDiem.TabIndex = 7;
            lblDiem.Text = "Điểm:";
            // 
            // lblQLySV
            // 
            lblQLySV.AutoSize = true;
            lblQLySV.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblQLySV.Location = new Point(101, 33);
            lblQLySV.Name = "lblQLySV";
            lblQLySV.Size = new Size(558, 38);
            lblQLySV.TabIndex = 8;
            lblQLySV.Text = "QUẢN LÝ SINH VIEN - EF CORE (ĐẦY ĐỦ)";
            // 
            // txtDiem
            // 
            txtDiem.Location = new Point(492, 113);
            txtDiem.Name = "txtDiem";
            txtDiem.Size = new Size(107, 27);
            txtDiem.TabIndex = 9;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(87, 109);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(293, 27);
            txtHoTen.TabIndex = 10;
            txtHoTen.TextChanged += txtHoTen_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 540);
            Controls.Add(txtHoTen);
            Controls.Add(txtDiem);
            Controls.Add(lblQLySV);
            Controls.Add(lblDiem);
            Controls.Add(lblHoten);
            Controls.Add(bttLoc);
            Controls.Add(bttTai);
            Controls.Add(bttXoa);
            Controls.Add(bttSua);
            Controls.Add(bttThem);
            Controls.Add(dgvSinhVien);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSinhVien;
        private Button bttThem;
        private Button bttSua;
        private Button bttXoa;
        private Button bttTai;
        private Button bttLoc;
        private Label lblHoten;
        private Label lblDiem;
        private Label lblQLySV;
        private TextBox txtDiem;
        private TextBox txtHoTen;
    }
}
