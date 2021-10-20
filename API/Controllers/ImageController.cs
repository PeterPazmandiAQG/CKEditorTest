using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Web.Http;

namespace API.Controllers
{
    [Route("[controller]")]
    public class ImageController : Controller
    {
        [Route("Upload")]
        [HttpPost]
        public async Task<object> Upload()
        {
            try
            {
                var file = HttpContext.Curr
            }
            catch(Exception ex)
            {
                return Task.FromResult(new
                {
                    error = new { message = ex.Message }
                });
            }
        }
    }
}