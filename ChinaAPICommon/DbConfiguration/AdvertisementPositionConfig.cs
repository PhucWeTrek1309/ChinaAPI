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
    public class AdvertisementPositionConfig : IEntityTypeConfiguration<AdvertisementPositionDb>
    {
        public void Configure(EntityTypeBuilder<AdvertisementPositionDb> builder)
        {
            // Tạo rằng buộc cho các trường trong bảng
            builder.HasKey(e => e.AdvertisementPositionId);

            builder.ToTable("AdvertisementPosition")
                .HasComment("Bảng thông tin vị trí banner, quảng cáo");

            builder.Property(e => e.AdvertisementPositionId)
                .HasComment("Id vị trí");

            builder.Property(e => e.AdvertisementPositionName)
                .HasComment("Tên vị trí");

            builder.Property(e => e.AdvertisementPositionStatus)
                .HasComment("trạng thái vị trí đã kích hoạt hay chưa");

            builder.Property(e => e.AdvertisementPositionSortOrder)
                .HasComment("Thứ tự sắp xếp vị trí");

            builder.Property(e => e.CreateDate)
                .HasComment("Ngày tạo");

            builder.Property(e => e.ModifiedDate)
                .HasComment("Thời gian sửa gần nhất");

            // Tạo khóa liên kết với các trường trong bảng
        }
    }
}
