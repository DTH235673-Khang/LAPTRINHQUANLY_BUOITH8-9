namespace QuanLyBanHang.Reports
{
    partial class frmThongKeSanPham
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
            reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            label1 = new Label();
            cboHangSanXuat = new ComboBox();
            label2 = new Label();
            cboLoaiSanPham = new ComboBox();
            btnLocKetQua = new Button();
            SuspendLayout();
            // 
            // reportViewer
            // 
            reportViewer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            reportViewer.Location = new Point(0, 58);
            reportViewer.Margin = new Padding(3, 2, 3, 2);
            reportViewer.Name = "reportViewer";
            reportViewer.ServerReport.BearerToken = null;
            reportViewer.Size = new Size(800, 392);
            reportViewer.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 25);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 1;
            label1.Text = "Hãng sản xuất:";
            // 
            // cboHangSanXuat
            // 
            cboHangSanXuat.FormattingEnabled = true;
            cboHangSanXuat.Location = new Point(167, 22);
            cboHangSanXuat.Name = "cboHangSanXuat";
            cboHangSanXuat.Size = new Size(154, 23);
            cboHangSanXuat.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(349, 25);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 3;
            label2.Text = "Loại sản phẩm:";
            // 
            // cboLoaiSanPham
            // 
            cboLoaiSanPham.FormattingEnabled = true;
            cboLoaiSanPham.Location = new Point(442, 22);
            cboLoaiSanPham.Name = "cboLoaiSanPham";
            cboLoaiSanPham.Size = new Size(154, 23);
            cboLoaiSanPham.TabIndex = 4;
            // 
            // btnLocKetQua
            // 
            btnLocKetQua.Location = new Point(642, 21);
            btnLocKetQua.Name = "btnLocKetQua";
            btnLocKetQua.Size = new Size(93, 23);
            btnLocKetQua.TabIndex = 5;
            btnLocKetQua.Text = "Lọc kết quả";
            btnLocKetQua.UseVisualStyleBackColor = true;
            btnLocKetQua.Click += btnLocKetQua_Click;
            // 
            // frmThongKeSanPham
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLocKetQua);
            Controls.Add(cboLoaiSanPham);
            Controls.Add(label2);
            Controls.Add(cboHangSanXuat);
            Controls.Add(label1);
            Controls.Add(reportViewer);
            Name = "frmThongKeSanPham";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thống kê sản phẩm";
            Load += frmThongKeSanPham_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private Label label1;
        private ComboBox cboHangSanXuat;
        private Label label2;
        private ComboBox cboLoaiSanPham;
        private Button btnLocKetQua;
    }
}