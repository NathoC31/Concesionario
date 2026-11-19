using Concesionario.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Concesionario.Models;

public class ConcesionarioContext(DbContextOptions<ConcesionarioContext> options) : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<Vehiculo> Vehiculo { get; set; } = default!;
    public DbSet<Marca> Marca { get; set; } = default!;
}
