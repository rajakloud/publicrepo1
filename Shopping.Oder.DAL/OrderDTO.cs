using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Oder.DAL
{
    public class OrderDTO
    {
        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public decimal Amount { get; set; }

    }
}
