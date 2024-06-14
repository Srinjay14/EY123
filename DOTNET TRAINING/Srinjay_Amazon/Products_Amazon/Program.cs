using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Products_Amazon.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Products_AmazonContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Products_AmazonContext") ?? throw new InvalidOperationException("Connection string 'Products_AmazonContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Products}/{action=Index}/{id?}");

app.Run();
