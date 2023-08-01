using Crm.Entities;

namespace Crm.Services;

public sealed class OrderService
{
    public Order CreateOrder(OrderInfo orderInfo)
    {
         return new()
        {
            OrderDescription =orderInfo.OrderDescription,
            Price = orderInfo.Price,
            Date = orderInfo.Date,
            DeliveryType = orderInfo.DeliveryType,
            DeliveryAddress = orderInfo.DeliveryAddress
        };

    }
}


