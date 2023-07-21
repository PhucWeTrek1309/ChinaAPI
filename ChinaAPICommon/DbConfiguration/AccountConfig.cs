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
            builder.HasKey(e => e.AccountId);

            //builder.ToTable("User", tb => tb.HasComment("Bảng lưu thông tin quản trị viên website"));


            builder.Property(e => e.AccountName)
                    .HasMaxLength(255)
                    .HasComment("Tên đăng nhập");

    }
}

