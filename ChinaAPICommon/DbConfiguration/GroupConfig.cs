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
    public class GroupConfig : IEntityTypeConfiguration<GroupDb>
    {
        public void Configure(EntityTypeBuilder<GroupDb> builder)
        {
            // Tạo các rằng buộc cho các trường
            builder.HasKey(e => e.GroupId);

            builder.ToTable("Group").HasComment("Bảng thông tin các danh mục");

            builder.Property(e => e.GroupId).HasComment("Id danh mục");

            builder.Property(e => e.ParentGroupId).HasMaxLength(10).HasComment("Id danh mục cha");

            builder.Property(e => e.GroupLanguage).HasComment("Ngôn ngữ của danh mục").HasMaxLength(1);

            builder.Property(e => e.GroupApp).HasComment("Chức năng danh mục(là sản phẩm hay tin tức").HasMaxLength(10);

            builder.Property(e => e.GroupLevel).HasMaxLength(5).HasComment("Cấp của danh mục");

            builder.Property(e => e.GroupName).HasMaxLength(100).HasComment("Tên danh mục");

            builder.Property(e => e.GroupStatus).HasMaxLength(2).HasComment("Trạng thái danh mục");

            builder.Property(e => e.GroupLink).HasMaxLength(255).HasComment("Link danh mục");

            builder.Property(e => e.CreateDate).HasComment("Ngày tạo");

            builder.Property(e => e.ModifiedDate).HasComment("Thời gian sửa gần nhất");

            // Tạo các khóa liên kết cho các bảng
        }
    }
}
