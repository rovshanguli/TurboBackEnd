using Microsoft.AspNetCore.Mvc;
using ServiceLayer.DTOs.Model;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    public class ModelController : BaseController
    {
        private readonly IModelService _service;
        public ModelController(IModelService service)
        {
            _service = service;
        }

        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> Create([FromBody] ModelCreateDto modelCreateDto)
        {
            await _service.CreateAsync(modelCreateDto);
            return Ok();
        }
    }
}
