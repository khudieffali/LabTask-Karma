using LabTask_Karma.Models.DataAccess;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var cString = builder.Configuration.GetConnectionString("KarmaDB");
builder.Services.AddDbContext<KarmaDbContext>(opt=>opt.UseSqlServer(cString));
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();

app.MapControllerRoute("default", "{controller=home}/{action=index}/{id?}");

app.Run();
