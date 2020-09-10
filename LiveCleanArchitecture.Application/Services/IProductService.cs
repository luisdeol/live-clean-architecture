using LiveCleanArchitecture.Application.ViewModels;

namespace LiveCleanArchitecture.Application.Services
{
    public interface IProductService
    {
        ProductViewModel GetById(int id);
    }
}
