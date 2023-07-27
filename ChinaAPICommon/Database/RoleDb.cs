using ChinaAPICommon.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinaAPICommon.Database
{
    /// <summary>
    /// Bảng quyền user
    /// </summary>
    public class RoleDb
    {
        /// <summary>
        /// Id quyền
        /// </summary>
        public int RoleId { get; set; }
        /// <summary>
        /// Tên quyền
        /// </summary>
        public string? RoleName { get; set; }
        /// <summary>
        /// Id user
        /// </summary>
        public int AccountId { get; set; }
        /// <summary>
        /// Mô tả quyền
        /// </summary>
        public string? RoleDescription { get; set; }
        /// <summary>
        /// Trạng thái (1 là kích hoạt, 2 là chưa kích hoạt)
        /// </summary>
        public EnumStatus RoleStatus { get; set; }
        /// <summary>
        /// Thời gian tạo tài khoản (lấy thời gian now = Hiện tại)
        /// </summary
        public DateTime CreateDate { set; get; } = DateTime.Now;
        /// <summary>
        /// Thời gian có chỉnh sửa với tài khoản
        /// </summary>
        public DateTime ModifiedDate { set; get; }

        public virtual AccountDb AccountDb { get; set; } = null!;
    }
}
