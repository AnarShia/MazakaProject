using MazakaNet.Data;
using MazakaNet.Models;
using MazakaNet.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddIdentity<AppUser, IdentityRole>(options =>
    {
        options.Password.RequiredLength = 3;
        options.Password.RequiredUniqueChars = 0;
        options.Password.RequireLowercase = false;
        options.Password.RequireUppercase = false;
        options.Password.RequireDigit = false;
        options.Password.RequireNonAlphanumeric = false;
    })
    .AddEntityFrameworkStores<MazakaNetContext>().AddDefaultTokenProviders();

builder.Services.AddRazorPages();

builder.Services.AddDbContext<MazakaNetContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")));

SignInManager<AppUser> signInManager = builder.Services.BuildServiceProvider().GetRequiredService<SignInManager<AppUser>>();

UserManager<AppUser> userManager = builder.Services.BuildServiceProvider().GetService<UserManager<AppUser>>();

builder.Services.AddSingleton<IAccountServices, AccountServices>();
AccountServices.Configure(signInManager,userManager);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
app.UseDeveloperExceptionPage();

}
else
{
app.UseExceptionHandler("/Home/Error");
app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
endpoints.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
endpoints.MapRazorPages();
});

app.Run();
