using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestOkay.Model;

namespace TestOkay.Controllers
{
    public class ItemController : BaseController<Item, int>
    {
        public ItemController()
        {

        }

    }
}
