using System.Threading.Tasks;

namespace Foodstock.Service.Interfaces
{
    public interface IProductService
    {
        Task<object> GetProductById(int Id);
    }
}
