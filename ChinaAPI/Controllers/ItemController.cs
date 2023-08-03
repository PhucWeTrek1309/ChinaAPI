using ChinaAPI_BAL.BaseBAL;
using ChinaAPICommon.Database;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChinaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : BasesController<ItemDb>
    {
        public ItemController(IBaseBAL<ItemDb> baseBL) : base(baseBL)
        {
        }
    }
}
