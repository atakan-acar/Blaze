using Blaze.Application.Common;
using Microsoft.AspNetCore.Mvc;


namespace Blaze.Api.Controllers
{
    public class BaseApiController : ControllerBase
    {
        [HttpGet("widget/{entity}")]
        public virtual IActionResult Widget(string entity)
        {
            var widget = UIDrawer.Widget(entity);

            return Ok(widget);
        }
    }
}
