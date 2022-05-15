using ServiceLayer.DTOs.Brand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IBrandService
    {
        Task CreateAsync(BrandDto brandDto);
    }
}
