using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChinaAPICommon.Enum;

namespace ChinaAPICommon.CustomAttribute
{
    public class EmailAttribute : Attribute
    {
        public MyErrorCode ErrorCode { get; set; }

    }
}
