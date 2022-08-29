using System.Data;
using WebApp.Models.Services.Infrastructure;
using WebApp.Models.ViewModels;

namespace WebApp.Models.Services.Application
{
    public class AdoNetProductService : IProductService
    {
        private readonly IDatabaseAccessor db;
        public AdoNetProductService(IDatabaseAccessor db)
        {
            this.db = db;
        }
        public ProductDetailViewModel GetProduct(int id)
        {
            throw new NotImplementedException();
        }

        public List<ProductViewModel> GetProducts()
        {
            string query = "SELECT * FROM Products";
            DataSet dataSet = db.Query(query);

            throw new NotImplementedException();
        }
    }
}