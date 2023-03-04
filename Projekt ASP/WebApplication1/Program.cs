using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using static System.Formats.Asn1.AsnWriter;
using ProjektASP.DataBase;
using NuGet.Protocol;
using static System.Net.Mime.MediaTypeNames;
using ProjektASP.Models.Identity;
using Microsoft.AspNetCore.Identity;
using ProjektASP.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddMvc();
builder.Services.AddDbContext<MovieContext>(options =>
                    options.UseSqlServer(@"Server = (localdb)\MSSQLLocalDB; Database = test; Trusted_Connection = True; MultipleActiveResultSets = true"));

//builder.Services.AddDbContext<AppIdentityDbContext>(options =>
//                    options.UseSqlServer(@"Server = (localdb)\MSSQLLocalDB; Database = test; Trusted_Connection = True; MultipleActiveResultSets = true"));
builder.Services.AddIdentity<AppUser, IdentityRole>().AddEntityFrameworkStores<MovieContext>().AddDefaultTokenProviders();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//void ConfigureServices(IServiceCollection services)
//{
//    services.Configure<CookiePolicyOptions>(options =>
//    {
//        // This lambda determines whether user consent for non-essential cookies is needed for a given request.
//        options.CheckConsentNeeded = context => true;
//        options.MinimumSameSitePolicy = SameSiteMode.None;
//    });

//    var connection = "Server=localhost;Port=5432;Database=Test;User Id=postgres;Password=postgres;";
//    services.AddDbContext<MovieContext>(options => options.UseSqlServer(connection));

//    services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
//}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
