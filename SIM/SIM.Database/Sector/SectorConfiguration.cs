

namespace SIM.Database
{
    public sealed class SectorConfiguration : IEntityTypeConfiguration<Sector>
    {
        public void Configure(EntityTypeBuilder<Sector> builder)
        {
            builder.ToTable(nameof(Sector), "dbo");

            builder.HasKey(m => m.Id);

            builder.Property(m => m.SectorName)
                .HasColumnType("nvarchar")
                .HasMaxLength(255).IsRequired();

            builder.Property(m => m.ParentIndustryId);

            builder.Property(m => m.Level)
                .IsRequired();
        }
    }
}
