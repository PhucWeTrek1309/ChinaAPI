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
    public class BillConfig : IEntityTypeConfiguration<BillDb>
    {
        public void Configure(EntityTypeBuilder<BillDb> builder)
        {
            // Tạo các rằng buộc cho các bảng
            builder.HasKey(x => x.BillId);

            builder.ToTable("Bills").HasComment("Bảng lưu thông tin đơn hàng");

            builder.Property(e => e.BillId).HasComment("Id Đơn hàng");

            builder.Property(e => e.BillCode)
                .HasMaxLength(20)
                .HasComment("Mã đơn hàng");

            builder.Property(e => e.BillGender)
                .HasMaxLength(10)
                .HasComment("Giới tính khách hàng");

            builder.Property(e => e.BillName)
                .HasMaxLength(100)
                .HasComment("Tên khách hàng");

            builder.Property(e => e.BillPhone)
                .HasMaxLength(11)
                .HasComment("Số điện thoại khách hàng");

            builder.Property(e => e.BillEmail)
                .HasMaxLength(100)
                .HasComment("Email khách hàng");

            builder.Property(e => e.BillAddress)
                .HasMaxLength(100)
                .HasComment("Địa chỉ khachs hàng");

            builder.Property(e => e.BillMessage)
                .HasMaxLength(500)
                .HasComment("Tin nhấn của khách hàng");

            builder.Property(e => e.BillParam)
                .HasMaxLength(100)
                .HasComment("thông tin thêm của đơn hàng");

            builder.Property(e => e.BillStatus)
                .HasMaxLength(10)
                .HasComment("Trạng thái đơn hàng");

            builder.Property(e => e.CreateDate)
                .HasComment("Ngày tạo");

            builder.Property(e => e.ModifiedDate)
                .HasComment("Thời gian sửa gần nhất");

            // Tạo các khóa liên kết cho các bảng
        }
    }
}
