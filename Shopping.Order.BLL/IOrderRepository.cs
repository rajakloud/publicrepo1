

namespace Shopping.Oder.BLL
{
    public interface IOrderRepository
    {
        public string CreateOrder(Order.BLL.Entities.Order ord);
    }
}