using ChinaAPI_BAL.BaseBAL;
using ChinaAPI_DAL.BaseDAL;
using ChinaAPI_DAL.ItemDAL;
using ChinaAPICommon.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinaAPI_BAL.ItemBAL
{
    public class ItemBAL : BaseBAL<ItemDb>, IItemBAL
    {

        private IItemDAL _item;
        public ItemBAL(IItemDAL baseDAL) : base(baseDAL)
        {
            _item = baseDAL;
        }

        public async Task<int> GetNewId()
        {
            var newId = await _item.GetNewId();
            return newId;
        }
    }
}
