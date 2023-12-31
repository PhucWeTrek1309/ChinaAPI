﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinaAPICommon.DTO
{
    public class PagingResult<T>
    {
        /// <summary>
        /// Tổng số trang
        /// </summary>
        public double TotalPage { get; set; }
        /// <summary>
        /// Tổng số bản ghi
        /// </summary>
        public int TotalRecord { get; set; }
        /// <summary>
        /// Danh sách item thỏa mãn điều kiện
        /// </summary>
        public List<T>? Data { get; set; }
    }
}
