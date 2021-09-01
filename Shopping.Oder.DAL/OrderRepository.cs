using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.ServiceBus;
using Newtonsoft.Json;
using Shopping.Oder.BLL;
using Shopping.Order.BLL;
using Shopping.Order.BLL.Entities;

namespace Shopping.Oder.DAL
{
    public class OrderRepository : IOrderRepository
    {

        public string CreateOrder(Shopping.Order.BLL.Entities.Order ord)
        {
            Task<string> result = PushOrderMessage(ord);
            return result.Result;
        }

        private async Task<string> PushOrderMessage(Shopping.Order.BLL.Entities.Order ord)
        {
            //IQueueClient queueClient = new QueueClient("QueueConnectionString", "QueueName");
            IQueueClient queueClient = new QueueClient("Endpoint=sb://raja-demo1.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=06Y9yubcKAH1ypnElDzuemTGa8CSmCCUj3KBJrDtaRo=", "Order");
            var orderJSON = JsonConvert.SerializeObject(ord);
            var orderMessage = new Message(Encoding.UTF8.GetBytes(orderJSON))
            {
                MessageId = Guid.NewGuid().ToString(),
                ContentType = "application/json"
            };
            await queueClient.SendAsync(orderMessage).ConfigureAwait(false);

            return "Create order message has been successfully pushed to queue with message Id " + orderMessage.MessageId;
        }
    }
}
