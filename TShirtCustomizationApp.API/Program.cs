using Microsoft.EntityFrameworkCore;
using TShirtCustomizationApp.Entity.Interfaces;
using TShirtCustomizationApp.Repository;
using TShirtCustomizationApp.Repository.Interfaces;
using TShirtCustomizationApp.Service;
using TShirtCustomizationApp.Service.Interfaces;
using static System.Net.Mime.MediaTypeNames;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>();

builder.Services.AddTransient<IItemService, ItemService>();
builder.Services.AddTransient<IImageRepository, ImageRepository>();
builder.Services.AddTransient<IItemColorRepository, ItemColorRepository>();
builder.Services.AddTransient<IItemFabricRepository, ItemFabricRepository>();
builder.Services.AddTransient<IItemRepository, ItemRepository>();
builder.Services.AddTransient<IColorRepository, ColorRepository>();
builder.Services.AddTransient<IFabricRepository, FabricRepository>();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
