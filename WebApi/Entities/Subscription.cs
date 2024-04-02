namespace WebApi.Entities;

public class Subscription
{
    public int SubscriptionId { get; set; }
    public bool IsTrading { get; set; }
    
    public int ModelId { get; set; }
    public Model Model { get; set; }
    
    public int UserId { get; set; }
    public User User { get; set; }
}