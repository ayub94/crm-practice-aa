namespace Crm.Entities;

public readonly struct OrderInfo
 {
    public readonly long Id { get; init; }
    public readonly string OrderDescription { get; init; }
    public readonly float Price { get; init; }
    public readonly string Date  { get; init; }
    public readonly string DeliveryType { get; init; }
    public readonly string DeliveryAddress { get; init; }

    public OrderInfo (
         string orderDescription,
         float price,
         string date,
         string deliveryType,
         string deliveryAddress
    )
   {
        OrderDescription = orderDescription;
        Price = price;
        Date = date;
        DeliveryType =deliveryType;
        DeliveryAddress = deliveryAddress;
    }
}