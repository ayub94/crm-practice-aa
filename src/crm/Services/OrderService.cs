using Crm.Entities;

namespace Crm.Services;

public sealed class OrderService
{
    public List<Order> orders = new List<Order>();
    public Order CreateOrder(OrderInfo orderInfo)
    {
         Order order = new()
        {
            OrderDescription =orderInfo.OrderDescription,
            Price = orderInfo.Price,
            Date = orderInfo.Date,
            DeliveryType = orderInfo.DeliveryType,
            DeliveryAddress = orderInfo.DeliveryAddress
        };

        orders.Add(order);
        
        return order;

    }

    public Order GetOrder(string orderDescription)
    {
        if(orderDescription is not {Length: >0}) 
            throw new ArgumentOutOfRangeException(nameof(orderDescription));

        foreach(Order order in orders )
        {
            if(orderDescription.Equals(order.OrderDescription))
              return order;
        }
        return null;
    }

    public Order GetOrderById(string orderId)
    {
        if(orderId is not {Length: >0}) 
            throw new ArgumentOutOfRangeException(nameof(orderId));

        foreach(Order order in orders )
        {
            if(orderId.Equals(order.Id))
              return order;
        }
        return null;
    }
    
}


