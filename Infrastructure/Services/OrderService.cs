namespace Domain;

using Microsoft.EntityFrameworkCore;
public class OrderService
{
            readonly DataContext context;
            public OrderService(  DataContext context)
            {
                this.context=context;
            }
     public  Task<List<Order>> GetOrders()
    {
        return  context.Orders.ToListAsync();
        
    }

}


  