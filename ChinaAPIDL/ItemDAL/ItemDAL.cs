using ChinaAPI_DAL.BaseDAL;
using ChinaAPICommon.Database;
using ChinaAPICommon.EFContext;
using CloudinaryDotNet;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinaAPI_DAL.ItemDAL
{
    public class ItemDAL : BaseDAL<ItemDb>, IItemDAL
    {
        private readonly MyDbContext? _dbContext;
        public ItemDAL(MyDbContext dbContext, Cloudinary cloudinary) : base(dbContext, cloudinary)
        {
            _dbContext = dbContext;
        }

        public async Task<int> GetNewId()
        {
            try
            {
                var maxId = await _dbContext!.Database
                        .ExecuteSqlRawAsync("SELECT MAX(Id) FROM Items");

                return maxId + 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
