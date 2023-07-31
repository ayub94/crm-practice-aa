namespace Crm.Entities;
public sealed class Order
{
    public long Id { get; set; }
    public string OrderDescription { get; set; }
    public float Price { get; set; }
    public string Date { get; set; }
    public string DeliveryType { get; set; }
    public string DeliveryAddress{ get; set; }
}
