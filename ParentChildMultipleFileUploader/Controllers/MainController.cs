using Microsoft.AspNetCore.Mvc;
using ParentChildMultipleFileUploader.Model;
using System.Text;

namespace ParentChildMultipleFileUploader.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MainController : ControllerBase
    {

        private readonly ILogger<MainController> _logger;

        public MainController(ILogger<MainController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public IActionResult UploadTest([FromForm] ParentChildRequest Data)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in Data.Children)
            {
                sb.AppendLine($"File Name: {item.Photo.FileName}");
            }

            return Ok(sb.ToString());
        }
    }
}
