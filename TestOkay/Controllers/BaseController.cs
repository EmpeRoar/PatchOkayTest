using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestOkay.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public abstract class BaseController<M> :  ControllerBase
        where M : class
    {
        public BaseController()
        {

        }

        [HttpGet]
        public virtual async Task<IActionResult> Get()
        {
            return Ok();
        }

        [HttpPatch]
        public virtual async Task<IActionResult> Patch(int ID, JsonPatchDocument<M> patchDoc)
        {
            return Ok();
        }
    }
}
