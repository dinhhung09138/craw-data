﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Stock.Database;

#nullable disable

namespace Stock.Database.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Stock.Domain.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("varchar(5)");

                    b.Property<decimal>("CurrentPrice")
                        .HasColumnType("decimal(4,2)");

                    b.Property<bool>("IsAlert")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("SectorLevel1")
                        .HasColumnType("int");

                    b.Property<int?>("SectorLevel2")
                        .HasColumnType("int");

                    b.Property<int?>("SectorLevel3")
                        .HasColumnType("int");

                    b.Property<int>("StockExchange")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Code")
                        .IsUnique()
                        .HasDatabaseName("IDX_Company_Code");

                    b.HasIndex("SectorLevel1");

                    b.HasIndex("SectorLevel2");

                    b.HasIndex("SectorLevel3");

                    b.ToTable("Company", "dbo");
                });

            modelBuilder.Entity("Stock.Domain.FinancialReport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("BVPSCoBan")
                        .HasColumnType("decimal(6,2)");

                    b.Property<decimal>("CoPhieuPhatHanh")
                        .HasColumnType("decimal(13,2)");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<decimal>("DoanhThuThuan")
                        .HasColumnType("decimal(13,2)");

                    b.Property<decimal>("EPS")
                        .HasColumnType("decimal(6,2)");

                    b.Property<decimal>("KhoiLuongCPLuuHanh")
                        .HasColumnType("decimal(13,2)");

                    b.Property<decimal>("KhoiLuongCPNiemYet")
                        .HasColumnType("decimal(13,2)");

                    b.Property<decimal>("LNSTCongTyMe")
                        .HasColumnType("decimal(13,2)");

                    b.Property<decimal>("LNSTThuNhapDN")
                        .HasColumnType("decimal(13,2)");

                    b.Property<decimal>("LNThuanTuHDKD")
                        .HasColumnType("decimal(13,2)");

                    b.Property<decimal>("LoiNhuanGop")
                        .HasColumnType("decimal(13,2)");

                    b.Property<decimal>("NoNganHan")
                        .HasColumnType("decimal(13,2)");

                    b.Property<decimal>("NoPhaiTra")
                        .HasColumnType("decimal(13,2)");

                    b.Property<decimal>("PB")
                        .HasColumnType("decimal(6,2)");

                    b.Property<decimal>("PE")
                        .HasColumnType("decimal(6,2)");

                    b.Property<decimal>("PECoBan")
                        .HasColumnType("decimal(6,2)");

                    b.Property<int>("Quarter")
                        .HasColumnType("int");

                    b.Property<decimal>("ROA")
                        .HasColumnType("decimal(6,2)");

                    b.Property<decimal>("ROE")
                        .HasColumnType("decimal(6,2)");

                    b.Property<decimal>("ROS")
                        .HasColumnType("decimal(6,2)");

                    b.Property<decimal>("TaiSanNganHan")
                        .HasColumnType("decimal(13,2)");

                    b.Property<decimal>("TongTaiSan")
                        .HasColumnType("decimal(13,2)");

                    b.Property<decimal>("VonChuSoHuu")
                        .HasColumnType("decimal(13,2)");

                    b.Property<decimal>("VonHoaThiTruong")
                        .HasColumnType("decimal(13,2)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("FinancialReport", "dbo");
                });

            modelBuilder.Entity("Stock.Domain.Sector", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<int?>("ParentIndustryId")
                        .HasColumnType("int");

                    b.Property<string>("SectorName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("UrlVietStockData")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sector", "dbo");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Level = 1,
                            SectorName = "Bán buôn",
                            UrlVietStockData = "https://finance.vietstock.vn/nganh/1-ban-buon.htm"
                        },
                        new
                        {
                            Id = 2,
                            Level = 1,
                            SectorName = "Bảo hiểm",
                            UrlVietStockData = "https://finance.vietstock.vn/nganh/2-bao-hiem.htm"
                        },
                        new
                        {
                            Id = 3,
                            Level = 1,
                            SectorName = "Bất động sản",
                            UrlVietStockData = "https://finance.vietstock.vn/nganh/3-bat-dong-san.htm"
                        },
                        new
                        {
                            Id = 4,
                            Level = 1,
                            SectorName = "Chứng khoán",
                            UrlVietStockData = "https://finance.vietstock.vn/nganh/5-chung-khoan.htm"
                        },
                        new
                        {
                            Id = 5,
                            Level = 1,
                            SectorName = "Công nghệ và thông tin",
                            UrlVietStockData = "https://finance.vietstock.vn/nganh/6-cong-nghe-va-thong-tin.htm"
                        },
                        new
                        {
                            Id = 6,
                            Level = 1,
                            SectorName = "Bán lẻ",
                            UrlVietStockData = "https://finance.vietstock.vn/nganh/7-ban-le.htm"
                        },
                        new
                        {
                            Id = 7,
                            Level = 1,
                            SectorName = "Chăm sóc sức khỏe",
                            UrlVietStockData = "https://finance.vietstock.vn/nganh/8-cham-soc-suc-khoe.htm"
                        },
                        new
                        {
                            Id = 8,
                            Level = 1,
                            SectorName = "Khai khoáng",
                            UrlVietStockData = "https://finance.vietstock.vn/nganh/10-khai-khoang.htm"
                        },
                        new
                        {
                            Id = 9,
                            Level = 1,
                            SectorName = "Ngân hàng",
                            UrlVietStockData = "https://finance.vietstock.vn/nganh/11-ngan-hang.htm"
                        },
                        new
                        {
                            Id = 10,
                            Level = 1,
                            SectorName = "Nông - Lâm - Ngư",
                            UrlVietStockData = "https://finance.vietstock.vn/nganh/12-nong-lam-ngu.htm"
                        },
                        new
                        {
                            Id = 11,
                            Level = 1,
                            SectorName = "SX Thiết bị, máy móc",
                            UrlVietStockData = "https://finance.vietstock.vn/nganh/15-sx-thiet-bi-may-moc.htm"
                        },
                        new
                        {
                            Id = 12,
                            Level = 1,
                            SectorName = "SX Hàng gia dụng",
                            UrlVietStockData = "https://finance.vietstock.vn/nganh/16-sx-hang-gia-dung.htm"
                        },
                        new
                        {
                            Id = 13,
                            Level = 1,
                            SectorName = "Sản phẩm cao su",
                            UrlVietStockData = "https://finance.vietstock.vn/nganh/17-san-pham-cao-su.htm"
                        },
                        new
                        {
                            Id = 14,
                            Level = 1,
                            SectorName = "SX Nhựa - Hóa chất",
                            UrlVietStockData = "https://finance.vietstock.vn/nganh/18-sx-nhua-hoa-chat.htm"
                        },
                        new
                        {
                            Id = 15,
                            Level = 1,
                            SectorName = "Thực phẩm - Đồ uống",
                            UrlVietStockData = "https://finance.vietstock.vn/nganh/19-thuc-pham-do-uong.htm"
                        },
                        new
                        {
                            Id = 16,
                            Level = 1,
                            SectorName = "Chế biến Thủy sản",
                            UrlVietStockData = "https://finance.vietstock.vn/nganh/20-che-bien-thuy-san.htm"
                        },
                        new
                        {
                            Id = 17,
                            Level = 1,
                            SectorName = "Vật liệu xây dựng",
                            UrlVietStockData = "https://finance.vietstock.vn/nganh/21-vat-lieu-xay-dung.htm"
                        },
                        new
                        {
                            Id = 18,
                            Level = 1,
                            SectorName = "Tiện ích",
                            UrlVietStockData = "https://finance.vietstock.vn/nganh/22-tien-ich.htm"
                        },
                        new
                        {
                            Id = 19,
                            Level = 1,
                            SectorName = "Vận tải - kho bãi",
                            UrlVietStockData = "https://finance.vietstock.vn/nganh/23-van-tai-kho-bai.htm"
                        },
                        new
                        {
                            Id = 20,
                            Level = 1,
                            SectorName = "Xây dựng",
                            UrlVietStockData = "https://finance.vietstock.vn/nganh/24-xay-dung.htm"
                        },
                        new
                        {
                            Id = 21,
                            Level = 1,
                            SectorName = "Dịch vụ lưu trú, ăn uống, giải trí",
                            UrlVietStockData = "https://finance.vietstock.vn/nganh/25-dich-vu-luu-tru-an-uong-giai-tri.htm"
                        },
                        new
                        {
                            Id = 22,
                            Level = 1,
                            SectorName = "SX Phụ trợ",
                            UrlVietStockData = "https://finance.vietstock.vn/nganh/26-sx-phu-tro.htm"
                        },
                        new
                        {
                            Id = 23,
                            Level = 1,
                            SectorName = "Thiết bị điện",
                            UrlVietStockData = "https://finance.vietstock.vn/nganh/27-thiet-bi-dien.htm"
                        },
                        new
                        {
                            Id = 24,
                            Level = 1,
                            SectorName = "Dịch vụ tư vấn, hỗ trợ",
                            UrlVietStockData = "https://finance.vietstock.vn/nganh/28-dich-vu-tu-van-ho-tro.htm"
                        },
                        new
                        {
                            Id = 25,
                            Level = 1,
                            SectorName = "Tài chính khác",
                            UrlVietStockData = "https://finance.vietstock.vn/nganh/29-tai-chinh-khac.htm"
                        });
                });

            modelBuilder.Entity("Stock.Domain.Company", b =>
                {
                    b.HasOne("Stock.Domain.Sector", "Sector1")
                        .WithMany("CompanyLevel1s")
                        .HasForeignKey("SectorLevel1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Company_SectorLevel1");

                    b.HasOne("Stock.Domain.Sector", "Sector2")
                        .WithMany("CompanyLevel2s")
                        .HasForeignKey("SectorLevel2")
                        .HasConstraintName("FK_Company_SectorLevel2");

                    b.HasOne("Stock.Domain.Sector", "Sector3")
                        .WithMany("CompanyLevel3s")
                        .HasForeignKey("SectorLevel3")
                        .HasConstraintName("FK_Company_SectorLevel3");

                    b.Navigation("Sector1");

                    b.Navigation("Sector2");

                    b.Navigation("Sector3");
                });

            modelBuilder.Entity("Stock.Domain.FinancialReport", b =>
                {
                    b.HasOne("Stock.Domain.Company", "Company")
                        .WithMany("FinancialReports")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_FinancialReport_CompanyId");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("Stock.Domain.Company", b =>
                {
                    b.Navigation("FinancialReports");
                });

            modelBuilder.Entity("Stock.Domain.Sector", b =>
                {
                    b.Navigation("CompanyLevel1s");

                    b.Navigation("CompanyLevel2s");

                    b.Navigation("CompanyLevel3s");
                });
#pragma warning restore 612, 618
        }
    }
}
