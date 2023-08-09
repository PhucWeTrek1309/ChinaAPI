using ChinaAPI_BAL.BaseBAL;
using ChinaAPI_BAL.ItemBAL;
using ChinaAPICommon;
using ChinaAPICommon.Database;
using ChinaAPICommon.DTO;
using ChinaAPICommon.Enum;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace ChinaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : BasesController<ItemDb>
    {
        private readonly IItemBAL _itemBAL;
        public ItemController(IItemBAL baseBL) : base(baseBL)
        {
            _itemBAL = baseBL;
        }

        [HttpGet("GetNewId")]
        public IActionResult GetNewEmployeeCode()
        {
            try
            {
                var newCode = _itemBAL.GetNewId();

                if (newCode != null)
                {
                    return StatusCode(StatusCodes.Status200OK, newCode);
                }
                return StatusCode(StatusCodes.Status500InternalServerError, new DialogMessage
                {
                    ErrorCode = MyErrorCode.GetIdFail,
                    DevMsg = ResourceChinaApi.GetApiFail,
                    UserMsg = ResourceChinaApi.GetApiFail,
                    TradeId = HttpContext.TraceIdentifier
                });
            }
            catch (Exception ex)
            {

                return HandleException(ex);
            }
        }
    }
}
