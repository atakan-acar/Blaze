using Microsoft.AspNetCore.Mvc;

namespace Blaze.Api.Controllers
{
    public class ProductController : BaseApiController
    {
        [HttpGet("p-widget")]
        public override IActionResult WidgetRender(string entity)
        {
            return base.WidgetRender(entity);
        }

        [HttpGet("p-form")]
        public override IActionResult Form(string entity)
        {
            return base.Form(entity);
        }
    }
}
