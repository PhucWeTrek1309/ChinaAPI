using ChinaAPICommon.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinaAPICommon.Database
{
    /// <summary>
    /// Bảng thông tin Item
    /// </summary>
    public class ItemDb
    {
        /// <summary>
        /// Id item
        /// </summary>
        public int  ItemId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int  ItemLanguage { get; set; }
        /// <summary>
        /// Đánh dấu item (vd: product, news,...)
        /// </summary>
        public string? ItemApp { get; set; }
        /// <summary>
        /// Mã sản phẩm
        /// </summary>
        public int ItemCode { get; set; }
        /// <summary>
        /// Tên sản phẩm
        /// </summary>
        public string? ItemTitle { get; set; }
        /// <summary>
        /// Mô tả
        /// </summary>
        public string? ItemDescription { get; set; }
        /// <summary>
        /// Content sản phẩm
        /// </summary>
        public string? ItemContent { get; set; }
        /// <summary>
        /// Id ảnh lưu trên CloudDinary (Phục vụ xóa ảnh)
        /// </summary>
        public string? ItemImageId { get; set; }
        /// <summary>
        /// Ảnh item
        /// </summary>
        public string? ItemImage { get; set; }
        /// <summary>
        /// Tên người đăng
        /// </summary>
        public string? ItemAuthor { get; set; }
        /// <summary>
        /// Title (phục vụ SEO)
        /// </summary>
        public string? ItemMetaTitle { get; set; }
        /// <summary>
        /// Mô tả (phục vụ SEO)
        /// </summary>
        public string? ItemMetaDescription { get; set; }
        /// <summary>
        /// từ khóa phổ biến (phục vụ SEO)
        /// </summary>
        public string? ItemMetaKeywords { get; set; }
        /// <summary>
        /// từ khóa phổ biến
        /// </summary>
        public string? ItemTag { get; set; }
        /// <summary>
        /// Đường dẫn
        /// </summary>
        public string? ItemLink { get; set; }
        /// <summary>
        /// Giá gốc
        /// </summary>
        public decimal ItemPriceOld { get; set; }
        /// <summary>
        /// Giá khi có khuyến mãi
        /// </summary>
        public decimal ItemPriceNew { get; set; }
        /// <summary>
        /// Lượt xem
        /// </summary>
        public int ItemTotalView { get; set; }
        /// <summary>
        /// Thứ tự sắp xếp
        /// </summary>
        public int  ItemSortOrder { get; set; }
        /// <summary>
        /// Trạng thái (1 là kích hoạt, 2 là chưa kích hoạt)
        /// </summary>
        public EnumStatus  ItemStatus { get; set; }
        /// <summary>
        /// Thời gian tạo tài khoản (lấy thời gian now = Hiện tại)
        /// </summary
        public DateTime? CreateDate { get; set; } = DateTime.Now;
        /// <summary>
        /// Thời gian có chỉnh sửa với tài khoản
        /// </summary>
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<ImageDb> ImageDb { get; set; } = new List<ImageDb>();


    }
}
