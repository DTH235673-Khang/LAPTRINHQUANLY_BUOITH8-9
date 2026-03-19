using QuanLyBanHang.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.Forms
{
    public partial class frmHoaDon_ChiTiet : Form
    {
        QLBHDbContext context = new QLBHDbContext();  // Khởi tạo biến ngữ cảnh CSDL
        int id;  // Lấy mã hóa đơn (dùng cho Sửa và Xóa)
        BindingList<DanhSachHoaDon_ChiTiet> hoaDonChiTiet = new BindingList<DanhSachHoaDon_ChiTiet>();
        public frmHoaDon_ChiTiet()
        {
            InitializeComponent();
        }
        public frmHoaDon_ChiTiet(int maHoaDon = 0)
        {
            InitializeComponent();
            id = maHoaDon;
        }
        public void LayNhanVienVaoComboBox()
        {
            cboNhanVien.DataSource = context.NhanVien.ToList();
            cboNhanVien.ValueMember = "ID";
            cboNhanVien.DisplayMember = "HoVaTen";
        }
        public void LayKhachHangVaoComboBox()
        {
            cboKhachHang.DataSource = context.KhachHang.ToList();
            cboKhachHang.ValueMember = "ID";
            cboKhachHang.DisplayMember = "HoVaTen";
        }
        public void LaySanPhamVaoComboBox()
        {
            cboSanPham.DataSource = context.SanPham.ToList();
            cboSanPham.ValueMember = "ID";
            cboSanPham.DisplayMember = "TenSanPham";
        }
        public void BatTatChucNang()
        {
            if (id == 0 && dataGridView.Rows.Count == 0) // Thêm
            {
                // Xóa trắng các trường
                cboKhachHang.Text = "";
                cboNhanVien.Text = "";
                cboSanPham.Text = "";
                numSoLuongBan.Value = 1;
                numDonGiaBan.Value = 0;
            }
            // Nút lưu và xóa chỉ sáng khi có sản phẩm
            btnLuuHoaDon.Enabled = dataGridView.Rows.Count > 0;
            btnXoa.Enabled = dataGridView.Rows.Count > 0;
        }

        private void frmHoaDon_ChiTiet_Load(object sender, EventArgs e)
        {
            helpProvider1.HelpNamespace = "HuongDanSuDung/nhanvien.html";
            helpProvider1.SetShowHelp(this, true);
            LayNhanVienVaoComboBox();
            LayKhachHangVaoComboBox();
            LaySanPhamVaoComboBox();
            dataGridView.AutoGenerateColumns = false;
            if (id != 0) // Đã tồn tại chi tiết
            {
                var hoaDon = context.HoaDon.Where(r => r.ID == id).SingleOrDefault();
                cboNhanVien.SelectedValue = hoaDon.NhanVienID;
                cboKhachHang.SelectedValue = hoaDon.KhachHangID;
                txtGhiChuHoaDon.Text = hoaDon.GhiChuHoaDon;
                var ct = context.HoaDonChiTiet.Where(r => r.HoaDonID == id).Select(r => new DanhSachHoaDon_ChiTiet
                {
                    ID = r.ID,
                    HoaDonID = r.HoaDonID,
                    SanPhamID = r.SanPhamID,
                    TenSanPham = r.SanPham.TenSanPham,
                    SoLuongBan = r.SoLuongBan,
                    DonGiaBan = r.DonGiaBan,
                    ThanhTien = Convert.ToInt32(r.SoLuongBan * r.DonGiaBan)
                }).ToList();
                hoaDonChiTiet = new BindingList<DanhSachHoaDon_ChiTiet>(ct);
            }
            dataGridView.DataSource = hoaDonChiTiet;
            BatTatChucNang();
        }
        private void btnXacNhanBan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboSanPham.Text))
                MessageBox.Show("Vui lòng chọn sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (numSoLuongBan.Value <= 0)
                MessageBox.Show("Số lượng bán phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (numDonGiaBan.Value <= 0)
                MessageBox.Show("Đơn giá bán sản phẩm phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            {
                int maSanPham = Convert.ToInt32(cboSanPham.SelectedValue.ToString());
                var chiTiet = hoaDonChiTiet.FirstOrDefault(x => x.SanPhamID == maSanPham);
                // Nếu đã tồn tại sản phẩm thì cập nhật thông tin 
                if (chiTiet != null)
                {
                    chiTiet.SoLuongBan = Convert.ToInt32(numSoLuongBan.Value);
                    chiTiet.DonGiaBan = Convert.ToInt32(numDonGiaBan.Value);
                    chiTiet.ThanhTien = Convert.ToInt32(numSoLuongBan.Value * numDonGiaBan.Value);
                    dataGridView.Refresh();
                }
                else // Nếu chưa có sản phẩm thì thêm vào
                {
                    // Nếu chưa có sản phẩm nào
                    DanhSachHoaDon_ChiTiet ct = new DanhSachHoaDon_ChiTiet
                    {
                        ID = 0,
                        HoaDonID = id,
                        SanPhamID = maSanPham,
                        TenSanPham = cboSanPham.Text,
                        SoLuongBan = Convert.ToInt32(numSoLuongBan.Value),
                        DonGiaBan = Convert.ToInt32(numDonGiaBan.Value),
                        ThanhTien = Convert.ToInt32(numSoLuongBan.Value * numDonGiaBan.Value)
                    };
                    hoaDonChiTiet.Add(ct);
                }
                BatTatChucNang();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int maSanPham = Convert.ToInt32(dataGridView.CurrentRow.Cells["SanPhamID"].Value.ToString());
            var chiTiet = hoaDonChiTiet.FirstOrDefault(x => x.SanPhamID == maSanPham);
            if (chiTiet != null)
            {
                hoaDonChiTiet.Remove(chiTiet);
            }
            BatTatChucNang();
        }

        private void btnLuuHoaDon_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboNhanVien.Text))
                MessageBox.Show("Vui lòng chọn nhân viên lập hóa đơn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(cboKhachHang.Text))
                MessageBox.Show("Vui lòng chọn khách hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (id != 0) // Đã tồn tại chi tiết thì chỉ cập nhật
                {
                    HoaDon hd = context.HoaDon.Find(id);
                    if (hd != null)
                    {
                        hd.NhanVienID = Convert.ToInt32(cboNhanVien.SelectedValue.ToString());
                        hd.KhachHangID = Convert.ToInt32(cboKhachHang.SelectedValue.ToString());
                        hd.GhiChuHoaDon = txtGhiChuHoaDon.Text;
                        context.HoaDon.Update(hd);
                        // Xóa chi tiết cũ
                        var old = context.HoaDonChiTiet.Where(r => r.HoaDonID == id).ToList();
                        context.HoaDonChiTiet.RemoveRange(old);
                        // Thêm lại chi tiết mới
                        double total = 0;
                        foreach (var item in hoaDonChiTiet.ToList())
                        {
                            HoaDonChiTiet ct = new HoaDonChiTiet();
                            ct.HoaDonID = id;
                            ct.SanPhamID = item.SanPhamID;
                            ct.SoLuongBan = item.SoLuongBan;
                            ct.DonGiaBan = item.DonGiaBan;
                            total += ct.SoLuongBan * ct.DonGiaBan;
                            context.HoaDonChiTiet.Add(ct);

                        }
                        hd.TongTienHoaDon=total;
                        context.SaveChanges();
                    }
                }
                else // Thêm mới
                {
                    HoaDon hd = new HoaDon();
                    hd.NhanVienID = Convert.ToInt32(cboNhanVien.SelectedValue.ToString());
                    hd.KhachHangID = Convert.ToInt32(cboKhachHang.SelectedValue.ToString());
                    hd.NgayLap = DateTime.Now;
                    hd.GhiChuHoaDon = txtGhiChuHoaDon.Text;
                    context.HoaDon.Add(hd);
                    context.SaveChanges();
                    // Thêm chi tiết
                    double total = 0;
                    foreach (var item in hoaDonChiTiet.ToList())
                    {
                        HoaDonChiTiet ct = new HoaDonChiTiet();
                        ct.HoaDonID = hd.ID;
                        ct.SanPhamID = item.SanPhamID;
                        ct.SoLuongBan = item.SoLuongBan;
                        ct.DonGiaBan = item.DonGiaBan;
                        total += ct.DonGiaBan*ct.SoLuongBan;
                        context.HoaDonChiTiet.Add(ct);
                    }
                    hd.TongTienHoaDon=total;
                    context.SaveChanges();
                }
                
                MessageBox.Show("Đã lưu thành công!", "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cboSanPham_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int maSanPham = Convert.ToInt32(cboSanPham.SelectedValue.ToString());
            var sanPham = context.SanPham.Find(maSanPham);
            numDonGiaBan.Value = sanPham.DonGia;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
