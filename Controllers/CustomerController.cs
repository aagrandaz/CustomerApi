using CustomerApi.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace CustomerApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CustomerController : Controller
{
    [HttpGet]
    public async Task<List<CustomerDto>> GetCustomers()
    {
        throw new NotImplementedException();
    }
    
    //api/customer/{Id}
    [HttpGet("{Id}")]
    public async Task<CustomerDto> GetCustomer(long Id)
    {
        throw new NotImplementedException();
    }
    
    [HttpDelete]
    public async Task<bool> DeletedCustomers(long Id)
    {
        throw new NotImplementedException();
    }
    
    [HttpPost]
    public async Task<CustomerDto> CreateCustomer(CreateCustomerDtos customer)
    {
        throw new NotImplementedException();
    }
    
    [HttpPut]
    public async Task<CustomerDto> UpdateCustomers(CustomerDto customer)
    {
        throw new NotImplementedException();
    }
}