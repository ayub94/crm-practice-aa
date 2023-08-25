namespace Crm.BusinesLogic;

public interface IOrderService
{
    public OrderInfo CreateOrder(OrderInfo orderInfo);   
    public OrderInfo GetOrder(string description);
    public OrderInfo GetOrderById(long id);
    public bool EditDescription(long id, string newDescription);
    public bool RemoveOrder(string description);
}
