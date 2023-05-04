using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")] //[controller] stands for controller name without controller
   // in this case Users. 
    public class BaseApiController : ControllerBase
    {
        
    }
}