using AutoMapper;
using DomainLayer.Entities;
using RepositoryLayer.Repositories;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.DTOs.Brand;
using ServiceLayer.DTOs.Model;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class ModelService : IModelService
    {

        private readonly IModelRepository _repository;
        private readonly IMapper _mapper;

        public ModelService(IModelRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task CreateAsync(ModelCreateDto modelCreateDto)
        {
            var model = _mapper.Map<Model>(modelCreateDto);
            await _repository.CreateAsync(model);
        }

        public Task<List<BrandGetDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<BrandGetDto> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task SoftDeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
