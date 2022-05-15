using Microsoft.AspNetCore.Mvc;
using ServiceLayer.DTOs.Brand;
using ServiceLayer.Services.Interfaces;
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

        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> Create([FromBody] BrandDto brandDto)
        {
            await _service.CreateAsync(brandDto);
            return Ok();
        }
    }
}
