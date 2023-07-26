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
    public class ItemConfig : IEntityTypeConfiguration<ItemDb>
    {
        public void Configure(EntityTypeBuilder<ItemDb> builder)
        {
            // tạo các rằng buộc cho trường trong bảng
            builder.HasKey(e => e.ItemId);

            builder.ToTable("Items").HasComment("Bảng thông tin item");

            builder.Property(e => e.ItemId).HasComment("Id item");

            builder.Property(e => e.ItemLanguage).HasMaxLength(10).HasComment("Ngôn ngữ của Item");

            builder.Property(e => e.ItemApp).HasMaxLength(10).HasComment("Chức năng item( là sản phẩm hay tin tức)");

            builder.Property(e => e.ItemCode).HasMaxLength(20).HasComment("Mã Item");

            builder.Property(e => e.ItemTitle).HasMaxLength(255).HasComment("Tên item");

            builder.Property(e => e.ItemDescription).HasColumnType("varchar(MAX)").HasComment("Chi tiết item");

            builder.Property(e => e.ItemContent).HasMaxLength(500).HasComment("Mô tả item");

            builder.Property(e => e.ItemImageId).HasMaxLength(255).HasComment("Id ảnh trên Cloud");

            builder.Property(e => e.ItemImage).HasMaxLength(500).HasComment("Ảnh item");

            builder.Property(e => e.ItemAuthor).HasMaxLength(100).HasComment("Tác giả tạo item");

            builder.Property(e => e.ItemMetaTitle).HasMaxLength(255).HasComment("Tên item(phục vụ SEO)");

            builder.Property(e => e.ItemMetaDescription).HasColumnType("varchar(MAX)").HasComment("chi tiết item(SEO)");

            builder.Property(e => e.ItemMetaKeywords).HasMaxLength(500).HasComment("Từ khóa item(SEO)");

            builder.Property(e => e.ItemTag).HasMaxLength(255).HasComment("Từ khóa nổi bật item");

            builder.Property(e => e.ItemLink).HasMaxLength(255).HasComment("Đường dẫn item");

            builder.Property(e => e.ItemPriceOld).HasComment("Giá (chưa khuyến mãi)");

            builder.Property(e => e.ItemPriceNew).HasComment("Giá (khi có khuyến mãi)");

            builder.Property(e => e.ItemTotalView).HasMaxLength(10).HasComment("Lượt xem");

            builder.Property(e => e.ItemSortOrder).HasMaxLength(10).HasComment("Thứ tự sắp xếp");

            builder.Property(e => e.ItemStatus).HasMaxLength(1).HasComment("Trạng thái item");

            builder.Property(e => e.CreateDate).HasComment("Ngày tạo");

            builder.Property(e => e.ModifiedDate).HasComment("Thời gian sửa gần nhất");

            // Tạo khóa liên kết với các bảng khác

        }
    }
}
