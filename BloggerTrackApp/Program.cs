using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using BloggerTrackApp.Data;
using BloggerTrackApp.Models;

var builder = WebApplication.CreateBuilder(args);

string DefaultConnection= "Server=tcp:godwin-server.database.windows.net,1433;Initial Catalog=BlogDB;Persist Security Info=False;User ID=Godwin-admin;Password=MyCompany@123;MultipleActiveResultSets=False;";
builder.Services.AddDbContext<AdminDbContext>(options => 
    options.UseSqlServer(DefaultConnection));

builder.Services.AddDefaultIdentity<AdminInfo>().AddEntityFrameworkStores<AdminDbContext>();

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
app.UseAuthentication();;

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=BlogInfo}/{action=Index}/{id?}");
    endpoints.MapRazorPages();
});

app.Run();
