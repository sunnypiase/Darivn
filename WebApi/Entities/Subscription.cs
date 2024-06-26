namespace WebApi.Entities;

public class Subscription : IDbEntity
{
    public int SubscriptionId { get; set; }
    public bool IsTrading { get; set; }
    
    public int ModelId { get; set; }
    public Model Model { get; set; }
    
    public int UserId { get; set; }
    public User User { get; set; }
    public int GetId() => SubscriptionId;
}