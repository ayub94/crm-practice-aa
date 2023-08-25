using Crm.DataAccess;

namespace Crm.BusinesLogic;


public sealed class OrderService : IOrderService
{
    private readonly List<Order> _orders;

    private long _id =0;

    public OrderService()
    {
        _orders = new();
    }
    
    public OrderInfo CreateOrder(OrderInfo orderInfo)
    {
         Order newOrder = new()
        {
            Id =_id++,
            Description =orderInfo.Description,
            Price = orderInfo.Price,
            Date = orderInfo.Date,
            DeliveryType = orderInfo.DeliveryType,
            DeliveryAddress = orderInfo.DeliveryAddress
        };

        _orders.Add(newOrder);
        
        return orderInfo with { Id = newOrder.Id };
    }  
    public OrderInfo GetOrder(string description)
    {
        if(description is not {Length: >0}) 
            throw new ArgumentOutOfRangeException(nameof(description));

        Order? order = _orders.Find(c => c.Description.Equals(description)) ?? throw new NotFoundException();
        return order.ToOrderInfo();
    }
    public OrderInfo GetOrderById(long id)
    {
       Order? order = _orders.Find(c=> c.Id == id ) ?? throw new NotFoundException();
        return order.ToOrderInfo(); ;
    }

    public bool EditDescription(long id, string newDescription)
    {
        Order? order = _orders.Find(c=> c.Id == id ) ?? throw new NotFoundException();
        if(order is null) return false;

        order.Description = newDescription;
        return true;
    }
    public bool RemoveOrder(string description)
    {
         if(description is not {Length: >0}) 
            throw new ArgumentOutOfRangeException(nameof(description));

        int orderIndex = _orders.FindIndex(c => c.Description.Equals(description) );
        if (orderIndex < 0)
            return false;

        _orders.RemoveAt(orderIndex);
        
        return true;
    }
}


   
    
     
    
    