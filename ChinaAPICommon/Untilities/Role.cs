using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinaAPICommon.Untilities
{
    public static class Role
    {
        #region AdvertisementPosition 0-3

        /// <summary>
        /// Xem AdvertisementPosition(vị trí banner, quảng cáo, ...)
        /// </summary>
        public static int ViewAdvertisementPosition = 0;

        /// <summary>
        /// Tạo AdvertisementPosition(vị trí banner, quảng cáo, ...)
        /// </summary>
        public static int CreateAdvertisementPosition = 1;

        /// <summary>
        /// Sửa AdvertisementPosition(vị trí banner, quảng cáo, ...)
        /// </summary>
        public static int EditAdvertisementPosition = 2;

        /// <summary>
        /// Xóa AdvertisementPosition(vị trí banner, quảng cáo, ...)
        /// </summary>
        public static int DeleteAdvertisementPosition = 3;

        #endregion


        #region Advertisement 4-7

        /// <summary>
        /// Xem Advertisement
        /// </summary>
        public static int ViewAdvertisement = 4;

        /// <summary>
        /// Tạo Advertisement
        /// </summary>
        public static int CreateAdvertisement = 5;

        /// <summary>
        /// Sửa Advertisement
        /// </summary>
        public static int EditAdvertisement = 6;

        /// <summary>
        /// Xóa Advertisement
        /// </summary>
        public static int DeleteAdvertisement = 7;

        #endregion

        #region Bill 8-11

        /// <summary>
        /// Xem Bill
        /// </summary>
        public static int ViewBill = 8;

        /// <summary>
        /// Tạo Bill
        /// </summary>
        public static int CreateBill = 9;

        /// <summary>
        /// Sửa Bill
        /// </summary>
        public static int EditBill = 10;

        /// <summary>
        /// Xóa Bill
        /// </summary>
        public static int DeleteBill = 11;

        #endregion

        #region Group 12-15

        /// <summary>
        /// Xem Group
        /// </summary>
        public static int ViewGroup = 12;

        /// <summary>
        /// Tạo Group
        /// </summary>
        public static int CreateGroup = 13;

        /// <summary>
        /// Sửa Group
        /// </summary>
        public static int EditGroup = 14;

        /// <summary>
        /// Xóa Group
        /// </summary>
        public static int DeleteGroup = 15;

        #endregion

        #region Item 16-19

        /// <summary>
        /// Xem Item
        /// </summary>
        public static int ViewItem = 16;

        /// <summary>
        /// Tạo Item
        /// </summary>
        public static int CreateItem = 17;

        /// <summary>
        /// Sửa Item
        /// </summary>
        public static int EditItem = 18;

        /// <summary>
        /// Xóa Item
        /// </summary>
        public static int DeleteItem = 19;

        #endregion

        #region WebsiteMenu 20-23

        /// <summary>
        /// Xem menu
        /// </summary>
        public static int ViewMenu = 21;

        /// <summary>
        /// Tạo menu
        /// </summary>
        public static int CreateMenu = 22;

        /// <summary>
        /// Sửa menu
        /// </summary>
        public static int EditMenu = 23;

        /// <summary>
        /// Xóa menu
        /// </summary>
        public static int DeleteMenu = 24;


        #endregion

        #region WebsiteInformation 25

        /// <summary>
        /// Chỉnh sửa thông tin website: Brand name; social link ...
        /// </summary>
        public static int WebsiteInformation = 25;

        #endregion

        #region WebsiteOptimizeSystem 26

        /// <summary>
        /// Chỉnh sửa thông tin website: Mã nhúng thẻ head + body; title website; meta
        /// </summary>
        public static int WebsiteOptimizeSystem = 26;

        #endregion

        #region WebsiteEmailSystem 27

        /// <summary>
        /// Chỉnh sửa thông tin email hệ thống dùng để gửi email thông báo
        /// </summary>
        public static int WebsiteEmailSystem = 27;

        #endregion

        #region WebsiteContact 28-31

        /// <summary>
        /// Xem danh sách các liên hệ
        /// </summary>
        public static int ViewContactDetail = 28;

        /// <summary>
        /// Tạo liên hệ
        /// </summary>
        public static int CreateContactDetail = 29;

        /// <summary>
        /// Sửa liên hệ
        /// </summary>
        public static int EditContactDetail = 30;

        /// <summary>
        /// xóa liên hệ
        /// </summary>
        public static int DeleteContactDetail = 31;

        #endregion

        #region BlogGroup 32-35

        /// <summary>
        /// Xem danh sách danh mục bài viết
        /// </summary>
        public static int ViewBlogGroup = 32;

        /// <summary>
        /// Tạo danh mục bài viết
        /// </summary>
        public static int CreateBlogGroup = 33;

        /// <summary>
        /// Sửa danh mục bài viết
        /// </summary>
        public static int EditBlogGroup = 34;

        /// <summary>
        /// xóa danh mục bài viết
        /// </summary>
        public static int DeleteBlogGroup = 35;

        #endregion

        /// <summary>
        /// Cấu hình trang blog
        /// </summary>
        public static int BlogConfiguration = 36;


        #region BlogItem 37-40

        /// <summary>
        /// Xem danh sách danh mục bài viết
        /// </summary>
        public static int ViewBlogItem = 37;

        /// <summary>
        /// Tạo danh mục bài viết
        /// </summary>
        public static int CreateBlogItem = 38;

        /// <summary>
        /// Sửa danh mục bài viết
        /// </summary>
        public static int EditBlogItem = 39;

        /// <summary>
        /// xóa danh mục bài viết
        /// </summary>
        public static int DeleteBlogItem = 40;

        #endregion


        #region Member 41-44

        /// <summary>
        /// Xem danh sách
        /// </summary>
        public static int ViewMember = 41;

        /// <summary>
        /// Tạo member
        /// </summary>
        public static int CreateMember = 42;

        /// <summary>
        /// Sửa member
        /// </summary>
        public static int EditMember = 43;

        /// <summary>
        /// xóa member
        /// </summary>
        public static int DeleteMember = 44;

        #endregion
    }
}
