using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChinaAPICommon.Enum;

namespace ChinaAPICommon.Database
{
    /// <summary>
    /// Bảng lưu thông tin các vị trí xuất hiện banner, quảng cáo trên website
    /// </summary>
    public class AdvertisementPositionDb
    {
        /// <summary>
        /// Id
        /// </summary>
        public int AdvertisementPositionId { get; set; }
        /// <summary>
        /// Tên (vị trí xuất hiện (vd:banner đầu trang, ..))
        /// </summary>
        public string? AdvertisementPositionName { get; set; }
        /// <summary>
        /// Trạng thái của vị trí(1 là kích hoạt, 0 là chưa kích hoạt)
        /// </summary>
        public EnumStatus AdvertisementPositionStatus { get; set; }
        /// <summary>
        /// Thứ tự của các vị trí
        /// </summary>
        public int AdvertisementPositionSortOrder { get; set; }
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
