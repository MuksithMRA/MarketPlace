using MarketPlace.Models;
using Microsoft.EntityFrameworkCore;

namespace MarketPlace.Utils
{
public class DataContext : DbContext
{

    public DataContext(DbContextOptions<DataContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

    }

    public DbSet<User> Users {
        get;
        set;
    }
    public DbSet<Member> Members {
        get;
        set;
    }
    public DbSet<Location> Locations {
        get;
        set;
    }
    public DbSet<Brand> Brands {
        get;
        set;
    }
    public DbSet<SubCategory> SubCategories {
        get;
        set;
    }
    public DbSet<Category> Categories {
        get;
        set;
    }
    public DbSet<Product> Products {
        get;
        set;
    }
    public DbSet<Store> Stores {
        get;
        set;
    }
}
}
