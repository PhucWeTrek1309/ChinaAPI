using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChinaAPICommon.Enum;

namespace ChinaAPICommon.Database
{
    /// <summary>
    /// Bảng lưu thông tin tài khoản (User và admin)
    /// </summary>
    public class AccountDb
    {
        /// <summary>
        /// Id Tài khoản
        /// </summary>
        public int AccountId { get; set; }
        /// <summary>
        /// Mã tài khoản
        /// </summary>
        public int AccountCode { get; set; }
        /// <summary>
        /// Tên tài khoản( Tên đăng nhập)
        /// </summary>
        public string? AccountName { get; set; }
        /// <summary>
        /// Mã quyền tài khoản (Mã quyền ứng với Id ở bảng Role)
        /// </summary>
        public int RoleAccountId { get; set; }
        /// <summary>
        /// Họ
        /// </summary>
        public string? FirstName { get; set; }
        /// <summary>
        /// Tên
        /// </summary>
        public string? LastName { get; set; }
        /// <summary>
        /// Email tài khoản
        /// </summary>
        public string? Email { get; set; }
        /// <summary>
        /// Số điện thoại liên hệ
        /// </summary>
        public string? PhoneNumber { get; set; }
        /// <summary>
        /// Trạng thái tài khoản (0 là chưa kích hoạt, 1 là đã kích hoạt)
        /// </summary>
        public EnumStatus AccountStatus { get; set; }
        /// <summary>
        /// Ảnh (Avatar người dùng)
        /// </summary>
        public string? Image { get; set; }
        /// <summary>
        /// Mă token (khi đăng nhập thành công )
        /// </summary>
        public string? Token { get; set; }
        /// <summary>
        /// Mã refreshToken dùng để cấp lại Token khi Token hết hạn
        /// </summary>
        public string? RefreshToken { get; set; }
        /// <summary>
        /// Thời gian tạo refreahToken
        /// </summary>
        public DateTime CreatedRefreshToken { set; get; }
        /// <summary>
        /// Thời gian RefreshToken Hết hạn
        /// </summary>
        public DateTime ExpiresRefreshToken { set; get; }
        /// <summary>
        /// Thời gian tạo Token
        /// </summary>
        public DateTime CreateToken { set; get; }
        /// <summary>
        /// Thời gian Token hết hạn
        /// </summary>
        public DateTime ExpiresToken { set; get; }
        /// <summary>
        /// Thời gian tạo tài khoản (lấy thời gian now = Hiện tại)
        /// </summary>
        public DateTime CreateDate { set; get; } = DateTime.Now;
        /// <summary>
        /// Thời gian có chỉnh sửa với tài khoản
        /// </summary>
        public DateTime ModifiedDate { set; get; }

    }
}
