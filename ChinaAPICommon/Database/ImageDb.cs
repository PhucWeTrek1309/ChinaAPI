using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinaAPICommon.Database
{
    public class ImageDb
    {
        /// <summary>
        /// Id ảnh
        /// </summary>
        public int ImageId { get; set; }
        /// <summary>
        /// Id bài viết hoặc sản phâm (nhằm mục đích lưu nhiều ảnh)
        /// </summary>
        public int ItemId { get; set; }
        /// <summary>
        /// Ảnh của bài viết hay sản phẩm
        /// </summary>
        public string? ImageApp { get; set; }
        /// <summary>
        /// Link ảnh
        /// </summary>
        public string? ImageLink { get; set; }
        /// <summary>
        /// Id ảnh trên cloudDinary(phục vụ việc xóa ảnh)
        /// </summary>
        public string? ImageCode { get; set; }
        /// <summary>
        /// tên ảnh (để đưa vào thuộc tính alt của thẻ image)
        /// </summary>
        public string? ImageTitle { get; set; }
        /// <summary>
        /// Thời gian tạo tài khoản (lấy thời gian now = Hiện tại)
        /// </summary>
        public DateTime CreateDate { set; get; } = DateTime.Now;
        /// <summary>
        /// Thời gian có chỉnh sửa với tài khoản
        /// </summary>
        public DateTime ModifiedDate { set; get; }

        public virtual ItemDb ItemDb { get; set; } = null!;
    }
}
