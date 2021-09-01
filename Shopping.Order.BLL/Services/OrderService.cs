using Shopping.Oder.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Order.BLL.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }

        public string CreateOrder(Shopping.Order.BLL.Entities.Order ord)
        {
            return orderRepository.CreateOrder(ord);
        }
    }
}
