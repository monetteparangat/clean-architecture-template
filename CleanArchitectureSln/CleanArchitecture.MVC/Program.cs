using CleanArchitecture.Infrastructure.Data.Context;
using CleanArchitecture.Infrastructure.IoC;
using CleanArchitecture.MVC.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("UniversityIdentityDBConnection") ?? throw new InvalidOperationException("Connection string 'UniversityIdentityDBConnection' not found.");
var universityDbConnectionString = builder.Configuration.GetConnectionString("UniversityDbConnection") ?? throw new InvalidOperationException("Connection string 'UniversityDBConnection' not found."); ;

// AddDbContext
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDbContext<UniversityDBContext>(options =>
{
    options.UseMySql(universityDbConnectionString, ServerVersion.AutoDetect(universityDbConnectionString));
});


builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();


builder.Services.AddControllersWithViews();

// Register services
DependencyContainer.RegisterServices(builder.Services);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
