using apiweb.Data;
using apiweb.Entities;
using Microsoft.AspNetCore.Mvc;

namespace apiweb.Controllers
{
    [ApiController]
    [Route("api/Products")]
    public class ProductsController : Controller
    {
        private readonly StoreContext _context;
       
        public ProductsController(StoreContext context)
        {
            
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product> GetProducts()
        {

            var products = ContextBoundObject.Products.ToList();

            return Ok( products);
        }

    }
}
