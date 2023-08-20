namespace Crm.DataAccess;

public readonly struct OrderInfo
 {
     private readonly long _id;
     private readonly string _orderDescription;
     private readonly float _price;
     private readonly string _date;
     private readonly string _deliveryType;
     private readonly string _deliveryAddress;

    public readonly long Id
    { 
          get => _id;  
          init => _id = value < 0 ? value : throw new ArgumentNullException(nameof(value)); 
     }
    public readonly string OrderDescription 
    {
          get => _orderDescription ?? string.Empty ;  
          init => _orderDescription = value is  {Length: >0} ? value : throw new ArgumentNullException(nameof(value));
     }
    public readonly float Price
    {
          get => _price; 
          init =>  _price = value > 0 ? value : throw new ArgumentNullException(nameof(value)); 
    }
    public readonly string Date  
    {
          get => _date ?? string.Empty;
          init => _date = value is {Length: >0} ? value : throw new ArgumentNullException(nameof(value)); 
     }
    public readonly string DeliveryType 
    {
         get => _deliveryType ?? string.Empty; 
         init => _deliveryType = value is{Length: >0} ? value : throw new ArgumentNullException(nameof(value)); 
     }
    public readonly string DeliveryAddress 
    { 
         get => _deliveryAddress ?? string.Empty; 
         init => _deliveryAddress = value is{Length: >0} ? value : throw new ArgumentNullException(nameof(value)); 
     }

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