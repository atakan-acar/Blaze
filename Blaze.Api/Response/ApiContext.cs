using Blaze.Application.Common.Models;
using Microsoft.AspNetCore.Mvc;

namespace Blaze.Api.Response
{
    public static class ApiContext
    {
        public static IActionResult Response(BaseResponse response)
        {
            if (response.IsSuccess) return new OkObjectResult(response);

            return new BadRequestObjectResult(response);
        }
    }
}
