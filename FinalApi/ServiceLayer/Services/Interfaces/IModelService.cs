using ServiceLayer.DTOs.Brand;
using ServiceLayer.DTOs.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IModelService
    {
        Task CreateAsync(ModelCreateDto modelCreateDto);
        Task<List<BrandGetDto>> GetAllAsync();
        Task<BrandGetDto> GetByIdAsync(int id);
        Task SoftDeleteAsync(int id);
    }
}
