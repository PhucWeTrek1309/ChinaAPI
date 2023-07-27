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
    public class GroupItemConfig : IEntityTypeConfiguration<GroupItemsDb>
    {
        public void Configure(EntityTypeBuilder<GroupItemsDb> builder)
        {
            // Tạo các rằng buộc cho các trường trong bảng

            builder.HasKey(e => e.GroupItemsId);

            builder.ToTable("GroupItems").HasComment("Bảng liên kết danh mục và sản phẩm");

            builder.Property(e => e.GroupItemsId).HasComment("Id bảng liên kết");

            builder.Property(e => e.ItemId).HasComment("Id bảng Item");

            builder.Property(e => e.GroupId).HasComment("Id bảng Group");

            // Tạo các liên kết khóa cho bảng

            builder.HasOne(d => d.GroupDb).WithMany()
           .HasForeignKey(d => d.GroupId)
           .HasConstraintName("FK_GroupItem_Group");

            builder.HasOne(d => d.ItemDb).WithMany()
                .HasForeignKey(d => d.ItemId)
                .HasConstraintName("FK_GroupItem_Item");
        }
    }
}
