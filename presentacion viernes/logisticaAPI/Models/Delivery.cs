namespace LogisticaAPI.Models;

public class Delivery
{
    public int DeliveryId { get; set; }

    public int OrderId { get; set; }
    public Order Order { get; set; }

    public int DeliveryUserId { get; set; }
    public User DeliveryUser { get; set; }

    public DateTime? DeliveredAt { get; set; }
}