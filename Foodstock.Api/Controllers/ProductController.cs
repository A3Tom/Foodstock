using System;
using System.Threading.Tasks;
using Foodstock.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Foodstock.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> GetProduct(int productId)
        {
            var product = await _productService.GetProductById(productId);

            return Ok(product);
        }
    }
}
