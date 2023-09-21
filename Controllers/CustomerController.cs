using CustomerApi.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace CustomerApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CustomerController : Controller
{
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CustomerDto))]
    public async Task<List<IActionResult>> GetCustomers()
    {
        throw new NotImplementedException();
    }
    
    //api/customer/{Id}
    [HttpGet("{Id}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CustomerDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetCustomer(long Id)
    {
        var vacio = new CustomerDto();
        return new OkObjectResult(vacio);
    }
    
    [HttpDelete("{Id}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(bool))]
    public async Task<bool> DeletedCustomers(long Id)
    {
        throw new NotImplementedException();
    }
    
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(CustomerDto))]
    public async Task<IActionResult> CreateCustomer(CreateCustomerDtos customer)
    {
        var vacio = new CustomerDto();
        return new CreatedResult($"http://localhost:5251/api/customer/{vacio.Id}", null);
    }
    
    [HttpPut]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CustomerDto))]
    public async Task<IActionResult> UpdateCustomers(CustomerDto customer)
    {
        throw new NotImplementedException();
    }
}