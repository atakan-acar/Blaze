using Microsoft.AspNetCore.Mvc;


namespace Blaze.Api.Controllers
{
    public class ProductController : BaseApiController
    {

        [HttpGet("widget/product-widget")]
        public override IActionResult Widget(string entity)
        {
            return Ok("product-widget");
        }
    }
}
