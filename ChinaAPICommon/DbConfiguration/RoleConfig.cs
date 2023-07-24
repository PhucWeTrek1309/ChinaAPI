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
    public class RoleConfig : IEntityTypeConfiguration<RoleDb>
    {
        public void Configure(EntityTypeBuilder<RoleDb> builder)
        {
            // Tạo các rằng buộc cac trường
            builder.HasKey(e => e.RoleId);

            builder.ToTable("Role").HasComment("bảng quyền người dùng");

            builder.Property(e => e.RoleId).HasComment("ID quyền");

            builder.Property(e => e.RoleName).HasMaxLength(255).HasComment("Tên quyền");

            builder.Property(e => e.RoleDescription).HasMaxLength(255).HasComment("Mô tả quyền");

            builder.Property(e => e.RoleStatus).HasMaxLength(1).HasComment("Trạng thái quyền");

            builder.Property(e => e.CreateDate).HasComment("Ngày tạo");

            builder.Property(e => e.ModifiedDate).HasComment("Thời gian sửa gần nhất");

            // Tạo các liên kết với bảng khác
        }
    }
}
