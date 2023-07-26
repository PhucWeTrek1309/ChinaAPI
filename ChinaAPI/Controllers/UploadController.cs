using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChinaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadController : ControllerBase
    {
        private readonly Cloudinary _cloudinary;

        public UploadController(Cloudinary cloudinary)
        {
            _cloudinary = cloudinary;
        }

        [HttpPost("image")]
        public async Task<IActionResult> UploadImage(IFormFile file)
        {
            if (file == null || file.Length <= 0)
                return BadRequest("No file or invalid file provided.");

            var uploadParams = new ImageUploadParams
            {
                File = new FileDescription(file.FileName, file.OpenReadStream()),
                Folder = "Article"
            };

            var uploadResult = await _cloudinary.UploadAsync(uploadParams);

            string imageUrl = uploadResult.SecureUrl.ToString();

            Console.WriteLine(imageUrl);

            return Ok(uploadResult);
        }

        [HttpDelete("image")]
        public async Task<IActionResult> DeleteImage(string publicId)
        {
            if (string.IsNullOrEmpty(publicId))
                return BadRequest("Invalid public ID provided.");

            var deleteParams = new DeletionParams(publicId);

            var result = await _cloudinary.DestroyAsync(deleteParams);

            if (result.Result == "ok")
            {
                return Ok("Image deleted successfully.");
            }
            else
            {
                return BadRequest("Failed to delete image.");
            }
        }
    }
}
