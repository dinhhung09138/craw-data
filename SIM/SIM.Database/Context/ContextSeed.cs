
using Microsoft.EntityFrameworkCore;
using System;

namespace SIM.Database
{
    public static class ContextSeed
    {
        public static void Seed(this ModelBuilder builder)
        {
            builder.SeedSector();
        }

        private static void SeedSector(this ModelBuilder builder)
        {
            builder.Entity<Sector>(m => {
                m.HasData(new
                {
                    Id = 1,
                    SectorName = "Bán buôn",
                    Level = SectorLevel.Level1,
                    UrlVietStockData = "https://finance.vietstock.vn/nganh/1-ban-buon.htm",
                });
            });
            builder.Entity<Sector>(m => {
                m.HasData(new
                {
                    Id = 2,
                    SectorName = "Bảo hiểm",
                    Level = SectorLevel.Level1,
                    UrlVietStockData = "https://finance.vietstock.vn/nganh/2-bao-hiem.htm",
                });
            });
            builder.Entity<Sector>(m => {
                m.HasData(new
                {
                    Id = 3,
                    SectorName = "Bất động sản",
                    Level = SectorLevel.Level1,
                    UrlVietStockData = "https://finance.vietstock.vn/nganh/3-bat-dong-san.htm",
                });
            });
            builder.Entity<Sector>(m => {
                m.HasData(new
                {
                    Id = 4,
                    SectorName = "Chứng khoán",
                    Level = SectorLevel.Level1,
                    UrlVietStockData = "https://finance.vietstock.vn/nganh/5-chung-khoan.htm",
                });
            });
            builder.Entity<Sector>(m => {
                m.HasData(new
                {
                    Id = 5,
                    SectorName = "Công nghệ và thông tin",
                    Level = SectorLevel.Level1,
                    UrlVietStockData = "https://finance.vietstock.vn/nganh/6-cong-nghe-va-thong-tin.htm",
                });
            });
            builder.Entity<Sector>(m => {
                m.HasData(new
                {
                    Id = 6,
                    SectorName = "Bán lẻ",
                    Level = SectorLevel.Level1,
                    UrlVietStockData = "https://finance.vietstock.vn/nganh/7-ban-le.htm",
                });
            });
            builder.Entity<Sector>(m => {
                m.HasData(new
                {
                    Id = 7,
                    SectorName = "Chăm sóc sức khỏe",
                    Level = SectorLevel.Level1,
                    UrlVietStockData = "https://finance.vietstock.vn/nganh/8-cham-soc-suc-khoe.htm",
                });
            });
            builder.Entity<Sector>(m => {
                m.HasData(new
                {
                    Id = 8,
                    SectorName = "Khai khoáng",
                    Level = SectorLevel.Level1,
                    UrlVietStockData = "https://finance.vietstock.vn/nganh/10-khai-khoang.htm",
                });
            });
            builder.Entity<Sector>(m => {
                m.HasData(new
                {
                    Id = 9,
                    SectorName = "Ngân hàng",
                    Level = SectorLevel.Level1,
                    UrlVietStockData = "https://finance.vietstock.vn/nganh/11-ngan-hang.htm",
                });
            });
            builder.Entity<Sector>(m => {
                m.HasData(new
                {
                    Id = 10,
                    SectorName = "Nông - Lâm - Ngư",
                    Level = SectorLevel.Level1,
                    UrlVietStockData = "https://finance.vietstock.vn/nganh/12-nong-lam-ngu.htm",
                });
            });
            builder.Entity<Sector>(m => {
                m.HasData(new
                {
                    Id = 11,
                    SectorName = "SX Thiết bị, máy móc",
                    Level = SectorLevel.Level1,
                    UrlVietStockData = "https://finance.vietstock.vn/nganh/15-sx-thiet-bi-may-moc.htm",
                });
            });
            builder.Entity<Sector>(m => {
                m.HasData(new
                {
                    Id = 12,
                    SectorName = "SX Hàng gia dụng",
                    Level = SectorLevel.Level1,
                    UrlVietStockData = "https://finance.vietstock.vn/nganh/16-sx-hang-gia-dung.htm",
                });
            });
            builder.Entity<Sector>(m => {
                m.HasData(new
                {
                    Id = 13,
                    SectorName = "Sản phẩm cao su",
                    Level = SectorLevel.Level1,
                    UrlVietStockData = "https://finance.vietstock.vn/nganh/17-san-pham-cao-su.htm",
                });
            });
            builder.Entity<Sector>(m => {
                m.HasData(new
                {
                    Id = 14,
                    SectorName = "SX Nhựa - Hóa chất",
                    Level = SectorLevel.Level1,
                    UrlVietStockData = "https://finance.vietstock.vn/nganh/18-sx-nhua-hoa-chat.htm",
                });
            });
            builder.Entity<Sector>(m => {
                m.HasData(new
                {
                    Id = 15,
                    SectorName = "Thực phẩm - Đồ uống",
                    Level = SectorLevel.Level1,
                    UrlVietStockData = "https://finance.vietstock.vn/nganh/19-thuc-pham-do-uong.htm",
                });
            });
            builder.Entity<Sector>(m => {
                m.HasData(new
                {
                    Id = 16,
                    SectorName = "Chế biến Thủy sản",
                    Level = SectorLevel.Level1,
                    UrlVietStockData = "https://finance.vietstock.vn/nganh/20-che-bien-thuy-san.htm",
                });
            });
            builder.Entity<Sector>(m => {
                m.HasData(new
                {
                    Id = 17,
                    SectorName = "Vật liệu xây dựng",
                    Level = SectorLevel.Level1,
                    UrlVietStockData = "https://finance.vietstock.vn/nganh/21-vat-lieu-xay-dung.htm",
                });
            });
            builder.Entity<Sector>(m => {
                m.HasData(new
                {
                    Id = 18,
                    SectorName = "Tiện ích",
                    Level = SectorLevel.Level1,
                    UrlVietStockData = "https://finance.vietstock.vn/nganh/22-tien-ich.htm",
                });
            });
            builder.Entity<Sector>(m => {
                m.HasData(new
                {
                    Id = 19,
                    SectorName = "Vận tải - kho bãi",
                    Level = SectorLevel.Level1,
                    UrlVietStockData = "https://finance.vietstock.vn/nganh/23-van-tai-kho-bai.htm",
                });
            });
            builder.Entity<Sector>(m => {
                m.HasData(new
                {
                    Id = 20,
                    SectorName = "Xây dựng",
                    Level = SectorLevel.Level1,
                    UrlVietStockData = "https://finance.vietstock.vn/nganh/24-xay-dung.htm",
                });
            });
            builder.Entity<Sector>(m => {
                m.HasData(new
                {
                    Id = 21,
                    SectorName = "Dịch vụ lưu trú, ăn uống, giải trí",
                    Level = SectorLevel.Level1,
                    UrlVietStockData = "https://finance.vietstock.vn/nganh/25-dich-vu-luu-tru-an-uong-giai-tri.htm",
                });
            });
            builder.Entity<Sector>(m => {
                m.HasData(new
                {
                    Id = 22,
                    SectorName = "SX Phụ trợ",
                    Level = SectorLevel.Level1,
                    UrlVietStockData = "https://finance.vietstock.vn/nganh/26-sx-phu-tro.htm",
                });
            });
            builder.Entity<Sector>(m => {
                m.HasData(new
                {
                    Id = 23,
                    SectorName = "Thiết bị điện",
                    Level = SectorLevel.Level1,
                    UrlVietStockData = "https://finance.vietstock.vn/nganh/27-thiet-bi-dien.htm",
                });
            });
            builder.Entity<Sector>(m => {
                m.HasData(new
                {
                    Id = 24,
                    SectorName = "Dịch vụ tư vấn, hỗ trợ",
                    Level = SectorLevel.Level1,
                    UrlVietStockData = "https://finance.vietstock.vn/nganh/28-dich-vu-tu-van-ho-tro.htm",
                });
            });
            builder.Entity<Sector>(m => {
                m.HasData(new
                {
                    Id = 25,
                    SectorName = "Tài chính khác",
                    Level = SectorLevel.Level1,
                    UrlVietStockData = "https://finance.vietstock.vn/nganh/29-tai-chinh-khac.htm",
                });
            });
        }
    }
}
