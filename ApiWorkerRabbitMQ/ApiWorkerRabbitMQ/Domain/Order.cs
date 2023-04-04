namespace ApiWorkerRabbitMQ.Domain
{
    public sealed class Order
    {
        public int OrderNumber { get; set; }
        public int ItemName { get; set; }
        public int Price { get; set; }
    }
}
