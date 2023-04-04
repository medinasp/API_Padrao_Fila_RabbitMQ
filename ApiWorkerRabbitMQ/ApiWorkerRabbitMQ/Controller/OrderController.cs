using ApiWorkerRabbitMQ.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiWorkerRabbitMQ.Controller
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private ILogger<OrderController> _logger;

        public OrderController(ILogger<OrderController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public IActionResult InsertOrder(Order order)
        {
            try
            {
                return Accepted();
            }
            catch (Exception ex)
            {
                _logger.LogError("Pedido não processado", ex);
                return new StatusCodeResult(500);
            }
        }
    }
}
