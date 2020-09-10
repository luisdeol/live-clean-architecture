using LiveCleanArchitecture.Application.InputModels;
using LiveCleanArchitecture.Application.ViewModels;
using LiveCleanArchitecture.Core.Entities;
using LiveCleanArchitecture.Core.Interfaces.Repositories;

namespace LiveCleanArchitecture.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void Add(ProductInputModel productInputModel)
        {
            var product = new Product();

            _productRepository.Add(product);
        }

        public ProductViewModel GetById(int id)
        {
            var product = _productRepository.GetById(id);

            return new ProductViewModel(product.Title, product.Price);
        }
    }
}
