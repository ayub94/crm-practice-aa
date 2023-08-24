namespace Crm.DataAccess;
public sealed class Order
{
    public long Id { get; set; }
    public required string OrderDescription {get; set; }
    public float Price { get; set; }
    public required string Date { get; set; }
    public required string DeliveryType { get; set; }
    public required string DeliveryAddress{ get; set; }
}
