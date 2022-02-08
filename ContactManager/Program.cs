using Microsoft.EntityFrameworkCore;
using ContactManager.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddRouting(options =>
{
    options.LowercaseUrls = true;
    options.AppendTrailingSlash = true;

});

var app = builder.Build();

// Connection string reference
builder.Services.AddDbContext<ContactContext>(options
    => options.UseSqlServer(builder.Configuration.GetConnectionString("ContactContext")));

// Configure the HTTP request pipeline.
app.UseDeveloperExceptionPage();
app.UseStaticFiles();
app.UseRouting();

// app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
