using _Net.Models;
using _Net.Models.Dp;
using _Net.Service.categoryService;
using _Net.Service.dpService;
using _Net.Service.statusService;
using Microsoft.EntityFrameworkCore;
using NetCore;
using Mapster;

//Мапинг
TypeAdapterConfig<CreateCategoryAndDp, Category>
    .NewConfig()
    .Map(dest => dest.Name, src => src.CategoryName)
    .Map(dest => dest.Description, src => src.CategoryDescription);

TypeAdapterConfig<CreateCategoryAndDp, Dp>
    .NewConfig()
    .Map(dest => dest.Type, src => src.DpType)
    .Map(dest => dest.Name, src => src.DpName);

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Регистрация MyDbContext в контейнере зависимостей с использованием PostgreSQL
builder.Services.AddDbContext<MyDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

// Регистрация интерфейса ICategoryService и его реализации
builder.Services.AddScoped<ICategoryService, CategoryServiceDao>();
builder.Services.AddScoped<IDpService, DpServiceDao>();
builder.Services.AddScoped<IStatusService, StatusServiceDao>();
builder.Services.AddScoped<IStatusTransitionService, StatusTransitionServiceDao>();

var app = builder.Build();

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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Category}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Dp}/{action=Index}/{id?}");

app.Run();