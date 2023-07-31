using Crm.Entities;

namespace Crm.Services;

public sealed class OrderService
{
    public Order CreateOrder(
        string orderDescription,
        float price,
        string date,
        string deliveryType,
        string deliveryAddress
    )
    {
         return new()
        {
            OrderDescription = orderDescription,
            Price = price,
            Date = date,
            DeliveryType = deliveryType,
            DeliveryAddress = deliveryAddress
        };

    }
}


