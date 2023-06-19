public class CustomerService
{
        readonly DataContext context;
        public CustomerService( DataContext context)
        {
            this.context=context;
        }

}