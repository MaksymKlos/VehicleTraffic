using Database.Constants;
using Database.Models;
using Microsoft.EntityFrameworkCore;

namespace Database;

public sealed class VehicleTrafficContext : DbContext
{
    public DbSet<Driver> Водії { get; set; } = null!;
    public DbSet<Route> Маршрути { get; set; } = null!;
    public DbSet<Shipping> Перевезення { get; set; } = null!; 
    public DbSet<Transport> ТрансортніЗасоби { get; set; } = null!;
    public DbSet<Fine> Штрафи { get; set; } = null!;

    public VehicleTrafficContext()
    {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseLazyLoadingProxies().UseSqlite(Connection.DbConnection);

        base.OnConfiguring(optionsBuilder);
    }
}