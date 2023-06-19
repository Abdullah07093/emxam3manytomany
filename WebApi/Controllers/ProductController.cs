using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    private readonly ProductController productController;
    public ProductController(ProductController productController)
    {
        this.productController=productController;
    }

}