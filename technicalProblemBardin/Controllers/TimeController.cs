using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http;
using System.Net;
using Newtonsoft.Json;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimeController : ControllerBase
    {
        // GET api/time
        [HttpGet]
        public ActionResult<string> GetTime()
        {
            var time = DateTime.Now.ToString();
            return JsonConvert.SerializeObject(time);
        }
    }
}
