namespace Crm.BusinesLogic;

public readonly record struct OrderInfo(long Id, string Description, float Price, string Date, string DeliveryType, string DeliveryAddress ) ;