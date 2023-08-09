using ChinaAPI_BAL.BaseBAL;
using ChinaAPICommon.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinaAPI_BAL.ItemBAL
{
    public interface IItemBAL : IBaseBAL<ItemDb>
    {
        Task<int> GetNewId();
    }
}
