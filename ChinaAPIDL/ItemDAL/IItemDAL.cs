using ChinaAPI_DAL.BaseDAL;
using ChinaAPICommon.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinaAPI_DAL.ItemDAL
{
    public interface IItemDAL : IBaseDAL<ItemDb>
    {
        Task<int> GetNewId();
    }
}
