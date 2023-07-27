using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinaAPICommon.Database
{
    /// <summary>
    /// Bảng liên kết bảng item và danh mục
    /// </summary>
    public class GroupItemsDb
    {
        /// <summary>
        /// Id
        /// </summary>
        public int GroupItemsId { get; set; }
        /// <summary>
        /// Id của item
        /// </summary>
        public int ItemId { get; set; }
        /// <summary>
        /// Id của danh mục
        /// </summary>
        public int GroupId { get; set; }

        public virtual ItemDb? ItemDb { get; set; }

        /// <summary>
        /// Đối tượng tham chiếu qua khóa ngoại: BlogItem
        /// </summary>
        public virtual GroupDb? GroupDb { get; set; }
    }
}
