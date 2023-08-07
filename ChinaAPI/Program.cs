using ChinaAPI_BAL.BaseBAL;
using ChinaAPI_DAL.BaseDAL;
using ChinaAPICommon.EFContext;
using CloudinaryDotNet;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// tạo chuỗi kết nối Db
builder.Services.AddDbContext<MyDbContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultDatabase")!);
});

// Đọc cấu hình từ appsettings.json
IConfiguration configuration = builder.Configuration;
IConfigurationSection cloudinaryConfig = configuration.GetSection("Cloudinary");
Account cloudinaryCredentials = new Account(
     cloudinaryConfig["CloudName"],
    cloudinaryConfig["ApiKey"],
    cloudinaryConfig["ApiSecret"]
);

Cloudinary cloudinary = new Cloudinary(cloudinaryCredentials);

cloudinary.Api.Secure = true;

// Đăng ký Cloudinary vào DI container để sử dụng trong các controller hoặc service
builder.Services.AddSingleton(cloudinary);

// Đăng kí dependencyInject
builder.Services.AddScoped(typeof(IBaseDAL<>), typeof(BaseDAL<>));

builder.Services.AddScoped(typeof(IBaseBAL<>), typeof(BaseBAL<>));

builder.Services.AddCors(p => p.AddPolicy("MyCors", build =>
{
    build.WithOrigins("http://127.0.0.1:5500/index.html");
    build.AllowAnyHeader();
    build.AllowAnyMethod();
    build.AllowAnyOrigin();
}));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Swager demo");
    });
}

app.UseCors("MyCors");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
