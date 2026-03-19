namespace QuanLyBanHang.Forms
{
    partial class frmSanPham
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            btnXoayAnh = new Button();
            btnDoiAnh = new Button();
            btnXuat = new Button();
            btnNhap = new Button();
            btnTimKiem = new Button();
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            picHinhAnh = new PictureBox();
            numDonGia = new NumericUpDown();
            numSoLuong = new NumericUpDown();
            label6 = new Label();
            label5 = new Label();
            txtMoTa = new TextBox();
            txtTenSanPham = new TextBox();
            cboHangSanXuat = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            cboLoaiSanPham = new ComboBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            TenLoai = new DataGridViewTextBoxColumn();
            TenHangSanXuat = new DataGridViewTextBoxColumn();
            TenSanPham = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            HinhAnh = new DataGridViewImageColumn();
            helpProvider1 = new HelpProvider();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btnXoayAnh);
            groupBox1.Controls.Add(btnDoiAnh);
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(picHinhAnh);
            groupBox1.Controls.Add(numDonGia);
            groupBox1.Controls.Add(numSoLuong);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtMoTa);
            groupBox1.Controls.Add(txtTenSanPham);
            groupBox1.Controls.Add(cboHangSanXuat);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cboLoaiSanPham);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(4, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(857, 181);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sản phẩm";
            // 
            // btnXoayAnh
            // 
            btnXoayAnh.Location = new Point(679, 54);
            btnXoayAnh.Name = "btnXoayAnh";
            btnXoayAnh.Size = new Size(75, 23);
            btnXoayAnh.TabIndex = 22;
            btnXoayAnh.Text = "Xoay ảnh";
            btnXoayAnh.UseVisualStyleBackColor = true;
            btnXoayAnh.Click += btnXoayAnh_Click;
            // 
            // btnDoiAnh
            // 
            btnDoiAnh.Location = new Point(679, 18);
            btnDoiAnh.Name = "btnDoiAnh";
            btnDoiAnh.Size = new Size(75, 23);
            btnDoiAnh.TabIndex = 16;
            btnDoiAnh.Text = "Đổi ảnh";
            btnDoiAnh.UseVisualStyleBackColor = true;
            btnDoiAnh.Click += btnDoiAnh_Click;
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(772, 142);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(75, 23);
            btnXuat.TabIndex = 21;
            btnXuat.Text = "Xuất...";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(693, 142);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(75, 23);
            btnNhap.TabIndex = 20;
            btnNhap.Text = "Nhập...";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(612, 142);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(75, 23);
            btnTimKiem.TabIndex = 19;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(531, 142);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 23);
            btnThoat.TabIndex = 18;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(450, 142);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(75, 23);
            btnHuyBo.TabIndex = 17;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(369, 142);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(75, 23);
            btnLuu.TabIndex = 16;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(288, 142);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 15;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(207, 142);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 14;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(126, 142);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 13;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // picHinhAnh
            // 
            picHinhAnh.Location = new Point(558, 18);
            picHinhAnh.Name = "picHinhAnh";
            picHinhAnh.Size = new Size(104, 118);
            picHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            picHinhAnh.TabIndex = 12;
            picHinhAnh.TabStop = false;
            // 
            // numDonGia
            // 
            numDonGia.Location = new Point(421, 51);
            numDonGia.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            numDonGia.Name = "numDonGia";
            numDonGia.Size = new Size(120, 23);
            numDonGia.TabIndex = 11;
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(421, 18);
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(120, 23);
            numSoLuong.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(348, 54);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 9;
            label6.Text = "Đơn giá(*):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(348, 21);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 8;
            label5.Text = "Số lượng(*):";
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(126, 113);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(415, 23);
            txtMoTa.TabIndex = 7;
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.Location = new Point(126, 84);
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.Size = new Size(415, 23);
            txtTenSanPham.TabIndex = 6;
            // 
            // cboHangSanXuat
            // 
            cboHangSanXuat.FormattingEnabled = true;
            cboHangSanXuat.Location = new Point(124, 51);
            cboHangSanXuat.Name = "cboHangSanXuat";
            cboHangSanXuat.Size = new Size(198, 23);
            cboHangSanXuat.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 119);
            label4.Name = "label4";
            label4.Size = new Size(96, 15);
            label4.TabIndex = 4;
            label4.Text = "Mô tả sản phẩm:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 87);
            label3.Name = "label3";
            label3.Size = new Size(96, 15);
            label3.TabIndex = 3;
            label3.Text = "Tên sản phẩm(*):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 54);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 2;
            label2.Text = "Hãng sản xuất(*):";
            // 
            // cboLoaiSanPham
            // 
            cboLoaiSanPham.FormattingEnabled = true;
            cboLoaiSanPham.Location = new Point(124, 18);
            cboLoaiSanPham.Name = "cboLoaiSanPham";
            cboLoaiSanPham.Size = new Size(198, 23);
            cboLoaiSanPham.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 21);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 0;
            label1.Text = "Phân loại(*):";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Location = new Point(11, 194);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(849, 226);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách sản phẩm";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, TenLoai, TenHangSanXuat, TenSanPham, SoLuong, DonGia, HinhAnh });
            dataGridView.Location = new Point(3, 19);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(843, 204);
            dataGridView.TabIndex = 0;
            dataGridView.CellFormatting += dataGridView_CellFormatting;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // TenLoai
            // 
            TenLoai.DataPropertyName = "TenLoai";
            TenLoai.HeaderText = "Phân loại";
            TenLoai.Name = "TenLoai";
            // 
            // TenHangSanXuat
            // 
            TenHangSanXuat.DataPropertyName = "TenHangSanXuat";
            TenHangSanXuat.HeaderText = "Hãng sản xuất";
            TenHangSanXuat.Name = "TenHangSanXuat";
            // 
            // TenSanPham
            // 
            TenSanPham.DataPropertyName = "TenSanPham";
            TenSanPham.HeaderText = "Tên sản phẩm";
            TenSanPham.Name = "TenSanPham";
            // 
            // SoLuong
            // 
            SoLuong.DataPropertyName = "SoLuong";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N0";
            SoLuong.DefaultCellStyle = dataGridViewCellStyle1;
            SoLuong.HeaderText = "Số lượng";
            SoLuong.Name = "SoLuong";
            // 
            // DonGia
            // 
            DonGia.DataPropertyName = "DonGia";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            DonGia.DefaultCellStyle = dataGridViewCellStyle2;
            DonGia.HeaderText = "Đơn giá";
            DonGia.Name = "DonGia";
            // 
            // HinhAnh
            // 
            HinhAnh.DataPropertyName = "HinhAnh";
            HinhAnh.HeaderText = "Hình ảnh";
            HinhAnh.Name = "HinhAnh";
            // 
            // frmSanPham
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 427);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmSanPham";
            Text = "Sản phẩm";
            Load += frmSanPham_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtMoTa;
        private TextBox txtTenSanPham;
        private ComboBox cboHangSanXuat;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cboLoaiSanPham;
        private Label label1;
        private Button btnDoiAnh;
        private Button btnXuat;
        private Button btnNhap;
        private Button btnTimKiem;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private PictureBox picHinhAnh;
        private NumericUpDown numDonGia;
        private NumericUpDown numSoLuong;
        private Label label6;
        private Label label5;
        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenLoai;
        private DataGridViewTextBoxColumn TenHangSanXuat;
        private DataGridViewTextBoxColumn TenSanPham;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewImageColumn HinhAnh;
        private Button btnXoayAnh;
        private HelpProvider helpProvider1;
    }
}