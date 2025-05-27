//AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using HopefullyWebScraper.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<HopefullyWebScraperContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("HopefullyWebScraperContext") ?? throw new InvalidOperationException("Connection string 'HopefullyWebScraperContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();


///the developer exception page is enabled by default and provides helpfull information on exceptions
///productions apps should not be run in development mode because exception page can leak sensitive information
///the following sets exception endoint to /error and enables HSTS when app not running in development mode

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
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

app.Run();
