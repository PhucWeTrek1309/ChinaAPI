using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChinaAPICommon.Enum;

namespace ChinaAPICommon.DTO
{
    public class ServicesResult
    {
        public Boolean IsSuccess;
        public MyErrorCode? ErrorCode;
        public int? NumberOfAffectedRows;
        public object? Error;
    }
}
