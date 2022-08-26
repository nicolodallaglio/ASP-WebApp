using WebApp.Models.ViewModels;

namespace WebApp.Models.Services.Application
{
    public interface IProductService
    {
        List<ProductViewModel> GetProducts();
        ProductDetailViewModel GetProduct(int id);
    }
}