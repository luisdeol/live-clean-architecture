using LiveCleanArchitecture.Core.Entities;

namespace LiveCleanArchitecture.Core.Interfaces.Repositories
{
    public interface IProductRepository
    {
        Product GetById(int id);
        void Add(Product product);
    }
}
