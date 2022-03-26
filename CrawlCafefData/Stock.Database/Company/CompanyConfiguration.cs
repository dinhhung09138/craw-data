

namespace Stock.Database
{
    public sealed class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.ToTable(nameof(Company), "dbo");

            builder.HasKey(m => m.Id);

            builder.HasIndex(m => m.Code)
                .HasDatabaseName("IDX_Company_Code")
                .IsUnique();
            builder.Property(m => m.Code)
                .HasColumnType("varchar")
                .HasMaxLength(5)
                .IsRequired();

            builder.Property(m => m.Name)
                .HasColumnType("nvarchar")
                .HasMaxLength(255).IsRequired();

            builder.HasOne(m => m.Sector1)
                   .WithMany(e => e.CompanyLevel1s)
                   .HasForeignKey(m => m.SectorLevel1)
                   .HasConstraintName("FK_Company_SectorLevel1")
                   .IsRequired();
            builder.Property(m => m.SectorLevel1).IsRequired();

            builder.HasOne(m => m.Sector2)
                   .WithMany(e => e.CompanyLevel2s)
                   .HasForeignKey(m => m.SectorLevel2)
                   .HasConstraintName("FK_Company_SectorLevel2");
            builder.Property(m => m.SectorLevel2);

            builder.HasOne(m => m.Sector3)
                   .WithMany(e => e.CompanyLevel3s)
                   .HasForeignKey(m => m.SectorLevel3)
                   .HasConstraintName("FK_Company_SectorLevel3");
            builder.Property(m => m.SectorLevel3);


            builder.Property(m => m.CurrentPrice)
                .HasColumnType("decimal(4,2)")
                .IsRequired();

            builder.Property(m => m.IsAlert).IsRequired();

            builder.Property(m => m.StockExchange).IsRequired();
        }
    }
}
