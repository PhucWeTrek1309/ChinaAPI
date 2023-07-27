using ChinaAPICommon.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinaAPICommon.DbConfiguration
{
    public class AdvertisementConfig : IEntityTypeConfiguration<AdvertisementsDb>
    {
        public void Configure(EntityTypeBuilder<AdvertisementsDb> builder)
        {
            // Rằng buôc các trường trong bảng
            builder.ToTable("Advertisements").HasComment("Bảng lưu thông tin banner, quảng cáo, ...");

            builder.HasKey(e => e.AdvertisementId);

            builder.Property(e => e.AdvertisementId).HasComment("Id Banner, quảng cáo");

            builder.Property(e => e.AdvertisementPositonId).HasComment("Vị trí cùa banner");

            builder.Property(e => e.AdvertisementName)
                .HasMaxLength(255)
                .HasComment("Tên banner, quảng cáo");

            builder.Property(e => e.AdvertisementApp)
                .HasMaxLength(100)
                .HasComment("chức năng trên trang (vd: là banner, hay là quảng cáo, ...)");

            builder.Property(e => e.AdvertisementLanguage)
                .HasMaxLength(10)
                .HasComment("Ngôn ngữ của item");

            builder.Property(e => e.AdvertisementLink)
                .HasMaxLength(255)
                .HasComment("Đường dẫn của banner");

            builder.Property(e => e.AdvertisementTarget)
                .HasMaxLength(10)
                .HasComment("Cách chuyển trang khi nhấn vào link");

            builder.Property(e => e.AdvertisementDescription)
                .HasColumnType("varchar(MAX)")
                .HasComment("Mô tả của banner");

            builder.Property(e => e.AdvertisementImage)
                .HasMaxLength(500)
                .HasComment("Ảnh banner hoặc quảng cáo");

            builder.Property(e => e.AdvertisementSortOrder)
                .HasMaxLength(10)
                .HasComment("Thứ tự sấp xếp");

            builder.Property(e => e.AdvertisementStatus)
                .HasMaxLength(10)
                .HasComment("Trạng thái ( đã kích hoạt hay chưa)");

            builder.Property(e => e.CreateDate)
                .HasComment("Thời gian tạo");

            builder.Property(e => e.ModifiedDate)
                .HasComment("Thời gian sừa gần nhất");

            // tạo khóa cho các trường trong bảng
        }
    }
}
