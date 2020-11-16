using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using AbaabaSystem.Utils;
using Microsoft.AspNetCore.Cors;

namespace AbaabaSystem.API.Controllers
{
    [EnableCors("AbaabaSystemCors")]
    [Route("api/[controller]")]
    [ApiController]
    public class VideoController : ControllerBase
    {
        BilibiliFetch bilibiliFetch = new BilibiliFetch();

        [HttpGet]
        [Route("{id}")]
        public JObject GetPopularVideo(int index)
        {
            return bilibiliFetch.GetBilibiliPopularVideo(index);
        }
    }
}
