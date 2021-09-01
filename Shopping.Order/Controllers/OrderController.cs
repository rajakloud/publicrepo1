using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Shopping.Order.BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Order.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly ILogger<OrderController> logger;
        private readonly IOrderService orderService;

        public OrderController(ILogger<OrderController> logger, IOrderService orderService)
        {
            this.logger = logger;
            this.orderService = orderService;
        }

        [HttpPost]
        public IActionResult CreateOrder([FromBody] Order.BLL.Entities.Order ord)
        {
            string result = orderService.CreateOrder(ord);

            return Ok(result);
        }
    }
}
