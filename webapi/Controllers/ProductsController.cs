// ===========================================================================
/// <summary>
/// ProductsController.cs
/// reactasp-shoper
/// created by Mehrdad Soleimanimajd on 07.08.2023
/// </summary>
/// <created>ʆϒʅ, 07.08.2023</created>
/// <changed>ʆϒʅ, 12.08.2023</changed>
// ===========================================================================

using Microsoft.AspNetCore.Mvc;
using webapi.Models;
using webapi_shoper.Data;
using webapi_shoper.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace webapi_shoper.Controllers
{
    [ApiController]
    //[Route("api/[controller]")]
    [Route("[controller]")]
    public class ProductsController: ControllerBase
    {

        //private readonly shoperSQLEContext _context;

        private static readonly string[] CategoriesArray = new[]
        {
            "Appliance", "Gadgets", "Tech", "Tools"
        };

        private readonly ILogger<ProductsController> _logger;

        public ProductsController(ILogger<ProductsController> logger)
        {
            _logger = logger;
        }

        //public ProductsController(shoperSQLEContext context)
        //{
        //    _context = context;
        //}

        // GET: api/<ProductsController>
        //[HttpGet("GetPro")]
        //public string Get()
        //{
        //    //var aa = _context.Products.First<Product>().Name;
        //    var aaa = CategoriesArray[0];
        //    return "valueAAA...";
        //    //servicep
        //}

        //// GET api/<ProductsController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<ProductsController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<ProductsController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<ProductsController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
