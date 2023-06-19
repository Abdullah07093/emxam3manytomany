using Microsoft.EntityFrameworkCore;

public class DataContext:DbContext
{
    public DataContext(DbContextOptions <DataContext> options): base(options)
    {
        
    }
    public DbSet<Costomer> Costomers{get;set;}
    public DbSet<Order> Orders{get;set;}
    public DbSet<OrderDitail> OrderDitails{get;set;}
    public DbSet<Product> Products{get;set;}
   
}