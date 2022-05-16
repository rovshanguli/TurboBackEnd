using AutoMapper;
using DomainLayer.Entities;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.DTOs.Brand;
using ServiceLayer.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class BrandService : IBrandService
    {
        private readonly IBrandRepository _repository;
        private readonly IMapper _mapper;

        public BrandService(IBrandRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task CreateAsync(BrandCreateDto brandDto)
        {
            var model = _mapper.Map<Brand>(brandDto);
            await _repository.CreateAsync(model);
        }

        public async Task<List<BrandGetDto>> GetAllAsync()
        {
            var model = await _repository.GetAllAsync();
            var res = _mapper.Map<List<BrandGetDto>>(model);
            return res;
        }

        public async Task<BrandGetDto> GetByIdAsync(int id)
        {
            var model = await _repository.GetAsync(id);
            var res = _mapper.Map<BrandGetDto>(model);
            return res;
        }

        public async Task SoftDeleteAsync(int id)
        {
            var model = await _repository.GetAsync(id);
            await _repository.SoftDeleteAsync(model);
        }
    }
}
