using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class OrderController : ControllerBase
{

private readonly OrderController orderController;
public OrderController(OrderController orderController)
{
    this.orderController=orderController;
}

  [HttpGet("GetOrders")]

public async Task<List<Order>> GetOrders(){
    return await orderController.GetOrders();
}

}