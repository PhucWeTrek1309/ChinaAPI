﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ChinaAPICommon;
using ChinaAPICommon.CustomAttribute;
using ChinaAPICommon.DTO;
using ChinaAPICommon.EFContext;
using ChinaAPICommon.Enum;
using Microsoft.EntityFrameworkCore;

namespace ChinaAPI_DAL.BaseDAL
{
    public class BaseDAL<T> : IBaseDAL<T> where T : class
    {
        #region field

        private readonly MyDbContext? _dbContext;

        #endregion

        #region Constructor

        public BaseDAL(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        #endregion

        #region Function
        /// <summary>
        /// Lấy bản ghi theo ID
        /// </summary>
        /// <param name="id">Id bản ghi muốn lấy</param>
        /// <returns>Bản ghi cần lấy</returns>
        /// <exception cref="ErrorException">ID không tồn tại</exception>
        public async Task<T> GetRecordById(int id)
        {
            var record = await _dbContext!.Set<T>().FindAsync(id);
            if (record == null)
            {
                throw new ErrorException()
                {
                    ErrorCode = MyErrorCode.RecordByIdNotExist,
                    ErrorMessage = Resource.RecordByIdNotExist
                };
            }
            return record;
        }
        /// <summary>
        /// Lấy danh sách bản ghi
        /// </summary>
        /// <returns>Danh sách bản ghi cần lấy</returns>
        /// <exception cref="ErrorException">Danh sách bản ghi không tồn tại</exception>
        public async Task<List<T>> GetAllRecord()
        {
            var record = await _dbContext!.Set<T>().ToListAsync();
            if (record == null)
            {
                throw new ErrorException()
                {
                    ErrorCode = MyErrorCode.ListRecordNotExist,
                    ErrorMessage = Resource.ListRecordNotExist
                };
            }
            return record;
        }
        /// <summary>
        /// Lấy danh sách bản ghi có phân trang và tìm kiếm
        /// </summary>
        /// <param name="keyword">Từ khóa cần tìm</param>
        /// <param name="limit">Số bản ghi trên 1 trang</param>
        /// <param name="offset">Trang bắt đầu</param>
        /// <returns>Danh sách bản ghi thỏa mãn</returns>
        public async Task<PagingResult<T>> GetFilter(string keyword, int limit, int offset)
        {
            var query = _dbContext!.Set<T>().AsQueryable();
            // Tạo biến để lưu các trường có attribute là search
            var searchableProperties = new List<string>();
            // dùng vòng lặp qua các attribute, sau đó lấy ra các trường thỏa mãn
            var properties = typeof(T).GetProperties();
            foreach (var property in properties)
            {
                var searchAttribute = property.GetCustomAttributes(typeof(SearchAttribute), false).FirstOrDefault();
                if (searchAttribute != null)
                {
                    searchableProperties.Add(property.Name);
                }
            }

            if (!string.IsNullOrEmpty(keyword) && searchableProperties.Any())
            {
                // Tạo biểu thức lambda để tìm kiếm keyword trong các trường có attribute [Search]
                var parameter = Expression.Parameter(typeof(T), "x");
                var keywordExpression = Expression.Constant(keyword, typeof(string));
                var containsMethod = typeof(string).GetMethod("Contains", new[] { typeof(string) });

                var searchConditions = new List<Expression>();
                foreach (var propertyName in searchableProperties)
                {
                    var property = Expression.Property(parameter, propertyName);
                    if (containsMethod != null)
                    {
                        var containsExpression = Expression.Call(property, containsMethod, keywordExpression);
                        searchConditions.Add(containsExpression);
                    }
                }

                var searchPredicate = Expression.Lambda<Func<T, bool>>(searchConditions.Aggregate(Expression.OrElse), parameter);
                query = query.Where(searchPredicate);
            }

            var totalRecord = await query.CountAsync();

            if (limit <= 0)
            {
                limit = 20;

            }

            if (offset <= 0)
            {
                offset = 1;
            }

            var totalPage = Math.Ceiling((double)totalRecord / limit);

            var records = await query.Skip(limit * (offset - 1)).Take(limit).ToListAsync();
            var recordFilter = new PagingResult<T>()
            {
                TotalPage = totalPage,
                TotalRecord = totalRecord,
                Data = records
            };
            return recordFilter;
        }
        /// <summary>
        /// Thêm 1 bản ghi
        /// </summary>
        /// <param name="record">Thông tin bản ghi cẩn thẻm</param>
        /// <returns></returns>
        public async Task<int> Insert(T record)
        {
            _dbContext!.Set<T>().Add(record);
            return await _dbContext.SaveChangesAsync();
        }
        /// <summary>
        /// Sửa 1 bản ghi theo ID
        /// </summary>
        /// <param name="id">Id bản ghi cần sửa</param>
        /// <param name="recordUpdated">Thông tin bản ghi cần sửa</param>
        /// <returns></returns>
        /// <exception cref="Exception">Không tìm thấy bản ghi cần sửa</exception>
        public async Task<int> Update(int id, T recordUpdated)
        {
            var entity = await _dbContext!.Set<T>().FindAsync(id);
            if (entity is null)
            {
                throw new ErrorException()
                {
                    ErrorCode = MyErrorCode.UpdateNotExist,
                    ErrorMessage = Resource.UpdateNotExist
                };
            }

            _dbContext.Entry(entity).CurrentValues.SetValues(recordUpdated);
            _dbContext.Update(entity);
            return await _dbContext.SaveChangesAsync();
        }
        /// <summary>
        /// Xóa 1 bản ghi theo ID
        /// </summary>
        /// <param name="id">Id bản ghi cần xóa</param>
        /// <returns>Id bản ghi vừa xóa</returns>
        /// <exception cref="ErrorException">Không tìm thấy bản ghi cần xóa</exception>
        public async Task<int> DeleteById(int id)
        {
            var record = await _dbContext!.Set<T>().FindAsync(id);
            if (record is null)
            {
                throw new ErrorException()
                {
                    ErrorCode = MyErrorCode.DeleteNotExist,
                    ErrorMessage = Resource.DeleteNotExist
                };
            }

            _dbContext.Set<T>().Remove(record);
            return await _dbContext.SaveChangesAsync();
        }
        /// <summary>
        /// Xóa nhiều bản ghi theo danh sách id
        /// </summary>
        /// <param name="ids">Danh sách id cần xóa</param>
        /// <returns>Danh sách id vừa xóa</returns>
        /// <exception cref="ErrorException">Không tìm thấy bản ghi cần xóa</exception>
        public async Task<int> BatchDelete(List<int>? ids)
        {
            if (ids == null || !ids.Any())
                throw new ErrorException()
                {
                    ErrorCode = MyErrorCode.DeleteNotExist,
                    ErrorMessage = Resource.DeleteNotExist
                };
            foreach (var id in ids)
            {
                var record = await _dbContext!.Set<T>().FindAsync(id);
                if (record != null)
                    _dbContext.Set<T>().Remove(record);
            }

            return await _dbContext!.SaveChangesAsync();
        } 

        #endregion

    }
}