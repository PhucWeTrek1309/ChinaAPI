using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChinaAPICommon.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ChinaAPICommon.DbConfiguration;

    public class AccountConfig : IEntityTypeConfiguration<AccountDb>
    {
        public void Configure(EntityTypeBuilder<AccountDb> builder)
        {
            // Tạo các rằng buộc cho các trường trong bảng
            builder.HasKey(e => e.AccountId);

            builder.ToTable("Account").HasComment("Bảng thông tin tài khoản");

            builder.Property(e => e.AccountId)
                .HasComment("Id tài khoản");

            builder.Property(e => e.AccountName)
                .HasMaxLength(255)
                .HasComment("Tên đăng nhập");

            builder.Property(e => e.AccountCode)
                .HasMaxLength(100)
                .HasComment("Mã tài khoản");

            builder.Property(e => e.FirstName)
                .HasMaxLength(100)
                .HasComment("FirstName tài khoản");

            builder.Property(e => e.LastName)
                .HasMaxLength(100)
                .HasComment("LastName tài khoản");

            builder.Property(e => e.Email)
                .HasMaxLength(100)
                .HasComment("Email tài khoản");

            builder.Property(e => e.PhoneNumber)
                .HasMaxLength(100)
                .HasComment("Phone tài khoản");

            builder.Property(e => e.Image)
                .HasColumnType("varchar(MAX)")
                .HasComment("Trạng thái tài khoản");

            builder.Property(e => e.Token)
                .HasMaxLength(500)
                .HasComment("Mã Token tài khoản");

            builder.Property(e => e.RefreshToken)
                .HasMaxLength(500)
                .HasComment("Mã refreshToken tài khoản");

            builder.Property(e => e.CreateToken)
                .HasMaxLength(500)
                .HasComment("Thời gian tạo Token");

            builder.Property(e => e.ExpiresToken)
                .HasMaxLength(500)
                .HasComment("Thời gian Token hết hạn");

            builder.Property(e => e.CreatedRefreshToken)
                .HasMaxLength(500)
                .HasComment("Thời gian tạo RefreshToken");

            builder.Property(e => e.ExpiresRefreshToken)
                .HasMaxLength(500)
                .HasComment("Thời gian refreshToken hết hạn");

            builder.Property(e => e.CreateDate)
                .HasMaxLength(500)
                .HasComment("Thời gian tạo tài khoản");

            builder.Property(e => e.ModifiedDate)
                .HasMaxLength(500)
                .HasComment("Thời gian gần nhất chỉnh sửa tài khoản");

            // Tạo các liên kết khóa trong bảng
    }
}

