using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestOkay.Model;

namespace TestOkay.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public abstract class BaseController<M, I> : ControllerBase
        where M : class, ICore<I>
        where I : struct, IConvertible
    {
        public BaseController()
        {

        }

        [HttpGet]
        public virtual async Task<IActionResult> Get()
        {
            return Ok();
        }

        [HttpPut("{ID}")]
        public virtual async Task<IActionResult> Put(I ID)
        {
            return Ok();
        }

        [HttpPatch("{ID}")]
        public virtual async Task<IActionResult> Patch(I ID, [FromBody] JsonPatchDocument<M> patchDoc)
        {
            return Ok();
        }
    }
}
