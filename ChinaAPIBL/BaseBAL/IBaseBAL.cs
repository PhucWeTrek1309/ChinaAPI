using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChinaAPICommon.DTO;
using Microsoft.AspNetCore.Http;

namespace ChinaAPI_BAL.BaseBAL
{
    public interface IBaseBAL<T> where T : class
    {
        /// <summary>
        /// Lấy chi tiết bản ghi theo ID
        /// </summary>
        /// <param name="id">ID của bản ghi</param>
        /// <returns>Thông tin chi tiết bản ghi</returns>
        Task<T> GetRecordById(int id);

        /// <summary>
        /// Lấy toàn bộ bản ghi
        /// </summary>
        /// <returns>toàn bộ bản ghi</returns>
        Task<List<T>> GetAllRecord();

        /// <summary>
        /// Tìm kiếm và phân trang
        /// </summary>
        /// <returns>Kết quả tìm kiếm và phân trang</returns>
        Task<PagingResult<T>> GetFilter(string? keyword, int limit, int offset);

        /// <summary>
        /// Thêm một bản ghi
        /// </summary>
        /// <param name="record">Đối tượng cần insert</param>
        /// <returns>Đối tượng đã insert</returns>
        Task<ServicesResult> Insert(T record);
        /// <summary>
        /// Thêm 1 bản ghi có ảnh
        /// </summary>
        /// <param name="record">Thông tin bản ghi</param>
        /// <param name="file">Ảnh hoặc file Media</param>
        /// <returns></returns>
        Task<ServicesResult> Insert(T record, IFormFile file);
        /// <summary>
        /// Sửa một bản ghi theo id
        /// </summary>
        /// <param name="id">Id của bản ghi</param>
        /// <param name="recordUpdated">Chi tiết bản ghi sau khi sửa</param>
        /// <returns>Số bản ghi bị ảnh hưởng</returns>
        Task<ServicesResult> Update(int id, T recordUpdated);
        Task<ServicesResult> Update(int id, T recordUpdated, IFormFile file);
        /// <summary>
        /// Xóa 1 bản ghi theo id
        /// </summary>
        /// <param name="id">id bản ghi cần xóa</param>
        /// <returns>Số dòng bị ảnh hưởng</returns>
        Task<ServicesResult> DeleteById(int id);
        Task<ServicesResult> DeleteById(int id, IFormFile file);
        /// <summary>
        /// Xóa nhiều bản ghi
        /// </summary>
        /// <param name="ids">danh sách id bản ghi cần xóa</param>
        /// <returns>Số lượng bản ghi đã xóa</returns>
        Task<ServicesResult> BatchDelete(List<int> ids);
        Task<ServicesResult> BatchDelete(List<int> ids, IFormFile file);

    }
}
