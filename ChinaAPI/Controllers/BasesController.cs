using System.Security.Claims;
using ChinaAPI_BAL.BaseBAL;
using ChinaAPICommon;
using ChinaAPICommon.DTO;
using ChinaAPICommon.Enum;
using ChinaAPICommon.Untilities;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Mvc;

namespace ChinaAPI.Controllers
{
    [Route("api/[controller]")]
    public class BasesController<T> : ControllerBase where T : class
    {
        #region fileds

        private readonly IBaseBAL<T> _baseBAL;

        #endregion

        #region constructor

        protected BasesController(IBaseBAL<T> baseBAL)
        {
            _baseBAL = baseBAL;
        }

        #endregion

        [HttpGet("{recordId}")]
        public async Task<IActionResult> GetRecordById(int recordId)
        {
            try
            {
                var record = await _baseBAL.GetRecordById(recordId);

                // Kiểm tra quyền hạn trước khi xử lý
                //var claimsIdentity = HttpContext.User.Identity as ClaimsIdentity;
                //if (!HasPermission(claimsIdentity!))
                //{
                //    return Unauthorized();
                //}

                return Ok(record);
            }
            catch (Exception ex)
            {
                return HandleException(ex);
            }
        }

        [HttpGet]
        public virtual async Task<IActionResult> GetAllRecord()
        {
            try
            {
                var records = await _baseBAL.GetAllRecord();

                // Kiểm tra quyền hạn trước khi xử lý
                //var claimsIdentity = HttpContext.User.Identity as ClaimsIdentity;
                //if (!HasPermission(claimsIdentity!))
                //{
                //    return Unauthorized();
                //}

                return Ok(records);
            }
            catch (Exception ex)
            {
                return HandleException(ex);
            }
        }

        [HttpGet("PagingAndFilter")]
        public virtual async Task<IActionResult> GetRecordPagingAndFilter(
            int limit, int offset, string? keyword)
        {
            try
            {
                var records = await _baseBAL.GetFilter(keyword, limit, offset);

                // Kiểm tra quyền hạn trước khi xử lý
                //var claimsIdentity = HttpContext.User.Identity as ClaimsIdentity;
                //if (!HasPermission(claimsIdentity!))
                //{
                //    return Unauthorized();
                //}

                return Ok(records);
            }
            catch (Exception ex)
            {
                return HandleException(ex);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Insert([FromForm] T record, IFormFile? file)
        {
            // Kiểm tra quyền hạn trước khi xử lý
            //var claimsIdentity = HttpContext.User.Identity as ClaimsIdentity;
            //if (!HasPermission(claimsIdentity!))
            //{
            //    return Unauthorized();
            //}
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var result = await _baseBAL.Insert(record, file);
                if (result.IsSuccess == false)
                {
                    return StatusCode(StatusCodes.Status400BadRequest, new DialogMessage
                    {
                        ErrorCode = MyErrorCode.RecordByIdNotExist,
                        UserMsg = ResourceChinaApi.InsertError,
                        DevMsg = ResourceChinaApi.InsertError,
                        TradeId = HttpContext.TraceIdentifier
                    });
                }

                return StatusCode(StatusCodes.Status201Created, new DialogMessage
                {
                    DevMsg = ResourceChinaApi.InsertSuccess,
                    UserMsg = ResourceChinaApi.InsertSuccess
                });
            }
            catch (Exception ex)
            {
                return HandleException(ex);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateRecord(int id, [FromForm] T record, IFormFile? file)
        {
            // Kiểm tra quyền hạn trước khi xử lý
            //var claimsIdentity = HttpContext.User.Identity as ClaimsIdentity;
            //if (!HasPermission(claimsIdentity!))
            //{
            //    return Unauthorized();
            //}

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var recordUpdate = await _baseBAL.Update(id, record, file!);
                if (recordUpdate.IsSuccess == false)
                {
                    return StatusCode(StatusCodes.Status404NotFound, new DialogMessage
                    {
                        ErrorCode = MyErrorCode.UpdateNotExist,
                        DevMsg = ResourceChinaApi.UpdateNotExist,
                        UserMsg = ResourceChinaApi.UpdateNotExist,
                        TradeId = HttpContext.TraceIdentifier
                    });
                }

                return StatusCode(StatusCodes.Status200OK, new DialogMessage
                {
                    DevMsg = ResourceChinaApi.UpdateSuccess,
                    UserMsg = ResourceChinaApi.UpdateSuccess,
                });
            }
            catch (Exception ex)
            {
                return HandleException(ex);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRecordById(int id)
        {
            // Kiểm tra quyền hạn trước khi xử lý
            //var claimsIdentity = HttpContext.User.Identity as ClaimsIdentity;
            //if (!HasPermission(claimsIdentity!))
            //{
            //    return Unauthorized();
            //}

            try
            {
                var record = await _baseBAL.DeleteById(id);
                if (record.IsSuccess == true)
                {
                    return StatusCode(StatusCodes.Status200OK, new DialogMessage
                    {
                        UserMsg = ResourceChinaApi.DeleteSuccess,
                        DevMsg = ResourceChinaApi.DeleteSuccess
                    });
                }

                return StatusCode(StatusCodes.Status404NotFound, new DialogMessage
                {
                    ErrorCode = MyErrorCode.DeleteNotExist,
                    DevMsg = ResourceChinaApi.DeleteNotExist,
                    UserMsg = ResourceChinaApi.DeleteNotExist,
                    TradeId = HttpContext.TraceIdentifier
                });
            }
            catch (Exception ex)
            {
                return HandleException(ex);
            }
        }

        [HttpDelete("BatchDelete")]
        public async Task<IActionResult> DeleteManyRecord(List<int> recordIds)
        {

            // Kiểm tra quyền hạn trước khi xử lý
            //var claimsIdentity = HttpContext.User.Identity as ClaimsIdentity;
            //if (!HasPermission(claimsIdentity!))
            //{
            //    return Unauthorized();
            //}

            try
            {
                var records = await _baseBAL.BatchDelete(recordIds);
                if (records.IsSuccess == true)
                {
                    return StatusCode(StatusCodes.Status200OK, new DialogMessage()
                    {
                        UserMsg = ResourceChinaApi.DeleteSuccess,
                        DevMsg = ResourceChinaApi.DeleteSuccess
                    });
                }

                return StatusCode(StatusCodes.Status404NotFound, new DialogMessage
                {
                    ErrorCode = MyErrorCode.DeleteNotExist,
                    DevMsg = ResourceChinaApi.DeleteNotExist,
                    UserMsg = ResourceChinaApi.DeleteNotExist,
                    TradeId = HttpContext.TraceIdentifier
                });

            }
            catch (Exception ex)
            {
                return HandleException(ex);
            }
        }

        #region Exception

        protected IActionResult HandleException(Exception ex)
        {
            Console.WriteLine(ex.Message);
            return StatusCode(StatusCodes.Status500InternalServerError, new DialogMessage()
            {
                ErrorCode = MyErrorCode.Exception,
                DevMsg = ResourceChinaApi.ExceptionDevMsg,
                UserMsg = ResourceChinaApi.ExceptionUserMsg,
                MoreInfo = ex.Message,
                TradeId = HttpContext.TraceIdentifier
            });
        }

        #endregion

        #region protected
        protected bool HasPermission(ClaimsIdentity identity)
        {
            return PermissonChecked<T>.HasPermission(identity);
        }

        #endregion
    }
}
