using ChinaAPICommon.Database;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinaAPICommon.DbConfiguration
{
    
        public class ImageConfig : IEntityTypeConfiguration<ImageDb>
        {
            public void Configure(EntityTypeBuilder<ImageDb> builder)
            {
                // Tạo các rằng buộc cac trường
                builder.HasKey(e => e.ImageId);

                builder.ToTable("Image").HasComment("bảng ảnh sản phẩm, tin tức, ...");

                builder.Property(e => e.ImageId).HasComment("ID ảnh");

                builder.Property(e => e.ItemId).HasMaxLength(10).HasComment("id trùng với id sản phẩm hoặc id bài viết");

                builder.Property(e => e.ImageApp).HasMaxLength(100).HasComment("Nơi hiển thị ảnh ( sản phẩm hay tin tức)");

                builder.Property(e => e.ImageLink).HasMaxLength(500).HasComment("Link đến ảnh");

                builder.Property(e => e.ImageCode).HasMaxLength(255).HasComment("Id Ảnh trên cloud");

                builder.Property(e => e.ImageTitle).HasMaxLength(500).HasComment("Tên ảnh");

                builder.Property(e => e.CreateDate).HasComment("Ngày tạo");

                builder.Property(e => e.ModifiedDate).HasComment("Thời gian sửa gần nhất");

            // Tạo các liên kết với bảng khác

             builder.HasOne(d => d.ItemDb).WithMany(p => p.ImageDb).HasForeignKey(d => d.ItemId);
        }
        }
    }

