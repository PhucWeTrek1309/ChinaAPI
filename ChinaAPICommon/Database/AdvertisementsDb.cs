using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChinaAPICommon.Enum;

namespace ChinaAPICommon.Database
{
    /// <summary>
    ///  Bảng lưu thông tin, hình ảnh các banner và quảng cáo
    /// </summary>
    public class AdvertisementsDb
    {
        /// <summary>
        /// Id
        /// </summary>
        public int AdvertisementId { get; set; }
        /// <summary>
        /// id vị trí xuất hiện ( = Id bảng positionAdvertisement)
        /// </summary>
        public int AdvertisementPositonId { get; set; }
        /// <summary>
        /// Tên banner hoặc quảng cáo ( nếu là banner sẽ dùng title lam thuộc tính alt)
        /// </summary>
        public string? AdvertisementName { get; set; }
        /// <summary>
        /// chức năng trên trang (vd: là banner, hay là quảng cáo, ...)
        /// </summary>
        public string? AdvertisementApp { get; set; }
        /// <summary>
        /// Ngôn ngữ ()
        /// </summary>
        public int AdvertisementLanguage { get; set; }
        /// <summary>
        /// Đường dần (nếu có)
        /// </summary>
        public string? AdvertisementLink { get; set; }
        /// <summary>
        /// Cách chuyển trang (khi có link mở ờ cửa sổ hiện tại hay cửa sổ mới)
        /// </summary>
        public int AdvertisementTarget { get; set; }
        /// <summary>
        /// Mô tả về quảng cáo hoặc banner
        /// </summary>
        public string? AdvertisementDescription { get; set; }
        /// <summary>
        /// Ảnh
        /// </summary>
        public string? AdvertisementImage { get; set; }
        /// <summary>
        /// Thứ tự sắp xếp
        /// </summary>
        public string? AdvertisementSortOrder { get; set; }
        /// <summary>
        /// Trạng thái ( 1 là kích hoạt, 0 là chưa kích hoạt)
        /// </summary>
        public EnumStatus? AdvertisementStatus { get; set; }
        /// <summary>
        /// Thời gian tạo tài khoản (lấy thời gian now = Hiện tại)
        /// </summary>
        public DateTime? CreateDate { get; set; } = DateTime.Now;
        /// <summary>
        /// Thời gian có chỉnh sửa với tài khoản
        /// </summary>
        public DateTime? ModifiedDate { get; set; } 
    }
}
