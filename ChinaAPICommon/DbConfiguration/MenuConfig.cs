using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChinaAPICommon.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ChinaAPICommon.DbConfiguration
{
    public class MenuConfig : IEntityTypeConfiguration<MenuDb>
    {
        public void Configure(EntityTypeBuilder<MenuDb> builder)
        {
            // Tạo các rằng buộc cho các trường
            builder.HasKey(e => e.MenuId);

            builder.ToTable("Menu").HasComment("Bảng menu");

            builder.Property(e => e.MenuId).HasComment("Id menu");

            builder.Property(e => e.ParentMenuId).HasComment("Id menu cha").HasMaxLength(5);

            builder.Property(e => e.MenuLanguage).HasComment("Ngôn ngữ menu").HasMaxLength(1);

            builder.Property(e => e.MenuApp).HasComment("Loại menu(Menu bottom , menu header)").HasMaxLength(10);

            builder.Property(e => e.MenuLevel).HasComment("Cấp menu").HasMaxLength(5);

            builder.Property(e => e.MenuSort).HasComment("Thứ tự menu").HasMaxLength(5);

            builder.Property(e => e.MenuStatus).HasComment("Trạng thái menu").HasMaxLength(1);

            builder.Property(e => e.MenuTarget).HasComment("Cách chuyển trang menu").HasMaxLength(5);

            builder.Property(e => e.MenuName).HasComment("Tên menu").HasMaxLength(100);

            builder.Property(e => e.MenuLink).HasComment("Link menu").HasMaxLength(255);

            builder.Property(e => e.MenuImage).HasComment("Ảnh menu").HasMaxLength(255);

            builder.Property(e => e.CreateDate).HasComment("Ngày tạo");

            builder.Property(e => e.ModifiedDate).HasComment("Thời gian sửa gần nhất");

            // tạo các khóa liên kết
        }
    }
}
