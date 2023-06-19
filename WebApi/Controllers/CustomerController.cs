using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CustomerController : ControllerBase
{
private readonly CustomerController customerController;
public CustomerController(CustomerController customerController)
{
    this.customerController=customerController;
}


//   [HttpGet("GetCustomers")]

// public async Task<List<Country>> GetCustomers(){
//     return await countryService.GetCustomers();
// }


}