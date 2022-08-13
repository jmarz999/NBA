using Microsoft.AspNetCore.Mvc;

namespace NBA.Controllers
{
    [Route("api/[controller]")]
    [ApiExplorerSettings(IgnoreApi = true)]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public ActionResult Home()
        {
            return new RedirectResult("~/swagger");
        }
    }
}
