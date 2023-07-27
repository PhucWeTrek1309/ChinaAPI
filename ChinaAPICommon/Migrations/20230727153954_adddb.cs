using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChinaAPICommon.Migrations
{
    public partial class adddb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    AccountId = table.Column<int>(type: "int", nullable: false, comment: "Id tài khoản")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountCode = table.Column<int>(type: "int", maxLength: 100, nullable: false, comment: "Mã tài khoản"),
                    AccountName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Tên đăng nhập"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, comment: "FirstName tài khoản"),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, comment: "LastName tài khoản"),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, comment: "Email tài khoản"),
                    PhoneNumber = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, comment: "Phone tài khoản"),
                    AccountStatus = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "varchar(MAX)", nullable: true, comment: "Trạng thái tài khoản"),
                    Token = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, comment: "Mã Token tài khoản"),
                    RefreshToken = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, comment: "Mã refreshToken tài khoản"),
                    CreatedRefreshToken = table.Column<DateTime>(type: "datetime2", maxLength: 500, nullable: false, comment: "Thời gian tạo RefreshToken"),
                    ExpiresRefreshToken = table.Column<DateTime>(type: "datetime2", maxLength: 500, nullable: false, comment: "Thời gian refreshToken hết hạn"),
                    CreateToken = table.Column<DateTime>(type: "datetime2", maxLength: 500, nullable: false, comment: "Thời gian tạo Token"),
                    ExpiresToken = table.Column<DateTime>(type: "datetime2", maxLength: 500, nullable: false, comment: "Thời gian Token hết hạn"),
                    CreateDate = table.Column<DateTime>(type: "datetime2", maxLength: 500, nullable: false, comment: "Thời gian tạo tài khoản"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", maxLength: 500, nullable: false, comment: "Thời gian gần nhất chỉnh sửa tài khoản")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.AccountId);
                },
                comment: "Bảng thông tin tài khoản");

            migrationBuilder.CreateTable(
                name: "AdvertisementPosition",
                columns: table => new
                {
                    AdvertisementPositionId = table.Column<int>(type: "int", nullable: false, comment: "Id vị trí")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdvertisementPositionName = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "Tên vị trí"),
                    AdvertisementPositionStatus = table.Column<int>(type: "int", nullable: false, comment: "trạng thái vị trí đã kích hoạt hay chưa"),
                    AdvertisementPositionSortOrder = table.Column<int>(type: "int", nullable: false, comment: "Thứ tự sắp xếp vị trí"),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Ngày tạo"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Thời gian sửa gần nhất")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvertisementPosition", x => x.AdvertisementPositionId);
                },
                comment: "Bảng thông tin vị trí banner, quảng cáo");

            migrationBuilder.CreateTable(
                name: "Advertisements",
                columns: table => new
                {
                    AdvertisementId = table.Column<int>(type: "int", nullable: false, comment: "Id Banner, quảng cáo")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdvertisementPositonId = table.Column<int>(type: "int", nullable: false, comment: "Vị trí cùa banner"),
                    AdvertisementName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Tên banner, quảng cáo"),
                    AdvertisementApp = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, comment: "chức năng trên trang (vd: là banner, hay là quảng cáo, ...)"),
                    AdvertisementLanguage = table.Column<int>(type: "int", maxLength: 10, nullable: false, comment: "Ngôn ngữ của item"),
                    AdvertisementLink = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Đường dẫn của banner"),
                    AdvertisementTarget = table.Column<int>(type: "int", maxLength: 10, nullable: false, comment: "Cách chuyển trang khi nhấn vào link"),
                    AdvertisementDescription = table.Column<string>(type: "varchar(MAX)", nullable: true, comment: "Mô tả của banner"),
                    AdvertisementImage = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, comment: "Ảnh banner hoặc quảng cáo"),
                    AdvertisementSortOrder = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, comment: "Thứ tự sấp xếp"),
                    AdvertisementStatus = table.Column<int>(type: "int", maxLength: 10, nullable: true, comment: "Trạng thái ( đã kích hoạt hay chưa)"),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Thời gian tạo"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Thời gian sừa gần nhất")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Advertisements", x => x.AdvertisementId);
                },
                comment: "Bảng lưu thông tin banner, quảng cáo, ...");

            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
                    BillId = table.Column<int>(type: "int", nullable: false, comment: "Id Đơn hàng")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BillCode = table.Column<int>(type: "int", maxLength: 20, nullable: false, comment: "Mã đơn hàng"),
                    BillGender = table.Column<int>(type: "int", maxLength: 10, nullable: false, comment: "Giới tính khách hàng"),
                    BillName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, comment: "Tên khách hàng"),
                    BillPhone = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true, comment: "Số điện thoại khách hàng"),
                    BillEmail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, comment: "Email khách hàng"),
                    BillAddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, comment: "Địa chỉ khachs hàng"),
                    BillMessage = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, comment: "Tin nhấn của khách hàng"),
                    BillParam = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, comment: "thông tin thêm của đơn hàng"),
                    BillStatus = table.Column<int>(type: "int", maxLength: 10, nullable: true, comment: "Trạng thái đơn hàng"),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Ngày tạo"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Thời gian sửa gần nhất")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.BillId);
                },
                comment: "Bảng lưu thông tin đơn hàng");

            migrationBuilder.CreateTable(
                name: "Group",
                columns: table => new
                {
                    GroupId = table.Column<int>(type: "int", nullable: false, comment: "Id danh mục")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentGroupId = table.Column<int>(type: "int", maxLength: 10, nullable: false, comment: "Id danh mục cha"),
                    GroupLanguage = table.Column<int>(type: "int", maxLength: 1, nullable: false, comment: "Ngôn ngữ của danh mục"),
                    GroupApp = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, comment: "Chức năng danh mục(là sản phẩm hay tin tức"),
                    GroupLevel = table.Column<int>(type: "int", maxLength: 5, nullable: false, comment: "Cấp của danh mục"),
                    GroupName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, comment: "Tên danh mục"),
                    GroupStatus = table.Column<int>(type: "int", maxLength: 2, nullable: false, comment: "Trạng thái danh mục"),
                    GroupLink = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Link danh mục"),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Ngày tạo"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Thời gian sửa gần nhất")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Group", x => x.GroupId);
                },
                comment: "Bảng thông tin các danh mục");

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false, comment: "Id item")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemLanguage = table.Column<int>(type: "int", maxLength: 10, nullable: false, comment: "Ngôn ngữ của Item"),
                    ItemApp = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, comment: "Chức năng item( là sản phẩm hay tin tức)"),
                    ItemCode = table.Column<int>(type: "int", maxLength: 20, nullable: false, comment: "Mã Item"),
                    ItemTitle = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Tên item"),
                    ItemDescription = table.Column<string>(type: "varchar(MAX)", nullable: true, comment: "Chi tiết item"),
                    ItemContent = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, comment: "Mô tả item"),
                    ItemImageId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Id ảnh trên Cloud"),
                    ItemImage = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, comment: "Ảnh item"),
                    ItemAuthor = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, comment: "Tác giả tạo item"),
                    ItemMetaTitle = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Tên item(phục vụ SEO)"),
                    ItemMetaDescription = table.Column<string>(type: "varchar(MAX)", nullable: true, comment: "chi tiết item(SEO)"),
                    ItemMetaKeywords = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, comment: "Từ khóa item(SEO)"),
                    ItemTag = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Từ khóa nổi bật item"),
                    ItemLink = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Đường dẫn item"),
                    ItemPriceOld = table.Column<decimal>(type: "decimal(18,4)", nullable: false, comment: "Giá (chưa khuyến mãi)"),
                    ItemPriceNew = table.Column<decimal>(type: "decimal(18,4)", nullable: false, comment: "Giá (khi có khuyến mãi)"),
                    ItemTotalView = table.Column<int>(type: "int", maxLength: 10, nullable: false, comment: "Lượt xem"),
                    ItemSortOrder = table.Column<int>(type: "int", maxLength: 10, nullable: false, comment: "Thứ tự sắp xếp"),
                    ItemStatus = table.Column<int>(type: "int", maxLength: 1, nullable: false, comment: "Trạng thái item"),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Ngày tạo"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Thời gian sửa gần nhất")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ItemId);
                },
                comment: "Bảng thông tin item");

            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    MenuId = table.Column<int>(type: "int", nullable: false, comment: "Id menu")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentMenuId = table.Column<int>(type: "int", maxLength: 5, nullable: false, comment: "Id menu cha"),
                    MenuLanguage = table.Column<int>(type: "int", maxLength: 1, nullable: false, comment: "Ngôn ngữ menu"),
                    MenuApp = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, comment: "Loại menu(Menu bottom , menu header)"),
                    MenuLevel = table.Column<int>(type: "int", maxLength: 5, nullable: false, comment: "Cấp menu"),
                    MenuSort = table.Column<int>(type: "int", maxLength: 5, nullable: false, comment: "Thứ tự menu"),
                    MenuStatus = table.Column<int>(type: "int", maxLength: 1, nullable: false, comment: "Trạng thái menu"),
                    MenuTarget = table.Column<int>(type: "int", maxLength: 5, nullable: false, comment: "Cách chuyển trang menu"),
                    MenuName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, comment: "Tên menu"),
                    MenuLink = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Link menu"),
                    MenuImage = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Ảnh menu"),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Ngày tạo"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Thời gian sửa gần nhất")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.MenuId);
                },
                comment: "Bảng menu");

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false, comment: "ID quyền")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Tên quyền"),
                    AccountId = table.Column<int>(type: "int", nullable: false, comment: "ID User"),
                    RoleDescription = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Mô tả quyền"),
                    RoleStatus = table.Column<int>(type: "int", maxLength: 1, nullable: false, comment: "Trạng thái quyền"),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Ngày tạo"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Thời gian sửa gần nhất")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.RoleId);
                    table.ForeignKey(
                        name: "FK_Role_Account_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Account",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "bảng quyền người dùng");

            migrationBuilder.CreateTable(
                name: "GroupItems",
                columns: table => new
                {
                    GroupItemsId = table.Column<int>(type: "int", nullable: false, comment: "Id bảng liên kết")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemId = table.Column<int>(type: "int", nullable: false, comment: "Id bảng Item"),
                    GroupId = table.Column<int>(type: "int", nullable: false, comment: "Id bảng Group")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupItems", x => x.GroupItemsId);
                    table.ForeignKey(
                        name: "FK_GroupItem_Group",
                        column: x => x.GroupId,
                        principalTable: "Group",
                        principalColumn: "GroupId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroupItem_Item",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Bảng liên kết danh mục và sản phẩm");

            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    ImageId = table.Column<int>(type: "int", nullable: false, comment: "ID ảnh")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemId = table.Column<int>(type: "int", maxLength: 10, nullable: false, comment: "id trùng với id sản phẩm hoặc id bài viết"),
                    ImageApp = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, comment: "Nơi hiển thị ảnh ( sản phẩm hay tin tức)"),
                    ImageLink = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, comment: "Link đến ảnh"),
                    ImageCode = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Id Ảnh trên cloud"),
                    ImageTitle = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, comment: "Tên ảnh"),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Ngày tạo"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Thời gian sửa gần nhất")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.ImageId);
                    table.ForeignKey(
                        name: "FK_Image_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "bảng ảnh sản phẩm, tin tức, ...");

            migrationBuilder.CreateIndex(
                name: "IX_GroupItems_GroupId",
                table: "GroupItems",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupItems_ItemId",
                table: "GroupItems",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Image_ItemId",
                table: "Image",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Role_AccountId",
                table: "Role",
                column: "AccountId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdvertisementPosition");

            migrationBuilder.DropTable(
                name: "Advertisements");

            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.DropTable(
                name: "GroupItems");

            migrationBuilder.DropTable(
                name: "Image");

            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "Group");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Account");
        }
    }
}
