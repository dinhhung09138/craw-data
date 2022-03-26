

namespace SIM.Database
{
    public sealed class FinancialReportConfiguration : IEntityTypeConfiguration<FinancialReport>
    {
        public void Configure(EntityTypeBuilder<FinancialReport> builder)
        {
            builder.ToTable(nameof(FinancialReport), "dbo");

            builder.HasKey(m => m.Id);

            builder.Property(m => m.CompanyId).IsRequired();
            builder.HasOne(m => m.Company)
                   .WithMany(e => e.FinancialReports)
                   .HasForeignKey(m => m.CompanyId)
                   .OnDelete(DeleteBehavior.Cascade)
                   .HasConstraintName("FK_FinancialReport_CompanyId")
                   .IsRequired();

            builder.Property(m => m.Year)
                .HasColumnType("int")
                .IsRequired();

            builder.Property(m => m.Quarter)
                .HasColumnType("int")
                .IsRequired();

            builder.Property(m => m.PB)
                .HasColumnType("decimal(6,2)")
                .IsRequired();

            builder.Property(m => m.EPS)
                .HasColumnType("decimal(6,2)")
                .IsRequired();

            builder.Property(m => m.PE)
                .HasColumnType("decimal(6,2)")
                .IsRequired();

            builder.Property(m => m.BVPSCoBan)
                .HasColumnType("decimal(6,2)")
                .IsRequired();

            builder.Property(m => m.PECoBan)
                .HasColumnType("decimal(6,2)")
                .IsRequired();

            builder.Property(m => m.ROS)
                .HasColumnType("decimal(6,2)")
                .IsRequired();

            builder.Property(m => m.ROE)
                .HasColumnType("decimal(6,2)")
                .IsRequired();

            builder.Property(m => m.ROA)
                .HasColumnType("decimal(6,2)")
                .IsRequired();

            builder.Property(m => m.KhoiLuongCPNiemYet)
                .HasColumnType("decimal(13,2)")
                .IsRequired();

            builder.Property(m => m.KhoiLuongCPLuuHanh)
                .HasColumnType("decimal(13,2)")
                .IsRequired();

            builder.Property(m => m.VonHoaThiTruong)
                .HasColumnType("decimal(13,2)")
                .IsRequired();

            builder.Property(m => m.CoPhieuPhatHanh)
                .HasColumnType("decimal(13,2)")
                .IsRequired();

            builder.Property(m => m.DoanhThuThuan)
                .HasColumnType("decimal(13,2)")
                .IsRequired();

            builder.Property(m => m.LoiNhuanGop)
                .HasColumnType("decimal(13,2)")
                .IsRequired();

            builder.Property(m => m.LNThuanTuHDKD)
                .HasColumnType("decimal(13,2)")
                .IsRequired();

            builder.Property(m => m.LNSTThuNhapDN)
                .HasColumnType("decimal(13,2)")
                .IsRequired();

            builder.Property(m => m.LNSTCongTyMe)
                .HasColumnType("decimal(13,2)")
                .IsRequired();

            builder.Property(m => m.TaiSanNganHan)
                .HasColumnType("decimal(13,2)")
                .IsRequired();

            builder.Property(m => m.TongTaiSan)
                .HasColumnType("decimal(13,2)")
                .IsRequired();

            builder.Property(m => m.NoPhaiTra)
                .HasColumnType("decimal(13,2)")
                .IsRequired();

            builder.Property(m => m.NoNganHan)
                .HasColumnType("decimal(13,2)")
                .IsRequired();

            builder.Property(m => m.VonChuSoHuu)
                .HasColumnType("decimal(13,2)")
                .IsRequired();

        }
    }
}
