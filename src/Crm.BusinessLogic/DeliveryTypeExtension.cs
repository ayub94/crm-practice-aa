using Crm.DataAccess;

namespace Crm.BusinesLogic;

public static class DeliveryTypeExtension
{
    public static DeliveryType ToDeliveryTypeEnum(this string deliveryTypeStr)
    => Enum.Parse<DeliveryType>(deliveryTypeStr);
}