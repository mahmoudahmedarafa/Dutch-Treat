using Dutch_Treat.Data;
using Dutch_Treat.Data.Entities;
using Dutch_Treat.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation()
                .AddNewtonsoftJson(options => options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore);

builder.Services.AddRazorPages();
builder.Services.AddTransient<IMailService, NullMailService>();

builder.Services.AddDbContextPool<DutchContext>(options => options.UseSqlServer(
                    builder.Configuration.GetConnectionString("EmployeeDBConnection")
));

builder.Services.AddScoped<IDutchRepository, DutchRepository>();

builder.Services.AddIdentity<StoreUser, IdentityRole>(options =>
{

}).AddEntityFrameworkStores<DutchContext>();

builder.Services.AddAuthentication().AddCookie().AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidIssuer = builder.Configuration["Token:Issuer"],
        ValidAudience = builder.Configuration["Token:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Token:Key"]))
    };
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/error");
}

app.UseDefaultFiles();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapRazorPages();
    endpoints.MapControllerRoute("Default", "/{controller}/{action}/{id?}",
                                 new {controller = "App", action = "Index"});
});

app.Run();