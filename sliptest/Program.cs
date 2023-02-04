using Efcore;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Models;
using Repository.DepartmentRepository;
using Repository.LocationRepository;
using Repository.RoleRepository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddSwaggerGen();
builder.Services.AddUtilityConfiguration(builder.Configuration);
builder.Services.AddDbContext<sliptestcontext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("sliptestcontext"), s => s.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery));
});
//
builder.Services.AddTransient<IRoleRepository, RoleRepository>();
builder.Services.AddTransient<IDepartmentRepository,DepartmentRepository>();    
builder.Services.AddTransient<ILocationInterfcae,LocationRepository>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

else
{
    app.UseSwagger();
    app.UseSwaggerUI();
    
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html"); ;

app.Run();
