using Microsoft.EntityFrameworkCore;

public class DataContext:DbContext
{
    public DataContext(DbContextOptions <DataContext> options): base(options)
    {
        
    }
    public DbSet<Customer> Costomers{get;set;}
    public DbSet<Order> Orders{get;set;}
    public DbSet<Product> Products{get;set;}
   
}