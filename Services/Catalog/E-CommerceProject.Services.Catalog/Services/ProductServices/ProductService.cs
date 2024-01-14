using AutoMapper;
using E_CommerceProject.Services.Catalog.Dtos.ProductDtos;
using E_CommerceProject.Services.Catalog.Models;
using E_CommerceProject.Services.Catalog.Settings;
using MongoDB.Driver;

namespace E_CommerceProject.Services.Catalog.Services.ProductServices
{
    public class ProductService : IProductService
    {
        private readonly IMongoCollection<Product> _productCollection;
        private readonly IMapper _mapper;

        public ProductService(IMapper mapper, IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _productCollection = database.GetCollection<Product>(_databaseSettings.ProductCollectionName);
            _mapper = mapper;
        }

        public Task CreateProductAsync(CreateProductDto createProductDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteProductAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResultProductDto>> GetAllProductsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ResultProductDto> GetProductAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateProductAsync(UpdateProductDto updateProductDto)
        {
            throw new NotImplementedException();
        }
    }
}
