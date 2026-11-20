using Microsoft.EntityFrameworkCore;
using Concesionario.Data;
using Microsoft.AspNetCore.Identity;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("ConcesionarioContext") ?? throw new InvalidOperationException("Connection string 'ConcesionarioContext' not found.");

builder.Services.AddDbContext<ConcesionarioContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ConcesionarioContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();
using (var scope = app.Services.CreateScope())
{
    var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

    string[] roles = { "Vendedor", "Comprador" };

    foreach (var rol in roles)
    {
        if (!await roleManager.RoleExistsAsync(rol))
        {
            await roleManager.CreateAsync(new IdentityRole(rol));
        }
    }

    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();

    // Usuario Vendedor
    var vendedor = await userManager.FindByEmailAsync("vendedor@hbtechworks.com");

    if (vendedor == null)
    {
        vendedor = new ApplicationUser
        {
            UserName = "vendedor@hbtechworks.com",
            Email = "vendedor@hbtechworks.com",
            EmailConfirmed = true
        };

        await userManager.CreateAsync(vendedor, "Vendedor2026!");
    }

    if (!await userManager.IsInRoleAsync(vendedor, "Vendedor"))
    {
        await userManager.AddToRoleAsync(vendedor, "Vendedor");
    }

    // Usuario Comprador
    var comprador = await userManager.FindByEmailAsync("comprador@hbtechworks.com");

    if (comprador == null)
    {
        comprador = new ApplicationUser
        {
            UserName = "comprador@hbtechworks.com",
            Email = "comprador@hbtechworks.com",
            EmailConfirmed = true
        };

        await userManager.CreateAsync(comprador, "Comprador2026!");
    }

    if (!await userManager.IsInRoleAsync(comprador, "Comprador"))
    {
        await userManager.AddToRoleAsync(comprador, "Comprador");
    }
}


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

app.MapRazorPages();
app.Run();
