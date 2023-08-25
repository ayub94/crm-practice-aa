using Crm.DataAccess;
namespace Crm.BusinesLogic;

public static class OrderExtension
{
    public static OrderInfo ToOrderInfo(this Order order)
    {
        return new(
           order.Id,
           order.Description,
           order.Price,
           order.Date,
           order.DeliveryType.ToString(),
           order.DeliveryAddress);
    }
}
