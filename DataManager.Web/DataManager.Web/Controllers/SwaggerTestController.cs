using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DataManager.Web.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SwaggerTestController : ControllerBase
    {
        /// <summary>
        /// 这是一个Swagger测试接口
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Test()
        {
            return new JsonResult(new {key = "Name", value = "test"});
        }
    }
}