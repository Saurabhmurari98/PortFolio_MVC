using Portfolio.Contracts;
using Portfolio.Models;
using Portfolio.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IContact, ContactService>();
var app = builder.Build();

app.UseRouting();
app.UseStaticFiles();
app.UseEndpoints(e =>
  e.MapControllerRoute(name: "Default", pattern: "{controller=Home}/{action=Index}/{id?}")

);

app.Run();
