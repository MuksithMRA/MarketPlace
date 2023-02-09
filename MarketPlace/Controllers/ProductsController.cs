using MarketPlace.Dtos;
using MarketPlace.Dtos.Responses;
using MarketPlace.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MarketPlace.Controllers
{
[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    public readonly IProductService _productService;
    public ProductsController(IProductService productService) {
        _productService = productService;
    }

    // GET: api/<ProductsController>
    [HttpGet]
    public async Task<ActionResult> Get()
    {
        CommonResponse<List<ProductDTO>> response = await _productService.getAllProducts();

        if (response.StatusCode == StatusCodes.Status404NotFound)
        {
            return NotFound(response);
        }
        else if (response.StatusCode == StatusCodes.Status500InternalServerError)
        {
            return Problem(statusCode: response.StatusCode, detail: "Internal Server error");
        }
        else
        {
            return Ok(response);
        }
    }

    // GET api/<ProductsController>/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "value";
    }

    // POST api/<ProductsController>
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/<ProductsController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/<ProductsController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}
}
