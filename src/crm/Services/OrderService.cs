using Crm.DataAccess;
namespace Crm.Services;

abstract class OrderServices
{
    public List<Order> orders = new List<Order>();
    public abstract Order? CreateOrder(OrderInfo orderInfo);   
    public abstract Order? GetOrder(string orderDescription);
    public abstract Order? GetOrderById(string orderId);
    public abstract Order? EditOrderDescription(string orderDescription, string newOrderDescription);
    public abstract Order? DeleteOrder(string orderDescription);
}

class OrderService : OrderServices
{
    public override Order CreateOrder(OrderInfo orderInfo)
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
    public override Order? GetOrder(string orderDescription)
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
     public override Order? GetOrderById(string orderId)
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
    public override Order? EditOrderDescription(string orderDescription, string newOrderDescription)
    {
        if(orderDescription is not {Length: >0}) 
            throw new ArgumentOutOfRangeException(nameof(orderDescription));

        foreach(Order order in orders )
        {
            if(orderDescription.Equals(order.OrderDescription))
            {
                order.OrderDescription = newOrderDescription;
                 return order;

            }
             
        }
        return null;
    }
    public override Order? DeleteOrder(string orderDescription)
    {
         if(orderDescription is not {Length: >0}) 
            throw new ArgumentOutOfRangeException(nameof(orderDescription));

        foreach(Order order in orders )
        {
            if(orderDescription.Equals(order.OrderDescription))
            {
                orders.Remove(order);
                return order;
            }
              
        }
        return null;

    }
}


