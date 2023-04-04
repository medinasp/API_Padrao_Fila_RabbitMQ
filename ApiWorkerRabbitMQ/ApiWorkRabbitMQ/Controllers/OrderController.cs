using ApiWorkRabbitMQ.Models;
using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RabbitMQ.Client;
using System.Text;
using System.Text.Json;

namespace ApiWorkRabbitMQ.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private ILogger<OrderController> _logger;

        public OrderController(ILogger<OrderController> logger)
        {
            _logger = logger;
        }

        [Produces("application/json")]
        [HttpPost("/api/Order")]
        public IActionResult Order(Order order)
        {
            try
            {
                #region Inserir na fila
                var factory = new ConnectionFactory { HostName = "localhost" };
                using var connection = factory.CreateConnection();
                using var channel = connection.CreateModel();

                channel.QueueDeclare(queue: "orderQueue",
                                     durable: false,
                                     exclusive: false,
                                     autoDelete: false,
                                     arguments: null);

                string message = JsonSerializer.Serialize(order);
                var body = Encoding.UTF8.GetBytes(message);

                channel.BasicPublish(exchange: string.Empty,
                                     routingKey: "orderQueue",
                                     basicProperties: null,
                                     body: body);
                #endregion
                return Accepted(order);
            }
            catch (Exception ex)
            {
                _logger.LogError("Pedido não processado", ex);
                return new StatusCodeResult(500);
            }
        }
    }
}
