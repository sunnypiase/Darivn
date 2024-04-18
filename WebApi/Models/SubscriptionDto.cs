using WebApi.Entities;

namespace WebApi.Models;

public class SubscriptionDto: IDto<Subscription>
{
    public int SubscriptionId { get; set; }
    public bool IsTrading { get; set; }
    
    public int ModelId { get; set; }
    public int UserId { get; set; }
    public int GetId() => SubscriptionId;
}