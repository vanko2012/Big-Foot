namespace big_foot.Data
{
    public class Order
    {
        public int Id { get; set; }
        //M:1
        public string ProductId { get; set; }
        public Product Products { get; set; }
        //M:1
        public string CustomerId { get; set; }
        public Customer Customers { get; set; }

        public DateTime Register_On { get; set; }
    }
}
