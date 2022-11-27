using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBMatrodicFitness.Data;
using EntityMetrodicFitness.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{

    [ApiController]
    [Route("api/[Controller]")]
    public class ProductController : ControllerBase
    {
        public readonly StoreContext _storecontext;
        public ProductController(StoreContext storeContext)
        {
            _storecontext = storeContext;
        }

        [HttpGet]
        /*public IActionResult Index()
        {
            var products = new Product{ 1, "one" }; 
            return List<prod>
        }*/

        public async Task<ActionResult<List<Product>>> GetProducts()
        {

            var products = await _storecontext.Products.ToListAsync();

            return Ok(products);
        
        
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {

            return Ok(await _storecontext.Products.FindAsync(id));

        }





    }
}
