using CloudinaryDotNet;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
