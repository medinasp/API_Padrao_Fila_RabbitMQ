using RabbitMQ.Client.Events;
using RabbitMQ.Client;
using System.Text;
using AppOrderConsumer.Domain;

var factory = new ConnectionFactory { HostName = "localhost" };
using var connection = factory.CreateConnection();
using var channel = connection.CreateModel();

channel.QueueDeclare(queue: "orderQueue",
                     durable: false,
                     exclusive: false,
                     autoDelete: false,
                     arguments: null);

Console.WriteLine(" [*] Waiting for messages.");

var consumer = new EventingBasicConsumer(channel);
consumer.Received += (model, ea) =>
{
    try
    {
        var body = ea.Body.ToArray();
        var message = Encoding.UTF8.GetString(body);

        var order = System.Text.Json.JsonSerializer.Deserialize<Order>(message);

        Console.WriteLine($"Order: {order.OrderNumber} | {order.ItemName} | {order.Price:N2}");

        channel.BasicAck(ea.DeliveryTag, false); //caso de erro e caia no catch, a mensagem volta pra fila.

    }
    catch (Exception ex)
    {
        channel.BasicNack(ea.DeliveryTag, false, true); //caso de erro no try e cair no catch, enviar de volta para a fila  (acima)
    }
};
channel.BasicConsume(queue: "orderQueue",
                     autoAck: false, //colocar false para o consumidor não consumir a fila caso de erro no try
                     consumer: consumer);

Console.WriteLine(" Press [enter] to exit.");
Console.ReadLine();