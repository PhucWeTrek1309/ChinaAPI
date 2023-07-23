using ChinaAPICommon.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinaAPICommon.Database
{
    /// <summary>
    /// bản quản lý menu
    /// </summary>
    public class MenuDb
    {
        /// <summary>
        /// Id menu
        /// </summary>
        public int MenuId { get; set; }
        /// <summary>
        /// Id menu cha
        /// </summary>
        public int ParentMenuId { get; set; }
        /// <summary>
        /// Ngôn ngữ
        /// </summary>
        public int MenuLanguage { get; set; }
        /// <summary>
        /// Đánh dấu menu (menu header, menu bottom,...)
        /// </summary>
        public string? MenuApp { get; set;}
        /// <summary>
        /// Cấp menu
        /// </summary>
        public int MenuLevel { get; set;}
        /// <summary>
        /// Thứ tự menu
        /// </summary>
        public int MenuSort { get; set; }
        /// <summary>
        /// Trạng thái (1 là kích hoạt, 2 là chưa kích hoạt)
        /// </summary>
        public EnumStatus MenuStatus { get; set; }
        /// <summary>
        /// Cách chuyển khi có link
        /// </summary>
        public int MenuTarget { get; set; }
        /// <summary>
        /// Tên menu
        /// </summary>
        public string? MenuName { get; set; }
        /// <summary>
        /// Đường dẫ menu
        /// </summary>
        public string? MenuLink { get; set; }
        /// <summary>
        /// Ảnh menu
        /// </summary>
        public string? MenuImage { get; set; }
        /// <summary>
        /// Thời gian tạo tài khoản (lấy thời gian now = Hiện tại)
        /// </summary>
        public DateTime? CreateDate { get; set;} = DateTime.Now;
        /// <summary>
        /// Thời gian có chỉnh sửa với tài khoản
        /// </summary>
        public DateTime? ModifiedDate { get; set;}
    }
}
