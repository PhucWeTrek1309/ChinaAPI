﻿// <auto-generated />
using System;
using ChinaAPICommon.EFContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ChinaAPICommon.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ChinaAPICommon.Database.AccountDb", b =>
                {
                    b.Property<int>("AccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Id tài khoản");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccountId"), 1L, 1);

                    b.Property<int>("AccountCode")
                        .HasMaxLength(100)
                        .HasColumnType("int")
                        .HasComment("Mã tài khoản");

                    b.Property<string>("AccountName")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasComment("Tên đăng nhập");

                    b.Property<int>("AccountStatus")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasMaxLength(500)
                        .HasColumnType("datetime2")
                        .HasComment("Thời gian tạo tài khoản");

                    b.Property<DateTime>("CreateToken")
                        .HasMaxLength(500)
                        .HasColumnType("datetime2")
                        .HasComment("Thời gian tạo Token");

                    b.Property<DateTime>("CreatedRefreshToken")
                        .HasMaxLength(500)
                        .HasColumnType("datetime2")
                        .HasComment("Thời gian tạo RefreshToken");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasComment("Email tài khoản");

                    b.Property<DateTime>("ExpiresRefreshToken")
                        .HasMaxLength(500)
                        .HasColumnType("datetime2")
                        .HasComment("Thời gian refreshToken hết hạn");

                    b.Property<DateTime>("ExpiresToken")
                        .HasMaxLength(500)
                        .HasColumnType("datetime2")
                        .HasComment("Thời gian Token hết hạn");

                    b.Property<string>("FirstName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasComment("FirstName tài khoản");

                    b.Property<string>("Image")
                        .HasColumnType("varchar(MAX)")
                        .HasComment("Trạng thái tài khoản");

                    b.Property<string>("LastName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasComment("LastName tài khoản");

                    b.Property<DateTime>("ModifiedDate")
                        .HasMaxLength(500)
                        .HasColumnType("datetime2")
                        .HasComment("Thời gian gần nhất chỉnh sửa tài khoản");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasComment("Phone tài khoản");

                    b.Property<string>("RefreshToken")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasComment("Mã refreshToken tài khoản");

                    b.Property<string>("Token")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasComment("Mã Token tài khoản");

                    b.HasKey("AccountId");

                    b.ToTable("Account", (string)null);

                    b.HasComment("Bảng thông tin tài khoản");
                });

            modelBuilder.Entity("ChinaAPICommon.Database.AdvertisementPositionDb", b =>
                {
                    b.Property<int>("AdvertisementPositionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Id vị trí");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdvertisementPositionId"), 1L, 1);

                    b.Property<string>("AdvertisementPositionName")
                        .HasColumnType("nvarchar(max)")
                        .HasComment("Tên vị trí");

                    b.Property<int>("AdvertisementPositionSortOrder")
                        .HasColumnType("int")
                        .HasComment("Thứ tự sắp xếp vị trí");

                    b.Property<int>("AdvertisementPositionStatus")
                        .HasColumnType("int")
                        .HasComment("trạng thái vị trí đã kích hoạt hay chưa");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2")
                        .HasComment("Ngày tạo");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2")
                        .HasComment("Thời gian sửa gần nhất");

                    b.HasKey("AdvertisementPositionId");

                    b.ToTable("AdvertisementPosition", (string)null);

                    b.HasComment("Bảng thông tin vị trí banner, quảng cáo");
                });

            modelBuilder.Entity("ChinaAPICommon.Database.AdvertisementsDb", b =>
                {
                    b.Property<int>("AdvertisementId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Id Banner, quảng cáo");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdvertisementId"), 1L, 1);

                    b.Property<string>("AdvertisementApp")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasComment("chức năng trên trang (vd: là banner, hay là quảng cáo, ...)");

                    b.Property<string>("AdvertisementDescription")
                        .HasColumnType("varchar(MAX)")
                        .HasComment("Mô tả của banner");

                    b.Property<string>("AdvertisementImage")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasComment("Ảnh banner hoặc quảng cáo");

                    b.Property<int>("AdvertisementLanguage")
                        .HasMaxLength(10)
                        .HasColumnType("int")
                        .HasComment("Ngôn ngữ của item");

                    b.Property<string>("AdvertisementLink")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasComment("Đường dẫn của banner");

                    b.Property<string>("AdvertisementName")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasComment("Tên banner, quảng cáo");

                    b.Property<int>("AdvertisementPositonId")
                        .HasColumnType("int")
                        .HasComment("Vị trí cùa banner");

                    b.Property<string>("AdvertisementSortOrder")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasComment("Thứ tự sấp xếp");

                    b.Property<int?>("AdvertisementStatus")
                        .HasMaxLength(10)
                        .HasColumnType("int")
                        .HasComment("Trạng thái ( đã kích hoạt hay chưa)");

                    b.Property<int>("AdvertisementTarget")
                        .HasMaxLength(10)
                        .HasColumnType("int")
                        .HasComment("Cách chuyển trang khi nhấn vào link");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2")
                        .HasComment("Thời gian tạo");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2")
                        .HasComment("Thời gian sừa gần nhất");

                    b.HasKey("AdvertisementId");

                    b.ToTable("Advertisements", (string)null);

                    b.HasComment("Bảng lưu thông tin banner, quảng cáo, ...");
                });

            modelBuilder.Entity("ChinaAPICommon.Database.GroupDb", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Id danh mục");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GroupId"), 1L, 1);

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2")
                        .HasComment("Ngày tạo");

                    b.Property<string>("GroupApp")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasComment("Chức năng danh mục(là sản phẩm hay tin tức");

                    b.Property<int>("GroupLanguage")
                        .HasMaxLength(1)
                        .HasColumnType("int")
                        .HasComment("Ngôn ngữ của danh mục");

                    b.Property<int>("GroupLevel")
                        .HasMaxLength(5)
                        .HasColumnType("int")
                        .HasComment("Cấp của danh mục");

                    b.Property<string>("GroupLink")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasComment("Link danh mục");

                    b.Property<string>("GroupName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasComment("Tên danh mục");

                    b.Property<int>("GroupStatus")
                        .HasMaxLength(2)
                        .HasColumnType("int")
                        .HasComment("Trạng thái danh mục");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2")
                        .HasComment("Thời gian sửa gần nhất");

                    b.Property<int>("ParentGroupId")
                        .HasMaxLength(10)
                        .HasColumnType("int")
                        .HasComment("Id danh mục cha");

                    b.HasKey("GroupId");

                    b.ToTable("Group", (string)null);

                    b.HasComment("Bảng thông tin các danh mục");
                });

            modelBuilder.Entity("ChinaAPICommon.Database.GroupItemsDb", b =>
                {
                    b.Property<int>("GroupItemsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Id bảng liên kết");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GroupItemsId"), 1L, 1);

                    b.Property<int>("GroupId")
                        .HasColumnType("int")
                        .HasComment("Id bảng Group");

                    b.Property<int>("ItemId")
                        .HasColumnType("int")
                        .HasComment("Id bảng Item");

                    b.HasKey("GroupItemsId");

                    b.HasIndex("GroupId");

                    b.HasIndex("ItemId");

                    b.ToTable("GroupItems", (string)null);

                    b.HasComment("Bảng liên kết danh mục và sản phẩm");
                });

            modelBuilder.Entity("ChinaAPICommon.Database.ImageDb", b =>
                {
                    b.Property<int>("ImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("ID ảnh");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ImageId"), 1L, 1);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2")
                        .HasComment("Ngày tạo");

                    b.Property<string>("ImageApp")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasComment("Nơi hiển thị ảnh ( sản phẩm hay tin tức)");

                    b.Property<string>("ImageCode")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasComment("Id Ảnh trên cloud");

                    b.Property<string>("ImageLink")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasComment("Link đến ảnh");

                    b.Property<string>("ImageTitle")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasComment("Tên ảnh");

                    b.Property<int>("ItemId")
                        .HasMaxLength(10)
                        .HasColumnType("int")
                        .HasComment("id trùng với id sản phẩm hoặc id bài viết");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2")
                        .HasComment("Thời gian sửa gần nhất");

                    b.HasKey("ImageId");

                    b.HasIndex("ItemId");

                    b.ToTable("Image", (string)null);

                    b.HasComment("bảng ảnh sản phẩm, tin tức, ...");
                });

            modelBuilder.Entity("ChinaAPICommon.Database.ItemDb", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Id item");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ItemId"), 1L, 1);

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2")
                        .HasComment("Ngày tạo");

                    b.Property<string>("ItemApp")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasComment("Chức năng item( là sản phẩm hay tin tức)");

                    b.Property<string>("ItemAuthor")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasComment("Tác giả tạo item");

                    b.Property<int>("ItemCode")
                        .HasMaxLength(20)
                        .HasColumnType("int")
                        .HasComment("Mã Item");

                    b.Property<string>("ItemContent")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasComment("Mô tả item");

                    b.Property<string>("ItemDescription")
                        .HasColumnType("varchar(MAX)")
                        .HasComment("Chi tiết item");

                    b.Property<string>("ItemImage")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasComment("Ảnh item");

                    b.Property<string>("ItemImageId")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasComment("Id ảnh trên Cloud");

                    b.Property<int>("ItemLanguage")
                        .HasMaxLength(10)
                        .HasColumnType("int")
                        .HasComment("Ngôn ngữ của Item");

                    b.Property<string>("ItemLink")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasComment("Đường dẫn item");

                    b.Property<string>("ItemMetaDescription")
                        .HasColumnType("varchar(MAX)")
                        .HasComment("chi tiết item(SEO)");

                    b.Property<string>("ItemMetaKeywords")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasComment("Từ khóa item(SEO)");

                    b.Property<string>("ItemMetaTitle")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasComment("Tên item(phục vụ SEO)");

                    b.Property<decimal>("ItemPriceNew")
                        .HasColumnType("decimal(18,4)")
                        .HasComment("Giá (khi có khuyến mãi)");

                    b.Property<decimal>("ItemPriceOld")
                        .HasColumnType("decimal(18,4)")
                        .HasComment("Giá (chưa khuyến mãi)");

                    b.Property<int>("ItemSortOrder")
                        .HasMaxLength(10)
                        .HasColumnType("int")
                        .HasComment("Thứ tự sắp xếp");

                    b.Property<int>("ItemStatus")
                        .HasMaxLength(1)
                        .HasColumnType("int")
                        .HasComment("Trạng thái item");

                    b.Property<string>("ItemTag")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasComment("Từ khóa nổi bật item");

                    b.Property<string>("ItemTitle")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasComment("Tên item");

                    b.Property<int>("ItemTotalView")
                        .HasMaxLength(10)
                        .HasColumnType("int")
                        .HasComment("Lượt xem");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2")
                        .HasComment("Thời gian sửa gần nhất");

                    b.HasKey("ItemId");

                    b.ToTable("Items", (string)null);

                    b.HasComment("Bảng thông tin item");
                });

            modelBuilder.Entity("ChinaAPICommon.Database.MenuDb", b =>
                {
                    b.Property<int>("MenuId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Id menu");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MenuId"), 1L, 1);

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2")
                        .HasComment("Ngày tạo");

                    b.Property<string>("MenuApp")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasComment("Loại menu(Menu bottom , menu header)");

                    b.Property<string>("MenuImage")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasComment("Ảnh menu");

                    b.Property<int>("MenuLanguage")
                        .HasMaxLength(1)
                        .HasColumnType("int")
                        .HasComment("Ngôn ngữ menu");

                    b.Property<int>("MenuLevel")
                        .HasMaxLength(5)
                        .HasColumnType("int")
                        .HasComment("Cấp menu");

                    b.Property<string>("MenuLink")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasComment("Link menu");

                    b.Property<string>("MenuName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasComment("Tên menu");

                    b.Property<int>("MenuSort")
                        .HasMaxLength(5)
                        .HasColumnType("int")
                        .HasComment("Thứ tự menu");

                    b.Property<int>("MenuStatus")
                        .HasMaxLength(1)
                        .HasColumnType("int")
                        .HasComment("Trạng thái menu");

                    b.Property<int>("MenuTarget")
                        .HasMaxLength(5)
                        .HasColumnType("int")
                        .HasComment("Cách chuyển trang menu");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2")
                        .HasComment("Thời gian sửa gần nhất");

                    b.Property<int>("ParentMenuId")
                        .HasMaxLength(5)
                        .HasColumnType("int")
                        .HasComment("Id menu cha");

                    b.HasKey("MenuId");

                    b.ToTable("Menu", (string)null);

                    b.HasComment("Bảng menu");
                });

            modelBuilder.Entity("ChinaAPICommon.Database.NotificationDb", b =>
                {
                    b.Property<int>("BillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Id Đơn hàng");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BillId"), 1L, 1);

                    b.Property<string>("BillAddress")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasComment("Địa chỉ khachs hàng");

                    b.Property<int>("BillCode")
                        .HasMaxLength(20)
                        .HasColumnType("int")
                        .HasComment("Mã đơn hàng");

                    b.Property<string>("BillEmail")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasComment("Email khách hàng");

                    b.Property<int>("BillGender")
                        .HasMaxLength(10)
                        .HasColumnType("int")
                        .HasComment("Giới tính khách hàng");

                    b.Property<string>("BillMessage")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasComment("Tin nhấn của khách hàng");

                    b.Property<string>("BillName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasComment("Tên khách hàng");

                    b.Property<string>("BillParam")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasComment("thông tin thêm của đơn hàng");

                    b.Property<string>("BillPhone")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)")
                        .HasComment("Số điện thoại khách hàng");

                    b.Property<int?>("BillStatus")
                        .HasMaxLength(10)
                        .HasColumnType("int")
                        .HasComment("Trạng thái đơn hàng");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2")
                        .HasComment("Ngày tạo");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2")
                        .HasComment("Thời gian sửa gần nhất");

                    b.HasKey("BillId");

                    b.ToTable("Bills", (string)null);

                    b.HasComment("Bảng lưu thông tin đơn hàng");
                });

            modelBuilder.Entity("ChinaAPICommon.Database.RoleDb", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("ID quyền");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleId"), 1L, 1);

                    b.Property<int>("AccountId")
                        .HasColumnType("int")
                        .HasComment("ID User");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2")
                        .HasComment("Ngày tạo");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2")
                        .HasComment("Thời gian sửa gần nhất");

                    b.Property<string>("RoleDescription")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasComment("Mô tả quyền");

                    b.Property<string>("RoleName")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasComment("Tên quyền");

                    b.Property<int>("RoleStatus")
                        .HasMaxLength(1)
                        .HasColumnType("int")
                        .HasComment("Trạng thái quyền");

                    b.HasKey("RoleId");

                    b.HasIndex("AccountId");

                    b.ToTable("Role", (string)null);

                    b.HasComment("bảng quyền người dùng");
                });

            modelBuilder.Entity("ChinaAPICommon.Database.GroupItemsDb", b =>
                {
                    b.HasOne("ChinaAPICommon.Database.GroupDb", "GroupDb")
                        .WithMany()
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_GroupItem_Group");

                    b.HasOne("ChinaAPICommon.Database.ItemDb", "ItemDb")
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_GroupItem_Item");

                    b.Navigation("GroupDb");

                    b.Navigation("ItemDb");
                });

            modelBuilder.Entity("ChinaAPICommon.Database.ImageDb", b =>
                {
                    b.HasOne("ChinaAPICommon.Database.ItemDb", "ItemDb")
                        .WithMany("ImageDb")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ItemDb");
                });

            modelBuilder.Entity("ChinaAPICommon.Database.RoleDb", b =>
                {
                    b.HasOne("ChinaAPICommon.Database.AccountDb", "AccountDb")
                        .WithMany("RoleDb")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AccountDb");
                });

            modelBuilder.Entity("ChinaAPICommon.Database.AccountDb", b =>
                {
                    b.Navigation("RoleDb");
                });

            modelBuilder.Entity("ChinaAPICommon.Database.ItemDb", b =>
                {
                    b.Navigation("ImageDb");
                });
#pragma warning restore 612, 618
        }
    }
}
