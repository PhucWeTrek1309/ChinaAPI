﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChinaAPI_DAL.BaseDAL;
using ChinaAPICommon.CustomAttribute;
using ChinaAPICommon.DTO;

namespace ChinaAPI_BAL.BaseBAL
{
    public class BaseBAL<T> : IBaseBAL<T> where T : class
    {
        #region Field

        private readonly IBaseDAL<T> _baseDAL;


        #endregion

        #region Contructor

        public BaseBAL(IBaseDAL<T> baseDAL)
        {
            _baseDAL = baseDAL;
        }

        #endregion

        public async Task<T> GetRecordById(int id)
        {
            var record = await _baseDAL.GetRecordById(id);

            return record;
        }

        public async Task<List<T>> GetAllRecord()
        {
            var records = await _baseDAL.GetAllRecord();
            return records;
        }

        public async Task<PagingResult<T>> GetFilter(string? keyword, int limit, int offset)
        {
            return await _baseDAL.GetFilter(keyword ?? "", limit, offset);
        }

        public async Task<ServicesResult> Insert(T record)
        {
            var validateRequiredData = ValidateData<T>.ValidateRequiredData(record);
            if (!validateRequiredData.IsSuccess)
            {
                return validateRequiredData;
            }
            await _baseDAL.Insert(record);
            return new ServicesResult
            {
                IsSuccess = true
            };
        }

        public async Task<ServicesResult> Update(int id, T recordUpdated)
        {
            var validateRequiredData = ValidateData<T>.ValidateRequiredData(recordUpdated);
            if (!validateRequiredData.IsSuccess)
            {
                return validateRequiredData;
            }
            await _baseDAL.Update(id, recordUpdated);
            return new ServicesResult
            {
                IsSuccess = true
            };
        }

        public async Task<ServicesResult> DeleteById(int id)
        {
            var records = await _baseDAL.DeleteById(id);
            if (records > 0)
            {
                return new ServicesResult
                {
                    IsSuccess = true,
                };
            }
            return new ServicesResult
            {
                IsSuccess = false,
            };
        }

        public async Task<ServicesResult> BatchDelete(List<int> ids)
        {
            var records = await _baseDAL.BatchDelete(ids);
            if (records > 0)
            {
                return new ServicesResult
                {
                    IsSuccess = true,
                };
            }
            return new ServicesResult
            {
                IsSuccess = false,
            };
        }
    }
}
