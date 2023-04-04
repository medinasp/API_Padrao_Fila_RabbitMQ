namespace ApiWorkRabbitMQ.Models
{
    public sealed class Order
    {
        public int OrderNumber { get; set; }
        public string ItemName { get; set; }
        public int Price { get; set; }
    }
}
