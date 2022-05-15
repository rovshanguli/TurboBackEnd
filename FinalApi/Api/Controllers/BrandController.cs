using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    public class BrandController : BaseController
    {
        private readonly IBrandService _service;
        public BrandController(IBrandService service)
        {
            _service = service;
        }
    }
}
