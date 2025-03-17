using Microsoft.AspNetCore.Mvc;
using Yang_BackEnd.API.Models;
using Yang_BackEnd.Application.Interfaces;
using Yang_BackEnd.Domain.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Yang_BackEnd.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        // POST api/<ProductsController>
        [HttpPost]
        public async Task<IActionResult> AddProduct([FromBody] AddProductModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var product = new Product
            {
                Name = model.Name,
                Price = model.Price,
                Description = model.Description,
            };
            var result = await _productService.CreateProductAsync(product);
            return Ok(result);
        }


    }
}
