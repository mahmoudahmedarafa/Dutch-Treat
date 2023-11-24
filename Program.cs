using Dutch_Treat.Data;
using Dutch_Treat.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
builder.Services.AddRazorPages();
builder.Services.AddTransient<IMailService, NullMailService>();
//builder.Services.AddDbContext<DutchContext>(options =>
//{
//    options.UseSqlServer();
//});
builder.Services.AddDbContextPool<DutchContext>(options => options.UseSqlServer(
                    builder.Configuration.GetConnectionString("EmployeeDBConnection")
));


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

app.UseEndpoints(endpoints =>
{
    endpoints.MapRazorPages();
    endpoints.MapControllerRoute("Default", "/{controller}/{action}/{id?}",
                                 new {controller = "App", action = "Index"});
});

app.Run();