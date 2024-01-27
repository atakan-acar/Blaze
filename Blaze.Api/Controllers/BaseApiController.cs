using Blaze.Application.Common;
using Blaze.Application.Entities.Projects;
using Microsoft.AspNetCore.Mvc;


namespace Blaze.Api.Controllers
{
    public abstract class BaseApiController : ControllerBase
    {
        [HttpGet("e-widget/{entity}")]
        public virtual IActionResult WidgetRender(string entity = nameof(Product))
        {
            var widget = UIDrawer.Widget(entity);

            return Blaze.Api.Response.ApiContext.Response(widget);
        }

        [HttpGet("e-form/{entity}")]
        public virtual IActionResult Form(string entity = nameof(Product))
        {
            var widget = UIDrawer.Form(entity);

            return Blaze.Api.Response.ApiContext.Response(widget);
        }


        [HttpGet("e-information/{entity}")]
        public virtual IActionResult Information(string entity = nameof(Product))
        {
            var widget = UIDrawer.Information(entity);

            return Blaze.Api.Response.ApiContext.Response(widget);
        }
    }
}
