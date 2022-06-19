using Microsoft.AspNetCore.Mvc;
using Week2.Api.Entities.Concrete;
using Week2.Api.Services.Abstract;

namespace Week2.Api.Controllers;

[ApiController]
[Route("[controller]s")]
public class ProductController : ControllerBase
{
    private readonly IProductService _productService;

    public ProductController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_productService.GetAll());
    }

    // [HttpGet("{id}")]
    // public IActionResult GetById(int id)
    // {
    //     return Ok(_productDal.GetById(id));
    // }

    [HttpPost]
    public IActionResult Add([FromBody]Product product)
    {
        if (!_productService.Add(product))
        {
            return BadRequest();
        }

        return StatusCode(201);
    }

    [HttpPut]
    public IActionResult Update([FromBody]Product product)
    {
        if(!_productService.Update(product))
        {
            return BadRequest();
        }

        return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        if(!_productService.Delete(id))
        {
            return BadRequest();
        }

        return Ok();
    }
}