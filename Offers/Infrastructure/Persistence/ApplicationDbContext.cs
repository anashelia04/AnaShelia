using System.Reflection;
using Domain.Entities;
using Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Offer> Offers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        
        var foodCategoryId = Guid.NewGuid();
        var beveragesCategoryId = Guid.NewGuid();
    
        modelBuilder.Entity<Category>().HasData(
            new Category { Id = foodCategoryId, Name = "Food", Description = "Groceries, Meals" },
            new Category { Id = beveragesCategoryId, Name = "Beverages", Description = "Drinks" }
        );
    
        modelBuilder.Entity<Offer>().HasData(
            new Offer
            {
                Id = Guid.NewGuid(),
                Title = "Bread",
                Description = "Get half price on all freshly baked bread",
                Quantity = 20,
                UnitPrice = 2.50m,
                StartTime = DateTime.Now,
                EndTime = DateTime.Now.AddDays(7),
                Status = OfferStatus.Active,
                CategoryId = foodCategoryId
            },
            new Offer
            {
                Id = Guid.NewGuid(),
                Title = "Coffee",
                Description = "Purchase any coffee and get another one free",
                Quantity = 50,
                UnitPrice = 3.99m,
                StartTime = DateTime.Now,
                EndTime = DateTime.Now.AddDays(14),
                Status = OfferStatus.Active,
                CategoryId = beveragesCategoryId
            }
        );
    }
}