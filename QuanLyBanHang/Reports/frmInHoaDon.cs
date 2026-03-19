using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using QuanLyBanHang.Data;
using Microsoft.Reporting.WinForms;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
namespace QuanLyBanHang.Reports
{
    public partial class frmInHoaDon : Form
    {
        QLBHDbContext context = new QLBHDbContext();
        QLBHDataSet.DanhSachHoaDon_ChiTietDataTable danhSachHoaDon_ChiTietDataTable = new QLBHDataSet.DanhSachHoaDon_ChiTietDataTable();
        string reportsFolder = Application.StartupPath.Replace("bin\\Debug\\net8.0-windows", "Reports");
        int id; // Mã hóa đơn
        public frmInHoaDon(int maHoaDon = 0)
        {
            InitializeComponent();
            id = maHoaDon;
        }
        private void frmInHoaDon_Load(object sender, EventArgs e)
        {
            var hoaDon = context.HoaDon.Include(r => r.KhachHang).Include(r => r.HoaDonChiTiet)
            .Where(r => r.ID == id).SingleOrDefault();
            if (hoaDon != null)
            {
                var hoaDonChiTiet = context.HoaDonChiTiet.Where(r => r.HoaDonID == id).Select(r => new DanhSachHoaDon_ChiTiet
                {
                    ID = r.ID,
                    HoaDonID = r.HoaDonID,
                    SanPhamID = r.SanPhamID,
                    TenSanPham = r.SanPham.TenSanPham,
                    SoLuongBan = r.SoLuongBan,
                    DonGiaBan = r.DonGiaBan,
                    ThanhTien = Convert.ToInt32(r.SoLuongBan * r.DonGiaBan)
                }).ToList();
                danhSachHoaDon_ChiTietDataTable.Clear();
                foreach (var row in hoaDonChiTiet)
                {
                    danhSachHoaDon_ChiTietDataTable.AddDanhSachHoaDon_ChiTietRow(row.ID,
                    row.HoaDonID,
                    row.SanPhamID,
                    row.TenSanPham,
                    row.SoLuongBan,
                    row.DonGiaBan,
                    row.ThanhTien);
                }
                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Name = "DanhSachHoaDon_ChiTiet";
                reportDataSource.Value = danhSachHoaDon_ChiTietDataTable;
                reportViewer.LocalReport.DataSources.Clear();
                reportViewer.LocalReport.DataSources.Add(reportDataSource);
                reportViewer.LocalReport.ReportPath = Path.Combine(reportsFolder, "rptInHoaDon.rdlc");
                IList<ReportParameter> param = new List<ReportParameter>
                {
                    new ReportParameter("NgayLap", string.Format("Ngày {0} Tháng {1} Năm {2}",
                    hoaDon.NgayLap.Day,
                    hoaDon.NgayLap.Month,
                    hoaDon.NgayLap.Year)),
                    new ReportParameter("NguoiBan_Ten", "CÔNG TY TNHH LAZY ANT"),
                    new ReportParameter("NguoiBan_DiaChi", "Mỹ Phước, TP. Long Xuyên, An Giang"),
                    new ReportParameter("NguoiBan_MaSoThue", "1602162070"),
                    new ReportParameter("NguoiMua_Ten", hoaDon.KhachHang.HoVaTen),
                    new ReportParameter("NguoiMua_DiaChi", hoaDon.KhachHang.DiaChi),
                    new ReportParameter("NguoiMua_MaSoThue", ""),
                    new ReportParameter("TongTien", hoaDon.HoaDonChiTiet.Sum(r => r.SoLuongBan * r.DonGiaBan).ToString())
                };
                reportViewer.LocalReport.SetParameters(param);
                reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer.ZoomMode = ZoomMode.Percent;
                reportViewer.ZoomPercent = 100;
                reportViewer.RefreshReport();
            }
        }
    }
}