using System.Threading.Tasks;
using Foodstock.Service.Interfaces;

namespace Foodstock.Service.Classes
{
    public class ProductService : IProductService
    {
        public Task<object> GetProductById(int Id)
        {
            throw new System.NotImplementedException();
        }
    }
}
