using Crm.DataAccess;
namespace Crm.Services;

abstract class OrderServices
{
    public List<Order> orders = new List<Order>();
    public abstract Order? CreateOrder(OrderInfo orderInfo);   
    public abstract Order? GetOrder(string description);
    public abstract Order? GetOrderById(string orderId);
    public abstract Order? EditDescription(string description, string newDescription);
    public abstract Order? DeleteOrder(string description);
}

class OrderService : OrderServices
{
    public override Order CreateOrder(OrderInfo orderInfo)
    {
         Order order = new()
        {
            Description =orderInfo.Description,
            Price = orderInfo.Price,
            Date = orderInfo.Date,
            DeliveryType = orderInfo.DeliveryType,
            DeliveryAddress = orderInfo.DeliveryAddress
        };

        orders.Add(order);
        
        return order;
    }  
    public override Order? GetOrder(string description)
    {
        if(description is not {Length: >0}) 
            throw new ArgumentOutOfRangeException(nameof(description));

        foreach(Order order in orders )
        {
            if(description.Equals(order.Description))
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
    public override Order? EditDescription(string description, string newDescription)
    {
        if(description is not {Length: >0}) 
            throw new ArgumentOutOfRangeException(nameof(description));

        foreach(Order order in orders )
        {
            if(description.Equals(order.Description))
            {
                order.Description = newDescription;
                 return order;

            }
             
        }
        return null;
    }
    public override Order? DeleteOrder(string description)
    {
         if(description is not {Length: >0}) 
            throw new ArgumentOutOfRangeException(nameof(description));

        foreach(Order order in orders )
        {
            if(description.Equals(order.Description))
            {
                orders.Remove(order);
                return order;
            }
              
        }
        return null;

    }
}


