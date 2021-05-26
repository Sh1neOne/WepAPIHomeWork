using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication.Entities;
using WebApplication.Interface;

namespace WepAPIHomeWork.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    { 
        private readonly IProductData _repository;

        public ValuesController(IProductData rep)
        {
            this._repository = rep;
        }

        [HttpGet]
        [Route("GetProducts")]
        public async Task<List<Product>> GetProducts()
        {
            return await _repository.GetProductsAsync();
        }

        [HttpGet]
        [Route("GetProduct/{id}")]
        public async Task<Product> GetProductById(int id)
        {
            return await _repository.GetProductByIdAsync(id);
        }

        [HttpPost]
        [Route("AddProduct")]
        public async Task<int> AddProduct([FromBody] Product product)
        {
            return await _repository.SaveProductAsync(product);
        }

        [HttpDelete]
        [Route("DeleteProuct/{id}")]
        public async Task<int> DeleteProduct(int id)
        {
            return await _repository.DeleteProductAsync(id);
        }

    }
}
