using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChinaAPICommon.Enum;

namespace ChinaAPICommon.DTO
{
    public class DialogMessage
    {
        /// <summary>
        /// Mã Lỗi trả về
        /// </summary>
        public MyErrorCode ErrorCode { get; set; }
        /// <summary>
        /// Thông báo cho dev
        /// </summary>
        public string? DevMsg { get; set; }
        /// <summary>
        /// Thông báo cho người dùng
        /// </summary>
        public string? UserMsg { get; set; }
        /// <summary>
        /// Thông tin thêm
        /// </summary>
        public object? MoreInfo { get; set; }
        /// <summary>
        /// ID lỗi 
        /// </summary>
        public string? TradeId { get; set; }
    }
}
