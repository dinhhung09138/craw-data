using DotNetCore.Domain;
using System;

namespace SIM.Domain
{
    /// <summary>
    /// Báo cáo tài chính, kết quả hoạt động kinh doanh
    /// </summary>
    public class FinancialReport : Entity<int>
    {
        public FinancialReport() { }

        public int CompanyId { get; set; }

        public Company Company { get; set; }

        public int Year { get; set; }

        public short Quarter { get; set; }

        public float PB { get; set; }

        public float EPS { get; set; }

        public float PE { get; set; }

        public float BVPSCoBan { get; set; }

        public float PECoBan { get; set; }

        public float ROS { get; set; }

        public float ROE { get; set; }

        public float ROA { get; set; }

        public decimal KhoiLuongCPNiemYet { get; set; }

        public decimal KhoiLuongCPLuuHanh { get; set; }

        public decimal VonHoaThiTruong { get; set; }

        public decimal CoPhieuPhatHanh { get; set; }

        public decimal DoanhThuThuan { get; set; }

        public decimal LoiNhuanGop { get; set; }

        public decimal LNThuanTuHDKD { get; set; }

        public decimal LNSTThuNhapDN { get; set; }

        public decimal LNSTCongTyMe { get; set; }

        public decimal TaiSanNganHan { get; set; }

        public decimal TongTaiSan { get; set; }

        public decimal NoPhaiTra { get; set; }

        public decimal NoNganHan { get; set; }

        public decimal VonChuSoHuu { get; set; }
    }
}
