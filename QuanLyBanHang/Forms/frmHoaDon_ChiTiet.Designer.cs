namespace QuanLyBanHang.Forms
{
    partial class frmHoaDon_ChiTiet
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            txtGhiChuHoaDon = new TextBox();
            label3 = new Label();
            cboKhachHang = new ComboBox();
            label2 = new Label();
            cboNhanVien = new ComboBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnThoat = new Button();
            btnInHoaDon = new Button();
            btnLuuHoaDon = new Button();
            groupBox3 = new GroupBox();
            dataGridView = new DataGridView();
            SanPhamID = new DataGridViewTextBoxColumn();
            TenSanPham = new DataGridViewTextBoxColumn();
            DonGiaBan = new DataGridViewTextBoxColumn();
            SoLuongBan = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();
            btnXoa = new Button();
            btnXacNhanBan = new Button();
            numSoLuongBan = new NumericUpDown();
            label6 = new Label();
            numDonGiaBan = new NumericUpDown();
            label5 = new Label();
            cboSanPham = new ComboBox();
            label4 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuongBan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDonGiaBan).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(txtGhiChuHoaDon);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cboKhachHang);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cboNhanVien);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(8, 14);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(804, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin hóa đơn";
            // 
            // txtGhiChuHoaDon
            // 
            txtGhiChuHoaDon.Location = new Point(109, 56);
            txtGhiChuHoaDon.Name = "txtGhiChuHoaDon";
            txtGhiChuHoaDon.Size = new Size(681, 23);
            txtGhiChuHoaDon.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 59);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 4;
            label3.Text = "Ghi chú hóa đơn:";
            // 
            // cboKhachHang
            // 
            cboKhachHang.FormattingEnabled = true;
            cboKhachHang.Location = new Point(506, 20);
            cboKhachHang.Name = "cboKhachHang";
            cboKhachHang.Size = new Size(284, 23);
            cboKhachHang.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(414, 23);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 2;
            label2.Text = "Khách hàng(*):";
            // 
            // cboNhanVien
            // 
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(109, 20);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(284, 23);
            cboNhanVien.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 23);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 0;
            label1.Text = "Nhân viên lập(*):";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(btnThoat);
            groupBox2.Controls.Add(btnInHoaDon);
            groupBox2.Controls.Add(btnLuuHoaDon);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnXacNhanBan);
            groupBox2.Controls.Add(numSoLuongBan);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(numDonGiaBan);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(cboSanPham);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(8, 120);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(804, 318);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin chi tiết hóa đơn";
            // 
            // btnThoat
            // 
            btnThoat.ForeColor = Color.Red;
            btnThoat.Location = new Point(466, 289);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(100, 23);
            btnThoat.TabIndex = 16;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnInHoaDon
            // 
            btnInHoaDon.ForeColor = Color.Black;
            btnInHoaDon.Location = new Point(360, 289);
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.Size = new Size(100, 23);
            btnInHoaDon.TabIndex = 15;
            btnInHoaDon.Text = "In Hóa Đơn...";
            btnInHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnLuuHoaDon
            // 
            btnLuuHoaDon.ForeColor = Color.Blue;
            btnLuuHoaDon.Location = new Point(254, 289);
            btnLuuHoaDon.Name = "btnLuuHoaDon";
            btnLuuHoaDon.Size = new Size(100, 23);
            btnLuuHoaDon.TabIndex = 14;
            btnLuuHoaDon.Text = "Lưu Hóa Đơn";
            btnLuuHoaDon.UseVisualStyleBackColor = true;
            btnLuuHoaDon.Click += btnLuuHoaDon_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView);
            groupBox3.Location = new Point(6, 76);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(784, 204);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { SanPhamID, TenSanPham, DonGiaBan, SoLuongBan, ThanhTien });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 19);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(778, 182);
            dataGridView.TabIndex = 0;
            // 
            // SanPhamID
            // 
            SanPhamID.DataPropertyName = "SanPhamID";
            SanPhamID.HeaderText = "ID";
            SanPhamID.Name = "SanPhamID";
            // 
            // TenSanPham
            // 
            TenSanPham.DataPropertyName = "TenSanPham";
            TenSanPham.HeaderText = "Tên Sản Phẩm";
            TenSanPham.Name = "TenSanPham";
            // 
            // DonGiaBan
            // 
            DonGiaBan.DataPropertyName = "DonGiaBan";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "N2";
            DonGiaBan.DefaultCellStyle = dataGridViewCellStyle1;
            DonGiaBan.HeaderText = "Đơn Giá Bán";
            DonGiaBan.Name = "DonGiaBan";
            // 
            // SoLuongBan
            // 
            SoLuongBan.DataPropertyName = "SoLuongBan";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "N2";
            SoLuongBan.DefaultCellStyle = dataGridViewCellStyle2;
            SoLuongBan.HeaderText = "Số Lượng Bán";
            SoLuongBan.Name = "SoLuongBan";
            // 
            // ThanhTien
            // 
            ThanhTien.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Blue;
            dataGridViewCellStyle3.Format = "N2";
            ThanhTien.DefaultCellStyle = dataGridViewCellStyle3;
            ThanhTien.HeaderText = "Thành Tiền";
            ThanhTien.Name = "ThanhTien";
            // 
            // btnXoa
            // 
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(680, 48);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(80, 23);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnXacNhanBan
            // 
            btnXacNhanBan.Location = new Point(551, 48);
            btnXacNhanBan.Name = "btnXacNhanBan";
            btnXacNhanBan.Size = new Size(105, 23);
            btnXacNhanBan.TabIndex = 11;
            btnXacNhanBan.Text = "Xác nhận bán";
            btnXacNhanBan.UseVisualStyleBackColor = true;
            btnXacNhanBan.Click += btnXacNhanBan_Click;
            // 
            // numSoLuongBan
            // 
            numSoLuongBan.Location = new Point(403, 48);
            numSoLuongBan.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSoLuongBan.Name = "numSoLuongBan";
            numSoLuongBan.Size = new Size(120, 23);
            numSoLuongBan.TabIndex = 10;
            numSoLuongBan.TabStop = false;
            numSoLuongBan.ThousandsSeparator = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(403, 30);
            label6.Name = "label6";
            label6.Size = new Size(93, 15);
            label6.TabIndex = 9;
            label6.Text = "Số lượng bán(*):";
            // 
            // numDonGiaBan
            // 
            numDonGiaBan.Location = new Point(267, 48);
            numDonGiaBan.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numDonGiaBan.Name = "numDonGiaBan";
            numDonGiaBan.Size = new Size(120, 23);
            numDonGiaBan.TabIndex = 8;
            numDonGiaBan.ThousandsSeparator = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(267, 30);
            label5.Name = "label5";
            label5.Size = new Size(87, 15);
            label5.TabIndex = 7;
            label5.Text = "Đơn giá bán(*):";
            // 
            // cboSanPham
            // 
            cboSanPham.FormattingEnabled = true;
            cboSanPham.Location = new Point(43, 48);
            cboSanPham.Name = "cboSanPham";
            cboSanPham.Size = new Size(201, 23);
            cboSanPham.TabIndex = 6;
            cboSanPham.SelectionChangeCommitted += cboSanPham_SelectionChangeCommitted;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 30);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 6;
            label4.Text = "Sản phẩm(*):";
            // 
            // frmHoaDon_ChiTiet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmHoaDon_ChiTiet";
            Text = "Hóa đơn chi tiết";
            Load += frmHoaDon_ChiTiet_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuongBan).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDonGiaBan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtGhiChuHoaDon;
        private Label label3;
        private ComboBox cboKhachHang;
        private Label label2;
        private ComboBox cboNhanVien;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnXoa;
        private Button btnXacNhanBan;
        private NumericUpDown numSoLuongBan;
        private Label label6;
        private NumericUpDown numDonGiaBan;
        private Label label5;
        private ComboBox cboSanPham;
        private Label label4;
        private GroupBox groupBox3;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn SanPhamID;
        private DataGridViewTextBoxColumn TenSanPham;
        private DataGridViewTextBoxColumn DonGiaBan;
        private DataGridViewTextBoxColumn SoLuongBan;
        private DataGridViewTextBoxColumn ThanhTien;
        private Button btnThoat;
        private Button btnInHoaDon;
        private Button btnLuuHoaDon;
    }
}