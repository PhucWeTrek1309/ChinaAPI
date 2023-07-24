using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChinaAPICommon.Enum;

namespace ChinaAPICommon.CustomAttribute
{
    public class MyMaxLengthAttribute : Attribute
    {
        /// <summary>
        /// Chiều dài tối đa
        /// </summary>
        public int MaxLength { get; set; }

        /// <summary>
        /// Mã lỗi
        /// </summary>
        public MyErrorCode? ErrorCode { get; set; }

        public MyMaxLengthAttribute(int maxLength, MyErrorCode errorCode)
        {
            MaxLength = maxLength;

            ErrorCode = errorCode;
        }


    }
}
