using AutoMapper;
using DomainLayer.Entities;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.DTOs.Brand;
using ServiceLayer.Services.Interfaces;
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
        public async Task CreateAsync(BrandDto brandDto)
        {
            var model = _mapper.Map<Brand>(brandDto);
            await _repository.CreateAsync(model);
        }
    }
}
