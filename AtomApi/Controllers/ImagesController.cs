using System.Threading.Tasks;
using AtomApi.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AtomApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ImagesController:ControllerBase
    {
        private ILogger<ImagesController> _logger;
        public ImagesController(ILogger<ImagesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [ResponseCache(Duration=120)]
        public async Task<IActionResult> GetImages(AtomImageSpecificationViewModel imageSpecification)
        {
            _logger.LogInformation("We are trying to get images based on an image spec");

            if(imageSpecification==null)
            {
                return NotFound();
            }

            return Ok();
        }
    }
}
