using ChinaAPICommon.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinaAPICommon.Database
{
    /// <summary>
    /// Bảng danh mục (sản phẩm, tin tức, ...)
    /// </summary>
    public class GroupDb
    {
        /// <summary>
        /// Id
        /// </summary>
        public int  GroupId { get; set; }
        /// <summary>
        /// Id Danh mục cha ( == id ở trên)
        /// </summary>
        public int ParentGroupId { get; set; }
        /// <summary>
        /// Ngôn ngữ
        /// </summary>
        public int GroupLanguage { get; set; }
        /// <summary>
        /// Đánh dấu là danh mục của sản phẩm hay tin tức
        /// </summary>
        public string? GroupApp { get; set; }
        /// <summary>
        /// đánh dấu là danh mục cấp bao nhiêu ()
        /// </summary>
        public int GroupLevel { get; set; }
        /// <summary>
        /// Tên danh mục
        /// </summary>
        public string? GroupName { get; set; }
        /// <summary>
        /// Trạng thái danh mục(1 là kích hoạt, 2 là chưa kích hoạt)
        /// </summary>
        public EnumStatus GroupStatus { get; set; }
        /// <summary>
        /// Đường dẫn danh mục
        /// </summary>
        public string? GroupLink { get; set; }
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
