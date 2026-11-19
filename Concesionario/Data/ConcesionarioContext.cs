using Microsoft.EntityFrameworkCore;
using Concesionario.Models;

public class ConcesionarioContext(DbContextOptions<ConcesionarioContext> options) : DbContext(options)
{
    public DbSet<Vehiculo> Vehiculo { get; set; } = default!;
    public DbSet<Marca> Marca { get; set; } = default!;
}
