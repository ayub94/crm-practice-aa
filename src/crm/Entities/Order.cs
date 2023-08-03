namespace Crm.Entities;
public sealed class Order
{
    public long Id { get; init; }
    public required string OrderDescription {get; init; }
    public float Price { get; init; }
    public required string Date { get; init; }
    public required string DeliveryType { get; init; }
    public required string DeliveryAddress{ get; init; }
}
