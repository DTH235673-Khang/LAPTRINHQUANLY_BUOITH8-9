using ClosedXML.Excel;
using Microsoft.IdentityModel.Tokens;
using QuanLyBanHang.Data;
using QuanLyBanHang.Reports;
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
    public partial class frmHoaDon : Form
    {
        QLBHDbContext context = new QLBHDbContext();  // Khởi tạo biến ngữ cảnh CSDL
        int id;
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            helpProvider1.HelpNamespace = "HuongDanSuDung/nhanvien.html";
            helpProvider1.SetShowHelp(this, true);
            dataGridView.AutoGenerateColumns = false;
            List<DanhSachHoaDon> hd = new List<DanhSachHoaDon>();
            hd = context.HoaDon.Select(r => new DanhSachHoaDon
            {
                ID = r.ID,
                NhanVienID = r.NhanVienID,
                HoVaTenNhanVien = r.NhanVien.HoVaTen,
                KhachHangID = r.KhachHangID,
                HoVaTenKhachHang = r.KhachHang.HoVaTen,
                NgayLap = r.NgayLap,
                GhiChuHoaDon = r.GhiChuHoaDon,
                TongTienHoaDon = r.HoaDonChiTiet.Sum(r => r.SoLuongBan * r.DonGiaBan),
                XemChiTiet = "Xem chi tiết"
            }).ToList();
            dataGridView.DataSource = hd;
        }

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            using (frmHoaDon_ChiTiet chiTiet = new frmHoaDon_ChiTiet())
            {
                chiTiet.ShowDialog();
                frmHoaDon_Load(sender, e);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
            using (frmHoaDon_ChiTiet chiTiet = new frmHoaDon_ChiTiet(id))
            {
                chiTiet.ShowDialog();
                frmHoaDon_Load(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
            if (id.ToString().IsNullOrEmpty())
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                if (MessageBox.Show("Xác nhận xóa hóa đơn " + id + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.Yes)
                {
                    id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
                    HoaDon hoadon = context.HoaDon.Find(id);
                    if (hoadon != null)
                    {
                        context.HoaDon.Remove(hoadon);
                    }
                    context.SaveChanges();
                    frmHoaDon_Load(sender, e);
                }
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnNhap_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Nhập dữ liệu từ tập tin Excel";
            openFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (XLWorkbook workbook = new XLWorkbook(openFileDialog.FileName))
                    {
                        DataTable table1 = new DataTable();
                        IXLWorksheet worksheet1 = workbook.Worksheet(1); // Lấy sheet 1
                        bool firstRow1 = true;
                        foreach (IXLRow row in worksheet1.RowsUsed())
                        {
                            if (firstRow1)
                            {
                                foreach (IXLCell cell in row.CellsUsed()) table1.Columns.Add(cell.Value.ToString());
                                firstRow1 = false;
                            }
                            else
                            {
                                table1.Rows.Add(row.Cells(1, table1.Columns.Count).Select(c => c.Value.ToString()).ToArray());
                            }
                        }

                        if (table1.Rows.Count > 0)
                        {
                            foreach (DataRow r in table1.Rows)
                            {
                                var nv = context.NhanVien.FirstOrDefault(x => x.HoVaTen == r["NhanVien"].ToString());
                                var kh = context.KhachHang.FirstOrDefault(x => x.HoVaTen == r["KhachHang"].ToString());

                                if (nv != null && kh != null)
                                {
                                    HoaDon hd = new HoaDon();
                                    hd.NhanVienID = nv.ID;
                                    hd.KhachHangID = kh.ID;
                                    hd.NgayLap = Convert.ToDateTime(r["NgayLap"]);
                                    hd.GhiChuHoaDon = r["GhiChuHoaDon"].ToString();
                                    hd.TongTienHoaDon = Convert.ToDouble(r["TongTienHoaDon"]);
                                    context.HoaDon.Add(hd);
                                }
                            }
                            context.SaveChanges(); // Lưu hóa đơn trước để có ID
                        }

                        DataTable table2 = new DataTable();
                        IXLWorksheet worksheet2 = workbook.Worksheet(2); // Lấy sheet 2
                        bool firstRow2 = true;
                        foreach (IXLRow row in worksheet2.RowsUsed())
                        {
                            if (firstRow2)
                            {
                                foreach (IXLCell cell in row.CellsUsed()) table2.Columns.Add(cell.Value.ToString());
                                firstRow2 = false;
                            }
                            else
                            {
                                table2.Rows.Add(row.Cells(1, table2.Columns.Count).Select(c => c.Value.ToString()).ToArray());
                            }
                        }

                        if (table2.Rows.Count > 0)
                        {
                            foreach (DataRow r2 in table2.Rows) // Chạy vòng lặp riêng cho bảng 2
                            {
                                string tenSP = r2["SanPham"].ToString();
                                var sp = context.SanPham.FirstOrDefault(x => x.TenSanPham == tenSP);

                                if (sp != null)
                                {
                                    HoaDonChiTiet ct = new HoaDonChiTiet();
                                    ct.HoaDonID = Convert.ToInt32(r2["ID"]); // Cột liên kết trong Excel
                                    ct.SanPhamID = sp.ID;
                                    ct.SoLuongBan = Convert.ToInt32(r2["SoLuong"]);
                                    ct.DonGiaBan = Convert.ToInt32(r2["DonGia"]);
                                    context.HoaDonChiTiet.Add(ct);
                                }
                            }
                            context.SaveChanges();
                        }

                        MessageBox.Show("Đã nhập thành công " + table1.Rows.Count + " hóa đơn và " + table2.Rows.Count + " chi tiết.", "Thành công");
                        frmHoaDon_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo lỗi");
                }
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất dữ liệu ra tập tin Excel";
            saveFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            saveFileDialog.FileName = "BaoCaoHoaDon_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // --- XỬ LÝ TABLE 1: HÓA ĐƠN ---
                    DataTable tableHD = new DataTable();
                    tableHD.Columns.AddRange(new DataColumn[] {
                new DataColumn("ID", typeof(int)),
                new DataColumn("NhanVien", typeof(string)),
                new DataColumn("KhachHang", typeof(string)),
                new DataColumn("NgayLap", typeof(DateTime)),
                new DataColumn("GhiChuHoaDon", typeof(string)),
                new DataColumn("TongTienHoaDon",typeof(double))
            });

                    var dsHoaDon = context.HoaDon.ToList();
                    if (dsHoaDon != null)
                    {
                        foreach (var p in dsHoaDon)
                        {
                            var nv = context.NhanVien.FirstOrDefault(r => r.ID == p.NhanVienID);
                            var kh = context.KhachHang.FirstOrDefault(r => r.ID == p.KhachHangID);
                            tableHD.Rows.Add(p.ID, nv.HoVaTen, kh.HoVaTen, p.NgayLap, p.GhiChuHoaDon, p.TongTienHoaDon);
                        }
                    }

                    // --- XỬ LÝ TABLE 2: CHI TIẾT HÓA ĐƠN ---
                    DataTable tableCT = new DataTable();
                    tableCT.Columns.AddRange(new DataColumn[] {
                new DataColumn("ID", typeof(int)),
                new DataColumn("SanPham", typeof(string)),
                new DataColumn("SoLuong", typeof(int)),
                new DataColumn("DonGia", typeof(int))
            });

                    var dsChiTiet = context.HoaDonChiTiet.ToList();
                    if (dsChiTiet != null)
                    {
                        foreach (var d in dsChiTiet)
                        {
                            var sp = context.SanPham.FirstOrDefault(r => r.ID == d.SanPhamID);
                            tableCT.Rows.Add(d.HoaDonID, sp.TenSanPham, d.SoLuongBan, d.DonGiaBan);
                        }
                    }

                    // --- XUẤT RA FILE EXCEL ---
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        // Thêm Sheet 1 từ tableHD
                        var sheet1 = wb.Worksheets.Add(tableHD, "HoaDon");
                        sheet1.Columns().AdjustToContents();

                        // Thêm Sheet 2 từ tableCT
                        var sheet2 = wb.Worksheets.Add(tableCT, "HoaDonChiTiet");
                        sheet2.Columns().AdjustToContents();

                        wb.SaveAs(saveFileDialog.FileName);
                        MessageBox.Show("Đã xuất dữ liệu ra 2 Sheet thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
            using (frmInHoaDon inHoaDon = new frmInHoaDon(id))
            {
                inHoaDon.ShowDialog();
            }
        }
    }
}

