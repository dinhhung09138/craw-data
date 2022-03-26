using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SIM.Database.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "Sector",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SectorName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    ParentIndustryId = table.Column<int>(type: "int", nullable: true),
                    UrlVietStockData = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sector", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Company",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "varchar(5)", maxLength: 5, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    SectorLevel1 = table.Column<int>(type: "int", nullable: false),
                    SectorLevel2 = table.Column<int>(type: "int", nullable: true),
                    SectorLevel3 = table.Column<int>(type: "int", nullable: true),
                    CurrentPrice = table.Column<decimal>(type: "decimal(4,2)", nullable: false),
                    IsAlert = table.Column<bool>(type: "bit", nullable: false),
                    StockExchange = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Company_SectorLevel1",
                        column: x => x.SectorLevel1,
                        principalSchema: "dbo",
                        principalTable: "Sector",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Company_SectorLevel2",
                        column: x => x.SectorLevel2,
                        principalSchema: "dbo",
                        principalTable: "Sector",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Company_SectorLevel3",
                        column: x => x.SectorLevel3,
                        principalSchema: "dbo",
                        principalTable: "Sector",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FinancialReport",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Quarter = table.Column<int>(type: "int", nullable: false),
                    PB = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    EPS = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    PE = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    BVPSCoBan = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    PECoBan = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    ROS = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    ROE = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    ROA = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    KhoiLuongCPNiemYet = table.Column<decimal>(type: "decimal(13,2)", nullable: false),
                    KhoiLuongCPLuuHanh = table.Column<decimal>(type: "decimal(13,2)", nullable: false),
                    VonHoaThiTruong = table.Column<decimal>(type: "decimal(13,2)", nullable: false),
                    CoPhieuPhatHanh = table.Column<decimal>(type: "decimal(13,2)", nullable: false),
                    DoanhThuThuan = table.Column<decimal>(type: "decimal(13,2)", nullable: false),
                    LoiNhuanGop = table.Column<decimal>(type: "decimal(13,2)", nullable: false),
                    LNThuanTuHDKD = table.Column<decimal>(type: "decimal(13,2)", nullable: false),
                    LNSTThuNhapDN = table.Column<decimal>(type: "decimal(13,2)", nullable: false),
                    LNSTCongTyMe = table.Column<decimal>(type: "decimal(13,2)", nullable: false),
                    TaiSanNganHan = table.Column<decimal>(type: "decimal(13,2)", nullable: false),
                    TongTaiSan = table.Column<decimal>(type: "decimal(13,2)", nullable: false),
                    NoPhaiTra = table.Column<decimal>(type: "decimal(13,2)", nullable: false),
                    NoNganHan = table.Column<decimal>(type: "decimal(13,2)", nullable: false),
                    VonChuSoHuu = table.Column<decimal>(type: "decimal(13,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinancialReport", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FinancialReport_CompanyId",
                        column: x => x.CompanyId,
                        principalSchema: "dbo",
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Sector",
                columns: new[] { "Id", "Level", "ParentIndustryId", "SectorName", "UrlVietStockData" },
                values: new object[,]
                {
                    { 1, 1, null, "Bán buôn", "https://finance.vietstock.vn/nganh/1-ban-buon.htm" },
                    { 2, 1, null, "Bảo hiểm", "https://finance.vietstock.vn/nganh/2-bao-hiem.htm" },
                    { 3, 1, null, "Bất động sản", "https://finance.vietstock.vn/nganh/3-bat-dong-san.htm" },
                    { 4, 1, null, "Chứng khoán", "https://finance.vietstock.vn/nganh/5-chung-khoan.htm" },
                    { 5, 1, null, "Công nghệ và thông tin", "https://finance.vietstock.vn/nganh/6-cong-nghe-va-thong-tin.htm" },
                    { 6, 1, null, "Bán lẻ", "https://finance.vietstock.vn/nganh/7-ban-le.htm" },
                    { 7, 1, null, "Chăm sóc sức khỏe", "https://finance.vietstock.vn/nganh/8-cham-soc-suc-khoe.htm" },
                    { 8, 1, null, "Khai khoáng", "https://finance.vietstock.vn/nganh/10-khai-khoang.htm" },
                    { 9, 1, null, "Ngân hàng", "https://finance.vietstock.vn/nganh/11-ngan-hang.htm" },
                    { 10, 1, null, "Nông - Lâm - Ngư", "https://finance.vietstock.vn/nganh/12-nong-lam-ngu.htm" },
                    { 11, 1, null, "SX Thiết bị, máy móc", "https://finance.vietstock.vn/nganh/15-sx-thiet-bi-may-moc.htm" },
                    { 12, 1, null, "SX Hàng gia dụng", "https://finance.vietstock.vn/nganh/16-sx-hang-gia-dung.htm" },
                    { 13, 1, null, "Sản phẩm cao su", "https://finance.vietstock.vn/nganh/17-san-pham-cao-su.htm" },
                    { 14, 1, null, "SX Nhựa - Hóa chất", "https://finance.vietstock.vn/nganh/18-sx-nhua-hoa-chat.htm" },
                    { 15, 1, null, "Thực phẩm - Đồ uống", "https://finance.vietstock.vn/nganh/19-thuc-pham-do-uong.htm" },
                    { 16, 1, null, "Chế biến Thủy sản", "https://finance.vietstock.vn/nganh/20-che-bien-thuy-san.htm" },
                    { 17, 1, null, "Vật liệu xây dựng", "https://finance.vietstock.vn/nganh/21-vat-lieu-xay-dung.htm" },
                    { 18, 1, null, "Tiện ích", "https://finance.vietstock.vn/nganh/22-tien-ich.htm" },
                    { 19, 1, null, "Vận tải - kho bãi", "https://finance.vietstock.vn/nganh/23-van-tai-kho-bai.htm" },
                    { 20, 1, null, "Xây dựng", "https://finance.vietstock.vn/nganh/24-xay-dung.htm" },
                    { 21, 1, null, "Dịch vụ lưu trú, ăn uống, giải trí", "https://finance.vietstock.vn/nganh/25-dich-vu-luu-tru-an-uong-giai-tri.htm" },
                    { 22, 1, null, "SX Phụ trợ", "https://finance.vietstock.vn/nganh/26-sx-phu-tro.htm" },
                    { 23, 1, null, "Thiết bị điện", "https://finance.vietstock.vn/nganh/27-thiet-bi-dien.htm" },
                    { 24, 1, null, "Dịch vụ tư vấn, hỗ trợ", "https://finance.vietstock.vn/nganh/28-dich-vu-tu-van-ho-tro.htm" },
                    { 25, 1, null, "Tài chính khác", "https://finance.vietstock.vn/nganh/29-tai-chinh-khac.htm" }
                });

            migrationBuilder.CreateIndex(
                name: "IDX_Company_Code",
                schema: "dbo",
                table: "Company",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Company_SectorLevel1",
                schema: "dbo",
                table: "Company",
                column: "SectorLevel1");

            migrationBuilder.CreateIndex(
                name: "IX_Company_SectorLevel2",
                schema: "dbo",
                table: "Company",
                column: "SectorLevel2");

            migrationBuilder.CreateIndex(
                name: "IX_Company_SectorLevel3",
                schema: "dbo",
                table: "Company",
                column: "SectorLevel3");

            migrationBuilder.CreateIndex(
                name: "IX_FinancialReport_CompanyId",
                schema: "dbo",
                table: "FinancialReport",
                column: "CompanyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FinancialReport",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Company",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Sector",
                schema: "dbo");
        }
    }
}
