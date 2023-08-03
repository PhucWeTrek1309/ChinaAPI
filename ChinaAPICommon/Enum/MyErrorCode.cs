﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinaAPICommon.Enum
{
    public enum MyErrorCode
    {
        /// <summary>
        /// Lỗi Exception
        /// </summary>
        Exception = 0,
        /// <summary>
        /// không tìm thấy bản ghi theo Id
        /// </summary>
        RecordByIdNotExist = 1,
        /// <summary>
        /// Không tìm thấy danh sách bản ghi
        /// </summary>
        ListRecordNotExist = 2,
        /// <summary>
        /// Bản ghi cập nhật không tồn tại
        /// </summary>
        UpdateNotExist = 3,
        /// <summary>
        /// Bản ghi cần xóa không tồn tại
        /// </summary>
        DeleteNotExist = 4,

        /// <summary>
        /// Dữ liệu quá độ dài cho phép
        /// </summary>
        DataOutLenth = 5,
        /// <summary>
        /// Email không đúng định dạng
        /// </summary>
        EmailInvalid = 6,
        /// <summary>
        /// Dữ liệu đầu vào bị trống
        /// </summary>
        RequiredValueIsEmpty = 7,
        /// <summary>
        /// Thêm dữ liệu thất bại 
        /// </summary>
        InsertError = 8,
        
    }
}
