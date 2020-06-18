using System.Collections.Generic;
using System.Threading.Tasks;
using Foodstock.Domain.Models;

namespace Foodstock.Service.Interfaces
{
    public interface ICategoryService
    {
        public Task<IEnumerable<Category>> GetAllCategories();
    }
}
