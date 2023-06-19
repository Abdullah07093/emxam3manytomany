public class Order
{
        public int Id { get; set; }
        public TimeStamp OrderPlaced { get; set; }
        public TimeStamp OrderFulFilled { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }



}