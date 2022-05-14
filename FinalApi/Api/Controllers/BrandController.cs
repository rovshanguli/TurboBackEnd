using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    public class BrandController : BaseController
    {
        private readonly IBookService _service;
        public BrandController(IBookService service)
        {
            _service = service;
        }
    }
}
