using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChinaAPICommon.Enum;

namespace ChinaAPICommon.DTO
{
  
    public class ErrorException : Exception
    {
        /// <summary>
        /// mã lỗi 
        /// </summary>
        public MyErrorCode ErrorCode { get; set; }
        /// <summary>
        /// Chi tiết lỗi
        /// </summary>
        public string? ErrorMessage { get; set; }
    }
}




