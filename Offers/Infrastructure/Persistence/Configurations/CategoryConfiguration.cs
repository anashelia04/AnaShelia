using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.HasKey(c => c.Id);

        builder.Property(c => c.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(c => c.Description)
            .HasMaxLength(500);

        builder.HasIndex(c => c.Name)
            .IsUnique();

        builder.HasMany(c => c.Offers)
            .WithOne(o => o.Category)
            .HasForeignKey(o => o.CategoryId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}