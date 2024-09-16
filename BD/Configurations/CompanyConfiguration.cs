using BD.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BD.Configurations;

internal class CompanyConfiguration : IEntityTypeConfiguration<CompanyEntity>
{
    public void Configure(EntityTypeBuilder<CompanyEntity> builder)
    {
        builder.HasKey(e => e.Id);

        builder.HasMany(e => e.Films)
            .WithOne(e => e.Company)
            .HasForeignKey(e => e.CompanyId);
    }
}