using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChinaAPICommon.Enum;

namespace ChinaAPICommon.Database
{
    /// <summary>
    /// Bảng thông tin dơn hàng hoặc phản hồi của khách hàng
    /// </summary>
    public class NotificationDb
    {
        /// <summary>
        /// ID
        /// </summary>
        public int  BillId { get; set; }
        /// <summary>
        /// Mã đơn hàng
        /// </summary>
        public int BillCode { get; set; }
        /// <summary>
        /// Giới tính (0 là nữ, 1 là nam, 2 là khác)
        /// </summary>
        public Gender BillGender { get; set; }
        /// <summary>
        /// Tên khách hàng
        /// </summary>
        public string? BillName { get; set; }
        /// <summary>
        /// Số Điện thoại
        /// </summary>
        public string? BillPhone { get; set; }
        /// <summary>
        /// Email
        /// </summary>
        public string? BillEmail { get; set; }
        /// <summary>
        /// Địa chỉ
        /// </summary>
        public string? BillAddress { get; set; }
        /// <summary>
        /// Tin nhấn ( phản hồi,...)
        /// </summary>
        public string? BillMessage { get; set; }
        /// <summary>
        /// Thông tin thêm ( nếu sản phẩm có biến thể)
        /// </summary>
        public string? BillParam { get; set; }
        /// <summary>
        /// Trạng thái
        /// </summary>
        public EnumStatus? BillStatus { get; set; }
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
