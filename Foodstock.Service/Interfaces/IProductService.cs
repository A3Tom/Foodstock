using System.Threading.Tasks;
using Foodstock.Domain.Models;

namespace Foodstock.Service.Interfaces
{
    public interface IProductService
    {
        Task<Product> GetProductById(int productId);
    }
}
