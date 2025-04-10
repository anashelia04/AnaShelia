using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

public class OfferConfiguration : IEntityTypeConfiguration<Offer>
{
    public void Configure(EntityTypeBuilder<Offer> builder)
    {
        builder.HasKey(o => o.Id);

        builder.Property(o => o.Title)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(o => o.Description)
            .HasMaxLength(1000);

        builder.Property(o => o.Quantity)
            .IsRequired();

        builder.Property(o => o.UnitPrice)
            .IsRequired()
            .HasPrecision(18, 2);

        builder.Property(o => o.StartTime)
            .IsRequired();

        builder.Property(o => o.EndTime)
            .IsRequired();

        builder.Property(o => o.Status)
            .IsRequired();

        builder.Property(o => o.ImageUrl)
            .HasMaxLength(2048);

        builder.Property(o => o.CategoryId)
            .IsRequired();

        builder.HasIndex(o => o.Status);

        builder.HasIndex(o => o.EndTime);

        builder.HasIndex(o => new { o.CategoryId, o.Status });
    }
}